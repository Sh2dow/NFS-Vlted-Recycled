using System.Collections.Generic;
using System.ComponentModel;

namespace VaultEditor;

internal static class Class225
{
    private static readonly IDictionary<GEnum20, TypeConverter> idictionary_0;

    static Class225()
    {
        idictionary_0 = new Dictionary<GEnum20, TypeConverter>
        {
            {
                GEnum20.const_0,
                null
            },
            {
                GEnum20.const_1,
                new GClass533()
            },
            {
                GEnum20.const_2,
                new GClass528()
            },
            {
                GEnum20.const_3,
                new GClass532()
            },
            {
                GEnum20.const_4,
                new GClass531()
            },
            {
                GEnum20.const_7,
                new ExpandableObjectConverter()
            },
            {
                GEnum20.const_8,
                new GClass530()
            },
            {
                GEnum20.const_6,
                new GClass529()
            },
            {
                GEnum20.const_5,
                new GClass527()
            }
        };
    }

    public static TypeConverter smethod_0(GEnum20 genum20_0)
    {
        idictionary_0.TryGetValue(genum20_0, out var value);
        return value;
    }
}
