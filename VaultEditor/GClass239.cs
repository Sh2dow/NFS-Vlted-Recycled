using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass239 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private float float_0;

    [GAttribute1("Allow")]
    public uint Allow
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

    [GAttribute1("Reject")]
    public uint Reject
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

    [GAttribute1("MaxCausalityTime")]
    public float MaxCausalityTime
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
        Allow = binaryReader_0.ReadUInt32();
        Reject = binaryReader_0.ReadUInt32();
        MaxCausalityTime = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Allow);
        binaryWriter_0.Write(Reject);
        binaryWriter_0.Write(MaxCausalityTime);
    }
}
