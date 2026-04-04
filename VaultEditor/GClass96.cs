using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml;
using TextEditor;

namespace VaultEditor;

public sealed class GClass96(FastColoredTextBox fastColoredTextBox_1) : IDisposable
{
    private sealed class Class108
    {
        public string string_0;

        public int int_0;

        public int int_1;

        public string String_0 => string_0 + int_0;
    }

    protected static readonly GEnum12 genum12_0 = GClass83.smethod_0();

    public readonly GClass85 gclass85_0 = new GClass86(Brushes.Blue, null, FontStyle.Bold);

    public readonly GClass85 gclass85_1 = new GClass86(Brushes.Blue, null, FontStyle.Regular);

    public readonly GClass85 gclass85_2 = new GClass86(null, null, FontStyle.Bold | FontStyle.Underline);

    public readonly GClass85 gclass85_3 = new GClass86(Brushes.Brown, null, FontStyle.Italic);

    public readonly GClass85 gclass85_4 = new GClass86(Brushes.Gray, null, FontStyle.Regular);

    public readonly GClass85 gclass85_5 = new GClass86(Brushes.Green, null, FontStyle.Italic);

    public readonly GClass85 gclass85_6 = new GClass86(Brushes.Magenta, null, FontStyle.Regular);

    public readonly GClass85 gclass85_7 = new GClass86(Brushes.Maroon, null, FontStyle.Regular);

    public readonly GClass85 gclass85_8 = new GClass86(Brushes.Red, null, FontStyle.Regular);

    public readonly GClass85 gclass85_9 = new GClass86(Brushes.Black, null, FontStyle.Regular);

    protected readonly Dictionary<string, GClass93> dictionary_0 = [];

    protected readonly List<GClass85> list_0 = new(5);

    protected Regex regex_0;

    protected Regex regex_1;

    protected Regex regex_2;

    protected Regex regex_3;

    protected Regex regex_4;

    protected Regex regex_5;

    protected Regex regex_6;

    protected Regex regex_7;

    protected Regex regex_8;

    protected Regex regex_9;

    protected Regex regex_10;

    protected Regex regex_11;

    protected Regex regex_12;

    protected Regex regex_13;

    protected Regex regex_14;

    protected Regex regex_15;

    protected Regex regex_16;

    protected Regex regex_17;

    protected Regex regex_18;

    protected Regex regex_19;

    protected Regex regex_20;

    protected Regex regex_21;

    protected Regex regex_22;

    protected Regex regex_23;

    protected Regex regex_24;

    protected Regex regex_25;

    protected Regex regex_26;

    protected Regex regex_27;

    protected Regex regex_28;

    protected Regex regex_29;

    protected Regex regex_30;

    protected Regex regex_31;

    protected Regex regex_32;

    protected Regex regex_33;

    protected Regex regex_34;

    protected Regex regex_35;

    protected Regex regex_36;

    protected Regex regex_37;

    protected Regex regex_38;

    protected Regex regex_39;

    protected Regex regex_40;

    protected Regex regex_41;

    protected Regex regex_42;

    protected Regex regex_43;

    protected Regex regex_44;

    protected Regex regex_45;

    protected Regex regex_46;

    protected Regex regex_47;

    protected Regex regex_48;

    protected Regex regex_49;

    protected Regex regex_50;

    protected Regex regex_51;

    protected Regex regex_52;

    protected Regex regex_53;

    protected Regex regex_54;

    protected Regex regex_55;

    protected Regex regex_56;

    protected Regex regex_57;

    protected Regex regex_58;

    protected Regex regex_59;

    protected Regex regex_60;

    protected Regex regex_61;

    protected Regex regex_62;

    protected Regex regex_63;

    protected Regex regex_64;

    protected Regex regex_65;

    protected FastColoredTextBox fastColoredTextBox_0 = fastColoredTextBox_1;

    [CompilerGenerated]
    private GClass85 gclass85_10;

    [CompilerGenerated]
    private GClass85 gclass85_11;

    [CompilerGenerated]
    private GClass85 gclass85_12;

    [CompilerGenerated]
    private GClass85 gclass85_13;

    [CompilerGenerated]
    private GClass85 gclass85_14;

    [CompilerGenerated]
    private GClass85 gclass85_15;

    [CompilerGenerated]
    private GClass85 gclass85_16;

    [CompilerGenerated]
    private GClass85 gclass85_17;

    [CompilerGenerated]
    private GClass85 gclass85_18;

    [CompilerGenerated]
    private GClass85 gclass85_19;

    [CompilerGenerated]
    private GClass85 gclass85_20;

    [CompilerGenerated]
    private GClass85 gclass85_21;

    [CompilerGenerated]
    private GClass85 gclass85_22;

    [CompilerGenerated]
    private GClass85 gclass85_23;

    [CompilerGenerated]
    private GClass85 gclass85_24;

    [CompilerGenerated]
    private GClass85 gclass85_25;

    [CompilerGenerated]
    private GClass85 gclass85_26;

    [CompilerGenerated]
    private GClass85 gclass85_27;

    [CompilerGenerated]
    private GClass85 gclass85_28;

    [CompilerGenerated]
    private GClass85 gclass85_29;

    [CompilerGenerated]
    private GClass85 gclass85_30;

    [CompilerGenerated]
    private GClass85 gclass85_31;

    [CompilerGenerated]
    private GClass85 gclass85_32;

    public GClass85 StringStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_10;
        }
        [CompilerGenerated]
        set
        {
            gclass85_10 = value;
        }
    }

    public GClass85 CommentStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_11;
        }
        [CompilerGenerated]
        set
        {
            gclass85_11 = value;
        }
    }

    public GClass85 NumberStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_12;
        }
        [CompilerGenerated]
        set
        {
            gclass85_12 = value;
        }
    }

    public GClass85 AttributeStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_13;
        }
        [CompilerGenerated]
        set
        {
            gclass85_13 = value;
        }
    }

    public GClass85 ClassNameStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_14;
        }
        [CompilerGenerated]
        set
        {
            gclass85_14 = value;
        }
    }

    public GClass85 KeywordStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_15;
        }
        [CompilerGenerated]
        set
        {
            gclass85_15 = value;
        }
    }

    public GClass85 CommentTagStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_16;
        }
        [CompilerGenerated]
        set
        {
            gclass85_16 = value;
        }
    }

    public GClass85 AttributeValueStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_17;
        }
        [CompilerGenerated]
        set
        {
            gclass85_17 = value;
        }
    }

    public GClass85 TagBracketStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_18;
        }
        [CompilerGenerated]
        set
        {
            gclass85_18 = value;
        }
    }

    public GClass85 TagNameStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_19;
        }
        [CompilerGenerated]
        set
        {
            gclass85_19 = value;
        }
    }

    public GClass85 HtmlEntityStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_20;
        }
        [CompilerGenerated]
        set
        {
            gclass85_20 = value;
        }
    }

    public GClass85 XmlAttributeStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_21;
        }
        [CompilerGenerated]
        set
        {
            gclass85_21 = value;
        }
    }

    public GClass85 XmlAttributeValueStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_22;
        }
        [CompilerGenerated]
        set
        {
            gclass85_22 = value;
        }
    }

    public GClass85 XmlTagBracketStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_23;
        }
        [CompilerGenerated]
        set
        {
            gclass85_23 = value;
        }
    }

    public GClass85 XmlTagNameStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_24;
        }
        [CompilerGenerated]
        set
        {
            gclass85_24 = value;
        }
    }

    public GClass85 XmlEntityStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_25;
        }
        [CompilerGenerated]
        set
        {
            gclass85_25 = value;
        }
    }

    public GClass85 XmlCDataStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_26;
        }
        [CompilerGenerated]
        set
        {
            gclass85_26 = value;
        }
    }

    public GClass85 VariableStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_27;
        }
        [CompilerGenerated]
        set
        {
            gclass85_27 = value;
        }
    }

    public GClass85 KeywordStyle2
    {
        [CompilerGenerated]
        get
        {
            return gclass85_28;
        }
        [CompilerGenerated]
        set
        {
            gclass85_28 = value;
        }
    }

    public GClass85 KeywordStyle3
    {
        [CompilerGenerated]
        get
        {
            return gclass85_29;
        }
        [CompilerGenerated]
        set
        {
            gclass85_29 = value;
        }
    }

    public GClass85 StatementsStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_30;
        }
        [CompilerGenerated]
        set
        {
            gclass85_30 = value;
        }
    }

    public GClass85 FunctionsStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_31;
        }
        [CompilerGenerated]
        set
        {
            gclass85_31 = value;
        }
    }

    public GClass85 TypesStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass85_32;
        }
        [CompilerGenerated]
        set
        {
            gclass85_32 = value;
        }
    }

    public static RegexOptions RegexOptions_0
    {
        get
        {
            if (genum12_0 == GEnum12.const_0)
            {
                return RegexOptions.Compiled;
            }
            return RegexOptions.None;
        }
    }

    public void Dispose()
    {
        foreach (GClass93 value in dictionary_0.Values)
        {
            value.Dispose();
        }
    }

    public void vmethod_0(GEnum13 genum13_0, GClass84 gclass84_0)
    {
        switch (genum13_0)
        {
            case GEnum13.const_1:
                vmethod_5(gclass84_0);
                break;
            case GEnum13.const_2:
                vmethod_6(gclass84_0);
                break;
            case GEnum13.const_3:
                vmethod_7(gclass84_0);
                break;
            case GEnum13.const_4:
                vmethod_8(gclass84_0);
                break;
            case GEnum13.const_5:
                vmethod_9(gclass84_0);
                break;
            case GEnum13.const_6:
                vmethod_10(gclass84_0);
                break;
            case GEnum13.const_7:
                vmethod_11(gclass84_0);
                break;
            case GEnum13.const_8:
                vmethod_12(gclass84_0);
                break;
        }
    }

    public void vmethod_1(string string_0, GClass84 gclass84_0)
    {
        if (!dictionary_0.TryGetValue(string_0, out GClass93 value))
        {
            XmlDocument xmlDocument = new();
            string path = string_0;
            if (!File.Exists(path))
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileName(path));
            }
            xmlDocument.LoadXml(File.ReadAllText(path));
            value = smethod_0(xmlDocument);
            dictionary_0[string_0] = value;
        }
        method_6(value, gclass84_0);
    }

    public void vmethod_2(object sender, GEventArgs8 e)
    {
        switch ((sender as FastColoredTextBox).GEnum13_0)
        {
            case GEnum13.const_1:
                method_5(sender, e);
                break;
            case GEnum13.const_2:
                method_4(sender, e);
                break;
            case GEnum13.const_3:
                method_2(sender, e);
                break;
            case GEnum13.const_4:
                method_3(sender, e);
                break;
            case GEnum13.const_5:
                method_1(sender, e);
                break;
            case GEnum13.const_6:
                method_0(sender, e);
                break;
            case GEnum13.const_7:
                method_5(sender, e);
                break;
            case GEnum13.const_8:
                method_19(sender, e);
                break;
        }
    }

    protected void method_0(object sender, GEventArgs8 e)
    {
        if (!Regex.IsMatch(e.LineText, "^[^\"']*\\{.*\\}[^\"']*$"))
        {
            if (Regex.IsMatch(e.LineText, "^[^\"']*\\{"))
            {
                e.ShiftNextLines = e.TabLength;
            }
            else if (Regex.IsMatch(e.LineText, "}[^\"']*$"))
            {
                e.Shift = -e.TabLength;
                e.ShiftNextLines = -e.TabLength;
            }
            else if (Regex.IsMatch(e.PrevLineText, "^\\s*(if|for|foreach|while|[\\}\\s]*else)\\b[^{]*$") && !Regex.IsMatch(e.PrevLineText, "(;\\s*$)|(;\\s*//)"))
            {
                e.Shift = e.TabLength;
            }
        }
    }

    protected void method_1(object sender, GEventArgs8 e)
    {
        (sender as FastColoredTextBox).vmethod_46(sender, e);
    }

    protected void method_2(object sender, GEventArgs8 e)
    {
        (sender as FastColoredTextBox).vmethod_46(sender, e);
    }

    protected void method_3(object sender, GEventArgs8 e)
    {
        (sender as FastColoredTextBox).vmethod_46(sender, e);
    }

    protected void method_4(object sender, GEventArgs8 e)
    {
        if (Regex.IsMatch(e.LineText, "^\\s*(End|EndIf|Next|Loop)\\b", RegexOptions.IgnoreCase))
        {
            e.Shift = -e.TabLength;
            e.ShiftNextLines = -e.TabLength;
        }
        else if (Regex.IsMatch(e.LineText, "\\b(Class|Property|Enum|Structure|Sub|Function|Namespace|Interface|Get)\\b|(Set\\s*\\()", RegexOptions.IgnoreCase))
        {
            e.ShiftNextLines = e.TabLength;
        }
        else if (!Regex.IsMatch(e.LineText, "\\b(Then)\\s*\\S+", RegexOptions.IgnoreCase))
        {
            if (Regex.IsMatch(e.LineText, "^\\s*(If|While|For|Do|Try|With|Using|Select)\\b", RegexOptions.IgnoreCase))
            {
                e.ShiftNextLines = e.TabLength;
            }
            else if (Regex.IsMatch(e.LineText, "^\\s*(Else|ElseIf|Case|Catch|Finally)\\b", RegexOptions.IgnoreCase))
            {
                e.Shift = -e.TabLength;
            }
            else if (e.PrevLineText.TrimEnd().EndsWith("_"))
            {
                e.Shift = e.TabLength;
            }
        }
    }

    protected void method_5(object sender, GEventArgs8 e)
    {
        if (!Regex.IsMatch(e.LineText, "^[^\"']*\\{.*\\}[^\"']*$"))
        {
            if (Regex.IsMatch(e.LineText, "^[^\"']*\\{"))
            {
                e.ShiftNextLines = e.TabLength;
            }
            else if (Regex.IsMatch(e.LineText, "}[^\"']*$"))
            {
                e.Shift = -e.TabLength;
                e.ShiftNextLines = -e.TabLength;
            }
            else if (Regex.IsMatch(e.LineText, "^\\s*\\w+\\s*:\\s*($|//)") && !Regex.IsMatch(e.LineText, "^\\s*default\\s*:"))
            {
                e.Shift = -e.TabLength;
            }
            else if (Regex.IsMatch(e.LineText, "^\\s*(case|default)\\b.*:\\s*($|//)"))
            {
                e.Shift = -e.TabLength / 2;
            }
            else if (Regex.IsMatch(e.PrevLineText, "^\\s*(if|for|foreach|while|[\\}\\s]*else)\\b[^{]*$") && !Regex.IsMatch(e.PrevLineText, "(;\\s*$)|(;\\s*//)"))
            {
                e.Shift = e.TabLength;
            }
        }
    }

    public void vmethod_3(string string_0, XmlDocument xmlDocument_0)
    {
        GClass93 value = smethod_0(xmlDocument_0);
        dictionary_0[string_0] = value;
    }

    public void vmethod_4(GClass85 gclass85_33)
    {
        if (!list_0.Contains(gclass85_33))
        {
            fastColoredTextBox_0.method_22();
            list_0.Add(gclass85_33);
        }
    }

    public static GClass93 smethod_0(XmlDocument xmlDocument_0)
    {
        GClass93 gClass = new();
        XmlNode xmlNode = xmlDocument_0.SelectSingleNode("doc/brackets");
        if (xmlNode != null)
        {
            if (xmlNode.Attributes["left"] != null && xmlNode.Attributes["right"] != null && !(xmlNode.Attributes["left"].Value == "") && !(xmlNode.Attributes["right"].Value == ""))
            {
                gClass.char_0 = xmlNode.Attributes["left"].Value[0];
                gClass.char_1 = xmlNode.Attributes["right"].Value[0];
            }
            else
            {
                gClass.char_0 = '\0';
                gClass.char_1 = '\0';
            }
            if (xmlNode.Attributes["left2"] != null && xmlNode.Attributes["right2"] != null && !(xmlNode.Attributes["left2"].Value == "") && !(xmlNode.Attributes["right2"].Value == ""))
            {
                gClass.char_2 = xmlNode.Attributes["left2"].Value[0];
                gClass.char_3 = xmlNode.Attributes["right2"].Value[0];
            }
            else
            {
                gClass.char_2 = '\0';
                gClass.char_3 = '\0';
            }
            if (xmlNode.Attributes["strategy"] != null && !(xmlNode.Attributes["strategy"].Value == ""))
            {
                gClass.bracketsHighlightStrategy_0 = (BracketsHighlightStrategy)Enum.Parse(typeof(BracketsHighlightStrategy), xmlNode.Attributes["strategy"].Value);
            }
            else
            {
                gClass.bracketsHighlightStrategy_0 = BracketsHighlightStrategy.Strategy2;
            }
        }
        Dictionary<string, GClass85> dictionary = [];
        foreach (XmlNode item in xmlDocument_0.SelectNodes("doc/style"))
        {
            GClass85 gClass2 = smethod_3(item);
            dictionary[item.Attributes["name"].Value] = gClass2;
            gClass.list_0.Add(gClass2);
        }
        foreach (XmlNode item2 in xmlDocument_0.SelectNodes("doc/rule"))
        {
            gClass.list_1.Add(smethod_2(item2, dictionary));
        }
        foreach (XmlNode item3 in xmlDocument_0.SelectNodes("doc/folding"))
        {
            gClass.list_2.Add(smethod_1(item3));
        }
        return gClass;
    }

    protected static GClass95 smethod_1(XmlNode xmlNode_0)
    {
        GClass95 gClass = new()
        {
            string_0 = xmlNode_0.Attributes["start"].Value,
            string_1 = xmlNode_0.Attributes["finish"].Value
        };
        XmlAttribute xmlAttribute = xmlNode_0.Attributes["options"];
        if (xmlAttribute != null)
        {
            gClass.regexOptions_0 = (RegexOptions)Enum.Parse(typeof(RegexOptions), xmlAttribute.Value);
        }
        return gClass;
    }

    protected static GClass94 smethod_2(XmlNode xmlNode_0, Dictionary<string, GClass85> dictionary_1)
    {
        GClass94 gClass = new()
        {
            string_0 = xmlNode_0.InnerText
        };
        XmlAttribute xmlAttribute = xmlNode_0.Attributes["style"];
        XmlAttribute xmlAttribute2 = xmlNode_0.Attributes["options"];
        if (xmlAttribute == null)
        {
            throw new Exception("Rule must contain style name.");
        }
        if (!dictionary_1.ContainsKey(xmlAttribute.Value))
        {
            throw new Exception("Style '" + xmlAttribute.Value + "' is not found.");
        }
        gClass.gclass85_0 = dictionary_1[xmlAttribute.Value];
        if (xmlAttribute2 != null)
        {
            gClass.regexOptions_0 = (RegexOptions)Enum.Parse(typeof(RegexOptions), xmlAttribute2.Value);
        }
        return gClass;
    }

    protected static GClass85 smethod_3(XmlNode xmlNode_0)
    {
        _ = xmlNode_0.Attributes["type"];
        XmlAttribute xmlAttribute = xmlNode_0.Attributes["color"];
        XmlAttribute xmlAttribute2 = xmlNode_0.Attributes["backColor"];
        XmlAttribute xmlAttribute3 = xmlNode_0.Attributes["fontStyle"];
        _ = xmlNode_0.Attributes["name"];
        SolidBrush brush_ = null;
        if (xmlAttribute != null)
        {
            brush_ = new SolidBrush(smethod_4(xmlAttribute.Value));
        }
        SolidBrush brush_2 = null;
        if (xmlAttribute2 != null)
        {
            brush_2 = new SolidBrush(smethod_4(xmlAttribute2.Value));
        }
        FontStyle fontStyle_ = FontStyle.Regular;
        if (xmlAttribute3 != null)
        {
            fontStyle_ = (FontStyle)Enum.Parse(typeof(FontStyle), xmlAttribute3.Value);
        }
        return new GClass86(brush_, brush_2, fontStyle_);
    }

    protected static Color smethod_4(string string_0)
    {
        if (string_0.StartsWith("#"))
        {
            if (string_0.Length <= 7)
            {
                return Color.FromArgb(255, Color.FromArgb(int.Parse(string_0.Substring(1), NumberStyles.AllowHexSpecifier)));
            }
            return Color.FromArgb(int.Parse(string_0.Substring(1), NumberStyles.AllowHexSpecifier));
        }
        return Color.FromName(string_0);
    }

    public void method_6(GClass93 gclass93_0, GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.method_29();
        for (int i = 0; i < gclass93_0.list_0.Count; i++)
        {
            gclass84_0.fastColoredTextBox_0.GClass85_0[i] = gclass93_0.list_0[i];
        }
        int count = gclass93_0.list_0.Count;
        for (int j = 0; j < list_0.Count; j++)
        {
            gclass84_0.fastColoredTextBox_0.GClass85_0[count + j] = list_0[j];
        }
        char[] char_ = method_8(gclass84_0.fastColoredTextBox_0);
        gclass84_0.fastColoredTextBox_0.LeftBracket = gclass93_0.char_0;
        gclass84_0.fastColoredTextBox_0.RightBracket = gclass93_0.char_1;
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = gclass93_0.char_2;
        gclass84_0.fastColoredTextBox_0.RightBracket2 = gclass93_0.char_3;
        gclass84_0.method_34([.. gclass93_0.list_0]);
        foreach (GClass94 item in gclass93_0.list_1)
        {
            gclass84_0.method_20(item.gclass85_0, item.Regex_0);
        }
        gclass84_0.method_36();
        foreach (GClass95 item2 in gclass93_0.list_2)
        {
            gclass84_0.method_26(item2.string_0, item2.string_1, item2.regexOptions_0);
        }
        method_7(gclass84_0.fastColoredTextBox_0, char_);
    }

    protected void method_7(FastColoredTextBox fastColoredTextBox_1, char[] char_0)
    {
        fastColoredTextBox_1.LeftBracket = char_0[0];
        fastColoredTextBox_1.RightBracket = char_0[1];
        fastColoredTextBox_1.LeftBracket2 = char_0[2];
        fastColoredTextBox_1.RightBracket2 = char_0[3];
    }

    protected char[] method_8(FastColoredTextBox fastColoredTextBox_1)
    {
        return [fastColoredTextBox_1.LeftBracket, fastColoredTextBox_1.RightBracket, fastColoredTextBox_1.LeftBracket2, fastColoredTextBox_1.RightBracket2];
    }

    protected void method_9()
    {
        regex_7 = new Regex("\r\n                            # Character definitions:\r\n                            '\r\n                            (?> # disable backtracking\r\n                              (?:\r\n                                \\\\[^\\r\\n]|    # escaped meta char\r\n                                [^'\\r\\n]      # any character except '\r\n                              )*\r\n                            )\r\n                            '?\r\n                            |\r\n                            # Normal string & verbatim strings definitions:\r\n                            (?<verbatimIdentifier>@)?         # this group matches if it is an verbatim string\r\n                            \"\r\n                            (?> # disable backtracking\r\n                              (?:\r\n                                # match and consume an escaped character including escaped double quote (\") char\r\n                                (?(verbatimIdentifier)        # if it is a verbatim string ...\r\n                                  \"\"|                         #   then: only match an escaped double quote (\") char\r\n                                  \\\\.                         #   else: match an escaped sequence\r\n                                )\r\n                                | # OR\r\n            \r\n                                # match any char except double quote char (\")\r\n                                [^\"]\r\n                              )*\r\n                            )\r\n                            \"\r\n                        ", RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace | RegexOptions_0);
        regex_2 = new Regex("//.*$", RegexOptions.Multiline | RegexOptions_0);
        regex_3 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | RegexOptions_0);
        regex_4 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexOptions_0);
        regex_6 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?[lLdDfF]?\\b|\\b0x[a-fA-F\\d]+\\b", RegexOptions_0);
        regex_0 = new Regex("^\\s*(?<range>\\[.+?\\])\\s*$", RegexOptions.Multiline | RegexOptions_0);
        regex_1 = new Regex("\\b(class|struct|enum|interface)\\s+(?<range>\\w+?)\\b", RegexOptions_0);
        regex_5 = new Regex("\\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\\b|#region\\b|#endregion\\b", RegexOptions_0);
    }

    public void method_10(GEnum13 genum13_0)
    {
        switch (genum13_0)
        {
            case GEnum13.const_1:
                StringStyle = gclass85_3;
                CommentStyle = gclass85_5;
                NumberStyle = gclass85_6;
                AttributeStyle = gclass85_5;
                ClassNameStyle = gclass85_2;
                KeywordStyle = gclass85_1;
                CommentTagStyle = gclass85_4;
                break;
            case GEnum13.const_2:
                StringStyle = gclass85_3;
                CommentStyle = gclass85_5;
                NumberStyle = gclass85_6;
                ClassNameStyle = gclass85_2;
                KeywordStyle = gclass85_1;
                break;
            case GEnum13.const_3:
                CommentStyle = gclass85_5;
                TagBracketStyle = gclass85_1;
                TagNameStyle = gclass85_7;
                AttributeStyle = gclass85_8;
                AttributeValueStyle = gclass85_1;
                HtmlEntityStyle = gclass85_8;
                break;
            case GEnum13.const_4:
                CommentStyle = gclass85_5;
                XmlTagBracketStyle = gclass85_1;
                XmlTagNameStyle = gclass85_7;
                XmlAttributeStyle = gclass85_8;
                XmlAttributeValueStyle = gclass85_1;
                XmlEntityStyle = gclass85_8;
                XmlCDataStyle = gclass85_9;
                break;
            case GEnum13.const_5:
                StringStyle = gclass85_8;
                CommentStyle = gclass85_5;
                NumberStyle = gclass85_6;
                KeywordStyle = gclass85_0;
                StatementsStyle = gclass85_0;
                FunctionsStyle = gclass85_7;
                VariableStyle = gclass85_7;
                TypesStyle = gclass85_3;
                break;
            case GEnum13.const_6:
                StringStyle = gclass85_8;
                CommentStyle = gclass85_5;
                NumberStyle = gclass85_8;
                VariableStyle = gclass85_7;
                KeywordStyle = gclass85_6;
                KeywordStyle2 = gclass85_1;
                KeywordStyle3 = gclass85_4;
                break;
            case GEnum13.const_7:
                StringStyle = gclass85_3;
                CommentStyle = gclass85_5;
                NumberStyle = gclass85_6;
                KeywordStyle = gclass85_1;
                break;
            case GEnum13.const_8:
                StringStyle = gclass85_3;
                CommentStyle = gclass85_5;
                NumberStyle = gclass85_6;
                KeywordStyle = gclass85_0;
                FunctionsStyle = gclass85_7;
                break;
        }
    }

    public void vmethod_5(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = "//";
        gclass84_0.fastColoredTextBox_0.LeftBracket = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket = ')';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '{';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = '}';
        gclass84_0.fastColoredTextBox_0.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
        gclass84_0.method_34(StringStyle, CommentStyle, NumberStyle, AttributeStyle, ClassNameStyle, KeywordStyle);
        if (regex_7 == null)
        {
            method_9();
        }
        gclass84_0.method_20(StringStyle, regex_7);
        gclass84_0.method_20(CommentStyle, regex_2);
        gclass84_0.method_20(CommentStyle, regex_3);
        gclass84_0.method_20(CommentStyle, regex_4);
        gclass84_0.method_20(NumberStyle, regex_6);
        gclass84_0.method_20(AttributeStyle, regex_0);
        gclass84_0.method_20(ClassNameStyle, regex_1);
        gclass84_0.method_20(KeywordStyle, regex_5);
        foreach (GClass84 item in gclass84_0.method_29("^\\s*///.*$", RegexOptions.Multiline))
        {
            item.method_35(StyleIndex.All);
            if (regex_16 == null)
            {
                method_12();
            }
            item.method_18(CommentStyle);
            foreach (GClass84 item2 in item.method_33(regex_14))
            {
                item2.method_35(StyleIndex.All);
                item2.method_18(CommentTagStyle);
            }
            foreach (GClass84 item3 in item.method_29("^\\s*///", RegexOptions.Multiline))
            {
                item3.method_35(StyleIndex.All);
                item3.method_18(CommentTagStyle);
            }
        }
        gclass84_0.method_36();
        gclass84_0.method_25("{", "}");
        gclass84_0.method_25("#region\\b", "#endregion\\b");
        gclass84_0.method_25("/\\*", "\\*/");
    }

    protected void method_11()
    {
        regex_65 = new Regex("\"\"|\".*?[^\\\\]\"", RegexOptions_0);
        regex_62 = new Regex("'.*$", RegexOptions.Multiline | RegexOptions_0);
        regex_64 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?\\b", RegexOptions_0);
        regex_61 = new Regex("\\b(Class|Structure|Enum|Interface)[ ]+(?<range>\\w+?)\\b", RegexOptions.IgnoreCase | RegexOptions_0);
        regex_63 = new Regex("\\b(AddHandler|AddressOf|Alias|And|AndAlso|As|Boolean|ByRef|Byte|ByVal|Call|Case|Catch|CBool|CByte|CChar|CDate|CDbl|CDec|Char|CInt|Class|CLng|CObj|Const|Continue|CSByte|CShort|CSng|CStr|CType|CUInt|CULng|CUShort|Date|Decimal|Declare|Default|Delegate|Dim|DirectCast|Do|Double|Each|Else|ElseIf|End|EndIf|Enum|Erase|Error|Event|Exit|False|Finally|For|Friend|Function|Get|GetType|GetXMLNamespace|Global|GoSub|GoTo|Handles|If|Implements|Imports|In|Inherits|Integer|Interface|Is|IsNot|Let|Lib|Like|Long|Loop|Me|Mod|Module|MustInherit|MustOverride|MyBase|MyClass|Namespace|Narrowing|New|Next|Not|Nothing|NotInheritable|NotOverridable|Object|Of|On|Operator|Option|Optional|Or|OrElse|Overloads|Overridable|Overrides|ParamArray|Partial|Private|Property|Protected|Public|RaiseEvent|ReadOnly|ReDim|REM|RemoveHandler|Resume|Return|SByte|Select|Set|Shadows|Shared|Short|Single|Static|Step|Stop|String|Structure|Sub|SyncLock|Then|Throw|To|True|Try|TryCast|TypeOf|UInteger|ULong|UShort|Using|Variant|Wend|When|While|Widening|With|WithEvents|WriteOnly|Xor|Region)\\b|(#Const|#Else|#ElseIf|#End|#If|#Region)\\b", RegexOptions.IgnoreCase | RegexOptions_0);
    }

    public void vmethod_6(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = "'";
        gclass84_0.fastColoredTextBox_0.LeftBracket = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket = ')';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '\0';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = '\0';
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.\\(\\)]+\\s*(?<range>=)\\s*(?<range>.+)\r\n";
        gclass84_0.method_34(StringStyle, CommentStyle, NumberStyle, ClassNameStyle, KeywordStyle);
        if (regex_65 == null)
        {
            method_11();
        }
        gclass84_0.method_20(StringStyle, regex_65);
        gclass84_0.method_20(CommentStyle, regex_62);
        gclass84_0.method_20(NumberStyle, regex_64);
        gclass84_0.method_20(ClassNameStyle, regex_61);
        gclass84_0.method_20(KeywordStyle, regex_63);
        gclass84_0.method_36();
        gclass84_0.method_26("#Region\\b", "#End\\s+Region\\b", RegexOptions.IgnoreCase);
        gclass84_0.method_26("\\b(Class|Property|Enum|Structure|Interface)[ \\t]+\\S+", "\\bEnd (Class|Property|Enum|Structure|Interface)\\b", RegexOptions.IgnoreCase);
        gclass84_0.method_26("^\\s*(?<range>While)[ \\t]+\\S+", "^\\s*(?<range>End While)\\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        gclass84_0.method_26("\\b(Sub|Function)[ \\t]+[^\\s']+", "\\bEnd (Sub|Function)\\b", RegexOptions.IgnoreCase);
        gclass84_0.method_26("(\\r|\\n|^)[ \\t]*(?<range>Get|Set)[ \\t]*(\\r|\\n|$)", "\\bEnd (Get|Set)\\b", RegexOptions.IgnoreCase);
        gclass84_0.method_26("^\\s*(?<range>For|For\\s+Each)\\b", "^\\s*(?<range>Next)\\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        gclass84_0.method_26("^\\s*(?<range>Do)\\b", "^\\s*(?<range>Loop)\\b", RegexOptions.IgnoreCase | RegexOptions.Multiline);
    }

    protected void method_12()
    {
        regex_10 = new Regex("(<!--.*?-->)|(<!--.*)", RegexOptions.Singleline | RegexOptions_0);
        regex_11 = new Regex("(<!--.*?-->)|(.*-->)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexOptions_0);
        regex_16 = new Regex("<|/>|</|>", RegexOptions_0);
        regex_15 = new Regex("<(?<range>[!\\w:]+)", RegexOptions_0);
        regex_12 = new Regex("</(?<range>[\\w:]+)>", RegexOptions_0);
        regex_14 = new Regex("<[^>]+>", RegexOptions_0);
        regex_8 = new Regex("(?<range>[\\w\\d\\-]{1,20}?)='[^']*'|(?<range>[\\w\\d\\-]{1,20})=\"[^\"]*\"|(?<range>[\\w\\d\\-]{1,20})=[\\w\\d\\-]{1,20}", RegexOptions_0);
        regex_9 = new Regex("[\\w\\d\\-]{1,20}?=(?<range>'[^']*')|[\\w\\d\\-]{1,20}=(?<range>\"[^\"]*\")|[\\w\\d\\-]{1,20}=(?<range>[\\w\\d\\-]{1,20})", RegexOptions_0);
        regex_13 = new Regex("\\&(amp|gt|lt|nbsp|quot|apos|copy|reg|#[0-9]{1,8}|#x[0-9a-f]{1,8});", RegexOptions_0 | RegexOptions.IgnoreCase);
    }

    public void vmethod_7(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = null;
        gclass84_0.fastColoredTextBox_0.LeftBracket = '<';
        gclass84_0.fastColoredTextBox_0.RightBracket = '>';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = ')';
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "";
        gclass84_0.method_34(CommentStyle, TagBracketStyle, TagNameStyle, AttributeStyle, AttributeValueStyle, HtmlEntityStyle);
        if (regex_16 == null)
        {
            method_12();
        }
        gclass84_0.method_20(CommentStyle, regex_10);
        gclass84_0.method_20(CommentStyle, regex_11);
        gclass84_0.method_20(TagBracketStyle, regex_16);
        gclass84_0.method_20(TagNameStyle, regex_15);
        gclass84_0.method_20(TagNameStyle, regex_12);
        gclass84_0.method_20(AttributeStyle, regex_8);
        gclass84_0.method_20(AttributeValueStyle, regex_9);
        gclass84_0.method_20(HtmlEntityStyle, regex_13);
        gclass84_0.method_36();
        gclass84_0.method_26("<head", "</head>", RegexOptions.IgnoreCase);
        gclass84_0.method_26("<body", "</body>", RegexOptions.IgnoreCase);
        gclass84_0.method_26("<table", "</table>", RegexOptions.IgnoreCase);
        gclass84_0.method_26("<form", "</form>", RegexOptions.IgnoreCase);
        gclass84_0.method_26("<div", "</div>", RegexOptions.IgnoreCase);
        gclass84_0.method_26("<script", "</script>", RegexOptions.IgnoreCase);
        gclass84_0.method_26("<tr", "</tr>", RegexOptions.IgnoreCase);
    }

    protected void method_13()
    {
        regex_19 = new Regex("(<!--.*?-->)|(<!--.*)", RegexOptions.Singleline | RegexOptions_0);
        regex_20 = new Regex("(<!--.*?-->)|(.*-->)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexOptions_0);
        regex_25 = new Regex("<\\?|<|/>|</|>|\\?>", RegexOptions_0);
        regex_24 = new Regex("<[?](?<range1>[x][m][l]{1})|<(?<range>[!\\w:]+)", RegexOptions_0);
        regex_21 = new Regex("</(?<range>[\\w:]+)>", RegexOptions_0);
        regex_23 = new Regex("<[^>]+>", RegexOptions_0);
        regex_17 = new Regex("(?<range>[\\w\\d\\-\\:]+)[ ]*=[ ]*'[^']*'|(?<range>[\\w\\d\\-\\:]+)[ ]*=[ ]*\"[^\"]*\"|(?<range>[\\w\\d\\-\\:]+)[ ]*=[ ]*[\\w\\d\\-\\:]+", RegexOptions_0);
        regex_18 = new Regex("[\\w\\d\\-]+?=(?<range>'[^']*')|[\\w\\d\\-]+[ ]*=[ ]*(?<range>\"[^\"]*\")|[\\w\\d\\-]+[ ]*=[ ]*(?<range>[\\w\\d\\-]+)", RegexOptions_0);
        regex_22 = new Regex("\\&(amp|gt|lt|nbsp|quot|apos|copy|reg|#[0-9]{1,8}|#x[0-9a-f]{1,8});", RegexOptions_0 | RegexOptions.IgnoreCase);
        regex_26 = new Regex("<!\\s*\\[CDATA\\s*\\[(?<text>(?>[^]]+|](?!]>))*)]]>", RegexOptions_0 | RegexOptions.IgnoreCase);
        regex_27 = new Regex("<(?<range>/?\\w+)\\s[^>]*?[^/]>|<(?<range>/?\\w+)\\s*>", RegexOptions.Singleline | RegexOptions_0);
    }

    public void vmethod_8(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = null;
        gclass84_0.fastColoredTextBox_0.LeftBracket = '<';
        gclass84_0.fastColoredTextBox_0.RightBracket = '>';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = ')';
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "";
        gclass84_0.method_34(CommentStyle, XmlTagBracketStyle, XmlTagNameStyle, XmlAttributeStyle, XmlAttributeValueStyle, XmlEntityStyle, XmlCDataStyle);
        if (regex_25 == null)
        {
            method_13();
        }
        gclass84_0.method_20(XmlCDataStyle, regex_26);
        gclass84_0.method_20(CommentStyle, regex_19);
        gclass84_0.method_20(CommentStyle, regex_20);
        gclass84_0.method_20(XmlTagBracketStyle, regex_25);
        gclass84_0.method_20(XmlTagNameStyle, regex_24);
        gclass84_0.method_20(XmlTagNameStyle, regex_21);
        gclass84_0.method_20(XmlAttributeStyle, regex_17);
        gclass84_0.method_20(XmlAttributeValueStyle, regex_18);
        gclass84_0.method_20(XmlEntityStyle, regex_22);
        gclass84_0.method_36();
        method_14(gclass84_0);
    }

    private void method_14(GClass84 gclass84_0)
    {
        Stack<Class108> stack = new();
        int num = 0;
        FastColoredTextBox fastColoredTextBox = gclass84_0.fastColoredTextBox_0;
        foreach (GClass84 item in gclass84_0.method_33(regex_27))
        {
            string text = item.vmethod_2();
            int int_ = item.GStruct10_0.int_1;
            if (text[0] != '/')
            {
                Class108 @class = new()
                {
                    string_0 = text,
                    int_0 = num++,
                    int_1 = item.GStruct10_0.int_1
                };
                stack.Push(@class);
                if (string.IsNullOrEmpty(fastColoredTextBox[int_].FoldingStartMarker))
                {
                    fastColoredTextBox[int_].FoldingStartMarker = @class.String_0;
                }
            }
            else
            {
                if (stack.Count <= 0)
                {
                    continue;
                }
                Class108 class2 = stack.Pop();
                if (int_ == class2.int_1)
                {
                    if (fastColoredTextBox[int_].FoldingStartMarker == class2.String_0)
                    {
                        fastColoredTextBox[int_].FoldingStartMarker = null;
                    }
                }
                else if (string.IsNullOrEmpty(fastColoredTextBox[int_].FoldingEndMarker))
                {
                    fastColoredTextBox[int_].FoldingEndMarker = class2.String_0;
                }
            }
        }
    }

    protected void method_15()
    {
        regex_58 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", RegexOptions_0);
        regex_56 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?\\b", RegexOptions_0);
        regex_50 = new Regex("--.*$", RegexOptions.Multiline | RegexOptions_0);
        regex_51 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | RegexOptions_0);
        regex_52 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexOptions_0);
        regex_53 = new Regex("#.*$", RegexOptions.Multiline | RegexOptions_0);
        regex_60 = new Regex("@[a-zA-Z_\\d]*\\b", RegexOptions_0);
        regex_57 = new Regex("\\b(ALTER APPLICATION ROLE|ALTER ASSEMBLY|ALTER ASYMMETRIC KEY|ALTER AUTHORIZATION|ALTER BROKER PRIORITY|ALTER CERTIFICATE|ALTER CREDENTIAL|ALTER CRYPTOGRAPHIC PROVIDER|ALTER DATABASE|ALTER DATABASE AUDIT SPECIFICATION|ALTER DATABASE ENCRYPTION KEY|ALTER ENDPOINT|ALTER EVENT SESSION|ALTER FULLTEXT CATALOG|ALTER FULLTEXT INDEX|ALTER FULLTEXT STOPLIST|ALTER FUNCTION|ALTER INDEX|ALTER LOGIN|ALTER MASTER KEY|ALTER MESSAGE TYPE|ALTER PARTITION FUNCTION|ALTER PARTITION SCHEME|ALTER PROCEDURE|ALTER QUEUE|ALTER REMOTE SERVICE BINDING|ALTER RESOURCE GOVERNOR|ALTER RESOURCE POOL|ALTER ROLE|ALTER ROUTE|ALTER SCHEMA|ALTER SERVER AUDIT|ALTER SERVER AUDIT SPECIFICATION|ALTER SERVICE|ALTER SERVICE MASTER KEY|ALTER SYMMETRIC KEY|ALTER TABLE|ALTER TRIGGER|ALTER USER|ALTER VIEW|ALTER WORKLOAD GROUP|ALTER XML SCHEMA COLLECTION|BULK INSERT|CREATE AGGREGATE|CREATE APPLICATION ROLE|CREATE ASSEMBLY|CREATE ASYMMETRIC KEY|CREATE BROKER PRIORITY|CREATE CERTIFICATE|CREATE CONTRACT|CREATE CREDENTIAL|CREATE CRYPTOGRAPHIC PROVIDER|CREATE DATABASE|CREATE DATABASE AUDIT SPECIFICATION|CREATE DATABASE ENCRYPTION KEY|CREATE DEFAULT|CREATE ENDPOINT|CREATE EVENT NOTIFICATION|CREATE EVENT SESSION|CREATE FULLTEXT CATALOG|CREATE FULLTEXT INDEX|CREATE FULLTEXT STOPLIST|CREATE FUNCTION|CREATE INDEX|CREATE LOGIN|CREATE MASTER KEY|CREATE MESSAGE TYPE|CREATE PARTITION FUNCTION|CREATE PARTITION SCHEME|CREATE PROCEDURE|CREATE QUEUE|CREATE REMOTE SERVICE BINDING|CREATE RESOURCE POOL|CREATE ROLE|CREATE ROUTE|CREATE RULE|CREATE SCHEMA|CREATE SERVER AUDIT|CREATE SERVER AUDIT SPECIFICATION|CREATE SERVICE|CREATE SPATIAL INDEX|CREATE STATISTICS|CREATE SYMMETRIC KEY|CREATE SYNONYM|CREATE TABLE|CREATE TRIGGER|CREATE TYPE|CREATE USER|CREATE VIEW|CREATE WORKLOAD GROUP|CREATE XML INDEX|CREATE XML SCHEMA COLLECTION|DELETE|DISABLE TRIGGER|DROP AGGREGATE|DROP APPLICATION ROLE|DROP ASSEMBLY|DROP ASYMMETRIC KEY|DROP BROKER PRIORITY|DROP CERTIFICATE|DROP CONTRACT|DROP CREDENTIAL|DROP CRYPTOGRAPHIC PROVIDER|DROP DATABASE|DROP DATABASE AUDIT SPECIFICATION|DROP DATABASE ENCRYPTION KEY|DROP DEFAULT|DROP ENDPOINT|DROP EVENT NOTIFICATION|DROP EVENT SESSION|DROP FULLTEXT CATALOG|DROP FULLTEXT INDEX|DROP FULLTEXT STOPLIST|DROP FUNCTION|DROP INDEX|DROP LOGIN|DROP MASTER KEY|DROP MESSAGE TYPE|DROP PARTITION FUNCTION|DROP PARTITION SCHEME|DROP PROCEDURE|DROP QUEUE|DROP REMOTE SERVICE BINDING|DROP RESOURCE POOL|DROP ROLE|DROP ROUTE|DROP RULE|DROP SCHEMA|DROP SERVER AUDIT|DROP SERVER AUDIT SPECIFICATION|DROP SERVICE|DROP SIGNATURE|DROP STATISTICS|DROP SYMMETRIC KEY|DROP SYNONYM|DROP TABLE|DROP TRIGGER|DROP TYPE|DROP USER|DROP VIEW|DROP WORKLOAD GROUP|DROP XML SCHEMA COLLECTION|ENABLE TRIGGER|EXEC|EXECUTE|REPLACE|FROM|INSERT|MERGE|OPTION|OUTPUT|SELECT|TOP|TRUNCATE TABLE|UPDATE|UPDATE STATISTICS|WHERE|WITH|INTO|IN|SET)\\b", RegexOptions.IgnoreCase | RegexOptions_0);
        regex_55 = new Regex("\\b(ADD|ALL|AND|ANY|AS|ASC|AUTHORIZATION|BACKUP|BEGIN|BETWEEN|BREAK|BROWSE|BY|CASCADE|CHECK|CHECKPOINT|CLOSE|CLUSTERED|COLLATE|COLUMN|COMMIT|COMPUTE|CONSTRAINT|CONTAINS|CONTINUE|CROSS|CURRENT|CURRENT_DATE|CURRENT_TIME|CURSOR|DATABASE|DBCC|DEALLOCATE|DECLARE|DEFAULT|DENY|DESC|DISK|DISTINCT|DISTRIBUTED|DOUBLE|DUMP|ELSE|END|ERRLVL|ESCAPE|EXCEPT|EXISTS|EXIT|EXTERNAL|FETCH|FILE|FILLFACTOR|FOR|FOREIGN|FREETEXT|FULL|FUNCTION|GOTO|GRANT|GROUP|HAVING|HOLDLOCK|IDENTITY|IDENTITY_INSERT|IDENTITYCOL|IF|INDEX|INNER|INTERSECT|IS|JOIN|KEY|KILL|LIKE|LINENO|LOAD|NATIONAL|NOCHECK|NONCLUSTERED|NOT|NULL|OF|OFF|OFFSETS|ON|OPEN|OR|ORDER|OUTER|OVER|PERCENT|PIVOT|PLAN|PRECISION|PRIMARY|PRINT|PROC|PROCEDURE|PUBLIC|RAISERROR|READ|READTEXT|RECONFIGURE|REFERENCES|REPLICATION|RESTORE|RESTRICT|RETURN|REVERT|REVOKE|ROLLBACK|ROWCOUNT|ROWGUIDCOL|RULE|SAVE|SCHEMA|SECURITYAUDIT|SHUTDOWN|SOME|STATISTICS|TABLE|TABLESAMPLE|TEXTSIZE|THEN|TO|TRAN|TRANSACTION|TRIGGER|TSEQUAL|UNION|UNIQUE|UNPIVOT|UPDATETEXT|USE|USER|VALUES|VARYING|VIEW|WAITFOR|WHEN|WHILE|WRITETEXT)\\b", RegexOptions.IgnoreCase | RegexOptions_0);
        regex_54 = new Regex("(@@CONNECTIONS|@@CPU_BUSY|@@CURSOR_ROWS|@@DATEFIRST|@@DATEFIRST|@@DBTS|@@ERROR|@@FETCH_STATUS|@@IDENTITY|@@IDLE|@@IO_BUSY|@@LANGID|@@LANGUAGE|@@LOCK_TIMEOUT|@@MAX_CONNECTIONS|@@MAX_PRECISION|@@NESTLEVEL|@@OPTIONS|@@PACKET_ERRORS|@@PROCID|@@REMSERVER|@@ROWCOUNT|@@SERVERNAME|@@SERVICENAME|@@SPID|@@TEXTSIZE|@@TRANCOUNT|@@VERSION)\\b|\\b(ABS|ACOS|APP_NAME|ASCII|ASIN|ASSEMBLYPROPERTY|AsymKey_ID|ASYMKEY_ID|asymkeyproperty|ASYMKEYPROPERTY|ATAN|ATN2|AVG|CASE|CAST|CEILING|Cert_ID|Cert_ID|CertProperty|CHAR|CHARINDEX|CHECKSUM_AGG|COALESCE|COL_LENGTH|COL_NAME|COLLATIONPROPERTY|COLLATIONPROPERTY|COLUMNPROPERTY|COLUMNS_UPDATED|COLUMNS_UPDATED|CONTAINSTABLE|CONVERT|COS|COT|COUNT|COUNT_BIG|CRYPT_GEN_RANDOM|CURRENT_TIMESTAMP|CURRENT_TIMESTAMP|CURRENT_USER|CURRENT_USER|CURSOR_STATUS|DATABASE_PRINCIPAL_ID|DATABASE_PRINCIPAL_ID|DATABASEPROPERTY|DATABASEPROPERTYEX|DATALENGTH|DATALENGTH|DATEADD|DATEDIFF|DATENAME|DATEPART|DAY|DB_ID|DB_NAME|DECRYPTBYASYMKEY|DECRYPTBYCERT|DECRYPTBYKEY|DECRYPTBYKEYAUTOASYMKEY|DECRYPTBYKEYAUTOCERT|DECRYPTBYPASSPHRASE|DEGREES|DENSE_RANK|DIFFERENCE|ENCRYPTBYASYMKEY|ENCRYPTBYCERT|ENCRYPTBYKEY|ENCRYPTBYPASSPHRASE|ERROR_LINE|ERROR_MESSAGE|ERROR_NUMBER|ERROR_PROCEDURE|ERROR_SEVERITY|ERROR_STATE|EVENTDATA|EXP|FILE_ID|FILE_IDEX|FILE_NAME|FILEGROUP_ID|FILEGROUP_NAME|FILEGROUPPROPERTY|FILEPROPERTY|FLOOR|fn_helpcollations|fn_listextendedproperty|fn_servershareddrives|fn_virtualfilestats|fn_virtualfilestats|FORMATMESSAGE|FREETEXTTABLE|FULLTEXTCATALOGPROPERTY|FULLTEXTSERVICEPROPERTY|GETANSINULL|GETDATE|GETUTCDATE|GROUPING|HAS_PERMS_BY_NAME|HOST_ID|HOST_NAME|IDENT_CURRENT|IDENT_CURRENT|IDENT_INCR|IDENT_INCR|IDENT_SEED|IDENTITY\\(|INDEX_COL|INDEXKEY_PROPERTY|INDEXPROPERTY|IS_MEMBER|IS_OBJECTSIGNED|IS_SRVROLEMEMBER|ISDATE|ISDATE|ISNULL|ISNUMERIC|Key_GUID|Key_GUID|Key_ID|Key_ID|KEY_NAME|KEY_NAME|LEFT|LEN|LOG|LOG10|LOWER|LTRIM|MAX|MIN|MONTH|NCHAR|NEWID|NTILE|NULLIF|OBJECT_DEFINITION|OBJECT_ID|OBJECT_NAME|OBJECT_SCHEMA_NAME|OBJECTPROPERTY|OBJECTPROPERTYEX|OPENDATASOURCE|OPENQUERY|OPENROWSET|OPENXML|ORIGINAL_LOGIN|ORIGINAL_LOGIN|PARSENAME|PATINDEX|PATINDEX|PERMISSIONS|PI|POWER|PUBLISHINGSERVERNAME|PWDCOMPARE|PWDENCRYPT|QUOTENAME|RADIANS|RAND|RANK|REPLICATE|REVERSE|RIGHT|ROUND|ROW_NUMBER|ROWCOUNT_BIG|RTRIM|SCHEMA_ID|SCHEMA_ID|SCHEMA_NAME|SCHEMA_NAME|SCOPE_IDENTITY|SERVERPROPERTY|SESSION_USER|SESSION_USER|SESSIONPROPERTY|SETUSER|SIGN|SignByAsymKey|SignByCert|SIN|SOUNDEX|SPACE|SQL_VARIANT_PROPERTY|SQRT|SQUARE|STATS_DATE|STDEV|STDEVP|STR|STUFF|SUBSTRING|SUM|SUSER_ID|SUSER_NAME|SUSER_SID|SUSER_SNAME|SWITCHOFFSET|SYMKEYPROPERTY|symkeyproperty|sys\\.dm_db_index_physical_stats|sys\\.fn_builtin_permissions|sys\\.fn_my_permissions|SYSDATETIME|SYSDATETIMEOFFSET|SYSTEM_USER|SYSTEM_USER|SYSUTCDATETIME|TAN|TERTIARY_WEIGHTS|TEXTPTR|TODATETIMEOFFSET|TRIGGER_NESTLEVEL|TYPE_ID|TYPE_NAME|TYPEPROPERTY|UNICODE|UPDATE\\(|UPPER|USER_ID|USER_NAME|USER_NAME|VAR|VARP|VerifySignedByAsymKey|VerifySignedByCert|XACT_STATE|YEAR)\\b", RegexOptions.IgnoreCase | RegexOptions_0);
        regex_59 = new Regex("\\b(BIGINT|NUMERIC|BIT|SMALLINT|DECIMAL|SMALLMONEY|INT|TINYINT|MONEY|FLOAT|REAL|DATE|DATETIMEOFFSET|DATETIME2|SMALLDATETIME|DATETIME|TIME|CHAR|VARCHAR|TEXT|NCHAR|NVARCHAR|NTEXT|BINARY|VARBINARY|IMAGE|TIMESTAMP|HIERARCHYID|TABLE|UNIQUEIDENTIFIER|SQL_VARIANT|XML)\\b", RegexOptions.IgnoreCase | RegexOptions_0);
    }

    public void vmethod_9(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = "--";
        gclass84_0.fastColoredTextBox_0.LeftBracket = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket = ')';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '\0';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = '\0';
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "";
        gclass84_0.method_34(CommentStyle, StringStyle, NumberStyle, VariableStyle, StatementsStyle, KeywordStyle, FunctionsStyle, TypesStyle);
        if (regex_58 == null)
        {
            method_15();
        }
        gclass84_0.method_20(CommentStyle, regex_50);
        gclass84_0.method_20(CommentStyle, regex_51);
        gclass84_0.method_20(CommentStyle, regex_52);
        gclass84_0.method_20(CommentStyle, regex_53);
        gclass84_0.method_20(StringStyle, regex_58);
        gclass84_0.method_20(NumberStyle, regex_56);
        gclass84_0.method_20(TypesStyle, regex_59);
        gclass84_0.method_20(VariableStyle, regex_60);
        gclass84_0.method_20(StatementsStyle, regex_57);
        gclass84_0.method_20(KeywordStyle, regex_55);
        gclass84_0.method_20(FunctionsStyle, regex_54);
        gclass84_0.method_36();
        gclass84_0.method_26("\\bBEGIN\\b", "\\bEND\\b", RegexOptions.IgnoreCase);
        gclass84_0.method_25("/\\*", "\\*/");
    }

    protected void method_16()
    {
        regex_48 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", RegexOptions_0);
        regex_47 = new Regex("\\b\\d+[\\.]?\\d*\\b", RegexOptions_0);
        regex_41 = new Regex("(//|#).*$", RegexOptions.Multiline | RegexOptions_0);
        regex_42 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | RegexOptions_0);
        regex_43 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexOptions_0);
        regex_49 = new Regex("\\$[a-zA-Z_\\d]*\\b", RegexOptions_0);
        regex_44 = new Regex("\\b(die|echo|empty|exit|eval|include|include_once|isset|list|require|require_once|return|print|unset)\\b", RegexOptions_0);
        regex_45 = new Regex("\\b(abstract|and|array|as|break|case|catch|cfunction|class|clone|const|continue|declare|default|do|else|elseif|enddeclare|endfor|endforeach|endif|endswitch|endwhile|extends|final|for|foreach|function|global|goto|if|implements|instanceof|interface|namespace|new|or|private|protected|public|static|switch|throw|try|use|var|while|xor)\\b", RegexOptions_0);
        regex_46 = new Regex("__CLASS__|__DIR__|__FILE__|__LINE__|__FUNCTION__|__METHOD__|__NAMESPACE__", RegexOptions_0);
    }

    public void vmethod_10(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = "//";
        gclass84_0.fastColoredTextBox_0.LeftBracket = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket = ')';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '{';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = '}';
        gclass84_0.fastColoredTextBox_0.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
        gclass84_0.method_34(StringStyle, CommentStyle, NumberStyle, VariableStyle, KeywordStyle, KeywordStyle2, KeywordStyle3);
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
        if (regex_48 == null)
        {
            method_16();
        }
        gclass84_0.method_20(StringStyle, regex_48);
        gclass84_0.method_20(CommentStyle, regex_41);
        gclass84_0.method_20(CommentStyle, regex_42);
        gclass84_0.method_20(CommentStyle, regex_43);
        gclass84_0.method_20(NumberStyle, regex_47);
        gclass84_0.method_20(VariableStyle, regex_49);
        gclass84_0.method_20(KeywordStyle, regex_44);
        gclass84_0.method_20(KeywordStyle2, regex_45);
        gclass84_0.method_20(KeywordStyle3, regex_46);
        gclass84_0.method_36();
        gclass84_0.method_25("{", "}");
        gclass84_0.method_25("/\\*", "\\*/");
    }

    protected void method_17()
    {
        regex_33 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", RegexOptions_0);
        regex_28 = new Regex("//.*$", RegexOptions.Multiline | RegexOptions_0);
        regex_29 = new Regex("(/\\*.*?\\*/)|(/\\*.*)", RegexOptions.Singleline | RegexOptions_0);
        regex_30 = new Regex("(/\\*.*?\\*/)|(.*\\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexOptions_0);
        regex_32 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?[lLdDfF]?\\b|\\b0x[a-fA-F\\d]+\\b", RegexOptions_0);
        regex_31 = new Regex("\\b(true|false|break|case|catch|const|continue|default|delete|do|else|export|for|function|if|in|instanceof|new|null|return|switch|this|throw|try|var|void|while|with|typeof)\\b", RegexOptions_0);
    }

    public void vmethod_11(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = "//";
        gclass84_0.fastColoredTextBox_0.LeftBracket = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket = ')';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '{';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = '}';
        gclass84_0.fastColoredTextBox_0.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
        gclass84_0.method_34(StringStyle, CommentStyle, NumberStyle, KeywordStyle);
        if (regex_33 == null)
        {
            method_17();
        }
        gclass84_0.method_20(StringStyle, regex_33);
        gclass84_0.method_20(CommentStyle, regex_28);
        gclass84_0.method_20(CommentStyle, regex_29);
        gclass84_0.method_20(CommentStyle, regex_30);
        gclass84_0.method_20(NumberStyle, regex_32);
        gclass84_0.method_20(KeywordStyle, regex_31);
        gclass84_0.method_36();
        gclass84_0.method_25("{", "}");
        gclass84_0.method_25("/\\*", "\\*/");
    }

    protected void method_18()
    {
        regex_39 = new Regex("\"\"|''|\".*?[^\\\\]\"|'.*?[^\\\\]'", RegexOptions_0);
        regex_34 = new Regex("--.*$", RegexOptions.Multiline | RegexOptions_0);
        regex_35 = new Regex("(--\\[\\[.*?\\]\\])|(--\\[\\[.*)", RegexOptions.Singleline | RegexOptions_0);
        regex_36 = new Regex("(--\\[\\[.*?\\]\\])|(.*\\]\\])", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexOptions_0);
        regex_38 = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?[lLdDfF]?\\b|\\b0x[a-fA-F\\d]+\\b", RegexOptions_0);
        regex_37 = new Regex("\\b(and|break|do|else|elseif|end|false|for|function|if|in|local|nil|not|or|repeat|return|then|true|until|while)\\b", RegexOptions_0);
        regex_40 = new Regex("\\b(assert|collectgarbage|dofile|error|getfenv|getmetatable|ipairs|load|loadfile|loadstring|module|next|pairs|pcall|print|rawequal|rawget|rawset|require|select|setfenv|setmetatable|tonumber|tostring|type|unpack|xpcall)\\b", RegexOptions_0);
    }

    public void vmethod_12(GClass84 gclass84_0)
    {
        gclass84_0.fastColoredTextBox_0.CommentPrefix = "--";
        gclass84_0.fastColoredTextBox_0.LeftBracket = '(';
        gclass84_0.fastColoredTextBox_0.RightBracket = ')';
        gclass84_0.fastColoredTextBox_0.LeftBracket2 = '{';
        gclass84_0.fastColoredTextBox_0.RightBracket2 = '}';
        gclass84_0.fastColoredTextBox_0.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
        gclass84_0.fastColoredTextBox_0.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
        gclass84_0.method_34(StringStyle, CommentStyle, NumberStyle, KeywordStyle, FunctionsStyle);
        if (regex_39 == null)
        {
            method_18();
        }
        gclass84_0.method_20(StringStyle, regex_39);
        gclass84_0.method_20(CommentStyle, regex_34);
        gclass84_0.method_20(CommentStyle, regex_35);
        gclass84_0.method_20(CommentStyle, regex_36);
        gclass84_0.method_20(NumberStyle, regex_38);
        gclass84_0.method_20(KeywordStyle, regex_37);
        gclass84_0.method_20(FunctionsStyle, regex_40);
        gclass84_0.method_36();
        gclass84_0.method_25("{", "}");
        gclass84_0.method_25("--\\[\\[", "\\]\\]");
    }

    protected void method_19(object sender, GEventArgs8 e)
    {
        if (Regex.IsMatch(e.LineText, "^\\s*(end|until)\\b"))
        {
            e.Shift = -e.TabLength;
            e.ShiftNextLines = -e.TabLength;
        }
        else if (!Regex.IsMatch(e.LineText, "\\b(then)\\s*\\S+"))
        {
            if (Regex.IsMatch(e.LineText, "^\\s*(function|do|for|while|repeat|if)\\b"))
            {
                e.ShiftNextLines = e.TabLength;
            }
            else if (Regex.IsMatch(e.LineText, "^\\s*(else|elseif)\\b", RegexOptions.IgnoreCase))
            {
                e.Shift = -e.TabLength;
            }
        }
    }
}
