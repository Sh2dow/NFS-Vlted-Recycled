using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass257 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private float float_0;

    [GAttribute1("TransitionType")]
    public int TransitionType
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

    [GAttribute1("TransitionSec")]
    public float TransitionSec
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
        TransitionType = binaryReader_0.ReadInt32();
        TransitionSec = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(TransitionType);
        binaryWriter_0.Write(TransitionSec);
    }
}
