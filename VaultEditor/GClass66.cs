using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass66 : GClass61
{
    public sealed class GClass70
    {
        [CompilerGenerated]
        private GClass84 gclass84_0;

        [CompilerGenerated]
        private string string_0;

        public GClass84 ReplacedRange
        {
            [CompilerGenerated]
            get
            {
                return gclass84_0;
            }
            [CompilerGenerated]
            set
            {
                gclass84_0 = value;
            }
        }

        public string ReplaceText
        {
            [CompilerGenerated]
            get
            {
                return string_0;
            }
            [CompilerGenerated]
            set
            {
                string_0 = value;
            }
        }
    }

    private readonly List<GClass70> list_0;

    private readonly List<string> list_1 = [];

    public GClass66(GClass97 gclass97_1, List<GClass70> list_2)
        : base(gclass97_1)
    {
        list_2.Sort((gclass70_0, gclass70_1) => (gclass70_0.ReplacedRange.GStruct10_0.int_1 == gclass70_1.ReplacedRange.GStruct10_0.int_1) ? gclass70_0.ReplacedRange.GStruct10_0.int_0.CompareTo(gclass70_1.ReplacedRange.GStruct10_0.int_0) : gclass70_0.ReplacedRange.GStruct10_0.int_1.CompareTo(gclass70_1.ReplacedRange.GStruct10_0.int_1));
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
            fastColoredTextBox_.GClass84_5.GStruct10_0 = list_0[i].ReplacedRange.GStruct10_0;
            for (int j = 0; j < list_0[i].ReplaceText.Length; j++)
            {
                fastColoredTextBox_.GClass84_5.method_11(bool_1: true);
            }
            GClass65.smethod_0(gclass97_0);
            int index = list_0.Count - 1 - i;
            GClass63.smethod_0(list_1[index], gclass97_0);
            gclass97_0.vmethod_14(list_0[i].ReplacedRange.GStruct10_0.int_1, list_0[i].ReplacedRange.GStruct10_0.int_1);
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
            fastColoredTextBox_.GClass84_5.GStruct10_0 = list_0[num].ReplacedRange.GStruct10_0;
            fastColoredTextBox_.GClass84_5.GStruct10_1 = list_0[num].ReplacedRange.GStruct10_1;
            list_1.Add(fastColoredTextBox_.GClass84_5.vmethod_2());
            GClass65.smethod_0(gclass97_0);
            GClass63.smethod_0(list_0[num].ReplaceText, gclass97_0);
            gclass97_0.vmethod_14(list_0[num].ReplacedRange.GStruct10_0.int_1, list_0[num].ReplacedRange.GStruct10_1.int_1);
        }
        fastColoredTextBox_.GClass84_5.method_39();
        gclass97_0.vmethod_15(new GClass97.GEventArgs14(0, 1));
        class84_1 = new Class84(fastColoredTextBox_.GClass84_5);
    }

    public override GClass61 vmethod_3()
    {
        return new GClass66(gclass97_0, [.. list_0]);
    }
}
