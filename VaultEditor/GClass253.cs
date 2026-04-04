using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass253 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private int int_6;

    [GAttribute1("Row")]
    public int Row
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

    [GAttribute1("Lane")]
    public int Lane
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

    [GAttribute1("VehicleClassKey", DataType = GEnum20.const_3)]
    public uint VehicleClassKey
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

    [GAttribute1("VehicleCollectionKey", DataType = GEnum20.const_3)]
    public uint VehicleCollectionKey
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

    [GAttribute1("Change")]
    public int Change
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

    [GAttribute1("Unk")]
    public int Unk
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Row = binaryReader_0.ReadInt32();
        Lane = binaryReader_0.ReadInt32();
        VehicleClassKey = binaryReader_0.ReadUInt32();
        VehicleCollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadInt32();
        Change = binaryReader_0.ReadInt32();
        Unk = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Row);
        binaryWriter_0.Write(Lane);
        binaryWriter_0.Write(VehicleClassKey);
        binaryWriter_0.Write(VehicleCollectionKey);
        binaryWriter_0.Write(0u);
        binaryWriter_0.Write(Change);
        binaryWriter_0.Write(Unk);
    }
}
