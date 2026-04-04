using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 4, Type = GEnum15.const_16, IsCollection = true)]
internal sealed class Class135 : GClass119
{
    [CompilerGenerated]
    private short short_0;

    [CompilerGenerated]
    private short short_1;

    public short U1
    {
        [CompilerGenerated]
        get
        {
            return short_0;
        }
        [CompilerGenerated]
        set
        {
            short_0 = value;
        }
    }

    public short U2
    {
        [CompilerGenerated]
        get
        {
            return short_1;
        }
        [CompilerGenerated]
        set
        {
            short_1 = value;
        }
    }

    public override string ToString()
    {
        return $"{U1} {U2}";
    }
}
