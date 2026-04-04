using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass235 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [GAttribute1("DeviceName")]
    public GClass499 DeviceName
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

    [GAttribute1("UpdateType")]
    public uint UpdateType
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

    [GAttribute1("LowerDZ")]
    public float LowerDZ
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

    [GAttribute1("UpperDZ")]
    public float UpperDZ
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

    public GClass235()
    {
        DeviceName = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        binaryReader_0.ReadUInt32();
        DeviceName.imethod_0(binaryReader_0);
        UpdateType = binaryReader_0.ReadUInt32();
        LowerDZ = binaryReader_0.ReadSingle();
        UpperDZ = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(GClass486.smethod_8(DeviceName.String_0));
        DeviceName.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(UpdateType);
        binaryWriter_0.Write(LowerDZ);
        binaryWriter_0.Write(UpperDZ);
    }
}
