using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass521
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
    private GClass520 gclass520_0;

    [CompilerGenerated]
    private GClass520 gclass520_1;

    [CompilerGenerated]
    private GClass520 gclass520_2;

    [CompilerGenerated]
    private int int_0;

    public float f1
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

    public float f2
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

    public float f3
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

    public float f4
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

    public float f5
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

    public GClass520 CustomData1
    {
        [CompilerGenerated]
        get
        {
            return gclass520_0;
        }
        [CompilerGenerated]
        set
        {
            gclass520_0 = value;
        }
    }

    public GClass520 CustomData2
    {
        [CompilerGenerated]
        get
        {
            return gclass520_1;
        }
        [CompilerGenerated]
        set
        {
            gclass520_1 = value;
        }
    }

    public GClass520 CustomData3
    {
        [CompilerGenerated]
        get
        {
            return gclass520_2;
        }
        [CompilerGenerated]
        set
        {
            gclass520_2 = value;
        }
    }

    public int u1
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public GClass521()
    {
        CustomData1 = new GClass520(4);
        CustomData2 = new GClass520(4);
        CustomData3 = new GClass520(4);
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        f1 = binaryReader_0.ReadSingle();
        f2 = binaryReader_0.ReadSingle();
        f3 = binaryReader_0.ReadSingle();
        f4 = binaryReader_0.ReadSingle();
        f5 = binaryReader_0.ReadSingle();
        CustomData1.imethod_0(binaryReader_0);
        CustomData2.imethod_0(binaryReader_0);
        CustomData3.imethod_0(binaryReader_0);
        u1 = binaryReader_0.ReadInt32();
    }

    public void method_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(f1);
        binaryWriter_0.Write(f2);
        binaryWriter_0.Write(f3);
        binaryWriter_0.Write(f4);
        binaryWriter_0.Write(f5);
        CustomData1.imethod_1(binaryWriter_0);
        CustomData2.imethod_1(binaryWriter_0);
        CustomData3.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(u1);
    }

    public override string ToString()
    {
        return "Extra data";
    }
}
