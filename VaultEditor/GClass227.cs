using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass227 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [GAttribute1("SpeedMin")]
    public float SpeedMin
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

    [GAttribute1("ValueMin")]
    public float ValueMin
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

    [GAttribute1("SpeedMax")]
    public float SpeedMax
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

    [GAttribute1("ValueMax")]
    public float ValueMax
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
        SpeedMin = binaryReader_0.ReadSingle();
        ValueMin = binaryReader_0.ReadSingle();
        SpeedMax = binaryReader_0.ReadSingle();
        ValueMax = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(SpeedMin);
        binaryWriter_0.Write(ValueMin);
        binaryWriter_0.Write(SpeedMax);
        binaryWriter_0.Write(ValueMax);
    }
}
