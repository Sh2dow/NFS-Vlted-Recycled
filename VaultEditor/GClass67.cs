using System.Collections.Generic;

namespace VaultEditor;

public sealed class GClass67 : GClass61
{
    private readonly List<int> list_0;

    private readonly List<string> list_1 = [];

    public GClass67(GClass97 gclass97_1, List<int> list_2)
        : base(gclass97_1)
    {
        list_2.Sort();
        list_0 = list_2;
        class84_1 = (class84_0 = new Class84(gclass97_1.FastColoredTextBox_0.GClass84_5));
    }

    public override void vmethod_1()
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_0.FastColoredTextBox_0;
        gclass97_0.vmethod_17();
        fastColoredTextBox_.GClass84_5.method_38();
        for (int i = 0; i < list_0.Count; i++)
        {
            int num = list_0[i];
            if (num < gclass97_0.Count)
            {
                fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(0, num);
            }
            else
            {
                fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(gclass97_0[gclass97_0.Count - 1].Count, gclass97_0.Count - 1);
            }
            GClass62.smethod_1(gclass97_0);
            fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(0, num);
            string text = list_1[list_1.Count - i - 1];
            GClass63.smethod_0(text, gclass97_0);
            gclass97_0[num].IsChanged = true;
            if (num < gclass97_0.Count - 1)
            {
                gclass97_0[num + 1].IsChanged = true;
            }
            else
            {
                gclass97_0[num - 1].IsChanged = true;
            }
            if (text.Trim() != string.Empty)
            {
                gclass97_0.vmethod_14(num, num);
            }
        }
        fastColoredTextBox_.GClass84_5.method_39();
        gclass97_0.vmethod_15(new GClass97.GEventArgs14(0, 1));
    }

    public override void vmethod_0()
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_0.FastColoredTextBox_0;
        list_1.Clear();
        gclass97_0.vmethod_17();
        fastColoredTextBox_.GClass84_5.method_38();
        for (int num = list_0.Count - 1; num >= 0; num--)
        {
            int num2 = list_0[num];
            list_1.Add(gclass97_0[num2].vmethod_0());
            gclass97_0.vmethod_10(num2);
        }
        fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(0, 0);
        fastColoredTextBox_.GClass84_5.method_39();
        gclass97_0.vmethod_15(new GClass97.GEventArgs14(0, 1));
        class84_1 = new Class84(fastColoredTextBox_.GClass84_5);
    }

    public override GClass61 vmethod_3()
    {
        return new GClass67(gclass97_0, [.. list_0]);
    }
}
