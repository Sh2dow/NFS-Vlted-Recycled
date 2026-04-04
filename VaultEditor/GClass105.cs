using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace VaultEditor;

public sealed class GClass105 : UITypeEditor
{
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
        if (context != null && context.Instance != null)
        {
            return UITypeEditorEditStyle.Modal;
        }
        return base.GetEditStyle(context);
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        if (context != null && context.Instance != null && provider != null)
        {
            // Chart editor disabled in .NET 8 migration
            // if (((IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService))).ShowDialog(new FormChartEditor
            // {
            //     SelectedObject = (context.Instance as GClass296)
            // }) == DialogResult.OK)
            // {
            //     return 0;
            // }
            return 0;
        }
        return value;
    }
}
