using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass464 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [GAttribute1]
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
