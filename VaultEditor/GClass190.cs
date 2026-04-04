using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass190 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private int int_4;

    [GAttribute1("1")]
    public int Value1
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

    [GAttribute1("2")]
    public GClass499 Value2
    {
        [CompilerGenerated]
        get
        {
            return gclass499_0;
        }
        [CompilerGenerated]
        set
        {
            gclass499_0 = value;
        }
    }

    [GAttribute1("3")]
    public int Value3
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

    public GClass190()
    {
        Value2 = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadInt32();
        Value2.imethod_0(binaryReader_0);
        Value3 = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        Value2.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(Value3);
    }
}
