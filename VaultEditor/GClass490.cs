using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass490(object object_1, int int_1) : PropertyDescriptor("property", null)
{
    private readonly int int_0 = int_1;

    [CompilerGenerated]
    private readonly object object_0 = object_1;

    public object Object
    {
        [CompilerGenerated]
        get
        {
            return object_0;
        }
    }

    public override string Category => "Base";

    public override string Description => "Description";

    public override string Name => DisplayName;

    public override string DisplayName => $"[{int_0}]";

    public override Type ComponentType => Object.GetType();

    public override TypeConverter Converter => new ExpandableObjectConverter();

    public override bool IsReadOnly => true;

    public override Type PropertyType => Object.GetType();

    public override bool CanResetValue(object component)
    {
        return false;
    }

    public override object GetValue(object component)
    {
        return Object;
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
