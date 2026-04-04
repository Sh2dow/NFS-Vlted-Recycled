using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass509(GClass154 gclass154_1, object object_1, GClass150 gclass150_1, GAttribute1 gattribute1_1) : PropertyDescriptor(gclass150_1.String_0, null)
{
    private readonly GAttribute1 gattribute1_0 = gattribute1_1;

    private readonly object object_0 = object_1;

    private readonly GClass150 gclass150_0 = gclass150_1;

    private readonly TypeConverter typeConverter_0 = Class225.smethod_0(gattribute1_1.DataType);

    [CompilerGenerated]
    private readonly GClass154 gclass154_0 = gclass154_1;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private bool bool_1;

    public GClass154 VltDataItem
    {
        [CompilerGenerated]
        get
        {
            return gclass154_0;
        }
    }

    public string CustomName
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public bool IsArray
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public bool IsMatched
    {
        [CompilerGenerated]
        get
        {
            return bool_1;
        }
        [CompilerGenerated]
        set
        {
            bool_1 = value;
        }
    }

    public override string Category
    {
        get
        {
            if (!IsMatched)
            {
                if (!VltDataItem.Field.Boolean_1)
                {
                    return "Base";
                }
                return "Optional";
            }
            return " Find Results";
        }
    }

    public override string Description => "Description";

    public override string Name => DisplayName;

    public override string DisplayName
    {
        get
        {
            if (IsArray)
            {
                return $"[{VltDataItem.ArrayIndex}]";
            }
            if (VltDataItem.IsSingleValue)
            {
                return GClass486.smethod_5(VltDataItem.Field.NameHash);
            }
            if (!string.IsNullOrWhiteSpace(CustomName))
            {
                return CustomName;
            }
            return gattribute1_0.Name;
        }
    }

    public override Type ComponentType => gclass150_0.Type_1;

    public override TypeConverter Converter => typeConverter_0 ?? base.Converter;

    public override bool IsReadOnly => gattribute1_0.ReadOnly;

    public override Type PropertyType => gclass150_0.Type_0;

    public GEnum20 GEnum20_0 => gattribute1_0.DataType;

    public override object GetEditor(Type editorBaseType)
    {
        return Class224.smethod_0(gattribute1_0.DataType) ?? base.GetEditor(editorBaseType);
    }

    public override bool CanResetValue(object component)
    {
        return false;
    }

    public override object GetValue(object component)
    {
        return gclass150_0.method_0(object_0);
    }

    public override void ResetValue(object component)
    {
    }

    public override void SetValue(object component, object value)
    {
        gclass150_0.method_1(object_0, value);
    }

    public override bool ShouldSerializeValue(object component)
    {
        return true;
    }
}
