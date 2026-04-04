using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using TextEditor;

namespace VaultEditor;

public sealed class GClass73
{
    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private bool bool_1;

    private FastColoredTextBox fastColoredTextBox_0;

    private readonly Dictionary<Color, int> dictionary_0 = [];

    public bool IncludeLineNumbers
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public bool UseOriginalFont
    {
        [CompilerGenerated]
        get
        {
            return bool_1;
        }
        [CompilerGenerated]
        set
        {
            bool_1 = value;
        }
    }

    public GClass73()
    {
        UseOriginalFont = true;
    }

    public string method_0(FastColoredTextBox fastColoredTextBox_1)
    {
        fastColoredTextBox_0 = fastColoredTextBox_1;
        GClass84 gClass = new(fastColoredTextBox_1);
        gClass.method_2();
        return method_1(gClass);
    }

    public string method_1(GClass84 gclass84_0)
    {
        fastColoredTextBox_0 = gclass84_0.fastColoredTextBox_0;
        Dictionary<StyleIndex, object> dictionary = [];
        StringBuilder stringBuilder = new();
        StringBuilder stringBuilder2 = new();
        StyleIndex styleIndex = StyleIndex.None;
        gclass84_0.method_40();
        int int_ = gclass84_0.GStruct10_0.int_1;
        dictionary[StyleIndex.None] = null;
        dictionary_0.Clear();
        int num = method_4(gclass84_0.fastColoredTextBox_0.Color_3);
        if (IncludeLineNumbers)
        {
            stringBuilder2.AppendFormat("{{\\cf{1} {0}}}\\tab", int_ + 1, num);
        }
        foreach (GStruct10 item in (IEnumerable<GStruct10>)gclass84_0)
        {
            GStruct8 gStruct = gclass84_0.fastColoredTextBox_0[item.int_1][item.int_0];
            if (gStruct.styleIndex_0 != styleIndex)
            {
                method_3(stringBuilder, stringBuilder2, styleIndex);
                styleIndex = gStruct.styleIndex_0;
                dictionary[styleIndex] = null;
            }
            if (item.int_1 != int_)
            {
                for (int i = int_; i < item.int_1; i++)
                {
                    stringBuilder2.AppendLine("\\line");
                    if (IncludeLineNumbers)
                    {
                        stringBuilder2.AppendFormat("{{\\cf{1} {0}}}\\tab", i + 2, num);
                    }
                }
                int_ = item.int_1;
            }
            switch (gStruct.char_0)
            {
                case '}':
                    stringBuilder2.Append("\\}");
                    continue;
                case '{':
                    stringBuilder2.Append("\\{");
                    continue;
                case '\\':
                    stringBuilder2.Append("\\\\");
                    continue;
            }
            int char_ = gStruct.char_0;
            if (char_ < 128)
            {
                stringBuilder2.Append(gStruct.char_0);
            }
            else
            {
                stringBuilder2.AppendFormat("{{\\u{0}}}", char_);
            }
        }
        method_3(stringBuilder, stringBuilder2, styleIndex);
        SortedList<int, Color> sortedList = [];
        foreach (KeyValuePair<Color, int> item2 in dictionary_0)
        {
            sortedList.Add(item2.Value, item2.Key);
        }
        stringBuilder2.Length = 0;
        stringBuilder2.AppendFormat("{{\\colortbl;");
        foreach (KeyValuePair<int, Color> item3 in sortedList)
        {
            stringBuilder2.Append(smethod_0(item3.Value) + ";");
        }
        stringBuilder2.AppendLine("}");
        if (UseOriginalFont)
        {
            stringBuilder.Insert(0, string.Format("{{\\fonttbl{{\\f0\\fmodern {0};}}}}{{\\fs{1} ", fastColoredTextBox_0.Font.Name, (int)(2f * fastColoredTextBox_0.Font.SizeInPoints), fastColoredTextBox_0.Int32_1));
            stringBuilder.AppendLine("}");
        }
        stringBuilder.Insert(0, stringBuilder2.ToString());
        stringBuilder.Insert(0, "{\\rtf1\\ud\\deff0");
        stringBuilder.AppendLine("}");
        return stringBuilder.ToString();
    }

    private GClass74 method_2(StyleIndex styleIndex_0)
    {
        List<GClass85> list = [];
        GClass86 gClass = null;
        int num = 1;
        bool flag = false;
        for (int i = 0; i < fastColoredTextBox_0.GClass85_0.Length; i++)
        {
            if (fastColoredTextBox_0.GClass85_0[i] != null && ((uint)styleIndex_0 & (uint)num) != 0 && fastColoredTextBox_0.GClass85_0[i].IsExportable)
            {
                GClass85 gClass2 = fastColoredTextBox_0.GClass85_0[i];
                list.Add(gClass2);
                if (gClass2 is GClass86 && (!flag || fastColoredTextBox_0.AllowSeveralTextStyleDrawing))
                {
                    flag = true;
                    gClass = gClass2 as GClass86;
                }
            }
            num <<= 1;
        }
        if (!flag)
        {
            return fastColoredTextBox_0.GClass86_0.vmethod_4();
        }
        return gClass.vmethod_4();
    }

    public static string smethod_0(Color color_0)
    {
        if (color_0 == Color.Transparent)
        {
            return "";
        }
        return $"\\red{color_0.R}\\green{color_0.G}\\blue{color_0.B}";
    }

    private void method_3(StringBuilder stringBuilder_0, StringBuilder stringBuilder_1, StyleIndex styleIndex_0)
    {
        if (stringBuilder_1.Length != 0)
        {
            GClass74 gClass = method_2(styleIndex_0);
            int num = method_4(gClass.ForeColor);
            int num2 = method_4(gClass.BackColor);
            StringBuilder stringBuilder = new();
            if (num >= 0)
            {
                stringBuilder.AppendFormat("\\cf{0}", num);
            }
            if (num2 >= 0)
            {
                stringBuilder.AppendFormat("\\highlight{0}", num2);
            }
            if (!string.IsNullOrEmpty(gClass.AdditionalTags))
            {
                stringBuilder.Append(gClass.AdditionalTags.Trim());
            }
            if (stringBuilder.Length > 0)
            {
                stringBuilder_0.AppendFormat("{{{0} {1}}}", stringBuilder, stringBuilder_1.ToString());
            }
            else
            {
                stringBuilder_0.Append(stringBuilder_1.ToString());
            }
            stringBuilder_1.Length = 0;
        }
    }

    private int method_4(Color color_0)
    {
        if (color_0.A == 0)
        {
            return -1;
        }
        if (!dictionary_0.ContainsKey(color_0))
        {
            dictionary_0[color_0] = dictionary_0.Count + 1;
        }
        return dictionary_0[color_0];
    }
}
