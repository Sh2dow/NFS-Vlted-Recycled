using System;
using System.IO;

namespace VaultEditor;

internal sealed class Class31 : Class27
{
    private sealed class Class26(Class31 class31_1) : Class21
    {
        private Class31 class31_0 = class31_1;

        public void Dispose()
        {
            class31_0 = null;
        }

        public override void vmethod_0(int int_0)
        {
            class31_0.method_0(int_0);
        }

        public override int vmethod_1(byte[] byte_0, int int_0, int int_1)
        {
            return class31_0.method_1(byte_0, int_0, int_1);
        }
    }

    private readonly byte[] byte_0 = new byte[4096];

    private int int_0;

    private int int_1;

    private readonly GClass39 gclass39_0;

    private Class21 class21_0;

    private readonly Class21 class21_1;

    private readonly long long_0;

    private long long_1;

    public Class31(byte[] byte_1, long long_2)
    {
        gclass39_0 = new GClass39(GClass41.smethod_1(byte_1));
        class21_1 = new Class26(this);
        long_0 = long_2;
    }

    public override void Dispose()
    {
        gclass39_0.Dispose();
        class21_1.Dispose();
        class21_0?.Dispose();
    }

    public override void vmethod_0(int int_2, Class21 class21_2, long long_2)
    {
        if (int_2 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        class21_0 = class21_2 ?? throw new ArgumentNullException("stream");
    }

    public override Class21 vmethod_1(int int_2)
    {
        if (int_2 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return class21_1;
    }

    private void method_0(int int_2)
    {
        while (true)
        {
            if (int_2 > 0)
            {
                if (gclass39_0.Boolean_0)
                {
                    break;
                }
                if (gclass39_0.Int32_1 > 0)
                {
                    int num = gclass39_0.method_1(int_2);
                    long_1 += num;
                    int_2 -= num;
                }
                else
                {
                    method_2();
                }
                continue;
            }
            return;
        }
        throw new InvalidDataException();
    }

    private int method_1(byte[] byte_1, int int_2, int int_3)
    {
        while (true)
        {
            if (!gclass39_0.Boolean_0)
            {
                if (gclass39_0.Int32_1 > 0)
                {
                    break;
                }
                method_2();
                continue;
            }
            return 0;
        }
        int num = gclass39_0.method_0(byte_1, int_2, int_3);
        long_1 += num;
        return num;
    }

    private void method_2()
    {
        if (int_0 == int_1)
        {
            int_1 = class21_0.vmethod_1(byte_0, 0, byte_0.Length);
            int_0 = gclass39_0.method_2(byte_0, 0, int_1, null, int_1 == 0);
        }
        else
        {
            int_0 += gclass39_0.method_2(byte_0, int_0, int_1 - int_0, null, bool_3: false);
        }
    }
}
