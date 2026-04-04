using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass303 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("Class", DataType = GEnum20.const_3)]
    public uint Class
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

    [GAttribute1("Collection", DataType = GEnum20.const_3)]
    public uint Collection
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Class = binaryReader_0.ReadUInt32();
        Collection = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
    }

    public override string ToString()
    {
        return GClass486.smethod_5(Class) + " -> " + GClass486.smethod_5(Collection);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Class);
        binaryWriter_0.Write(Collection);
        binaryWriter_0.Write(0);
    }
}
