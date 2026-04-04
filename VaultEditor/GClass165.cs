using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass165 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

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
    private float float_10;

    [GAttribute1("RegionID")]
    public uint RegionID
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

    [GAttribute1("Zone1")]
    public float Zone1
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

    [GAttribute1("Zone2")]
    public float Zone2
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

    [GAttribute1("Zone3")]
    public float Zone3
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

    [GAttribute1("Zone4")]
    public float Zone4
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

    [GAttribute1("Zone5")]
    public float Zone5
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

    [GAttribute1("Zone6")]
    public float Zone6
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

    [GAttribute1("Zone7")]
    public float Zone7
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

    [GAttribute1("Zone8")]
    public float Zone8
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

    [GAttribute1("Zone9")]
    public float Zone9
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

    [GAttribute1("Zone10")]
    public float Zone10
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

    [GAttribute1("Zone11")]
    public float Zone11
    {
        [CompilerGenerated]
        get
        {
            return float_10;
        }
        [CompilerGenerated]
        set
        {
            float_10 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        RegionID = binaryReader_0.ReadUInt32();
        Zone1 = binaryReader_0.ReadSingle();
        Zone2 = binaryReader_0.ReadSingle();
        Zone3 = binaryReader_0.ReadSingle();
        Zone4 = binaryReader_0.ReadSingle();
        Zone5 = binaryReader_0.ReadSingle();
        Zone6 = binaryReader_0.ReadSingle();
        Zone7 = binaryReader_0.ReadSingle();
        Zone8 = binaryReader_0.ReadSingle();
        Zone9 = binaryReader_0.ReadSingle();
        Zone10 = binaryReader_0.ReadSingle();
        Zone11 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(RegionID);
        binaryWriter_0.Write(Zone1);
        binaryWriter_0.Write(Zone2);
        binaryWriter_0.Write(Zone3);
        binaryWriter_0.Write(Zone4);
        binaryWriter_0.Write(Zone5);
        binaryWriter_0.Write(Zone6);
        binaryWriter_0.Write(Zone7);
        binaryWriter_0.Write(Zone8);
        binaryWriter_0.Write(Zone9);
        binaryWriter_0.Write(Zone10);
        binaryWriter_0.Write(Zone11);
    }
}
