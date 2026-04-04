using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass519 : GInterface5, GInterface6
{
    [CompilerGenerated]
    private sealed class Class231
    {
        public Func<string, bool> func_0;

        internal bool method_0(GClass496 gclass496_0)
        {
            return func_0(gclass496_0.ToString());
        }
    }

    private byte byte_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private List<GClass496> list_0;

    [CompilerGenerated]
    private uint uint_1;

    public uint Pointer
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        private set
        {
            uint_0 = value;
        }
    }

    [GAttribute1("Data", DataType = GEnum20.const_5)]
    public List<GClass496> Items
    {
        [CompilerGenerated]
        get
        {
            return list_0;
        }
        [CompilerGenerated]
        private set
        {
            list_0 = value;
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

    public byte Byte_0
    {
        get
        {
            return (byte)Items.Count;
        }
        set
        {
            byte_0 = value;
        }
    }

    [SpecialName]
    public bool imethod_3()
    {
        return Items != null;
    }

    [SpecialName]
    public bool imethod_2()
    {
        return false;
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
        OffsetDest = (uint)binaryReader_0.BaseStream.Position;
        for (byte b = 0; b < byte_0; b++)
        {
            GClass496 gClass = new();
            gClass.method_1(binaryReader_0);
            Items.Add(gClass);
        }
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        foreach (GClass496 item in Items)
        {
            item.method_2(binaryWriter_0);
        }
    }

    public GInterface5 imethod_6()
    {
        GClass519 gClass = new()
        {
            Pointer = Pointer,
            OffsetDest = OffsetDest,
            Items = []
        };
        foreach (GClass496 item2 in Items)
        {
            GClass496 item = item2.method_3();
            gClass.Items.Add(item);
        }
        return gClass;
    }

    public bool imethod_7(Func<string, bool> func_0)
    {
        return Items.Any(gclass496_0 => func_0(gclass496_0.ToString()));
    }

    public override string ToString()
    {
        return this.smethod_0();
    }
}
