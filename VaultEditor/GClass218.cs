using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass218 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private float float_0;

    [GAttribute1("HeliStrategy")]
    public uint HeliStrategy
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        set
        {
            uint_0 = value;
        }
    }

    [GAttribute1("Chance")]
    public uint Chance
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        set
        {
            uint_1 = value;
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        HeliStrategy = binaryReader_0.ReadUInt32();
        Chance = binaryReader_0.ReadUInt32();
        Duration = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(HeliStrategy);
        binaryWriter_0.Write(Chance);
        binaryWriter_0.Write(Duration);
    }
}
