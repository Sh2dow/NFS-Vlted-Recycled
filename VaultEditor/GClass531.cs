using System;
using System.ComponentModel;
using System.Globalization;

namespace VaultEditor;

public sealed class GClass531 : TypeConverter
{
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
        if (destinationType == typeof(string))
        {
            return true;
        }
        return false;
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string) && value is uint)
        {
            return GClass486.smethod_7((uint)value);
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is uint)
        {
            return value;
        }
        if (value is ulong)
        {
            return value;
        }
        if (value is string)
        {
            if (uint.TryParse((string)value, out var result))
            {
                return result;
            }
            return GClass486.smethod_9((string)value);
        }
        return base.ConvertFrom(context, culture, value);
    }
}
