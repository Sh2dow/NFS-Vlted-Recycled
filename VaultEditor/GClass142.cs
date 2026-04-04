using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace VaultEditor;

public static class GClass142
{
    public static bool smethod_0(this string string_0, params string[] string_1)
    {
        int num = 0;
        while (true)
        {
            if (num < string_1.Length)
            {
                string value = string_1[num];
                if (string_0.Equals(value, StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                num++;
                continue;
            }
            return false;
        }
        return true;
    }

    public static bool smethod_1(this string string_0, string string_1)
    {
        if (string_1 == null)
        {
            return false;
        }
        return string_0.IndexOf(string_1, StringComparison.CurrentCultureIgnoreCase) >= 0;
    }

    public static bool smethod_2(this string string_0, string string_1)
    {
        if (string_1 == null)
        {
            return false;
        }
        return string_0.StartsWith(string_1, StringComparison.CurrentCultureIgnoreCase);
    }

    public static bool smethod_3(this string string_0, string string_1)
    {
        if (string_1 == null)
        {
            return false;
        }
        return string_0.Equals(string_1, StringComparison.CurrentCultureIgnoreCase);
    }

    public static string smethod_4(this string string_0)
    {
        if (string_0.Any(char.IsWhiteSpace))
        {
            return "\"" + string_0 + "\"";
        }
        return string_0;
    }

    public static IEnumerable<string> smethod_5(this string string_0, bool bool_0 = false)
    {
        return string_0.Split(["\r\n", "\r", "\n"], bool_0 ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None);
    }

    public static bool smethod_6(this string string_0, out uint uint_0)
    {
        uint_0 = 0u;
        if (string_0.StartsWith("0x", StringComparison.InvariantCultureIgnoreCase) && uint.TryParse(string_0.Remove(0, 2), NumberStyles.AllowHexSpecifier, null, out uint_0))
        {
            return true;
        }
        return false;
    }

    public static bool smethod_7(this string string_0, out ulong ulong_0)
    {
        ulong_0 = 0uL;
        if (string_0.StartsWith("0x", StringComparison.InvariantCultureIgnoreCase) && ulong.TryParse(string_0.Remove(0, 2), NumberStyles.AllowHexSpecifier, null, out ulong_0))
        {
            return true;
        }
        return false;
    }

    public static bool smethod_8(this string string_0, out uint uint_0)
    {
        uint_0 = 0u;
        if (uint.TryParse(string_0, out uint_0))
        {
            return true;
        }
        return false;
    }

    public static bool smethod_9(this string string_0, out ulong ulong_0)
    {
        ulong_0 = 0uL;
        if (ulong.TryParse(string_0, out ulong_0))
        {
            return true;
        }
        return false;
    }
}
