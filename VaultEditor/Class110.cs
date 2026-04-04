using System.ComponentModel;
using System.Windows.Forms;

namespace VaultEditor;

internal sealed class Class110(ICustomTypeDescriptor icustomTypeDescriptor_1, object object_1) : CustomTypeDescriptor(icustomTypeDescriptor_1)
{
    private readonly ICustomTypeDescriptor icustomTypeDescriptor_0 = icustomTypeDescriptor_1;

    private readonly object object_0 = object_1;

    public override string GetComponentName()
    {
        if (object_0 is Control control)
        {
            return control.Name;
        }
        return null;
    }

    public override EventDescriptorCollection GetEvents()
    {
        EventDescriptorCollection events = base.GetEvents();
        EventDescriptor[] array = new EventDescriptor[events.Count];
        for (int i = 0; i < events.Count; i++)
        {
            if (events[i].Name == "TextChanged")
            {
                array[i] = new Class111(events[i]);
            }
            else
            {
                array[i] = events[i];
            }
        }
        return new EventDescriptorCollection(array);
    }
}
