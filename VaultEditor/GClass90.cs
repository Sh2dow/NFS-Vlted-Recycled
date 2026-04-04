using System.Drawing;

namespace VaultEditor;

public sealed class GClass90(Pen pen_1) : GClass85
{
    public Pen pen_0 = pen_1;

    public override void vmethod_0(Graphics graphics_0, Point point_0, GClass84 gclass84_0)
    {
        Point point = gclass84_0.fastColoredTextBox_0.method_94(gclass84_0.GStruct10_1);
        Rectangle rectangle_ = new(point.X - 5, point.Y + gclass84_0.fastColoredTextBox_0.Int32_1 - 2, 4, 3);
        graphics_0.FillPath(Brushes.White, GClass85.smethod_1(rectangle_, 1));
        graphics_0.DrawPath(pen_0, GClass85.smethod_1(rectangle_, 1));
        vmethod_2(gclass84_0.fastColoredTextBox_0, new GClass103(new Rectangle(point.X - gclass84_0.fastColoredTextBox_0.CharWidth, point.Y, gclass84_0.fastColoredTextBox_0.CharWidth, gclass84_0.fastColoredTextBox_0.Int32_1), this));
    }
}
