using System;
using System.IO;
using System.Threading.Tasks;

namespace VaultEditor;

internal sealed class Class40(Stream stream_1, bool bool_1) : GInterface1
{
    private Stream stream_0 = stream_1;

    private GInterface0 ginterface0_0;

    private Task task_0;

    private readonly Struct1<object> struct1_0 = Struct1<object>.smethod_0();

    private readonly bool bool_0 = bool_1;

    private uint uint_0 = uint.MaxValue;

    public void method_0()
    {
        if (stream_0 != null)
        {
            throw new NotImplementedException();
        }
    }

    public Stream method_1()
    {
        Stream result = stream_0;
        stream_0 = null;
        return result;
    }

    public GStruct0? method_2()
    {
        if (!bool_0)
        {
            return null;
        }
        return new GStruct0((int)Class14.smethod_1(uint_0));
    }

    public void method_3(Class42 class42_0, int int_0)
    {
        ginterface0_0 = class42_0.vmethod_3(int_0);
        if (ginterface0_0 == null)
        {
            class42_0.vmethod_4(int_0, this);
        }
    }

    public void method_4()
    {
        if (ginterface0_0 != null)
        {
            task_0 = Task.Run((Func<Task>)method_5);
        }
    }

    private async Task method_5()
    {
        byte[] array = new byte[65536];
        while (true)
        {
            int num = await ginterface0_0.imethod_0(array, 0, array.Length, GEnum2.const_1).ConfigureAwait(continueOnCapturedContext: false);
            if (num == 0)
            {
                break;
            }
            if (bool_0)
            {
                uint_0 = Class14.smethod_7(uint_0, array, 0, num);
            }
            await stream_0.WriteAsync(array, 0, num).ConfigureAwait(continueOnCapturedContext: false);
        }
        struct1_0.method_1(null);
    }

    public async Task<int> imethod_1(byte[] byte_0, int int_0, int int_1, GEnum2 genum2_0)
    {
        if (bool_0)
        {
            for (int i = 0; i < int_1; i++)
            {
                uint_0 = Class14.smethod_2(uint_0, byte_0[int_0 + i]);
            }
        }
        await stream_0.WriteAsync(byte_0, int_0, int_1).ConfigureAwait(continueOnCapturedContext: false);
        return int_1;
    }

    public Task imethod_2()
    {
        struct1_0.method_1(null);
        return Class19.Task_0;
    }

    public Task method_6()
    {
        return struct1_0.Task_0;
    }
}
