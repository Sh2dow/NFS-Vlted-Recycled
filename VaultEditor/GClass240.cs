using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass240 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [GAttribute1("VisualScale")]
    public float VisualScale
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

    [GAttribute1("HitPointScale")]
    public float HitPointScale
    {
        [CompilerGenerated]
        get
        {
            return float_1;
        }
        [CompilerGenerated]
        set
        {
            float_1 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        VisualScale = binaryReader_0.ReadSingle();
        HitPointScale = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(VisualScale);
        binaryWriter_0.Write(HitPointScale);
    }
}
