using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using TextEditor;

namespace VaultEditor;

public class GClass97 : IList<GClass80>, ICollection<GClass80>, IEnumerable<GClass80>, IEnumerable, IDisposable
{
    public sealed class GEventArgs14(int int_2, int int_3) : EventArgs
    {
        public int int_0 = int_2;

        public int int_1 = int_3;
    }

    protected readonly List<GClass80> list_0 = [];

    protected GClass81 gclass81_0;

    private int int_0;

    [CompilerGenerated]
    private GClass59 gclass59_0;

    private FastColoredTextBox fastColoredTextBox_0;

    public readonly GClass85[] gclass85_0;

    [CompilerGenerated]
    private EventHandler<GEventArgs3> eventHandler_0;

    [CompilerGenerated]
    private EventHandler<GEventArgs4> eventHandler_1;

    [CompilerGenerated]
    private EventHandler<GEventArgs14> eventHandler_2;

    [CompilerGenerated]
    private EventHandler<GEventArgs14> eventHandler_3;

    [CompilerGenerated]
    private EventHandler<GEventArgs14> eventHandler_4;

    [CompilerGenerated]
    private EventHandler<GEventArgs6> eventHandler_5;

    [CompilerGenerated]
    private EventHandler eventHandler_6;

    [CompilerGenerated]
    private GClass86 gclass86_0;

    public GClass59 Manager
    {
        [CompilerGenerated]
        get
        {
            return gclass59_0;
        }
        [CompilerGenerated]
        set
        {
            gclass59_0 = value;
        }
    }

    public GClass86 DefaultStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass86_0;
        }
        [CompilerGenerated]
        set
        {
            gclass86_0 = value;
        }
    }

    public virtual GClass80 this[int i]
    {
        get
        {
            return list_0[i];
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    public int Count => list_0.Count;

    public bool IsReadOnly => false;

    public FastColoredTextBox FastColoredTextBox_0
    {
        get
        {
            return fastColoredTextBox_0;
        }
        set
        {
            if (fastColoredTextBox_0 != value)
            {
                fastColoredTextBox_0 = value;
                method_0();
            }
        }
    }

    public event EventHandler<GEventArgs3> Event_0
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs3> eventHandler = eventHandler_0;
            EventHandler<GEventArgs3> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs3> eventHandler = eventHandler_0;
            EventHandler<GEventArgs3> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<GEventArgs4> Event_1
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs4> eventHandler = eventHandler_1;
            EventHandler<GEventArgs4> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs4> value2 = (EventHandler<GEventArgs4>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs4> eventHandler = eventHandler_1;
            EventHandler<GEventArgs4> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs4> value2 = (EventHandler<GEventArgs4>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<GEventArgs14> Event_2
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs14> eventHandler = eventHandler_2;
            EventHandler<GEventArgs14> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs14> value2 = (EventHandler<GEventArgs14>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs14> eventHandler = eventHandler_2;
            EventHandler<GEventArgs14> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs14> value2 = (EventHandler<GEventArgs14>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<GEventArgs14> Event_3
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs14> eventHandler = eventHandler_3;
            EventHandler<GEventArgs14> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs14> value2 = (EventHandler<GEventArgs14>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs14> eventHandler = eventHandler_3;
            EventHandler<GEventArgs14> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs14> value2 = (EventHandler<GEventArgs14>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<GEventArgs14> Event_4
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs14> eventHandler = eventHandler_4;
            EventHandler<GEventArgs14> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs14> value2 = (EventHandler<GEventArgs14>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs14> eventHandler = eventHandler_4;
            EventHandler<GEventArgs14> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs14> value2 = (EventHandler<GEventArgs14>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<GEventArgs6> Event_5
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs6> eventHandler = eventHandler_5;
            EventHandler<GEventArgs6> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs6> value2 = (EventHandler<GEventArgs6>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs6> eventHandler = eventHandler_5;
            EventHandler<GEventArgs6> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs6> value2 = (EventHandler<GEventArgs6>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler Event_6
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_6;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_6;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public GClass97(FastColoredTextBox fastColoredTextBox_1)
    {
        FastColoredTextBox_0 = fastColoredTextBox_1;
        gclass81_0 = new GClass81(this);
        Manager = new GClass59(this);
        if (Enum.GetUnderlyingType(typeof(StyleIndex)) == typeof(uint))
        {
            gclass85_0 = new GClass85[32];
        }
        else
        {
            gclass85_0 = new GClass85[16];
        }
        vmethod_2();
    }

    public virtual void vmethod_0()
    {
        foreach (GClass80 item in list_0)
        {
            item.IsChanged = false;
        }
    }

    public virtual GClass80 vmethod_1()
    {
        return new GClass80(vmethod_6());
    }

    private void method_0()
    {
        eventHandler_6?.Invoke(this, EventArgs.Empty);
    }

    public virtual void vmethod_2()
    {
        DefaultStyle = new GClass86(null, null, FontStyle.Regular);
    }

    public virtual bool vmethod_3(int int_1)
    {
        return list_0[int_1] != null;
    }

    public virtual IList<string> vmethod_4()
    {
        return gclass81_0;
    }

    public virtual IEnumerator<GClass80> GetEnumerator()
    {
        return list_0.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list_0 as IEnumerator;
    }

    public virtual int vmethod_5(GClass80 gclass80_0, IComparer<GClass80> icomparer_0)
    {
        return list_0.BinarySearch(gclass80_0, icomparer_0);
    }

    public virtual int vmethod_6()
    {
        return int_0++;
    }

    public virtual void vmethod_7(int int_1, GClass80 gclass80_0)
    {
        list_0.Insert(int_1, gclass80_0);
        vmethod_8(int_1);
    }

    public virtual void vmethod_8(int int_1)
    {
        vmethod_9(int_1, 1);
    }

    public virtual void vmethod_9(int int_1, int int_2)
    {
        eventHandler_0?.Invoke(this, new GEventArgs3(int_1, int_2));
    }

    public virtual void vmethod_10(int int_1)
    {
        vmethod_12(int_1, 1);
    }

    [SpecialName]
    public virtual bool vmethod_11()
    {
        return eventHandler_1 != null;
    }

    public virtual void vmethod_12(int int_1, int int_2)
    {
        List<int> list = [];
        if (int_2 > 0 && vmethod_11())
        {
            for (int i = 0; i < int_2; i++)
            {
                list.Add(this[int_1 + i].UniqueId);
            }
        }
        list_0.RemoveRange(int_1, int_2);
        vmethod_13(int_1, int_2, list);
    }

    public virtual void vmethod_13(int int_1, int int_2, List<int> list_1)
    {
        if (int_2 > 0 && eventHandler_1 != null)
        {
            eventHandler_1(this, new GEventArgs4(int_1, int_2, list_1));
        }
    }

    public virtual void vmethod_14(int int_1, int int_2)
    {
        eventHandler_2?.Invoke(this, new GEventArgs14(Math.Min(int_1, int_2), Math.Max(int_1, int_2)));
    }

    public virtual int IndexOf(GClass80 item)
    {
        return list_0.IndexOf(item);
    }

    public virtual void Insert(int index, GClass80 item)
    {
        vmethod_7(index, item);
    }

    public virtual void RemoveAt(int index)
    {
        vmethod_10(index);
    }

    public virtual void Add(GClass80 item)
    {
        vmethod_7(Count, item);
    }

    public virtual void Clear()
    {
        vmethod_12(0, Count);
    }

    public virtual bool Contains(GClass80 item)
    {
        return list_0.Contains(item);
    }

    public virtual void CopyTo(GClass80[] array, int arrayIndex)
    {
        list_0.CopyTo(array, arrayIndex);
    }

    public virtual bool Remove(GClass80 item)
    {
        int num = IndexOf(item);
        if (num >= 0)
        {
            vmethod_10(num);
            return true;
        }
        return false;
    }

    public virtual void vmethod_15(GEventArgs14 geventArgs14_0)
    {
        eventHandler_3?.Invoke(this, geventArgs14_0);
    }

    public virtual void vmethod_16(GEventArgs14 geventArgs14_0)
    {
        eventHandler_4?.Invoke(this, geventArgs14_0);
    }

    public virtual void vmethod_17()
    {
        string string_ = null;
        vmethod_18(ref string_);
    }

    public virtual void vmethod_18(ref string string_0)
    {
        if (eventHandler_5 != null)
        {
            GEventArgs6 gEventArgs = new()
            {
                InsertingText = string_0
            };
            eventHandler_5(this, gEventArgs);
            string_0 = gEventArgs.InsertingText;
            if (gEventArgs.Cancel)
            {
                string_0 = string.Empty;
            }
        }
    }

    public virtual int vmethod_19(int int_1)
    {
        return list_0[int_1].Count;
    }

    public virtual bool vmethod_20(int int_1)
    {
        return !string.IsNullOrEmpty(list_0[int_1].FoldingStartMarker);
    }

    public virtual bool vmethod_21(int int_1)
    {
        return !string.IsNullOrEmpty(list_0[int_1].FoldingEndMarker);
    }

    public virtual void Dispose()
    {
    }

    public virtual void vmethod_22(string string_0, Encoding encoding_0)
    {
        using StreamWriter streamWriter = new(string_0, append: false, encoding_0);
        for (int i = 0; i < Count - 1; i++)
        {
            streamWriter.WriteLine(list_0[i].vmethod_0());
        }
        streamWriter.Write(list_0[Count - 1].vmethod_0());
    }
}
