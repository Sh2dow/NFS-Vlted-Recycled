using System;

namespace VaultEditor;

public sealed class GClass19
{
    private GClass20 gclass20_0;

    private Struct6 struct6_0;

    private int int_0;

    public int Int32_0 => struct6_0.Int32_0;

    public int Int32_1 => int_0;

    internal GClass19(GClass20 gclass20_1, Struct6 struct6_1)
    {
        gclass20_0 = gclass20_1;
        struct6_0 = struct6_1;
    }

    internal void method_0()
    {
        while (int_0 < struct6_0.Int32_0)
        {
            method_1();
        }
        gclass20_0 = null;
    }

    public bool method_1()
    {
        if (gclass20_0 == null)
        {
            throw new ObjectDisposedException(null);
        }
        if (int_0 == struct6_0.Int32_0)
        {
            throw new InvalidOperationException();
        }
        return struct6_0[int_0++];
    }
}
