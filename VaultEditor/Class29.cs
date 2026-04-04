using System;

namespace VaultEditor;

internal sealed class Class29 : Class27
{
    private sealed class Class24(Class29 class29_1) : Class21
    {
        private Class29 class29_0 = class29_1;

    public void Dispose()
        {
            class29_0 = null;
        }

        public override void vmethod_0(int int_0)
        {
            class29_0.method_0(int_0);
        }

        public override int vmethod_1(byte[] byte_0, int int_0, int int_1)
        {
            return class29_0.method_1(byte_0, int_0, int_1);
        }
    }

    private Class21 class21_0;

    private readonly Class24 class24_0;

    private readonly long long_0;

    private long long_1;

    public Class29(byte[] byte_0, long long_2)
    {
        if (long_2 < 0L)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        class24_0 = new Class24(this);
        long_0 = long_2;
    }

    public override void Dispose()
    {
        class24_0.Dispose();
        class21_0?.Dispose();
    }

    public override void vmethod_0(int int_0, Class21 class21_1, long long_2)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        if (class21_0 != null)
        {
            throw new InvalidOperationException();
        }
        class21_0 = class21_1 ?? throw new ArgumentNullException("stream");
    }

    public override Class21 vmethod_1(int int_0)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return class24_0;
    }

    private void method_0(int int_0)
    {
        class21_0.vmethod_0(int_0);
    }

    private int method_1(byte[] byte_0, int int_0, int int_1)
    {
        int num = class21_0.vmethod_1(byte_0, int_0, int_1);
        long_1 += num;
        return num;
    }
}
