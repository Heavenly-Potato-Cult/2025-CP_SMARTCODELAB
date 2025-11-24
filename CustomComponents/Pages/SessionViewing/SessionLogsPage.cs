using ProtoBuf;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.Pages.SessionViewing
{
    public partial class SessionLogsPage : UserControl
    {
        public SessionLogsPage()
        {
            InitializeComponent();
        }

        private void SessionLogsPage_Load(object sender, EventArgs e)
        {
            // Start the heavy work on a background thread
            Task.Run(() =>
            {
                // 1. Create a list to hold the DATA (not the controls yet)
                var sessionsData = new List<ProgrammingSession>();

                // 2. Read and Deserialize files (Heavy I/O work)
                foreach (var item in Directory.EnumerateFiles(SystemConfigurations.SESSIONS_FOLDER))
                {
                    try
                    {
                        using (FileStream sessionFile = File.OpenRead(item))
                        {
                            var session = Serializer.DeserializeWithLengthPrefix<ProgrammingSession>(sessionFile, PrefixStyle.Base128);

                            if (session != null)
                            {
                                sessionsData.Add(session);
                            }
                        }
                    }
                    catch (ProtoBuf.ProtoException ex)
                    {
                        // Handle Corrupted Data
                        Debug.WriteLine($"ProtoException while deserializing session file '{item}': {ex.Message}");
                        try
                        {
                            var corruptPath = item + ".corrupt";
                            if (File.Exists(corruptPath)) File.Delete(corruptPath);
                            File.Move(item, corruptPath);
                        }
                        catch (Exception mex)
                        {
                            Debug.WriteLine($"Failed to move corrupted session file '{item}': {mex.Message}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error reading session file '{item}': {ex.Message}");
                    }
                }

                // 3. Update the UI exactly ONCE
                this.Invoke(new Action(() =>
                {
                    // Freeze the layout engine to prevent flickering
                    sessionsContainer.SuspendLayout();
                    try
                    {
                        // Clear existing items
                        sessionsContainer.Controls.Clear();

                        // Convert the Data List into a Control List
                        var controlsToAdd = sessionsData
                            .Select(session => new SessionLogsDisplay(session))
                            .ToArray();

                        // Add all controls in one go
                        sessionsContainer.Controls.AddRange(controlsToAdd);
                    }
                    finally
                    {
                        // Unfreeze and force an immediate repaint
                        sessionsContainer.ResumeLayout(true);
                    }
                }));
            });
        }
    }
}
