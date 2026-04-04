using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass251 : GClass154
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

    [CompilerGenerated]
    private float float_6;

    [CompilerGenerated]
    private float float_7;

    [GAttribute1("FrequencyA")]
    public float FrequencyA
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

    [GAttribute1("AmplitudeA")]
    public float AmplitudeA
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

    [GAttribute1("OffsetA")]
    public float OffsetA
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

    [GAttribute1("ThresholdA")]
    public float ThresholdA
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

    [GAttribute1("FrequencyB")]
    public float FrequencyB
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

    [GAttribute1("AmplitudeB")]
    public float AmplitudeB
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

    [GAttribute1("OffsetB")]
    public float OffsetB
    {
        [CompilerGenerated]
        get
        {
            return float_6;
        }
        [CompilerGenerated]
        set
        {
            float_6 = value;
        }
    }

    [GAttribute1("ThresholdB")]
    public float ThresholdB
    {
        [CompilerGenerated]
        get
        {
            return float_7;
        }
        [CompilerGenerated]
        set
        {
            float_7 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        FrequencyA = binaryReader_0.ReadSingle();
        AmplitudeA = binaryReader_0.ReadSingle();
        OffsetA = binaryReader_0.ReadSingle();
        ThresholdA = binaryReader_0.ReadSingle();
        FrequencyB = binaryReader_0.ReadSingle();
        AmplitudeB = binaryReader_0.ReadSingle();
        OffsetB = binaryReader_0.ReadSingle();
        ThresholdB = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(FrequencyA);
        binaryWriter_0.Write(AmplitudeA);
        binaryWriter_0.Write(OffsetA);
        binaryWriter_0.Write(ThresholdA);
        binaryWriter_0.Write(FrequencyB);
        binaryWriter_0.Write(AmplitudeB);
        binaryWriter_0.Write(OffsetB);
        binaryWriter_0.Write(ThresholdB);
    }
}
