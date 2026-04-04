using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass290 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [GAttribute1("Group", DataType = GEnum20.const_3)]
    public uint Group
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

    [GAttribute1("Name", DataType = GEnum20.const_3)]
    public uint CarName
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

    [GAttribute1("Density")]
    public float Density
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

    [GAttribute1("5")]
    public uint Value5
    {
        [CompilerGenerated]
        get
        {
            return uint_2;
        }
        [CompilerGenerated]
        set
        {
            uint_2 = value;
        }
    }

    [GAttribute1("6")]
    public uint Value6
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        set
        {
            uint_3 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Group = binaryReader_0.ReadUInt32();
        CarName = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
        Density = binaryReader_0.ReadSingle();
        Value5 = binaryReader_0.ReadUInt32();
        Value6 = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Group);
        binaryWriter_0.Write(CarName);
        binaryWriter_0.Write(0);
        binaryWriter_0.Write(Density);
        binaryWriter_0.Write(Value5);
        binaryWriter_0.Write(Value6);
    }
}
