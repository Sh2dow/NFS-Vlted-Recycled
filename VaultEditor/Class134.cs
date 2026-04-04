using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 14, Type = GEnum15.const_8, IsCollection = true, PostDataAlign = 4)]
internal sealed class Class134 : GClass119
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private short short_0;

    [TypeConverter(typeof(GClass531))]
    public uint PartName
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

    public short U4
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

    public override string ToString()
    {
        return U4 + ". " + GClass486.smethod_7(PartName);
    }
}
