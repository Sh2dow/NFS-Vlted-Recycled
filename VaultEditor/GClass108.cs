using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace VaultEditor;

public sealed class GClass108
{
    private static readonly IDictionary<Type, IList<GClass150>> idictionary_0 = new Dictionary<Type, IList<GClass150>>();

    public static IEnumerable<GClass150> smethod_0(Type type_0)
    {
        if (!idictionary_0.ContainsKey(type_0))
        {
            IList<GClass150> list = [];
            PropertyInfo[] properties = type_0.GetProperties();
            foreach (PropertyInfo propertyInfo in properties)
            {
                List<GAttribute1> list2 = [.. propertyInfo.GetCustomAttributes(typeof(GAttribute1), inherit: true).OfType<GAttribute1>()];
                if (list2.Count == 1)
                {
                    list.Add(new GClass150(propertyInfo, list2[0]));
                }
            }
            idictionary_0.Add(type_0, list);
        }
        return idictionary_0[type_0];
    }
}
