using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace VaultEditor;

internal sealed class Class39 : GInterface0
{
    private GClass38 gclass38_0;

    private GInterface1 ginterface1_0;

    private Task task_0;

    private long long_0;

    private uint uint_0 = uint.MaxValue;

    private int int_0;

    private readonly bool bool_0;

    internal Class39(bool bool_1)
    {
        bool_0 = bool_1;
    }

    internal void method_0(GClass38 gclass38_1)
    {
        gclass38_0 = gclass38_1;
    }

    public void method_1()
    {
        if (int_0 != 3)
        {
            Debugger.Break();
        }
    }

    public long method_2()
    {
        int_0 |= 1;
        return long_0;
    }

    public GStruct0? method_3()
    {
        int_0 |= 2;
        if (!bool_0)
        {
            return null;
        }
        return new GStruct0((int)Class14.smethod_1(uint_0));
    }

    public void method_4(Class42 class42_0, int int_1)
    {
        ginterface1_0 = class42_0.vmethod_1(int_1);
        if (ginterface1_0 == null)
        {
            class42_0.vmethod_2(int_1, this);
        }
    }

    public void method_5()
    {
        if (ginterface1_0 != null)
        {
            task_0 = Task.Run((Func<Task>)method_6);
        }
    }

    private async Task method_6()
    {
        byte[] array = new byte[65536];
        while (true)
        {
            int num = await gclass38_0.method_0(array, 0, array.Length, GEnum2.const_1).ConfigureAwait(continueOnCapturedContext: false);
            if (num == 0)
            {
                break;
            }
            int num2 = await ginterface1_0.imethod_1(array, 0, num, GEnum2.const_0).ConfigureAwait(continueOnCapturedContext: false);
            long_0 += num2;
            uint_0 = Class14.smethod_7(uint_0, array, 0, num2);
        }
        await ginterface1_0.imethod_2().ConfigureAwait(continueOnCapturedContext: false);
    }

    public async Task<int> imethod_0(byte[] byte_0, int int_1, int int_2, GEnum2 genum2_0)
    {
        if (genum2_0 == GEnum2.const_0)
        {
            throw new NotImplementedException();
        }
        int num = await gclass38_0.method_0(byte_0, int_1, int_2, genum2_0).ConfigureAwait(continueOnCapturedContext: false);
        long_0 += num;
        uint_0 = Class14.smethod_7(uint_0, byte_0, int_1, num);
        return num;
    }
}
