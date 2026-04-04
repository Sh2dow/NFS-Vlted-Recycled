using System;

namespace VaultEditor;

internal sealed class Class30 : Class27
{
    private sealed class Class25(Class30 class30_1) : Class21
    {
        private Class30 class30_0 = class30_1;

        public void Dispose()
        {
            class30_0 = null;
        }

        public override void vmethod_0(int int_0)
        {
            class30_0.method_1(int_0);
        }

        public override int vmethod_1(byte[] byte_0, int int_0, int int_1)
        {
            return class30_0.method_2(byte_0, int_0, int_1);
        }
    }

    private GClass44 gclass44_0;

    private Class21 class21_0;

    private Class25 class25_0;

    private byte[] byte_0;

    private int int_0;

    private int int_1;

    private readonly long long_0;

    private long long_1;

    public Class30(byte[] byte_1, long long_2)
    {
        gclass44_0 = new GClass44(new GClass45(byte_1[0]));
        class25_0 = new Class25(this);
        byte_0 = new byte[4096];
        long_0 = long_2;
    }

    public override void Dispose()
    {
        gclass44_0?.Dispose();
        gclass44_0 = null;
        class25_0?.Dispose();
        class25_0 = null;
        byte_0 = null;
    }

    public override void vmethod_0(int int_2, Class21 class21_1, long long_2)
    {
        if (int_2 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        class21_0 = class21_1 ?? throw new ArgumentNullException("stream");
    }

    public override Class21 vmethod_1(int int_2)
    {
        if (int_2 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return class25_0;
    }

    private void method_0()
    {
        while (gclass44_0.Int32_1 == 0 && !gclass44_0.Boolean_0)
        {
            if (int_0 == int_1)
            {
                int_0 = 0;
                int_1 = 0;
                int num = class21_0.vmethod_1(byte_0, 0, byte_0.Length);
                if (num == 0)
                {
                    gclass44_0.method_2(null, 0, 0, null, bool_3: true);
                    continue;
                }
                int_1 = num;
            }
            int num2 = gclass44_0.method_2(byte_0, int_0, int_1 - int_0, (int)Math.Min(2147483647L, long_0 - long_1), bool_3: false);
            int_0 += num2;
        }
    }

    private void method_1(int int_2)
    {
        while (int_2 > 0)
        {
            method_0();
            int num = gclass44_0.method_1(int_2);
            int_2 -= num;
            long_1 += num;
        }
    }

    private int method_2(byte[] byte_1, int int_2, int int_3)
    {
        method_0();
        int num = gclass44_0.method_0(byte_1, int_2, int_3);
        long_1 += num;
        return num;
    }
}
