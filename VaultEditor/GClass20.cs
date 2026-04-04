using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace VaultEditor;

public abstract class GClass20
{
    private sealed class Class36 : IDisposable
    {
        private GClass20 gclass20_0;

        private readonly Class36 class36_0;

        private Stream stream_0;

        private byte[] byte_0 = new byte[16384];

        private int int_0;

        private int int_1;

        public Class36(GClass20 gclass20_1)
        {
            gclass20_0 = gclass20_1;
            class36_0 = gclass20_1.class36_0;
            gclass20_1.class36_0 = this;
        }

        public void Dispose()
        {
            gclass20_0.class36_0 = class36_0;
            gclass20_0 = null;
        }

        public void method_0(Stream stream_1)
        {
            stream_1.Position = 0L;
            stream_0 = stream_1;
        }

        private void method_1(int int_2)
        {
            if (int_1 - int_0 < int_2)
            {
                method_2(int_2);
            }
        }

        private void method_2(int int_2)
        {
            byte[] dst = ((int_2 <= byte_0.Length) ? byte_0 : new byte[Math.Max(byte_0.Length * 2, int_2)]);
            if (int_0 < int_1)
            {
                Buffer.BlockCopy(byte_0, int_0, dst, 0, int_1 - int_0);
            }
            int_1 -= int_0;
            int_0 = 0;
            byte_0 = dst;
            while (true)
            {
                if (int_1 < int_2)
                {
                    int num = stream_0.Read(byte_0, int_1, byte_0.Length - int_1);
                    if (num <= 0)
                    {
                        break;
                    }
                    int_1 += num;
                    continue;
                }
                return;
            }
            throw new EndOfStreamException();
        }

        public long method_3()
        {
            return stream_0.Position - (int_1 - int_0);
        }

        public byte method_4()
        {
            method_1(1);
            return byte_0[int_0++];
        }

        public uint method_5()
        {
            method_1(4);
            int result = smethod_2(byte_0, int_0);
            int_0 += 4;
            return (uint)result;
        }

        public ulong method_6()
        {
            method_1(8);
            long result = smethod_3(byte_0, int_0);
            int_0 += 8;
            return (ulong)result;
        }

        public ulong method_7()
        {
            byte b = method_4();
            byte b2 = 128;
            ulong num = 0uL;
            int num2 = 0;
            while (true)
            {
                if (num2 < 8)
                {
                    if ((b & b2) == 0)
                    {
                        break;
                    }
                    method_1(1);
                    num |= (ulong)method_4() << 8 * num2;
                    b2 >>= 1;
                    num2++;
                    continue;
                }
                return num;
            }
            ulong num3 = (uint)(b & (b2 - 1));
            return num + (num3 << num2 * 8);
        }

        public string method_8()
        {
            int num = 0;
            while (true)
            {
                method_1(num + 2);
                if (byte_0[int_0 + num] == 0 && byte_0[int_0 + num + 1] == 0)
                {
                    break;
                }
                num += 2;
            }
            string result = Encoding.Unicode.GetString(byte_0, int_0, num);
            int_0 += num + 2;
            return result;
        }

        public void method_9(long long_0)
        {
            if (long_0 < 0L)
            {
                throw new InvalidDataException();
            }
            if (long_0 < int_1 - int_0)
            {
                int_0 += (int)long_0;
                return;
            }
            long num = method_3();
            if (long_0 > stream_0.Length - num)
            {
                throw new InvalidDataException();
            }
            int_1 = 0;
            int_0 = 0;
            stream_0.Seek(num + long_0, SeekOrigin.Current);
        }
    }

    private GClass1 gclass1_0;

    private Class36 class36_0;

    private Stream stream_0;

    private long long_0;

    private byte byte_0;

    private byte byte_1;

    private GStruct0 gstruct0_0;

    private long long_1;

    private long long_2;

    [CompilerGenerated]
    private bool bool_0;

    public bool EnablePosixFileAttributeExtension
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public static byte[] Byte_0 => Class33.byte_0;

    public static bool smethod_0(Stream stream_1)
    {
        if (stream_1 == null)
        {
            throw new ArgumentNullException("stream");
        }
        if (!stream_1.CanRead)
        {
            throw new InvalidOperationException("Stream must be readable.");
        }
        return smethod_1(stream_1, stream_1.CanSeek ? stream_1.Length : long.MaxValue, out byte byte_, out byte byte_2, out long long_, out long long_2, out GStruct0 gstruct0_) == null;
    }

    private static Exception smethod_1(Stream stream_1, long long_3, out byte byte_2, out byte byte_3, out long long_4, out long long_5, out GStruct0 gstruct0_1)
    {
        byte_2 = 0;
        byte_3 = 0;
        long_4 = 0L;
        long_5 = 0L;
        gstruct0_1 = default;
        byte[] array = new byte[32];
        int num = 0;
        do
        {
            int num2 = stream_1.Read(array, num, 32 - num);
            if (num2 > 0)
            {
                num += num2;
                continue;
            }
            return new EndOfStreamException();
        }
        while (num < 32);
        int num3 = 0;
        while (true)
        {
            if (num3 < 6)
            {
                if (array[num3] != Class33.byte_0[num3])
                {
                    break;
                }
                num3++;
                continue;
            }
            byte_2 = array[6];
            byte_3 = array[7];
            if (byte_2 != 0)
            {
                return new InvalidDataException("Invalid header version.");
            }
            long_4 = smethod_3(array, 12);
            long_5 = smethod_3(array, 20);
            gstruct0_1 = new GStruct0(smethod_2(array, 28));
            if (Class14.smethod_1(Class14.smethod_4(Class14.smethod_6(Class14.smethod_6(uint.MaxValue, long_4), long_5), gstruct0_1.int_0)) != (uint)smethod_2(array, 8))
            {
                return new InvalidDataException("Invalid header checksum.");
            }
            if (long_4 >= array.Length && long_4 <= long_3 - 32L)
            {
                if (long_5 >= 0L && long_5 <= long_3 - 32L - long_4)
                {
                    return null;
                }
                return new InvalidDataException("Invalid metadata length.");
            }
            return new InvalidDataException("Invalid metadata offset.");
        }
        return new InvalidDataException("File is not a 7z archive.");
    }

    private static int smethod_2(byte[] byte_2, int int_0)
    {
        return byte_2[int_0] | (byte_2[int_0 + 1] << 8) | (byte_2[int_0 + 2] << 16) | (byte_2[int_0 + 3] << 24);
    }

    private static long smethod_3(byte[] byte_2, int int_0)
    {
        return (long)(byte_2[int_0] | ((ulong)byte_2[int_0 + 1] << 8) | ((ulong)byte_2[int_0 + 2] << 16) | ((ulong)byte_2[int_0 + 3] << 24) | ((ulong)byte_2[int_0 + 4] << 32) | ((ulong)byte_2[int_0 + 5] << 40) | ((ulong)byte_2[int_0 + 6] << 48) | ((ulong)byte_2[int_0 + 7] << 56));
    }

    protected GClass11 method_0(Stream stream_1, GClass1 gclass1_1)
    {
        if (stream_1 == null)
        {
            throw new ArgumentNullException("stream");
        }
        if (stream_1.CanRead && stream_1.CanSeek)
        {
            if (stream_0 != null)
            {
                throw new InvalidOperationException("Recursive invocation.");
            }
            try
            {
                gclass1_0 = gclass1_1;
                stream_0 = stream_1;
                stream_0.Position = 0L;
                long_0 = stream_1.Length;
                Exception ex = smethod_1(stream_0, long_0, out byte_0, out byte_1, out long_1, out long_2, out gstruct0_0);
                if (ex != null)
                {
                    throw ex;
                }
                if (long_2 != 0L)
                {
                    using Stream0 stream_2 = new(stream_0, 32L + long_1, long_2);
                    using Class36 @class = new(this);
                    @class.method_0(stream_2);
                    if (!method_1(@class))
                    {
                        return new GClass11();
                    }
                    return method_2();
                }
                return new GClass11();
            }
            finally
            {
                gclass1_0 = null;
                stream_0 = null;
            }
        }
        throw new InvalidOperationException("Stream must support reading and seeking.");
    }

    protected virtual void vmethod_0(int int_0)
    {
    }

    protected virtual void vmethod_1(GClass15 gclass15_0)
    {
    }

    protected virtual void vmethod_2(GClass18 gclass18_0)
    {
    }

    protected virtual void vmethod_3(GClass17 gclass17_0)
    {
    }

    protected virtual void vmethod_4(GClass19 gclass19_0)
    {
    }

    protected virtual void vmethod_5(GClass19 gclass19_0)
    {
    }

    protected virtual void vmethod_6(GClass19 gclass19_0)
    {
    }

    protected virtual void vmethod_7(GClass16 gclass16_0)
    {
    }

    protected virtual void vmethod_8(GClass16 gclass16_0)
    {
    }

    protected virtual void vmethod_9(GClass16 gclass16_0)
    {
    }

    private bool method_1(Class36 class36_1)
    {
        Enum0 @enum = method_26();
        if (@enum == Enum0.const_24)
        {
            IList<Stream> list = method_3();
            if (list == null || !list.Any())
            {
                return false;
            }
            class36_1.method_0(list[0]);
            @enum = method_26();
        }
        if (@enum != Enum0.const_2)
        {
            throw new InvalidDataException();
        }
        return true;
    }

    private GClass11 method_2()
    {
        Enum0 @enum = method_26();
        if (@enum == Enum0.const_3)
        {
            method_11();
            @enum = method_26();
        }
        IList<Stream> ilist_ = [];
        if (@enum == Enum0.const_4)
        {
            ilist_ = method_3();
            @enum = method_26();
        }
        if (@enum == Enum0.const_5)
        {
            GClass11 result = method_5(ilist_, bool_1: true);
            @enum = method_26();
            int? num = null;
            switch (@enum)
            {
                default:
                    throw new InvalidDataException();
                case Enum0.const_6:
                    {
                        int num2 = method_24();
                        vmethod_0(num2);
                        while (true)
                        {
                            @enum = method_26();
                            if (@enum == Enum0.const_1)
                            {
                                break;
                            }
                            long num3 = (long)method_22();
                            if (num3 >= 0L)
                            {
                                long num4 = method_18();
                                switch (@enum)
                                {
                                    case Enum0.const_15:
                                        {
                                            Struct6 struct6_6 = method_12(num2);
                                            num = struct6_6.method_0();
                                            GClass19 gClass9 = new(this, struct6_6);
                                            vmethod_4(gClass9);
                                            gClass9.method_0();
                                            goto default;
                                        }
                                    case Enum0.const_16:
                                        if (num.HasValue)
                                        {
                                            GClass19 gClass = new(this, method_12(num.Value));
                                            vmethod_5(gClass);
                                            gClass.method_0();
                                            goto default;
                                        }
                                        throw new InvalidDataException();
                                    case Enum0.const_17:
                                        if (num.HasValue)
                                        {
                                            GClass19 gClass8 = new(this, method_12(num.Value));
                                            vmethod_6(gClass8);
                                            gClass8.method_0();
                                            goto default;
                                        }
                                        throw new InvalidDataException();
                                    case Enum0.const_18:
                                        using (method_25(ilist_))
                                        {
                                            GClass15 gClass7 = new(this, num2);
                                            vmethod_1(gClass7);
                                            gClass7.method_0();
                                        }
                                        goto default;
                                    case Enum0.const_19:
                                        {
                                            Struct6 struct6_5 = method_13(num2);
                                            using (method_25(ilist_))
                                            {
                                                GClass16 gClass6 = new(this, num2, struct6_5);
                                                vmethod_7(gClass6);
                                                gClass6.method_0();
                                            }
                                            goto default;
                                        }
                                    case Enum0.const_20:
                                        {
                                            Struct6 struct6_4 = method_13(num2);
                                            using (method_25(ilist_))
                                            {
                                                GClass16 gClass5 = new(this, num2, struct6_4);
                                                vmethod_8(gClass5);
                                                gClass5.method_0();
                                            }
                                            goto default;
                                        }
                                    case Enum0.const_21:
                                        {
                                            Struct6 struct6_3 = method_13(num2);
                                            using (method_25(ilist_))
                                            {
                                                GClass16 gClass4 = new(this, num2, struct6_3);
                                                vmethod_9(gClass4);
                                                gClass4.method_0();
                                            }
                                            goto default;
                                        }
                                    case Enum0.const_22:
                                        {
                                            Struct6 struct6_2 = method_13(num2);
                                            using (method_25(ilist_))
                                            {
                                                GClass18 gClass3 = new(this, num2, struct6_2, EnablePosixFileAttributeExtension);
                                                vmethod_2(gClass3);
                                                gClass3.method_0();
                                            }
                                            goto default;
                                        }
                                    case Enum0.const_25:
                                        {
                                            Struct6 struct6_ = method_13(num2);
                                            using (method_25(ilist_))
                                            {
                                                GClass17 gClass2 = new(this, num2, struct6_);
                                                vmethod_3(gClass2);
                                                gClass2.method_0();
                                            }
                                            goto default;
                                        }
                                    case Enum0.const_26:
                                        {
                                            for (int i = 0; i < num3; i++)
                                            {
                                                if (method_19() != 0)
                                                {
                                                    throw new InvalidDataException();
                                                }
                                            }
                                            goto default;
                                        }
                                    default:
                                        if ((byte_0 != 0 || byte_1 >= 3) && method_18() - num4 != num3)
                                        {
                                            throw new InvalidDataException();
                                        }
                                        break;
                                }
                                continue;
                            }
                            throw new InvalidDataException();
                        }
                        break;
                    }
                case Enum0.const_1:
                    break;
            }
            return result;
        }
        throw new NotImplementedException();
    }

    private IList<Stream> method_3()
    {
        GClass11 gClass = method_5([], bool_1: false);
        int count = gClass.DecoderSections.Count;
        List<Stream> list = [];
        for (int i = 0; i < count; i++)
        {
            list.Add(method_4(gClass, i));
        }
        return list;
    }

    private Stream method_4(GClass11 gclass11_0, int int_0)
    {
        MemoryStream memoryStream = new();
        using (GClass23 gClass = new(stream_0, gclass11_0, int_0, gclass1_0))
        {
            using Stream stream = gClass.method_0();
            stream.CopyTo(memoryStream);
        }
        memoryStream.Position = 0L;
        return memoryStream;
    }

    private GClass11 method_5(IList<Stream> ilist_0, bool bool_1)
    {
        IList<GClass12> ilist_1 = null;
        Class34[] array = null;
        while (true)
        {
            switch (method_26())
            {
                case Enum0.const_7:
                    ilist_1 = method_6();
                    break;
                case Enum0.const_8:
                    array = method_7(ilist_0);
                    break;
                case Enum0.const_9:
                    if (array != null)
                    {
                        method_8(array);
                        break;
                    }
                    throw new InvalidDataException();
                default:
                    throw new InvalidDataException();
                case Enum0.const_1:
                    {
                        if (array == null)
                        {
                            throw new InvalidDataException();
                        }
                        List<GClass13> list = [];
                        Class34[] array2 = array;
                        foreach (Class34 @class in array2)
                        {
                            List<GClass14> list2 = [];
                            Class35[] class35_ = @class.class35_0;
                            foreach (Class35 class2 in class35_)
                            {
                                list2.Add(new GClass14(class2.gstruct6_0, class2.byte_0, class2.ilist_0, class2.ilist_1));
                            }
                            if (@class.gstruct2_0 == null && !@class.nullable_1.HasValue)
                            {
                                @class.nullable_1 = 1;
                                @class.gstruct2_0 =
                                [
                            new(@class.long_0, @class.nullable_0)
                                ];
                            }
                            list.Add(new GClass13(list2, @class.gstruct4_0, @class.long_0, @class.nullable_0, @class.gstruct2_0));
                        }
                        return new GClass11(ilist_1, list);
                    }
            }
        }
    }

    private IList<GClass12> method_6()
    {
        long num = method_23() + 32L;
        if (num < 0L)
        {
            throw new InvalidDataException();
        }
        int num2 = method_24();
        method_27(Enum0.const_10);
        long[] array = new long[num2];
        for (int i = 0; i < num2; i++)
        {
            array[i] = method_23();
        }
        IList<GClass12> list = null;
        while (true)
        {
            switch (method_26())
            {
                default:
                    method_28();
                    break;
                case Enum0.const_11:
                    {
                        Struct6 @struct = method_13(num2);
                        long num5 = num;
                        list = [];
                        for (int k = 0; k < num2; k++)
                        {
                            long num6 = array[k];
                            GStruct0? nullable_ = null;
                            if (@struct[k])
                            {
                                nullable_ = new GStruct0(method_20());
                            }
                            list.Add(new GClass12(num5, num6, nullable_));
                            num5 += num6;
                        }
                        break;
                    }
                case Enum0.const_1:
                    if (list == null)
                    {
                        long num3 = num;
                        list = [];
                        for (int j = 0; j < num2; j++)
                        {
                            long num4 = array[j];
                            list.Add(new GClass12(num3, num4, null));
                            num3 += num4;
                        }
                    }
                    return list;
            }
        }
    }

    private Class34[] method_7(IList<Stream> ilist_0)
    {
        method_27(Enum0.const_12);
        int num = method_24();
        Class34[] array = new Class34[num];
        int num2 = 0;
        using (method_25(ilist_0))
        {
            for (int i = 0; i < num; i++)
            {
                Class34 @class = method_9(num2);
                num2 += @class.int_0;
                array[i] = @class;
            }
        }
        method_27(Enum0.const_13);
        Class34[] array2 = array;
        foreach (Class34 class2 in array2)
        {
            for (int k = 0; k < class2.class35_0.Length; k++)
            {
                Class35 class3 = class2.class35_0[k];
                int int_ = class3.int_1;
                List<GStruct5> list = [];
                for (int l = 0; l < int_; l++)
                {
                    long num3 = method_23();
                    list.Add(new GStruct5(num3));
                    if (GStruct4.smethod_0(gstruct4_1: new GStruct4(k, l), gstruct4_0: class2.gstruct4_0))
                    {
                        class2.long_0 = num3;
                    }
                }
                class3.ilist_1 = list;
            }
        }
        while (true)
        {
            switch (method_26())
            {
                case Enum0.const_11:
                    {
                        Struct6 @struct = method_13(num);
                        for (int m = 0; m < num; m++)
                        {
                            if (@struct[m])
                            {
                                array[m].nullable_0 = new GStruct0(method_20());
                            }
                            else
                            {
                                array[m].nullable_0 = null;
                            }
                        }
                        break;
                    }
                default:
                    method_28();
                    break;
                case Enum0.const_1:
                    return array;
            }
        }
    }

    private void method_8(Class34[] class34_0)
    {
        bool flag = false;
        while (true)
        {
            Enum0 @enum = method_26();
            switch (@enum)
            {
                case Enum0.const_14:
                    {
                        flag = true;
                        Class34[] array = class34_0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i].nullable_1 = method_24();
                        }
                        break;
                    }
                default:
                    method_28();
                    break;
                case Enum0.const_1:
                case Enum0.const_10:
                case Enum0.const_11:
                    {
                        int i;
                        Class34[] array;
                        if (!flag)
                        {
                            array = class34_0;
                            for (i = 0; i < array.Length; i++)
                            {
                                array[i].nullable_1 = 1;
                            }
                        }
                        array = class34_0;
                        i = 0;
                        while (true)
                        {
                            if (i < array.Length)
                            {
                                Class34 @class = array[i];
                                if (@class.nullable_1.Value != 0)
                                {
                                    long num = @class.long_0;
                                    GStruct2[] array2 = new GStruct2[@class.nullable_1.Value];
                                    for (int j = 0; j < array2.Length - 1; j++)
                                    {
                                        if (@enum == Enum0.const_10)
                                        {
                                            long num2 = method_23();
                                            if (num2 == 0L || num2 >= num)
                                            {
                                                throw new InvalidDataException();
                                            }
                                            array2[j] = new GStruct2(num2, null);
                                            num -= num2;
                                        }
                                    }
                                    if (num == 0L)
                                    {
                                        throw new InvalidDataException();
                                    }
                                    array2[array2.Length - 1] = new GStruct2(num, null);
                                    @class.gstruct2_0 = array2;
                                }
                                i++;
                                continue;
                            }
                            if (@enum == Enum0.const_10)
                            {
                                @enum = method_26();
                            }
                            int num3 = 0;
                            int num4 = 0;
                            IList<GStruct0?> list = null;
                            array = class34_0;
                            foreach (Class34 class2 in array)
                            {
                                if (class2.nullable_1 != 1 || !class2.nullable_0.HasValue)
                                {
                                    num3 += class2.nullable_1.Value;
                                }
                                num4 += class2.nullable_1.Value;
                            }
                            while (true)
                            {
                                switch (@enum)
                                {
                                    case Enum0.const_11:
                                        {
                                            list = [];
                                            Struct6 @struct = method_13(num3);
                                            int num5 = 0;
                                            array = class34_0;
                                            foreach (Class34 class3 in array)
                                            {
                                                if (class3.nullable_1 == 1 && class3.nullable_0.HasValue)
                                                {
                                                    list.Add(class3.nullable_0.Value);
                                                    continue;
                                                }
                                                for (int l = 0; l < class3.nullable_1; l++)
                                                {
                                                    if (@struct[num5++])
                                                    {
                                                        list.Add(new GStruct0(method_20()));
                                                    }
                                                    else
                                                    {
                                                        list.Add(null);
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                    default:
                                        method_28();
                                        break;
                                    case Enum0.const_1:
                                        if (list == null)
                                        {
                                            list = [];
                                            for (int k = 0; k < num4; k++)
                                            {
                                                list.Add(null);
                                            }
                                        }
                                        return;
                                }
                                @enum = method_26();
                            }
                        }
                    }
            }
        }
    }

    private Class34 method_9(int int_0)
    {
        Class34 @class = new();
        int num = 0;
        int num2 = 0;
        int num3 = method_24();
        if (num3 == 0)
        {
            throw new InvalidDataException();
        }
        @class.class35_0 = new Class35[num3];
        for (int i = 0; i < num3; i++)
        {
            Class35 class2 = method_10();
            num += class2.int_0;
            num2 += class2.int_1;
            @class.class35_0[i] = class2;
        }
        bool[] array = new bool[num2];
        int num4 = 1;
        while (true)
        {
            if (num4 < num2)
            {
                int num5 = method_24();
                int num6 = 0;
                while (true)
                {
                    if (num6 != num3)
                    {
                        if (num5 < @class.class35_0[num6].int_0)
                        {
                            break;
                        }
                        num5 -= @class.class35_0[num6].int_1;
                        num6++;
                        continue;
                    }
                    throw new InvalidDataException();
                }
                int num7 = method_24();
                if (num7 < num2 && !array[num7])
                {
                    array[num7] = true;
                    int num8 = 0;
                    while (true)
                    {
                        if (num8 != num3)
                        {
                            int int_1 = @class.class35_0[num8].int_1;
                            if (num7 < int_1)
                            {
                                break;
                            }
                            num7 -= int_1;
                            num8++;
                            continue;
                        }
                        throw new InvalidDataException();
                    }
                    if (@class.class35_0[num6].ilist_0[num5].Int32_0 == int.MaxValue)
                    {
                        @class.class35_0[num6].ilist_0[num5] = new GStruct4(num8, num7);
                        num4++;
                        continue;
                    }
                    throw new InvalidDataException();
                }
                throw new InvalidDataException();
            }
            bool flag = false;
            int num9 = 0;
            for (int j = 0; j < num3; j++)
            {
                Class35 class3 = @class.class35_0[j];
                for (int k = 0; k < class3.int_1; k++)
                {
                    if (!array[num9++])
                    {
                        if (flag)
                        {
                            throw new InvalidDataException();
                        }
                        flag = true;
                        @class.gstruct4_0 = new GStruct4(j, k);
                    }
                }
            }
            if (!flag)
            {
                throw new InvalidDataException();
            }
            int num10 = 1 + num - num2;
            if (num10 <= 0)
            {
                throw new InvalidDataException();
            }
            @class.int_0 = num10;
            if (num10 == 1)
            {
                bool flag2 = false;
                Class35[] class35_ = @class.class35_0;
                foreach (Class35 class4 in class35_)
                {
                    for (int m = 0; m < class4.int_0; m++)
                    {
                        if (class4.ilist_0[m].Int32_0 == int.MaxValue)
                        {
                            if (flag2)
                            {
                                throw new InvalidDataException();
                            }
                            flag2 = true;
                            class4.ilist_0[m] = new GStruct4(null, 0);
                        }
                    }
                }
                if (flag2)
                {
                    break;
                }
                throw new InvalidDataException();
            }
            for (int n = 0; n < num10; n++)
            {
                int num11 = method_24();
                int num12 = 0;
                while (true)
                {
                    if (num12 != num3)
                    {
                        Class35 class5 = @class.class35_0[num12];
                        if (num11 < class5.int_0)
                        {
                            break;
                        }
                        num11 -= class5.int_1;
                        num12++;
                        continue;
                    }
                    throw new InvalidDataException();
                }
                IList<GStruct4> ilist_ = @class.class35_0[num12].ilist_0;
                if (ilist_[num11].Int32_0 == int.MaxValue)
                {
                    ilist_[num11] = new GStruct4(null, int_0 + n);
                    continue;
                }
                throw new InvalidDataException();
            }
            break;
        }
        return @class;
    }

    private Class35 method_10()
    {
        Class35 @class = new();
        byte b = method_19();
        if ((b & 0x80) != 0)
        {
            throw new NotImplementedException();
        }
        int num = b & 0xF;
        if (num > 4)
        {
            throw new InvalidDataException();
        }
        int num2 = 0;
        for (int num3 = num - 1; num3 >= 0; num3--)
        {
            num2 |= method_19() << num3 * 8;
        }
        @class.gstruct6_0 = GStruct6.smethod_0(num2);
        if (@class.gstruct6_0.Boolean_0)
        {
            throw new InvalidDataException();
        }
        if ((b & 0x10) != 0)
        {
            @class.int_0 = method_24();
            @class.int_1 = method_24();
        }
        else
        {
            @class.int_0 = 1;
            @class.int_1 = 1;
        }
        @class.gstruct6_0.method_1(@class.int_0, @class.int_1);
        @class.ilist_0 = [];
        GStruct4 item = new(int.MaxValue, int.MaxValue);
        for (int i = 0; i < @class.int_0; i++)
        {
            @class.ilist_0.Add(item);
        }
        if ((b & 0x20) != 0)
        {
            int num4 = method_24();
            List<byte> list = [];
            for (int j = 0; j < num4; j++)
            {
                list.Add(method_19());
            }
            @class.byte_0 = [.. list];
        }
        else
        {
            @class.byte_0 = [];
        }
        return @class;
    }

    private void method_11()
    {
        throw new NotImplementedException();
    }

    private Struct6 method_12(int int_0)
    {
        byte[] array = new byte[int_0 + 7 >> 3];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = method_19();
        }
        return new Struct6(int_0, array);
    }

    private Struct6 method_13(int int_0)
    {
        if (method_19() != 0)
        {
            return new Struct6(int_0, bool_1: true);
        }
        return method_12(int_0);
    }

    internal long method_14()
    {
        return method_20();
    }

    internal long method_15()
    {
        return method_21();
    }

    internal long method_16()
    {
        return method_23();
    }

    internal string method_17()
    {
        return class36_0.method_8();
    }

    private long method_18()
    {
        return class36_0.method_3();
    }

    private byte method_19()
    {
        return class36_0.method_4();
    }

    private int method_20()
    {
        return (int)class36_0.method_5();
    }

    private long method_21()
    {
        return (long)class36_0.method_6();
    }

    private ulong method_22()
    {
        return class36_0.method_7();
    }

    private long method_23()
    {
        ulong num = method_22();
        if ((long)num < 0L)
        {
            throw new InvalidDataException();
        }
        return (long)num;
    }

    private int method_24()
    {
        ulong num = method_22();
        if (num > 2147483647L)
        {
            throw new InvalidDataException();
        }
        return (int)num;
    }

    private Class36 method_25(IList<Stream> ilist_0)
    {
        if (method_19() == 0)
        {
            return null;
        }
        int num = method_24();
        if (num < 0 || num >= ilist_0.Count)
        {
            throw new InvalidDataException();
        }
        Stream stream_ = ilist_0[num];
        Class36 @class = new(this);
        @class.method_0(stream_);
        return @class;
    }

    private Enum0 method_26()
    {
        ulong num = method_22();
        if (num > 25L)
        {
            return Enum0.const_0;
        }
        return (Enum0)num;
    }

    private void method_27(Enum0 enum0_0)
    {
        while (method_26() != enum0_0)
        {
            method_28();
        }
    }

    private void method_28()
    {
        class36_0.method_9(method_23());
    }
}
