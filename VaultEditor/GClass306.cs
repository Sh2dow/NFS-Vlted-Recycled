using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass306 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("Value")]
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

    public GClass306()
    {
        Value = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        Value.imethod_1(binaryWriter_0);
    }
}
