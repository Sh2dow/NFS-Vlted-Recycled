using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace VaultEditor;

public sealed class GClass59
{
    private readonly int int_0 = 200;

    private readonly GClass79<GClass61> gclass79_0;

    private readonly Stack<GClass61> stack_0 = new();

    [CompilerGenerated]
    private GClass97 gclass97_0;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private EventHandler eventHandler_0 = delegate
    {
    };

    protected int int_1;

    private int int_2;

    public GClass97 TextSource
    {
        [CompilerGenerated]
        get
        {
            return gclass97_0;
        }
        [CompilerGenerated]
        private set
        {
            gclass97_0 = value;
        }
    }

    public bool UndoRedoStackIsEnabled
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

    public bool Boolean_0 => gclass79_0.Int32_1 > 0;

    public bool Boolean_1 => stack_0.Count > 0;

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

    public GClass59(GClass97 gclass97_1)
    {
        gclass79_0 = new GClass79<GClass61>(int_0);
        TextSource = gclass97_1;
        UndoRedoStackIsEnabled = true;
    }

    public void vmethod_0(GClass60 gclass60_0)
    {
        if (int_1 > 0)
        {
            return;
        }
        if (gclass60_0.gclass97_0.FastColoredTextBox_0.GClass84_5.Boolean_0 && gclass60_0 is GClass61)
        {
            gclass60_0 = new GClass68((GClass61)gclass60_0);
        }
        if (gclass60_0 is GClass61)
        {
            (gclass60_0 as GClass61).bool_0 = int_2 > 0;
            gclass79_0.method_2(gclass60_0 as GClass61);
        }
        try
        {
            gclass60_0.vmethod_0();
        }
        catch (ArgumentOutOfRangeException)
        {
            if (gclass60_0 is GClass61)
            {
                gclass79_0.method_0();
            }
        }
        if (!UndoRedoStackIsEnabled)
        {
            method_5();
        }
        stack_0.Clear();
        TextSource.FastColoredTextBox_0.method_131();
    }

    public void method_0()
    {
        if (gclass79_0.Int32_1 > 0)
        {
            GClass61 gClass = gclass79_0.method_0();
            method_2();
            try
            {
                gClass.vmethod_1();
            }
            finally
            {
                method_1();
            }
            stack_0.Push(gClass);
        }
        if (gclass79_0.Int32_1 > 0 && gclass79_0.method_1().bool_0)
        {
            method_0();
        }
        TextSource.FastColoredTextBox_0.method_131();
    }

    private void method_1()
    {
        int_1--;
    }

    private void method_2()
    {
        int_1++;
    }

    public void method_3()
    {
        int_2--;
        if (int_2 == 0 && gclass79_0.Int32_1 > 0)
        {
            gclass79_0.method_1().bool_0 = false;
        }
    }

    public void method_4()
    {
        int_2++;
    }

    internal void method_5()
    {
        gclass79_0.method_3();
        stack_0.Clear();
        TextSource.FastColoredTextBox_0.method_131();
    }

    internal void method_6()
    {
        if (stack_0.Count == 0)
        {
            return;
        }
        method_2();
        GClass61 gClass;
        try
        {
            gClass = stack_0.Pop();
            if (TextSource.FastColoredTextBox_0.GClass84_5.Boolean_0)
            {
                TextSource.FastColoredTextBox_0.GClass84_5.Boolean_0 = false;
            }
            TextSource.FastColoredTextBox_0.GClass84_5.GStruct10_0 = gClass.class84_0.Start;
            TextSource.FastColoredTextBox_0.GClass84_5.GStruct10_1 = gClass.class84_0.End;
            gClass.vmethod_0();
            gclass79_0.method_2(gClass);
        }
        finally
        {
            method_1();
        }
        eventHandler_0(this, EventArgs.Empty);
        if (gClass.bool_0)
        {
            method_6();
        }
        TextSource.FastColoredTextBox_0.method_131();
    }
}
