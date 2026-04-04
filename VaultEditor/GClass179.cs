using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass179 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("LocalizedString")]
    public GClass499 Value1
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

    public GClass179()
    {
        Value1 = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        Value1.imethod_1(binaryWriter_0);
    }
}
