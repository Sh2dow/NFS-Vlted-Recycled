using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass88 : GClass85
{
    [CompilerGenerated]
    private Brush brush_0;

    [CompilerGenerated]
    private Brush brush_1;

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

    public Brush ForegroundBrush
    {
        [CompilerGenerated]
        get
        {
            return brush_1;
        }
        [CompilerGenerated]
        private set
        {
            brush_1 = value;
        }
    }

    public bool IsExportable
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public GClass88(Brush brush_2, Brush brush_3 = null)
    {
        BackgroundBrush = brush_2;
        ForegroundBrush = brush_3;
    }

    public override void vmethod_0(Graphics graphics_0, Point point_0, GClass84 gclass84_0)
    {
        if (BackgroundBrush == null)
        {
            return;
        }
        graphics_0.SmoothingMode = SmoothingMode.None;
        Rectangle rect = new(point_0.X, point_0.Y, (gclass84_0.GStruct10_1.int_0 - gclass84_0.GStruct10_0.int_0) * gclass84_0.fastColoredTextBox_0.CharWidth, gclass84_0.fastColoredTextBox_0.Int32_1);
        if (rect.Width == 0)
        {
            return;
        }
        graphics_0.FillRectangle(BackgroundBrush, rect);
        if (ForegroundBrush == null)
        {
            return;
        }
        graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
        GClass84 gclass84_1 = new(gclass84_0.fastColoredTextBox_0, gclass84_0.GStruct10_0.int_0, gclass84_0.GStruct10_0.int_1, Math.Min(gclass84_0.fastColoredTextBox_0[gclass84_0.GStruct10_1.int_1].Count, gclass84_0.GStruct10_1.int_0), gclass84_0.GStruct10_1.int_1);
        using GClass86 gClass = new(ForegroundBrush, null, FontStyle.Regular);
        gClass.vmethod_0(graphics_0, new Point(point_0.X, point_0.Y - 1), gclass84_1);
    }
}
