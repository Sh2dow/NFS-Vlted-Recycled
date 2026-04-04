using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass504 : GClass500
{
    [CompilerGenerated]
    private sealed class Class221
    {
        public List<string> list_0;

        public Action<GClass154> action_0;

        internal void method_0(GClass154 gclass154_0)
        {
            list_0.AddRange(smethod_0(gclass154_0));
        }
    }

    private readonly HashSet<string> hashSet_0;

    private IDictionary<uint, string> idictionary_0;

    private IDictionary<string, uint> idictionary_1;

    public GClass504()
        : base(GEnum23.const_1)
    {
        hashSet_0 = [];
    }

    public GClass504(GClass483 gclass483_0)
        : base(GEnum23.const_1)
    {
        List<string> list_0 = [];
        foreach (GClass537 row in gclass483_0.Rows)
        {
            row.smethod_0(delegate (GClass154 gclass154_0)
            {
                list_0.AddRange(smethod_0(gclass154_0));
            });
        }
        hashSet_0 = [];
        hashSet_0.UnionWith(list_0);
    }

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        idictionary_0 = new Dictionary<uint, string>();
        long num = binaryReader_0.BaseStream.Position + int_2;
        while (binaryReader_0.BaseStream.Position < num)
        {
            uint key = (uint)binaryReader_0.BaseStream.Position;
            string text = GClass145.smethod_0(binaryReader_0);
            idictionary_0.Add(key, text);
            GClass486.smethod_8(text);
        }
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        idictionary_1 = new Dictionary<string, uint>();
        List<string> list = [.. hashSet_0.Distinct()];
        list.Insert(0, $"NFS-VltEd {GClass0.ToolVersion} by nfsu360");
        foreach (string item in list)
        {
            uint value = (uint)binaryWriter_0.BaseStream.Position;
            GClass145.smethod_1(binaryWriter_0, item);
            if (item != null)
            {
                idictionary_1.Add(item, value);
            }
        }
    }

    public string method_0(uint uint_0)
    {
        idictionary_0.TryGetValue(uint_0, out var value);
        return value ?? string.Empty;
    }

    public uint method_1(string string_0)
    {
        string_0 ??= string.Empty;
        return idictionary_1[string_0];
    }

    public void method_2(string string_0)
    {
        hashSet_0.Add(string_0);
    }

    private static IEnumerable<string> smethod_0(GClass154 gclass154_0)
    {
        return from gclass499_0 in GClass107<GClass499>.smethod_1(gclass154_0)
               select gclass499_0.String_0;
    }
}
