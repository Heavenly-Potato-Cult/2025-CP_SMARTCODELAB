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

        /// <summary>
        /// Gets the broadcast address based on a given IP and subnet mask.
        /// </summary>

        /// <summary>
        /// Gets the local IPv4 broadcast address of the first active network interface.
        /// </summary>
        public static IPAddress? GetLocalBroadcastAddress()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up &&
                    ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    var ipProps = ni.GetIPProperties();

                    foreach (var addrInfo in ipProps.UnicastAddresses)
                    {
                        if (addrInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            return GetBroadcastAddress(addrInfo.Address, addrInfo.IPv4Mask);
                        }
                    }
                }
            }

            return null; // No active IPv4 interface found
        }

        public static IPAddress? GetWiFiIPv4()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Ensure interface is active, not loopback, and is Wi-Fi
                if (ni.OperationalStatus == OperationalStatus.Up &&
                    ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    var ipProps = ni.GetIPProperties();

                    var ipv4 = ipProps.UnicastAddresses
                        .FirstOrDefault(a => a.Address.AddressFamily == AddressFamily.InterNetwork)?.Address;

                    if (ipv4 != null)
                        return ipv4;
                }
            }

            return null; // No Wi-Fi IPv4 found
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
    }
}
