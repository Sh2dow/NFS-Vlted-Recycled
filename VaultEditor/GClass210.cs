using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass210 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [GAttribute1("Data1")]
    public uint Value1
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

    [GAttribute1("Data2")]
    public uint Value2
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

    [GAttribute1("Sliders")]
    public GInterface5 Sliders
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

    public GClass210()
    {
        Sliders = new GClass518();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadUInt32();
        Value2 = binaryReader_0.ReadUInt32();
        Sliders.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        Sliders.imethod_1(binaryWriter_0);
    }
}
