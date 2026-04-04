using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass217 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [CompilerGenerated]
    private float float_4;

    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [CompilerGenerated]
    private GInterface5 ginterface5_1;

    [CompilerGenerated]
    private GInterface5 ginterface5_2;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private float float_5;

    [CompilerGenerated]
    private float float_6;

    [CompilerGenerated]
    private float float_7;

    [CompilerGenerated]
    private float float_8;

    [CompilerGenerated]
    private float float_9;

    [CompilerGenerated]
    private GInterface5 ginterface5_3;

    [CompilerGenerated]
    private GInterface5 ginterface5_4;

    [CompilerGenerated]
    private GInterface5 ginterface5_5;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("Easy_MinX")]
    public float EasyMinX
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

    [GAttribute1("Easy_MaxX")]
    public float EasyMaxX
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

    [GAttribute1("Easy_MinY")]
    public float EasyMinY
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

    [GAttribute1("Easy_MaxY")]
    public float EasyMaxY
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

    [GAttribute1("Easy_GraphScale")]
    public float EasyGraphScale
    {
        [CompilerGenerated]
        get
        {
            return float_4;
        }
        [CompilerGenerated]
        set
        {
            float_4 = value;
        }
    }

    [GAttribute1("Easy_XValues")]
    public GInterface5 EasyXValues
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_0;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_0 = value;
        }
    }

    [GAttribute1("Easy_YValues")]
    public GInterface5 EasyYValues
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_1;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_1 = value;
        }
    }

    [GAttribute1("Easy_Y2Values")]
    public GInterface5 EasyY2Values
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_2;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_2 = value;
        }
    }

    [GAttribute1("Easy_AllocatedMemory")]
    public uint EasyAllocatedMemory
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

    [GAttribute1("Hard_MinX")]
    public float HardMinX
    {
        [CompilerGenerated]
        get
        {
            return float_5;
        }
        [CompilerGenerated]
        set
        {
            float_5 = value;
        }
    }

    [GAttribute1("Hard_MaxX")]
    public float HardMaxX
    {
        [CompilerGenerated]
        get
        {
            return float_6;
        }
        [CompilerGenerated]
        set
        {
            float_6 = value;
        }
    }

    [GAttribute1("Hard_MinY")]
    public float HardMinY
    {
        [CompilerGenerated]
        get
        {
            return float_7;
        }
        [CompilerGenerated]
        set
        {
            float_7 = value;
        }
    }

    [GAttribute1("Hard_MaxY")]
    public float HardMaxY
    {
        [CompilerGenerated]
        get
        {
            return float_8;
        }
        [CompilerGenerated]
        set
        {
            float_8 = value;
        }
    }

    [GAttribute1("Hard_GraphScale")]
    public float HardGraphScale
    {
        [CompilerGenerated]
        get
        {
            return float_9;
        }
        [CompilerGenerated]
        set
        {
            float_9 = value;
        }
    }

    [GAttribute1("Hard_XValues")]
    public GInterface5 HardXValues
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_3;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_3 = value;
        }
    }

    [GAttribute1("Hard_YValues")]
    public GInterface5 HardYValues
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_4;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_4 = value;
        }
    }

    [GAttribute1("Hard_Y2Values")]
    public GInterface5 HardY2Values
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_5;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_5 = value;
        }
    }

    [GAttribute1("Hard_AllocatedMemory")]
    public uint HardAllocatedMemory
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

    public GClass217()
    {
        EasyXValues = new GClass517();
        EasyYValues = new GClass517();
        EasyY2Values = new GClass517();
        HardXValues = new GClass517();
        HardYValues = new GClass517();
        HardY2Values = new GClass517();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        EasyMinX = binaryReader_0.ReadSingle();
        EasyMaxX = binaryReader_0.ReadSingle();
        EasyMinY = binaryReader_0.ReadSingle();
        EasyMaxY = binaryReader_0.ReadSingle();
        EasyGraphScale = binaryReader_0.ReadSingle();
        EasyXValues.imethod_0(binaryReader_0);
        EasyYValues.imethod_0(binaryReader_0);
        EasyY2Values.imethod_0(binaryReader_0);
        EasyAllocatedMemory = binaryReader_0.ReadUInt32();
        HardMinX = binaryReader_0.ReadSingle();
        HardMaxX = binaryReader_0.ReadSingle();
        HardMinY = binaryReader_0.ReadSingle();
        HardMaxY = binaryReader_0.ReadSingle();
        HardGraphScale = binaryReader_0.ReadSingle();
        HardXValues.imethod_0(binaryReader_0);
        HardYValues.imethod_0(binaryReader_0);
        HardY2Values.imethod_0(binaryReader_0);
        HardAllocatedMemory = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(EasyMinX);
        binaryWriter_0.Write(EasyMaxX);
        binaryWriter_0.Write(EasyMinY);
        binaryWriter_0.Write(EasyMaxY);
        binaryWriter_0.Write(EasyGraphScale);
        EasyXValues.imethod_1(binaryWriter_0);
        EasyYValues.imethod_1(binaryWriter_0);
        EasyY2Values.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(EasyAllocatedMemory);
        binaryWriter_0.Write(HardMinX);
        binaryWriter_0.Write(HardMaxX);
        binaryWriter_0.Write(HardMinY);
        binaryWriter_0.Write(HardMaxY);
        binaryWriter_0.Write(HardGraphScale);
        HardXValues.imethod_1(binaryWriter_0);
        HardYValues.imethod_1(binaryWriter_0);
        HardY2Values.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(HardAllocatedMemory);
    }
}
