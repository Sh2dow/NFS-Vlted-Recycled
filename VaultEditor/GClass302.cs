using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass302 : GClass154
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

    [CompilerGenerated]
    private float float_11;

    [CompilerGenerated]
    private float float_12;

    [CompilerGenerated]
    private float float_13;

    [CompilerGenerated]
    private float float_14;

    [CompilerGenerated]
    private float float_15;

    [GAttribute1("M[1,1]")]
    public float M11
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

    [GAttribute1("M[1,2]")]
    public float M12
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

    [GAttribute1("M[1,3]")]
    public float M13
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

    [GAttribute1("M[1,4]")]
    public float M14
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

    [GAttribute1("M[2,1]")]
    public float M21
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

    [GAttribute1("M[2,2]")]
    public float M22
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

    [GAttribute1("M[2,3]")]
    public float M23
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

    [GAttribute1("M[2,4]")]
    public float M24
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

    [GAttribute1("M[3,1]")]
    public float M31
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

    [GAttribute1("M[3,2]")]
    public float M32
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

    [GAttribute1("M[3,3]")]
    public float M33
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

    [GAttribute1("M[3,4]")]
    public float M34
    {
        [CompilerGenerated]
        get
        {
            return float_11;
        }
        [CompilerGenerated]
        set
        {
            float_11 = value;
        }
    }

    [GAttribute1("M[4,1]")]
    public float M41
    {
        [CompilerGenerated]
        get
        {
            return float_12;
        }
        [CompilerGenerated]
        set
        {
            float_12 = value;
        }
    }

    [GAttribute1("M[4,2]")]
    public float M42
    {
        [CompilerGenerated]
        get
        {
            return float_13;
        }
        [CompilerGenerated]
        set
        {
            float_13 = value;
        }
    }

    [GAttribute1("M[4,3]")]
    public float M43
    {
        [CompilerGenerated]
        get
        {
            return float_14;
        }
        [CompilerGenerated]
        set
        {
            float_14 = value;
        }
    }

    [GAttribute1("M[4,4]")]
    public float M44
    {
        [CompilerGenerated]
        get
        {
            return float_15;
        }
        [CompilerGenerated]
        set
        {
            float_15 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        M11 = binaryReader_0.ReadSingle();
        M12 = binaryReader_0.ReadSingle();
        M13 = binaryReader_0.ReadSingle();
        M14 = binaryReader_0.ReadSingle();
        M21 = binaryReader_0.ReadSingle();
        M22 = binaryReader_0.ReadSingle();
        M23 = binaryReader_0.ReadSingle();
        M24 = binaryReader_0.ReadSingle();
        M31 = binaryReader_0.ReadSingle();
        M32 = binaryReader_0.ReadSingle();
        M33 = binaryReader_0.ReadSingle();
        M34 = binaryReader_0.ReadSingle();
        M41 = binaryReader_0.ReadSingle();
        M42 = binaryReader_0.ReadSingle();
        M43 = binaryReader_0.ReadSingle();
        M44 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(M11);
        binaryWriter_0.Write(M12);
        binaryWriter_0.Write(M13);
        binaryWriter_0.Write(M14);
        binaryWriter_0.Write(M21);
        binaryWriter_0.Write(M22);
        binaryWriter_0.Write(M23);
        binaryWriter_0.Write(M24);
        binaryWriter_0.Write(M31);
        binaryWriter_0.Write(M32);
        binaryWriter_0.Write(M33);
        binaryWriter_0.Write(M34);
        binaryWriter_0.Write(M41);
        binaryWriter_0.Write(M42);
        binaryWriter_0.Write(M43);
        binaryWriter_0.Write(M44);
    }

    public override string ToString()
    {
        return $"{M11}, {M12}, {M13}, {M14}, {M21}, {M22}, {M23}, {M24}, {M31}, {M32}, {M33}, {M34}, {M41}, {M42}, {M43}, {M44}";
    }
}
