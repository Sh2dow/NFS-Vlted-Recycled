using System.Drawing;

namespace VaultEditor;

public sealed class GClass100(int int_1, Rectangle rectangle_1) : GClass99(rectangle_1)
{
    public readonly int int_0 = int_1;

    public void method_0(Graphics graphics_0, Pen pen_0, Brush brush_0, Pen pen_1)
    {
        graphics_0.FillRectangle(brush_0, rectangle_0);
        graphics_0.DrawRectangle(pen_0, rectangle_0);
        graphics_0.DrawLine(pen_1, rectangle_0.Left + 2, rectangle_0.Top + rectangle_0.Height / 2, rectangle_0.Right - 2, rectangle_0.Top + rectangle_0.Height / 2);
    }
}
