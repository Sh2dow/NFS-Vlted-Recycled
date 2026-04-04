using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass170 : GClass154
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
    private uint uint_4;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [GAttribute1("TireCondition")]
    public uint TireCondition
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

    [GAttribute1("EmitterClass", DataType = GEnum20.const_3)]
    public uint EmitterClass
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

    [GAttribute1("EmitterCollection", DataType = GEnum20.const_3)]
    public uint EmitterCollection
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

    [GAttribute1("EmitterLowLodClass", DataType = GEnum20.const_3)]
    public uint EmitterLowLodClass
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

    [GAttribute1("EmitterLowLodCollection", DataType = GEnum20.const_3)]
    public uint EmitterLowLodCollection
    {
        [CompilerGenerated]
        get
        {
            return uint_4;
        }
        [CompilerGenerated]
        set
        {
            uint_4 = value;
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
        TireCondition = binaryReader_0.ReadUInt32();
        EmitterClass = binaryReader_0.ReadUInt32();
        EmitterCollection = binaryReader_0.ReadUInt32();
        if (binaryReader_0.ReadUInt32() != 0)
        {
            throw new Exception();
        }
        EmitterLowLodClass = binaryReader_0.ReadUInt32();
        EmitterLowLodCollection = binaryReader_0.ReadUInt32();
        if (binaryReader_0.ReadUInt32() != 0)
        {
            throw new Exception();
        }
        MinSpeed = binaryReader_0.ReadSingle();
        MaxSpeed = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(TireCondition);
        binaryWriter_0.Write(EmitterClass);
        binaryWriter_0.Write(EmitterCollection);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(EmitterLowLodClass);
        binaryWriter_0.Write(EmitterLowLodCollection);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(MinSpeed);
        binaryWriter_0.Write(MaxSpeed);
    }
}
