using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass159 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [GAttribute1("SurfaceClassKey", DataType = GEnum20.const_3)]
    public uint SurfaceClassKey
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

    [GAttribute1("SurfaceCollectionKey", DataType = GEnum20.const_3)]
    public uint SurfaceCollectionKey
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

    [GAttribute1("EffectClassKey", DataType = GEnum20.const_3)]
    public uint EffectClassKey
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

    [GAttribute1("EffectCollectionKey", DataType = GEnum20.const_3)]
    public uint EffectCollectionKey
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

    [GAttribute1("MinSpeed")]
    public float MinSpeed
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

    [GAttribute1("MaxSpeed")]
    public float MaxSpeed
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
        SurfaceClassKey = binaryReader_0.ReadUInt32();
        SurfaceCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
        EffectClassKey = binaryReader_0.ReadUInt32();
        EffectCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
        MinSpeed = binaryReader_0.ReadSingle();
        MaxSpeed = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(SurfaceClassKey);
        binaryWriter_0.Write(SurfaceCollectionKey);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(EffectClassKey);
        binaryWriter_0.Write(EffectCollectionKey);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(MinSpeed);
        binaryWriter_0.Write(MaxSpeed);
    }
}
