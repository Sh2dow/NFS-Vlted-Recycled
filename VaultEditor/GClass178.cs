using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass178 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private int int_6;

    [GAttribute1("Acceleration")]
    public int Acceleration
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

    [GAttribute1("Handling")]
    public int Handling
    {
        [CompilerGenerated]
        get
        {
            return int_4;
        }
        [CompilerGenerated]
        set
        {
            int_4 = value;
        }
    }

    [GAttribute1("RequiredPartCount")]
    public int RequiredPartCount
    {
        [CompilerGenerated]
        get
        {
            return int_5;
        }
        [CompilerGenerated]
        set
        {
            int_5 = value;
        }
    }

    [GAttribute1("TopSpeed")]
    public int TopSpeed
    {
        [CompilerGenerated]
        get
        {
            return int_6;
        }
        [CompilerGenerated]
        set
        {
            int_6 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Acceleration = binaryReader_0.ReadInt32();
        Handling = binaryReader_0.ReadInt32();
        RequiredPartCount = binaryReader_0.ReadInt32();
        TopSpeed = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Acceleration);
        binaryWriter_0.Write(Handling);
        binaryWriter_0.Write(RequiredPartCount);
        binaryWriter_0.Write(TopSpeed);
    }
}
