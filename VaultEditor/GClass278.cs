using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass278 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [GAttribute1("Frequency")]
    public float Frequency
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

    [GAttribute1("Amplitude")]
    public float Amplitude
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

    [GAttribute1("MinSpeed")]
    public float MinSpeed
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

    [GAttribute1("MaxSpeed")]
    public float MaxSpeed
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
        Frequency = binaryReader_0.ReadSingle();
        Amplitude = binaryReader_0.ReadSingle();
        MinSpeed = binaryReader_0.ReadSingle();
        MaxSpeed = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Frequency);
        binaryWriter_0.Write(Amplitude);
        binaryWriter_0.Write(MinSpeed);
        binaryWriter_0.Write(MaxSpeed);
    }
}
