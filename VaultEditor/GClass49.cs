using System;
using System.Windows.Forms;

namespace VaultEditor;

public static class GClass49
{
    public static void smethod_0<T>(this T gparam_0, Action<T> action_0) where T : Control
    {
        try
        {
            if (gparam_0.InvokeRequired)
            {
                gparam_0.Invoke(action_0, gparam_0);
            }
            else
            {
                action_0(gparam_0);
            }
        }
        catch (Exception)
        {
        }
    }
}
