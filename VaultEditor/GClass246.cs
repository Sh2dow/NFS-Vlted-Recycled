using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass246 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [GAttribute1("SlotName")]
    public GClass499 SlotName
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

    [GAttribute1("CameraClassKey", DataType = GEnum20.const_3)]
    public uint CameraClassKey
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

    [GAttribute1("CameraCollectionKey", DataType = GEnum20.const_3)]
    public uint CameraCollectionKey
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

    [GAttribute1("Camera_4_3ClassKey", DataType = GEnum20.const_3)]
    public uint Camera_4_3ClassKey
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

    [GAttribute1("Camera_4_3CollectionKey", DataType = GEnum20.const_3)]
    public uint Camera_4_3CollectionKey
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

    public GClass246()
    {
        SlotName = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        SlotName.imethod_0(binaryReader_0);
        CameraClassKey = binaryReader_0.ReadUInt32();
        CameraCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
        Camera_4_3ClassKey = binaryReader_0.ReadUInt32();
        Camera_4_3CollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        SlotName.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(CameraClassKey);
        binaryWriter_0.Write(CameraCollectionKey);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(Camera_4_3ClassKey);
        binaryWriter_0.Write(Camera_4_3CollectionKey);
        binaryWriter_0.Write(0u);
    }
}
