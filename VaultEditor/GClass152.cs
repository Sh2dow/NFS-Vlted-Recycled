using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass152 : GInterface4, GInterface8, GInterface7
{
    public sealed class GClass153
    {
        public int int_0;

        public string string_0;
    }

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private IList<GClass153> ilist_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    public int Count
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public int Num1
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

    public int Num2
    {
        [CompilerGenerated]
        get
        {
            return int_2;
        }
        [CompilerGenerated]
        set
        {
            int_2 = value;
        }
    }

    public int Num3
    {
        [CompilerGenerated]
        get
        {
            return int_3;
        }
        [CompilerGenerated]
        set
        {
            int_3 = value;
        }
    }

    public IList<GClass153> Types
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
        [CompilerGenerated]
        set
        {
            ilist_0 = value;
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
        set
        {
            uint_1 = value;
        }
    }

    public uint Id
    {
        [CompilerGenerated]
        get
        {
            return uint_2;
        }
        [CompilerGenerated]
        set
        {
            uint_2 = value;
        }
    }

    public void imethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0)
    {
        Num1 = binaryReader_0.ReadInt32();
        Num2 = binaryReader_0.ReadInt32();
        Count = binaryReader_0.ReadInt32();
        Pointer = binaryReader_0.smethod_10(0u);
        Types = [];
        for (int i = 0; i < Count; i++)
        {
            GClass153 item = new()
            {
                int_0 = binaryReader_0.ReadInt32()
            };
            Types.Add(item);
        }
    }

    public void imethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Num1);
        binaryWriter_0.Write(Num2);
        binaryWriter_0.Write(Count);
        Pointer = binaryWriter_0.smethod_11();
        foreach (GClass153 type in Types)
        {
            binaryWriter_0.Write(type.int_0);
        }
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        binaryReader_0.smethod_0(OffsetDest);
        foreach (GClass153 type in Types)
        {
            GClass486.smethod_8(type.string_0 = GClass145.smethod_0(binaryReader_0));
        }
    }

    public void method_1(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        foreach (GClass153 type in Types)
        {
            GClass145.smethod_1(binaryWriter_0, type.string_0);
        }
    }
}
