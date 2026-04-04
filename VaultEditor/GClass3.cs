using System;
using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

public sealed class GClass3 : IDisposable
{
    private readonly Class32 class32_0;

    private readonly Class21[] class21_0;

    private readonly Class27[] class27_0;

    private readonly Class21 class21_1;

    public GClass3(Stream stream_0, GClass11 gclass11_0, int int_0, GClass1 gclass1_0)
    {
        if (stream_0 == null)
        {
            throw new ArgumentNullException("stream");
        }
        if (!stream_0.CanRead)
        {
            throw new ArgumentException("Stream must be readable.", "stream");
        }
        if (!stream_0.CanSeek)
        {
            throw new ArgumentException("Stream must be seekable.", "stream");
        }
        if (gclass11_0 == null)
        {
            throw new ArgumentNullException("metadata");
        }
        if (int_0 >= 0 && int_0 < gclass11_0.DecoderSections.Count)
        {
            Class32 class32_ = new(stream_0);
            Class21[] array = new Class21[gclass11_0.FileSections.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Class22(class32_, gclass11_0.FileSections[i].Offset, gclass11_0.FileSections[i].Length);
            }
            GClass13 gClass = gclass11_0.DecoderSections[int_0];
            IList<GClass14> decoders = gClass.Decoders;
            Class27[] array2 = new Class27[decoders.Count];
            for (int j = 0; j < array2.Length; j++)
            {
                GClass14 gClass2 = decoders[j];
                array2[j] = gClass2.DecoderType.method_4(gClass2.Settings, gClass2.OutputStreams, gclass1_0);
            }
            for (int k = 0; k < array2.Length; k++)
            {
                Class27 @class = array2[k];
                IList<GStruct4> inputStreams = decoders[k].InputStreams;
                for (int l = 0; l < inputStreams.Count; l++)
                {
                    smethod_0(gclass11_0, gClass, inputStreams[l], array, array2, out var class21_, out var long_);
                    @class.vmethod_0(l, class21_, long_);
                }
            }
            smethod_0(gclass11_0, gClass, gClass.DecodedStream, array, array2, out var class21_2, out var _);
            class32_0 = class32_;
            class21_0 = array;
            class27_0 = array2;
            class21_1 = class21_2;
            return;
        }
        throw new ArgumentOutOfRangeException("index");
    }

    private static void smethod_0(GClass11 gclass11_0, GClass13 gclass13_0, GStruct4 gstruct4_0, Class21[] class21_2, Class27[] class27_1, out Class21 class21_3, out long long_0)
    {
        int? nullable_ = gstruct4_0.Nullable_0;
        if (nullable_.HasValue)
        {
            long_0 = gclass13_0.Decoders[nullable_.Value].OutputStreams[gstruct4_0.Int32_0].Length;
            class21_3 = class27_1[nullable_.Value].vmethod_1(gstruct4_0.Int32_0);
        }
        else
        {
            long_0 = gclass11_0.FileSections[gstruct4_0.Int32_0].Length;
            class21_3 = class21_2[gstruct4_0.Int32_0];
        }
    }

    public void Dispose()
    {
        Class21[] array = class21_0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i].Dispose();
        }
        Class27[] array2 = class27_0;
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i].Dispose();
        }
    }

    public void method_0(int int_0)
    {
        if (int_0 < 0)
        {
            throw new ArgumentOutOfRangeException("offset");
        }
        if (int_0 > 0)
        {
            class21_1.vmethod_0(int_0);
        }
    }

    public int method_1(byte[] byte_0, int int_0, int int_1)
    {
        if (byte_0 == null)
        {
            throw new ArgumentNullException("buffer");
        }
        if (int_0 >= 0 && int_0 <= byte_0.Length)
        {
            if (int_1 >= 0 && int_1 <= byte_0.Length - int_0)
            {
                if (int_1 == 0)
                {
                    return 0;
                }
                return class21_1.vmethod_1(byte_0, int_0, int_1);
            }
            throw new ArgumentOutOfRangeException("count");
        }
        throw new ArgumentOutOfRangeException("offset");
    }
}
