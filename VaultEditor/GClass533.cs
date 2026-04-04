using System;
using System.ComponentModel;
using System.Globalization;

namespace VaultEditor;

public sealed class GClass533 : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        if (sourceType == typeof(string))
        {
            return true;
        }
        return base.CanConvertFrom(context, sourceType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            return true;
        }
        return base.CanConvertTo(context, destinationType);
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string) && value is uint)
        {
            return $"0x{value:x8}";
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is uint)
        {
            return value;
        }
        if (value is string string_)
        {
            if (string_.smethod_6(out var uint_))
            {
                return uint_;
            }
            if (GClass142.smethod_8(string_, out uint_))
            {
                return uint_;
            }
        }
        return base.ConvertFrom(context, culture, value);
    }
}
