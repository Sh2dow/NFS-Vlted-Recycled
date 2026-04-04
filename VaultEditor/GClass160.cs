using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass160 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [GAttribute1("Level")]
    public uint Level
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

    [GAttribute1("Unk")]
    public float Unk
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

    [GAttribute1("Cost")]
    public float Cost
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
        Level = binaryReader_0.ReadUInt32();
        Unk = binaryReader_0.ReadSingle();
        Cost = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Level);
        binaryWriter_0.Write(Unk);
        binaryWriter_0.Write(Cost);
    }
}
