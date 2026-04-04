using System;
using System.Collections.Generic;

namespace VaultEditor;

public sealed class GClass64 : GClass61
{
    private string string_0;

    private readonly List<GClass84> list_0;

    private readonly List<string> list_1 = [];

    public GClass64(GClass97 gclass97_1, List<GClass84> list_2, string string_1)
        : base(gclass97_1)
    {
        list_2.Sort((gclass84_0, gclass84_1) => (gclass84_0.GStruct10_0.int_1 == gclass84_1.GStruct10_0.int_1) ? gclass84_0.GStruct10_0.int_0.CompareTo(gclass84_1.GStruct10_0.int_0) : gclass84_0.GStruct10_0.int_1.CompareTo(gclass84_1.GStruct10_0.int_1));
        list_0 = list_2;
        string_0 = string_1;
        class84_1 = (class84_0 = new Class84(gclass97_1.FastColoredTextBox_0.GClass84_5));
    }

    public override void vmethod_1()
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_0.FastColoredTextBox_0;
        gclass97_0.vmethod_17();
        fastColoredTextBox_.method_86();
        fastColoredTextBox_.GClass84_5.method_38();
        for (int i = 0; i < list_0.Count; i++)
        {
            fastColoredTextBox_.GClass84_5.GStruct10_0 = list_0[i].GStruct10_0;
            for (int j = 0; j < string_0.Length; j++)
            {
                fastColoredTextBox_.GClass84_5.method_11(bool_1: true);
            }
            smethod_0(gclass97_0);
            GClass63.smethod_0(list_1[list_1.Count - i - 1], gclass97_0);
        }
        fastColoredTextBox_.GClass84_5.method_39();
        fastColoredTextBox_.method_87();
        if (list_0.Count > 0)
        {
            gclass97_0.vmethod_14(list_0[0].GStruct10_0.int_1, list_0[list_0.Count - 1].GStruct10_1.int_1);
        }
        gclass97_0.vmethod_15(new GClass97.GEventArgs14(0, 1));
    }

    public override void vmethod_0()
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_0.FastColoredTextBox_0;
        list_1.Clear();
        gclass97_0.vmethod_18(ref string_0);
        fastColoredTextBox_.GClass84_5.method_38();
        fastColoredTextBox_.method_86();
        for (int num = list_0.Count - 1; num >= 0; num--)
        {
            fastColoredTextBox_.GClass84_5.GStruct10_0 = list_0[num].GStruct10_0;
            fastColoredTextBox_.GClass84_5.GStruct10_1 = list_0[num].GStruct10_1;
            list_1.Add(fastColoredTextBox_.GClass84_5.vmethod_2());
            smethod_0(gclass97_0);
            if (string_0 != "")
            {
                GClass63.smethod_0(string_0, gclass97_0);
            }
        }
        if (list_0.Count > 0)
        {
            gclass97_0.vmethod_14(list_0[0].GStruct10_0.int_1, list_0[list_0.Count - 1].GStruct10_1.int_1);
        }
        fastColoredTextBox_.method_87();
        fastColoredTextBox_.GClass84_5.method_39();
        gclass97_0.vmethod_15(new GClass97.GEventArgs14(0, 1));
        class84_1 = new Class84(fastColoredTextBox_.GClass84_5);
    }

    public override GClass61 vmethod_3()
    {
        return new GClass64(gclass97_0, [.. list_0], string_0);
    }

    internal static void smethod_0(GClass97 gclass97_1)
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_1.FastColoredTextBox_0;
        fastColoredTextBox_.GClass84_5.method_40();
        GStruct10 gStruct10_ = fastColoredTextBox_.GClass84_5.GStruct10_0;
        GStruct10 gStruct10_2 = fastColoredTextBox_.GClass84_5.GStruct10_1;
        int num = Math.Min(gStruct10_2.int_1, gStruct10_.int_1);
        int num2 = Math.Max(gStruct10_2.int_1, gStruct10_.int_1);
        int int32_ = fastColoredTextBox_.GClass84_5.Int32_2;
        int int32_2 = fastColoredTextBox_.GClass84_5.Int32_3;
        if (num >= 0)
        {
            if (num == num2)
            {
                gclass97_1[num].vmethod_1(int32_, int32_2 - int32_);
                return;
            }
            gclass97_1[num].vmethod_1(int32_, gclass97_1[num].Count - int32_);
            gclass97_1[num2].vmethod_1(0, int32_2);
            gclass97_1.vmethod_12(num + 1, num2 - num - 1);
            GClass62.smethod_2(num, gclass97_1);
        }
    }
}
