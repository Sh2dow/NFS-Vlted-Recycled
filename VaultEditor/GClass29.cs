using System;
using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

public sealed class GClass29
{
    private readonly GClass37 gclass37_0;

    private readonly List<GClass35> list_0;

    private readonly List<GClass36> list_1;

    private bool bool_0;

    public int Int32_0 => list_0.Count;

    public int Int32_1 => list_1.Count;

    public GClass29()
    {
        gclass37_0 = new GClass37(this);
        list_0 = [];
        list_1 = [];
    }

    public GClass35 method_0(int int_0)
    {
        if (int_0 < 0 || int_0 >= list_0.Count)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return list_0[int_0];
    }

    public GClass36 method_1(int int_0)
    {
        if (int_0 < 0 || int_0 >= list_1.Count)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return list_1[int_0];
    }

    public GClass37 method_2()
    {
        return gclass37_0;
    }

    private void method_3()
    {
        if (bool_0)
        {
            throw new InvalidOperationException("Complete encoder definitions cannot be modified.");
        }
    }

    public GClass35 method_4(GClass30 gclass30_0)
    {
        if (gclass30_0 == null)
        {
            throw new ArgumentNullException("settings");
        }
        method_3();
        GClass35 gClass = new(this, list_0.Count, gclass30_0);
        list_0.Add(gClass);
        return gClass;
    }

    public GClass36 method_5()
    {
        method_3();
        GClass36 gClass = new(this, list_1.Count);
        list_1.Add(gClass);
        return gClass;
    }

    public void method_6(GClass37 gclass37_1, GClass36 gclass36_0)
    {
        if (gclass37_1 == null)
        {
            throw new ArgumentNullException("source");
        }
        if (gclass36_0 == null)
        {
            throw new ArgumentNullException("target");
        }
        if (gclass37_1.Definition != this)
        {
            throw new ArgumentException("Data source belongs to a different encoder definition.", "source");
        }
        if (gclass36_0.Definition != this)
        {
            throw new ArgumentException("Data target belongs to a different encoder definition.", "target");
        }
        if (gclass37_1.Boolean_1)
        {
            throw new ArgumentException("Data source is already connected.", "source");
        }
        if (gclass36_0.Boolean_1)
        {
            throw new ArgumentException("Data target is already connected.", "target");
        }
        method_3();
        gclass37_1.method_0(gclass36_0);
        gclass36_0.method_0(gclass37_1);
    }

    public void method_7()
    {
        if (bool_0)
        {
            return;
        }
        if (list_0.Count == 0)
        {
            throw new InvalidOperationException("No encoders defined.");
        }
        if (!gclass37_0.Boolean_1)
        {
            throw new InvalidOperationException("Content source not connected.");
        }
        for (int i = 0; i < list_0.Count; i++)
        {
            GClass35 gClass = list_0[i];
            for (int j = 0; j < gClass.Int32_0; j++)
            {
                if (!gClass.method_0(j).Boolean_1)
                {
                    throw new InvalidOperationException($"Missing input connection #{j} for encoder #{i}.");
                }
            }
            for (int k = 0; k < gClass.Int32_1; k++)
            {
                if (!gClass.method_1(k).Boolean_1)
                {
                    throw new InvalidOperationException($"Missing output connection #{k} for encoder #{i}.");
                }
            }
        }
        bool_0 = true;
    }

    internal GClass38 method_8(GClass24 gclass24_0, int int_0, Stream[] stream_0, bool bool_1)
    {
        if (!bool_0)
        {
            throw new InvalidOperationException("Incomplete ArchiveEncoderDefinition.");
        }
        if (stream_0 == null)
        {
            throw new ArgumentNullException("storage");
        }
        if (stream_0.Length != list_1.Count)
        {
            throw new ArgumentException("Number of provided storage streams does not match number of declared storage streams.", "storage");
        }
        Class40[] array = new Class40[stream_0.Length];
        for (int i = 0; i < stream_0.Length; i++)
        {
            array[i] = new Class40(stream_0[i], bool_1);
        }
        int num = 0;
        int[] array2 = new int[list_0.Count];
        for (int j = 0; j < list_0.Count; j++)
        {
            array2[j] = num;
            num += list_0[j].Int32_0;
        }
        GClass36 target = gclass37_0.Target;
        int num2 = array2[target.Node.Index] + target.Index;
        Class39 @class = new(bool_1: true);
        Class41[] array3 = new Class41[num];
        for (int k = 0; k < num; k++)
        {
            if (k != num2)
            {
                array3[k] = new Class41();
            }
        }
        Class42[] array4 = new Class42[list_0.Count];
        for (int l = 0; l < list_0.Count; l++)
        {
            GClass30 settings = list_0[l].Settings;
            Class42 class42_ = (array4[l] = settings.vmethod_1());
            int num3 = settings.method_0();
            for (int m = 0; m < num3; m++)
            {
                if (list_0[l].method_0(m).Source.Boolean_0)
                {
                    @class.method_4(class42_, m);
                }
                else
                {
                    array3[array2[l] + m].method_2(class42_, m);
                }
            }
            int num4 = settings.method_1();
            for (int n = 0; n < num4; n++)
            {
                GClass36 target2 = list_0[l].method_1(n).Target;
                if (target2.Boolean_0)
                {
                    array[target2.Index].method_3(class42_, n);
                }
                else
                {
                    array3[array2[target2.Node.Index] + target2.Index].method_3(class42_, n);
                }
            }
        }
        GClass38 result = new(gclass24_0, int_0, this, @class, array, array3, array4);
        @class.method_5();
        Class40[] array5 = array;
        for (int num5 = 0; num5 < array5.Length; num5++)
        {
            array5[num5].method_4();
        }
        Class41[] array6 = array3;
        for (int num5 = 0; num5 < array6.Length; num5++)
        {
            array6[num5]?.method_4();
        }
        Class42[] array7 = array4;
        for (int num5 = 0; num5 < array7.Length; num5++)
        {
            array7[num5].vmethod_0();
        }
        return result;
    }
}
