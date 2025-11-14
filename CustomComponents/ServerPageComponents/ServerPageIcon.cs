using FastColoredTextBoxNS;
using SmartCodeLab.CustomComponents.GeneralComponents;
using SmartCodeLab.Models;
using SmartCodeLab.Models.Enums;
using SmartCodeLab.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCodeLab.CustomComponents.ServerPageComponents
{
    public partial class ServerPageIcon : RoundedUserControl
    {
        private Action<IPEndPoint> action;
        private LanguageSupported language;
        public ServerPageIcon(Server server,IPEndPoint point, Action<IPEndPoint> act)
        {
            InitializeComponent();
            taskName.Text = server.ServerName;
            subject.Text = server.programmingLanguage;
            action = act;
            language = server.ProgrammingLanguage;
            this.Click += (s, e) => ConnectServer(point);
        }

        private async void ConnectServer(IPEndPoint point)
        {
            if(language == LanguageSupported.Java)
            {//will check if java is installed in the user's computer
                var result = await isAvailable("java --version");
                bool isJavaNotRecognized = (result.Contains("'java' is not recognized as an internal or external command", StringComparison.OrdinalIgnoreCase));
                bool doesContainNeeded = result.Contains("java ") && result.Contains("Java(TM) SE Runtime Environment") && result.Contains("Java HotSpot(TM)");

                if (isJavaNotRecognized || !doesContainNeeded)
                {
                    MessageBox.Show("Java is not properly installed in your computer");
                    return;
                }

            }
            else if(language == LanguageSupported.Python)
            {
                var result = await isAvailable("py --version");
                bool isPythonNotFound = result.Contains("No installed Python found!", StringComparison.OrdinalIgnoreCase);

                if (isPythonNotFound)
                {

                    MessageBox.Show("Python is not properly installed in your computer");
                    return;
                }
            }
            action?.Invoke(point);
        }

        public async Task<string> isAvailable(string command)
        {
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            string totalOutput = string.Empty;
            process.OutputDataReceived += (s, e) =>
            {
                if (e.Data != null)
                {
                    totalOutput += e.Data + Environment.NewLine;
                }
            };

            process.ErrorDataReceived += (s, e) =>
            {
                if (e.Data != null)
                {
                    totalOutput += e.Data + Environment.NewLine;
                }
            };

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            await process.WaitForExitAsync();
            return totalOutput;
        }
    }
}
