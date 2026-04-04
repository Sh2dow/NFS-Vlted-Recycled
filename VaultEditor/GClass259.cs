using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass259 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private GClass499 gclass499_1;

    [GAttribute1("PresetRideClassKey", DataType = GEnum20.const_3)]
    public uint PresetRideClassKey
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

    [GAttribute1("PresetRideCollectionKey", DataType = GEnum20.const_3)]
    public uint PresetRideCollectionKey
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

    [GAttribute1("PresetSkinName")]
    public GClass499 PresetSkinName
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

    [GAttribute1("VehicleCategory")]
    public int VehicleCategory
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

    [GAttribute1("ChannelName")]
    public GClass499 ChannelName
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

    public GClass259()
    {
        PresetSkinName = new GClass499();
        ChannelName = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        PresetRideClassKey = binaryReader_0.ReadUInt32();
        PresetRideCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadInt32();
        PresetSkinName.imethod_0(binaryReader_0);
        VehicleCategory = binaryReader_0.ReadInt32();
        ChannelName.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(PresetRideClassKey);
        binaryWriter_0.Write(PresetRideCollectionKey);
        binaryWriter_0.Write(0u);
        PresetSkinName.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(VehicleCategory);
        ChannelName.imethod_1(binaryWriter_0);
    }
}
