using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass164 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

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

    [GAttribute1("IsMember")]
    public uint IsMember
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

    [GAttribute1("MemberIndex")]
    public uint MemberIndex
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        set
        {
            uint_3 = value;
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
        IsMember = binaryReader_0.ReadUInt32();
        MemberIndex = binaryReader_0.ReadUInt32();
        BlendingPower = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(ClassKey);
        binaryWriter_0.Write(DefinitionKey);
        binaryWriter_0.Write(IsMember);
        binaryWriter_0.Write(MemberIndex);
        binaryWriter_0.Write(BlendingPower);
    }
}
