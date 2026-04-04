using System.Collections.Generic;

namespace VaultEditor;

public sealed class GClass57 : GClass56
{
    protected FastColoredTextBox fastColoredTextBox_0;

    protected List<GClass58> list_0 = [];

    protected int int_0;

    public override int Count => list_0.Count;

    public override bool IsReadOnly => false;

    public GClass57(FastColoredTextBox fastColoredTextBox_1)
    {
        fastColoredTextBox_0 = fastColoredTextBox_1;
        fastColoredTextBox_1.Event_16 += vmethod_3;
        fastColoredTextBox_1.Event_17 += vmethod_2;
    }

    protected void vmethod_2(object sender, GEventArgs4 e)
    {
        for (int i = 0; i < Count; i++)
        {
            if (list_0[i].LineIndex < e.Index)
            {
                continue;
            }
            if (list_0[i].LineIndex >= e.Index + e.Count)
            {
                list_0[i].LineIndex = list_0[i].LineIndex - e.Count;
                continue;
            }
            bool flag = e.Index <= 0;
            foreach (GClass58 item in list_0)
            {
                if (item.LineIndex == e.Index - 1)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                list_0.RemoveAt(i);
                i--;
            }
            else
            {
                list_0[i].LineIndex = e.Index - 1;
            }
        }
    }

    protected void vmethod_3(object sender, GEventArgs3 e)
    {
        for (int i = 0; i < Count; i++)
        {
            if (list_0[i].LineIndex >= e.Index)
            {
                list_0[i].LineIndex = list_0[i].LineIndex + e.Count;
            }
            else if (list_0[i].LineIndex == e.Index - 1 && e.Count == 1 && fastColoredTextBox_0[e.Index - 1].Int32_0 == fastColoredTextBox_0[e.Index - 1].Count)
            {
                list_0[i].LineIndex = list_0[i].LineIndex + e.Count;
            }
        }
    }

    public override void Dispose()
    {
        fastColoredTextBox_0.Event_16 -= vmethod_3;
        fastColoredTextBox_0.Event_17 -= vmethod_2;
    }

    public override IEnumerator<GClass58> GetEnumerator()
    {
        foreach (GClass58 item in list_0)
        {
            yield return item;
        }
    }

    public override void vmethod_0(int int_1, string string_0)
    {
        Add(new GClass58(fastColoredTextBox_0, string_0 ?? ("Bookmark " + int_0), int_1));
    }

    public override void Add(int lineIndex)
    {
        Add(new GClass58(fastColoredTextBox_0, "Bookmark " + int_0, lineIndex));
    }

    public override void Clear()
    {
        list_0.Clear();
        int_0 = 0;
    }

    public override void Add(GClass58 bookmark)
    {
        foreach (GClass58 item in list_0)
        {
            if (item.LineIndex == bookmark.LineIndex)
            {
                return;
            }
        }
        list_0.Add(bookmark);
        int_0++;
        fastColoredTextBox_0.method_4();
    }

    public override bool Contains(GClass58 item)
    {
        return list_0.Contains(item);
    }

    public override bool Contains(int lineIndex)
    {
        foreach (GClass58 item in list_0)
        {
            if (item.LineIndex == lineIndex)
            {
                return true;
            }
        }
        return false;
    }

    public override void CopyTo(GClass58[] array, int arrayIndex)
    {
        list_0.CopyTo(array, arrayIndex);
    }

    public override bool Remove(GClass58 item)
    {
        fastColoredTextBox_0.method_4();
        return list_0.Remove(item);
    }

    public override bool Remove(int lineIndex)
    {
        bool result = false;
        for (int i = 0; i < Count; i++)
        {
            if (list_0[i].LineIndex == lineIndex)
            {
                list_0.RemoveAt(i);
                i--;
                result = true;
            }
        }
        fastColoredTextBox_0.method_4();
        return result;
    }

    public override GClass58 vmethod_1(int int_1)
    {
        return list_0[int_1];
    }
}
