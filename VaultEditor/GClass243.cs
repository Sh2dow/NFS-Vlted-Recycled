using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass243 : GClass154
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

    [GAttribute1("FrequencyStart")]
    public float Value1
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

    [GAttribute1("FrequencyEnd")]
    public float Value2
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

    [GAttribute1("RpmAmplitude")]
    public float Value3
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

    [GAttribute1("VolumeAmplitude")]
    public float Value4
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

    [GAttribute1("Lifespan")]
    public float Value5
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadSingle();
        Value2 = binaryReader_0.ReadSingle();
        Value3 = binaryReader_0.ReadSingle();
        Value4 = binaryReader_0.ReadSingle();
        Value5 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        binaryWriter_0.Write(Value4);
        binaryWriter_0.Write(Value5);
    }
}
