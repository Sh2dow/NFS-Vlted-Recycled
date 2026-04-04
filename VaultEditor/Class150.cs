using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 16, Type = GEnum15.const_11, IsCollection = true)]
internal sealed class Class150 : GClass119
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

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

    [TypeConverter(typeof(GClass531))]
    public uint U3
    {
        [CompilerGenerated]
        get
        {
            return uint_2;
        }
        [CompilerGenerated]
        set
        {
            uint_2 = value;
        }
    }

    [TypeConverter(typeof(GClass531))]
    public uint U4
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        set
        {
            uint_3 = value;
        }
    }

    public override string ToString()
    {
        return GClass486.smethod_7(U1);
    }
}
