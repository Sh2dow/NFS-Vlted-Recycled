using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass107<T> where T : class
{
    [CompilerGenerated]
    private sealed class Class122
    {
        public object object_0;

        internal T method_0(PropertyInfo propertyInfo_0)
        {
            return propertyInfo_0.GetValue(object_0) as T;
        }
    }

    private static readonly IDictionary<Type, IList<PropertyInfo>> idictionary_0 = new Dictionary<Type, IList<PropertyInfo>>();

    public static IList<PropertyInfo> smethod_0(Type type_0)
    {
        if (!idictionary_0.ContainsKey(type_0))
        {
            List<PropertyInfo> value = [.. (from propertyInfo_0 in type_0.GetProperties()
                                        where typeof(T).IsAssignableFrom(propertyInfo_0.PropertyType)
                                        select propertyInfo_0)];
            idictionary_0.Add(type_0, value);
        }
        return idictionary_0[type_0];
    }

    public static IEnumerable<T> smethod_1(object object_0)
    {
        return from propertyInfo_0 in smethod_0(object_0.GetType())
               select propertyInfo_0.GetValue(object_0) as T;
    }
}
