using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass296 : GClass154
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

    [GAttribute1("MinX")]
    public float MinX
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

    [GAttribute1("MaxX")]
    public float MaxX
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

    [GAttribute1("MinY")]
    public float MinY
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

    [GAttribute1("MaxY")]
    public float MaxY
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

    [GAttribute1("GraphScale")]
    public float GraphScale
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

    [GAttribute1("XValues")]
    public GInterface5 XValues
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

    [GAttribute1("YValues")]
    public GInterface5 YValues
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

    [GAttribute1("Y2Values")]
    public GInterface5 Y2Values
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

    [GAttribute1("AllocatedMemory")]
    public uint AllocatedMemory
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

    public GClass296()
    {
        XValues = new GClass517();
        YValues = new GClass517();
        Y2Values = new GClass517();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        MinX = binaryReader_0.ReadSingle();
        MaxX = binaryReader_0.ReadSingle();
        MinY = binaryReader_0.ReadSingle();
        MaxY = binaryReader_0.ReadSingle();
        GraphScale = binaryReader_0.ReadSingle();
        XValues.imethod_0(binaryReader_0);
        YValues.imethod_0(binaryReader_0);
        Y2Values.imethod_0(binaryReader_0);
        AllocatedMemory = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(MinX);
        binaryWriter_0.Write(MaxX);
        binaryWriter_0.Write(MinY);
        binaryWriter_0.Write(MaxY);
        binaryWriter_0.Write(GraphScale);
        XValues.imethod_1(binaryWriter_0);
        YValues.imethod_1(binaryWriter_0);
        Y2Values.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(AllocatedMemory);
    }
}
