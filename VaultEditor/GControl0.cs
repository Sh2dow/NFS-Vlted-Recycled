using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using TextEditor;

namespace VaultEditor;

[ToolboxItem(false)]
public sealed class GControl0 : UserControl, IDisposable
{
    [CompilerGenerated]
    private EventHandler eventHandler_0;

    internal List<GClass51> list_0;

    private IEnumerable<GClass51> ienumerable_0 = new List<GClass51>();

    private int int_0;

    private readonly int int_1 = -1;

    private int int_2;

    private readonly FastColoredTextBox fastColoredTextBox_0;

    internal ToolTip toolTip_0 = new();

    private readonly System.Windows.Forms.Timer timer_0 = new();

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private ImageList imageList_0;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private Size size_0;

    [CompilerGenerated]
    private Color color_0;

    [CompilerGenerated]
    private Color color_1;

    internal bool AllowTabKey
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public ImageList ImageList
    {
        [CompilerGenerated]
        get
        {
            return imageList_0;
        }
        [CompilerGenerated]
        set
        {
            imageList_0 = value;
        }
    }

    internal int ToolTipDuration
    {
        [CompilerGenerated]
        get
        {
            return int_3;
        }
        [CompilerGenerated]
        set
        {
            int_3 = value;
        }
    }

    internal Size MaxToolTipSize
    {
        [CompilerGenerated]
        get
        {
            return size_0;
        }
        [CompilerGenerated]
        set
        {
            size_0 = value;
        }
    }

    public Color SelectedColor
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

    public Color HoveredColor
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

    private int Int32_0 => Font.Height + 2;

    private GClass55 GClass55_0 => base.Parent as GClass55;

    internal int Int32_1
    {
        get
        {
            return timer_0.Interval;
        }
        set
        {
            timer_0.Interval = value;
        }
    }

    internal bool Boolean_0
    {
        get
        {
            return toolTip_0.ShowAlways;
        }
        set
        {
            toolTip_0.ShowAlways = value;
        }
    }

    public int Int32_2
    {
        get
        {
            return int_0;
        }
        set
        {
            if (int_0 != value)
            {
                int_0 = value;
                eventHandler_0?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public GClass51 GClass51_0
    {
        get
        {
            if (Int32_2 >= 0 && int_0 < list_0.Count)
            {
                return list_0[int_0];
            }
            return null;
        }
        set
        {
            Int32_2 = list_0.IndexOf(value);
        }
    }

    public int Int32_3 => list_0.Count;

    public event EventHandler Event_0
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_0;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_0;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    internal GControl0(FastColoredTextBox fastColoredTextBox_1)
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        base.Font = new Font(FontFamily.GenericSansSerif, 9f);
        list_0 = [];
        base.VerticalScroll.SmallChange = Int32_0;
        MaximumSize = new Size(base.Size.Width, 180);
        toolTip_0.ShowAlways = false;
        Int32_1 = 500;
        timer_0.Tick += timer_0_Tick;
        SelectedColor = Color.Orange;
        HoveredColor = Color.Red;
        ToolTipDuration = 3000;
        toolTip_0.Popup += toolTip_0_Popup;
        fastColoredTextBox_0 = fastColoredTextBox_1;
        fastColoredTextBox_1.KeyDown += method_6;
        fastColoredTextBox_1.Event_6 += method_5;
        fastColoredTextBox_1.Event_13 += method_1;
        Form form = fastColoredTextBox_1.FindForm();
        if (form != null)
        {
            form.LocationChanged += delegate
            {
                method_0();
            };
            form.ResizeBegin += delegate
            {
                method_0();
            };
            form.FormClosing += delegate
            {
                method_0();
            };
            form.LostFocus += delegate
            {
                method_0();
            };
        }
        fastColoredTextBox_1.LostFocus += delegate
        {
            if (GClass55_0 != null && !GClass55_0.IsDisposed && !GClass55_0.Focused)
            {
                method_0();
            }
        };
        fastColoredTextBox_1.Scroll += delegate
        {
            method_0();
        };
        base.VisibleChanged += delegate
        {
            if (base.Visible)
            {
                method_12();
            }
        };
    }

    private void toolTip_0_Popup(object sender, PopupEventArgs e)
    {
        if (MaxToolTipSize.Height > 0 && MaxToolTipSize.Width > 0)
        {
            e.ToolTipSize = MaxToolTipSize;
        }
    }

    protected void Dispose(bool disposing)
    {
        if (toolTip_0 != null)
        {
            toolTip_0.Popup -= toolTip_0_Popup;
            toolTip_0.Dispose();
        }
        if (fastColoredTextBox_0 != null)
        {
            fastColoredTextBox_0.KeyDown -= method_6;
            fastColoredTextBox_0.KeyPress -= method_1;
            fastColoredTextBox_0.Event_6 -= method_5;
        }
        if (timer_0 != null)
        {
            timer_0.Stop();
            timer_0.Tick -= timer_0_Tick;
            timer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void method_0()
    {
        if (GClass55_0 != null && !GClass55_0.IsDisposed)
        {
            GClass55_0.method_1();
        }
    }

    private void method_1(object sender, KeyPressEventArgs e)
    {
        bool flag = e.KeyChar == '\b' || e.KeyChar == 'ÿ';
        if (GClass55_0.Visible && !flag)
        {
            method_4(bool_1: false);
        }
        else
        {
            method_2(timer_0);
        }
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
        timer_0.Stop();
        method_4(bool_1: false);
    }

    private void method_2(System.Windows.Forms.Timer timer_1)
    {
        timer_1.Stop();
        timer_1.Start();
    }

    internal void method_3()
    {
        method_4(bool_1: false);
    }

    internal void method_4(bool bool_1)
    {
        if (!GClass55_0.Enabled)
        {
            GClass55_0.method_1();
            return;
        }
        list_0.Clear();
        Int32_2 = 0;
        base.VerticalScroll.Value = 0;
        base.AutoScrollMinSize -= new Size(1, 0);
        base.AutoScrollMinSize += new Size(1, 0);
        GClass84 gClass = fastColoredTextBox_0.GClass84_5.method_43(GClass55_0.SearchPattern);
        string text = gClass.vmethod_2();
        Point position = fastColoredTextBox_0.method_94(gClass.GStruct10_1);
        position.Offset(2, fastColoredTextBox_0.Int32_1);
        if (bool_1 || (text.Length >= GClass55_0.MinFragmentLength && fastColoredTextBox_0.GClass84_5.vmethod_0() && (GStruct10.smethod_4(fastColoredTextBox_0.GClass84_5.GStruct10_0, gClass.GStruct10_0) || text.Length == 0)))
        {
            GClass55_0.Fragment = gClass;
            bool flag = false;
            foreach (GClass51 item in ienumerable_0)
            {
                item.Parent = GClass55_0;
                GEnum4 num = item.vmethod_1(text);
                if (num != GEnum4.const_0)
                {
                    list_0.Add(item);
                }
                if (num == GEnum4.const_2 && !flag)
                {
                    flag = true;
                    Int32_2 = list_0.Count - 1;
                }
            }
            if (flag)
            {
                method_7();
                method_12();
            }
        }
        if (Int32_3 > 0)
        {
            if (!GClass55_0.Visible)
            {
                CancelEventArgs e = new();
                GClass55_0.method_0(e);
                if (!e.Cancel)
                {
                    GClass55_0.Show(fastColoredTextBox_0, position);
                }
            }
            method_12();
            Invalidate();
        }
        else
        {
            GClass55_0.method_1();
        }
    }

    private void method_5(object sender, EventArgs e)
    {
        if (!GClass55_0.Visible)
        {
            return;
        }
        bool flag = false;
        if (!fastColoredTextBox_0.GClass84_5.vmethod_0())
        {
            flag = true;
        }
        else if (!GClass55_0.Fragment.method_0(fastColoredTextBox_0.GClass84_5.GStruct10_0))
        {
            if (fastColoredTextBox_0.GClass84_5.GStruct10_0.int_1 == GClass55_0.Fragment.GStruct10_1.int_1 && fastColoredTextBox_0.GClass84_5.GStruct10_0.int_0 == GClass55_0.Fragment.GStruct10_1.int_0 + 1)
            {
                if (!Regex.IsMatch(fastColoredTextBox_0.GClass84_5.Char_1.ToString(), GClass55_0.SearchPattern))
                {
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }
        }
        if (flag)
        {
            GClass55_0.method_1();
        }
    }

    private void method_6(object sender, KeyEventArgs e)
    {
        FastColoredTextBox fastColoredTextBox = sender as FastColoredTextBox;
        if (GClass55_0.Visible && method_10(e.KeyCode, e.Modifiers))
        {
            e.Handled = true;
        }
        if (!GClass55_0.Visible)
        {
            if (fastColoredTextBox.HotkeysMapping.ContainsKey(e.KeyData) && fastColoredTextBox.HotkeysMapping[e.KeyData] == FCTBAction.AutocompleteMenu)
            {
                method_3();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape && timer_0.Enabled)
            {
                timer_0.Stop();
            }
        }
    }

    private void method_7()
    {
        if (int_2 != list_0.Count)
        {
            int val = Int32_0 * list_0.Count + 1;
            base.Height = Math.Min(val, MaximumSize.Height);
            GClass55_0.method_2();
            base.AutoScrollMinSize = new Size(0, val);
            int_2 = list_0.Count;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        method_7();
        int int32_ = Int32_0;
        int val = base.VerticalScroll.Value / int32_ - 1;
        int val2 = (base.VerticalScroll.Value + base.ClientSize.Height) / int32_ + 1;
        int num = Math.Max(val, 0);
        val2 = Math.Min(val2, list_0.Count);
        int num2 = 18;
        for (int i = num; i < val2; i++)
        {
            int num3 = i * int32_ - base.VerticalScroll.Value;
            GClass51 gClass = list_0[i];
            if (gClass.vmethod_11() != Color.Transparent)
            {
                using SolidBrush brush = new(gClass.vmethod_11());
                e.Graphics.FillRectangle(brush, 1, num3, base.ClientSize.Width - 1 - 1, int32_ - 1);
            }
            if (ImageList != null && list_0[i].int_0 >= 0)
            {
                e.Graphics.DrawImage(ImageList.Images[gClass.int_0], 1, num3);
            }
            if (i == Int32_2)
            {
                using LinearGradientBrush brush2 = new(new Point(0, num3 - 3), new Point(0, num3 + int32_), Color.Transparent, SelectedColor);
                using Pen pen = new(SelectedColor);
                e.Graphics.FillRectangle(brush2, num2, num3, base.ClientSize.Width - 1 - num2, int32_ - 1);
                e.Graphics.DrawRectangle(pen, num2, num3, base.ClientSize.Width - 1 - num2, int32_ - 1);
            }
            if (i == int_1)
            {
                using Pen pen2 = new(HoveredColor);
                e.Graphics.DrawRectangle(pen2, num2, num3, base.ClientSize.Width - 1 - num2, int32_ - 1);
            }
            using SolidBrush brush3 = new((gClass.vmethod_9() != Color.Transparent) ? gClass.vmethod_9() : ForeColor);
            e.Graphics.DrawString(gClass.ToString(), Font, brush3, num2, num3);
        }
    }

    protected override void OnScroll(ScrollEventArgs se)
    {
        base.OnScroll(se);
        Invalidate();
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        if (e.Button == MouseButtons.Left)
        {
            Int32_2 = method_9(e.Location);
            method_12();
            Invalidate();
        }
    }

    protected override void OnMouseDoubleClick(MouseEventArgs e)
    {
        base.OnMouseDoubleClick(e);
        Int32_2 = method_9(e.Location);
        Invalidate();
        vmethod_0();
    }

    internal void vmethod_0()
    {
        if (Int32_2 < 0 || Int32_2 >= list_0.Count)
        {
            return;
        }
        fastColoredTextBox_0.GClass97_0.Manager.method_4();
        try
        {
            GClass51 gClass51_ = GClass51_0;
            GEventArgs0 gEventArgs = new()
            {
                Item = gClass51_,
                SelectedIndex = Int32_2
            };
            GClass55_0.method_4(gEventArgs);
            if (gEventArgs.Cancel)
            {
                Int32_2 = gEventArgs.SelectedIndex;
                Invalidate();
                return;
            }
            if (!gEventArgs.Handled)
            {
                GClass84 fragment = GClass55_0.Fragment;
                method_8(gClass51_, fragment);
            }
            GClass55_0.method_1();
            GEventArgs1 geventArgs1_ = new()
            {
                Item = gClass51_,
                Tb = GClass55_0.Fragment.fastColoredTextBox_0
            };
            gClass51_.vmethod_2(GClass55_0, geventArgs1_);
            GClass55_0.method_5(geventArgs1_);
        }
        finally
        {
            fastColoredTextBox_0.GClass97_0.Manager.method_3();
        }
    }

    private void method_8(GClass51 gclass51_0, GClass84 gclass84_0)
    {
        string string_ = gclass51_0.vmethod_0();
        FastColoredTextBox fastColoredTextBox = gclass84_0.fastColoredTextBox_0;
        fastColoredTextBox.method_107();
        fastColoredTextBox.GClass97_0.Manager.vmethod_0(new GClass69(fastColoredTextBox.GClass97_0));
        if (fastColoredTextBox.GClass84_5.Boolean_0)
        {
            GStruct10 gStruct10_ = fastColoredTextBox.GClass84_5.GStruct10_0;
            GStruct10 gStruct10_2 = fastColoredTextBox.GClass84_5.GStruct10_1;
            gStruct10_.int_0 = gclass84_0.GStruct10_0.int_0;
            gStruct10_2.int_0 = gclass84_0.GStruct10_1.int_0;
            fastColoredTextBox.GClass84_5.GStruct10_0 = gStruct10_;
            fastColoredTextBox.GClass84_5.GStruct10_1 = gStruct10_2;
        }
        else
        {
            fastColoredTextBox.GClass84_5.GStruct10_0 = gclass84_0.GStruct10_0;
            fastColoredTextBox.GClass84_5.GStruct10_1 = gclass84_0.GStruct10_1;
        }
        fastColoredTextBox.vmethod_20(string_);
        fastColoredTextBox.GClass97_0.Manager.vmethod_0(new GClass69(fastColoredTextBox.GClass97_0));
        fastColoredTextBox.method_108();
        fastColoredTextBox.Focus();
    }

    private int method_9(Point point_0)
    {
        return (point_0.Y + base.VerticalScroll.Value) / Int32_0;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        method_10(keyData, Keys.None);
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private bool method_10(Keys keys_0, Keys keys_1)
    {
        if (keys_1 == Keys.None)
        {
            switch (keys_0)
            {
                case Keys.Escape:
                    GClass55_0.method_1();
                    return true;
                case Keys.Return:
                    vmethod_0();
                    return true;
                case Keys.Tab:
                    if (AllowTabKey)
                    {
                        vmethod_0();
                        return true;
                    }
                    break;
                case Keys.Next:
                    method_11(10);
                    return true;
                case Keys.Prior:
                    method_11(-10);
                    return true;
                case Keys.Down:
                    method_11(1);
                    return true;
                case Keys.Up:
                    method_11(-1);
                    return true;
            }
        }
        return false;
    }

    public void method_11(int int_4)
    {
        Int32_2 = Math.Max(0, Math.Min(Int32_2 + int_4, list_0.Count - 1));
        method_12();
        Invalidate();
    }

    private void method_12()
    {
        if (GClass51_0 != null)
        {
            method_13(GClass51_0);
        }
        int num = Int32_2 * Int32_0 - base.VerticalScroll.Value;
        if (num < 0)
        {
            base.VerticalScroll.Value = Int32_2 * Int32_0;
        }
        if (num > base.ClientSize.Height - Int32_0)
        {
            base.VerticalScroll.Value = Math.Min(base.VerticalScroll.Maximum, Int32_2 * Int32_0 - base.ClientSize.Height + Int32_0);
        }
        base.AutoScrollMinSize -= new Size(1, 0);
        base.AutoScrollMinSize += new Size(1, 0);
    }

    private void method_13(GClass51 gclass51_0)
    {
        string text = gclass51_0.vmethod_3();
        string value = gclass51_0.vmethod_5();
        if (string.IsNullOrEmpty(text))
        {
            toolTip_0.ToolTipTitle = null;
            toolTip_0.SetToolTip(this, null);
        }
        else if (base.Parent != null)
        {
            IWin32Window win32Window = base.Parent ?? this;
            Point point = ((PointToScreen(base.Location).X + MaxToolTipSize.Width + 105 >= Screen.FromControl(base.Parent).WorkingArea.Right) ? new Point(base.Left - 105 - MaximumSize.Width, 0) : new Point(base.Right + 5, 0));
            if (string.IsNullOrEmpty(value))
            {
                toolTip_0.ToolTipTitle = null;
                toolTip_0.Show(text, win32Window, point.X, point.Y, ToolTipDuration);
            }
            else
            {
                toolTip_0.ToolTipTitle = text;
                toolTip_0.Show(value, win32Window, point.X, point.Y, ToolTipDuration);
            }
        }
    }

    public void method_14(ICollection<string> icollection_0)
    {
        List<GClass51> list = new(icollection_0.Count);
        foreach (string item in icollection_0)
        {
            list.Add(new GClass51(item));
        }
        method_15(list);
    }

    public void method_15(IEnumerable<GClass51> ienumerable_1)
    {
        ienumerable_0 = ienumerable_1;
    }

    [CompilerGenerated]
    private void method_16(object sender, EventArgs e)
    {
        method_0();
    }

    [CompilerGenerated]
    private void method_17(object sender, EventArgs e)
    {
        method_0();
    }

    [CompilerGenerated]
    private void method_18(object sender, FormClosingEventArgs e)
    {
        method_0();
    }

    [CompilerGenerated]
    private void method_19(object sender, EventArgs e)
    {
        method_0();
    }

    [CompilerGenerated]
    private void method_20(object sender, EventArgs e)
    {
        if (GClass55_0 != null && !GClass55_0.IsDisposed && !GClass55_0.Focused)
        {
            method_0();
        }
    }

    [CompilerGenerated]
    private void method_21(object sender, ScrollEventArgs e)
    {
        method_0();
    }

    [CompilerGenerated]
    private void GControl0_VisibleChanged(object sender, EventArgs e)
    {
        if (base.Visible)
        {
            method_12();
        }
    }
}
