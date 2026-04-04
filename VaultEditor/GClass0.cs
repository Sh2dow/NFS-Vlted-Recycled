using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public static class GClass0
{
    [CompilerGenerated]
    private static string string_0;

    [CompilerGenerated]
    private static Version version_0;

    public static string ToolVersionString
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public static Version ToolVersion
    {
        [CompilerGenerated]
        get
        {
            return version_0;
        }
        [CompilerGenerated]
        set
        {
            version_0 = value;
        }
    }

    public static string smethod_0(GEnum1 genum1_0)
    {
        return genum1_0 switch
        {
            GEnum1.const_1 => "Need for Speed: Underground",
            GEnum1.const_2 => "Need for Speed: Underground 2",
            GEnum1.const_3 => "Need for Speed: Most Wanted",
            GEnum1.const_4 => "Need for Speed: Carbon",
            GEnum1.const_5 => "Need for Speed: ProStreet",
            GEnum1.const_6 => "Need for Speed: Undercover",
            GEnum1.const_7 => "Need for Speed: World",
            GEnum1.const_8 => "Need for Speed: World (Alpha)",
            _ => string.Empty,
        };
    }
}
