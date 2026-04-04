using System.Collections.Generic;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GClass109
{
    public static void smethod_0(Form form_0, string string_0)
    {
        FormMessageBox formMessageBox = new()
        {
            String_0 = string_0,
            MessageBoxButtons_0 = MessageBoxButtons.OK
        };
        formMessageBox.ShowDialog(form_0);
    }

    public static void smethod_1(Form form_0, string string_0)
    {
        FormMessageBox formMessageBox = new()
        {
            String_0 = string_0,
            MessageBoxButtons_0 = MessageBoxButtons.OK
        };
        formMessageBox.ShowDialog(form_0);
    }

    public static void smethod_2(Form form_0, string string_0)
    {
        FormMessageBox formMessageBox = new()
        {
            String_0 = string_0,
            MessageBoxButtons_0 = MessageBoxButtons.OK
        };
        formMessageBox.ShowDialog(form_0);
    }

    public static DialogResult smethod_3(Form form_0, string string_0, DialogResult dialogResult_0 = DialogResult.Yes)
    {
        return new FormMessageBox
        {
            String_0 = string_0,
            MessageBoxButtons_0 = MessageBoxButtons.YesNo,
            DialogResult_0 = dialogResult_0
        }.ShowDialog(form_0);
    }

    public static string smethod_4(Form form_0, string string_0, string string_1 = null)
    {
        FormMessageBox formMessageBox = new()
        {
            CurrentMode = FormMessageBox.GEnum0.const_1,
            String_1 = string_1,
            String_0 = string_0,
            MessageBoxButtons_0 = MessageBoxButtons.OKCancel,
            DialogResult_0 = DialogResult.OK
        };
        if (formMessageBox.ShowDialog(form_0) == DialogResult.Cancel)
        {
            return null;
        }
        return formMessageBox.String_1;
    }

    public static IEnumerable<string> smethod_5(Form form_0, string string_0, IDictionary<string, string> idictionary_0)
    {
        FormMessageBox formMessageBox = new()
        {
            CurrentMode = FormMessageBox.GEnum0.const_2,
            String_0 = string_0,
            Options = idictionary_0,
            MessageBoxButtons_0 = MessageBoxButtons.OKCancel,
            DialogResult_0 = DialogResult.OK
        };
        if (formMessageBox.ShowDialog(form_0) == DialogResult.Cancel)
        {
            return new List<string>();
        }
        return formMessageBox.IEnumerable_0;
    }
}
