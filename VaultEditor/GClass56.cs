using System;
using System.Collections;
using System.Collections.Generic;

namespace VaultEditor;

public abstract class GClass56 : ICollection<GClass58>, IEnumerable<GClass58>, IEnumerable, IDisposable
{
    public abstract int Count { get; }

    public abstract bool IsReadOnly { get; }

    public abstract void Add(GClass58 item);

    public abstract void Clear();

    public abstract bool Contains(GClass58 item);

    public abstract void CopyTo(GClass58[] array, int arrayIndex);

    public abstract bool Remove(GClass58 item);

    public abstract IEnumerator<GClass58> GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public abstract void Dispose();

    public abstract void vmethod_0(int int_0, string string_0);

    public abstract void Add(int lineIndex);

    public abstract bool Contains(int lineIndex);

    public abstract bool Remove(int lineIndex);

    public abstract GClass58 vmethod_1(int int_0);
}
