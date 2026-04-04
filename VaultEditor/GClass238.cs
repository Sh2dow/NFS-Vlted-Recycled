using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass238 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [GAttribute1("PartClass", DataType = GEnum20.const_3)]
    public uint PartClass
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

    [GAttribute1("PartCollection", DataType = GEnum20.const_3)]
    public uint PartCollection
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

    [GAttribute1("KitNumber")]
    public uint KitNumber
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        PartClass = binaryReader_0.ReadUInt32();
        PartCollection = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
        KitNumber = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(PartClass);
        binaryWriter_0.Write(PartCollection);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(KitNumber);
    }
}
