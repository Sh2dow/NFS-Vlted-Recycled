using System.IO;
using System.Text;

namespace VaultEditor;

public sealed class GClass145
{
    public static string smethod_0(BinaryReader binaryReader_0)
    {
        StringBuilder stringBuilder = new();
        byte b;
        do
        {
            b = binaryReader_0.ReadByte();
            if (b != 0)
            {
                stringBuilder.Append((char)b);
            }
        }
        while (b != 0);
        return stringBuilder.ToString();
    }

    public static void smethod_1(BinaryWriter binaryWriter_0, string string_0)
    {
        if (string_0 == null)
        {
            binaryWriter_0.Write((byte)0);
            binaryWriter_0.Write((byte)0);
        }
        else
        {
            byte[] bytes = Encoding.ASCII.GetBytes(string_0);
            binaryWriter_0.Write(bytes);
            binaryWriter_0.Write((byte)0);
        }
    }
}
