using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass168 : GClass154
{
    private ulong ulong_0;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("StringKey")]
    public GClass499 Value
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

    public GClass168()
    {
        Value = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        ulong_0 = binaryReader_0.ReadUInt64();
        binaryReader_0.ReadUInt32();
        Value.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(GClass486.smethod_10(Value.String_0));
        binaryWriter_0.Write(GClass486.smethod_8(Value.String_0));
        Value.imethod_1(binaryWriter_0);
    }
}
