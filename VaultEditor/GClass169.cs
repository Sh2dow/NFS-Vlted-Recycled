using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass169 : GClass154
{
    [CompilerGenerated]
    private ulong ulong_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("Collision64", DataType = GEnum20.const_2)]
    public ulong Hash64
    {
        [CompilerGenerated]
        get
        {
            return ulong_0;
        }
        [CompilerGenerated]
        set
        {
            ulong_0 = value;
        }
    }

    [GAttribute1("Collision", DataType = GEnum20.const_3)]
    public uint Hash32
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

    [GAttribute1("Visual")]
    public GClass499 Value
    {
        [CompilerGenerated]
        get
        {
            return gclass499_0;
        }
        [CompilerGenerated]
        set
        {
            gclass499_0 = value;
        }
    }

    public GClass169()
    {
        Value = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Hash64 = binaryReader_0.ReadUInt64();
        Hash32 = binaryReader_0.ReadUInt32();
        Value.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Hash64);
        binaryWriter_0.Write(Hash32);
        Value.imethod_1(binaryWriter_0);
    }
}
