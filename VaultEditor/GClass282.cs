using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass282 : GClass154
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

    [CompilerGenerated]
    private float float_8;

    [CompilerGenerated]
    private float float_9;

    [CompilerGenerated]
    private float float_10;

    [CompilerGenerated]
    private float float_11;

    [GAttribute1("StartTimeLimit1")]
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

    [GAttribute1("StartTimeLimit2")]
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

    [GAttribute1("LowTimeLimit1")]
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

    [GAttribute1("LowTimeLimit2")]
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

    [GAttribute1("FailureTimeLimit1")]
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

    [GAttribute1("FailureTimeLimit2")]
    public float Value6
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

    [GAttribute1("MediumTimeLimit1")]
    public float Value7
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

    [GAttribute1("MediumTimeLimit2")]
    public float Value8
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

    [GAttribute1("HighTimeLimit1")]
    public float Value9
    {
        [CompilerGenerated]
        get
        {
            return float_8;
        }
        [CompilerGenerated]
        set
        {
            float_8 = value;
        }
    }

    [GAttribute1("HighTimeLimit2")]
    public float Value10
    {
        [CompilerGenerated]
        get
        {
            return float_9;
        }
        [CompilerGenerated]
        set
        {
            float_9 = value;
        }
    }

    [GAttribute1("OpponentDamageThreshold1")]
    public float Value11
    {
        [CompilerGenerated]
        get
        {
            return float_10;
        }
        [CompilerGenerated]
        set
        {
            float_10 = value;
        }
    }

    [GAttribute1("OpponentDamageThreshold2")]
    public float Value12
    {
        [CompilerGenerated]
        get
        {
            return float_11;
        }
        [CompilerGenerated]
        set
        {
            float_11 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadSingle();
        Value2 = binaryReader_0.ReadSingle();
        Value3 = binaryReader_0.ReadSingle();
        Value4 = binaryReader_0.ReadSingle();
        Value5 = binaryReader_0.ReadSingle();
        Value6 = binaryReader_0.ReadSingle();
        Value7 = binaryReader_0.ReadSingle();
        Value8 = binaryReader_0.ReadSingle();
        Value9 = binaryReader_0.ReadSingle();
        Value10 = binaryReader_0.ReadSingle();
        Value11 = binaryReader_0.ReadSingle();
        Value12 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        binaryWriter_0.Write(Value4);
        binaryWriter_0.Write(Value5);
        binaryWriter_0.Write(Value6);
        binaryWriter_0.Write(Value7);
        binaryWriter_0.Write(Value8);
        binaryWriter_0.Write(Value9);
        binaryWriter_0.Write(Value10);
        binaryWriter_0.Write(Value11);
        binaryWriter_0.Write(Value12);
    }
}
