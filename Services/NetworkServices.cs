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
        public static string? GetIpv4()
        {
            return NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(n => n.OperationalStatus == OperationalStatus.Up &&
                        n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .SelectMany(n => n.GetIPProperties().UnicastAddresses)
            .Where(a => a.Address.AddressFamily == AddressFamily.InterNetwork)
            .Select(a => a.Address.ToString())
            .FirstOrDefault();
        }
        public static IPAddress? GetWiFiBroadcast()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up &&
                    ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    var unicast = ni.GetIPProperties().UnicastAddresses
                        .FirstOrDefault(a => a.Address.AddressFamily == AddressFamily.InterNetwork);

                    if (unicast == null)
                        continue;

                    return GetBroadcastAddress(unicast.Address, unicast.IPv4Mask);
                }
            }

            return null; // No Wi-Fi broadcast found
        }

        private static IPAddress GetBroadcastAddress(IPAddress ip, IPAddress mask)
        {
            byte[] ipBytes = ip.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();
            byte[] broadcast = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
                broadcast[i] = (byte)(ipBytes[i] | ~maskBytes[i]);

            return new IPAddress(broadcast);
        }

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
    }
}
