using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass271 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [GAttribute1("SlotID")]
    public int SlotID
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

    [GAttribute1("GroupClassKey", DataType = GEnum20.const_3)]
    public uint GroupClassKey
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

    [GAttribute1("GroupCollectionKey", DataType = GEnum20.const_3)]
    public uint GroupCollectionKey
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
    public float Value6
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

    [GAttribute1("7")]
    public float Value7
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

    [GAttribute1("8")]
    public float Value8
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

    [GAttribute1("Chance")]
    public float Chance
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
        SlotID = binaryReader_0.ReadInt32();
        GroupClassKey = binaryReader_0.ReadUInt32();
        GroupCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
        Value5 = binaryReader_0.ReadUInt32();
        Value6 = binaryReader_0.ReadSingle();
        Value7 = binaryReader_0.ReadSingle();
        Value8 = binaryReader_0.ReadSingle();
        Chance = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(SlotID);
        binaryWriter_0.Write(GroupClassKey);
        binaryWriter_0.Write(GroupCollectionKey);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(Value5);
        binaryWriter_0.Write(Value6);
        binaryWriter_0.Write(Value7);
        binaryWriter_0.Write(Value8);
        binaryWriter_0.Write(Chance);
    }
}
