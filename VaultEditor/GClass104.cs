using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace VaultEditor;

public sealed class GClass104 : UITypeEditor
{
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
        return UITypeEditorEditStyle.None;
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        return value;
    }
}
