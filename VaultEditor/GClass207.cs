using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass207 : GClass154
{
    [CompilerGenerated]
    private int int_3;

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
    private int int_4;

    [GAttribute1("CurveStyle")]
    public int CurveStyle
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

    [GAttribute1("CurvePower")]
    public float CurvePower
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

    [GAttribute1("CurveMultiplierLowSpeed")]
    public float CurveMultiplierLowSpeed
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

    [GAttribute1("CurveMultiplierHighSpeed")]
    public float CurveMultiplierHighSpeed
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

    [GAttribute1("InnerDeadZone")]
    public float InnerDeadZone
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

    [GAttribute1("OuterDeadZone")]
    public float OuterDeadZone
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

    [GAttribute1("NumberOfSteps")]
    public int NumberOfSteps
    {
        [CompilerGenerated]
        get
        {
            return int_4;
        }
        [CompilerGenerated]
        set
        {
            int_4 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        CurveStyle = binaryReader_0.ReadInt32();
        CurvePower = binaryReader_0.ReadSingle();
        CurveMultiplierLowSpeed = binaryReader_0.ReadSingle();
        CurveMultiplierHighSpeed = binaryReader_0.ReadSingle();
        InnerDeadZone = binaryReader_0.ReadSingle();
        OuterDeadZone = binaryReader_0.ReadSingle();
        NumberOfSteps = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(CurveStyle);
        binaryWriter_0.Write(CurvePower);
        binaryWriter_0.Write(CurveMultiplierLowSpeed);
        binaryWriter_0.Write(CurveMultiplierHighSpeed);
        binaryWriter_0.Write(InnerDeadZone);
        binaryWriter_0.Write(OuterDeadZone);
        binaryWriter_0.Write(NumberOfSteps);
    }
}
