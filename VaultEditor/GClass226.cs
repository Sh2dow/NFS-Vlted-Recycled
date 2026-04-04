using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass226 : GClass154
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

    [GAttribute1("Type")]
    public uint Type
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

    [GAttribute1("InputMin")]
    public float InputMin
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

    [GAttribute1("ValueMin1")]
    public float ValueMin1
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

    [GAttribute1("ValueMin2")]
    public float ValueMin2
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

    [GAttribute1("InputMax")]
    public float InputMax
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

    [GAttribute1("ValueMax1")]
    public float ValueMax1
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

    [GAttribute1("ValueMax2")]
    public float ValueMax2
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Type = binaryReader_0.ReadUInt32();
        InputMin = binaryReader_0.ReadSingle();
        ValueMin1 = binaryReader_0.ReadSingle();
        ValueMin2 = binaryReader_0.ReadSingle();
        InputMax = binaryReader_0.ReadSingle();
        ValueMax1 = binaryReader_0.ReadSingle();
        ValueMax2 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Type);
        binaryWriter_0.Write(InputMin);
        binaryWriter_0.Write(ValueMin1);
        binaryWriter_0.Write(ValueMin2);
        binaryWriter_0.Write(InputMax);
        binaryWriter_0.Write(ValueMax1);
        binaryWriter_0.Write(ValueMax2);
    }
}
