using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass295 : GClass154
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

    [GAttribute1("Front_MinX")]
    public float FrontMinX
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

    [GAttribute1("Front_MaxX")]
    public float FrontMaxX
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

    [GAttribute1("Front_MinY")]
    public float FrontMinY
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

    [GAttribute1("Front_MaxY")]
    public float FrontMaxY
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

    [GAttribute1("Front_GraphScale")]
    public float FrontGraphScale
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

    [GAttribute1("Front_XValues")]
    public GInterface5 FrontXValues
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

    [GAttribute1("Front_YValues")]
    public GInterface5 FrontYValues
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

    [GAttribute1("Front_Y2Values")]
    public GInterface5 FrontY2Values
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

    [GAttribute1("Front_AllocatedMemory")]
    public uint FrontAllocatedMemory
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

    [GAttribute1("Rear_MinX")]
    public float RearMinX
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

    [GAttribute1("Rear_MaxX")]
    public float RearMaxX
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

    [GAttribute1("Rear_MinY")]
    public float RearMinY
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

    [GAttribute1("Rear_MaxY")]
    public float RearMaxY
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

    [GAttribute1("Rear_GraphScale")]
    public float RearGraphScale
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

    [GAttribute1("Rear_XValues")]
    public GInterface5 RearXValues
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

    [GAttribute1("Rear_YValues")]
    public GInterface5 RearYValues
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

    [GAttribute1("Rear_Y2Values")]
    public GInterface5 RearY2Values
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

    [GAttribute1("Rear_AllocatedMemory")]
    public uint RearAllocatedMemory
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

    public GClass295()
    {
        FrontXValues = new GClass517();
        FrontYValues = new GClass517();
        FrontY2Values = new GClass517();
        RearXValues = new GClass517();
        RearYValues = new GClass517();
        RearY2Values = new GClass517();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        FrontMinX = binaryReader_0.ReadSingle();
        FrontMaxX = binaryReader_0.ReadSingle();
        FrontMinY = binaryReader_0.ReadSingle();
        FrontMaxY = binaryReader_0.ReadSingle();
        FrontGraphScale = binaryReader_0.ReadSingle();
        FrontXValues.imethod_0(binaryReader_0);
        FrontYValues.imethod_0(binaryReader_0);
        FrontY2Values.imethod_0(binaryReader_0);
        FrontAllocatedMemory = binaryReader_0.ReadUInt32();
        RearMinX = binaryReader_0.ReadSingle();
        RearMaxX = binaryReader_0.ReadSingle();
        RearMinY = binaryReader_0.ReadSingle();
        RearMaxY = binaryReader_0.ReadSingle();
        RearGraphScale = binaryReader_0.ReadSingle();
        RearXValues.imethod_0(binaryReader_0);
        RearYValues.imethod_0(binaryReader_0);
        RearY2Values.imethod_0(binaryReader_0);
        RearAllocatedMemory = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(FrontMinX);
        binaryWriter_0.Write(FrontMaxX);
        binaryWriter_0.Write(FrontMinY);
        binaryWriter_0.Write(FrontMaxY);
        binaryWriter_0.Write(FrontGraphScale);
        FrontXValues.imethod_1(binaryWriter_0);
        FrontYValues.imethod_1(binaryWriter_0);
        FrontY2Values.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(FrontAllocatedMemory);
        binaryWriter_0.Write(RearMinX);
        binaryWriter_0.Write(RearMaxX);
        binaryWriter_0.Write(RearMinY);
        binaryWriter_0.Write(RearMaxY);
        binaryWriter_0.Write(RearGraphScale);
        RearXValues.imethod_1(binaryWriter_0);
        RearYValues.imethod_1(binaryWriter_0);
        RearY2Values.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(RearAllocatedMemory);
    }
}
