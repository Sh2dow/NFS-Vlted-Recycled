using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass228 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private uint uint_2;

    [GAttribute1("RGB", DataType = GEnum20.const_6)]
    public int Int32_0
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

    [GAttribute1("MaterialA")]
    public uint MaterialA
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

    [GAttribute1("MaterialB")]
    public uint MaterialB
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

    [GAttribute1("Blend")]
    public float Blend
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

    [GAttribute1("SpeechColour")]
    public uint SpeechColour
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
        Int32_0 = binaryReader_0.ReadInt32();
        MaterialA = binaryReader_0.ReadUInt32();
        MaterialB = binaryReader_0.ReadUInt32();
        Blend = binaryReader_0.ReadSingle();
        SpeechColour = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Int32_0);
        binaryWriter_0.Write(MaterialA);
        binaryWriter_0.Write(MaterialB);
        binaryWriter_0.Write(Blend);
        binaryWriter_0.Write(SpeechColour);
    }
}
