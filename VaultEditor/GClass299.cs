using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass299 : GClass154
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private float float_2;

    [GAttribute1("DegPerG")]
    public float DegPerG
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

    [GAttribute1("DegPerSec")]
    public float DegPerSec
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

    [GAttribute1("MaxG")]
    public float MaxG
    {
        [CompilerGenerated]
        get
        {
            return float_2;
        }
        [CompilerGenerated]
        set
        {
            float_2 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        DegPerG = binaryReader_0.ReadSingle();
        MaxG = binaryReader_0.ReadSingle();
        DegPerSec = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(DegPerG);
        binaryWriter_0.Write(MaxG);
        binaryWriter_0.Write(DegPerSec);
    }
}
