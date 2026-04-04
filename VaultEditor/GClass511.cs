using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass511 : GInterface5, GInterface6
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    public uint Value1
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        set
        {
            uint_0 = value;
        }
    }

    public uint Value2
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

    public uint Pointer
    {
        [CompilerGenerated]
        get
        {
            return uint_2;
        }
        [CompilerGenerated]
        protected set
        {
            uint_2 = value;
        }
    }

    public uint OffsetDest
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        private set
        {
            uint_3 = value;
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
        Value1 = binaryReader_0.ReadUInt32();
        Value2 = binaryReader_0.ReadUInt32();
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
    }

    public GInterface5 imethod_6()
    {
        return new GClass511
        {
            Pointer = Pointer,
            OffsetDest = OffsetDest,
            Value1 = Value1,
            Value2 = Value2
        };
    }

    public bool imethod_7(Func<string, bool> func_0)
    {
        return false;
    }

    public override string ToString()
    {
        return this.smethod_0();
    }
}
