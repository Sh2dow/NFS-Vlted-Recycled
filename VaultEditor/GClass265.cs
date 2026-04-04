using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass265 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private bool bool_2;

    [CompilerGenerated]
    private float float_0;

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

    [GAttribute1("Inverse")]
    public bool Inverse
    {
        [CompilerGenerated]
        get
        {
            return bool_2;
        }
        [CompilerGenerated]
        set
        {
            bool_2 = value;
        }
    }

    [GAttribute1("Percentage")]
    public float Percentage
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
        PerformanceType = binaryReader_0.ReadUInt32();
        Inverse = binaryReader_0.ReadInt32() == 1;
        Percentage = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(PerformanceType);
        binaryWriter_0.Write(Inverse ? 1 : 0);
        binaryWriter_0.Write(Percentage);
    }
}
