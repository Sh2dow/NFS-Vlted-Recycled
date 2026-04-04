using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace VaultEditor;

public sealed class GClass42 : IDisposable
{
    [CompilerGenerated]
    private sealed class Class50
    {
        public GClass42 gclass42_0;

        public GInterface1 ginterface1_0;

        public GInterface0 ginterface0_0;

        internal async Task method_0()
        {
            if (Class52.Struct21.smethod_1(gclass42_0.class73_0.method_9(new Class17(ginterface1_0), new Class16(ginterface0_0), null, Class52.Class77.class77_1, Class52.Class77.class77_0), Class52.Struct21_0))
            {
                throw new InvalidOperationException();
            }
            await ginterface1_0.imethod_2().ConfigureAwait(continueOnCapturedContext: false);
        }

        internal void method_1(Task task_0)
        {
            lock (gclass42_0.object_0)
            {
                gclass42_0.bool_0 = false;
                Monitor.PulseAll(gclass42_0.object_0);
            }
        }
    }

    private readonly object object_0;

    private Task task_0;

    private Task task_1;

    private bool bool_0;

    private readonly Class52.Class73 class73_0;

    public GClass42(GClass43 gclass43_0)
    {
        if (gclass43_0 == null)
        {
            throw new ArgumentNullException("settings");
        }
        object_0 = new object();
        class73_0 = new Class52.Class73();
        class73_0.method_7(gclass43_0.method_2());
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
                    Monitor.PulseAll(object_0);
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
        class73_0.method_6(Class52.Class77.class77_1, Class52.Class77.class77_0);
    }

    public Task method_2(GInterface0 ginterface0_0, GInterface1 ginterface1_0, CancellationToken cancellationToken_0 = default)
    {
        lock (object_0)
        {
            if (task_1 != null)
            {
                throw new OperationCanceledException();
            }
            while (bool_0)
            {
                Monitor.Wait(object_0);
                if (task_1 != null)
                {
                    throw new OperationCanceledException();
                }
            }
            bool_0 = true;
        }
        Task task = Task.Run(async delegate
        {
            if (Class52.Struct21.smethod_1(class73_0.method_9(new Class17(ginterface1_0), new Class16(ginterface0_0), null, Class52.Class77.class77_1, Class52.Class77.class77_0), Class52.Struct21_0))
            {
                throw new InvalidOperationException();
            }
            await ginterface1_0.imethod_2().ConfigureAwait(continueOnCapturedContext: false);
        }, cancellationToken_0);
        task_0 = task.ContinueWith(delegate
        {
            lock (object_0)
            {
                bool_0 = false;
                Monitor.PulseAll(object_0);
            }
        }, CancellationToken.None, TaskContinuationOptions.DenyChildAttach, TaskScheduler.Default);
        return task;
    }

    [CompilerGenerated]
    private void method_3(Task task_2)
    {
        lock (object_0)
        {
            method_1();
        }
    }
}
