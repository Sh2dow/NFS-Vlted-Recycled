using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace VaultEditor;

public sealed class GClass106 : UITypeEditor
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
            IWindowsFormsEditorService windowsFormsEditorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (value is byte[] selectedObject)
            {
                FormBytesEditor formBytesEditor = new()
                {
                    SelectedObject = selectedObject
                };
                windowsFormsEditorService.ShowDialog(formBytesEditor);
                return formBytesEditor.SelectedObject;
            }
            if (value is IList)
            {
                FormCollectionsEditor dialog = new()
                {
                    SelectedObject = (IList)value
                };
                windowsFormsEditorService.ShowDialog(dialog);
            }
            return value;
        }
        return value;
    }
}
