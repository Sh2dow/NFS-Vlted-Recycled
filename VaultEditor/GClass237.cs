using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass237 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [GAttribute1("Formation")]
    public int Formation
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

    [GAttribute1("Duration")]
    public float Duration
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

    [GAttribute1("Frequency")]
    public float Frequency
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Formation = binaryReader_0.ReadInt32();
        Duration = binaryReader_0.ReadSingle();
        Frequency = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Formation);
        binaryWriter_0.Write(Duration);
        binaryWriter_0.Write(Frequency);
    }
}
