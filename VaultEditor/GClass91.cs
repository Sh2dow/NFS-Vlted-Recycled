using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass91 : GClass85
{
    [CompilerGenerated]
    private Pen pen_0;

    private Pen Pen
    {
        [CompilerGenerated]
        get
        {
            return pen_0;
        }
        [CompilerGenerated]
        set
        {
            pen_0 = value;
        }
    }

    public GClass91(int int_0, Color color_0)
    {
        Pen = new Pen(Color.FromArgb(int_0, color_0));
    }

    public override void vmethod_0(Graphics graphics_0, Point point_0, GClass84 gclass84_0)
    {
        Size size = GClass85.smethod_0(gclass84_0);
        Point point_1 = new(point_0.X, point_0.Y + size.Height - 1);
        Point point_2 = new(point_0.X + size.Width, point_0.Y + size.Height - 1);
        method_0(graphics_0, point_1, point_2);
    }

    private void method_0(Graphics graphics_0, Point point_0, Point point_1)
    {
        if (point_1.X - point_0.X < 2)
        {
            graphics_0.DrawLine(Pen, point_0, point_1);
            return;
        }
        int num = -1;
        List<Point> list = [];
        for (int i = point_0.X; i <= point_1.X; i += 2)
        {
            list.Add(new Point(i, point_0.Y + num));
            num = -num;
        }
        graphics_0.DrawLines(Pen, list.ToArray());
    }

    public void Dispose()
    {
        base.Dispose();
        Pen?.Dispose();
    }
}
