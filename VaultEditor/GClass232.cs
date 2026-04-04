using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass232 : GClass154
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

    [GAttribute1("Threshold0")]
    public float Threshold0
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

    [GAttribute1("Threshold1")]
    public float Threshold1
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

    [GAttribute1("Threshold2")]
    public float Threshold2
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

    [GAttribute1("Threshold3")]
    public float Threshold3
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

    [GAttribute1("DeltaThreshold0")]
    public float DeltaThreshold0
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

    [GAttribute1("DeltaThreshold1")]
    public float DeltaThreshold1
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

    [GAttribute1("DeltaThreshold2")]
    public float DeltaThreshold2
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

    [GAttribute1("DeltaThreshold3")]
    public float DeltaThreshold3
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
        Threshold0 = binaryReader_0.ReadSingle();
        Threshold1 = binaryReader_0.ReadSingle();
        Threshold2 = binaryReader_0.ReadSingle();
        Threshold3 = binaryReader_0.ReadSingle();
        DeltaThreshold0 = binaryReader_0.ReadSingle();
        DeltaThreshold1 = binaryReader_0.ReadSingle();
        DeltaThreshold2 = binaryReader_0.ReadSingle();
        DeltaThreshold3 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Threshold0);
        binaryWriter_0.Write(Threshold1);
        binaryWriter_0.Write(Threshold2);
        binaryWriter_0.Write(Threshold3);
        binaryWriter_0.Write(DeltaThreshold0);
        binaryWriter_0.Write(DeltaThreshold1);
        binaryWriter_0.Write(DeltaThreshold2);
        binaryWriter_0.Write(DeltaThreshold3);
    }
}
