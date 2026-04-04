using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass236 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("CopType")]
    public GClass499 Name
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

    [GAttribute1("Count")]
    public uint Count
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

    [GAttribute1("Chance")]
    public uint Chance
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

    public GClass236()
    {
        Name = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Name.imethod_0(binaryReader_0);
        binaryReader_0.ReadUInt32();
        Count = binaryReader_0.ReadUInt32();
        Chance = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        Name.imethod_1(binaryWriter_0);
        uint value = GClass486.smethod_8(Name.String_0);
        binaryWriter_0.Write(value);
        binaryWriter_0.Write(Count);
        binaryWriter_0.Write(Chance);
    }
}
