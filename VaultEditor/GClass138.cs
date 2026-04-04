using System;
using System.Collections.Generic;
using System.Linq;

namespace VaultEditor;

public static class GClass138
{
    private static readonly Dictionary<string, byte> dictionary_0 = smethod_0();

    private static Dictionary<string, byte> smethod_0()
    {
        Dictionary<string, byte> dictionary = [];
        for (int i = 0; i <= 255; i++)
        {
            dictionary.Add(i.ToString("X2"), (byte)i);
        }
        return dictionary;
    }

    public static string smethod_1(this byte[] byte_0)
    {
        return BitConverter.ToString(byte_0).Replace("-", " ");
    }

    public static byte[] smethod_2(this string string_0)
    {
        string[] source = string_0.Split(' ');
        List<string> list = [.. source.Where(key => !dictionary_0.ContainsKey(key))];
        if (list.Any())
        {
            throw new Exception("Invalid values: " + string.Join(", ", list));
        }
        return [.. source.Select(key => dictionary_0[key])];
    }
}
