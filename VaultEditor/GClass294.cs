using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass294 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [GAttribute1("R")]
    public float Single_0
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

    [GAttribute1("G")]
    public float Single_1
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

    [GAttribute1("B")]
    public float Single_2
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

    [GAttribute1("A")]
    public float Single_3
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Single_0 = binaryReader_0.ReadSingle();
        Single_1 = binaryReader_0.ReadSingle();
        Single_2 = binaryReader_0.ReadSingle();
        Single_3 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Single_0);
        binaryWriter_0.Write(Single_1);
        binaryWriter_0.Write(Single_2);
        binaryWriter_0.Write(Single_3);
    }

    public override string ToString()
    {
        return $"{Single_0}, {Single_1}, {Single_2}, {Single_3}";
    }
}
