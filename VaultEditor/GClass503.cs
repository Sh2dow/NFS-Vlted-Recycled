using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass503 : GClass500
{
    private readonly GClass505 gclass505_0;

    [CompilerGenerated]
    private byte[] byte_0;

    public byte[] Data
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

    public GClass503()
        : base(GEnum23.const_3)
    {
    }

    public GClass503(GClass505 gclass505_1)
        : base(GEnum23.const_3)
    {
        gclass505_0 = gclass505_1;
    }

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        Data = binaryReader_0.ReadBytes(int_2);
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        gclass505_0.method_4(genum1_0, binaryWriter_0);
    }
}
