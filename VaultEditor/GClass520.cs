using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass520(int int_2) : GInterface5, GInterface6
{
    private readonly int int_0 = int_2;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private byte[] byte_0;

    [CompilerGenerated]
    private uint uint_1;

    public int Count
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        private set
        {
            int_1 = value;
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

    [GAttribute1("Data")]
    public byte[] Data
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        private set
        {
            byte_0 = value;
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
    public bool imethod_3()
    {
        return Data != null;
    }

    [SpecialName]
    public bool imethod_2()
    {
        return false;
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
        int count = Count * int_0;
        Data = binaryReader_0.ReadBytes(count);
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        binaryWriter_0.Write(Data);
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
        return "Extra data";
    }
}
