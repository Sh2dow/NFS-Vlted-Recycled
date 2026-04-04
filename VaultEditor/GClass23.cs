using System;
using System.IO;

namespace VaultEditor;

public sealed class GClass23(Stream stream_0, GClass11 gclass11_1, int int_1, GClass1 gclass1_0) : IDisposable
{
    private readonly GClass11 gclass11_0 = gclass11_1;

    private readonly GClass13 gclass13_0 = gclass11_1.DecoderSections[int_1];

    private readonly GClass3 gclass3_0 = new GClass3(stream_0, gclass11_1, int_1, gclass1_0);

    private Stream1 stream1_0;

    private int int_0;

    public int Int32_0 => gclass13_0.Streams.Count;

    public int Int32_1 => int_0;

    public long Int64_0
    {
        get
        {
            if (stream1_0 == null)
            {
                return 0L;
            }
            return stream1_0.Position;
        }
    }

    public long Int64_1 => gclass13_0.Streams[int_0].Length;

    public GStruct0? Nullable_0 => gclass13_0.Streams[int_0].Checksum;

    public void Dispose()
    {
        method_2();
        gclass3_0.Dispose();
    }

    public Stream method_0()
    {
        if (Int32_1 == Int32_0)
        {
            throw new InvalidOperationException("The reader contains no more streams.");
        }
        if (stream1_0 != null)
        {
            throw new InvalidOperationException("Each stream can only be opened once.");
        }
        stream1_0 = new Stream1(gclass3_0, Int64_1);
        return stream1_0;
    }

    public void method_1()
    {
        if (Int32_1 == Int32_0)
        {
            throw new InvalidOperationException("The reader contains no more streams.");
        }
        long num = Int64_1 - Int64_0;
        method_2();
        while (num > 2147483647L)
        {
            gclass3_0.method_0(int.MaxValue);
            num -= 2147483647L;
        }
        if (num > 0L)
        {
            gclass3_0.method_0((int)num);
        }
        int_0++;
    }

    private void method_2()
    {
        if (stream1_0 != null)
        {
            stream1_0.Dispose();
            stream1_0 = null;
        }
    }
}
