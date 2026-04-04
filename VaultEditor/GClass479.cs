using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass479
{
    public static int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private GEnum16 genum16_0;

    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private int int_3;

    public int FilesCount
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        set
        {
            int_1 = value;
        }
    }

    public GEnum16 Magic
    {
        [CompilerGenerated]
        get
        {
            return genum16_0;
        }
        [CompilerGenerated]
        set
        {
            genum16_0 = value;
        }
    }

    public int NamesLength
    {
        [CompilerGenerated]
        get
        {
            return int_2;
        }
        [CompilerGenerated]
        set
        {
            int_2 = value;
        }
    }

    public int Offset
    {
        [CompilerGenerated]
        get
        {
            return int_3;
        }
        [CompilerGenerated]
        set
        {
            int_3 = value;
        }
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        Magic = (GEnum16)binaryReader_0.ReadUInt32();
        FilesCount = binaryReader_0.ReadInt32();
        Offset = binaryReader_0.ReadInt32();
        NamesLength = binaryReader_0.ReadInt32();
    }

    public void method_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write((uint)Magic);
        binaryWriter_0.Write(FilesCount);
        binaryWriter_0.Write(Offset);
        binaryWriter_0.Write(NamesLength);
    }
}
