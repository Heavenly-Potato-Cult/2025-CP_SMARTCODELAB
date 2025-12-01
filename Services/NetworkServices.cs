using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Services
{
    public class NetworkServices
    {
        public static string GetLocalIPv4()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "No IPv4 address found";
        }

        public static IPAddress GetSubnetMaskForIP(IPAddress ipAddress)
        {
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.OperationalStatus != OperationalStatus.Up)
                    continue;

                IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();

                foreach (UnicastIPAddressInformation unicastAddress in ipProperties.UnicastAddresses)
                {
                    if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork &&
                        unicastAddress.Address.Equals(ipAddress))
                    {
                        return unicastAddress.IPv4Mask;
                    }
                }
            }

            return null; // IP address not found
        }

        public static string GetBroadcastAddress(string ipAddressString, string subnetMaskString)
        {
            try
            {
                // Parse IP address and subnet mask
                IPAddress ipAddress = IPAddress.Parse(ipAddressString);
                IPAddress subnetMask = IPAddress.Parse(subnetMaskString);

                // Convert to byte arrays
                byte[] ipBytes = ipAddress.GetAddressBytes();
                byte[] maskBytes = subnetMask.GetAddressBytes();

                // Calculate broadcast address: IP OR (NOT Mask)
                byte[] broadcastBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    broadcastBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);
                }

                return new IPAddress(broadcastBytes).ToString();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Invalid input: {ex.Message}");
            }
        }

        public static string ExtractBroadCastAddress()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c \"cd \"{SystemConfigurations.CONFIGURATION_FOLDER}\" && \"{ProgrammingConfiguration.javaExe}\" NetworkAddressExtractor\"",
                UseShellExecute = false,               // required for redirection
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            using (Process proc = new Process { StartInfo = processStartInfo })
            {
                string stdout = "";
                string stderr = "";

                proc.OutputDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                        stdout += e.Data + "\n";
                };

                proc.ErrorDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                        stderr += e.Data + "\n";
                };

                proc.Start();

                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();

                // Wait for full exit
                proc.WaitForExit();

                // Combine stdout + stderr (optional) or ignore stderr
                if (!string.IsNullOrWhiteSpace(stderr))
                {
                    // Optional: log or handle
                    MessageBox.Show("Java error: " + stderr);
                }

                return stdout.Trim();
            }
        }
    }
}
