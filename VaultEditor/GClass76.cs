using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GClass76 : ICollection<GClass77>, IEnumerable<GClass77>, IEnumerable, IDisposable
{
    private readonly FastColoredTextBox fastColoredTextBox_0;

    private readonly List<GClass77> list_0 = [];

    public int Count => list_0.Count;

    public bool IsReadOnly => false;

    public GClass76(FastColoredTextBox fastColoredTextBox_1)
    {
        fastColoredTextBox_0 = fastColoredTextBox_1;
        fastColoredTextBox_1.Event_2 += vmethod_1;
        fastColoredTextBox_1.KeyDown += vmethod_0;
        fastColoredTextBox_1.Event_7 += method_0;
    }

    protected void vmethod_0(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
        {
            Clear();
        }
    }

    protected void vmethod_1(object sender, GEventArgs5 e)
    {
        Clear();
    }

    public void Dispose()
    {
        fastColoredTextBox_0.Event_2 -= vmethod_1;
        fastColoredTextBox_0.KeyDown -= vmethod_0;
        fastColoredTextBox_0.Event_7 -= method_0;
    }

    private void method_0(object sender, EventArgs e)
    {
        if (list_0.Count == 0)
        {
            return;
        }
        fastColoredTextBox_0.method_11(bool_37: true);
        foreach (GClass77 item in list_0)
        {
            method_1(item);
            item.HostPanel.Invalidate();
        }
    }

    private void method_1(GClass77 gclass77_0)
    {
        if (gclass77_0.Inline)
        {
            if (gclass77_0.Range.GStruct10_0.int_1 < fastColoredTextBox_0.list_0.Count - 1)
            {
                gclass77_0.HostPanel.Top = fastColoredTextBox_0.list_0[gclass77_0.Range.GStruct10_0.int_1 + 1].int_0 - gclass77_0.TopPadding - gclass77_0.HostPanel.Height - fastColoredTextBox_0.VerticalScroll.Value;
            }
            else
            {
                gclass77_0.HostPanel.Top = fastColoredTextBox_0.int_8 + fastColoredTextBox_0.Paddings.Top - gclass77_0.HostPanel.Height - fastColoredTextBox_0.VerticalScroll.Value;
            }
        }
        else
        {
            if (gclass77_0.Range.GStruct10_0.int_1 > fastColoredTextBox_0.Int32_9 - 1)
            {
                return;
            }
            if (gclass77_0.Range.GStruct10_0.int_1 == fastColoredTextBox_0.Int32_9 - 1)
            {
                int num = fastColoredTextBox_0.list_0[gclass77_0.Range.GStruct10_0.int_1].int_0 - fastColoredTextBox_0.VerticalScroll.Value + fastColoredTextBox_0.Int32_1;
                if (num + gclass77_0.HostPanel.Height + 1 > fastColoredTextBox_0.ClientRectangle.Bottom)
                {
                    gclass77_0.HostPanel.Top = Math.Max(0, fastColoredTextBox_0.list_0[gclass77_0.Range.GStruct10_0.int_1].int_0 - fastColoredTextBox_0.VerticalScroll.Value - gclass77_0.HostPanel.Height);
                }
                else
                {
                    gclass77_0.HostPanel.Top = num;
                }
            }
            else
            {
                gclass77_0.HostPanel.Top = fastColoredTextBox_0.list_0[gclass77_0.Range.GStruct10_0.int_1 + 1].int_0 - fastColoredTextBox_0.VerticalScroll.Value;
                if (gclass77_0.HostPanel.Bottom > fastColoredTextBox_0.ClientRectangle.Bottom)
                {
                    gclass77_0.HostPanel.Top = fastColoredTextBox_0.list_0[gclass77_0.Range.GStruct10_0.int_1 + 1].int_0 - fastColoredTextBox_0.Int32_1 - gclass77_0.TopPadding - gclass77_0.HostPanel.Height - fastColoredTextBox_0.VerticalScroll.Value;
                }
            }
        }
        if (gclass77_0.Dock == DockStyle.Fill)
        {
            gclass77_0.Int32_0 = fastColoredTextBox_0.ClientSize.Width - fastColoredTextBox_0.LeftIndent - 2;
            gclass77_0.HostPanel.Left = fastColoredTextBox_0.LeftIndent;
            return;
        }
        Point point = fastColoredTextBox_0.method_94(gclass77_0.Range.GStruct10_0);
        Point point2 = fastColoredTextBox_0.method_94(gclass77_0.Range.GStruct10_1);
        int num2 = (point.X + point2.X) / 2 - gclass77_0.HostPanel.Width / 2;
        gclass77_0.HostPanel.Left = Math.Max(fastColoredTextBox_0.LeftIndent, num2);
        if (gclass77_0.HostPanel.Right > fastColoredTextBox_0.ClientSize.Width)
        {
            gclass77_0.HostPanel.Left = Math.Max(fastColoredTextBox_0.LeftIndent, num2 - (gclass77_0.HostPanel.Right - fastColoredTextBox_0.ClientSize.Width));
        }
    }

    public IEnumerator<GClass77> GetEnumerator()
    {
        foreach (GClass77 item in list_0)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Clear()
    {
        list_0.Clear();
        if (fastColoredTextBox_0.Controls.Count == 0)
        {
            return;
        }
        List<Control> list = [];
        foreach (Control control in fastColoredTextBox_0.Controls)
        {
            if (control is GControl3)
            {
                list.Add(control);
            }
        }
        foreach (Control item in list)
        {
            fastColoredTextBox_0.Controls.Remove(item);
        }
        for (int i = 0; i < fastColoredTextBox_0.list_0.Count; i++)
        {
            GStruct9 value = fastColoredTextBox_0.list_0[i];
            value.int_1 = 0;
            fastColoredTextBox_0.list_0[i] = value;
        }
        fastColoredTextBox_0.method_10();
        fastColoredTextBox_0.method_4();
        fastColoredTextBox_0.Select();
        fastColoredTextBox_0.ActiveControl = null;
    }

    public void Add(GClass77 hint)
    {
        list_0.Add(hint);
        if (hint.Inline)
        {
            GStruct9 value = fastColoredTextBox_0.list_0[hint.Range.GStruct10_0.int_1];
            hint.TopPadding = value.int_1;
            value.int_1 += hint.HostPanel.Height;
            fastColoredTextBox_0.list_0[hint.Range.GStruct10_0.int_1] = value;
            fastColoredTextBox_0.method_11(bool_37: true);
        }
        method_1(hint);
        fastColoredTextBox_0.vmethod_4();
        hint.HostPanel.Parent = fastColoredTextBox_0;
        fastColoredTextBox_0.Select();
        fastColoredTextBox_0.ActiveControl = null;
        fastColoredTextBox_0.method_4();
    }

    public void method_2(IList<GClass77> ilist_0)
    {
        list_0.AddRange(ilist_0);
        foreach (GClass77 item in ilist_0)
        {
            if (item.Inline)
            {
                GStruct9 value = fastColoredTextBox_0.list_0[item.Range.GStruct10_0.int_1];
                item.TopPadding = value.int_1;
                value.int_1 += item.HostPanel.Height;
                fastColoredTextBox_0.list_0[item.Range.GStruct10_0.int_1] = value;
                fastColoredTextBox_0.method_11(bool_37: true);
            }
            method_1(item);
            item.HostPanel.Parent = fastColoredTextBox_0;
        }
        fastColoredTextBox_0.vmethod_4();
        fastColoredTextBox_0.Select();
        fastColoredTextBox_0.ActiveControl = null;
        fastColoredTextBox_0.method_4();
    }

    public bool Contains(GClass77 item)
    {
        return list_0.Contains(item);
    }

    public void CopyTo(GClass77[] array, int arrayIndex)
    {
        list_0.CopyTo(array, arrayIndex);
    }

    public bool Remove(GClass77 item)
    {
        throw new NotImplementedException();
    }
}
