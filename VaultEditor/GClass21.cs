using System;
using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

public sealed class GClass21 : GClass20
{
    private static readonly char[] char_0 = ['\\', '/'];

    private bool bool_1;

    private int int_0;

    private int int_1;

    private List<string> list_0;

    private List<bool> list_1;

    private List<bool> list_2;

    private List<bool> list_3;

    private List<long?> list_4;

    private List<GEnum3?> list_5;

    private List<DateTime?> list_6;

    private List<DateTime?> list_7;

    private List<DateTime?> list_8;

    private GClass7.GClass10 gclass10_0;

    private Dictionary<GClass7.GClass10, List<GClass5.GClass8>> dictionary_0;

    private HashSet<GClass6.GClass9> hashSet_0;

    private List<GClass6.GClass9> list_9;

    private List<int> list_10;

    public GClass4 method_29(Stream stream_1)
    {
        return method_30(stream_1, null);
    }

    public GClass4 method_30(Stream stream_1, GClass1 gclass1_1)
    {
        if (bool_1)
        {
            throw new InvalidOperationException("Recursive invocation.");
        }
        try
        {
            bool_1 = true;
            list_0 = null;
            list_1 = null;
            list_2 = null;
            list_3 = null;
            list_4 = null;
            list_5 = null;
            list_6 = null;
            list_7 = null;
            list_8 = null;
            int_0 = -1;
            int_1 = -1;
            GClass11 gClass = method_0(stream_1, gclass1_1);
            gclass10_0 = new GClass7.GClass10();
            dictionary_0 = new Dictionary<GClass7.GClass10, List<GClass5.GClass8>>
            {
                { gclass10_0, [] }
            };
            hashSet_0 = [];
            list_9 = [];
            list_10 = [];
            GClass13 gClass2 = null;
            int num = -1;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            List<GClass6> list;
            while (true)
            {
                if (num5 < list_0.Count)
                {
                    string string_ = list_0[num5];
                    bool flag = false;
                    GClass6.GClass9 gClass3 = null;
                    if (list_1 != null && list_1[num5])
                    {
                        bool bool_ = list_2 == null || list_2[num4];
                        if (list_3 != null && list_3[num4])
                        {
                            method_33(dictionary_0[gclass10_0], string_, 0);
                        }
                        else
                        {
                            gClass3 = method_31(dictionary_0[gclass10_0], string_, 0, bool_);
                        }
                        num4++;
                    }
                    else
                    {
                        flag = true;
                        gClass3 = method_31(dictionary_0[gclass10_0], string_, 0, bool_2: true);
                    }
                    if (gClass3 != null)
                    {
                        if (list_4 != null)
                        {
                            gClass3.Offset = list_4[num5] ?? 0L;
                        }
                        if (list_5 != null)
                        {
                            GEnum3? attributes = list_5[num5];
                            if (attributes.HasValue && (attributes.Value & (GEnum3)16) != GEnum3.flag_0)
                            {
                                throw new InvalidDataException();
                            }
                            gClass3.Attributes = attributes;
                        }
                        if (list_6 != null)
                        {
                            gClass3.Creation = list_6[num5];
                        }
                        if (list_7 != null)
                        {
                            gClass3.LastWrite = list_7[num5];
                        }
                        if (list_8 != null)
                        {
                            gClass3.LastAccess = list_8[num5];
                        }
                        if (flag)
                        {
                            while (num2 == num3)
                            {
                                if (num != gClass.DecoderSections.Count - 1)
                                {
                                    gClass2 = gClass.DecoderSections[++num];
                                    num3 = gClass2.Streams.Count;
                                    num2 = 0;
                                    list_10.Add(list_9.Count);
                                    continue;
                                }
                                throw new InvalidDataException();
                            }
                            gClass3.Stream = new GStruct3(num, num2);
                            GStruct2 gStruct = gClass2.Streams[num2++];
                            gClass3.Length = gStruct.Length;
                            gClass3.Checksum = gStruct.Checksum;
                        }
                    }
                    if (flag)
                    {
                        list_9.Add(gClass3);
                    }
                    num5++;
                    continue;
                }
                list = [];
                foreach (GClass6.GClass9 item in list_9)
                {
                    list.Add(hashSet_0.Contains(item) ? item.method_1() : null);
                }
                if (num2 == num3 && num == gClass.DecoderSections.Count - 1)
                {
                    break;
                }
                throw new InvalidDataException();
            }
            list_10.Add(list.Count);
            return new GClass4(gClass, method_38(gclass10_0), [.. list_10], list);
        }
        finally
        {
            bool_1 = false;
        }
    }

    private GClass6.GClass9 method_31(List<GClass5.GClass8> list_11, string string_0, int int_2, bool bool_2)
    {
        int num = string_0.IndexOfAny(char_0, int_2);
        string text;
        if (num < 0)
        {
            text = string_0.Substring(int_2);
            if (bool_2)
            {
                return method_32(list_11, string_0, text);
            }
        }
        else
        {
            text = string_0.Substring(int_2, num - int_2);
        }
        GClass7.GClass10 gClass = null;
        foreach (GClass5.GClass8 item in list_11)
        {
            if (string.Equals(item.Name, text, StringComparison.OrdinalIgnoreCase))
            {
                gClass = item as GClass7.GClass10;
                break;
            }
        }
        if (gClass == null)
        {
            method_34(list_11, text);
            gClass = new GClass7.GClass10
            {
                FullName = ((num < 0) ? string_0 : string_0.Substring(0, num)),
                Name = text
            };
            list_11.Add(gClass);
            dictionary_0.Add(gClass, []);
        }
        if (num < 0)
        {
            return null;
        }
        return method_31(dictionary_0[gClass], string_0, num + 1, bool_2);
    }

    private GClass6.GClass9 method_32(List<GClass5.GClass8> list_11, string string_0, string string_1)
    {
        method_34(list_11, string_1);
        GClass6.GClass9 gClass = new()
        {
            FullName = string_0,
            Name = string_1
        };
        list_11.Add(gClass);
        hashSet_0.Add(gClass);
        return gClass;
    }

    private void method_33(List<GClass5.GClass8> list_11, string string_0, int int_2)
    {
        int num = string_0.IndexOfAny(char_0, int_2);
        if (num < 0)
        {
            string string_1 = string_0.Substring(int_2);
            method_34(list_11, string_1);
            return;
        }
        string b = string_0.Substring(int_2, num - int_2);
        foreach (GClass5.GClass8 item in list_11)
        {
            if (string.Equals(item.Name, b, StringComparison.OrdinalIgnoreCase))
            {
                if (item is GClass7.GClass10 key)
                {
                    method_33(dictionary_0[key], string_0, num + 1);
                }
                break;
            }
        }
    }

    private void method_34(List<GClass5.GClass8> list_11, string string_0)
    {
        int num = 0;
        while (true)
        {
            if (num < list_11.Count)
            {
                if (string.Equals(list_11[num].Name, string_0, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                num++;
                continue;
            }
            return;
        }
        method_35(list_11[num]);
        list_11.RemoveAt(num);
    }

    private void method_35(GClass5.GClass8 gclass8_0)
    {
        if (gclass8_0 is GClass6.GClass9)
        {
            method_36((GClass6.GClass9)gclass8_0);
        }
        if (gclass8_0 is GClass7.GClass10)
        {
            method_37((GClass7.GClass10)gclass8_0);
        }
    }

    private void method_36(GClass6.GClass9 gclass9_0)
    {
        hashSet_0.Remove(gclass9_0);
    }

    private void method_37(GClass7.GClass10 gclass10_1)
    {
        foreach (GClass5.GClass8 item in dictionary_0[gclass10_1])
        {
            method_35(item);
        }
        dictionary_0.Remove(gclass10_1);
    }

    private GClass7 method_38(GClass7.GClass10 gclass10_1)
    {
        foreach (GClass5.GClass8 item in dictionary_0[gclass10_1])
        {
            if (item is GClass7.GClass10)
            {
                gclass10_1.List_0.Add(method_38((GClass7.GClass10)item));
            }
            else
            {
                gclass10_1.List_0.Add(((GClass6.GClass9)item).method_1());
            }
        }
        return gclass10_1.method_3();
    }

    protected override void vmethod_0(int int_2)
    {
        int_0 = int_2;
    }

    protected override void vmethod_1(GClass15 gclass15_0)
    {
        list_0 = new List<string>(gclass15_0.Int32_0);
        for (int i = 0; i < gclass15_0.Int32_0; i++)
        {
            list_0.Add(gclass15_0.method_1());
        }
    }

    protected override void vmethod_4(GClass19 gclass19_0)
    {
        int_1 = 0;
        list_1 = new List<bool>(gclass19_0.Int32_0);
        for (int i = 0; i < gclass19_0.Int32_0; i++)
        {
            bool flag = gclass19_0.method_1();
            list_1.Add(flag);
            if (flag)
            {
                int_1++;
            }
        }
    }

    protected override void vmethod_5(GClass19 gclass19_0)
    {
        list_2 = new List<bool>(gclass19_0.Int32_0);
        for (int i = 0; i < gclass19_0.Int32_0; i++)
        {
            list_2.Add(gclass19_0.method_1());
        }
    }

    protected override void vmethod_6(GClass19 gclass19_0)
    {
        list_3 = new List<bool>(gclass19_0.Int32_0);
        for (int i = 0; i < gclass19_0.Int32_0; i++)
        {
            list_3.Add(gclass19_0.method_1());
        }
    }

    protected override void vmethod_3(GClass17 gclass17_0)
    {
        list_4 = new List<long?>(gclass17_0.Int32_0);
        for (int i = 0; i < gclass17_0.Int32_0; i++)
        {
            list_4.Add(gclass17_0.method_1());
        }
    }

    protected override void vmethod_2(GClass18 gclass18_0)
    {
        list_5 = new List<GEnum3?>(gclass18_0.Int32_0);
        for (int i = 0; i < gclass18_0.Int32_0; i++)
        {
            list_5.Add(gclass18_0.method_1());
        }
    }

    protected override void vmethod_7(GClass16 gclass16_0)
    {
        list_6 = new List<DateTime?>(gclass16_0.Int32_0);
        for (int i = 0; i < gclass16_0.Int32_0; i++)
        {
            list_6.Add(gclass16_0.method_1());
        }
    }

    protected override void vmethod_9(GClass16 gclass16_0)
    {
        list_7 = new List<DateTime?>(gclass16_0.Int32_0);
        for (int i = 0; i < gclass16_0.Int32_0; i++)
        {
            list_7.Add(gclass16_0.method_1());
        }
    }

    protected override void vmethod_8(GClass16 gclass16_0)
    {
        list_8 = new List<DateTime?>(gclass16_0.Int32_0);
        for (int i = 0; i < gclass16_0.Int32_0; i++)
        {
            list_8.Add(gclass16_0.method_1());
        }
    }
}
