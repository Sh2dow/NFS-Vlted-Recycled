using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class244(string string_3) : GClass541
{
    public static string string_1;

    private readonly string string_2 = string_3;

    [SpecialName]
    public override string vmethod_0()
    {
        return "version " + string_2.smethod_4();
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        if (Version.TryParse(string_2, out var result))
        {
            if (GClass0.ToolVersion < result)
            {
                gClass.method_1($"NFS-VltEd v{result.Major}.{result.Minor} or higher is required");
            }
        }
        else
        {
            gClass.method_1("Unable to parse version: " + string_2);
        }
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
