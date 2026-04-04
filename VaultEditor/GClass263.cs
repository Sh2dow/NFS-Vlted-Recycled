using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass263 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [GAttribute1("PerformanceType")]
    public uint PerformanceType
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

    [GAttribute1("Min")]
    public float Min
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

    [GAttribute1("Max")]
    public float Max
    {
        [CompilerGenerated]
        get
        {
            return float_1;
        }
        [CompilerGenerated]
        set
        {
            float_1 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        PerformanceType = binaryReader_0.ReadUInt32();
        Min = binaryReader_0.ReadSingle();
        Max = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(PerformanceType);
        binaryWriter_0.Write(Min);
        binaryWriter_0.Write(Max);
    }
}
