using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace VaultEditor;

internal static class Class19
{
    internal static Task Task_0 => Task.FromResult<object>(null);

    internal static void smethod_0()
    {
    }

    internal static void smethod_1()
    {
    }

    internal static void smethod_2<T>(ref T[] gparam_0)
    {
        if (gparam_0 != null)
        {
            Array.Clear(gparam_0, 0, gparam_0.Length);
            gparam_0 = null;
        }
    }

    internal static void smethod_3(byte[] byte_0, int int_0, int int_1, GEnum2 genum2_0)
    {
        if (byte_0 == null)
        {
            throw new ArgumentNullException("buffer");
        }
        if (int_0 >= 0 && int_0 < byte_0.Length)
        {
            if (int_1 > 0 && int_1 <= byte_0.Length - int_0)
            {
                if (genum2_0 != GEnum2.const_0 && genum2_0 != GEnum2.const_1)
                {
                    throw new ArgumentOutOfRangeException("mode");
                }
                return;
            }
            throw new ArgumentOutOfRangeException("length");
        }
        throw new ArgumentOutOfRangeException("offset");
    }

    [Conditional("DEBUG")]
    internal static void smethod_4(byte[] byte_0, int int_0, int int_1, GEnum2 genum2_0)
    {
    }
}
