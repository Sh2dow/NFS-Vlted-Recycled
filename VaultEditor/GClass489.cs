using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass489(GClass154 gclass154_1) : PropertyDescriptor("property", null)
{
    [CompilerGenerated]
    private readonly GClass154 gclass154_0 = gclass154_1;

    [CompilerGenerated]
    private bool bool_0;

    public GClass154 VltDataItem
    {
        [CompilerGenerated]
        get
        {
            return gclass154_0;
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

    public override string Category
    {
        get
        {
            if (!VltDataItem.IsMatched)
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
            if (!IsArray)
            {
                return GClass486.smethod_5(VltDataItem.Field.NameHash);
            }
            return $"[{VltDataItem.ArrayIndex}]";
        }
    }

    public override Type ComponentType => VltDataItem.GetType();

    public override TypeConverter Converter => new ExpandableObjectConverter();

    public override bool IsReadOnly => true;

    public override Type PropertyType => VltDataItem.GetType();

    public override bool CanResetValue(object component)
    {
        return false;
    }

    public override object GetValue(object component)
    {
        return VltDataItem;
    }

    public override void ResetValue(object component)
    {
    }

    public override void SetValue(object component, object value)
    {
    }

    public override bool ShouldSerializeValue(object component)
    {
        return false;
    }
}
