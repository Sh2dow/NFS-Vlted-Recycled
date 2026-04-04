using System;

namespace VaultEditor;

public sealed class GClass65(GClass97 gclass97_1) : GClass61(gclass97_1)
{
    private string string_0;

    public override void vmethod_1()
    {
        gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0 = new GStruct10(class84_0.Int32_0, Math.Min(class84_0.Start.int_1, class84_0.End.int_1));
        gclass97_0.vmethod_17();
        GClass63.smethod_0(string_0, gclass97_0);
        gclass97_0.vmethod_14(class84_0.Start.int_1, class84_0.End.int_1);
        gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0 = class84_0.Start;
        gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_1 = class84_0.End;
    }

    public override void vmethod_0()
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_0.FastColoredTextBox_0;
        string text = null;
        gclass97_0.vmethod_18(ref text);
        if (text == "")
        {
            throw new ArgumentOutOfRangeException();
        }
        string_0 = fastColoredTextBox_.GClass84_5.vmethod_2();
        smethod_0(gclass97_0);
        class84_1 = new Class84(fastColoredTextBox_.GClass84_5);
        gclass97_0.vmethod_14(class84_1.Start.int_1, class84_1.Start.int_1);
    }

    internal static void smethod_0(GClass97 gclass97_1)
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_1.FastColoredTextBox_0;
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
            }
            else
            {
                gclass97_1[num].vmethod_1(int32_, gclass97_1[num].Count - int32_);
                gclass97_1[num2].vmethod_1(0, int32_2);
                gclass97_1.vmethod_12(num + 1, num2 - num - 1);
                GClass62.smethod_2(num, gclass97_1);
            }
            fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(int32_, num);
            gclass97_1.vmethod_15(new GClass97.GEventArgs14(num, num2));
        }
    }

    public override GClass61 vmethod_3()
    {
        return new GClass65(gclass97_0);
    }
}
