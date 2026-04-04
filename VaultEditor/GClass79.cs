using System;

namespace VaultEditor;

public sealed class GClass79<T>(int int_2)
{
    private T[] gparam_0 = new T[int_2];

    private int int_0 = 0;

    private int int_1 = 0;

    public int Int32_0 => gparam_0.Length;

    public int Int32_1 => int_0;

    private int Int32_2 => (int_1 + int_0 - 1) % gparam_0.Length;

    public T method_0()
    {
        if (int_0 == 0)
        {
            throw new Exception("Stack is empty");
        }
        int int32_ = Int32_2;
        T result = gparam_0[int32_];
        gparam_0[int32_] = default;
        int_0--;
        return result;
    }

    public T method_1()
    {
        if (int_0 == 0)
        {
            return default;
        }
        return gparam_0[Int32_2];
    }

    public void method_2(T gparam_1)
    {
        if (int_0 == gparam_0.Length)
        {
            int_1 = (int_1 + 1) % gparam_0.Length;
        }
        else
        {
            int_0++;
        }
        gparam_0[Int32_2] = gparam_1;
    }

    public void method_3()
    {
        gparam_0 = new T[gparam_0.Length];
        int_0 = 0;
        int_1 = 0;
    }

    public T[] method_4()
    {
        T[] array = new T[int_0];
        for (int i = 0; i < int_0; i++)
        {
            array[i] = gparam_0[(int_1 + i) % gparam_0.Length];
        }
        return array;
    }
}
