using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace VaultEditor;

public sealed class GClass24 : IDisposable
{
    [CompilerGenerated]
    private sealed class Class37
    {
        public GClass26 gclass26_0;

        internal bool method_0(int int_0)
        {
            return !gclass26_0.vmethod_2(int_0);
        }

        internal bool method_1(int int_0)
        {
            return !gclass26_0.vmethod_2(int_0);
        }

        internal bool method_2(int int_0)
        {
            return !gclass26_0.vmethod_3(int_0);
        }

        internal bool method_3(int int_0)
        {
            return !gclass26_0.vmethod_2(int_0);
        }

        internal bool method_4(int int_0)
        {
            return !gclass26_0.vmethod_3(int_0);
        }

        internal bool method_5(int int_0)
        {
            return !gclass26_0.vmethod_2(int_0);
        }

        internal bool method_6(int int_0)
        {
            return gclass26_0.vmethod_4(int_0);
        }

        internal bool method_7(int int_0)
        {
            return !gclass26_0.vmethod_2(int_0);
        }

        internal bool method_8(int int_0)
        {
            return gclass26_0.vmethod_4(int_0);
        }

        internal DateTime? method_9(int int_0)
        {
            return gclass26_0.vmethod_8(int_0);
        }

        internal DateTime? method_10(int int_0)
        {
            return gclass26_0.vmethod_10(int_0);
        }

        internal DateTime? method_11(int int_0)
        {
            return gclass26_0.vmethod_9(int_0);
        }

        internal uint? method_12(int int_0)
        {
            GEnum3? gEnum = gclass26_0.vmethod_7(int_0);
            if (!gEnum.HasValue)
            {
                return null;
            }
            return (uint)gEnum.Value;
        }
    }

    private static readonly byte byte_0;

    private static readonly byte byte_1;

    private readonly Stream stream_0;

    private readonly IList<GClass12> ilist_0;

    private readonly IList<GClass13> ilist_1;

    private readonly GClass25 gclass25_0;

    private readonly List<GClass38> list_0 = [];

    private long long_0;

    private long long_1;

    private long long_2;

    private GStruct0 gstruct0_0;

    private readonly bool bool_0;

    private GClass24(Stream stream_1, bool bool_1)
    {
        if (stream_1 == null)
        {
            throw new ArgumentNullException("stream");
        }
        if (!stream_1.CanWrite)
        {
            throw new ArgumentException("Stream must be writeable.", "stream");
        }
        if (!stream_1.CanSeek)
        {
            throw new ArgumentException("Stream must be seekable.", "stream");
        }
        stream_0 = stream_1;
        bool_0 = bool_1;
        long_1 = 32L;
        long_2 = 0L;
        long_0 = 32L;
        gstruct0_0 = GStruct0.smethod_0();
        ilist_0 = [];
        ilist_1 = [];
    }

    private static void smethod_0(byte[] byte_2, int int_0, int int_1)
    {
        byte_2[int_0] = (byte)int_1;
        byte_2[int_0 + 1] = (byte)(int_1 >> 8);
        byte_2[int_0 + 2] = (byte)(int_1 >> 16);
        byte_2[int_0 + 3] = (byte)(int_1 >> 24);
    }

    private static void smethod_1(byte[] byte_2, int int_0, long long_3)
    {
        smethod_0(byte_2, int_0, (int)long_3);
        smethod_0(byte_2, int_0 + 4, (int)(long_3 >> 32));
    }

    public static GClass24 smethod_2(Stream stream_1, bool bool_1)
    {
        try
        {
            GClass24 gClass = new(stream_1, bool_1);
            stream_1.Position = 0L;
            stream_1.SetLength(32L);
            stream_1.Write(gClass.method_22(), 0, 32);
            return gClass;
        }
        catch
        {
            if (bool_1)
            {
                stream_1?.Dispose();
            }
            throw;
        }
    }

    public static async Task<GClass24> smethod_3(Stream stream_1, bool bool_1)
    {
        try
        {
            GClass24 gClass = new(stream_1, bool_1);
            stream_1.Position = 0L;
            stream_1.SetLength(32L);
            await stream_1.WriteAsync(gClass.method_22(), 0, 32).ConfigureAwait(continueOnCapturedContext: false);
            return gClass;
        }
        catch
        {
            if (bool_1)
            {
                stream_1?.Dispose();
            }
            throw;
        }
    }

    public void Dispose()
    {
        if (bool_0)
        {
            stream_0.Dispose();
        }
        if (list_0.Count > 0)
        {
            throw new NotImplementedException();
        }
    }

    public Task method_0(GClass26 gclass26_0)
    {
        if (gclass26_0 == null)
        {
            throw new ArgumentNullException("metadata");
        }
        int num = gclass26_0.vmethod_0();
        if (num < 0)
        {
            throw new InvalidOperationException("ArchiveMetadataProvider returned negative count.");
        }
        long_1 = long_0;
        stream_0.Position = long_0;
        int num2 = ilist_1.Sum(gclass13_0 => gclass13_0?.Streams.Count ?? 0);
        method_12(Enum0.const_2);
        if (ilist_1.Count > 0)
        {
            method_12(Enum0.const_5);
            method_8();
            method_9();
            method_11();
            method_12(Enum0.const_1);
        }
        if (num2 > 0)
        {
            method_12(Enum0.const_6);
            method_17(num);
            int num3 = 0;
            for (int num4 = 0; num4 < num; num4++)
            {
                if (!gclass26_0.vmethod_2(num4))
                {
                    num3++;
                }
            }
            if (num3 > 0)
            {
                method_1(Enum0.const_15, from int_0 in Enumerable.Range(0, num)
                                         select !gclass26_0.vmethod_2(int_0), num);
                if ((from int_0 in Enumerable.Range(0, num)
                     where !gclass26_0.vmethod_2(int_0)
                     select int_0).Any(int_0 => !gclass26_0.vmethod_3(int_0)))
                {
                    method_1(Enum0.const_16, from int_0 in Enumerable.Range(0, num)
                                             where !gclass26_0.vmethod_2(int_0)
                                             select !gclass26_0.vmethod_3(int_0), num3);
                }
                if ((from int_0 in Enumerable.Range(0, num)
                     where !gclass26_0.vmethod_2(int_0)
                     select int_0).Any(int_0 => gclass26_0.vmethod_4(int_0)))
                {
                    method_1(Enum0.const_17, from int_0 in Enumerable.Range(0, num)
                                             where !gclass26_0.vmethod_2(int_0)
                                             select gclass26_0.vmethod_4(int_0), num3);
                }
            }
            bool flag = false;
            int num5 = 1;
            for (int num6 = 0; num6 < num2; num6++)
            {
                string text = gclass26_0.vmethod_1(num6);
                if (!string.IsNullOrEmpty(text))
                {
                    flag = true;
                    num5 += (text.Length + 1) * 2;
                }
                else
                {
                    num5 += 2;
                }
            }
            if (flag)
            {
                method_13(2 + method_18(num5), 16);
                method_12(Enum0.const_18);
                method_17(num5);
                method_14(0);
                for (int num7 = 0; num7 < num2; num7++)
                {
                    string text2 = gclass26_0.vmethod_1(num7);
                    foreach (char c in text2)
                    {
                        method_14((byte)c);
                        method_14((byte)((int)c >> 8));
                    }
                    method_14(0);
                    method_14(0);
                }
            }
            method_5(from int_0 in Enumerable.Range(0, num)
                     select gclass26_0.vmethod_8(int_0), Enum0.const_19);
            method_5(from int_0 in Enumerable.Range(0, num)
                     select gclass26_0.vmethod_10(int_0), Enum0.const_20);
            method_5(from int_0 in Enumerable.Range(0, num)
                     select gclass26_0.vmethod_9(int_0), Enum0.const_21);
            method_6(from int_0 in Enumerable.Range(0, num)
                     select (ulong?)null, Enum0.const_25);
            method_7(Enumerable.Range(0, num).Select(delegate (int int_0)
            {
                GEnum3? gEnum = gclass26_0.vmethod_7(int_0);
                return (!gEnum.HasValue) ? ((uint?)null) : new uint?((uint)gEnum.Value);
            }), Enum0.const_22);
            method_12(Enum0.const_1);
        }
        method_12(Enum0.const_1);
        long_2 = stream_0.Position - long_1;
        byte[] array = new byte[4096];
        stream_0.Position = long_1;
        uint uint_ = uint.MaxValue;
        int num9 = 0;
        while (num9 < long_2)
        {
            int num10 = stream_0.Read(array, 0, (int)Math.Min(long_2 - num9, array.Length));
            if (num10 > 0 && num10 <= long_2 - num9)
            {
                num9 += num10;
                uint_ = Class14.smethod_7(uint_, array, 0, num10);
                continue;
            }
            throw new Exception1();
        }
        gstruct0_0 = new GStruct0((int)Class14.smethod_1(uint_));
        return Class19.Task_0;
    }

    private void method_1(Enum0 enum0_0, IEnumerable<bool> ienumerable_0, int int_0)
    {
        method_12(enum0_0);
        method_17((int_0 + 7) / 8);
        method_2(ienumerable_0);
    }

    private void method_2(IEnumerable<bool> ienumerable_0)
    {
        byte b = 0;
        byte b2 = 128;
        foreach (bool item in ienumerable_0)
        {
            if (item)
            {
                b |= b2;
            }
            b2 >>= 1;
            if (b2 == 0)
            {
                method_14(b);
                b2 = 128;
                b = 0;
            }
        }
        if (b2 != 128)
        {
            method_14(b);
        }
    }

    private void method_3(IEnumerable<bool> ienumerable_0, int int_0, int int_1, Enum0 enum0_0, int int_2)
    {
        int num = ((int_1 != int_0) ? ((int_0 + 7) / 8) : 0);
        int num2 = 2 + num + int_1 * int_2;
        method_13(3 + num + method_18(num2), int_2);
        method_12(enum0_0);
        method_17(num2);
        if (int_1 == int_0)
        {
            method_14(1);
        }
        else
        {
            method_14(0);
            method_2(ienumerable_0);
        }
        method_14(0);
    }

    private void method_4(IEnumerable<GStruct0?> ienumerable_0)
    {
        if (!ienumerable_0.Any(nullable_0 => nullable_0.HasValue))
        {
            return;
        }
        method_12(Enum0.const_11);
        if (ienumerable_0.All(nullable_0 => nullable_0.HasValue))
        {
            method_14(1);
        }
        else
        {
            method_14(0);
            method_2(ienumerable_0.Select(nullable_0 => nullable_0.HasValue));
        }
        foreach (GStruct0? item in ienumerable_0)
        {
            if (item.HasValue)
            {
                method_15(item.Value.int_0);
            }
        }
    }

    private void method_5(IEnumerable<DateTime?> ienumerable_0, Enum0 enum0_0)
    {
        method_6(ienumerable_0.Select(nullable_0 => (!nullable_0.HasValue) ? ((ulong?)null) : new ulong?((ulong)nullable_0.Value.ToFileTimeUtc())), enum0_0);
    }

    private void method_6(IEnumerable<ulong?> ienumerable_0, Enum0 enum0_0)
    {
        int int_ = ienumerable_0.Count();
        int num = ienumerable_0.Count(nullable_0 => nullable_0.HasValue);
        if (num <= 0)
        {
            return;
        }
        method_3(ienumerable_0.Select(nullable_0 => nullable_0.HasValue), int_, num, enum0_0, 8);
        foreach (ulong? item in ienumerable_0)
        {
            if (item.HasValue)
            {
                method_16(item.Value);
            }
        }
    }

    private void method_7(IEnumerable<uint?> ienumerable_0, Enum0 enum0_0)
    {
        int int_ = ienumerable_0.Count();
        int num = ienumerable_0.Count(nullable_0 => nullable_0.HasValue);
        if (num <= 0)
        {
            return;
        }
        method_3(ienumerable_0.Select(nullable_0 => nullable_0.HasValue), int_, num, enum0_0, 4);
        foreach (uint? item in ienumerable_0)
        {
            if (item.HasValue)
            {
                method_15((int)item.Value);
            }
        }
    }

    private void method_8()
    {
        if (ilist_0.Count <= 0)
        {
            return;
        }
        method_12(Enum0.const_7);
        method_17(ilist_0[0].Offset - 32L);
        method_17(ilist_0.Count);
        method_12(Enum0.const_10);
        foreach (GClass12 item in ilist_0)
        {
            method_17(item.Length);
        }
        method_4(ilist_0.Select(gclass12_0 => gclass12_0.Checksum));
        method_12(Enum0.const_1);
    }

    private void method_9()
    {
        if (ilist_1.Count <= 0)
        {
            return;
        }
        method_12(Enum0.const_8);
        method_12(Enum0.const_12);
        method_17(ilist_1.Count);
        method_14(0);
        int int_ = 0;
        foreach (GClass13 item in ilist_1)
        {
            method_10(item, ref int_);
        }
        method_12(Enum0.const_13);
        foreach (GClass13 item2 in ilist_1)
        {
            foreach (GClass14 decoder in item2.Decoders)
            {
                foreach (GStruct5 outputStream in decoder.OutputStreams)
                {
                    method_17(outputStream.Length);
                }
            }
        }
        method_4(ilist_1.Select(gclass13_0 => gclass13_0.Checksum));
        method_12(Enum0.const_1);
    }

    private void method_10(GClass13 gclass13_0, ref int int_0)
    {
        method_17(gclass13_0.Decoders.Count);
        int[] array = new int[gclass13_0.Decoders.Count];
        int[] array2 = new int[gclass13_0.Decoders.Count];
        for (int i = 1; i < gclass13_0.Decoders.Count; i++)
        {
            array[i] = array[i - 1] + gclass13_0.Decoders[i - 1].InputStreams.Count;
            array2[i] = array2[i - 1] + gclass13_0.Decoders[i - 1].OutputStreams.Count;
        }
        for (int j = 0; j < gclass13_0.Decoders.Count; j++)
        {
            GClass14 gClass = gclass13_0.Decoders[j];
            byte[] array3 = gClass.DecoderType.method_0();
            bool flag = gClass.InputStreams.Count != 1 || gClass.OutputStreams.Count != 1;
            byte[] settings = gClass.Settings;
            bool flag2 = settings?.Any() ?? false;
            byte b = (byte)array3.Length;
            if (flag)
            {
                b |= 0x10;
            }
            if (flag2)
            {
                b |= 0x20;
            }
            method_14(b);
            byte[] array4 = array3;
            foreach (byte byte_ in array4)
            {
                method_14(byte_);
            }
            if (flag)
            {
                method_17(gClass.InputStreams.Count);
                method_17(gClass.OutputStreams.Count);
            }
            if (flag2)
            {
                method_17(settings.Length);
                array4 = settings;
                foreach (byte byte_2 in array4)
                {
                    method_14(byte_2);
                }
            }
        }
        for (int l = 0; l < gclass13_0.Decoders.Count; l++)
        {
            GClass14 gClass2 = gclass13_0.Decoders[l];
            for (int m = 0; m < gClass2.InputStreams.Count; m++)
            {
                GStruct4 gStruct = gClass2.InputStreams[m];
                if (gStruct.Nullable_0.HasValue)
                {
                    method_17(array[l] + m);
                    method_17(array2[gStruct.Nullable_0.Value] + gStruct.Int32_0);
                }
            }
        }
        int num = 0;
        foreach (GClass14 decoder in gclass13_0.Decoders)
        {
            foreach (GStruct4 inputStream in decoder.InputStreams)
            {
                if (!inputStream.Nullable_0.HasValue)
                {
                    num++;
                }
            }
        }
        if (num > 1)
        {
            foreach (GClass14 decoder2 in gclass13_0.Decoders)
            {
                foreach (GStruct4 inputStream2 in decoder2.InputStreams)
                {
                    if (!inputStream2.Nullable_0.HasValue)
                    {
                        method_17(inputStream2.Int32_0 - int_0);
                    }
                }
            }
        }
        int_0 += num;
    }

    private void method_11()
    {
        method_12(Enum0.const_9);
        if (ilist_1.Any(gclass13_0 => gclass13_0.Streams.Count != 1))
        {
            method_12(Enum0.const_14);
            foreach (GClass13 item in ilist_1)
            {
                method_17(item.Streams.Count);
            }
        }
        if (ilist_1.Any(gclass13_0 => gclass13_0.Streams.Count > 1))
        {
            method_12(Enum0.const_10);
            foreach (GClass13 item2 in ilist_1)
            {
                IList<GStruct2> streams = item2.Streams;
                for (int num = 0; num < streams.Count - 1; num++)
                {
                    method_17(streams[num].Length);
                }
            }
        }
        method_4(ilist_1.Where(gclass13_0 => gclass13_0.Streams.Count != 1 || !gclass13_0.Checksum.HasValue).SelectMany(gclass13_0 => gclass13_0.Streams, delegate (GClass13 gclass13_0, GStruct2 gstruct2_0)
        {
            GStruct2 gStruct = gstruct2_0;
            return gStruct.Checksum;
        }));
        method_12(Enum0.const_1);
    }

    private void method_12(Enum0 enum0_0)
    {
        method_14((byte)enum0_0);
    }

    private void method_13(int int_0, int int_1)
    {
        int_0 = (int)(stream_0.Position + int_0) & (int_1 - 1);
        if (int_0 > 0)
        {
            int num = int_1 - int_0;
            if (num < 2)
            {
                num += int_1;
            }
            num -= 2;
            method_12(Enum0.const_26);
            method_14((byte)num);
            for (int i = 0; i < num; i++)
            {
                method_14(0);
            }
        }
    }

    private void method_14(byte byte_2)
    {
        stream_0.WriteByte(byte_2);
    }

    private void method_15(int int_0)
    {
        method_14((byte)int_0);
        method_14((byte)(int_0 >> 8));
        method_14((byte)(int_0 >> 16));
        method_14((byte)(int_0 >> 24));
    }

    private void method_16(ulong ulong_0)
    {
        for (int i = 0; i < 8; i++)
        {
            method_14((byte)ulong_0);
            ulong_0 >>= 8;
        }
    }

    private void method_17(long long_3)
    {
        byte b = 0;
        byte b2 = 128;
        byte b3 = 0;
        while (b3 < 8)
        {
            if (long_3 >= 1L << 7 * (b3 + 1))
            {
                b |= b2;
                b2 >>= 1;
                b3++;
                continue;
            }
            b |= (byte)(long_3 >> 8 * b3);
            break;
        }
        method_14(b);
        while (b3 > 0)
        {
            method_14((byte)long_3);
            long_3 >>= 8;
            b3--;
        }
    }

    private int method_18(long long_3)
    {
        int i;
        for (i = 1; i < 9 && long_3 >= 1L << i * 7; i++)
        {
        }
        return i;
    }

    public async Task method_19()
    {
        byte[] array = method_22();
        stream_0.Position = 0L;
        await stream_0.WriteAsync(array, 0, array.Length).ConfigureAwait(continueOnCapturedContext: false);
    }

    public GClass38 method_20(GClass29 gclass29_0, bool bool_1)
    {
        if (gclass29_0 == null)
        {
            throw new ArgumentNullException("definition");
        }
        Stream[] array = new Stream[gclass29_0.Int32_1];
        int num;
        object obj;
        for (int i = 0; i < array.Length; array[num] = (Stream)obj, i++)
        {
            num = i;
            GClass25 gClass = gclass25_0;
            if (gClass == null)
            {
                obj = null;
            }
            else
            {
                obj = gClass.vmethod_0();
                if (obj != null)
                {
                    continue;
                }
            }
            obj = new MemoryStream();
        }
        GClass38 gClass2 = gclass29_0.method_8(this, ilist_1.Count, array, bool_1);
        ilist_1.Add(null);
        list_0.Add(gClass2);
        return gClass2;
    }

    public async Task method_21(Stream stream_1, GClass11 gclass11_0, int int_0)
    {
        if (stream_1 == null)
        {
            throw new ArgumentNullException("stream");
        }
        if (gclass11_0 == null)
        {
            throw new ArgumentNullException("metadata");
        }
        if (int_0 >= 0 && int_0 < gclass11_0.DecoderSections.Count)
        {
            GClass13 gClass = gclass11_0.DecoderSections[int_0];
            if (gClass.Streams.Count == 0)
            {
                throw new InvalidOperationException();
            }
            foreach (GClass14 decoder in gClass.Decoders)
            {
                foreach (GStruct4 inputStream in decoder.InputStreams)
                {
                    if (!inputStream.Nullable_0.HasValue)
                    {
                        GClass12 gClass2 = gclass11_0.FileSections[inputStream.Int32_0];
                        long num = long_0;
                        long length = gClass2.Length;
                        long_0 = checked(num + length);
                        ilist_0.Add(new GClass12(num, length, gClass2.Checksum));
                        using Stream0 stream = new(stream_0, gClass2.Offset, gClass2.Length);
                        await stream.CopyToAsync(stream_0).ConfigureAwait(continueOnCapturedContext: false);
                    }
                }
            }
            return;
        }
        throw new ArgumentOutOfRangeException("section");
    }

    private byte[] method_22()
    {
        long num = long_1 - 32L;
        if (num < 0L)
        {
            throw new Exception1();
        }
        uint uint_ = Class14.smethod_6(uint.MaxValue, num);
        uint_ = Class14.smethod_6(uint_, long_2);
        uint_ = Class14.smethod_4(uint_, gstruct0_0.int_0);
        uint_ = Class14.smethod_1(uint_);
        byte[] array = new byte[32];
        byte[] array2 = Class33.byte_0;
        for (int i = 0; i < array2.Length; i++)
        {
            array[i] = array2[i];
        }
        array[6] = 0;
        array[7] = 3;
        smethod_0(array, 8, (int)uint_);
        smethod_1(array, 12, num);
        smethod_1(array, 20, long_2);
        smethod_0(array, 28, gstruct0_0.int_0);
        return array;
    }

    internal void method_23(GClass38 gclass38_0, int int_0, GClass13 gclass13_0, Class40[] class40_0)
    {
        if (!list_0.Remove(gclass38_0))
        {
            throw new Exception1();
        }
        ilist_1[int_0] = gclass13_0;
        foreach (Class40 obj in class40_0)
        {
            Stream stream = obj.method_1();
            long num = long_0;
            long length = stream.Length;
            long_0 = checked(num + length);
            GStruct0? nullable_ = obj.method_2();
            ilist_0.Add(new GClass12(num, length, nullable_));
            stream_0.Position = num;
            stream.Position = 0L;
            stream.CopyTo(stream_0);
        }
    }
}
