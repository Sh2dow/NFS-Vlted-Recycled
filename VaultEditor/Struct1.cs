using System.Threading.Tasks;

namespace VaultEditor;

internal readonly struct Struct1<T>
{
    private readonly TaskCompletionSource<T> taskCompletionSource_0;

    public Task<T> Task_0 => taskCompletionSource_0.Task;

    private Struct1(TaskCompletionSource<T> taskCompletionSource_1)
    {
        taskCompletionSource_0 = taskCompletionSource_1;
    }

    public static Struct1<T> smethod_0()
    {
        return new Struct1<T>(new TaskCompletionSource<T>());
    }

    public void method_0()
    {
        taskCompletionSource_0.SetCanceled();
    }

    public void method_1(T gparam_0)
    {
        taskCompletionSource_0.SetResult(gparam_0);
    }
}
