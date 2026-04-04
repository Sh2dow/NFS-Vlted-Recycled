using System;
using System.Collections.Generic;

namespace VaultEditor;

public sealed class GClass68 : GClass61
{
    private readonly GClass61 gclass61_0;

    private readonly GClass84 gclass84_0;

    private readonly List<GClass61> list_0 = [];

    public GClass68(GClass61 gclass61_1)
        : base(gclass61_1.gclass97_0)
    {
        gclass61_0 = gclass61_1;
        gclass84_0 = gclass97_0.FastColoredTextBox_0.GClass84_5.method_6();
    }

    public override void vmethod_0()
    {
        list_0.Clear();
        GClass84 gClass = gclass84_0.method_6();
        int int_ = -1;
        int int_2 = gClass.GStruct10_0.int_1;
        int int_3 = gClass.GStruct10_1.int_1;
        gclass97_0.FastColoredTextBox_0.GClass84_5.Boolean_0 = false;
        gclass97_0.FastColoredTextBox_0.GClass84_5.method_38();
        gclass97_0.FastColoredTextBox_0.method_86();
        gclass97_0.FastColoredTextBox_0.bool_0 = false;
        try
        {
            if (gclass61_0 is GClass63)
            {
                method_0(ref int_, (gclass61_0 as GClass63).string_0);
            }
            else if (gclass61_0 is GClass62 && (gclass61_0 as GClass62).char_0 != 0 && (gclass61_0 as GClass62).char_0 != '\b')
            {
                method_0(ref int_, (gclass61_0 as GClass62).char_0.ToString());
            }
            else
            {
                method_1(ref int_);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
        }
        finally
        {
            gclass97_0.FastColoredTextBox_0.bool_0 = true;
            gclass97_0.FastColoredTextBox_0.method_87();
            gclass97_0.FastColoredTextBox_0.GClass84_5 = gclass84_0;
            if (int_ >= 0)
            {
                gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0 = new GStruct10(int_, int_2);
                gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_1 = new GStruct10(int_, int_3);
            }
            gclass97_0.FastColoredTextBox_0.GClass84_5.Boolean_0 = true;
            gclass97_0.FastColoredTextBox_0.GClass84_5.method_39();
        }
    }

    private void method_0(ref int int_0, string string_0)
    {
        string[] array = string_0.Split('\n');
        int num = 0;
        foreach (GClass84 item in gclass84_0.method_52(bool_1: true))
        {
            GClass80 gClass = gclass97_0.FastColoredTextBox_0[item.GStruct10_0.int_1];
            if (!GStruct10.smethod_2(item.GStruct10_1, item.GStruct10_0) || gClass.Int32_0 != gClass.Count)
            {
                string text = array[num % array.Length];
                if (GStruct10.smethod_2(item.GStruct10_1, item.GStruct10_0) && text != "")
                {
                    text = new string(' ', item.GStruct10_0.int_0 - item.GStruct10_1.int_0) + text;
                    item.GStruct10_0 = item.GStruct10_1;
                }
                gclass97_0.FastColoredTextBox_0.GClass84_5 = item;
                GClass63 gClass2 = new(gclass97_0, text);
                gClass2.vmethod_0();
                if (gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_1.int_0 > int_0)
                {
                    int_0 = gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_1.int_0;
                }
                list_0.Add(gClass2);
            }
            num++;
        }
    }

    private void method_1(ref int int_0)
    {
        foreach (GClass84 item in gclass84_0.method_52(bool_1: false))
        {
            gclass97_0.FastColoredTextBox_0.GClass84_5 = item;
            GClass61 gClass = gclass61_0.vmethod_3();
            gClass.vmethod_0();
            if (gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_1.int_0 > int_0)
            {
                int_0 = gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_1.int_0;
            }
            list_0.Add(gClass);
        }
    }

    public override void vmethod_1()
    {
        gclass97_0.FastColoredTextBox_0.method_86();
        gclass97_0.FastColoredTextBox_0.GClass84_5.method_38();
        try
        {
            for (int num = list_0.Count - 1; num >= 0; num--)
            {
                list_0[num].vmethod_1();
            }
        }
        finally
        {
            gclass97_0.FastColoredTextBox_0.GClass84_5.method_39();
            gclass97_0.FastColoredTextBox_0.method_87();
        }
        gclass97_0.FastColoredTextBox_0.GClass84_5 = gclass84_0.method_6();
        gclass97_0.FastColoredTextBox_0.vmethod_56(gclass84_0);
        gclass97_0.FastColoredTextBox_0.vmethod_58();
        gclass97_0.FastColoredTextBox_0.GClass84_5.Boolean_0 = true;
    }

    public override GClass61 vmethod_3()
    {
        throw new NotImplementedException();
    }
}
