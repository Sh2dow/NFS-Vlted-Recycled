using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace VaultEditor;

[Browsable(false)]
public sealed class GClass55 : ToolStripDropDown, IDisposable
{
    private readonly GControl0 gcontrol0_0;

    public ToolStripControlHost toolStripControlHost_0;

    [CompilerGenerated]
    private GClass84 gclass84_0;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private EventHandler<GEventArgs0> eventHandler_0;

    [CompilerGenerated]
    private EventHandler<GEventArgs1> eventHandler_1;

    [CompilerGenerated]
    private EventHandler<CancelEventArgs> eventHandler_2;

    public GClass84 Fragment
    {
        [CompilerGenerated]
        get
        {
            return gclass84_0;
        }
        [CompilerGenerated]
        internal set
        {
            gclass84_0 = value;
        }
    }

    public string SearchPattern
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public int MinFragmentLength
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

    [DefaultValue(typeof(Color), "Orange")]
    public Color Color_0
    {
        get
        {
            return gcontrol0_0.SelectedColor;
        }
        set
        {
            gcontrol0_0.SelectedColor = value;
        }
    }

    [DefaultValue(typeof(Color), "Red")]
    public Color Color_1
    {
        get
        {
            return gcontrol0_0.HoveredColor;
        }
        set
        {
            gcontrol0_0.HoveredColor = value;
        }
    }

    public bool Boolean_0
    {
        get
        {
            return gcontrol0_0.AllowTabKey;
        }
        set
        {
            gcontrol0_0.AllowTabKey = value;
        }
    }

    public int Int32_0
    {
        get
        {
            return gcontrol0_0.Int32_1;
        }
        set
        {
            gcontrol0_0.Int32_1 = value;
        }
    }

    public Size Size_0
    {
        get
        {
            return gcontrol0_0.MaxToolTipSize;
        }
        set
        {
            gcontrol0_0.MaxToolTipSize = value;
        }
    }

    public bool Boolean_1
    {
        get
        {
            return gcontrol0_0.Boolean_0;
        }
        set
        {
            gcontrol0_0.Boolean_0 = value;
        }
    }

    public Font Font_0
    {
        get
        {
            return gcontrol0_0.Font;
        }
        set
        {
            gcontrol0_0.Font = value;
        }
    }

    public GControl0 GControl0_0 => gcontrol0_0;

    public Size Size_1
    {
        get
        {
            return GControl0_0.MinimumSize;
        }
        set
        {
            GControl0_0.MinimumSize = value;
        }
    }

    public ImageList ImageList_0
    {
        get
        {
            return GControl0_0.ImageList;
        }
        set
        {
            GControl0_0.ImageList = value;
        }
    }

    public int Int32_1
    {
        get
        {
            return GControl0_0.ToolTipDuration;
        }
        set
        {
            GControl0_0.ToolTipDuration = value;
        }
    }

    public ToolTip ToolTip_0
    {
        get
        {
            return GControl0_0.toolTip_0;
        }
        set
        {
            GControl0_0.toolTip_0 = value;
        }
    }

    public event EventHandler<GEventArgs0> Event_0
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs0> eventHandler = eventHandler_0;
            EventHandler<GEventArgs0> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs0> eventHandler = eventHandler_0;
            EventHandler<GEventArgs0> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<GEventArgs1> Event_1
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs1> eventHandler = eventHandler_1;
            EventHandler<GEventArgs1> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs1> eventHandler = eventHandler_1;
            EventHandler<GEventArgs1> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<CancelEventArgs> Event_2
    {
        [CompilerGenerated]
        add
        {
            EventHandler<CancelEventArgs> eventHandler = eventHandler_2;
            EventHandler<CancelEventArgs> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<CancelEventArgs> value2 = (EventHandler<CancelEventArgs>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<CancelEventArgs> eventHandler = eventHandler_2;
            EventHandler<CancelEventArgs> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<CancelEventArgs> value2 = (EventHandler<CancelEventArgs>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public GClass55(FastColoredTextBox fastColoredTextBox_0)
    {
        base.AutoClose = false;
        AutoSize = false;
        base.Margin = Padding.Empty;
        base.Padding = Padding.Empty;
        base.BackColor = Color.White;
        gcontrol0_0 = new GControl0(fastColoredTextBox_0);
        toolStripControlHost_0 = new ToolStripControlHost(gcontrol0_0)
        {
            Margin = new Padding(2, 2, 2, 2),
            Padding = Padding.Empty,
            AutoSize = false,
            AutoToolTip = false
        };
        method_2();
        base.Items.Add(toolStripControlHost_0);
        gcontrol0_0.Parent = this;
        SearchPattern = "[\\w\\.]";
        MinFragmentLength = 2;
    }

    internal void method_0(CancelEventArgs cancelEventArgs_0)
    {
        eventHandler_2?.Invoke(this, cancelEventArgs_0);
    }

    public void method_1()
    {
        gcontrol0_0.toolTip_0.Hide(gcontrol0_0);
        Close();
    }

    internal void method_2()
    {
        toolStripControlHost_0.Size = gcontrol0_0.Size;
        base.Size = new Size(gcontrol0_0.Size.Width + 4, gcontrol0_0.Size.Height + 4);
    }

    public void vmethod_0()
    {
        gcontrol0_0.vmethod_0();
    }

    public void method_3(int int_1)
    {
        gcontrol0_0.method_11(int_1);
    }

    internal void method_4(GEventArgs0 geventArgs0_0)
    {
        eventHandler_0?.Invoke(this, geventArgs0_0);
    }

    public void method_5(GEventArgs1 geventArgs1_0)
    {
        eventHandler_1?.Invoke(this, geventArgs1_0);
    }

    public void method_6(bool bool_0)
    {
        GControl0_0.method_4(bool_0);
    }

    protected void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (gcontrol0_0 != null && !gcontrol0_0.IsDisposed)
        {
            gcontrol0_0.Dispose();
        }
    }
}
