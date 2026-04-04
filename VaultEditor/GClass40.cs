using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace VaultEditor;

public sealed class GClass40 : IDisposable
{
    private sealed class Class48
    {
        public byte[] byte_0;

        public int int_0;

        public int int_1;

        public int int_2;

        public Struct1<object> struct1_0 = Struct1<object>.smethod_0();
    }

    private sealed class Class49
    {
        public byte[] byte_0;

        public int int_0;

        public int int_1;

        public int int_2;

        public Struct1<int> struct1_0 = Struct1<int>.smethod_0();

        public GEnum2 genum2_0;
    }

    private readonly object object_0;

    private readonly Action action_0;

    private Task task_0;

    private Task task_1;

    private readonly Struct1<object> struct1_0 = Struct1<object>.smethod_0();

    private readonly Queue<Class48> queue_0;

    private readonly Queue<Class49> queue_1;

    private int int_0;

    private bool bool_0;

    private bool bool_1;

    private readonly GClass39 gclass39_0;

    public GClass40(GClass41 gclass41_0)
    {
        if (gclass41_0 == null)
        {
            throw new ArgumentNullException("settings");
        }
        object_0 = new object();
        action_0 = method_9;
        gclass39_0 = new GClass39(gclass41_0);
    }

    public void Dispose()
    {
        method_0().GetAwaiter().GetResult();
    }

    public Task method_0()
    {
        lock (object_0)
        {
            if (task_1 == null)
            {
                if (bool_0)
                {
                    task_1 = task_0.ContinueWith(delegate
                    {
                        lock (object_0)
                        {
                            method_1();
                        }
                    });
                }
                else
                {
                    method_1();
                    task_1 = Class19.Task_0;
                }
            }
            return task_1;
        }
    }

    private void method_1()
    {
        gclass39_0.Dispose();
        foreach (Class48 item in queue_0)
        {
            item.struct1_0.method_0();
        }
        queue_0.Clear();
        foreach (Class49 item2 in queue_1)
        {
            item2.struct1_0.method_0();
        }
        queue_1.Clear();
        if (!struct1_0.Task_0.IsCompleted)
        {
            struct1_0.method_0();
        }
    }

    public Task method_2()
    {
        lock (object_0)
        {
            bool_1 = true;
            method_8();
            return struct1_0.Task_0;
        }
    }

    public Task method_3(byte[] byte_0, int int_1, int int_2)
    {
        if (byte_0 == null)
        {
            throw new ArgumentNullException("buffer");
        }
        if (int_1 >= 0 && int_1 <= byte_0.Length)
        {
            if (int_2 < 0 || int_2 > byte_0.Length - int_1)
            {
                throw new ArgumentOutOfRangeException("length");
            }
            Class48 @class = new()
            {
                byte_0 = byte_0,
                int_0 = int_1,
                int_1 = int_1,
                int_2 = int_1 + int_2
            };
            method_6(@class);
            return @class.struct1_0.Task_0;
        }
        throw new ArgumentOutOfRangeException("offset");
    }

    public Task<int> method_4(byte[] byte_0, int int_1, int int_2, GEnum2 genum2_0)
    {
        if (byte_0 == null)
        {
            throw new ArgumentNullException("buffer");
        }
        if (int_1 >= 0 && int_1 <= byte_0.Length)
        {
            if (int_2 >= 0 && int_2 <= byte_0.Length - int_1)
            {
                if (genum2_0 != GEnum2.const_0 && genum2_0 != GEnum2.const_1)
                {
                    throw new ArgumentOutOfRangeException("mode");
                }
                Class49 @class = new()
                {
                    byte_0 = byte_0,
                    int_0 = int_1,
                    int_1 = int_1,
                    int_2 = int_1 + int_2,
                    genum2_0 = genum2_0
                };
                method_7(@class);
                return @class.struct1_0.Task_0;
            }
            throw new ArgumentOutOfRangeException("length");
        }
        throw new ArgumentOutOfRangeException("offset");
    }

    public async Task method_5(int int_1)
    {
        if (int_1 < 0)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        if (int_1 == 0)
        {
            return;
        }
        Class19.smethod_1();
        byte[] array = new byte[Math.Min(16384, int_1)];
        while (int_1 > 0)
        {
            int num = await method_4(array, 0, Math.Min(array.Length, int_1), GEnum2.const_1);
            if (num != 0)
            {
                int_1 -= num;
                continue;
            }
            throw new InvalidOperationException("Skipping beyond end of stream.");
        }
    }

    private void method_6(Class48 class48_0)
    {
        lock (object_0)
        {
            if (task_1 != null)
            {
                throw new ObjectDisposedException(null);
            }
            if (bool_1)
            {
                throw new InvalidOperationException();
            }
            queue_0.Enqueue(class48_0);
            method_8();
        }
    }

    private void method_7(Class49 class49_0)
    {
        checked
        {
            lock (object_0)
            {
                if (task_1 != null)
                {
                    throw new ObjectDisposedException(null);
                }
                int_0 += class49_0.int_2 - class49_0.int_1;
                queue_1.Enqueue(class49_0);
                method_8();
            }
        }
    }

    private void method_8()
    {
        if (!bool_0)
        {
            bool_0 = true;
            task_0 = Task.Run(action_0);
        }
    }

    private void method_9()
    {
        do
        {
            method_10();
        }
        while (method_11());
    }

    private void method_10()
    {
        while (gclass39_0.Int32_1 > 0)
        {
            Class49 @class;
            lock (object_0)
            {
                if (queue_1.Count == 0)
                {
                    break;
                }
                @class = queue_1.Peek();
                goto IL_0043;
            }
        IL_0043:
            int num = @class.int_2 - @class.int_1;
            int num2 = Math.Min(num, gclass39_0.Int32_1);
            gclass39_0.method_0(@class.byte_0, @class.int_1, num2);
            @class.int_1 += num2;
            if (num2 == num || @class.genum2_0 == GEnum2.const_1)
            {
                @class.struct1_0.method_1(@class.int_1 - @class.int_0);
                lock (object_0)
                {
                    queue_1.Dequeue();
                }
            }
        }
        if (gclass39_0.Boolean_0 && !struct1_0.Task_0.IsCompleted)
        {
            struct1_0.method_1(null);
        }
    }

    private bool method_11()
    {
        bool bool_;
        int value;
        Class48 @class;
        lock (object_0)
        {
            if (queue_0.Count == 0 || task_1 != null)
            {
                bool_0 = false;
                return false;
            }
            bool_ = bool_1 && queue_0.Count == 1;
            value = int_0;
            @class = queue_0.Peek();
        }
        @class.int_1 += gclass39_0.method_2(@class.byte_0, @class.int_1, @class.int_2 - @class.int_1, value, bool_);
        if (@class.int_1 == @class.int_2)
        {
            @class.struct1_0.method_1(null);
            lock (object_0)
            {
                queue_0.Dequeue();
                if (task_1 != null)
                {
                    bool_0 = false;
                    return false;
                }
            }
        }
        return true;
    }

    [CompilerGenerated]
    private void method_12(Task task_2)
    {
        lock (object_0)
        {
            method_1();
        }
    }
}
