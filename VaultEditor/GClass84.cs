using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using TextEditor;

namespace VaultEditor;

public sealed class GClass84(FastColoredTextBox fastColoredTextBox_1) : IEnumerable<GStruct10>, IEnumerable
{
    private GStruct10 gstruct10_0;

    private GStruct10 gstruct10_1;

    public readonly FastColoredTextBox fastColoredTextBox_0 = fastColoredTextBox_1;

    private int int_0 = -1;

    private int int_1;

    private string string_0;

    private List<GStruct10> list_0;

    private int int_2 = -1;

    private bool bool_0;

    public bool Boolean_0
    {
        get
        {
            return bool_0;
        }
        set
        {
            bool_0 = value;
        }
    }

    public GStruct10 GStruct10_0
    {
        get
        {
            return gstruct10_0;
        }
        set
        {
            gstruct10_1 = (gstruct10_0 = value);
            int_0 = -1;
            method_37();
        }
    }

    public GStruct10 GStruct10_1
    {
        get
        {
            return gstruct10_1;
        }
        set
        {
            gstruct10_1 = value;
            method_37();
        }
    }

    public int Int32_0
    {
        get
        {
            if (Boolean_0)
            {
                return method_59(bool_1: false);
            }
            int num = Math.Min(gstruct10_1.int_1, gstruct10_0.int_1);
            int num2 = Math.Max(gstruct10_1.int_1, gstruct10_0.int_1);
            int num3 = 0;
            if (num < 0)
            {
                return 0;
            }
            for (int i = num; i <= num2; i++)
            {
                int num4 = ((i == num) ? Int32_2 : 0);
                int num5 = ((i == num2) ? Math.Min(fastColoredTextBox_0[i].Count - 1, Int32_3 - 1) : (fastColoredTextBox_0[i].Count - 1));
                num3 += num5 - num4 + 1;
                if (i != num2 && num != num2)
                {
                    num3 += Environment.NewLine.Length;
                }
            }
            return num3;
        }
    }

    public int Int32_1
    {
        get
        {
            if (Boolean_0)
            {
                return method_59(bool_1: true);
            }
            return Int32_0;
        }
    }

    public char Char_0
    {
        get
        {
            if (GStruct10_0.int_0 >= fastColoredTextBox_0[GStruct10_0.int_1].Count)
            {
                return '\n';
            }
            return fastColoredTextBox_0[GStruct10_0.int_1][GStruct10_0.int_0].char_0;
        }
    }

    public char Char_1
    {
        get
        {
            if (GStruct10_0.int_0 > fastColoredTextBox_0[GStruct10_0.int_1].Count)
            {
                return '\n';
            }
            if (GStruct10_0.int_0 <= 0)
            {
                return '\n';
            }
            return fastColoredTextBox_0[GStruct10_0.int_1][GStruct10_0.int_0 - 1].char_0;
        }
    }

    internal int Int32_2
    {
        get
        {
            if (gstruct10_1.int_1 < gstruct10_0.int_1)
            {
                return gstruct10_1.int_0;
            }
            if (gstruct10_1.int_1 > gstruct10_0.int_1)
            {
                return gstruct10_0.int_0;
            }
            return Math.Min(gstruct10_1.int_0, gstruct10_0.int_0);
        }
    }

    internal int Int32_3
    {
        get
        {
            if (gstruct10_1.int_1 < gstruct10_0.int_1)
            {
                return gstruct10_0.int_0;
            }
            if (gstruct10_1.int_1 > gstruct10_0.int_1)
            {
                return gstruct10_1.int_0;
            }
            return Math.Max(gstruct10_1.int_0, gstruct10_0.int_0);
        }
    }

    public int Int32_4 => Math.Min(GStruct10_0.int_1, GStruct10_1.int_1);

    public int Int32_5 => Math.Max(GStruct10_0.int_1, GStruct10_1.int_1);

    public IEnumerable<GStruct8> IEnumerable_0
    {
        get
        {
            if (Boolean_0)
            {
                foreach (GStruct10 item in method_58())
                {
                    yield return fastColoredTextBox_0[item];
                }
                yield break;
            }
            int num = Math.Min(gstruct10_1.int_1, gstruct10_0.int_1);
            int num2 = Math.Max(gstruct10_1.int_1, gstruct10_0.int_1);
            int int32_ = Int32_2;
            int int32_2 = Int32_3;
            if (num < 0)
            {
                yield break;
            }
            for (int i = num; i <= num2; i++)
            {
                int num3 = ((i == num) ? int32_ : 0);
                int num4 = ((i == num2) ? Math.Min(int32_2 - 1, fastColoredTextBox_0[i].Count - 1) : (fastColoredTextBox_0[i].Count - 1));
                GClass80 gClass = fastColoredTextBox_0[i];
                for (int j = num3; j <= num4; j++)
                {
                    yield return gClass[j];
                }
            }
        }
    }

    public GStruct11 GStruct11_0
    {
        get
        {
            int int_ = Math.Min(GStruct10_0.int_0, GStruct10_1.int_0);
            int int_2 = Math.Min(GStruct10_0.int_1, GStruct10_1.int_1);
            int int_3 = Math.Max(GStruct10_0.int_0, GStruct10_1.int_0);
            int int_4 = Math.Max(GStruct10_0.int_1, GStruct10_1.int_1);
            return new GStruct11(int_2, int_, int_4, int_3);
        }
    }

    public bool Boolean_1
    {
        get
        {
            if (fastColoredTextBox_0.ReadOnly)
            {
                return true;
            }
            GClass92 gClass = null;
            GClass85[] gClass85_ = fastColoredTextBox_0.GClass85_0;
            foreach (GClass85 gClass2 in gClass85_)
            {
                if (gClass2 is GClass92)
                {
                    gClass = (GClass92)gClass2;
                    break;
                }
            }
            if (gClass != null)
            {
                StyleIndex styleIndex = smethod_0(fastColoredTextBox_0.method_32(gClass));
                if (vmethod_0())
                {
                    GClass80 gClass3 = fastColoredTextBox_0[gstruct10_0.int_1];
                    if (bool_0)
                    {
                        foreach (GClass84 item in method_52(bool_1: false))
                        {
                            gClass3 = fastColoredTextBox_0[item.gstruct10_0.int_1];
                            if (item.gstruct10_0.int_0 < gClass3.Count && item.gstruct10_0.int_0 > 0)
                            {
                                GStruct8 gStruct = gClass3[item.gstruct10_0.int_0 - 1];
                                GStruct8 gStruct2 = gClass3[item.gstruct10_0.int_0];
                                if ((gStruct.styleIndex_0 & styleIndex) != StyleIndex.None && (gStruct2.styleIndex_0 & styleIndex) != StyleIndex.None)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    else if (gstruct10_0.int_0 < gClass3.Count && gstruct10_0.int_0 > 0)
                    {
                        GStruct8 gStruct3 = gClass3[gstruct10_0.int_0 - 1];
                        GStruct8 gStruct4 = gClass3[gstruct10_0.int_0];
                        if ((gStruct3.styleIndex_0 & styleIndex) != StyleIndex.None && (gStruct4.styleIndex_0 & styleIndex) != StyleIndex.None)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    foreach (GStruct8 item2 in IEnumerable_0)
                    {
                        if ((item2.styleIndex_0 & styleIndex) != StyleIndex.None)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        set
        {
            GClass92 gClass = null;
            GClass85[] gClass85_ = fastColoredTextBox_0.GClass85_0;
            foreach (GClass85 gClass2 in gClass85_)
            {
                if (gClass2 is GClass92)
                {
                    gClass = (GClass92)gClass2;
                    break;
                }
            }
            gClass ??= new GClass92();
            if (value)
            {
                method_18(gClass);
                return;
            }
            method_34(gClass);
        }
    }

    private string String_0
    {
        get
        {
            StringBuilder stringBuilder = new();
            GStruct11 gStruct11_ = GStruct11_0;
            if (gStruct11_.int_0 < 0)
            {
                return "";
            }
            for (int i = gStruct11_.int_0; i <= gStruct11_.int_2; i++)
            {
                for (int j = gStruct11_.int_1; j < gStruct11_.int_3; j++)
                {
                    if (j < fastColoredTextBox_0[i].Count)
                    {
                        stringBuilder.Append(fastColoredTextBox_0[i][j].char_0);
                    }
                }
                if (gStruct11_.int_2 != gStruct11_.int_0 && i != gStruct11_.int_2)
                {
                    stringBuilder.AppendLine();
                }
            }
            return stringBuilder.ToString();
        }
    }

    public GClass84(FastColoredTextBox fastColoredTextBox_1, int int_3, int int_4, int int_5, int int_6)
        : this(fastColoredTextBox_1)
    {
        gstruct10_0 = new GStruct10(int_3, int_4);
        gstruct10_1 = new GStruct10(int_5, int_6);
    }

    public GClass84(FastColoredTextBox fastColoredTextBox_1, GStruct10 gstruct10_2, GStruct10 gstruct10_3)
        : this(fastColoredTextBox_1)
    {
        gstruct10_0 = gstruct10_2;
        gstruct10_1 = gstruct10_3;
    }

    public GClass84(FastColoredTextBox fastColoredTextBox_1, int int_3)
        : this(fastColoredTextBox_1)
    {
        gstruct10_0 = new GStruct10(0, int_3);
        gstruct10_1 = new GStruct10(fastColoredTextBox_1[int_3].Count, int_3);
    }

    [SpecialName]
    public bool vmethod_0()
    {
        if (Boolean_0)
        {
            return GStruct10_0.int_0 == GStruct10_1.int_0;
        }
        return GStruct10.smethod_1(GStruct10_0, GStruct10_1);
    }

    public bool method_0(GStruct10 gstruct10_2)
    {
        if (gstruct10_2.int_1 < Math.Min(gstruct10_0.int_1, gstruct10_1.int_1))
        {
            return false;
        }
        if (gstruct10_2.int_1 > Math.Max(gstruct10_0.int_1, gstruct10_1.int_1))
        {
            return false;
        }
        GStruct10 gStruct = gstruct10_0;
        GStruct10 gStruct2 = gstruct10_1;
        if (gStruct.int_1 > gStruct2.int_1 || (gStruct.int_1 == gStruct2.int_1 && gStruct.int_0 > gStruct2.int_0))
        {
            (gStruct2, gStruct) = (gStruct, gStruct2);
        }
        if (bool_0)
        {
            if (gstruct10_2.int_0 < gStruct.int_0 || gstruct10_2.int_0 > gStruct2.int_0)
            {
                return false;
            }
        }
        else
        {
            if (gstruct10_2.int_1 == gStruct.int_1 && gstruct10_2.int_0 < gStruct.int_0)
            {
                return false;
            }
            if (gstruct10_2.int_1 == gStruct2.int_1 && gstruct10_2.int_0 > gStruct2.int_0)
            {
                return false;
            }
        }
        return true;
    }

    public GClass84 vmethod_1(GClass84 gclass84_0)
    {
        if (Boolean_0)
        {
            return method_56(gclass84_0);
        }
        GClass84 gClass = method_6();
        GClass84 gClass2 = gclass84_0.method_6();
        gClass.method_40();
        gClass2.method_40();
        GStruct10 gStruct = (GStruct10.smethod_4(gClass.GStruct10_0, gClass2.GStruct10_0) ? gClass.GStruct10_0 : gClass2.GStruct10_0);
        GStruct10 gStruct2 = (GStruct10.smethod_2(gClass.GStruct10_1, gClass2.GStruct10_1) ? gClass.GStruct10_1 : gClass2.GStruct10_1);
        if (GStruct10.smethod_2(gStruct2, gStruct))
        {
            return new GClass84(fastColoredTextBox_0, gstruct10_0, gstruct10_0);
        }
        return fastColoredTextBox_0.method_96(gStruct, gStruct2);
    }

    public GClass84 method_1(GClass84 gclass84_0)
    {
        GClass84 gClass = method_6();
        GClass84 gClass2 = gclass84_0.method_6();
        gClass.method_40();
        gClass2.method_40();
        GStruct10 gStruct = (GStruct10.smethod_2(gClass.GStruct10_0, gClass2.GStruct10_0) ? gClass.GStruct10_0 : gClass2.GStruct10_0);
        GStruct10 gStruct2 = (GStruct10.smethod_4(gClass.GStruct10_1, gClass2.GStruct10_1) ? gClass.GStruct10_1 : gClass2.GStruct10_1);
        return fastColoredTextBox_0.method_96(gStruct, gStruct2);
    }

    public void method_2()
    {
        Boolean_0 = false;
        GStruct10_0 = new GStruct10(0, 0);
        if (fastColoredTextBox_0.Int32_9 == 0)
        {
            GStruct10_0 = new GStruct10(0, 0);
        }
        else
        {
            gstruct10_1 = new GStruct10(0, 0);
            gstruct10_0 = new GStruct10(fastColoredTextBox_0[fastColoredTextBox_0.Int32_9 - 1].Count, fastColoredTextBox_0.Int32_9 - 1);
        }
        if (this == fastColoredTextBox_0.GClass84_5)
        {
            fastColoredTextBox_0.method_4();
        }
    }

    [SpecialName]
    public string vmethod_2()
    {
        if (Boolean_0)
        {
            return String_0;
        }
        int num = Math.Min(gstruct10_1.int_1, gstruct10_0.int_1);
        int num2 = Math.Max(gstruct10_1.int_1, gstruct10_0.int_1);
        int int32_ = Int32_2;
        int int32_2 = Int32_3;
        if (num < 0)
        {
            return null;
        }
        StringBuilder stringBuilder = new();
        for (int i = num; i <= num2; i++)
        {
            int num3 = ((i == num) ? int32_ : 0);
            int num4 = ((i == num2) ? Math.Min(fastColoredTextBox_0[i].Count - 1, int32_2 - 1) : (fastColoredTextBox_0[i].Count - 1));
            for (int j = num3; j <= num4; j++)
            {
                stringBuilder.Append(fastColoredTextBox_0[i][j].char_0);
            }
            if (i != num2 && num != num2)
            {
                stringBuilder.AppendLine();
            }
        }
        return stringBuilder.ToString();
    }

    internal void method_3(out string string_1, out List<GStruct10> list_1)
    {
        if (fastColoredTextBox_0.TextVersion == int_2)
        {
            string_1 = string_0;
            list_1 = list_0;
            return;
        }
        int num = Math.Min(gstruct10_1.int_1, gstruct10_0.int_1);
        int num2 = Math.Max(gstruct10_1.int_1, gstruct10_0.int_1);
        int int32_ = Int32_2;
        int int32_2 = Int32_3;
        StringBuilder stringBuilder = new((num2 - num) * 50);
        list_1 = new List<GStruct10>(stringBuilder.Capacity);
        if (num >= 0)
        {
            for (int i = num; i <= num2; i++)
            {
                int num3 = ((i == num) ? int32_ : 0);
                int num4 = ((i == num2) ? Math.Min(int32_2 - 1, fastColoredTextBox_0[i].Count - 1) : (fastColoredTextBox_0[i].Count - 1));
                for (int j = num3; j <= num4; j++)
                {
                    stringBuilder.Append(fastColoredTextBox_0[i][j].char_0);
                    list_1.Add(new GStruct10(j, i));
                }
                if (i != num2 && num != num2)
                {
                    string newLine = Environment.NewLine;
                    foreach (char value in newLine)
                    {
                        stringBuilder.Append(value);
                        list_1.Add(new GStruct10(fastColoredTextBox_0[i].Count, i));
                    }
                }
            }
        }
        string_1 = stringBuilder.ToString();
        list_1.Add(GStruct10.smethod_4(GStruct10_1, GStruct10_0) ? GStruct10_1 : GStruct10_0);
        string_0 = string_1;
        list_0 = list_1;
        int_2 = fastColoredTextBox_0.TextVersion;
    }

    public string method_4(int int_3)
    {
        int num = fastColoredTextBox_0.method_91(GStruct10_0) - int_3;
        if (num < 0)
        {
            num = 0;
        }
        return new GClass84(fastColoredTextBox_0, fastColoredTextBox_0.method_92(num), GStruct10_0).vmethod_2();
    }

    public string method_5(int int_3)
    {
        return method_4(-int_3);
    }

    public GClass84 method_6()
    {
        return (GClass84)MemberwiseClone();
    }

    public bool method_7()
    {
        GStruct10 gStruct = gstruct10_0;
        method_11(bool_1: false);
        return GStruct10.smethod_0(gStruct, gstruct10_0);
    }

    public bool vmethod_3()
    {
        if (Boolean_0)
        {
            return method_57();
        }
        if (gstruct10_0.int_1 >= fastColoredTextBox_0.Int32_9 - 1 && gstruct10_0.int_0 >= fastColoredTextBox_0[fastColoredTextBox_0.Int32_9 - 1].Count)
        {
            return false;
        }
        if (gstruct10_0.int_0 < fastColoredTextBox_0[gstruct10_0.int_1].Count)
        {
            gstruct10_0.method_0(1, 0);
        }
        else
        {
            gstruct10_0 = new GStruct10(0, gstruct10_0.int_1 + 1);
        }
        int_0 = -1;
        gstruct10_1 = gstruct10_0;
        method_37();
        return true;
    }

    public bool method_8()
    {
        Boolean_0 = false;
        GStruct10 gStruct = gstruct10_0;
        method_10(bool_1: false);
        return GStruct10.smethod_0(gStruct, gstruct10_0);
    }

    public bool method_9()
    {
        Boolean_0 = false;
        if (gstruct10_0.int_0 == 0 && gstruct10_0.int_1 == 0)
        {
            return false;
        }
        if (gstruct10_0.int_0 > 0)
        {
            gstruct10_0.method_0(-1, 0);
        }
        else
        {
            gstruct10_0 = new GStruct10(fastColoredTextBox_0[gstruct10_0.int_1 - 1].Count, gstruct10_0.int_1 - 1);
        }
        int_0 = -1;
        gstruct10_1 = gstruct10_0;
        method_37();
        return true;
    }

    public void method_10(bool bool_1)
    {
        Boolean_0 = false;
        if (!bool_1 && GStruct10.smethod_4(gstruct10_0, gstruct10_1))
        {
            GStruct10_0 = GStruct10_1;
            return;
        }
        if (gstruct10_0.int_0 != 0 || gstruct10_0.int_1 != 0)
        {
            if (gstruct10_0.int_0 > 0 && fastColoredTextBox_0.list_0[gstruct10_0.int_1].genum10_0 == GEnum10.const_0)
            {
                gstruct10_0.method_0(-1, 0);
            }
            else
            {
                int num = fastColoredTextBox_0.method_105(gstruct10_0.int_1);
                if (num == gstruct10_0.int_1)
                {
                    return;
                }
                gstruct10_0 = new GStruct10(fastColoredTextBox_0[num].Count, num);
            }
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
        int_0 = -1;
    }

    public void method_11(bool bool_1)
    {
        Boolean_0 = false;
        if (!bool_1 && GStruct10.smethod_2(gstruct10_0, gstruct10_1))
        {
            GStruct10_0 = GStruct10_1;
            return;
        }
        if (gstruct10_0.int_1 < fastColoredTextBox_0.Int32_9 - 1 || gstruct10_0.int_0 < fastColoredTextBox_0[fastColoredTextBox_0.Int32_9 - 1].Count)
        {
            if (gstruct10_0.int_0 < fastColoredTextBox_0[gstruct10_0.int_1].Count && fastColoredTextBox_0.list_0[gstruct10_0.int_1].genum10_0 == GEnum10.const_0)
            {
                gstruct10_0.method_0(1, 0);
            }
            else
            {
                int num = fastColoredTextBox_0.method_104(gstruct10_0.int_1);
                if (num == gstruct10_0.int_1)
                {
                    return;
                }
                gstruct10_0 = new GStruct10(0, num);
            }
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
        int_0 = -1;
    }

    internal void method_12(bool bool_1)
    {
        Boolean_0 = false;
        if (!bool_1 && gstruct10_0.int_1 > gstruct10_1.int_1)
        {
            GStruct10_0 = GStruct10_1;
            return;
        }
        if (int_0 < 0)
        {
            int_0 = gstruct10_0.int_0 - fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0));
        }
        int num = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0);
        if (num == 0)
        {
            if (gstruct10_0.int_1 <= 0)
            {
                return;
            }
            int num2 = fastColoredTextBox_0.method_105(gstruct10_0.int_1);
            if (num2 == gstruct10_0.int_1)
            {
                return;
            }
            gstruct10_0.int_1 = num2;
            num = fastColoredTextBox_0.list_0[gstruct10_0.int_1].Int32_0;
        }
        if (num > 0)
        {
            int num3 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_1(num - 1, fastColoredTextBox_0[gstruct10_0.int_1]);
            gstruct10_0.int_0 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(num - 1) + int_0;
            if (gstruct10_0.int_0 > num3 + 1)
            {
                gstruct10_0.int_0 = num3 + 1;
            }
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
    }

    internal void method_13(bool bool_1)
    {
        Boolean_0 = false;
        if (int_0 < 0)
        {
            int_0 = gstruct10_0.int_0 - fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0));
        }
        int num = fastColoredTextBox_0.ClientRectangle.Height / fastColoredTextBox_0.Int32_1 - 1;
        for (int i = 0; i < num; i++)
        {
            int num2 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0);
            if (num2 == 0)
            {
                if (gstruct10_0.int_1 <= 0)
                {
                    break;
                }
                int num3 = fastColoredTextBox_0.method_105(gstruct10_0.int_1);
                if (num3 == gstruct10_0.int_1)
                {
                    break;
                }
                gstruct10_0.int_1 = num3;
                num2 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].Int32_0;
            }
            if (num2 > 0)
            {
                int num4 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_1(num2 - 1, fastColoredTextBox_0[gstruct10_0.int_1]);
                gstruct10_0.int_0 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(num2 - 1) + int_0;
                if (gstruct10_0.int_0 > num4 + 1)
                {
                    gstruct10_0.int_0 = num4 + 1;
                }
            }
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
    }

    internal void method_14(bool bool_1)
    {
        Boolean_0 = false;
        if (!bool_1 && gstruct10_0.int_1 < gstruct10_1.int_1)
        {
            GStruct10_0 = GStruct10_1;
            return;
        }
        if (int_0 < 0)
        {
            int_0 = gstruct10_0.int_0 - fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0));
        }
        int num = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0);
        if (num >= fastColoredTextBox_0.list_0[gstruct10_0.int_1].Int32_0 - 1)
        {
            if (gstruct10_0.int_1 >= fastColoredTextBox_0.Int32_9 - 1)
            {
                return;
            }
            int num2 = fastColoredTextBox_0.method_104(gstruct10_0.int_1);
            if (num2 == gstruct10_0.int_1)
            {
                return;
            }
            gstruct10_0.int_1 = num2;
            num = -1;
        }
        if (num < fastColoredTextBox_0.list_0[gstruct10_0.int_1].Int32_0 - 1)
        {
            int num3 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_1(num + 1, fastColoredTextBox_0[gstruct10_0.int_1]);
            gstruct10_0.int_0 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(num + 1) + int_0;
            if (gstruct10_0.int_0 > num3 + 1)
            {
                gstruct10_0.int_0 = num3 + 1;
            }
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
    }

    internal void method_15(bool bool_1)
    {
        Boolean_0 = false;
        if (int_0 < 0)
        {
            int_0 = gstruct10_0.int_0 - fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0));
        }
        int num = fastColoredTextBox_0.ClientRectangle.Height / fastColoredTextBox_0.Int32_1 - 1;
        for (int i = 0; i < num; i++)
        {
            int num2 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0);
            if (num2 >= fastColoredTextBox_0.list_0[gstruct10_0.int_1].Int32_0 - 1)
            {
                if (gstruct10_0.int_1 >= fastColoredTextBox_0.Int32_9 - 1)
                {
                    break;
                }
                int num3 = fastColoredTextBox_0.method_104(gstruct10_0.int_1);
                if (num3 == gstruct10_0.int_1)
                {
                    break;
                }
                gstruct10_0.int_1 = num3;
                num2 = -1;
            }
            if (num2 < fastColoredTextBox_0.list_0[gstruct10_0.int_1].Int32_0 - 1)
            {
                int num4 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_1(num2 + 1, fastColoredTextBox_0[gstruct10_0.int_1]);
                gstruct10_0.int_0 = fastColoredTextBox_0.list_0[gstruct10_0.int_1].method_0(num2 + 1) + int_0;
                if (gstruct10_0.int_0 > num4 + 1)
                {
                    gstruct10_0.int_0 = num4 + 1;
                }
            }
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
    }

    internal void method_16(bool bool_1)
    {
        Boolean_0 = false;
        if (gstruct10_0.int_1 >= 0 && fastColoredTextBox_0.list_0[gstruct10_0.int_1].genum10_0 == GEnum10.const_0)
        {
            gstruct10_0 = new GStruct10(0, gstruct10_0.int_1);
            if (!bool_1)
            {
                gstruct10_1 = gstruct10_0;
            }
            method_37();
            int_0 = -1;
        }
    }

    internal void method_17(bool bool_1)
    {
        Boolean_0 = false;
        if (gstruct10_0.int_1 >= 0 && fastColoredTextBox_0.list_0[gstruct10_0.int_1].genum10_0 == GEnum10.const_0)
        {
            gstruct10_0 = new GStruct10(fastColoredTextBox_0[gstruct10_0.int_1].Count, gstruct10_0.int_1);
            if (!bool_1)
            {
                gstruct10_1 = gstruct10_0;
            }
            method_37();
            int_0 = -1;
        }
    }

    public void method_18(GClass85 gclass85_0)
    {
        int int_ = fastColoredTextBox_0.method_34(gclass85_0);
        method_24(smethod_0(int_));
        fastColoredTextBox_0.method_4();
    }

    public void method_19(GClass85 gclass85_0, string string_1)
    {
        StyleIndex styleIndex_ = smethod_0(fastColoredTextBox_0.method_34(gclass85_0));
        method_22(styleIndex_, string_1, RegexOptions.None);
    }

    public void method_20(GClass85 gclass85_0, Regex regex_0)
    {
        StyleIndex styleIndex_ = smethod_0(fastColoredTextBox_0.method_34(gclass85_0));
        method_23(styleIndex_, regex_0);
    }

    public void method_21(GClass85 gclass85_0, string string_1, RegexOptions regexOptions_0)
    {
        StyleIndex styleIndex_ = smethod_0(fastColoredTextBox_0.method_34(gclass85_0));
        method_22(styleIndex_, string_1, regexOptions_0);
    }

    public void method_22(StyleIndex styleIndex_0, string string_1, RegexOptions regexOptions_0)
    {
        if (Math.Abs(GStruct10_0.int_1 - GStruct10_1.int_1) > 1000)
        {
            regexOptions_0 |= GClass96.RegexOptions_0;
        }
        foreach (GClass84 item in method_29(string_1, regexOptions_0))
        {
            item.method_24(styleIndex_0);
        }
        fastColoredTextBox_0.method_4();
    }

    public void method_23(StyleIndex styleIndex_0, Regex regex_0)
    {
        foreach (GClass84 item in method_33(regex_0))
        {
            item.method_24(styleIndex_0);
        }
        fastColoredTextBox_0.method_4();
    }

    public void method_24(StyleIndex styleIndex_0)
    {
        int num = Math.Min(GStruct10_1.int_1, GStruct10_0.int_1);
        int num2 = Math.Max(GStruct10_1.int_1, GStruct10_0.int_1);
        int int32_ = Int32_2;
        int int32_2 = Int32_3;
        if (num < 0)
        {
            return;
        }
        for (int i = num; i <= num2; i++)
        {
            int num3 = ((i == num) ? int32_ : 0);
            int num4 = ((i == num2) ? Math.Min(int32_2 - 1, fastColoredTextBox_0[i].Count - 1) : (fastColoredTextBox_0[i].Count - 1));
            for (int j = num3; j <= num4; j++)
            {
                GStruct8 value = fastColoredTextBox_0[i][j];
                value.styleIndex_0 |= styleIndex_0;
                fastColoredTextBox_0[i][j] = value;
            }
        }
    }

    public void method_25(string string_1, string string_2)
    {
        method_26(string_1, string_2, GClass96.RegexOptions_0);
    }

    public void method_26(string string_1, string string_2, RegexOptions regexOptions_0)
    {
        if (string_1 == string_2)
        {
            method_27(string_1, regexOptions_0);
            return;
        }
        foreach (GClass84 item in method_29(string_1, regexOptions_0))
        {
            fastColoredTextBox_0[item.GStruct10_0.int_1].FoldingStartMarker = string_1;
        }
        foreach (GClass84 item2 in method_29(string_2, regexOptions_0))
        {
            fastColoredTextBox_0[item2.GStruct10_0.int_1].FoldingEndMarker = string_1;
        }
        fastColoredTextBox_0.method_4();
    }

    public void method_27(string string_1, RegexOptions regexOptions_0)
    {
        foreach (GClass84 item in method_29(string_1, regexOptions_0))
        {
            if (item.GStruct10_0.int_1 > 0)
            {
                fastColoredTextBox_0[item.GStruct10_0.int_1 - 1].FoldingEndMarker = string_1;
            }
            fastColoredTextBox_0[item.GStruct10_0.int_1].FoldingStartMarker = string_1;
        }
        fastColoredTextBox_0.method_4();
    }

    public IEnumerable<GClass84> method_28(string string_1)
    {
        return method_29(string_1, RegexOptions.None);
    }

    public IEnumerable<GClass84> method_29(string string_1, RegexOptions regexOptions_0)
    {
        method_3(out var string_2, out var list_);
        Regex regex = new(string_1, regexOptions_0);
        foreach (Match item in regex.Matches(string_2))
        {
            GClass84 gClass = new(fastColoredTextBox_0);
            Group obj = item.Groups["range"];
            if (!obj.Success)
            {
                obj = item.Groups[0];
            }
            gClass.GStruct10_0 = list_[obj.Index];
            gClass.GStruct10_1 = list_[obj.Index + obj.Length];
            yield return gClass;
        }
    }

    public IEnumerable<GClass84> method_30(string string_1, RegexOptions regexOptions_0)
    {
        Regex regex_ = new(string_1, regexOptions_0);
        foreach (GClass84 item in method_31(regex_))
        {
            yield return item;
        }
    }

    public IEnumerable<GClass84> method_31(Regex regex_0)
    {
        method_40();
        GClass98 gClass = fastColoredTextBox_0.GClass97_0 as GClass98;
        for (int i = GStruct10_0.int_1; i <= GStruct10_1.int_1; i++)
        {
            bool flag = gClass?.vmethod_3(i) ?? true;
            GClass84 gClass2 = new(fastColoredTextBox_0, new GStruct10(0, i), new GStruct10(fastColoredTextBox_0[i].Count, i));
            if (i == GStruct10_0.int_1 || i == GStruct10_1.int_1)
            {
                gClass2 = gClass2.vmethod_1(this);
            }
            foreach (GClass84 item in gClass2.method_33(regex_0))
            {
                yield return item;
            }
            if (!flag)
            {
                gClass.method_7(i);
            }
        }
    }

    public IEnumerable<GClass84> method_32(string string_1, RegexOptions regexOptions_0)
    {
        method_40();
        Regex regex_ = new(string_1, regexOptions_0);
        GClass98 gClass = fastColoredTextBox_0.GClass97_0 as GClass98;
        for (int num = GStruct10_1.int_1; num >= GStruct10_0.int_1; num--)
        {
            bool flag = gClass?.vmethod_3(num) ?? true;
            GClass84 gClass2 = new(fastColoredTextBox_0, new GStruct10(0, num), new GStruct10(fastColoredTextBox_0[num].Count, num));
            if (num == GStruct10_0.int_1 || num == GStruct10_1.int_1)
            {
                gClass2 = gClass2.vmethod_1(this);
            }
            List<GClass84> list = [.. gClass2.method_33(regex_)];
            for (int num2 = list.Count - 1; num2 >= 0; num2--)
            {
                yield return list[num2];
            }
            if (!flag)
            {
                gClass.method_7(num);
            }
        }
    }

    public IEnumerable<GClass84> method_33(Regex regex_0)
    {
        method_3(out var string_, out var list_);
        foreach (Match item in regex_0.Matches(string_))
        {
            GClass84 gClass = new(fastColoredTextBox_0);
            Group obj = item.Groups["range"];
            if (!obj.Success)
            {
                obj = item.Groups[0];
            }
            gClass.GStruct10_0 = list_[obj.Index];
            gClass.GStruct10_1 = list_[obj.Index + obj.Length];
            yield return gClass;
        }
    }

    public void method_34(params GClass85[] gclass85_0)
    {
        try
        {
            method_35(fastColoredTextBox_0.method_33(gclass85_0));
        }
        catch
        {
        }
    }

    public void method_35(StyleIndex styleIndex_0)
    {
        int num = Math.Min(GStruct10_1.int_1, GStruct10_0.int_1);
        int num2 = Math.Max(GStruct10_1.int_1, GStruct10_0.int_1);
        int int32_ = Int32_2;
        int int32_2 = Int32_3;
        if (num < 0)
        {
            return;
        }
        for (int i = num; i <= num2; i++)
        {
            int num3 = ((i == num) ? int32_ : 0);
            int num4 = ((i == num2) ? Math.Min(int32_2 - 1, fastColoredTextBox_0[i].Count - 1) : (fastColoredTextBox_0[i].Count - 1));
            for (int j = num3; j <= num4; j++)
            {
                GStruct8 value = fastColoredTextBox_0[i][j];
                value.styleIndex_0 &= (StyleIndex)(ushort)(~(int)styleIndex_0);
                fastColoredTextBox_0[i][j] = value;
            }
        }
        fastColoredTextBox_0.method_4();
    }

    public void method_36()
    {
        int num = Math.Min(GStruct10_1.int_1, GStruct10_0.int_1);
        int num2 = Math.Max(GStruct10_1.int_1, GStruct10_0.int_1);
        if (num >= 0)
        {
            for (int i = num; i <= num2; i++)
            {
                fastColoredTextBox_0[i].method_1();
            }
            fastColoredTextBox_0.method_4();
        }
    }

    private void method_37()
    {
        int_2 = -1;
        string_0 = null;
        list_0 = null;
        if (fastColoredTextBox_0.GClass84_5 == this && int_1 == 0)
        {
            fastColoredTextBox_0.vmethod_58();
        }
    }

    public void method_38()
    {
        int_1++;
    }

    public void method_39()
    {
        int_1--;
        if (int_1 == 0)
        {
            method_37();
        }
    }

    public override string ToString()
    {
        return string.Concat("Start: ", GStruct10_0, " End: ", GStruct10_1);
    }

    public void method_40()
    {
        if (GStruct10.smethod_4(GStruct10_0, GStruct10_1))
        {
            method_41();
        }
    }

    public void method_41()
    {
        (gstruct10_1, gstruct10_0) = (gstruct10_0, gstruct10_1);
    }

    public void method_42()
    {
        method_40();
        gstruct10_0 = new GStruct10(0, gstruct10_0.int_1);
        gstruct10_1 = new GStruct10(fastColoredTextBox_0.method_23(gstruct10_1.int_1), gstruct10_1.int_1);
    }

    IEnumerator<GStruct10> IEnumerable<GStruct10>.GetEnumerator()
    {
        if (Boolean_0)
        {
            foreach (GStruct10 item in method_58())
            {
                yield return item;
            }
            yield break;
        }
        int num = Math.Min(gstruct10_1.int_1, gstruct10_0.int_1);
        int num2 = Math.Max(gstruct10_1.int_1, gstruct10_0.int_1);
        int int32_ = Int32_2;
        int int32_2 = Int32_3;
        if (num < 0)
        {
            yield break;
        }
        for (int i = num; i <= num2; i++)
        {
            int num3 = ((i == num) ? int32_ : 0);
            int num4 = ((i == num2) ? Math.Min(int32_2 - 1, fastColoredTextBox_0[i].Count - 1) : (fastColoredTextBox_0[i].Count - 1));
            for (int j = num3; j <= num4; j++)
            {
                yield return new GStruct10(j, i);
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<GStruct10>)this).GetEnumerator();
    }

    public GClass84 method_43(string string_1)
    {
        return method_45(string_1, RegexOptions.None);
    }

    public GClass84 method_44(GClass85 gclass85_0, bool bool_1)
    {
        StyleIndex styleIndex = fastColoredTextBox_0.method_33([gclass85_0]);
        GClass84 gClass = new(fastColoredTextBox_0)
        {
            GStruct10_0 = GStruct10_0
        };
        while (gClass.method_9() && (bool_1 || gClass.Char_0 != '\n'))
        {
            if (gClass.GStruct10_0.int_0 < fastColoredTextBox_0.method_23(gClass.GStruct10_0.int_1) && (fastColoredTextBox_0[gClass.GStruct10_0].styleIndex_0 & styleIndex) == 0)
            {
                gClass.vmethod_3();
                break;
            }
        }
        GStruct10 gStruct10_ = gClass.GStruct10_0;
        gClass.GStruct10_0 = GStruct10_0;
        while ((bool_1 || gClass.Char_0 != '\n') && (gClass.GStruct10_0.int_0 >= fastColoredTextBox_0.method_23(gClass.GStruct10_0.int_1) || (fastColoredTextBox_0[gClass.GStruct10_0].styleIndex_0 & styleIndex) != StyleIndex.None) && gClass.vmethod_3())
        {
        }
        GStruct10 gStruct10_2 = gClass.GStruct10_0;
        return new GClass84(fastColoredTextBox_0, gStruct10_, gStruct10_2);
    }

    public GClass84 method_45(string string_1, RegexOptions regexOptions_0)
    {
        GClass84 gClass = new(fastColoredTextBox_0)
        {
            GStruct10_0 = GStruct10_0
        };
        Regex regex = new(string_1, regexOptions_0);
        while (gClass.method_9())
        {
            if (!regex.IsMatch(gClass.Char_0.ToString()))
            {
                gClass.vmethod_3();
                break;
            }
        }
        GStruct10 gStruct10_ = gClass.GStruct10_0;
        gClass.GStruct10_0 = GStruct10_0;
        while (regex.IsMatch(gClass.Char_0.ToString()) && gClass.vmethod_3())
        {
        }
        GStruct10 gStruct10_2 = gClass.GStruct10_0;
        return new GClass84(fastColoredTextBox_0, gStruct10_, gStruct10_2);
    }

    private bool method_46(char char_0)
    {
        if (!char.IsLetterOrDigit(char_0))
        {
            return char_0 == '_';
        }
        return true;
    }

    private bool method_47(char char_0)
    {
        if (char_0 != ' ')
        {
            return char_0 == '\t';
        }
        return true;
    }

    public void method_48(bool bool_1)
    {
        Boolean_0 = false;
        if (!bool_1 && GStruct10.smethod_4(gstruct10_0, gstruct10_1))
        {
            GStruct10_0 = GStruct10_1;
            return;
        }
        GClass84 gClass = method_6();
        bool flag = false;
        while (method_47(gClass.Char_1))
        {
            flag = true;
            gClass.method_10(bool_1);
        }
        bool flag2 = false;
        while (method_46(gClass.Char_1))
        {
            flag2 = true;
            gClass.method_10(bool_1);
        }
        if (!flag2 && (!flag || gClass.Char_1 != '\n'))
        {
            gClass.method_10(bool_1);
        }
        GStruct10_0 = gClass.GStruct10_0;
        GStruct10_1 = gClass.GStruct10_1;
        if (fastColoredTextBox_0.list_0[GStruct10_0.int_1].genum10_0 != GEnum10.const_0)
        {
            method_11(bool_1);
        }
    }

    public void method_49(bool bool_1, bool bool_2 = false)
    {
        Boolean_0 = false;
        if (!bool_1 && GStruct10.smethod_2(gstruct10_0, gstruct10_1))
        {
            GStruct10_0 = GStruct10_1;
            return;
        }
        GClass84 gClass = method_6();
        bool flag = false;
        if (gClass.Char_0 == '\n')
        {
            gClass.method_11(bool_1);
            flag = true;
        }
        bool flag2 = false;
        while (method_47(gClass.Char_0))
        {
            flag2 = true;
            gClass.method_11(bool_1);
        }
        if (!((flag2 || flag) && bool_2))
        {
            bool flag3 = false;
            while (method_46(gClass.Char_0))
            {
                flag3 = true;
                gClass.method_11(bool_1);
            }
            if (!flag3)
            {
                gClass.method_11(bool_1);
            }
            if (bool_2 && !flag2)
            {
                while (method_47(gClass.Char_0))
                {
                    gClass.method_11(bool_1);
                }
            }
        }
        GStruct10_0 = gClass.GStruct10_0;
        GStruct10_1 = gClass.GStruct10_1;
        if (fastColoredTextBox_0.list_0[GStruct10_0.int_1].genum10_0 != GEnum10.const_0)
        {
            method_10(bool_1);
        }
    }

    internal void method_50(bool bool_1)
    {
        Boolean_0 = false;
        gstruct10_0 = new GStruct10(0, 0);
        if (fastColoredTextBox_0.list_0[GStruct10_0.int_1].genum10_0 != GEnum10.const_0)
        {
            fastColoredTextBox_0.method_100(GStruct10_0.int_1);
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
    }

    internal void method_51(bool bool_1)
    {
        Boolean_0 = false;
        gstruct10_0 = new GStruct10(fastColoredTextBox_0[fastColoredTextBox_0.Int32_9 - 1].Count, fastColoredTextBox_0.Int32_9 - 1);
        if (fastColoredTextBox_0.list_0[GStruct10_0.int_1].genum10_0 != GEnum10.const_0)
        {
            fastColoredTextBox_0.method_100(GStruct10_0.int_1);
        }
        if (!bool_1)
        {
            gstruct10_1 = gstruct10_0;
        }
        method_37();
    }

    public static StyleIndex smethod_0(int int_3)
    {
        return (StyleIndex)(1 << int_3);
    }

    public IEnumerable<GClass84> method_52(bool bool_1)
    {
        if (!Boolean_0)
        {
            yield return this;
            yield break;
        }
        GStruct11 gStruct11_ = GStruct11_0;
        for (int i = gStruct11_.int_0; i <= gStruct11_.int_2; i++)
        {
            if (gStruct11_.int_1 <= fastColoredTextBox_0[i].Count || bool_1)
            {
                yield return new GClass84(fastColoredTextBox_0, gStruct11_.int_1, i, Math.Min(gStruct11_.int_3, fastColoredTextBox_0[i].Count), i);
            }
        }
    }

    public bool method_53()
    {
        if (fastColoredTextBox_0.ReadOnly)
        {
            return true;
        }
        GClass84 gClass = method_6();
        gClass.method_40();
        if (gClass.gstruct10_0.int_0 == 0)
        {
            return false;
        }
        if (Boolean_0)
        {
            gClass.method_63();
        }
        else
        {
            gClass.method_10(bool_1: true);
        }
        return gClass.Boolean_1;
    }

    public bool method_54()
    {
        if (fastColoredTextBox_0.ReadOnly)
        {
            return true;
        }
        GClass84 gClass = method_6();
        gClass.method_40();
        if (gClass.gstruct10_1.int_0 >= fastColoredTextBox_0[gstruct10_1.int_1].Count)
        {
            return false;
        }
        if (Boolean_0)
        {
            gClass.method_62();
        }
        else
        {
            gClass.method_11(bool_1: true);
        }
        return gClass.Boolean_1;
    }

    public IEnumerable<GStruct10> method_55(GStruct10 gstruct10_2, bool bool_1 = false)
    {
        GClass84 gClass;
        if (bool_1)
        {
            gClass = new GClass84(fastColoredTextBox_0, gstruct10_2, gstruct10_2);
            while (gClass.method_8() && GStruct10.smethod_5(gClass.gstruct10_0, GStruct10_0))
            {
                if (gClass.GStruct10_0.int_0 < fastColoredTextBox_0[gClass.GStruct10_0.int_1].Count)
                {
                    yield return gClass.GStruct10_0;
                }
            }
            gClass = new GClass84(fastColoredTextBox_0, GStruct10_1, GStruct10_1);
            while (gClass.method_8() && GStruct10.smethod_5(gClass.gstruct10_0, gstruct10_2))
            {
                if (gClass.GStruct10_0.int_0 < fastColoredTextBox_0[gClass.GStruct10_0.int_1].Count)
                {
                    yield return gClass.GStruct10_0;
                }
            }
            yield break;
        }
        gClass = new GClass84(fastColoredTextBox_0, gstruct10_2, gstruct10_2);
        if (GStruct10.smethod_2(gstruct10_2, GStruct10_1))
        {
            do
            {
                if (gClass.GStruct10_0.int_0 < fastColoredTextBox_0[gClass.GStruct10_0.int_1].Count)
                {
                    yield return gClass.GStruct10_0;
                }
            }
            while (gClass.method_7());
        }
        gClass = new GClass84(fastColoredTextBox_0, GStruct10_0, GStruct10_0);
        if (!GStruct10.smethod_2(gClass.GStruct10_0, gstruct10_2))
        {
            yield break;
        }
        do
        {
            if (gClass.GStruct10_0.int_0 < fastColoredTextBox_0[gClass.GStruct10_0.int_1].Count)
            {
                yield return gClass.GStruct10_0;
            }
        }
        while (gClass.method_7() && GStruct10.smethod_2(gClass.GStruct10_0, gstruct10_2));
    }

    private GClass84 method_56(GClass84 gclass84_0)
    {
        if (gclass84_0.GStruct10_0.int_1 != gclass84_0.GStruct10_1.int_1)
        {
            return new GClass84(fastColoredTextBox_0, GStruct10_0, GStruct10_0);
        }
        GStruct11 gStruct11_ = GStruct11_0;
        if (gclass84_0.GStruct10_0.int_1 >= gStruct11_.int_0 && gclass84_0.GStruct10_0.int_1 <= gStruct11_.int_2)
        {
            return new GClass84(fastColoredTextBox_0, gStruct11_.int_1, gclass84_0.GStruct10_0.int_1, gStruct11_.int_3, gclass84_0.GStruct10_0.int_1).vmethod_1(gclass84_0);
        }
        return new GClass84(fastColoredTextBox_0, GStruct10_0, GStruct10_0);
    }

    private bool method_57()
    {
        GStruct11 gStruct11_ = GStruct11_0;
        bool flag = true;
        for (int i = gStruct11_.int_0; i <= gStruct11_.int_2; i++)
        {
            if (gStruct11_.int_3 < fastColoredTextBox_0[i].Count)
            {
                flag = false;
                break;
            }
        }
        if (flag)
        {
            return false;
        }
        GStruct10 gStruct10_ = GStruct10_0;
        GStruct10 gStruct10_2 = GStruct10_1;
        gStruct10_.method_0(1, 0);
        gStruct10_2.method_0(1, 0);
        method_38();
        GStruct10_0 = gStruct10_;
        GStruct10_1 = gStruct10_2;
        method_39();
        return true;
    }

    private IEnumerable<GStruct10> method_58()
    {
        GStruct11 gStruct11_ = GStruct11_0;
        if (gStruct11_.int_0 < 0)
        {
            yield break;
        }
        for (int i = gStruct11_.int_0; i <= gStruct11_.int_2; i++)
        {
            for (int j = gStruct11_.int_1; j < gStruct11_.int_3; j++)
            {
                if (j < fastColoredTextBox_0[i].Count)
                {
                    yield return new GStruct10(j, i);
                }
            }
        }
    }

    private int method_59(bool bool_1)
    {
        GStruct11 gStruct11_ = GStruct11_0;
        if (gStruct11_.int_0 < 0)
        {
            return 0;
        }
        int num = 0;
        for (int i = gStruct11_.int_0; i <= gStruct11_.int_2; i++)
        {
            for (int j = gStruct11_.int_1; j < gStruct11_.int_3; j++)
            {
                if (j < fastColoredTextBox_0[i].Count)
                {
                    num++;
                }
            }
            if (bool_1 && gStruct11_.int_2 != gStruct11_.int_0 && i != gStruct11_.int_2)
            {
                num += Environment.NewLine.Length;
            }
        }
        return num;
    }

    internal void method_60()
    {
        int int_ = fastColoredTextBox_0.method_104(GStruct10_1.int_1);
        GStruct10_1 = new GStruct10(GStruct10_1.int_0, int_);
    }

    internal void method_61()
    {
        int int_ = fastColoredTextBox_0.method_105(GStruct10_1.int_1);
        GStruct10_1 = new GStruct10(GStruct10_1.int_0, int_);
    }

    internal void method_62()
    {
        GStruct10_1 = new GStruct10(GStruct10_1.int_0 + 1, GStruct10_1.int_1);
    }

    internal void method_63()
    {
        if (GStruct10_1.int_0 > 0)
        {
            GStruct10_1 = new GStruct10(GStruct10_1.int_0 - 1, GStruct10_1.int_1);
        }
    }
}
