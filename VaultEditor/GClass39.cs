using System;
using System.IO;

namespace VaultEditor;

public sealed class GClass39 : IDisposable
{
    private readonly GClass41 gclass41_0;

    private readonly Class52.Class64 class64_0;

    private Class52.Enum4 enum4_0;

    private int int_0;

    private readonly bool bool_0;

    private readonly bool bool_1;

    private bool bool_2;

    public int Int32_0
    {
        get
        {
            if (bool_2)
            {
                throw new ObjectDisposedException(null);
            }
            if (int_0 == class64_0.long_1)
            {
                return (int)class64_0.long_1;
            }
            return checked((int)(class64_0.long_1 - class64_0.long_0));
        }
    }

    public int Int32_1
    {
        get
        {
            if (bool_2)
            {
                throw new ObjectDisposedException(null);
            }
            return checked((int)(class64_0.long_0 - int_0));
        }
    }

    public bool Boolean_0
    {
        get
        {
            if (bool_2)
            {
                throw new ObjectDisposedException(null);
            }
            return bool_1;
        }
    }

    public GClass39(GClass41 gclass41_1)
    {
        gclass41_0 = gclass41_1;
        class64_0 = new Class52.Class64();
        class64_0.method_0();
        if (Class52.Struct21.smethod_1(class64_0.method_4(Struct0<byte>.smethod_14(gclass41_1.method_1()), 5u, Class52.Class77.class77_1), Class52.Struct21_0))
        {
            throw new InvalidOperationException();
        }
        class64_0.method_1();
    }

    public void Dispose()
    {
        if (!bool_2)
        {
            bool_2 = true;
            class64_0.method_5(Class52.Class77.class77_1);
        }
    }

    public int method_0(byte[] byte_0, int int_1, int int_2)
    {
        if (byte_0 == null && int_2 != 0)
        {
            throw new ArgumentNullException("buffer");
        }
        if (int_1 >= 0 && int_1 <= byte_0.Length)
        {
            if (int_2 >= 0 && int_2 <= byte_0.Length - int_1)
            {
                if (bool_2)
                {
                    throw new ObjectDisposedException(null);
                }
                int_2 = Math.Min(int_2, Int32_1);
                Buffer.BlockCopy(class64_0.struct0_0.gparam_0, class64_0.struct0_0.int_0 + int_0, byte_0, int_1, int_2);
                int_0 += int_2;
                return int_2;
            }
            throw new ArgumentOutOfRangeException("length");
        }
        throw new ArgumentOutOfRangeException("offset");
    }

    public int method_1(int int_1)
    {
        Class19.smethod_1();
        byte[] array = new byte[Math.Min(16384, int_1)];
        return method_0(array, 0, array.Length);
    }

    public int method_2(byte[] byte_0, int int_1, int int_2, int? nullable_0, bool bool_3)
    {
        if (byte_0 == null && int_2 != 0)
        {
            throw new ArgumentNullException("buffer");
        }
        if (int_1 >= 0 && int_1 <= byte_0.Length)
        {
            if (int_2 >= 0 && int_2 <= byte_0.Length - int_1)
            {
                if (nullable_0 < 0)
                {
                    throw new ArgumentOutOfRangeException("limit");
                }
                if (bool_2)
                {
                    throw new ObjectDisposedException(null);
                }
                if (bool_0 && !(int_2 == 0 && bool_3))
                {
                    throw new InvalidOperationException("Input has already been completed.");
                }
                Class52.Enum3 enum3_ = (bool_3 ? Class52.Enum3.const_1 : Class52.Enum3.const_0);
                if (int_0 == class64_0.long_1)
                {
                    class64_0.long_0 = 0L;
                    int_0 = 0;
                }
                long num = class64_0.long_1;
                if (nullable_0.HasValue)
                {
                    num = Math.Min(num, int_0 + nullable_0.Value);
                }
                long long_ = int_2;
                if (Class52.Struct21.smethod_1(class64_0.method_6(num, Class15.smethod_0(byte_0, int_1), ref long_, enum3_, out enum4_0), Class52.Struct21_0))
                {
                    throw new InvalidDataException();
                }
                return checked((int)long_);
            }
            throw new ArgumentOutOfRangeException("length");
        }
        throw new ArgumentOutOfRangeException("offset");
    }
}
