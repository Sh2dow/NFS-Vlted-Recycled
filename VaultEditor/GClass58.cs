using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass58
{
    [CompilerGenerated]
    private FastColoredTextBox fastColoredTextBox_0;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private Color color_0;

    public FastColoredTextBox FastColoredTextBox_0
    {
        [CompilerGenerated]
        get
        {
            return fastColoredTextBox_0;
        }
        [CompilerGenerated]
        private set
        {
            fastColoredTextBox_0 = value;
        }
    }

    public string Name
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

    public int LineIndex
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public Color Color
    {
        [CompilerGenerated]
        get
        {
            return color_0;
        }
        [CompilerGenerated]
        set
        {
            color_0 = value;
        }
    }

    public GClass58(FastColoredTextBox fastColoredTextBox_1, string string_1, int int_1)
    {
        FastColoredTextBox_0 = fastColoredTextBox_1;
        Name = string_1;
        LineIndex = int_1;
        Color = fastColoredTextBox_1.BookmarkColor;
    }

    public void vmethod_0()
    {
        FastColoredTextBox_0.GClass84_5.GStruct10_0 = new GStruct10(0, LineIndex);
        FastColoredTextBox_0.method_52(FastColoredTextBox_0.GClass84_5, bool_37: true);
        FastColoredTextBox_0.method_4();
    }

    public void vmethod_1(Graphics graphics_0, Rectangle rectangle_0)
    {
        int num = FastColoredTextBox_0.Int32_1 - 1;
        using (LinearGradientBrush brush = new(new Rectangle(0, rectangle_0.Top, num, num), Color.White, Color, 45f))
        {
            graphics_0.FillEllipse(brush, 0, rectangle_0.Top, num, num);
        }
        using Pen pen = new(Color);
        graphics_0.DrawEllipse(pen, 0, rectangle_0.Top, num, num);
    }
}
