using System;

namespace VaultEditor;

internal sealed class Class22(Class32 class32_1, long long_3, long long_4) : Class21
{
    private Class32 class32_0 = class32_1;

    private readonly long long_0 = long_3;

    private long long_1 = long_3;

    private readonly long long_2 = long_3 + long_4;

    public override void Dispose()
    {
        class32_0 = null;
    }

    public override void vmethod_0(int int_0)
    {
        long num = long_2 - long_1;
        if (int_0 < 0 || int_0 > num)
        {
            throw new ArgumentOutOfRangeException("count");
        }
        long_1 += int_0;
    }

    public override int vmethod_1(byte[] byte_0, int int_0, int int_1)
    {
        long num = long_2 - long_1;
        if (num == 0L)
        {
            return 0;
        }
        if (int_1 > num)
        {
            int_1 = (int)num;
        }
        int num2 = class32_0.method_0(long_1, byte_0, int_0, int_1);
        if (num2 <= 0 || num2 > int_1)
        {
            throw new Exception1();
        }
        long_1 += num2;
        return num2;
    }
}
