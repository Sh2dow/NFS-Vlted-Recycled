using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GControl1 : Control
{
    public EventHandler eventHandler_0;

    private FastColoredTextBox fastColoredTextBox_0;

    private float float_0 = 0.3f;

    private bool bool_0 = true;

    private GStruct10 gstruct10_0 = GStruct10.GStruct10_0;

    private bool bool_1 = true;

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
            if (value != null)
            {
                vmethod_2(fastColoredTextBox_0);
            }
            vmethod_0();
        }
    }

    [Description("Scale")]
    [DefaultValue(0.3f)]
    public float Single_0
    {
        get
        {
            return float_0;
        }
        set
        {
            float_0 = value;
            method_1();
        }
    }

    [Description("Scrollbar visibility")]
    [DefaultValue(true)]
    public bool Boolean_0
    {
        get
        {
            return bool_1;
        }
        set
        {
            bool_1 = value;
            method_1();
        }
    }

    public GControl1()
    {
        ForeColor = Color.Maroon;
        SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        Application.Idle += method_0;
    }

    private void method_0(object sender, EventArgs e)
    {
        if (bool_0)
        {
            Invalidate();
        }
    }

    protected void vmethod_0()
    {
        method_1();
        eventHandler_0?.Invoke(this, EventArgs.Empty);
    }

    protected void vmethod_1(FastColoredTextBox fastColoredTextBox_1)
    {
        fastColoredTextBox_1.Scroll -= vmethod_5;
        fastColoredTextBox_1.Event_9 -= vmethod_4;
        fastColoredTextBox_1.Event_7 -= vmethod_3;
    }

    protected void vmethod_2(FastColoredTextBox fastColoredTextBox_1)
    {
        fastColoredTextBox_1.Scroll += vmethod_5;
        fastColoredTextBox_1.Event_9 += vmethod_4;
        fastColoredTextBox_1.Event_7 += vmethod_3;
    }

    protected void vmethod_3(object sender, EventArgs e)
    {
        method_1();
    }

    protected void vmethod_4(object sender, EventArgs e)
    {
        method_1();
    }

    protected void vmethod_5(object sender, ScrollEventArgs e)
    {
        method_1();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        method_1();
    }

    public void method_1()
    {
        bool_0 = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (fastColoredTextBox_0 == null)
        {
            return;
        }
        float num = Single_0 * 100f / (float)fastColoredTextBox_0.Int32_13;
        if (num <= float.Epsilon)
        {
            return;
        }
        GClass84 gClass84_ = fastColoredTextBox_0.GClass84_4;
        if (gstruct10_0.int_1 > gClass84_.GStruct10_0.int_1)
        {
            gstruct10_0.int_1 = gClass84_.GStruct10_0.int_1;
        }
        else
        {
            Point point_ = fastColoredTextBox_0.method_94(gClass84_.GStruct10_1);
            point_.Offset(0, -(int)((float)base.ClientSize.Height / num) + fastColoredTextBox_0.Int32_1);
            GStruct10 gStruct = fastColoredTextBox_0.method_83(point_);
            if (gStruct.int_1 > gstruct10_0.int_1)
            {
                gstruct10_0.int_1 = gStruct.int_1;
            }
        }
        gstruct10_0.int_0 = 0;
        int count = fastColoredTextBox_0.IList_0.Count;
        float num2 = (float)gClass84_.GStruct10_0.int_1 / (float)count;
        float num3 = (float)gClass84_.GStruct10_1.int_1 / (float)count;
        e.Graphics.ScaleTransform(num, num);
        SizeF sizeF = new((float)base.ClientSize.Width / num, (float)base.ClientSize.Height / num);
        fastColoredTextBox_0.method_69(e.Graphics, gstruct10_0, sizeF.ToSize());
        Point point = fastColoredTextBox_0.method_94(gstruct10_0);
        Point point2 = fastColoredTextBox_0.method_94(gClass84_.GStruct10_0);
        Point point3 = fastColoredTextBox_0.method_94(gClass84_.GStruct10_1);
        int num4 = point2.Y - point.Y;
        int num5 = point3.Y + fastColoredTextBox_0.Int32_1 - point.Y;
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        using (SolidBrush brush = new(Color.FromArgb(50, ForeColor)))
        {
            using Pen pen = new(brush, 1f / num);
            Rectangle rect = new(0, num4, (int)((float)(base.ClientSize.Width - 1) / num), num5 - num4);
            e.Graphics.FillRectangle(brush, rect);
            e.Graphics.DrawRectangle(pen, rect);
        }
        if (bool_1)
        {
            e.Graphics.ResetTransform();
            e.Graphics.SmoothingMode = SmoothingMode.None;
            using SolidBrush brush2 = new(Color.FromArgb(200, ForeColor));
            RectangleF rect2 = new(base.ClientSize.Width - 3, (float)base.ClientSize.Height * num2, 2f, (float)base.ClientSize.Height * (num3 - num2));
            e.Graphics.FillRectangle(brush2, rect2);
        }
        bool_0 = false;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            method_2(e.Location);
        }
        base.OnMouseDown(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            method_2(e.Location);
        }
        base.OnMouseMove(e);
    }

    private void method_2(Point point_0)
    {
        if (fastColoredTextBox_0 != null)
        {
            float num = Single_0 * 100f / (float)fastColoredTextBox_0.Int32_13;
            if (!(num <= float.Epsilon))
            {
                Point point_1 = new(0, fastColoredTextBox_0.method_94(gstruct10_0).Y + (int)((float)point_0.Y / num));
                GStruct10 gStruct = fastColoredTextBox_0.method_83(point_1);
                fastColoredTextBox_0.method_52(new GClass84(fastColoredTextBox_0, gStruct, gStruct), bool_37: true);
                BeginInvoke(new System.Windows.Forms.MethodInvoker(method_3));
            }
        }
    }

    private void method_3()
    {
        Refresh();
        fastColoredTextBox_0.Refresh();
    }

    protected void Dispose(bool disposing)
    {
        if (disposing)
        {
            Application.Idle -= method_0;
            if (fastColoredTextBox_0 != null)
            {
                vmethod_1(fastColoredTextBox_0);
            }
        }
        base.Dispose(disposing);
    }
}
