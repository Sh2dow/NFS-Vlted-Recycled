using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass163 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private float float_0;

    [GAttribute1("Class", DataType = GEnum20.const_3)]
    public uint Class
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

    [GAttribute1("Definition", DataType = GEnum20.const_3)]
    public uint Definition
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        set
        {
            uint_1 = value;
        }
    }

    [GAttribute1("Factor")]
    public float Factor
    {
        [CompilerGenerated]
        get
        {
            return float_0;
        }
        [CompilerGenerated]
        set
        {
            float_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Class = binaryReader_0.ReadUInt32();
        Definition = binaryReader_0.ReadUInt32();
        Factor = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Class);
        binaryWriter_0.Write(Definition);
        binaryWriter_0.Write(Factor);
    }
}
