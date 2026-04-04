using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass517 : GInterface5, GInterface6
{
    [CompilerGenerated]
    private sealed class Class229
    {
        public Func<string, bool> func_0;

        internal bool method_0(GClass494 gclass494_0)
        {
            return func_0(gclass494_0.ToString());
        }
    }

    [CompilerGenerated]
    private List<GClass494> list_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("Array", DataType = GEnum20.const_5)]
    public List<GClass494> Items
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

    public int Count
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

    [SpecialName]
    public bool imethod_2()
    {
        return false;
    }

    [SpecialName]
    public bool imethod_3()
    {
        return Items != null;
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Pointer = binaryReader_0.smethod_10(0u);
        Count = binaryReader_0.ReadInt32();
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        Pointer = binaryWriter_0.smethod_11();
        binaryWriter_0.Write(Count);
    }

    public void imethod_4(BinaryReader binaryReader_0)
    {
        Items = [];
        for (int i = 0; i < Count; i++)
        {
            GClass494 gClass = new();
            gClass.method_1(binaryReader_0);
            Items.Add(gClass);
        }
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        foreach (GClass494 item in Items)
        {
            item.method_2(binaryWriter_0);
        }
    }

    public GInterface5 imethod_6()
    {
        GClass517 gClass = new()
        {
            Pointer = Pointer,
            OffsetDest = OffsetDest,
            Count = Count,
            Items = []
        };
        foreach (GClass494 item2 in Items)
        {
            GClass494 item = item2.method_3();
            gClass.Items.Add(item);
        }
        return gClass;
    }

    public bool imethod_7(Func<string, bool> func_0)
    {
        return Items.Any(gclass494_0 => func_0(gclass494_0.ToString()));
    }

    public override string ToString()
    {
        return this.smethod_0();
    }
}
