using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass470 : GClass154
{
    [CompilerGenerated]
    private string string_0;

    [GAttribute1(ReadOnly = true)]
    public string Value
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public GClass470()
    {
        Value = "Runtime Linkage";
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
    }
}
