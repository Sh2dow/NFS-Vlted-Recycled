using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using TextEditor;

namespace VaultEditor;

public sealed class GClass80 : IList<GStruct8>, ICollection<GStruct8>, IEnumerable<GStruct8>, IEnumerable
{
    protected List<GStruct8> list_0;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private DateTime dateTime_0;

    [CompilerGenerated]
    private Brush brush_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    public string FoldingStartMarker
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

    public string FoldingEndMarker
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
        [CompilerGenerated]
        set
        {
            string_1 = value;
        }
    }

    public bool IsChanged
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

    public DateTime LastVisit
    {
        [CompilerGenerated]
        get
        {
            return dateTime_0;
        }
        [CompilerGenerated]
        set
        {
            dateTime_0 = value;
        }
    }

    public Brush BackgroundBrush
    {
        [CompilerGenerated]
        get
        {
            return brush_0;
        }
        [CompilerGenerated]
        set
        {
            brush_0 = value;
        }
    }

    public int UniqueId
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        private set
        {
            int_0 = value;
        }
    }

    public int AutoIndentSpacesNeededCount
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        set
        {
            int_1 = value;
        }
    }

    public GStruct8 this[int index]
    {
        get
        {
            return list_0[index];
        }
        set
        {
            list_0[index] = value;
        }
    }

    public int Count => list_0.Count;

    public bool IsReadOnly => false;

    public int Int32_0
    {
        get
        {
            int num = 0;
            for (int i = 0; i < Count && this[i].char_0 == ' '; i++)
            {
                num++;
            }
            return num;
        }
    }

    internal GClass80(int int_2)
    {
        UniqueId = int_2;
        list_0 = [];
    }

    public void method_0(StyleIndex styleIndex_0)
    {
        FoldingStartMarker = null;
        FoldingEndMarker = null;
        for (int i = 0; i < Count; i++)
        {
            GStruct8 value = this[i];
            value.styleIndex_0 &= (StyleIndex)(ushort)(~(int)styleIndex_0);
            this[i] = value;
        }
    }

    [SpecialName]
    public string vmethod_0()
    {
        StringBuilder stringBuilder = new(Count);
        using (IEnumerator<GStruct8> enumerator = GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                stringBuilder.Append(enumerator.Current.char_0);
            }
        }
        return stringBuilder.ToString();
    }

    public void method_1()
    {
        FoldingStartMarker = null;
        FoldingEndMarker = null;
    }

    public int IndexOf(GStruct8 item)
    {
        return list_0.IndexOf(item);
    }

    public void Insert(int index, GStruct8 item)
    {
        list_0.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        list_0.RemoveAt(index);
    }

    public void Add(GStruct8 item)
    {
        list_0.Add(item);
    }

    public void Clear()
    {
        list_0.Clear();
    }

    public bool Contains(GStruct8 item)
    {
        return list_0.Contains(item);
    }

    public void CopyTo(GStruct8[] array, int arrayIndex)
    {
        list_0.CopyTo(array, arrayIndex);
    }

    public bool Remove(GStruct8 item)
    {
        return list_0.Remove(item);
    }

    public IEnumerator<GStruct8> GetEnumerator()
    {
        return list_0.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list_0.GetEnumerator();
    }

    public void vmethod_1(int int_2, int int_3)
    {
        if (int_2 < Count)
        {
            list_0.RemoveRange(int_2, Math.Min(Count - int_2, int_3));
        }
    }

    public void vmethod_2()
    {
        list_0.TrimExcess();
    }

    public void vmethod_3(IEnumerable<GStruct8> ienumerable_0)
    {
        list_0.AddRange(ienumerable_0);
    }
}
