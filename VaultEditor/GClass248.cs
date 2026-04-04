using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass248 : GClass154
{
    private readonly GClass522 gclass522_0;

    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [CompilerGenerated]
    private float float_3;

    [CompilerGenerated]
    private float float_4;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("Packages")]
    public GInterface5 Packages
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

    [GAttribute1("Cost")]
    public float Cost
    {
        [CompilerGenerated]
        get
        {
            return float_0;
        }
        [CompilerGenerated]
        set
        {
            float_0 = value;
        }
    }

    [GAttribute1("Tier1Cost")]
    public float Tier1Cost
    {
        [CompilerGenerated]
        get
        {
            return float_1;
        }
        [CompilerGenerated]
        set
        {
            float_1 = value;
        }
    }

    [GAttribute1("Tier2Cost")]
    public float Tier2Cost
    {
        [CompilerGenerated]
        get
        {
            return float_2;
        }
        [CompilerGenerated]
        set
        {
            float_2 = value;
        }
    }

    [GAttribute1("Tier3Cost")]
    public float Tier3Cost
    {
        [CompilerGenerated]
        get
        {
            return float_3;
        }
        [CompilerGenerated]
        set
        {
            float_3 = value;
        }
    }

    [GAttribute1("Tier4Cost")]
    public float Tier4Cost
    {
        [CompilerGenerated]
        get
        {
            return float_4;
        }
        [CompilerGenerated]
        set
        {
            float_4 = value;
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

    public GClass248()
    {
        gclass522_0 = new GClass522();
        Packages = gclass522_0;
        OfferID = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Packages.imethod_0(binaryReader_0);
        Cost = binaryReader_0.ReadSingle();
        Tier1Cost = binaryReader_0.ReadSingle();
        Tier2Cost = binaryReader_0.ReadSingle();
        Tier3Cost = binaryReader_0.ReadSingle();
        Tier4Cost = binaryReader_0.ReadSingle();
        OfferID.imethod_0(binaryReader_0);
        gclass522_0.PackageLength = binaryReader_0.ReadByte();
        binaryReader_0.ReadBytes(3);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        Packages.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(Cost);
        binaryWriter_0.Write(Tier1Cost);
        binaryWriter_0.Write(Tier2Cost);
        binaryWriter_0.Write(Tier3Cost);
        binaryWriter_0.Write(Tier4Cost);
        OfferID.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(gclass522_0.PackageLength);
        binaryWriter_0.Write((byte)0);
        binaryWriter_0.Write((byte)0);
        binaryWriter_0.Write((byte)0);
    }
}
