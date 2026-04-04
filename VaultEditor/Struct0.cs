using System.Runtime.CompilerServices;

namespace VaultEditor;

internal readonly struct Struct0<T>(T[] gparam_1, int int_1 = 0)
{
    public readonly T[] gparam_0 = gparam_1;

    public readonly int int_0 = int_1;

    public static Struct0<T> Struct0_0 => default;

    public bool Boolean_0 => gparam_0 == null;

    public T this[int int_1]
    {
        get
        {
            return gparam_0[int_0 + int_1];
        }
        set
        {
            gparam_0[int_0 + int_1] = value;
        }
    }

    public T this[uint uint_0]
    {
        get
        {
            return this[(int)uint_0];
        }
        set
        {
            this[(int)uint_0] = value;
        }
    }

    public T this[long long_0]
    {
        get
        {
            return this[checked((int)long_0)];
        }
        set
        {
            this[checked((int)long_0)] = value;
        }
    }

    public Struct0(T[] gparam_1, uint uint_0)
        : this(gparam_1, (int)uint_0)
    {
    }

    [SpecialName]
    public static bool smethod_0(Struct0<T> struct0_0, Struct0<T> struct0_1)
    {
        Class20.smethod_5(struct0_0.gparam_0 == struct0_1.gparam_0);
        return struct0_0.int_0 < struct0_1.int_0;
    }

    [SpecialName]
    public static bool smethod_1(Struct0<T> struct0_0, Struct0<T> struct0_1)
    {
        Class20.smethod_5(struct0_0.gparam_0 == struct0_1.gparam_0);
        return struct0_0.int_0 <= struct0_1.int_0;
    }

    [SpecialName]
    public static bool smethod_2(Struct0<T> struct0_0, Struct0<T> struct0_1)
    {
        Class20.smethod_5(struct0_0.gparam_0 == struct0_1.gparam_0);
        return struct0_0.int_0 > struct0_1.int_0;
    }

    [SpecialName]
    public static bool smethod_3(Struct0<T> struct0_0, Struct0<T> struct0_1)
    {
        Class20.smethod_5(struct0_0.gparam_0 == struct0_1.gparam_0);
        return struct0_0.int_0 >= struct0_1.int_0;
    }

    [SpecialName]
    public static int smethod_4(Struct0<T> struct0_0, Struct0<T> struct0_1)
    {
        Class20.smethod_5(struct0_0.gparam_0 == struct0_1.gparam_0);
        return struct0_0.int_0 - struct0_1.int_0;
    }

    [SpecialName]
    public static Struct0<T> smethod_5(Struct0<T> struct0_0, int int_1)
    {
        return new Struct0<T>(struct0_0.gparam_0, struct0_0.int_0 - int_1);
    }

    [SpecialName]
    public static Struct0<T> smethod_6(Struct0<T> struct0_0, int int_1)
    {
        return new Struct0<T>(struct0_0.gparam_0, struct0_0.int_0 + int_1);
    }

    [SpecialName]
    public static Struct0<T> smethod_7(Struct0<T> struct0_0, long long_0)
    {
        return new Struct0<T>(struct0_0.gparam_0, checked((int)(struct0_0.int_0 + long_0)));
    }

    [SpecialName]
    public static Struct0<T> smethod_8(int int_1, Struct0<T> struct0_0)
    {
        return new Struct0<T>(struct0_0.gparam_0, int_1 + struct0_0.int_0);
    }

    [SpecialName]
    public static Struct0<T> smethod_9(Struct0<T> struct0_0, uint uint_0)
    {
        return smethod_5(struct0_0, (int)uint_0);
    }

    [SpecialName]
    public static Struct0<T> smethod_10(Struct0<T> struct0_0, uint uint_0)
    {
        return smethod_6(struct0_0, (int)uint_0);
    }

    [SpecialName]
    public static Struct0<T> smethod_11(uint uint_0, Struct0<T> struct0_0)
    {
        return smethod_8((int)uint_0, struct0_0);
    }

    [SpecialName]
    public static Struct0<T> smethod_12(Struct0<T> struct0_0)
    {
        return new Struct0<T>(struct0_0.gparam_0, struct0_0.int_0 + 1);
    }

    [SpecialName]
    public static Struct0<T> smethod_13(Struct0<T> struct0_0)
    {
        return new Struct0<T>(struct0_0.gparam_0, struct0_0.int_0 - 1);
    }

    [SpecialName]
    public static Struct0<T> smethod_14(T[] gparam_1)
    {
        return new Struct0<T>(gparam_1);
    }

    public override int GetHashCode()
    {
        int num = int_0;
        if (gparam_0 != null)
        {
            num += gparam_0.GetHashCode();
        }
        return num;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return gparam_0 == null;
        }
        Struct0<T>? @struct = obj as Struct0<T>?;
        if (@struct.HasValue)
        {
            return smethod_15(this, @struct.Value);
        }
        return false;
    }

    public bool method_0(Struct0<T> struct0_0)
    {
        if (gparam_0 == struct0_0.gparam_0)
        {
            return int_0 == struct0_0.int_0;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_15(Struct0<T> struct0_0, Struct0<T> struct0_1)
    {
        if (struct0_0.gparam_0 == struct0_1.gparam_0)
        {
            return struct0_0.int_0 == struct0_1.int_0;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_16(Struct0<T> struct0_0, Struct0<T> struct0_1)
    {
        if (struct0_0.gparam_0 == struct0_1.gparam_0)
        {
            return struct0_0.int_0 != struct0_1.int_0;
        }
        return true;
    }
}
