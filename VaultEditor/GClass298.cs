using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass298 : GClass154
{
    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [GAttribute1("Blob")]
    public GInterface5 CustomData
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_0;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_0 = value;
        }
    }

    public GClass298()
    {
        CustomData = new GClass513();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        CustomData.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        CustomData.imethod_1(binaryWriter_0);
    }
}
