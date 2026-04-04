using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass229 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private GClass499 gclass499_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [GAttribute1("PartID")]
    public int PartID
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

    [GAttribute1("AttachPart")]
    public GClass499 AttachPart
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

    [GAttribute1("MaterialClassKey", DataType = GEnum20.const_3)]
    public uint MaterialClassKey
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

    [GAttribute1("MaterialCollectionKey", DataType = GEnum20.const_3)]
    public uint MaterialCollectionKey
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

    [GAttribute1("SmackableCollisionName")]
    public GClass499 SmackableCollisionName
    {
        [CompilerGenerated]
        get
        {
            return gclass499_1;
        }
        [CompilerGenerated]
        set
        {
            gclass499_1 = value;
        }
    }

    [GAttribute1("SmackableCollisionAttributeClassKey", DataType = GEnum20.const_3)]
    public uint SmackableCollisionAttributeClassKey
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

    [GAttribute1("SmackableCollisionAttributeCollectionKey", DataType = GEnum20.const_3)]
    public uint SmackableCollisionAttributeCollectionKey
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

    public GClass229()
    {
        AttachPart = new GClass499();
        SmackableCollisionName = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        PartID = binaryReader_0.ReadInt32();
        AttachPart.imethod_0(binaryReader_0);
        MaterialClassKey = binaryReader_0.ReadUInt32();
        MaterialCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadInt32();
        SmackableCollisionName.imethod_0(binaryReader_0);
        SmackableCollisionAttributeClassKey = binaryReader_0.ReadUInt32();
        SmackableCollisionAttributeCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(PartID);
        AttachPart.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(MaterialClassKey);
        binaryWriter_0.Write(MaterialCollectionKey);
        binaryWriter_0.Write(0u);
        SmackableCollisionName.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(SmackableCollisionAttributeClassKey);
        binaryWriter_0.Write(SmackableCollisionAttributeCollectionKey);
        binaryWriter_0.Write(0u);
    }
}
