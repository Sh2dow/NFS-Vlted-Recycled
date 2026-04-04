using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 4, Type = GEnum15.const_15, IsCollection = true)]
internal sealed class Class133 : GClass119
{
    [CompilerGenerated]
    private uint uint_0;

    [TypeConverter(typeof(GClass531))]
    public uint Hash
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        set
        {
            uint_0 = value;
        }
    }

    public override string ToString()
    {
        return GClass486.smethod_7(Hash);
    }
}
