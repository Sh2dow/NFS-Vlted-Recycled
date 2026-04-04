using System;
using System.Threading;
using System.Threading.Tasks;

namespace VaultEditor;

internal sealed class Class44 : Class42, GInterface0, GInterface1
{
    private byte[] byte_0;

    private int int_0;

    private int int_1;

    private bool bool_0;

    Task<int> GInterface0.imethod_0(byte[] byte_1, int int_2, int int_3, GEnum2 genum2_0)
    {
        lock (this)
        {
            int num = 0;
            while (int_3 > 0)
            {
                while (byte_0 == null)
                {
                    if (!bool_0)
                    {
                        Monitor.Wait(this);
                        continue;
                    }
                    return Task.FromResult(num);
                }
                int num2 = Math.Min(int_3, int_1);
                Buffer.BlockCopy(byte_0, int_0, byte_1, int_2, num2);
                int_0 += num2;
                int_1 -= num2;
                int_2 += num2;
                int_3 -= num2;
                num += num2;
                if (int_1 == 0)
                {
                    byte_0 = null;
                    Monitor.PulseAll(this);
                }
                if (genum2_0 == GEnum2.const_1)
                {
                    break;
                }
            }
            return Task.FromResult(num);
        }
    }

    Task<int> GInterface1.imethod_1(byte[] byte_1, int int_2, int int_3, GEnum2 genum2_0)
    {
        lock (this)
        {
            while (byte_0 != null)
            {
                Monitor.Wait(this);
            }
            byte_0 = byte_1;
            int_0 = int_2;
            int_1 = int_3;
            Monitor.PulseAll(this);
            do
            {
                if (byte_0 != null)
                {
                    Monitor.Wait(this);
                    continue;
                }
                return Task.FromResult(int_3);
            }
            while (genum2_0 != GEnum2.const_1 || byte_0 == null || int_1 >= int_3);
            byte_0 = null;
            Monitor.PulseAll(this);
            return Task.FromResult(int_3 - int_1);
        }
    }

    Task GInterface1.imethod_2()
    {
        lock (this)
        {
            bool_0 = true;
            Monitor.PulseAll(this);
            while (byte_0 != null)
            {
                Monitor.Wait(this);
            }
        }
        return Class19.Task_0;
    }

    public override GInterface1 vmethod_1(int int_2)
    {
        if (int_2 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return this;
    }

    public override void vmethod_2(int int_2, GInterface0 ginterface0_0)
    {
        throw new Exception1();
    }

    public override GInterface0 vmethod_3(int int_2)
    {
        if (int_2 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return this;
    }

    public override void vmethod_4(int int_2, GInterface1 ginterface1_0)
    {
        throw new Exception1();
    }

    public override void vmethod_0()
    {
    }

    public override void Dispose()
    {
    }
}
