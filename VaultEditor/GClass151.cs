using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass151 : GInterface7
{
    [CompilerGenerated]
    private byte byte_0;

    [CompilerGenerated]
    private short short_0;

    [CompilerGenerated]
    private GEnum18 genum18_0;

    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private ushort ushort_1;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private GEnum17 genum17_0;

    public byte AlignShift
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

    public short Count
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

    public GEnum18 Flags
    {
        [CompilerGenerated]
        get
        {
            return genum18_0;
        }
        [CompilerGenerated]
        set
        {
            genum18_0 = value;
        }
    }

    public ushort Length
    {
        [CompilerGenerated]
        get
        {
            return ushort_0;
        }
        [CompilerGenerated]
        set
        {
            ushort_0 = value;
        }
    }

    public uint NameHash
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

    public ushort Offset
    {
        [CompilerGenerated]
        get
        {
            return ushort_1;
        }
        [CompilerGenerated]
        set
        {
            ushort_1 = value;
        }
    }

    public uint TypeHash
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

    public GEnum17 OptionalFlags2
    {
        [CompilerGenerated]
        get
        {
            return genum17_0;
        }
        [CompilerGenerated]
        private set
        {
            genum17_0 = value;
        }
    }

    public int Int32_0 => 1 << (AlignShift & 0x1F);

    public bool Boolean_0 => Flags.HasFlag(GEnum18.flag_1);

    public bool Boolean_1 => !Flags.HasFlag(GEnum18.flag_2);

    public void imethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0)
    {
        NameHash = binaryReader_0.ReadUInt32();
        TypeHash = binaryReader_0.ReadUInt32();
        Offset = binaryReader_0.ReadUInt16();
        Length = binaryReader_0.ReadUInt16();
        Count = binaryReader_0.ReadInt16();
        Flags = (GEnum18)binaryReader_0.ReadByte();
        AlignShift = binaryReader_0.ReadByte();
        OptionalFlags2 = method_0(genum1_0);
    }

    public void imethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(NameHash);
        binaryWriter_0.Write(TypeHash);
        binaryWriter_0.Write(Offset);
        binaryWriter_0.Write(Length);
        binaryWriter_0.Write(Count);
        binaryWriter_0.Write((byte)Flags);
        binaryWriter_0.Write(AlignShift);
    }

    public GEnum17 method_0(GEnum1 genum1_0)
    {
        if (!Boolean_1)
        {
            return GEnum17.flag_0;
        }
        if (Flags == (GEnum18.flag_3 | GEnum18.flag_6))
        {
            return GEnum17.flag_2;
        }
        if (Flags == (GEnum18.flag_1 | GEnum18.flag_3 | GEnum18.flag_6))
        {
            if (!Boolean_0)
            {
                throw new Exception();
            }
            return GEnum17.flag_1 | GEnum17.flag_2;
        }
        if (Count == 1 && Length <= 4)
        {
            if (genum1_0 == GEnum1.const_3)
            {
                return GEnum17.flag_3;
            }
            return GEnum17.flag_4;
        }
        if (Boolean_0)
        {
            return GEnum17.flag_1;
        }
        return GEnum17.flag_0;
    }
}
