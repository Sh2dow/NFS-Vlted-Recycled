using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace VaultEditor;

public class GClass492 : CustomTypeDescriptor
{
    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
        return GetProperties();
    }

    public override PropertyDescriptorCollection GetProperties()
    {
        PropertyDescriptorCollection propertyDescriptorCollection = new(null);
        foreach (GClass498 item in method_0(this))
        {
            propertyDescriptorCollection.Add(item);
        }
        return propertyDescriptorCollection;
    }

    private IEnumerable<GClass498> method_0(object object_0)
    {
        Type type = object_0.GetType();
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo propertyInfo in properties)
        {
            GAttribute1 customAttribute = propertyInfo.GetCustomAttribute<GAttribute1>(inherit: true);
            if (customAttribute != null)
            {
                yield return new GClass498(this, object_0, propertyInfo, customAttribute);
            }
        }
    }

    public override object GetPropertyOwner(PropertyDescriptor pd)
    {
        return this;
    }

    public override string ToString()
    {
        return this.smethod_0();
    }
}
