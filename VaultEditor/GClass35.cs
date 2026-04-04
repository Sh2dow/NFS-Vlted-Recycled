using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass35
{
    private readonly GClass36[] gclass36_0;

    private readonly GClass37[] gclass37_0;

    [CompilerGenerated]
    private readonly GClass29 gclass29_0;

    [CompilerGenerated]
    private readonly int int_0;

    [CompilerGenerated]
    private readonly GClass30 gclass30_0;

    public GClass29 Definition
    {
        [CompilerGenerated]
        get
        {
            return gclass29_0;
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

    public GClass30 Settings
    {
        [CompilerGenerated]
        get
        {
            return gclass30_0;
        }
    }

    public int Int32_0 => gclass36_0.Length;

    public int Int32_1 => gclass37_0.Length;

    internal GClass35(GClass29 gclass29_1, int int_1, GClass30 gclass30_1)
    {
        gclass29_0 = gclass29_1;
        int_0 = int_1;
        gclass30_0 = gclass30_1;
        gclass36_0 = new GClass36[gclass30_1.method_0()];
        for (int i = 0; i < gclass36_0.Length; i++)
        {
            gclass36_0[i] = new GClass36(this, i);
        }
        gclass37_0 = new GClass37[gclass30_1.method_1()];
        for (int j = 0; j < gclass37_0.Length; j++)
        {
            gclass37_0[j] = new GClass37(this, j);
        }
    }

    public GClass36 method_0(int int_1)
    {
        return gclass36_0[int_1];
    }

    public GClass37 method_1(int int_1)
    {
        return gclass37_0[int_1];
    }
}
