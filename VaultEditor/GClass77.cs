using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GClass77
{
    [CompilerGenerated]
    private GClass84 gclass84_0;

    [CompilerGenerated]
    private Control control_0;

    [CompilerGenerated]
    private DockStyle dockStyle_0;

    [CompilerGenerated]
    private GControl3 gcontrol3_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private object object_0;

    [CompilerGenerated]
    private bool bool_0;

    public GClass84 Range
    {
        [CompilerGenerated]
        get
        {
            return gclass84_0;
        }
        [CompilerGenerated]
        set
        {
            gclass84_0 = value;
        }
    }

    public Control InnerControl
    {
        [CompilerGenerated]
        get
        {
            return control_0;
        }
        [CompilerGenerated]
        set
        {
            control_0 = value;
        }
    }

    public DockStyle Dock
    {
        [CompilerGenerated]
        get
        {
            return dockStyle_0;
        }
        [CompilerGenerated]
        set
        {
            dockStyle_0 = value;
        }
    }

    public GControl3 HostPanel
    {
        [CompilerGenerated]
        get
        {
            return gcontrol3_0;
        }
        [CompilerGenerated]
        private set
        {
            gcontrol3_0 = value;
        }
    }

    internal int TopPadding
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

    public object Tag
    {
        [CompilerGenerated]
        get
        {
            return object_0;
        }
        [CompilerGenerated]
        set
        {
            object_0 = value;
        }
    }

    public bool Inline
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

    public string String_0
    {
        get
        {
            return HostPanel.Text;
        }
        set
        {
            HostPanel.Text = value;
        }
    }

    public Color Color_0
    {
        get
        {
            return HostPanel.BackColor;
        }
        set
        {
            HostPanel.BackColor = value;
        }
    }

    public Color Color_1
    {
        get
        {
            return HostPanel.BackColor2;
        }
        set
        {
            HostPanel.BackColor2 = value;
        }
    }

    public Color Color_2
    {
        get
        {
            return HostPanel.BorderColor;
        }
        set
        {
            HostPanel.BorderColor = value;
        }
    }

    public Color Color_3
    {
        get
        {
            return HostPanel.ForeColor;
        }
        set
        {
            HostPanel.ForeColor = value;
        }
    }

    public StringAlignment StringAlignment_0
    {
        get
        {
            return HostPanel.TextAlignment;
        }
        set
        {
            HostPanel.TextAlignment = value;
        }
    }

    public Font Font_0
    {
        get
        {
            return HostPanel.Font;
        }
        set
        {
            HostPanel.Font = value;
        }
    }

    public int Int32_0
    {
        get
        {
            return HostPanel.Width;
        }
        set
        {
            HostPanel.Width = value;
        }
    }

    public int Int32_1
    {
        get
        {
            return HostPanel.Height;
        }
        set
        {
            HostPanel.Height = value;
        }
    }

    public Cursor Cursor_0
    {
        get
        {
            return HostPanel.Cursor;
        }
        set
        {
            HostPanel.Cursor = value;
        }
    }

    public event EventHandler Event_0
    {
        add
        {
            HostPanel.Click += value;
        }
        remove
        {
            HostPanel.Click -= value;
        }
    }

    private GClass77(GClass84 gclass84_1, Control control_1, string string_0, bool bool_1, bool bool_2)
    {
        Range = gclass84_1;
        Inline = bool_1;
        InnerControl = control_1;
        vmethod_1();
        Dock = (bool_2 ? DockStyle.Fill : DockStyle.None);
        String_0 = string_0;
    }

    public GClass77(GClass84 gclass84_1, string string_0, bool bool_1, bool bool_2)
        : this(gclass84_1, null, string_0, bool_1, bool_2)
    {
    }

    public GClass77(GClass84 gclass84_1, string string_0)
        : this(gclass84_1, null, string_0, bool_1: true, bool_2: true)
    {
    }

    public GClass77(GClass84 gclass84_1, Control control_1, bool bool_1, bool bool_2)
        : this(gclass84_1, control_1, null, bool_1, bool_2)
    {
    }

    public GClass77(GClass84 gclass84_1, Control control_1)
        : this(gclass84_1, control_1, null, bool_1: true, bool_2: true)
    {
    }

    public void vmethod_0()
    {
        Range.fastColoredTextBox_0.method_52(Range, bool_37: true);
        Range.fastColoredTextBox_0.method_46(HostPanel.Bounds);
        Range.fastColoredTextBox_0.method_4();
    }

    protected void vmethod_1()
    {
        HostPanel = new GControl3();
        HostPanel.Click += vmethod_2;
        Cursor_0 = Cursors.Default;
        Color_2 = Color.Silver;
        Color_1 = Color.White;
        Color_0 = ((InnerControl == null) ? Color.Silver : SystemColors.Control);
        Color_3 = Color.Black;
        StringAlignment_0 = StringAlignment.Near;
        Font_0 = ((Range.fastColoredTextBox_0.Parent == null) ? Range.fastColoredTextBox_0.Font : Range.fastColoredTextBox_0.Parent.Font);
        if (InnerControl != null)
        {
            HostPanel.Controls.Add(InnerControl);
            Size preferredSize = InnerControl.GetPreferredSize(InnerControl.Size);
            HostPanel.Width = preferredSize.Width + 2;
            HostPanel.Height = preferredSize.Height + 2;
            InnerControl.Dock = DockStyle.Fill;
            InnerControl.Visible = true;
            Color_0 = SystemColors.Control;
        }
        else
        {
            HostPanel.Height = Range.fastColoredTextBox_0.Int32_1 + 5;
        }
    }

    protected void vmethod_2(object sender, EventArgs e)
    {
        Range.fastColoredTextBox_0.vmethod_2(this);
    }
}
