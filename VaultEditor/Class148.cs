using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 64, Type = GEnum15.const_5, IsCollection = true)]
internal sealed class Class148 : GClass119
{
    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private byte byte_0;

    public int GroupIndex
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        set
        {
            int_1 = value;
        }
    }

    public int MaterialIndex
    {
        [CompilerGenerated]
        get
        {
            return int_2;
        }
        [CompilerGenerated]
        set
        {
            int_2 = value;
        }
    }

    [GAttribute3(36)]
    public string Name
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

    [TypeConverter(typeof(GClass531))]
    public uint Shader
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
    public uint Hash
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

    [GAttribute4(12)]
    public byte p
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    public override string ToString()
    {
        return $"{GroupIndex}.{MaterialIndex} {Name}";
    }
}
