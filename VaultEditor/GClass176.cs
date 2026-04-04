using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass176 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private int int_6;

    [CompilerGenerated]
    private int int_7;

    [CompilerGenerated]
    private byte byte_0;

    [CompilerGenerated]
    private byte byte_1;

    [CompilerGenerated]
    private byte byte_2;

    [CompilerGenerated]
    private byte byte_3;

    [CompilerGenerated]
    private byte byte_4;

    [CompilerGenerated]
    private uint uint_3;

    [CompilerGenerated]
    private uint uint_4;

    [CompilerGenerated]
    private uint uint_5;

    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private int int_8;

    [GAttribute1("HAL_ID", DataType = GEnum20.const_1)]
    public uint HAL_ID
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

    [GAttribute1("CF_HAL_ID", DataType = GEnum20.const_1)]
    public uint CF_HAL_ID
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

    [GAttribute1("Price")]
    public int Price
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

    [GAttribute1("ShowroomUnlock")]
    public uint ShowroomUnlock
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

    [GAttribute1("Tier1Price")]
    public int Tier1Price
    {
        [CompilerGenerated]
        get
        {
            return int_4;
        }
        [CompilerGenerated]
        set
        {
            int_4 = value;
        }
    }

    [GAttribute1("Tier2Price")]
    public int Tier2Price
    {
        [CompilerGenerated]
        get
        {
            return int_5;
        }
        [CompilerGenerated]
        set
        {
            int_5 = value;
        }
    }

    [GAttribute1("Tier3Price")]
    public int Tier3Price
    {
        [CompilerGenerated]
        get
        {
            return int_6;
        }
        [CompilerGenerated]
        set
        {
            int_6 = value;
        }
    }

    [GAttribute1("Tier4Price")]
    public int Tier4Price
    {
        [CompilerGenerated]
        get
        {
            return int_7;
        }
        [CompilerGenerated]
        set
        {
            int_7 = value;
        }
    }

    [GAttribute1("Tier")]
    public byte Tier
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

    [GAttribute1("Tier1ShowroomUnlock")]
    public byte Tier1ShowroomUnlock
    {
        [CompilerGenerated]
        get
        {
            return byte_1;
        }
        [CompilerGenerated]
        set
        {
            byte_1 = value;
        }
    }

    [GAttribute1("Tier2ShowroomUnlock")]
    public byte Tier2ShowroomUnlock
    {
        [CompilerGenerated]
        get
        {
            return byte_2;
        }
        [CompilerGenerated]
        set
        {
            byte_2 = value;
        }
    }

    [GAttribute1("Tier3ShowroomUnlock")]
    public byte Tier3ShowroomUnlock
    {
        [CompilerGenerated]
        get
        {
            return byte_3;
        }
        [CompilerGenerated]
        set
        {
            byte_3 = value;
        }
    }

    [GAttribute1("Tier4ShowroomUnlock")]
    public byte Tier4ShowroomUnlock
    {
        [CompilerGenerated]
        get
        {
            return byte_4;
        }
        [CompilerGenerated]
        set
        {
            byte_4 = value;
        }
    }

    [GAttribute1("BrandHALId", DataType = GEnum20.const_4)]
    public uint BrandHALId
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

    [GAttribute1("LogoTextureId", DataType = GEnum20.const_4)]
    public uint LogoTextureId
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

    [GAttribute1("DetailHash", DataType = GEnum20.const_4)]
    public uint DetailHash
    {
        [CompilerGenerated]
        get
        {
            return uint_5;
        }
        [CompilerGenerated]
        set
        {
            uint_5 = value;
        }
    }

    [GAttribute1("PartDetails")]
    public GInterface5 PartDetails
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_0;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_0 = value;
        }
    }

    [GAttribute1("OfferID")]
    public GClass499 OfferID
    {
        [CompilerGenerated]
        get
        {
            return gclass499_0;
        }
        [CompilerGenerated]
        set
        {
            gclass499_0 = value;
        }
    }

    [GAttribute1("IsOnlineLockable")]
    public int IsOnlineLockable
    {
        [CompilerGenerated]
        get
        {
            return int_8;
        }
        [CompilerGenerated]
        set
        {
            int_8 = value;
        }
    }

    public GClass176()
    {
        PartDetails = new GClass511();
        OfferID = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        HAL_ID = binaryReader_0.ReadUInt32();
        CF_HAL_ID = binaryReader_0.ReadUInt32();
        Price = binaryReader_0.ReadInt32();
        ShowroomUnlock = binaryReader_0.ReadUInt32();
        Tier1Price = binaryReader_0.ReadInt32();
        Tier2Price = binaryReader_0.ReadInt32();
        Tier3Price = binaryReader_0.ReadInt32();
        Tier4Price = binaryReader_0.ReadInt32();
        Tier = binaryReader_0.ReadByte();
        Tier1ShowroomUnlock = binaryReader_0.ReadByte();
        Tier2ShowroomUnlock = binaryReader_0.ReadByte();
        Tier3ShowroomUnlock = binaryReader_0.ReadByte();
        Tier4ShowroomUnlock = binaryReader_0.ReadByte();
        binaryReader_0.ReadBytes(3);
        BrandHALId = binaryReader_0.ReadUInt32();
        LogoTextureId = binaryReader_0.ReadUInt32();
        DetailHash = binaryReader_0.ReadUInt32();
        PartDetails.imethod_0(binaryReader_0);
        OfferID.imethod_0(binaryReader_0);
        IsOnlineLockable = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(HAL_ID);
        binaryWriter_0.Write(CF_HAL_ID);
        binaryWriter_0.Write(Price);
        binaryWriter_0.Write(ShowroomUnlock);
        binaryWriter_0.Write(Tier1Price);
        binaryWriter_0.Write(Tier2Price);
        binaryWriter_0.Write(Tier3Price);
        binaryWriter_0.Write(Tier4Price);
        binaryWriter_0.Write(Tier);
        binaryWriter_0.Write(Tier1ShowroomUnlock);
        binaryWriter_0.Write(Tier2ShowroomUnlock);
        binaryWriter_0.Write(Tier3ShowroomUnlock);
        binaryWriter_0.Write(Tier4ShowroomUnlock);
        binaryWriter_0.Write((byte)0);
        binaryWriter_0.Write((byte)0);
        binaryWriter_0.Write((byte)0);
        binaryWriter_0.Write(BrandHALId);
        binaryWriter_0.Write(LogoTextureId);
        binaryWriter_0.Write(DetailHash);
        PartDetails.imethod_1(binaryWriter_0);
        OfferID.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(IsOnlineLockable);
    }
}
