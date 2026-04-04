using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;

namespace VaultEditor;

public abstract class GClass85 : IDisposable
{
    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private EventHandler<GEventArgs15> eventHandler_0;

    public bool IsExportable
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

    public event EventHandler<GEventArgs15> Event_0
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs15> eventHandler = eventHandler_0;
            EventHandler<GEventArgs15> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs15> value2 = (EventHandler<GEventArgs15>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs15> eventHandler = eventHandler_0;
            EventHandler<GEventArgs15> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs15> value2 = (EventHandler<GEventArgs15>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public GClass85()
    {
        IsExportable = true;
    }

    public abstract void vmethod_0(Graphics graphics_0, Point point_0, GClass84 gclass84_0);

    public virtual void vmethod_1(FastColoredTextBox fastColoredTextBox_0, GEventArgs15 geventArgs15_0)
    {
        eventHandler_0?.Invoke(fastColoredTextBox_0, geventArgs15_0);
    }

    protected virtual void vmethod_2(FastColoredTextBox fastColoredTextBox_0, GClass103 gclass103_0)
    {
        fastColoredTextBox_0.method_19(gclass103_0);
    }

    public static Size smethod_0(GClass84 gclass84_0)
    {
        return new Size((gclass84_0.GStruct10_1.int_0 - gclass84_0.GStruct10_0.int_0) * gclass84_0.fastColoredTextBox_0.CharWidth, gclass84_0.fastColoredTextBox_0.Int32_1);
    }

    public static GraphicsPath smethod_1(Rectangle rectangle_0, int int_0)
    {
        GraphicsPath graphicsPath = new();
        graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y, int_0, int_0, 180f, 90f);
        graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y, int_0, int_0, 270f, 90f);
        graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 0f, 90f);
        graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 90f, 90f);
        graphicsPath.AddLine(rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_0, rectangle_0.X, rectangle_0.Y + int_0 / 2);
        return graphicsPath;
    }

    public void Dispose()
    {
    }

    public virtual string vmethod_3()
    {
        return "";
    }

    public virtual GClass74 vmethod_4()
    {
        return new GClass74();
    }
}
