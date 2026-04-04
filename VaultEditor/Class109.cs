using System;
using System.ComponentModel;

namespace VaultEditor;

internal sealed class Class109(Type type_0) : TypeDescriptionProvider(smethod_0(type_0))
{
    private static TypeDescriptionProvider smethod_0(Type type_0)
    {
        return TypeDescriptor.GetProvider(type_0);
    }

    public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    {
        return new Class110(base.GetTypeDescriptor(objectType, instance), instance);
    }
}
