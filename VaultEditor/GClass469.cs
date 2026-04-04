using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass469 : GClass154
{
    [CompilerGenerated]
    private sbyte sbyte_0;

    [GAttribute1]
    public sbyte Value
    {
        [CompilerGenerated]
        get
        {
            return sbyte_0;
        }
        [CompilerGenerated]
        set
        {
            sbyte_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadSByte();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
