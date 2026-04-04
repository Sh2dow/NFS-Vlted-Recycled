using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass146
{
    [CompilerGenerated]
    private GEnum16 genum16_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [CompilerGenerated]
    private uint uint_4;

    public GEnum16 Magic
    {
        [CompilerGenerated]
        get
        {
            return genum16_0;
        }
        [CompilerGenerated]
        set
        {
            genum16_0 = value;
        }
    }

    public uint Offset
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

    public uint Size1
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

    public uint Size2
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

    public uint EndOffset
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        set
        {
            uint_3 = value;
        }
    }

    public uint HeaderOffset
    {
        [CompilerGenerated]
        get
        {
            return uint_4;
        }
        [CompilerGenerated]
        set
        {
            uint_4 = value;
        }
    }

    public override string ToString()
    {
        return $"{Magic}, {Offset}, {Size1}, {Size2}, {EndOffset}";
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        Magic = (GEnum16)binaryReader_0.ReadUInt32();
        Offset = binaryReader_0.ReadUInt32();
        Size1 = binaryReader_0.ReadUInt32();
        Size2 = binaryReader_0.ReadUInt32();
        EndOffset = binaryReader_0.ReadUInt32();
    }

    public void method_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write((uint)Magic);
        binaryWriter_0.Write(Offset);
        binaryWriter_0.Write(Size1);
        binaryWriter_0.Write(Size2);
        binaryWriter_0.Write(EndOffset);
    }
}
