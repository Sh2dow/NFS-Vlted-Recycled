using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass242 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private int int_3;

    [GAttribute1("1", DataType = GEnum20.const_1)]
    public uint Value1
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        set
        {
            uint_0 = value;
        }
    }

    [GAttribute1("2")]
    public int Value2
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadUInt32();
        Value2 = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
    }
}
