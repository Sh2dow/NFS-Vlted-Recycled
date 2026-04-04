using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 4, PreAlignBlock = 128, Type = GEnum15.const_22, IsCollection = true)]
internal sealed class Class165 : GClass119
{
    [CompilerGenerated]
    private float float_0;

    public float U1
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

    public override string ToString()
    {
        return $"{U1}";
    }
}
