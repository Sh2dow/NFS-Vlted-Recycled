using System;
using System.IO;

namespace VaultEditor;

public sealed class GClass18
{
    private GClass20 gclass20_0;

    private Struct6 struct6_0;

    private readonly int int_0;

    private int int_1;

    private readonly bool bool_0;

    public int Int32_0 => int_0;

    public int Int32_1 => int_1;

    internal GClass18(GClass20 gclass20_1, int int_2, Struct6 struct6_1, bool bool_1)
    {
        gclass20_0 = gclass20_1;
        struct6_0 = struct6_1;
        int_0 = int_2;
        bool_0 = bool_1;
    }

    internal void method_0()
    {
        while (int_1 < int_0)
        {
            method_1();
        }
        gclass20_0 = null;
    }

    public GEnum3? method_1()
    {
        if (gclass20_0 == null)
        {
            throw new ObjectDisposedException(null);
        }
        if (int_1 == int_0)
        {
            throw new InvalidOperationException();
        }
        if (struct6_0[int_1])
        {
            GEnum3 gEnum = (GEnum3)gclass20_0.method_14();
            int_1++;
            if (bool_0 && (gEnum & (GEnum3)(-32768)) != GEnum3.flag_0)
            {
                gEnum &= (GEnum3)32767;
            }
            if ((gEnum & (GEnum3)(-196600)) != GEnum3.flag_0)
            {
                throw new InvalidDataException();
            }
            return gEnum & (GEnum3)(-188097);
        }
        int_1++;
        return null;
    }
}
