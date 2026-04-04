using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass156 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Elasticity = binaryReader_0.ReadSingle();
        RollHeight = binaryReader_0.ReadSingle();
        WeightBias = binaryReader_0.ReadSingle();
        MassScale = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Elasticity);
        binaryWriter_0.Write(RollHeight);
        binaryWriter_0.Write(WeightBias);
        binaryWriter_0.Write(MassScale);
    }
}
