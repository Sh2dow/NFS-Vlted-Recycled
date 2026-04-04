using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass258 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private GClass499 gclass499_1;

    [CompilerGenerated]
    private bool bool_2;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private bool bool_3;

    [GAttribute1("ActorName")]
    public GClass499 ActorName
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

    [GAttribute1("CarChannelName")]
    public GClass499 CarChannelName
    {
        [CompilerGenerated]
        get
        {
            return gclass499_1;
        }
        [CompilerGenerated]
        set
        {
            gclass499_1 = value;
        }
    }

    [GAttribute1("IsDriver")]
    public bool IsDriver
    {
        [CompilerGenerated]
        get
        {
            return bool_2;
        }
        [CompilerGenerated]
        set
        {
            bool_2 = value;
        }
    }

    [GAttribute1("ExitAnimSec")]
    public float ExitAnimSec
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

    [GAttribute1("IsFacePixelation")]
    public bool IsFacePixelation
    {
        [CompilerGenerated]
        get
        {
            return bool_3;
        }
        [CompilerGenerated]
        set
        {
            bool_3 = value;
        }
    }

    public GClass258()
    {
        ActorName = new GClass499();
        CarChannelName = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        ActorName.imethod_0(binaryReader_0);
        CarChannelName.imethod_0(binaryReader_0);
        IsDriver = binaryReader_0.ReadInt32() == 1;
        ExitAnimSec = binaryReader_0.ReadSingle();
        IsFacePixelation = binaryReader_0.ReadInt32() == 1;
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        ActorName.imethod_1(binaryWriter_0);
        CarChannelName.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(IsDriver ? 1 : 0);
        binaryWriter_0.Write(ExitAnimSec);
        binaryWriter_0.Write(IsFacePixelation ? 1 : 0);
    }
}
