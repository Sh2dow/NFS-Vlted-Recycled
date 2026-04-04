using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass37
{
    [CompilerGenerated]
    private readonly GClass29 gclass29_0;

    [CompilerGenerated]
    private readonly GClass35 gclass35_0;

    [CompilerGenerated]
    private readonly int int_0;

    [CompilerGenerated]
    private GClass36 gclass36_0;

    public GClass29 Definition
    {
        [CompilerGenerated]
        get
        {
            return gclass29_0;
        }
    }

    public GClass35 Node
    {
        [CompilerGenerated]
        get
        {
            return gclass35_0;
        }
    }

    public int Index
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
    }

    public GClass36 Target
    {
        [CompilerGenerated]
        get
        {
            return gclass36_0;
        }
        [CompilerGenerated]
        private set
        {
            gclass36_0 = value;
        }
    }

    public bool Boolean_0 => Node == null;

    public bool Boolean_1 => Target != null;

    internal GClass37(GClass29 gclass29_1)
    {
        gclass29_0 = gclass29_1;
    }

    internal GClass37(GClass35 gclass35_1, int int_1)
    {
        gclass29_0 = gclass35_1.Definition;
        gclass35_0 = gclass35_1;
        int_0 = int_1;
    }

    internal void method_0(GClass36 gclass36_1)
    {
        Target = gclass36_1;
    }
}
