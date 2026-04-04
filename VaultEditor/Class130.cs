using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(PreAlignBlock = 128, Type = GEnum15.const_39)]
internal sealed class Class130 : GClass119
{
    [CompilerGenerated]
    private byte[] byte_0;

    public byte[] Data
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
        Data = binaryReader_0.ReadBytes(int_1);
    }

    public void imethod_4(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Data);
    }

    public void imethod_6(string string_0)
    {
        File.WriteAllBytes(string_0, Data);
    }
}
