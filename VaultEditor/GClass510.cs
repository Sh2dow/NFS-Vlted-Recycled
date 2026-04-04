using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass510
{
    public enum GEnum21
    {
        const_0,
        const_1,
        const_2,
        const_3
    }

    [CompilerGenerated]
    private GEnum21 genum21_0;

    [CompilerGenerated]
    private short short_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private bool bool_0;

    public GEnum21 Type
    {
        [CompilerGenerated]
        get
        {
            return genum21_0;
        }
        [CompilerGenerated]
        set
        {
            genum21_0 = value;
        }
    }

    public short Identifier
    {
        [CompilerGenerated]
        get
        {
            return short_0;
        }
        [CompilerGenerated]
        set
        {
            short_0 = value;
        }
    }

    public uint OffsetDest
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

    public uint OffsetSource
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

    public bool Vlt
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public void vmethod_0(BinaryReader binaryReader_0)
    {
        OffsetSource = binaryReader_0.ReadUInt32();
        Type = (GEnum21)binaryReader_0.ReadInt16();
        Identifier = binaryReader_0.ReadInt16();
        OffsetDest = binaryReader_0.ReadUInt32();
        Type.smethod_0();
    }

    public void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(OffsetSource);
        binaryWriter_0.Write((short)Type);
        binaryWriter_0.Write(Identifier);
        binaryWriter_0.Write(OffsetDest);
    }
}
