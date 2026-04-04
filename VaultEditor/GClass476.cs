using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass476
{
    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    public int BinSize
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public int VltSize
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

    public int BinOffset
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

    public int VltOffset
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

    public int FileSize
    {
        [CompilerGenerated]
        get
        {
            return int_4;
        }
        [CompilerGenerated]
        set
        {
            int_4 = value;
        }
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        BinOffset = binaryReader_0.ReadInt32();
        VltOffset = binaryReader_0.ReadInt32();
        BinSize = binaryReader_0.ReadInt32();
        VltSize = binaryReader_0.ReadInt32();
        FileSize = binaryReader_0.ReadInt32();
    }

    public void method_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(BinOffset);
        binaryWriter_0.Write(VltOffset);
        binaryWriter_0.Write(BinSize);
        binaryWriter_0.Write(VltSize);
        binaryWriter_0.Write(FileSize);
    }
}
