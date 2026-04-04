using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass185 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private float float_0;

    [GAttribute1("KeyString")]
    public GClass499 KeyString
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

    [GAttribute1("KeyHash", DataType = GEnum20.const_3)]
    public uint KeyHash
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

    [GAttribute1("Value")]
    public float Value
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

    public GClass185()
    {
        KeyString = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        KeyString.imethod_0(binaryReader_0);
        KeyHash = binaryReader_0.ReadUInt32();
        Value = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        KeyString.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(KeyHash);
        binaryWriter_0.Write(Value);
    }
}
