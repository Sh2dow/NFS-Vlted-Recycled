using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass372 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [GAttribute1]
    public int Value1
    {
        [CompilerGenerated]
        get
        {
            return int_3;
        }
        [CompilerGenerated]
        set
        {
            int_3 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
    }
}
