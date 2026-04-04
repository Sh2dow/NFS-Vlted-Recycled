using System;
using System.Threading.Tasks;

namespace VaultEditor;

internal sealed class Class46(GClass43 gclass43_0) : Class42
{
    private readonly GClass42 gclass42_0 = new GClass42(gclass43_0);

    private Task task_0;

    private GInterface0 ginterface0_0;

    private GInterface1 ginterface1_0;

    public override GInterface1 vmethod_1(int int_0)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return null;
    }

    public override void vmethod_2(int int_0, GInterface0 ginterface0_1)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        if (ginterface0_0 != null)
        {
            throw new InvalidOperationException();
        }
        ginterface0_0 = ginterface0_1 ?? throw new ArgumentNullException("stream");
    }

    public override GInterface0 vmethod_3(int int_0)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return null;
    }

    public override void vmethod_4(int int_0, GInterface1 ginterface1_1)
    {
        if (int_0 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }

        if (ginterface1_0 != null)
        {
            throw new InvalidOperationException();
        }
        ginterface1_0 = ginterface1_1 ?? throw new ArgumentNullException("stream");
    }

    public override void vmethod_0()
    {
        if (task_0 != null)
        {
            throw new InvalidOperationException();
        }
        task_0 = gclass42_0.method_2(ginterface0_0, ginterface1_0);
    }

    public override void Dispose()
    {
        gclass42_0.Dispose();
        try
        {
            task_0?.GetAwaiter().GetResult();
        }
        catch (OperationCanceledException)
        {
        }
    }
}
