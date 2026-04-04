using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass212 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private ushort ushort_1;

    [CompilerGenerated]
    private ushort ushort_2;

    [CompilerGenerated]
    private ushort ushort_3;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [GAttribute1("Name")]
    public GClass499 Name
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

    [GAttribute1("CurveStart")]
    public ushort CurveStart
    {
        [CompilerGenerated]
        get
        {
            return ushort_0;
        }
        [CompilerGenerated]
        set
        {
            ushort_0 = value;
        }
    }

    [GAttribute1("CurveCount")]
    public ushort CurveCount
    {
        [CompilerGenerated]
        get
        {
            return ushort_1;
        }
        [CompilerGenerated]
        set
        {
            ushort_1 = value;
        }
    }

    [GAttribute1("TriangleStart")]
    public ushort TriangleStart
    {
        [CompilerGenerated]
        get
        {
            return ushort_2;
        }
        [CompilerGenerated]
        set
        {
            ushort_2 = value;
        }
    }

    [GAttribute1("TriangleCount")]
    public ushort TriangleCount
    {
        [CompilerGenerated]
        get
        {
            return ushort_3;
        }
        [CompilerGenerated]
        set
        {
            ushort_3 = value;
        }
    }

    [GAttribute1("BoundsMinX")]
    public float BoundsMinX
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

    [GAttribute1("BoundsMinY")]
    public float BoundsMinY
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

    [GAttribute1("BoundsMaxX")]
    public float BoundsMaxX
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

    [GAttribute1("BoundsMaxY")]
    public float BoundsMaxY
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

    public GClass212()
    {
        Name = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Name.imethod_0(binaryReader_0);
        CurveStart = binaryReader_0.ReadUInt16();
        CurveCount = binaryReader_0.ReadUInt16();
        TriangleStart = binaryReader_0.ReadUInt16();
        TriangleCount = binaryReader_0.ReadUInt16();
        BoundsMinX = binaryReader_0.ReadSingle();
        BoundsMinY = binaryReader_0.ReadSingle();
        BoundsMaxX = binaryReader_0.ReadSingle();
        BoundsMaxY = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        Name.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(CurveStart);
        binaryWriter_0.Write(CurveCount);
        binaryWriter_0.Write(TriangleStart);
        binaryWriter_0.Write(TriangleCount);
        binaryWriter_0.Write(BoundsMinX);
        binaryWriter_0.Write(BoundsMinY);
        binaryWriter_0.Write(BoundsMaxX);
        binaryWriter_0.Write(BoundsMaxY);
    }
}
