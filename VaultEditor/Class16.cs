using System;

namespace VaultEditor;

internal sealed class Class16 : Class52.Interface2
{
    private readonly GInterface0 ginterface0_0;

    private bool bool_0;

    internal Class16(GInterface0 ginterface0_1)
    {
        ginterface0_0 = ginterface0_1;
    }

    Class52.Struct21 Class52.Interface2.imethod_0(Struct0<byte> struct0_0, ref long long_0)
    {
        if (bool_0)
        {
            long_0 = 0L;
            return Class52.Struct21_0;
        }
        int num = (int)((long_0 < 2147483647L) ? long_0 : int.MaxValue);
        int result;
        try
        {
            result = ginterface0_0.imethod_0(struct0_0.gparam_0, struct0_0.int_0, num, GEnum2.const_1).GetAwaiter().GetResult();
        }
        catch (OperationCanceledException)
        {
            long_0 = 0L;
            return Class52.Struct21_11;
        }
        if (result >= 0 && result <= num)
        {
            if (result == 0)
            {
                bool_0 = true;
            }
            long_0 = result;
            return Class52.Struct21_0;
        }
        throw new InvalidOperationException("IInputStream.ReadAsync returned an invalid result.");
    }
}
