using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass524 : GInterface9
{
    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    public int Index
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

    public int ChildrenCount
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

    public GClass524()
    {
    }

    public GClass524(int int_2, int int_3)
    {
        Index = int_2;
        ChildrenCount = int_3;
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Index = binaryReader_0.ReadInt32();
        ChildrenCount = binaryReader_0.ReadInt32();
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Index);
        binaryWriter_0.Write(ChildrenCount);
    }

    public override string ToString()
    {
        return $"({Index}, {ChildrenCount})";
    }
}
