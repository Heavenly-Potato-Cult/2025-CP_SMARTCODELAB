using ProtoBuf;
using SmartCodeLab.CustomComponents.ServerPageComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Services;
using System;
using System.Collections.Concurrent;
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
using Timer = System.Threading.Timer;

namespace SmartCodeLab.CustomComponents.Pages.SessionViewing
{
    public partial class SessionLogsPage : UserControl
    {
        private ConcurrentDictionary<string, ProgrammingSession> sessionsData;
        private long searchId;
        private Timer searchTimer;
        public SessionLogsPage()
        {
            InitializeComponent();
            searchId = 0;
            sessionsData = new ConcurrentDictionary<string, ProgrammingSession>();
            searchSess.innerTextBox.TextChanged += async (s, e) =>
            {
                searchTimer?.Change(Timeout.Infinite, Timeout.Infinite);

                searchTimer = new Timer(_ =>
                {
                    _ = showDisplayIcons();
                }, null, 300, Timeout.Infinite);
            };
        }

        private void SessionLogsPage_Load(object sender, EventArgs e)
        {
            // Start the heavy work on a background thread
            Task.Run(() =>
            {
                // 1. Create a list to hold the DATA (not the controls yet)
                sessionsData = new ConcurrentDictionary<string, ProgrammingSession>();

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
                                sessionsData.AddOrUpdate(session.server.ServerName,session,
                                    (key, value) => session);
                            }
                        }
                    }
                    catch (ProtoBuf.ProtoException ex)
                    {
                        // Handle Corrupted Data
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
                _ = showDisplayIcons();
            });
        }

        public void AddNewSession(ProgrammingSession newSession)
        {
            this.Invoke(new Action(() =>
            {
                sessionsData.AddOrUpdate(newSession.server.ServerName, newSession,
                                    (key, value) => newSession);
                _ = showDisplayIcons();
            }));
        }

        public async Task showDisplayIcons()
        {
            this.Invoke(new Action(() =>
            {
                // Freeze the layout engine to prevent flickering
                //sessionsContainer.SuspendLayout();
                try
                {
                    // Clear existing items
                    sessionsContainer.Controls.Clear();
                    long currentSearchId = ++searchId;
                    string search = searchSess.innerTextBox.Text.Trim().ToLower();
                    search = search == "Search Session" ? "" : search;
                    var filteredSessions = string.IsNullOrEmpty(search)
                        ? sessionsData.OrderByDescending(session => session.Value.server.createdAt).
                                        ToList()
                        : sessionsData.Where(session => session.Key.ToLower().Contains(search)).
                        OrderByDescending(session => session.Value.server.createdAt).
                        ToList();
                    // Convert the Data List into a Control List
                    foreach (var item in filteredSessions)
                    {
                        if (currentSearchId != searchId)
                            break; // A new search has started, abort this one

                        sessionsContainer.Controls.Add(new SessionLogsDisplay(item.Value));
                    }
                    //var controlsToAdd = sessionsData
                    //    .OrderByDescending(session => session.lastModified)
                    //    .Select(session => new SessionLogsDisplay(session))
                    //    .ToArray();
                    //// Add all controls in one go
                    //sessionsContainer.Controls.AddRange(controlsToAdd);
                }
                finally
                {
                    // Unfreeze and force an immediate repaint
                    sessionsContainer.ResumeLayout(true);
                }
            }));
        }
    }
}
