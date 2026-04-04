using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VaultEditor;

public sealed class GClass111
{
    private static void smethod_0(string string_0)
    {
        if (!(string_0 == string.Empty) && !Directory.Exists(string_0))
        {
            Directory.CreateDirectory(string_0);
        }
    }

    public static Stream smethod_1(string string_0, string string_1)
    {
        smethod_0(string_0);
        return new FileStream(Path.Combine(string_0, string_1), FileMode.Open);
    }

    public static Stream smethod_2(string string_0, string string_1)
    {
        smethod_0(string_0);
        return new FileStream(Path.Combine(string_0, string_1), FileMode.Create);
    }

    public static IEnumerable<string> smethod_3(string string_0)
    {
        smethod_0(string_0);
        return Directory.GetFiles(string_0);
    }

    public static IEnumerable<string> smethod_4()
    {
        return from string_0 in Directory.GetDirectories(".")
               where !string_0.StartsWith(".")
               select string_0;
    }

    public static void smethod_5(string string_0, bool bool_0 = false)
    {
        if (File.Exists(string_0))
        {
            string text = (bool_0 ? (string_0 + ".bak") : Path.ChangeExtension(string_0, "bak"));
            if (!File.Exists(text))
            {
                File.Copy(string_0, text);
            }
        }
    }

    public static void smethod_6(string string_0, MemoryStream memoryStream_0)
    {
        File.WriteAllBytes(string_0, memoryStream_0.ToArray());
    }

    public static void smethod_7(string string_0)
    {
        if (File.Exists(string_0))
        {
            FileAttributes attributes = File.GetAttributes(string_0);
            if (attributes.HasFlag(FileAttributes.ReadOnly))
            {
                File.SetAttributes(string_0, attributes & ~FileAttributes.ReadOnly);
            }
        }
    }
}
