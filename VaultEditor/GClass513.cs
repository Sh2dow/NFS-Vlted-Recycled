using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass513 : GInterface5, GInterface6
{
    private GClass482 gclass482_0;

    [CompilerGenerated]
    private byte[] byte_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("Blob", DataType = GEnum20.const_5)]
    public byte[] Blob
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

    public int Length
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
        return Blob != null;
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Length = binaryReader_0.ReadInt32();
        Pointer = binaryReader_0.smethod_10(0u);
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Length);
        Pointer = binaryWriter_0.smethod_11();
    }

    public void imethod_4(BinaryReader binaryReader_0)
    {
        gclass482_0 = new GClass482();
        gclass482_0.method_0(binaryReader_0);
        int blockSize = gclass482_0.BlockSize;
        Blob = binaryReader_0.ReadBytes(blockSize);
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        gclass482_0.method_1(binaryWriter_0);
        binaryWriter_0.Write(Blob);
    }

    public GInterface5 imethod_6()
    {
        GClass513 gClass = new()
        {
            Pointer = Pointer,
            OffsetDest = OffsetDest,
            Blob = new byte[Blob.Length]
        };
        Array.Copy(Blob, gClass.Blob, Blob.Length);
        return gClass;
    }

    public bool imethod_7(Func<string, bool> func_0)
    {
        return func_0(Blob?.smethod_1());
    }

    public override string ToString()
    {
        byte[] blob = Blob;
        object obj;
        if (blob == null)
        {
            obj = null;
        }
        else
        {
            obj = blob.smethod_1();
            if (obj != null)
            {
                goto IL_001b;
            }
        }
        obj = string.Empty;
        goto IL_001b;
    IL_001b:
        return (string)obj;
    }
}
