using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass495 : GClass492
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("Region")]
    public uint Region
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

    [GAttribute1("Zone")]
    public uint Zone
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

    public void method_1(BinaryReader binaryReader_0)
    {
        Region = binaryReader_0.ReadUInt32();
        Zone = binaryReader_0.ReadUInt32();
    }

    public void method_2(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Region);
        binaryWriter_0.Write(Zone);
    }

    public GClass495 method_3()
    {
        return new GClass495
        {
            Region = Region,
            Zone = Zone
        };
    }
}
