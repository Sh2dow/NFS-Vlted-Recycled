using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public class GClass51
{
    public string string_0;

    public int int_0 = -1;

    public object object_0;

    private string string_1;

    private string string_2;

    private string string_3;

    [CompilerGenerated]
    private GClass55 gclass55_0;

    public GClass55 Parent
    {
        [CompilerGenerated]
        get
        {
            return gclass55_0;
        }
        [CompilerGenerated]
        internal set
        {
            gclass55_0 = value;
        }
    }

    public GClass51()
    {
    }

    public GClass51(string string_4)
    {
        string_0 = string_4;
    }

    public GClass51(string string_4, int int_1)
        : this(string_4)
    {
        int_0 = int_1;
    }

    public GClass51(string string_4, int int_1, string string_5)
        : this(string_4, int_1)
    {
        string_3 = string_5;
    }

    public GClass51(string string_4, int int_1, string string_5, string string_6, string string_7)
        : this(string_4, int_1, string_5)
    {
        string_1 = string_6;
        string_2 = string_7;
    }

    public virtual string vmethod_0()
    {
        return string_0;
    }

    public virtual GEnum4 vmethod_1(string string_4)
    {
        if (string_0.StartsWith(string_4, StringComparison.InvariantCultureIgnoreCase) && string_0 != string_4)
        {
            return GEnum4.const_2;
        }
        return GEnum4.const_0;
    }

    public virtual string ToString()
    {
        return string_3 ?? string_0;
    }

    public virtual void vmethod_2(GClass55 gclass55_1, GEventArgs1 geventArgs1_0)
    {
    }

    [SpecialName]
    public virtual string vmethod_3()
    {
        return string_1;
    }

    [SpecialName]
    public virtual void vmethod_4(string string_4)
    {
        string_1 = string_4;
    }

    [SpecialName]
    public virtual string vmethod_5()
    {
        return string_2;
    }

    [SpecialName]
    public virtual void vmethod_6(string string_4)
    {
        string_2 = string_4;
    }

    [SpecialName]
    public virtual string vmethod_7()
    {
        return string_3;
    }

    [SpecialName]
    public virtual void vmethod_8(string string_4)
    {
        string_3 = string_4;
    }

    [SpecialName]
    public virtual Color vmethod_9()
    {
        return Color.Transparent;
    }

    [SpecialName]
    public virtual void vmethod_10(Color color_0)
    {
        throw new NotImplementedException("Override this property to change color");
    }

    [SpecialName]
    public virtual Color vmethod_11()
    {
        return Color.Transparent;
    }

    [SpecialName]
    public virtual void vmethod_12(Color color_0)
    {
        throw new NotImplementedException("Override this property to change color");
    }
}
