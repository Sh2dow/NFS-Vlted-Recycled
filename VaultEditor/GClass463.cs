using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass463 : GClass154
{
    [CompilerGenerated]
    private double double_0;

    [GAttribute1]
    public double Value
    {
        [CompilerGenerated]
        get
        {
            return double_0;
        }
        [CompilerGenerated]
        set
        {
            double_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadDouble();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
