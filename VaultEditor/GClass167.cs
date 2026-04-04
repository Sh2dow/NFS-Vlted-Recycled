using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass167 : GClass154
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
    private uint uint_3;

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

    [GAttribute1("PartClassKey", DataType = GEnum20.const_3)]
    public uint PartClassKey
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

    [GAttribute1("PartCollectionKey", DataType = GEnum20.const_3)]
    public uint PartCollectionKey
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

    [GAttribute1("Unk")]
    public uint Unk
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

    [GAttribute1("KitNumber")]
    public uint KitNumber
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
        SlotID = binaryReader_0.ReadInt32();
        PartClassKey = binaryReader_0.ReadUInt32();
        PartCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadInt32();
        Unk = binaryReader_0.ReadUInt32();
        KitNumber = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(SlotID);
        binaryWriter_0.Write(PartClassKey);
        binaryWriter_0.Write(PartCollectionKey);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(Unk);
        binaryWriter_0.Write(KitNumber);
    }
}
