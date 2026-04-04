using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VaultEditor;

internal static class Class185
{
    private static readonly int int_0;

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr intptr_0, int int_1, bool bool_0, int int_2);

    public static void smethod_0(this Control control_0)
    {
        SendMessage(control_0.Handle, 11, bool_0: false, 0);
    }

    public static void smethod_1(this Control control_0)
    {
        SendMessage(control_0.Handle, 11, bool_0: true, 0);
        control_0.Refresh();
    }
}
