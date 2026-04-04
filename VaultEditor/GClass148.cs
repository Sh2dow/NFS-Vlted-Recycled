using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass148 : GInterface8
{
    [CompilerGenerated]
    private short short_0;

    [CompilerGenerated]
    private GEnum17 genum17_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private GClass151 gclass151_0;

    public short TypeIndex
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

    public GEnum17 Flags2
    {
        [CompilerGenerated]
        get
        {
            return genum17_0;
        }
        [CompilerGenerated]
        set
        {
            genum17_0 = value;
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

    public uint Pointer
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

    public uint OffsetDest
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

    public GClass151 Field
    {
        [CompilerGenerated]
        get
        {
            return gclass151_0;
        }
        [CompilerGenerated]
        set
        {
            gclass151_0 = value;
        }
    }

    public bool Boolean_0
    {
        get
        {
            if (!Flags2.HasFlag(GEnum17.flag_3))
            {
                return Flags2.HasFlag(GEnum17.flag_4);
            }
            return true;
        }
    }

    public void vmethod_0(BinaryReader binaryReader_0)
    {
        NameHash = binaryReader_0.ReadUInt32();
        Pointer = binaryReader_0.smethod_10(null);
        TypeIndex = binaryReader_0.ReadInt16();
        Flags2 = (GEnum17)binaryReader_0.ReadInt16();
    }

    public void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(NameHash);
        Pointer = binaryWriter_0.smethod_11();
        binaryWriter_0.Write(TypeIndex);
        binaryWriter_0.Write((short)Flags2);
    }

    public static void smethod_0(GClass151 gclass151_1, GClass154 gclass154_0)
    {
        if (gclass151_1.Boolean_1)
        {
            gclass154_0.OptionalData = new GClass148
            {
                Field = gclass151_1,
                NameHash = gclass151_1.NameHash,
                Flags2 = gclass151_1.OptionalFlags2
            };
        }
    }
}
