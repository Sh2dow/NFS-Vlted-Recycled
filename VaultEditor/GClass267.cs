using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass267 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private float float_0;

    [GAttribute1("ClassKey", DataType = GEnum20.const_3)]
    public uint ClassKey
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

    [GAttribute1("DefinitionKey", DataType = GEnum20.const_3)]
    public uint DefinitionKey
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

    [GAttribute1("BlendingPower")]
    public float BlendingPower
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        ClassKey = binaryReader_0.ReadUInt32();
        DefinitionKey = binaryReader_0.ReadUInt32();
        BlendingPower = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(ClassKey);
        binaryWriter_0.Write(DefinitionKey);
        binaryWriter_0.Write(BlendingPower);
    }
}
