using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass512 : GInterface5, GInterface6
{
    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private byte[] byte_0;

    public int Size
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

    [SpecialName]
    public bool imethod_3()
    {
        return true;
    }

    [SpecialName]
    public bool imethod_2()
    {
        return true;
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Size = binaryReader_0.ReadInt32();
        Pointer = binaryReader_0.smethod_10(0u);
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Size);
        Pointer = binaryWriter_0.smethod_11();
    }

    public void imethod_4(BinaryReader binaryReader_0)
    {
        Data = binaryReader_0.ReadBytes(Size);
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        binaryWriter_0.Write(Data);
    }

    public GInterface5 imethod_6()
    {
        return new GClass512
        {
            Size = Size,
            Pointer = Pointer,
            OffsetDest = OffsetDest,
            Data = Data
        };
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
