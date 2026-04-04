using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass497 : GClass492
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("Package")]
    public uint Package
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

    [GAttribute1("Level")]
    public uint Level
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
        Package = binaryReader_0.ReadUInt32();
        Level = binaryReader_0.ReadUInt32();
    }

    public void method_2(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Package);
        binaryWriter_0.Write(Level);
    }

    public GClass497 method_3()
    {
        return new GClass497
        {
            Package = Package,
            Level = Level
        };
    }
}
