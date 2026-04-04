using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace VaultEditor;

public sealed class GClass527 : CollectionConverter
{
    public override bool GetPropertiesSupported(ITypeDescriptorContext context)
    {
        return false;
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        if (sourceType == typeof(string))
        {
            return true;
        }
        return false;
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        return false;
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            if (value is byte[] byte_)
            {
                return byte_.smethod_1();
            }
            if (value is IEnumerable enumerable)
            {
                IList<string> list = [];
                foreach (object item in enumerable)
                {
                    list.Add(item.smethod_0());
                }
                string text = "[" + string.Join("; ", list.Take(3));
                if (list.Count > 3)
                {
                    text += "...";
                }
                return text + "]";
            }
            return value?.ToString();
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string string_)
        {
            return string_.smethod_2();
        }
        if (value is byte[])
        {
            return value;
        }
        return base.ConvertFrom(context, culture, value);
    }

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
        return new PropertyDescriptorCollection([]);
    }
}
