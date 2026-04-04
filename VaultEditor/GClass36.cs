using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass36
{
    [CompilerGenerated]
    private readonly GClass29 gclass29_0;

    [CompilerGenerated]
    private readonly GClass35 gclass35_0;

    [CompilerGenerated]
    private readonly int int_0;

    [CompilerGenerated]
    private GClass37 gclass37_0;

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

    public GClass37 Source
    {
        [CompilerGenerated]
        get
        {
            return gclass37_0;
        }
        [CompilerGenerated]
        private set
        {
            gclass37_0 = value;
        }
    }

    public bool Boolean_0 => Node == null;

    public bool Boolean_1 => Source != null;

    internal GClass36(GClass29 gclass29_1, int int_1)
    {
        gclass29_0 = gclass29_1;
        int_0 = int_1;
    }

    internal GClass36(GClass35 gclass35_1, int int_1)
    {
        gclass29_0 = gclass35_1.Definition;
        gclass35_0 = gclass35_1;
        int_0 = int_1;
    }

    internal void method_0(GClass37 gclass37_1)
    {
        Source = gclass37_1;
    }
}
