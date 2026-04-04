using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass209 : GClass154
{
    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("Parts")]
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

    [GAttribute1("Type")]
    public GClass499 CarName
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

    public GClass209()
    {
        CustomData = new GClass516();
        CarName = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        CustomData.imethod_0(binaryReader_0);
        CarName.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        CustomData.imethod_1(binaryWriter_0);
        CarName.imethod_1(binaryWriter_0);
    }
}
