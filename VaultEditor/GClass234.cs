using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass234 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [CompilerGenerated]
    private float float_4;

    [CompilerGenerated]
    private float float_5;

    [GAttribute1("Elasticity")]
    public float Elasticity
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

    [GAttribute1("RollHeight")]
    public float RollHeight
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

    [GAttribute1("WeightBias")]
    public float WeightBias
    {
        [CompilerGenerated]
        get
        {
            return float_2;
        }
        [CompilerGenerated]
        set
        {
            float_2 = value;
        }
    }

    [GAttribute1("MassScale")]
    public float MassScale
    {
        [CompilerGenerated]
        get
        {
            return float_3;
        }
        [CompilerGenerated]
        set
        {
            float_3 = value;
        }
    }

    [GAttribute1("StunSpeed")]
    public float StunSpeed
    {
        [CompilerGenerated]
        get
        {
            return float_4;
        }
        [CompilerGenerated]
        set
        {
            float_4 = value;
        }
    }

    [GAttribute1("StunTime")]
    public float StunTime
    {
        [CompilerGenerated]
        get
        {
            return float_5;
        }
        [CompilerGenerated]
        set
        {
            float_5 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Elasticity = binaryReader_0.ReadSingle();
        RollHeight = binaryReader_0.ReadSingle();
        WeightBias = binaryReader_0.ReadSingle();
        MassScale = binaryReader_0.ReadSingle();
        StunSpeed = binaryReader_0.ReadUInt32();
        StunTime = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Elasticity);
        binaryWriter_0.Write(RollHeight);
        binaryWriter_0.Write(WeightBias);
        binaryWriter_0.Write(MassScale);
        binaryWriter_0.Write(StunSpeed);
        binaryWriter_0.Write(StunTime);
    }
}
