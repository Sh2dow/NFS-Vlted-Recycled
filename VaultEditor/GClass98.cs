using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GClass98 : GClass97, IDisposable
{
    private List<int> list_1 = [];

    private FileStream fileStream_0;

    private Encoding encoding_0;

    private readonly System.Windows.Forms.Timer timer_0 = new();

    [CompilerGenerated]
    private EventHandler<GEventArgs12> eventHandler_7;

    [CompilerGenerated]
    private EventHandler<GEventArgs13> eventHandler_8;

    [CompilerGenerated]
    private string string_0;

    public string SaveEOL
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

    public override GClass80 this[int i]
    {
        get
        {
            if (list_0[i] != null)
            {
                return list_0[i];
            }
            method_6(i);
            return list_0[i];
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    public event EventHandler<GEventArgs12> Event_7
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs12> eventHandler = eventHandler_7;
            EventHandler<GEventArgs12> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs12> value2 = (EventHandler<GEventArgs12>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_7, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs12> eventHandler = eventHandler_7;
            EventHandler<GEventArgs12> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs12> value2 = (EventHandler<GEventArgs12>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_7, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<GEventArgs13> Event_8
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs13> eventHandler = eventHandler_8;
            EventHandler<GEventArgs13> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs13> value2 = (EventHandler<GEventArgs13>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_8, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs13> eventHandler = eventHandler_8;
            EventHandler<GEventArgs13> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs13> value2 = (EventHandler<GEventArgs13>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_8, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public GClass98(FastColoredTextBox fastColoredTextBox_1)
        : base(fastColoredTextBox_1)
    {
        timer_0.Interval = 10000;
        timer_0.Tick += timer_0_Tick;
        timer_0.Enabled = true;
        SaveEOL = Environment.NewLine;
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
        timer_0.Enabled = false;
        try
        {
            method_1();
        }
        finally
        {
            timer_0.Enabled = true;
        }
    }

    private void method_1()
    {
        _ = base.FastColoredTextBox_0.GClass84_4.GStruct10_0;
        int int_ = base.FastColoredTextBox_0.GClass84_4.GStruct10_1.int_1;
        int num = 0;
        for (int i = 0; i < Count; i++)
        {
            if (list_0[i] != null && !list_0[i].IsChanged && Math.Abs(i - int_) > 2000)
            {
                list_0[i] = null;
                num++;
            }
        }
    }

    public void method_2(string string_1, Encoding encoding_1)
    {
        Clear();
        fileStream_0?.Dispose();
        SaveEOL = Environment.NewLine;
        fileStream_0 = new FileStream(string_1, FileMode.Open);
        long length = fileStream_0.Length;
        encoding_1 = smethod_0(encoding_1, fileStream_0);
        method_3(encoding_1);
        list_1.Add((int)fileStream_0.Position);
        list_0.Add(null);
        list_1.Capacity = (int)(length / 7L + 1000L);
        int num = 0;
        int item = 0;
        BinaryReader binaryReader = new(fileStream_0, encoding_1);
        while (fileStream_0.Position < length)
        {
            item = (int)fileStream_0.Position;
            char num2 = binaryReader.ReadChar();
            if (num2 == '\n')
            {
                list_1.Add((int)fileStream_0.Position);
                list_0.Add(null);
            }
            else if (num == 13)
            {
                list_1.Add(item);
                list_0.Add(null);
                SaveEOL = "\r";
            }
            num = num2;
        }
        if (num == 13)
        {
            list_1.Add(item);
            list_0.Add(null);
        }
        if (length > 2000000L)
        {
            GC.Collect();
        }
        GClass80[] array = new GClass80[100];
        int count = list_0.Count;
        list_0.AddRange(array);
        list_0.TrimExcess();
        list_0.RemoveRange(count, array.Length);
        int[] collection = new int[100];
        count = list_0.Count;
        list_1.AddRange(collection);
        list_1.TrimExcess();
        list_1.RemoveRange(count, array.Length);
        encoding_0 = encoding_1;
        vmethod_9(0, Count);
        int num3 = Math.Min(list_0.Count, base.FastColoredTextBox_0.ClientRectangle.Height / base.FastColoredTextBox_0.Int32_1);
        for (int i = 0; i < num3; i++)
        {
            method_6(i);
        }
        vmethod_15(new GEventArgs14(0, num3 - 1));
        if (base.FastColoredTextBox_0.Boolean_11)
        {
            vmethod_16(new GEventArgs14(0, num3 - 1));
        }
    }

    private int method_3(Encoding encoding_1)
    {
        if (encoding_1.IsSingleByte)
        {
            return 0;
        }
        if (encoding_1.HeaderName == "unicodeFFFE")
        {
            return 0;
        }
        if (encoding_1.HeaderName == "utf-16")
        {
            return 1;
        }
        if (encoding_1.HeaderName == "utf-32BE")
        {
            return 0;
        }
        if (encoding_1.HeaderName == "utf-32")
        {
            return 3;
        }
        return 0;
    }

    private static Encoding smethod_0(Encoding encoding_1, FileStream fileStream_1)
    {
        int num = 0;
        byte[] array = new byte[4];
        int num2 = fileStream_1.Read(array, 0, 4);
        if (array[0] == byte.MaxValue && array[1] == 254 && array[2] == 0 && array[3] == 0 && num2 >= 4)
        {
            encoding_1 = Encoding.UTF32;
            num = 4;
        }
        else if (array[0] == 0 && array[1] == 0 && array[2] == 254 && array[3] == byte.MaxValue)
        {
            encoding_1 = new UTF32Encoding(bigEndian: true, byteOrderMark: true);
            num = 4;
        }
        else if (array[0] == 239 && array[1] == 187 && array[2] == 191)
        {
            encoding_1 = Encoding.UTF8;
            num = 3;
        }
        else if (array[0] == 254 && array[1] == byte.MaxValue)
        {
            encoding_1 = Encoding.BigEndianUnicode;
            num = 2;
        }
        else if (array[0] == byte.MaxValue && array[1] == 254)
        {
            encoding_1 = Encoding.Unicode;
            num = 2;
        }
        fileStream_1.Seek(num, SeekOrigin.Begin);
        return encoding_1;
    }

    public void method_4()
    {
        if (fileStream_0 != null)
        {
            try
            {
                fileStream_0.Dispose();
            }
            catch
            {
            }
        }
        fileStream_0 = null;
    }

    public override void vmethod_22(string string_1, Encoding encoding_1)
    {
        List<int> list = new(Count);
        string text = Path.Combine(Path.GetDirectoryName(string_1), Path.GetFileNameWithoutExtension(string_1) + ".tmp");
        StreamReader streamReader = new(fileStream_0, encoding_0);
        using (FileStream fileStream = new(text, FileMode.Create))
        {
            using StreamWriter streamWriter = new(fileStream, encoding_1);
            streamWriter.Flush();
            for (int i = 0; i < Count; i++)
            {
                list.Add((int)fileStream.Length);
                string text2 = method_5(streamReader, i);
                bool flag;
                string text3 = ((!(flag = list_0[i] != null && list_0[i].IsChanged)) ? text2 : list_0[i].vmethod_0());
                if (eventHandler_8 != null)
                {
                    GEventArgs13 gEventArgs = new(text2, i, flag ? text3 : null);
                    eventHandler_8(this, gEventArgs);
                    if (gEventArgs.SavedText != null)
                    {
                        text3 = gEventArgs.SavedText;
                    }
                }
                streamWriter.Write(text3);
                if (i < Count - 1)
                {
                    streamWriter.Write(SaveEOL);
                }
                streamWriter.Flush();
            }
        }
        for (int j = 0; j < Count; j++)
        {
            list_0[j] = null;
        }
        streamReader.Dispose();
        fileStream_0.Dispose();
        if (File.Exists(string_1))
        {
            File.Delete(string_1);
        }
        File.Move(text, string_1);
        list_1 = list;
        fileStream_0 = new FileStream(string_1, FileMode.Open);
        encoding_0 = encoding_1;
    }

    private string method_5(StreamReader streamReader_0, int int_1)
    {
        int num = list_1[int_1];
        if (num < 0)
        {
            return "";
        }
        fileStream_0.Seek(num, SeekOrigin.Begin);
        streamReader_0.DiscardBufferedData();
        return streamReader_0.ReadLine();
    }

    public override void vmethod_0()
    {
        foreach (GClass80 item in list_0)
        {
            if (item != null)
            {
                item.IsChanged = false;
            }
        }
    }

    private void method_6(int int_1)
    {
        GClass80 gClass = vmethod_1();
        fileStream_0.Seek(list_1[int_1], SeekOrigin.Begin);
        string text = new StreamReader(fileStream_0, encoding_0).ReadLine() ?? "";
        if (eventHandler_7 != null)
        {
            GEventArgs12 gEventArgs = new(text, int_1);
            eventHandler_7(this, gEventArgs);
            text = gEventArgs.DisplayedLineText;
            if (text == null)
            {
                return;
            }
        }
        string text2 = text;
        foreach (char char_ in text2)
        {
            gClass.Add(new GStruct8(char_));
        }
        list_0[int_1] = gClass;
        if (base.FastColoredTextBox_0.Boolean_11)
        {
            vmethod_16(new GEventArgs14(int_1, int_1));
        }
    }

    public override void vmethod_7(int int_1, GClass80 gclass80_0)
    {
        list_1.Insert(int_1, -1);
        base.vmethod_7(int_1, gclass80_0);
    }

    public override void vmethod_12(int int_1, int int_2)
    {
        list_1.RemoveRange(int_1, int_2);
        base.vmethod_12(int_1, int_2);
    }

    public override void Clear()
    {
        base.Clear();
    }

    public override int vmethod_19(int int_1)
    {
        if (list_0[int_1] == null)
        {
            return 0;
        }
        return list_0[int_1].Count;
    }

    public override bool vmethod_20(int int_1)
    {
        if (list_0[int_1] == null)
        {
            return false;
        }
        return !string.IsNullOrEmpty(list_0[int_1].FoldingStartMarker);
    }

    public override bool vmethod_21(int int_1)
    {
        if (list_0[int_1] == null)
        {
            return false;
        }
        return !string.IsNullOrEmpty(list_0[int_1].FoldingEndMarker);
    }

    public void Dispose()
    {
        fileStream_0?.Dispose();
        timer_0.Dispose();
    }

    internal void method_7(int int_1)
    {
        if (list_0[int_1] != null && !list_0[int_1].IsChanged)
        {
            list_0[int_1] = null;
        }
    }
}
