using System;
using System.Collections;
using System.Collections.Generic;

namespace VaultEditor;

public sealed class GClass81(IList<GClass80> ilist_1) : IList<string>, ICollection<string>, IEnumerable<string>, IEnumerable
{
    private readonly IList<GClass80> ilist_0 = ilist_1;

    public string this[int index]
    {
        get
        {
            return ilist_0[index].vmethod_0();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    public int Count => ilist_0.Count;

    public bool IsReadOnly => true;

    public int IndexOf(string item)
    {
        int num = 0;
        while (true)
        {
            if (num < ilist_0.Count)
            {
                if (ilist_0[num].vmethod_0() == item)
                {
                    break;
                }
                num++;
                continue;
            }
            return -1;
        }
        return num;
    }

    public void Insert(int index, string item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public void Add(string item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(string item)
    {
        int num = 0;
        while (true)
        {
            if (num < ilist_0.Count)
            {
                if (ilist_0[num].vmethod_0() == item)
                {
                    break;
                }
                num++;
                continue;
            }
            return false;
        }
        return true;
    }

    public void CopyTo(string[] array, int arrayIndex)
    {
        for (int i = 0; i < ilist_0.Count; i++)
        {
            array[i + arrayIndex] = ilist_0[i].vmethod_0();
        }
    }

    public bool Remove(string item)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<string> GetEnumerator()
    {
        for (int i = 0; i < ilist_0.Count; i++)
        {
            yield return ilist_0[i].vmethod_0();
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
