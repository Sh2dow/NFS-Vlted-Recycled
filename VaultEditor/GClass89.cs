using System.Drawing;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass89 : GClass85
{
    [CompilerGenerated]
    private Brush brush_0;

    public Brush BackgroundBrush
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

    public GClass89(Brush brush_1)
    {
        BackgroundBrush = brush_1;
        IsExportable = true;
    }

    public override void vmethod_0(Graphics graphics_0, Point point_0, GClass84 gclass84_0)
    {
        if (BackgroundBrush != null)
        {
            Rectangle rect = new(point_0.X, point_0.Y, (gclass84_0.GStruct10_1.int_0 - gclass84_0.GStruct10_0.int_0) * gclass84_0.fastColoredTextBox_0.CharWidth, gclass84_0.fastColoredTextBox_0.Int32_1);
            if (rect.Width != 0)
            {
                graphics_0.FillRectangle(BackgroundBrush, rect);
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
        return text;
    }
}
