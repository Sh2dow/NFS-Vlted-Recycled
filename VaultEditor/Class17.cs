using System;

namespace VaultEditor;

internal sealed class Class17 : Class52.Interface3
{
    private readonly GInterface1 ginterface1_0;

    internal Class17(GInterface1 ginterface1_1)
    {
        ginterface1_0 = ginterface1_1;
    }

    long Class52.Interface3.imethod_0(Struct0<byte> struct0_0, long long_0)
    {
        byte[] gparam_ = struct0_0.gparam_0;
        int num = struct0_0.int_0;
        long result = long_0;
        while (true)
        {
            if (long_0 > 2147483647L)
            {
                int result2;
                try
                {
                    result2 = ginterface1_0.imethod_1(gparam_, num, int.MaxValue, GEnum2.const_1).GetAwaiter().GetResult();
                }
                catch (OperationCanceledException)
                {
                    return 0L;
                }
                if (result2 <= 0)
                {
                    break;
                }
                num += result2;
                long_0 -= result2;
                continue;
            }
            if (long_0 > 0L)
            {
                int result3;
                try
                {
                    result3 = ginterface1_0.imethod_1(gparam_, num, (int)long_0, GEnum2.const_0).GetAwaiter().GetResult();
                }
                catch (OperationCanceledException)
                {
                    return 0L;
                }
                if (result3 != long_0)
                {
                    throw new InvalidOperationException("IOutputStream.WriteAsync returned an invalid result.");
                }
            }
            return result;
        }
        throw new InvalidOperationException("IOutputStream.WriteAsync returned an invalid result.");
    }
}
