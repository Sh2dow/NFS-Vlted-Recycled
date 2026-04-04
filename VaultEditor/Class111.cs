using System;
using System.ComponentModel;

namespace VaultEditor;

internal sealed class Class111(MemberDescriptor memberDescriptor_0) : EventDescriptor(memberDescriptor_0)
{
    public override Type ComponentType => typeof(FastColoredTextBox);

    public override Type EventType => typeof(EventHandler);

    public override bool IsMulticast => true;

    public override void AddEventHandler(object component, Delegate value)
    {
        (component as FastColoredTextBox).Event_3 += value as EventHandler;
    }

    public override void RemoveEventHandler(object component, Delegate value)
    {
        (component as FastColoredTextBox).Event_3 -= value as EventHandler;
    }
}
