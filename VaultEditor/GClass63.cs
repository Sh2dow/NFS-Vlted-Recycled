namespace VaultEditor;

public sealed class GClass63(GClass97 gclass97_1, string string_1) : GClass61(gclass97_1)
{
    public string string_0 = string_1;

    public override void vmethod_1()
    {
        gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0 = class84_0.Start;
        gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_1 = class84_1.Start;
        gclass97_0.vmethod_17();
        GClass65.smethod_0(gclass97_0);
        base.vmethod_1();
    }

    public override void vmethod_0()
    {
        gclass97_0.vmethod_18(ref string_0);
        smethod_0(string_0, gclass97_0);
        base.vmethod_0();
    }

    internal static void smethod_0(string string_1, GClass97 gclass97_1)
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_1.FastColoredTextBox_0;
        try
        {
            fastColoredTextBox_.GClass84_5.method_38();
            char char_ = '\0';
            if (gclass97_1.Count == 0)
            {
                GClass62.smethod_1(gclass97_1);
                fastColoredTextBox_.GClass84_5.GStruct10_0 = GStruct10.GStruct10_0;
            }
            fastColoredTextBox_.method_100(fastColoredTextBox_.GClass84_5.GStruct10_0.int_1);
            int length = string_1.Length;
            for (int i = 0; i < length; i++)
            {
                char c = string_1[i];
                if (c == '\r' && (i >= length - 1 || string_1[i + 1] != '\n'))
                {
                    GClass62.smethod_0('\n', ref char_, gclass97_1);
                }
                else
                {
                    GClass62.smethod_0(c, ref char_, gclass97_1);
                }
            }
            gclass97_1.vmethod_15(new GClass97.GEventArgs14(0, 1));
        }
        finally
        {
            fastColoredTextBox_.GClass84_5.method_39();
        }
    }

    public override GClass61 vmethod_3()
    {
        return new GClass63(gclass97_0, string_0);
    }
}
