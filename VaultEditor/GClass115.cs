using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class GClass115
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private byte byte_0;

    [CompilerGenerated]
    private float float_3;

    [CompilerGenerated]
    private float float_4;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private float float_5;

    [CompilerGenerated]
    private float float_6;

    [CompilerGenerated]
    private byte byte_1;

    public float PositionX
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

    public float Unknown1
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

    public float PositionZ
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

    [GAttribute4(4)]
    public byte p1
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    public float Diameter
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

    public float Width
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

    public uint Index
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

    public float PositionY
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

    public float LeftBodyKitsY
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

    [GAttribute4(12)]
    public byte p2
    {
        [CompilerGenerated]
        get
        {
            return byte_1;
        }
        [CompilerGenerated]
        set
        {
            byte_1 = value;
        }
    }

    public override string ToString()
    {
        return $"x={PositionX}, y={PositionY}, z={PositionZ}";
    }
}
