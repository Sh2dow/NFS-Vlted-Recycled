using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace VaultEditor;

internal sealed class Class95 : UITypeEditor
{
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
        return UITypeEditorEditStyle.Modal;
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        if (provider != null && (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService)) != null)
        {
            HotkeysEditorForm hotkeysEditorForm = new(GClass78.smethod_0(value as string));
            if (hotkeysEditorForm.ShowDialog() == DialogResult.OK)
            {
                value = hotkeysEditorForm.method_2().ToString();
            }
        }
        return value;
    }
}
