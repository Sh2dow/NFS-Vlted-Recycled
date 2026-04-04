using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass514<T> : GInterface5, GInterface6 where T : GInterface9
{
    private readonly int int_0;

    [CompilerGenerated]
    private List<T> list_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("Array")]
    public List<T> Items
    {
        [CompilerGenerated]
        get
        {
            return list_0;
        }
        [CompilerGenerated]
        set
        {
            list_0 = value;
        }
    }

    public uint Pointer
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        protected set
        {
            uint_0 = value;
        }
    }

    public uint OffsetDest
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        private set
        {
            uint_1 = value;
        }
    }

    public GClass514(int int_1)
    {
        int_0 = int_1;
        Items = [];
    }

    [SpecialName]
    public bool imethod_2()
    {
        return false;
    }

    [SpecialName]
    public bool imethod_3()
    {
        return Items.Any();
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Pointer = binaryReader_0.smethod_10(0u);
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        Pointer = binaryWriter_0.smethod_11();
    }

    public void imethod_4(BinaryReader binaryReader_0)
    {
        Items = [];
        for (int i = 0; i < int_0; i++)
        {
            T item = Activator.CreateInstance<T>();
            item.imethod_0(binaryReader_0);
            Items.Add(item);
        }
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        foreach (T item in Items)
        {
            item.imethod_1(binaryWriter_0);
        }
    }

    public GInterface5 imethod_6()
    {
        throw new NotImplementedException();
    }

    public bool imethod_7(Func<string, bool> func_0)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return this.smethod_0();
    }
}
