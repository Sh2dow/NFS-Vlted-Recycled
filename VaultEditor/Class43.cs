using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace VaultEditor;

internal sealed class Class43 : Class42
{
    private sealed class Class38(Class43 class43_1, ICryptoTransform icryptoTransform_1) : GInterface1
    {
        private readonly Class43 class43_0 = class43_1;

        private GInterface1 ginterface1_0;

        private readonly ICryptoTransform icryptoTransform_0 = icryptoTransform_1;

        private readonly byte[] byte_0 = new byte[16];

        private byte[] byte_1 = new byte[16];

        private int int_0;

        public void method_0(GInterface1 ginterface1_1)
        {
            ginterface1_0 = ginterface1_1;
        }

        public async Task<int> imethod_1(byte[] byte_2, int int_1, int int_2, GEnum2 genum2_0)
        {
            int num = 0;
            do
            {
                if (int_0 == 16)
                {
                    icryptoTransform_0.TransformBlock(byte_0, 0, 16, byte_1, 0);
                    await ginterface1_0.imethod_1(byte_1, 0, 16, GEnum2.const_0).ConfigureAwait(continueOnCapturedContext: false);
                    int_0 = 0;
                }
                int num2 = Math.Min(16 - int_0, int_2);
                Buffer.BlockCopy(byte_2, int_1, byte_0, int_0, num2);
                int_0 += num2;
                num += num2;
                int_1 += num2;
                int_2 -= num2;
            }
            while (int_2 != 0 && genum2_0 != GEnum2.const_1);
            return num;
        }

        public async Task imethod_2()
        {
            if (int_0 != 0)
            {
                while (int_0 < 16)
                {
                    byte_0[int_0++] = 0;
                }
                byte_1 = icryptoTransform_0.TransformFinalBlock(byte_0, 0, 16);
                await ginterface1_0.imethod_1(byte_1, 0, 16, GEnum2.const_0).ConfigureAwait(continueOnCapturedContext: false);
                int_0 = 0;
            }
            await ginterface1_0.imethod_2().ConfigureAwait(continueOnCapturedContext: false);
        }

        public void method_1()
        {
            icryptoTransform_0.Dispose();
        }
    }

    private readonly Class38 class38_0;

    public Class43(ICryptoTransform icryptoTransform_0)
    {
        class38_0 = new Class38(this, icryptoTransform_0);
    }

    public override GInterface1 vmethod_1(int int_0)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return class38_0;
    }

    public override void vmethod_2(int int_0, GInterface0 ginterface0_0)
    {
        throw new Exception1();
    }

    public override GInterface0 vmethod_3(int int_0)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return null;
    }

    public override void vmethod_4(int int_0, GInterface1 ginterface1_0)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        class38_0.method_0(ginterface1_0);
    }

    public override void vmethod_0()
    {
    }

    public void Dispose()
    {
        class38_0.method_1();
    }
}
