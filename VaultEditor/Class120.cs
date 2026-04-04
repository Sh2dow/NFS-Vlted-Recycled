using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace VaultEditor;

internal sealed class Class120
{
    public static DateTime smethod_0()
    {
        return DateTime.ParseExact(((HttpWebRequest)WebRequest.Create("http://www.microsoft.com")).GetResponse().Headers["date"], "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
    }

    public static DateTime smethod_1()
    {
        byte[] array = new byte[48];
        array[0] = 27;
        IPEndPoint remoteEP = new(Dns.GetHostEntry("time.windows.com").AddressList[0], 123);
        Socket socket = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        socket.Connect(remoteEP);
        socket.ReceiveTimeout = 3000;
        socket.Send(array);
        socket.Receive(array);
        socket.Close();
        long ulong_ = BitConverter.ToUInt32(array, 40);
        ulong ulong_2 = BitConverter.ToUInt32(array, 44);
        long num = smethod_2((ulong)ulong_);
        ulong_2 = smethod_2(ulong_2);
        ulong num2 = (ulong)(num * 1000L) + ulong_2 * 1000L / 4294967296L;
        return new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds((long)num2).ToLocalTime();
    }

    private static uint smethod_2(ulong ulong_0)
    {
        return (uint)(((ulong_0 & 0xFFL) << 24) + ((ulong_0 & 0xFF00L) << 8) + ((ulong_0 & 0xFF0000L) >> 8) + ((ulong_0 & 0xFF000000L) >> 24));
    }
}
