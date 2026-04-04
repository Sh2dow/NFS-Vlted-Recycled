using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public class GClass86 : GClass85
{
    [CompilerGenerated]
    private Brush brush_0;

    [CompilerGenerated]
    private Brush brush_1;

    [CompilerGenerated]
    private FontStyle fontStyle_0;

    public StringFormat stringFormat_0;

    public Brush ForeBrush
    {
        [CompilerGenerated]
        get
        {
            return brush_0;
        }
        [CompilerGenerated]
        set
        {
            brush_0 = value;
        }
    }

    public Brush BackgroundBrush
    {
        [CompilerGenerated]
        get
        {
            return brush_1;
        }
        [CompilerGenerated]
        set
        {
            brush_1 = value;
        }
    }

    public FontStyle FontStyle
    {
        [CompilerGenerated]
        get
        {
            return fontStyle_0;
        }
        [CompilerGenerated]
        set
        {
            fontStyle_0 = value;
        }
    }

    public GClass86(Brush brush_2, Brush brush_3, FontStyle fontStyle_1)
    {
        ForeBrush = brush_2;
        BackgroundBrush = brush_3;
        FontStyle = fontStyle_1;
        stringFormat_0 = new StringFormat(StringFormatFlags.MeasureTrailingSpaces);
    }

    public override void vmethod_0(Graphics graphics_0, Point point_0, GClass84 gclass84_0)
    {
        if (BackgroundBrush != null)
        {
            graphics_0.FillRectangle(BackgroundBrush, point_0.X, point_0.Y, (gclass84_0.GStruct10_1.int_0 - gclass84_0.GStruct10_0.int_0) * gclass84_0.fastColoredTextBox_0.CharWidth, gclass84_0.fastColoredTextBox_0.Int32_1);
        }
        using Font font = new(gclass84_0.fastColoredTextBox_0.Font, FontStyle);
        GClass80 gClass = gclass84_0.fastColoredTextBox_0[gclass84_0.GStruct10_0.int_1];
        float num = gclass84_0.fastColoredTextBox_0.CharWidth;
        float num2 = point_0.Y + gclass84_0.fastColoredTextBox_0.Int32_2 / 2;
        float num3 = point_0.X - gclass84_0.fastColoredTextBox_0.CharWidth / 3;
        ForeBrush ??= new SolidBrush(gclass84_0.fastColoredTextBox_0.ForeColor);
        if (gclass84_0.fastColoredTextBox_0.Boolean_13)
        {
            for (int i = gclass84_0.GStruct10_0.int_0; i < gclass84_0.GStruct10_1.int_0; i++)
            {
                SizeF sizeF = FastColoredTextBox.smethod_1(font, gClass[i].char_0);
                GraphicsState gstate = graphics_0.Save();
                float num4 = ((sizeF.Width > (float)(gclass84_0.fastColoredTextBox_0.CharWidth + 1)) ? ((float)gclass84_0.fastColoredTextBox_0.CharWidth / sizeF.Width) : 1f);
                graphics_0.TranslateTransform(num3, num2 + (1f - num4) * (float)gclass84_0.fastColoredTextBox_0.Int32_1 / 2f);
                graphics_0.ScaleTransform(num4, (float)Math.Sqrt(num4));
                graphics_0.DrawString(gClass[i].char_0.ToString(), font, ForeBrush, 0f, 0f, stringFormat_0);
                graphics_0.Restore(gstate);
                num3 += num;
            }
        }
        else
        {
            for (int j = gclass84_0.GStruct10_0.int_0; j < gclass84_0.GStruct10_1.int_0; j++)
            {
                graphics_0.DrawString(gClass[j].char_0.ToString(), font, ForeBrush, num3, num2, stringFormat_0);
                num3 += num;
            }
        }
    }

    public override string vmethod_3()
    {
        string text = "";
        if (BackgroundBrush is SolidBrush)
        {
            string text2 = GClass72.smethod_0((BackgroundBrush as SolidBrush).Color);
            if (text2 != "")
            {
                text = text + "background-color:" + text2 + ";";
            }
        }
        if (ForeBrush is SolidBrush)
        {
            string text3 = GClass72.smethod_0((ForeBrush as SolidBrush).Color);
            if (text3 != "")
            {
                text = text + "color:" + text3 + ";";
            }
        }
        if ((FontStyle & FontStyle.Bold) != FontStyle.Regular)
        {
            text += "font-weight:bold;";
        }
        if ((FontStyle & FontStyle.Italic) != FontStyle.Regular)
        {
            text += "font-style:oblique;";
        }
        if ((FontStyle & FontStyle.Strikeout) != FontStyle.Regular)
        {
            text += "text-decoration:line-through;";
        }
        if ((FontStyle & FontStyle.Underline) != FontStyle.Regular)
        {
            text += "text-decoration:underline;";
        }
        return text;
    }

    public override GClass74 vmethod_4()
    {
        GClass74 gClass = new();
        if (BackgroundBrush is SolidBrush)
        {
            gClass.BackColor = (BackgroundBrush as SolidBrush).Color;
        }
        if (ForeBrush is SolidBrush)
        {
            gClass.ForeColor = (ForeBrush as SolidBrush).Color;
        }
        if ((FontStyle & FontStyle.Bold) != FontStyle.Regular)
        {
            gClass.AdditionalTags += "\\b";
        }
        if ((FontStyle & FontStyle.Italic) != FontStyle.Regular)
        {
            gClass.AdditionalTags += "\\i";
        }
        if ((FontStyle & FontStyle.Strikeout) != FontStyle.Regular)
        {
            gClass.AdditionalTags += "\\strike";
        }
        if ((FontStyle & FontStyle.Underline) != FontStyle.Regular)
        {
            gClass.AdditionalTags += "\\ul";
        }
        return gClass;
    }
}
