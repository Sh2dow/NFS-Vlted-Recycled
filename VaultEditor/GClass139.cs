using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace VaultEditor;

public static class GClass139
{
    public static string smethod_0(this object object_0)
    {
        IEnumerable<string> values = object_0.smethod_1();
        return string.Join(", ", values);
    }

    private static IEnumerable<string> smethod_1(this object object_0)
    {
        IEnumerable<GClass150> enumerable = GClass108.smethod_0(object_0.GetType());
        foreach (GClass150 item in enumerable)
        {
            yield return smethod_2(object_0: item.method_0(object_0), gattribute1_0: item.Attribute);
        }
    }

    private static string smethod_2(GAttribute1 gattribute1_0, object object_0)
    {
        TypeConverter typeConverter = Class225.smethod_0(gattribute1_0.DataType);
        if (typeConverter != null)
        {
            return typeConverter.ConvertToString(object_0);
        }
        if (object_0 is IEnumerable source)
        {
            IEnumerable<string> source2 = from object_1 in source.OfType<object>()
                                          select object_1.smethod_0();
            string text = "[" + string.Join("; ", source2.Take(3));
            if (source2.Count() > 3)
            {
                text += "...";
            }
            return text + "]";
        }
        return object_0?.ToString();
    }

    public static bool smethod_3<T>(this T gparam_0, params T[] gparam_1)
    {
        return gparam_1.Contains(gparam_0);
    }
}
