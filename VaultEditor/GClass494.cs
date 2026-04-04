using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass494 : GClass492
{
    [CompilerGenerated]
    private float float_0;

    [GAttribute1("Value")]
    public float Value
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

    public void method_1(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadSingle();
    }

    public void method_2(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }

    public GClass494 method_3()
    {
        return new GClass494
        {
            Value = Value
        };
    }

    public override string ToString()
    {
        return this.smethod_0();
    }
}
