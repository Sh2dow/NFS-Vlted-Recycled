using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass498(object object_2, object object_3, PropertyInfo propertyInfo_1, GAttribute1 gattribute1_1) : PropertyDescriptor(propertyInfo_1.Name, null)
{
    private readonly GAttribute1 gattribute1_0 = gattribute1_1;

    private readonly object object_0 = object_3;

    private readonly PropertyInfo propertyInfo_0 = propertyInfo_1;

    private readonly TypeConverter typeConverter_0 = Class225.smethod_0(gattribute1_1.DataType);

    [CompilerGenerated]
    private readonly object object_1 = object_2;

    public object OwnerObject
    {
        [CompilerGenerated]
        get
        {
            return object_1;
        }
    }

    public override string Description => "Description";

    public override string Name => propertyInfo_0.Name;

    public override string DisplayName => gattribute1_0.Name;

    public override Type ComponentType => propertyInfo_0.DeclaringType;

    public override TypeConverter Converter
    {
        get
        {
            if (typeConverter_0 != null)
            {
                return typeConverter_0;
            }
            return base.Converter;
        }
    }

    public override bool IsReadOnly => gattribute1_0.ReadOnly;

    public override Type PropertyType => propertyInfo_0.PropertyType;

    public GEnum20 GEnum20_0 => gattribute1_0.DataType;

    public override object GetEditor(Type editorBaseType)
    {
        if (gattribute1_0.DataType == GEnum20.const_5)
        {
            return new GClass106();
        }
        return base.GetEditor(editorBaseType);
    }

    public override bool CanResetValue(object component)
    {
        return false;
    }

    public override object GetValue(object component)
    {
        return propertyInfo_0.GetValue(object_0);
    }

    public override void ResetValue(object component)
    {
    }

    public override void SetValue(object component, object value)
    {
        propertyInfo_0.SetValue(object_0, value);
    }

    public override bool ShouldSerializeValue(object component)
    {
        return true;
    }
}
