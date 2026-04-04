using System;
using System.IO;

namespace VaultEditor;

internal sealed class Stream0 : Stream
{
    private Stream stream_0;

    private readonly long long_0;

    private long long_1;

    private readonly long long_2;

    public override bool CanRead => stream_0.CanRead;

    public override bool CanSeek => stream_0.CanSeek;

    public override bool CanWrite => false;

    public override long Length => long_2;

    public override long Position
    {
        get
        {
            return long_1;
        }
        set
        {
            long_1 = value;
            stream_0.Position = long_0 + value;
        }
    }

    public Stream0(Stream stream_1, long long_3, long long_4)
    {
        stream_0 = stream_1;
        long_0 = long_3;
        long_2 = long_4;
        stream_1.Position = long_3;
    }

    protected void Dispose(bool disposing)
    {
        stream_0 = null;
        base.Dispose(disposing);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        return origin switch
        {
            SeekOrigin.Begin => Position = offset,
            SeekOrigin.Current => Position += offset,
            SeekOrigin.End => Position = long_2 + offset,
            _ => throw new ArgumentOutOfRangeException(),
        };
    }

    public override int Read(byte[] buffer, int offset, int length)
    {
        long num = long_2 - long_1;
        if (length > num)
        {
            length = (int)num;
        }
        int num2 = stream_0.Read(buffer, offset, length);
        long_1 += num2;
        return num2;
    }

    public override void SetLength(long value)
    {
        throw new InvalidOperationException();
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        throw new InvalidOperationException();
    }

    public override void Flush()
    {
        throw new InvalidOperationException();
    }
}
