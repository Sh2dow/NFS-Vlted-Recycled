using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass150
{
    private readonly FieldInfo fieldInfo_0;

    private readonly PropertyInfo propertyInfo_0;

    private readonly MemberInfo memberInfo_0;

    [CompilerGenerated]
    private GAttribute1 gattribute1_0;

    public GAttribute1 Attribute
    {
        [CompilerGenerated]
        get
        {
            return gattribute1_0;
        }
        [CompilerGenerated]
        private set
        {
            gattribute1_0 = value;
        }
    }

    public Type Type_0
    {
        get
        {
            if (propertyInfo_0 != null)
            {
                return propertyInfo_0.PropertyType;
            }
            return fieldInfo_0.FieldType;
        }
    }

    public string String_0 => memberInfo_0.Name;

    public Type Type_1 => memberInfo_0.DeclaringType;

    public GClass150(PropertyInfo propertyInfo_1, GAttribute1 gattribute1_1)
    {
        propertyInfo_0 = propertyInfo_1;
        memberInfo_0 = propertyInfo_1;
        Attribute = gattribute1_1;
    }

    public GClass150(FieldInfo fieldInfo_1)
    {
        fieldInfo_0 = fieldInfo_1;
        memberInfo_0 = fieldInfo_1;
    }

    public object method_0(object object_0)
    {
        if (propertyInfo_0 != null)
        {
            return propertyInfo_0.GetValue(object_0);
        }
        return fieldInfo_0.GetValue(object_0);
    }

    public void method_1(object object_0, object object_1)
    {
        if (propertyInfo_0 != null)
        {
            propertyInfo_0.SetValue(object_0, object_1);
        }
        else
        {
            fieldInfo_0.SetValue(object_0, object_1);
        }
    }
}
