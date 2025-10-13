using System.Diagnostics;

namespace SmartCodeLab
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConfigureFirewallRules();
            Application.Run(new MonitoringForm());
        }

        private static void ConfigureFirewallRules()
        {
            if (!FirewallRuleExists("Temp_Port"))
            {
                OpenNetshAsAdmin("advfirewall firewall add rule name=\"Temp_Port\" dir=in action=allow protocol=TCP localport=1901");
            }
            Debug.WriteLine(FirewallRuleExists("Temp_Port"));
            Debug.WriteLine(FirewallRuleExists("Temporary_Port_Allow"));
            if (!FirewallRuleExists("Temporary_Port_Allow"))
            {
                OpenNetshAsAdmin("advfirewall firewall add rule name=\"Temporary_Port_Allow\" dir=in action=allow protocol=UDP localport=1902");
            }
            // Clean up on application exit
            Application.ApplicationExit += (s, e) =>
            {
                if (FirewallRuleExists("Temporary_Port_Allow"))
                {
                    OpenNetshAsAdmin("advfirewall firewall delete rule name=\"Temp_Port\"");
                    OpenNetshAsAdmin("advfirewall firewall delete rule name=\"Temporary_Port_Allow\"");
                }
            };
        }


        private static bool FirewallRuleExists(string ruleName)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = $"advfirewall firewall show rule name=\"{ruleName}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    return output.Contains("Rule Name") && !output.Contains("No rules match");
                }
            }
            catch
            {
                return false;
            }
        }

        public static void OpenNetshAsAdmin(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = command,
                Verb = "runas", // This requests admin privileges
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Normal
            };

            try
            {
                Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // User cancelled the UAC prompt
                Console.WriteLine("Admin privileges required: " + ex.Message);
            }
        }
    }
}