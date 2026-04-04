using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass260 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("SceneRootType")]
    public int SceneRootType
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

    [GAttribute1("MarkerName")]
    public GClass499 MarkerName
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

    public GClass260()
    {
        MarkerName = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        SceneRootType = binaryReader_0.ReadInt32();
        MarkerName.imethod_0(binaryReader_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(SceneRootType);
        MarkerName.imethod_1(binaryWriter_0);
    }
}
