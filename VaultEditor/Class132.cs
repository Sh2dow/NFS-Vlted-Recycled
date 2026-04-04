using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 8, Type = GEnum15.const_9, IsCollection = true)]
internal sealed class Class132 : GClass119
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [TypeConverter(typeof(GClass531))]
    public uint U1
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

    [TypeConverter(typeof(GClass531))]
    public uint U2
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        set
        {
            uint_1 = value;
        }
    }

    public override string ToString()
    {
        return GClass486.smethod_7(U1) + " | " + GClass486.smethod_7(U2);
    }
}
