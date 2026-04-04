using System.IO;

namespace VaultEditor;

public static class GClass481
{
    public static MemoryStream smethod_0(BinaryReader binaryReader_0)
    {
        GClass482 gClass = new();
        gClass.method_0(binaryReader_0);
        byte[] array = binaryReader_0.ReadBytes(gClass.BlockSize - 16);
        byte[] byte_ = new byte[gClass.DataSize];
        smethod_1(array, byte_);
        return new MemoryStream(array);
    }

    public static void smethod_1(byte[] byte_0, byte[] byte_1)
    {
        int num = 1;
        int num2 = 1;
        int num3 = 0;
        int num4 = 0;
        while (num3 < byte_0.Length && num4 < byte_1.Length)
        {
            if (num == 1)
            {
                num = byte_0[num3++] | 0x100;
            }
            if (num2 == 1)
            {
                num2 = byte_0[num3++] | 0x100;
            }
            if ((num & 1) == 1)
            {
                int num5;
                int num6;
                if ((num2 & 1) == 1)
                {
                    num5 = (byte_0[num3 + 1] | ((byte_0[num3] & 0xF0) << 4)) + 3;
                    num6 = (byte_0[num3] & 0xF) + 1;
                }
                else
                {
                    num6 = (byte_0[num3 + 1] | ((byte_0[num3] & 0xE0) << 3)) + 17;
                    num5 = (byte_0[num3] & 0x1F) + 3;
                }
                num3 += 2;
                for (int i = 0; i < num5; i++)
                {
                    byte_1[num4 + i] = byte_1[num4 + i - num6];
                }
                num4 += num5;
                num2 >>= 1;
            }
            else if (num4 < byte_1.Length)
            {
                byte_1[num4++] = byte_0[num3++];
            }
            num >>= 1;
        }
    }
}
