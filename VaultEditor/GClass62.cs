using System;

namespace VaultEditor;

public sealed class GClass62(GClass97 gclass97_1, char char_2) : GClass61(gclass97_1)
{
    public char char_0 = char_2;

    private char char_1;

    public override void vmethod_1()
    {
        gclass97_0.vmethod_17();
        switch (char_0)
        {
            case '\b':
                {
                    gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0 = class84_1.Start;
                    char char_ = '\0';
                    if (char_1 != 0)
                    {
                        gclass97_0.FastColoredTextBox_0.method_100(gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0.int_1);
                        smethod_0(char_1, ref char_, gclass97_0);
                    }
                    break;
                }
            case '\t':
                {
                    gclass97_0.FastColoredTextBox_0.method_100(class84_0.Start.int_1);
                    for (int i = class84_0.Int32_0; i < class84_1.Int32_0; i++)
                    {
                        gclass97_0[class84_0.Start.int_1].RemoveAt(class84_0.Start.int_0);
                    }
                    gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0 = class84_0.Start;
                    break;
                }
            case '\n':
                smethod_2(class84_0.Start.int_1, gclass97_0);
                break;
            default:
                gclass97_0.FastColoredTextBox_0.method_100(class84_0.Start.int_1);
                gclass97_0[class84_0.Start.int_1].RemoveAt(class84_0.Start.int_0);
                gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0 = class84_0.Start;
                break;
            case '\r':
                break;
        }
        gclass97_0.vmethod_15(new GClass97.GEventArgs14(class84_0.Start.int_1, class84_0.Start.int_1));
        base.vmethod_1();
    }

    public override void vmethod_0()
    {
        gclass97_0.FastColoredTextBox_0.method_100(gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0.int_1);
        string string_ = char_0.ToString();
        gclass97_0.vmethod_18(ref string_);
        if (string_.Length == 1)
        {
            char_0 = string_[0];
        }
        if (string.IsNullOrEmpty(string_))
        {
            throw new ArgumentOutOfRangeException();
        }
        if (gclass97_0.Count == 0)
        {
            smethod_1(gclass97_0);
        }
        smethod_0(char_0, ref char_1, gclass97_0);
        gclass97_0.vmethod_15(new GClass97.GEventArgs14(gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0.int_1, gclass97_0.FastColoredTextBox_0.GClass84_5.GStruct10_0.int_1));
        base.vmethod_0();
    }

    internal static void smethod_0(char char_2, ref char char_3, GClass97 gclass97_1)
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_1.FastColoredTextBox_0;
        switch (char_2)
        {
            case '\b':
                if (fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 == 0 && fastColoredTextBox_.GClass84_5.GStruct10_0.int_1 == 0)
                {
                    break;
                }
                if (fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 == 0)
                {
                    if (!gclass97_1.FastColoredTextBox_0.bool_0)
                    {
                        throw new ArgumentOutOfRangeException("Cant insert this char in ColumnRange mode");
                    }
                    if (fastColoredTextBox_.list_0[fastColoredTextBox_.GClass84_5.GStruct10_0.int_1 - 1].genum10_0 != GEnum10.const_0)
                    {
                        fastColoredTextBox_.method_100(fastColoredTextBox_.GClass84_5.GStruct10_0.int_1 - 1);
                    }
                    char_3 = '\n';
                    smethod_2(fastColoredTextBox_.GClass84_5.GStruct10_0.int_1 - 1, gclass97_1);
                }
                else
                {
                    char_3 = gclass97_1[fastColoredTextBox_.GClass84_5.GStruct10_0.int_1][fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 - 1].char_0;
                    gclass97_1[fastColoredTextBox_.GClass84_5.GStruct10_0.int_1].RemoveAt(fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 - 1);
                    fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 - 1, fastColoredTextBox_.GClass84_5.GStruct10_0.int_1);
                }
                break;
            case '\t':
                {
                    int num = fastColoredTextBox_.TabLength - fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 % fastColoredTextBox_.TabLength;
                    if (num == 0)
                    {
                        num = fastColoredTextBox_.TabLength;
                    }
                    for (int i = 0; i < num; i++)
                    {
                        gclass97_1[fastColoredTextBox_.GClass84_5.GStruct10_0.int_1].Insert(fastColoredTextBox_.GClass84_5.GStruct10_0.int_0, new GStruct8(' '));
                    }
                    fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 + num, fastColoredTextBox_.GClass84_5.GStruct10_0.int_1);
                    break;
                }
            case '\n':
                if (!gclass97_1.FastColoredTextBox_0.bool_0)
                {
                    throw new ArgumentOutOfRangeException("Cant insert this char in ColumnRange mode");
                }
                if (gclass97_1.Count == 0)
                {
                    smethod_1(gclass97_1);
                }
                smethod_1(gclass97_1);
                break;
            default:
                gclass97_1[fastColoredTextBox_.GClass84_5.GStruct10_0.int_1].Insert(fastColoredTextBox_.GClass84_5.GStruct10_0.int_0, new GStruct8(char_2));
                fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(fastColoredTextBox_.GClass84_5.GStruct10_0.int_0 + 1, fastColoredTextBox_.GClass84_5.GStruct10_0.int_1);
                break;
            case '\r':
                break;
        }
    }

    internal static void smethod_1(GClass97 gclass97_1)
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_1.FastColoredTextBox_0;
        if (fastColoredTextBox_.Boolean_10 || fastColoredTextBox_.Int32_9 <= 0)
        {
            if (gclass97_1.Count == 0)
            {
                gclass97_1.vmethod_7(0, gclass97_1.vmethod_1());
            }
            else
            {
                smethod_3(fastColoredTextBox_.GClass84_5.GStruct10_0.int_1, fastColoredTextBox_.GClass84_5.GStruct10_0.int_0, gclass97_1);
            }
            fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(0, fastColoredTextBox_.GClass84_5.GStruct10_0.int_1 + 1);
            gclass97_1.vmethod_15(new GClass97.GEventArgs14(0, 1));
        }
    }

    internal static void smethod_2(int int_0, GClass97 gclass97_1)
    {
        FastColoredTextBox fastColoredTextBox_ = gclass97_1.FastColoredTextBox_0;
        if (int_0 + 1 < gclass97_1.Count)
        {
            fastColoredTextBox_.method_100(int_0);
            fastColoredTextBox_.method_100(int_0 + 1);
            int count = gclass97_1[int_0].Count;
            if (gclass97_1[int_0 + 1].Count == 0)
            {
                gclass97_1.vmethod_10(int_0 + 1);
            }
            else
            {
                gclass97_1[int_0].vmethod_3(gclass97_1[int_0 + 1]);
                gclass97_1.vmethod_10(int_0 + 1);
            }
            fastColoredTextBox_.GClass84_5.GStruct10_0 = new GStruct10(count, int_0);
            gclass97_1.vmethod_15(new GClass97.GEventArgs14(0, 1));
        }
    }

    internal static void smethod_3(int int_0, int int_1, GClass97 gclass97_1)
    {
        GClass80 gClass = gclass97_1.vmethod_1();
        for (int i = int_1; i < gclass97_1[int_0].Count; i++)
        {
            gClass.Add(gclass97_1[int_0][i]);
        }
        gclass97_1[int_0].vmethod_1(int_1, gclass97_1[int_0].Count - int_1);
        gclass97_1.vmethod_7(int_0 + 1, gClass);
    }

    public override GClass61 vmethod_3()
    {
        return new GClass62(gclass97_0, char_0);
    }
}
