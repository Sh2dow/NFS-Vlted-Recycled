using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class207 : GClass475
{
    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private bool bool_1;

    public int OffsetStart
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

    public int OffsetEnd
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

    public bool IsArray
    {
        [CompilerGenerated]
        get
        {
            return bool_1;
        }
        [CompilerGenerated]
        set
        {
            bool_1 = value;
        }
    }

    public void method_1(BinaryReader binaryReader_0)
    {
        OffsetStart = binaryReader_0.ReadInt32();
        OffsetEnd = binaryReader_0.ReadInt32();
        IsArray = binaryReader_0.ReadBoolean();
    }

    public bool method_2(int int_4)
    {
        if (OffsetStart <= int_4)
        {
            return int_4 < OffsetEnd;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
