using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass522 : GInterface5, GInterface6
{
    [CompilerGenerated]
    private sealed class Class232
    {
        public Func<string, bool> func_0;

        internal bool method_0(GClass497 gclass497_0)
        {
            return func_0(gclass497_0.ToString());
        }
    }

    [CompilerGenerated]
    private List<GClass497> list_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private byte byte_0;

    [GAttribute1("Package", DataType = GEnum20.const_5)]
    public List<GClass497> Items
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
        private set
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

    public byte PackageLength
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    [SpecialName]
    public bool imethod_3()
    {
        return true;
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
        OffsetDest = (uint)binaryReader_0.BaseStream.Position;
        Items = [];
        for (byte b = 0; b < PackageLength; b++)
        {
            GClass497 gClass = new();
            gClass.method_1(binaryReader_0);
            Items.Add(gClass);
        }
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        foreach (GClass497 item in Items)
        {
            item.method_2(binaryWriter_0);
        }
    }

    public GInterface5 imethod_6()
    {
        GClass522 gClass = new()
        {
            Pointer = Pointer,
            OffsetDest = OffsetDest,
            PackageLength = PackageLength,
            Items = []
        };
        foreach (GClass497 item2 in Items)
        {
            GClass497 item = item2.method_3();
            gClass.Items.Add(item);
        }
        return gClass;
    }

    public bool imethod_7(Func<string, bool> func_0)
    {
        return Items.Any(gclass497_0 => func_0(gclass497_0.ToString()));
    }

    public override string ToString()
    {
        return this.smethod_0();
    }
}
