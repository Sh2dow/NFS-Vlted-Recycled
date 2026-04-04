using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass496 : GClass492
{
    [CompilerGenerated]
    private uint uint_0;

    [GAttribute1("Value", DataType = GEnum20.const_3)]
    public uint Value
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

    public void method_1(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadUInt32();
    }

    public void method_2(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }

    public GClass496 method_3()
    {
        return new GClass496
        {
            Value = Value
        };
    }
}
