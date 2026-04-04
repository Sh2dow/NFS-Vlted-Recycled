using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace VaultEditor;

internal static class Class12
{
    [STAThread]
    private static void Main()
    {
        Version version = (GClass0.ToolVersion = Assembly.GetEntryAssembly().GetName().Version);
        GClass0.ToolVersionString = $"{version.Major}.{version.Minor}";
        CultureInfo cultureInfo = new("en-US");
        Thread.CurrentThread.CurrentCulture = cultureInfo;
        Thread.CurrentThread.CurrentUICulture = cultureInfo;
        GClass486.smethod_0();
        GClass487.smethod_0();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(defaultValue: false);
        Application.Run(new MainForm());
    }
}
