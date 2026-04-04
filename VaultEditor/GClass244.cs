using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass244 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("Subject", DataType = GEnum20.const_3)]
    public uint Subject
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

    [GAttribute1("Text", DataType = GEnum20.const_3)]
    public uint Text
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

    [GAttribute1("Picture")]
    public GClass499 Picture
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

    public GClass244()
    {
        Picture = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Subject = binaryReader_0.ReadUInt32();
        Text = binaryReader_0.ReadUInt32();
        Picture.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Subject);
        binaryWriter_0.Write(Text);
        Picture.imethod_1(binaryWriter_0);
    }
}
