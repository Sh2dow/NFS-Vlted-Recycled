using System;
using System.Threading;
using System.Threading.Tasks;

namespace VaultEditor;

internal sealed class Class41 : GInterface0, GInterface1
{
    private GInterface0 ginterface0_0;

    private GInterface1 ginterface1_0;

    private Task task_0;

    private Struct1<int> struct1_0;

    private byte[] byte_0;

    private int int_0;

    private int int_1;

    private long long_0;

    private bool bool_0;

    private bool bool_1;

    public void method_0()
    {
        if (!bool_1)
        {
            bool_1 = true;
            if (!bool_0 && ginterface1_0 != null && ginterface0_0 != null)
            {
                throw new NotImplementedException();
            }
        }
    }

    public long method_1()
    {
        return long_0;
    }

    public void method_2(Class42 class42_0, int int_2)
    {
        ginterface1_0 = class42_0.vmethod_1(int_2);
        if (ginterface1_0 == null)
        {
            class42_0.vmethod_2(int_2, this);
        }
    }

    public void method_3(Class42 class42_0, int int_2)
    {
        ginterface0_0 = class42_0.vmethod_3(int_2);
        if (ginterface0_0 == null)
        {
            class42_0.vmethod_4(int_2, this);
        }
    }

    public void method_4()
    {
        if (ginterface1_0 != null && ginterface0_0 != null)
        {
            task_0 = Task.Run((Func<Task>)method_5);
        }
    }

    private async Task method_5()
    {
        byte[] array = new byte[65536];
        int num = 0;
        int num2 = 0;
        while (true)
        {
            if (!bool_0 && num2 < array.Length)
            {
                int num3 = await ginterface0_0.imethod_0(array, num2, array.Length - num2, GEnum2.const_1).ConfigureAwait(continueOnCapturedContext: false);
                if (num3 == 0)
                {
                    bool_0 = true;
                }
                else
                {
                    num2 += num3;
                }
            }
            if (num < num2)
            {
                num += await ginterface1_0.imethod_1(array, num, num2 - num, GEnum2.const_1).ConfigureAwait(continueOnCapturedContext: false);
            }
            if (num == num2)
            {
                num = 0;
                num2 = 0;
                if (bool_0)
                {
                    break;
                }
            }
        }
        await ginterface1_0.imethod_2().ConfigureAwait(continueOnCapturedContext: false);
    }

    public Task<int> imethod_0(byte[] byte_1, int int_2, int int_3, GEnum2 genum2_0)
    {
        if (ginterface0_0 != null)
        {
            return ginterface0_0.imethod_0(byte_1, int_2, int_3, genum2_0);
        }
        lock (this)
        {
            if (byte_0 != null)
            {
                throw new Exception1();
            }
            if (bool_0)
            {
                return Task.FromResult(0);
            }
            byte_0 = byte_1;
            int_0 = int_2;
            int_1 = int_2 + int_3;
            struct1_0 = Struct1<int>.smethod_0();
            Monitor.PulseAll(this);
            return struct1_0.Task_0;
        }
    }

    public async Task<int> imethod_1(byte[] byte_1, int int_2, int int_3, GEnum2 genum2_0)
    {
        if (ginterface1_0 == null)
        {
            int num = 0;
            do
            {
                lock (this)
                {
                    while (byte_0 == null)
                    {
                        Monitor.Wait(this);
                    }
                    int num2 = Math.Min(int_3, int_1 - int_0);
                    Buffer.BlockCopy(byte_1, int_2, byte_0, int_0, num2);
                    long_0 += num2;
                    num += num2;
                    int_2 += num2;
                    int_3 -= num2;
                    byte_0 = null;
                    struct1_0.method_1(num2);
                }
            }
            while (genum2_0 == GEnum2.const_0 && int_3 > 0);
            return num;
        }
        int num3 = await ginterface1_0.imethod_1(byte_1, int_2, int_3, genum2_0);
        long_0 += num3;
        return num3;
    }

    public Task imethod_2()
    {
        if (ginterface1_0 != null)
        {
            return ginterface1_0.imethod_2();
        }
        lock (this)
        {
            if (bool_0)
            {
                throw new Exception1();
            }
            bool_0 = true;
            if (byte_0 != null)
            {
                byte_0 = null;
                struct1_0.method_1(0);
            }
        }
        return Class19.Task_0;
    }
}
