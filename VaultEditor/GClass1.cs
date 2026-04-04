using System;
using System.Threading;

namespace VaultEditor;

public sealed class GClass1 : IDisposable
{
    private static readonly int int_0 = 1103515245;

    private char[] char_0;

    private GClass1(char[] char_1)
    {
        smethod_0(char_0 = char_1, GetHashCode());
    }

    private static void smethod_0(char[] char_1, int int_1)
    {
        for (int i = 0; i < char_1.Length; i++)
        {
            char c = char_1[i];
            char_1[i] = (char)(c ^ int_1);
            int_1 = int_1 * int_0 + c;
        }
    }

    private static void smethod_1(char[] char_1, int int_1)
    {
        for (int i = 0; i < char_1.Length; i++)
        {
            char c = char_1[i];
            char_1[i] = (char)(c ^ int_1);
            int_1 = int_1 * int_0 + char_1[i];
        }
    }

    public static GClass1 smethod_2(string string_0)
    {
        if (string_0 == null)
        {
            throw new ArgumentNullException("password");
        }
        return new GClass1(string_0.ToCharArray());
    }

    public static GClass1 smethod_3(char[] char_1)
    {
        if (char_1 == null)
        {
            throw new ArgumentNullException("password");
        }
        char[] array = new char[char_1.Length];
        for (int i = 0; i < char_1.Length; i++)
        {
            array[i] = char_1[i];
            char_1[i] = '\0';
        }
        return new GClass1(array);
    }

    public void Dispose()
    {
        new GStruct1(Interlocked.Exchange(ref char_0, null)).Dispose();
    }

    public GStruct1 method_0()
    {
        GStruct1 gstruct1_ = default;
        try
        {
            char[] array = Volatile.Read(ref char_0);
            if (array != null)
            {
                gstruct1_ = new GStruct1((char[])array.Clone());
                if (Volatile.Read(ref char_0) != null)
                {
                    smethod_1(GStruct1.smethod_2(gstruct1_), GetHashCode());
                    return new GStruct1(GStruct1.smethod_2(gstruct1_));
                }
            }
            throw new ObjectDisposedException(null);
        }
        catch
        {
            gstruct1_.Dispose();
            throw;
        }
    }
}
