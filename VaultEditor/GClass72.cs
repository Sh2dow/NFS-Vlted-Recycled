using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using TextEditor;

namespace VaultEditor;

public sealed class GClass72
{
    public string string_0 = "<style type=\"text/css\"> .lineNumber{font-family : monospace; font-size : small; font-style : normal; font-weight : normal; color : Teal; background-color : ThreedFace;} </style>";

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private bool bool_1;

    [CompilerGenerated]
    private bool bool_2;

    [CompilerGenerated]
    private bool bool_3;

    [CompilerGenerated]
    private bool bool_4;

    [CompilerGenerated]
    private bool bool_5;

    private FastColoredTextBox fastColoredTextBox_0;

    public bool UseNbsp
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

    public bool UseForwardNbsp
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

    public bool UseOriginalFont
    {
        [CompilerGenerated]
        get
        {
            return bool_2;
        }
        [CompilerGenerated]
        set
        {
            bool_2 = value;
        }
    }

    public bool UseStyleTag
    {
        [CompilerGenerated]
        get
        {
            return bool_3;
        }
        [CompilerGenerated]
        set
        {
            bool_3 = value;
        }
    }

    public bool UseBr
    {
        [CompilerGenerated]
        get
        {
            return bool_4;
        }
        [CompilerGenerated]
        set
        {
            bool_4 = value;
        }
    }

    public bool IncludeLineNumbers
    {
        [CompilerGenerated]
        get
        {
            return bool_5;
        }
        [CompilerGenerated]
        set
        {
            bool_5 = value;
        }
    }

    public GClass72()
    {
        UseNbsp = true;
        UseOriginalFont = true;
        UseStyleTag = true;
        UseBr = true;
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
        if (UseOriginalFont)
        {
            stringBuilder.AppendFormat("<font style=\"font-family: {0}, monospace; font-size: {1}pt; line-height: {2}px;\">", gclass84_0.fastColoredTextBox_0.Font.Name, gclass84_0.fastColoredTextBox_0.Font.SizeInPoints, gclass84_0.fastColoredTextBox_0.Int32_1);
        }
        if (IncludeLineNumbers)
        {
            stringBuilder2.AppendFormat("<span class=lineNumber>{0}</span>  ", int_ + 1);
        }
        bool flag = false;
        foreach (GStruct10 item in (IEnumerable<GStruct10>)gclass84_0)
        {
            GStruct8 gStruct = gclass84_0.fastColoredTextBox_0[item.int_1][item.int_0];
            if (gStruct.styleIndex_0 != styleIndex)
            {
                method_4(stringBuilder, stringBuilder2, styleIndex);
                styleIndex = gStruct.styleIndex_0;
                dictionary[styleIndex] = null;
            }
            if (item.int_1 != int_)
            {
                for (int i = int_; i < item.int_1; i++)
                {
                    stringBuilder2.Append(UseBr ? "<br>" : "\r\n");
                    if (IncludeLineNumbers)
                    {
                        stringBuilder2.AppendFormat("<span class=lineNumber>{0}</span>  ", i + 2);
                    }
                }
                int_ = item.int_1;
                flag = false;
            }
            char char_ = gStruct.char_0;
            if ((uint)char_ <= 38u)
            {
                switch (char_)
                {
                    case '&':
                        stringBuilder2.Append("&amp;");
                        continue;
                    case ' ':
                        if ((!flag && UseForwardNbsp) || UseNbsp)
                        {
                            stringBuilder2.Append("&nbsp;");
                            continue;
                        }
                        break;
                }
            }
            else
            {
                switch (char_)
                {
                    case '>':
                        stringBuilder2.Append("&gt;");
                        continue;
                    case '<':
                        stringBuilder2.Append("&lt;");
                        continue;
                }
            }
            flag = true;
            stringBuilder2.Append(gStruct.char_0);
        }
        method_4(stringBuilder, stringBuilder2, styleIndex);
        if (UseOriginalFont)
        {
            stringBuilder.Append("</font>");
        }
        if (UseStyleTag)
        {
            stringBuilder2.Length = 0;
            stringBuilder2.Append("<style type=\"text/css\">");
            foreach (StyleIndex key in dictionary.Keys)
            {
                stringBuilder2.AppendFormat(".fctb{0}{{ {1} }}\r\n", method_3(key), method_2(key));
            }
            stringBuilder2.Append("</style>");
            stringBuilder.Insert(0, stringBuilder2.ToString());
        }
        if (IncludeLineNumbers)
        {
            stringBuilder.Insert(0, string_0);
        }
        return stringBuilder.ToString();
    }

    private string method_2(StyleIndex styleIndex_0)
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
        string text = (flag ? gClass.vmethod_3() : fastColoredTextBox_0.GClass86_0.vmethod_3());
        foreach (GClass85 item in list)
        {
            if (item is not GClass86)
            {
                text += item.vmethod_3();
            }
        }
        return text;
    }

    public static string smethod_0(Color color_0)
    {
        if (color_0 == Color.Transparent)
        {
            return "";
        }
        return $"#{color_0.R:x2}{color_0.G:x2}{color_0.B:x2}";
    }

    private string method_3(StyleIndex styleIndex_0)
    {
        return styleIndex_0.ToString().Replace(" ", "").Replace(",", "");
    }

    private void method_4(StringBuilder stringBuilder_0, StringBuilder stringBuilder_1, StyleIndex styleIndex_0)
    {
        if (stringBuilder_1.Length == 0)
        {
            return;
        }
        if (UseStyleTag)
        {
            stringBuilder_0.AppendFormat("<font class=fctb{0}>{1}</font>", method_3(styleIndex_0), stringBuilder_1.ToString());
        }
        else
        {
            string text = method_2(styleIndex_0);
            if (text != "")
            {
                stringBuilder_0.AppendFormat("<font style=\"{0}\">", text);
            }
            stringBuilder_0.Append(stringBuilder_1.ToString());
            if (text != "")
            {
                stringBuilder_0.Append("</font>");
            }
        }
        stringBuilder_1.Length = 0;
    }
}
