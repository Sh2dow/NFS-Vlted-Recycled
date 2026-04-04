using System.Drawing;

namespace VaultEditor;

public sealed class GClass102(int int_1, Rectangle rectangle_1) : GClass99(rectangle_1)
{
    public readonly int int_0 = int_1;

    public override void vmethod_0(Graphics graphics_0, Pen pen_0)
    {
        graphics_0.DrawRectangle(pen_0, rectangle_0);
    }
}
