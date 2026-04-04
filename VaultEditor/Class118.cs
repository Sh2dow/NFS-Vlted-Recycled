using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace VaultEditor;

internal sealed class Class118
{
    public delegate void Delegate0(string lineText);

    public delegate void Delegate1(int start, int end);

    private readonly FastColoredTextBox fastColoredTextBox_0;

    private readonly Regex regex_0;

    private readonly GClass86 gclass86_0;

    private readonly GClass86 gclass86_1;

    private readonly GClass86 gclass86_2;

    [CompilerGenerated]
    private Delegate0 delegate0_0;

    [CompilerGenerated]
    private Delegate1 delegate1_0;

    public event Delegate0 Event_0
    {
        [CompilerGenerated]
        add
        {
            Delegate0 @delegate = delegate0_0;
            Delegate0 delegate2;
            do
            {
                delegate2 = @delegate;
                Delegate0 value2 = (Delegate0)Delegate.Combine(delegate2, value);
                @delegate = Interlocked.CompareExchange(ref delegate0_0, value2, delegate2);
            }
            while ((object)@delegate != delegate2);
        }
        [CompilerGenerated]
        remove
        {
            Delegate0 @delegate = delegate0_0;
            Delegate0 delegate2;
            do
            {
                delegate2 = @delegate;
                Delegate0 value2 = (Delegate0)Delegate.Remove(delegate2, value);
                @delegate = Interlocked.CompareExchange(ref delegate0_0, value2, delegate2);
            }
            while ((object)@delegate != delegate2);
        }
    }

    public event Delegate1 Event_1
    {
        [CompilerGenerated]
        add
        {
            Delegate1 @delegate = delegate1_0;
            Delegate1 delegate2;
            do
            {
                delegate2 = @delegate;
                Delegate1 value2 = (Delegate1)Delegate.Combine(delegate2, value);
                @delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
            }
            while ((object)@delegate != delegate2);
        }
        [CompilerGenerated]
        remove
        {
            Delegate1 @delegate = delegate1_0;
            Delegate1 delegate2;
            do
            {
                delegate2 = @delegate;
                Delegate1 value2 = (Delegate1)Delegate.Remove(delegate2, value);
                @delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
            }
            while ((object)@delegate != delegate2);
        }
    }

    public Class118(FastColoredTextBox fastColoredTextBox_1)
    {
        if (Class187.DarkTheme)
        {
            gclass86_0 = new GClass86(Brushes.Orange, null, FontStyle.Bold);
            gclass86_1 = new GClass86(Brushes.MediumSeaGreen, null, FontStyle.Regular);
            gclass86_2 = new GClass86(Brushes.IndianRed, null, FontStyle.Bold);
        }
        else
        {
            gclass86_0 = new GClass86(Brushes.Brown, null, FontStyle.Bold);
            gclass86_1 = new GClass86(Brushes.Green, null, FontStyle.Regular);
            gclass86_2 = new GClass86(Brushes.Red, null, FontStyle.Bold);
        }
        fastColoredTextBox_0 = fastColoredTextBox_1;
        fastColoredTextBox_0.Event_2 += method_1;
        fastColoredTextBox_0.Event_6 += method_0;
        fastColoredTextBox_0.Color_1 = (Class187.DarkTheme ? Color.FloralWhite : Color.Black);
        string text = string.Join("|", GClass541.String_0);
        regex_0 = new Regex("^\\s*(?<c>" + text + ")", RegexOptions.Multiline);
    }

    private void method_0(object sender, EventArgs e)
    {
        int int32_ = fastColoredTextBox_0.GClass84_5.Int32_5;
        if (int32_ >= 0)
        {
            string lineText = fastColoredTextBox_0.method_99(int32_);
            delegate0_0?.Invoke(lineText);
        }
    }

    private void method_1(object sender, GEventArgs5 e)
    {
        e.ChangedRange.method_34(gclass86_1, gclass86_0, gclass86_2);
        e.ChangedRange.method_21(gclass86_1, "#.*$", RegexOptions.Multiline);
        e.ChangedRange.method_21(gclass86_2, "!!!.*$", RegexOptions.Multiline);
        e.ChangedRange.method_20(gclass86_0, regex_0);
    }

    public void method_2(string string_0)
    {
        if (!string.IsNullOrEmpty(fastColoredTextBox_0.Text) && !fastColoredTextBox_0.Text.EndsWith(Environment.NewLine))
        {
            string_0 = Environment.NewLine + string_0;
        }
        fastColoredTextBox_0.method_27();
        fastColoredTextBox_0.vmethod_25(string_0);
    }

    public string method_3()
    {
        return fastColoredTextBox_0.Text;
    }

    public void method_4()
    {
        File.WriteAllText(Class121.String_0, method_3());
    }

    public void method_5()
    {
        string string_ = Class121.String_0;
        if (File.Exists(string_))
        {
            fastColoredTextBox_0.Text = File.ReadAllText(string_);
        }
    }

    public void method_6()
    {
        fastColoredTextBox_0.vmethod_19();
    }

    public void method_7(Form form_0, VaultDatabase gclass478_0, bool bool_0)
    {
        string string_;
        int num;
        if (!bool_0)
        {
            string_ = fastColoredTextBox_0.Text;
            num = 0;
        }
        else
        {
            num = fastColoredTextBox_0.GClass84_5.Int32_4;
            string_ = ((fastColoredTextBox_0.Int32_11 <= 0) ? fastColoredTextBox_0.method_99(fastColoredTextBox_0.GClass84_5.Int32_4) : fastColoredTextBox_0.String_4);
        }
        IList<GClass77> list = [];
        try
        {
            fastColoredTextBox_0.method_86();
            fastColoredTextBox_0.method_1();
            IEnumerable<string> enumerable = string_.smethod_5();
            Class234 @class = new();
            IList<Class263> list2 = [];
            int start = num + 1;
            foreach (string item in enumerable)
            {
                Class263 class2 = @class.method_1(string.Empty, item, num);
                if (class2.Boolean_0)
                {
                    list.Add(method_8(class2));
                }
                list2.Add(class2);
                num++;
            }
            foreach (Class263 item2 in list2.Where(class263_0 => class263_0.Value is Class247 || class263_0.Value is Class244))
            {
                GClass542 gClass = item2.Value.vmethod_2(gclass478_0);
                if (gClass.Boolean_0)
                {
                    delegate1_0?.Invoke(start, num);
                    fastColoredTextBox_0.method_87();
                    GClass109.smethod_1(form_0, gClass.method_0());
                    fastColoredTextBox_0.GClass76_0.method_2(list);
                    return;
                }
            }
            foreach (Class263 item3 in list2)
            {
                try
                {
                    if (item3.Value != null)
                    {
                        GClass542 gclass542_ = item3.Value.vmethod_2(gclass478_0);
                        item3.method_3(gclass542_);
                        if (item3.Boolean_0)
                        {
                            list.Add(method_8(item3));
                        }
                    }
                }
                catch (Exception ex)
                {
                    item3.method_1("Unable to execute command: " + ex.Message);
                }
            }
            delegate1_0?.Invoke(start, num);
            fastColoredTextBox_0.GClass76_0.method_2([.. list.Take(100)]);
            fastColoredTextBox_0.method_87();
        }
        catch (Exception ex2)
        {
            GClass109.smethod_1(null, "The ModScript file is either corrupted or not a supported format" + Environment.NewLine + ex2.Message);
        }
    }

    private GClass77 method_8(Class263 class263_0)
    {
        GClass77 gClass = new(new GClass84(fastColoredTextBox_0, class263_0.LineNumber), class263_0.method_0(), bool_1: true, bool_2: true);
        if (Class187.DarkTheme)
        {
            gClass.Color_2 = Color.FromArgb(200, 77, 77);
            gClass.Color_3 = Color.White;
            gClass.Color_0 = Color.FromArgb(200, 77, 77);
            gClass.Color_1 = Color.FromArgb(200, 77, 77);
        }
        else
        {
            gClass.Color_2 = Color.Red;
            gClass.Color_3 = Color.White;
            gClass.Color_0 = Color.Red;
            gClass.Color_1 = Color.Red;
        }
        return gClass;
    }

    public void method_9()
    {
        fastColoredTextBox_0.GClass76_0.Clear();
    }
}
