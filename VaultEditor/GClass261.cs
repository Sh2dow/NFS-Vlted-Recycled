using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass261 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private byte byte_0;

    [CompilerGenerated]
    private byte byte_1;

    [GAttribute1("AnimType")]
    public int AnimType
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

    [GAttribute1("FPS")]
    public byte Byte_0
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    [GAttribute1("RandomStartFrame")]
    public byte RandomStartFrame
    {
        [CompilerGenerated]
        get
        {
            return byte_1;
        }
        [CompilerGenerated]
        set
        {
            byte_1 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        AnimType = binaryReader_0.ReadInt32();
        Byte_0 = binaryReader_0.ReadByte();
        RandomStartFrame = binaryReader_0.ReadByte();
        binaryReader_0.ReadBytes(2);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(AnimType);
        binaryWriter_0.Write(Byte_0);
        binaryWriter_0.Write(RandomStartFrame);
        binaryWriter_0.Write((byte)0);
        binaryWriter_0.Write((byte)0);
    }
}
