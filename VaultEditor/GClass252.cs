using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass252 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("HeavyStrategy")]
    public int HeavyStrategy
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

    [GAttribute1("Chance")]
    public uint Chance
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

    [GAttribute1("ChanceBigSUV")]
    public uint ChanceBigSUV
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        HeavyStrategy = binaryReader_0.ReadInt32();
        Chance = binaryReader_0.ReadUInt32();
        Duration = binaryReader_0.ReadSingle();
        ChanceBigSUV = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(HeavyStrategy);
        binaryWriter_0.Write(Chance);
        binaryWriter_0.Write(Duration);
        binaryWriter_0.Write(ChanceBigSUV);
    }
}
