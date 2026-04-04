using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass462 : GClass154
{
    [CompilerGenerated]
    private bool bool_2;

    [GAttribute1]
    public bool Value
    {
        [CompilerGenerated]
        get
        {
            return bool_2;
        }
        [CompilerGenerated]
        set
        {
            bool_2 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadByte() == 1;
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        if (Value)
        {
            binaryWriter_0.Write((byte)1);
        }
        else
        {
            binaryWriter_0.Write((byte)0);
        }
    }
}
