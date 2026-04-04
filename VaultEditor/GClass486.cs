using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace VaultEditor;

public static class GClass486
{
    private static readonly string string_0;

    private static readonly string string_1;

    private static readonly IDictionary<uint, string> idictionary_0;

    private static readonly IDictionary<string, uint> idictionary_1;

    private static readonly IDictionary<string, ulong> idictionary_2;

    private static readonly IDictionary<ulong, string> idictionary_3;

    private static readonly IDictionary<string, uint> idictionary_4;

    private static readonly IDictionary<uint, string> idictionary_5;

    [CompilerGenerated]
    private static readonly uint uint_0;

    [CompilerGenerated]
    private static readonly uint uint_1;

    [CompilerGenerated]
    private static HashSet<uint> hashSet_0;

    public static uint DefaultHash
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
    }

    public static uint CollectionNameHash
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
    }

    public static HashSet<uint> Unresolved
    {
        [CompilerGenerated]
        get
        {
            return hashSet_0;
        }
        [CompilerGenerated]
        set
        {
            hashSet_0 = value;
        }
    }

    static GClass486()
    {
        string_0 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoHashes.txt");
        string_1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserHashes.txt");
        idictionary_0 = new Dictionary<uint, string>();
        idictionary_3 = new Dictionary<ulong, string>();
        idictionary_1 = new Dictionary<string, uint>();
        idictionary_2 = new Dictionary<string, ulong>();
        idictionary_5 = new Dictionary<uint, string>();
        idictionary_4 = new Dictionary<string, uint>();
        Unresolved = [];
        uint_0 = smethod_8("default");
        uint_1 = smethod_8("CollectionName");
        smethod_8("nfsu360");
    }

    public static void smethod_0()
    {
        smethod_4(string_1);
        smethod_4(string_0);
        smethod_2();
        smethod_3();
        smethod_1();
    }

    private static void smethod_1()
    {
        string[] array = Class13.HashBin.Split([Environment.NewLine], StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < array.Length; i++)
        {
            smethod_9(array[i]);
        }
    }

    private static void smethod_2()
    {
        string[] array = Class13.Hashes.Split([Environment.NewLine], StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < array.Length; i++)
        {
            smethod_8(array[i]);
        }
    }

    private static void smethod_3()
    {
        BinaryReader binaryReader = new(new MemoryStream(Class13.hashes64));
        int num = binaryReader.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            ulong num2 = binaryReader.ReadUInt64();
            string text = binaryReader.ReadString();
            if (!idictionary_2.ContainsKey(text))
            {
                idictionary_2.Add(text, num2);
            }
            if (!idictionary_3.ContainsKey(num2))
            {
                idictionary_3.Add(num2, text);
            }
        }
    }

    private static void smethod_4(string string_2)
    {
        if (!File.Exists(string_2))
        {
            return;
        }
        string[] array = File.ReadAllLines(string_2);
        foreach (string text in array)
        {
            if (!text.StartsWith("#"))
            {
                smethod_8(text);
                smethod_9(text);
                smethod_10(text);
            }
        }
    }

    public static string smethod_5(uint uint_2)
    {
        if (idictionary_0.TryGetValue(uint_2, out var value))
        {
            return value;
        }
        return $"0x{uint_2:x8}";
    }

    public static string smethod_6(ulong ulong_0)
    {
        if (!idictionary_3.TryGetValue(ulong_0, out var value))
        {
            return $"0x{ulong_0:x8}";
        }
        return value;
    }

    public static string smethod_7(uint uint_2)
    {
        if (!idictionary_5.TryGetValue(uint_2, out var value))
        {
            return $"0x{uint_2:x8}";
        }
        return value;
    }

    public static uint smethod_8(string string_2, bool bool_0 = false)
    {
        if (string.IsNullOrEmpty(string_2))
        {
            return 0u;
        }
        if (idictionary_1.TryGetValue(string_2, out var value))
        {
            return value;
        }
        if (string_2.smethod_6(out value))
        {
            return value;
        }
        if (bool_0)
        {
            File.AppendAllLines(string_0, new List<string> { string_2 });
        }
        uint num = GClass485.smethod_0(Encoding.ASCII.GetBytes(string_2));
        idictionary_1[string_2] = num;
        idictionary_0[num] = string_2;
        return num;
    }

    public static uint smethod_9(string string_2)
    {
        uint num = uint.MaxValue;
        if (string.IsNullOrEmpty(string_2))
        {
            return num;
        }
        if (idictionary_4.TryGetValue(string_2, out var value))
        {
            return value;
        }
        if (string_2.smethod_6(out value))
        {
            return value;
        }
        foreach (char c in string_2)
        {
            num *= 33;
            num += c;
        }
        idictionary_5[num] = string_2;
        idictionary_4[string_2] = num;
        return num;
    }

    public static ulong smethod_10(string string_2, bool bool_0 = false)
    {
        if (string.IsNullOrEmpty(string_2))
        {
            return 0uL;
        }
        if (idictionary_2.TryGetValue(string_2, out var value))
        {
            return value;
        }
        if (string_2.smethod_7(out value))
        {
            return value;
        }
        if (bool_0)
        {
            File.AppendAllLines(string_0, new List<string> { string_2 });
        }
        ulong num = GClass484.smethod_0(Encoding.ASCII.GetBytes(string_2));
        idictionary_3[num] = string_2;
        idictionary_2[string_2] = num;
        return num;
    }
}
