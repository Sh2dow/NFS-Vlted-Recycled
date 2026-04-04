using System;
using System.ComponentModel;

namespace VaultEditor;

internal static class Class191
{
    public static void smethod_0(this Enum enum_0)
    {
        if (!Enum.IsDefined(enum_0.GetType(), enum_0))
        {
            throw new Exception();
        }
    }

    public static string smethod_1(this Enum enum_0)
    {
        DescriptionAttribute[] array = (DescriptionAttribute[])enum_0.GetType().GetField(enum_0.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
        if (array.Length == 0)
        {
            return enum_0.ToString();
        }
        return array[0].Description;
    }
}
