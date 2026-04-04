using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GControl2 : UserControl
{
    public EventHandler eventHandler_0;

    [CompilerGenerated]
    private Color color_0;

    [CompilerGenerated]
    private Color color_1;

    [CompilerGenerated]
    private Color color_2;

    private FastColoredTextBox fastColoredTextBox_0;

    private IContainer icontainer_0;

    [DefaultValue(typeof(Color), "ControlLight")]
    public Color BackColor2
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

    [DefaultValue(typeof(Color), "DarkGray")]
    public Color TickColor
    {
        [CompilerGenerated]
        get
        {
            return color_1;
        }
        [CompilerGenerated]
        set
        {
            color_1 = value;
        }
    }

    [DefaultValue(typeof(Color), "Black")]
    public Color CaretTickColor
    {
        [CompilerGenerated]
        get
        {
            return color_2;
        }
        [CompilerGenerated]
        set
        {
            color_2 = value;
        }
    }

    [Description("Target FastColoredTextBox")]
    public FastColoredTextBox FastColoredTextBox_0
    {
        get
        {
            return fastColoredTextBox_0;
        }
        set
        {
            if (fastColoredTextBox_0 != null)
            {
                vmethod_1(fastColoredTextBox_0);
            }
            fastColoredTextBox_0 = value;
            vmethod_2(fastColoredTextBox_0);
            vmethod_0();
        }
    }

    public GControl2()
    {
        method_2();
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        MinimumSize = new Size(0, 24);
        MaximumSize = new Size(1073741823, 24);
        BackColor2 = SystemColors.ControlLight;
        TickColor = Color.DarkGray;
        CaretTickColor = Color.Black;
    }

    protected void vmethod_0()
    {
        eventHandler_0?.Invoke(this, EventArgs.Empty);
    }

    protected void vmethod_1(FastColoredTextBox fastColoredTextBox_1)
    {
        fastColoredTextBox_1.Scroll -= vmethod_3;
        fastColoredTextBox_1.Event_6 -= method_1;
        fastColoredTextBox_1.Event_7 -= method_0;
    }

    protected void vmethod_2(FastColoredTextBox fastColoredTextBox_1)
    {
        fastColoredTextBox_1.Scroll += vmethod_3;
        fastColoredTextBox_1.Event_6 += method_1;
        fastColoredTextBox_1.Event_7 += method_0;
    }

    private void method_0(object sender, EventArgs e)
    {
        Invalidate();
    }

    private void method_1(object sender, EventArgs e)
    {
        Invalidate();
    }

    protected void vmethod_3(object sender, ScrollEventArgs e)
    {
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (fastColoredTextBox_0 == null)
        {
            return;
        }
        Point point = PointToClient(fastColoredTextBox_0.PointToScreen(fastColoredTextBox_0.method_94(fastColoredTextBox_0.GClass84_5.GStruct10_0)));
        Size size = TextRenderer.MeasureText("W", Font);
        int num = 0;
        e.Graphics.FillRectangle(new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), BackColor, BackColor2, 270f), new Rectangle(0, 0, base.Width, base.Height));
        float num2 = fastColoredTextBox_0.CharWidth;
        StringFormat stringFormat = new()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Near
        };
        Point p = fastColoredTextBox_0.method_93(0);
        p = PointToClient(fastColoredTextBox_0.PointToScreen(p));
        using (Pen pen = new(TickColor))
        {
            using SolidBrush brush = new(ForeColor);
            float num3 = p.X;
            while (num3 < (float)base.Right)
            {
                if (num % 10 == 0)
                {
                    e.Graphics.DrawString(num.ToString(), Font, brush, num3, 0f, stringFormat);
                }
                e.Graphics.DrawLine(pen, (int)num3, size.Height + ((num % 5 == 0) ? 1 : 3), (int)num3, base.Height - 4);
                num3 += num2;
                num++;
            }
        }
        using (Pen pen2 = new(TickColor))
        {
            e.Graphics.DrawLine(pen2, new Point(point.X - 3, base.Height - 3), new Point(point.X + 3, base.Height - 3));
        }
        using Pen pen3 = new(CaretTickColor);
        e.Graphics.DrawLine(pen3, new Point(point.X - 2, size.Height + 3), new Point(point.X - 2, base.Height - 4));
        e.Graphics.DrawLine(pen3, new Point(point.X, size.Height + 1), new Point(point.X, base.Height - 4));
        e.Graphics.DrawLine(pen3, new Point(point.X + 2, size.Height + 3), new Point(point.X + 2, base.Height - 4));
    }

    protected void Dispose(bool disposing)
    {
        if (disposing && icontainer_0 != null)
        {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void method_2()
    {
        icontainer_0 = new Container();
        base.AutoScaleMode = AutoScaleMode.Font;
    }
}
