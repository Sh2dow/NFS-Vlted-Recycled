using System;
using System.Security.Cryptography;

namespace VaultEditor;

public sealed class GClass28 : IDisposable
{
    internal byte[] byte_0;

    internal byte[] byte_1;

    internal byte[] byte_2;

    private GClass28(byte[] byte_3, byte[] byte_4)
    {
        byte_0 = byte_3;
        byte_1 = byte_4;
        byte_2 = new byte[16];
        Buffer.BlockCopy(byte_4, 0, byte_2, 0, byte_4.Length);
    }

    public static GClass28 smethod_0()
    {
        byte[] array = [];
        byte[] array2 = new byte[8];
        using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
        {
            randomNumberGenerator.GetBytes(array);
            randomNumberGenerator.GetBytes(array2);
        }
        return new GClass28(array, array2);
    }

    public void Dispose()
    {
        Class19.smethod_2(ref byte_0);
        Class19.smethod_2(ref byte_1);
        Class19.smethod_2(ref byte_2);
    }
}
