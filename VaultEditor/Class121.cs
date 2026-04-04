using System;
using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

internal sealed class Class121
{
    private static readonly string string_0;

    public static string String_0 => Path.Combine(string_0, "main_log.nfsms");

    static Class121()
    {
        string_0 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
        if (!Directory.Exists(string_0))
        {
            Directory.CreateDirectory(string_0);
        }
    }

    public static void smethod_0(GEnum1 genum1_0, IEnumerable<string> ienumerable_0)
    {
        File.AppendAllLines(smethod_1(genum1_0), ienumerable_0);
    }

    public static string smethod_1(GEnum1 genum1_0)
    {
        string arg = smethod_2(genum1_0);
        return Path.Combine(string_0, $"{arg}_{DateTime.Now:yyyyMMdd}.txt");
    }

    private static string smethod_2(GEnum1 genum1_0)
    {
        return genum1_0 switch
        {
            GEnum1.const_1 => "Underground",
            GEnum1.const_2 => "Underground2",
            GEnum1.const_3 => "MostWanted",
            GEnum1.const_4 => "Carbon",
            GEnum1.const_5 => "ProStreet",
            GEnum1.const_6 => "Undercover",
            GEnum1.const_7 => "World",
            GEnum1.const_8 => "World (Beta)",
            _ => throw new ArgumentOutOfRangeException(),
        };
    }

    public static IList<string> smethod_3(GEnum1 genum1_0)
    {
        if (!Directory.Exists(string_0))
        {
            return [];
        }
        string text = smethod_2(genum1_0);
        return Directory.GetFiles(string_0, text + "_*.txt");
    }

    public static IList<string> smethod_4(string string_1)
    {
        if (!Directory.Exists(string_0))
        {
            return [];
        }
        string path = Path.Combine(string_0, string_1 + ".txt");
        if (!File.Exists(path))
        {
            return [];
        }
        return File.ReadAllLines(path);
    }
}
