using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace VaultEditor;

[GAttribute2(Type = GEnum15.const_24)]
internal sealed class Class147 : GClass119
{
    [CompilerGenerated]
    private string[] string_0;

    [CompilerGenerated]
    private byte[] byte_0;

    public string[] Names
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public byte[] RawData
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    public void imethod_3(BinaryReader binaryReader_0, int int_1)
    {
        byte[] bytes = (RawData = binaryReader_0.ReadBytes(int_1));
        Names = [.. Encoding.Default.GetString(bytes).Split(new char[1], StringSplitOptions.RemoveEmptyEntries)];
    }

    public void imethod_4(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(RawData);
    }
}
