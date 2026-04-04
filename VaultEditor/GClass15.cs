using System;

namespace VaultEditor;

public sealed class GClass15
{
    private GClass20 gclass20_0;

    private readonly int int_0;

    private int int_1;

    public int Int32_0 => int_0;

    public int Int32_1 => int_1;

    internal GClass15(GClass20 gclass20_1, int int_2)
    {
        gclass20_0 = gclass20_1;
        int_0 = int_2;
    }

    internal void method_0()
    {
        while (int_1 < int_0)
        {
            method_1();
        }
        gclass20_0 = null;
    }

    public string method_1()
    {
        if (gclass20_0 == null)
        {
            throw new ObjectDisposedException(null);
        }
        if (int_1 == int_0)
        {
            throw new InvalidOperationException();
        }
        string result = gclass20_0.method_17();
        int_1++;
        return result;
    }
}
