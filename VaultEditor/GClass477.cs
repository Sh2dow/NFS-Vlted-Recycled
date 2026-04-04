using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass477
{
    public static int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private int int_5;

    public int NameOffset
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

    public int BinSize
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

    public int VltSize
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

    public int BinOffset
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

    public int VltOffset
    {
        [CompilerGenerated]
        get
        {
            return int_5;
        }
        [CompilerGenerated]
        set
        {
            int_5 = value;
        }
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        NameOffset = binaryReader_0.ReadInt32();
        BinSize = binaryReader_0.ReadInt32();
        VltSize = binaryReader_0.ReadInt32();
        BinOffset = binaryReader_0.ReadInt32();
        VltOffset = binaryReader_0.ReadInt32();
    }

    public void method_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(NameOffset);
        binaryWriter_0.Write(BinSize);
        binaryWriter_0.Write(VltSize);
        binaryWriter_0.Write(BinOffset);
        binaryWriter_0.Write(VltOffset);
    }
}
