using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace VaultEditor;

public sealed class GStream0(Stream stream_0, GClass11 gclass11_0, int int_0, GClass1 gclass1_0) : Stream
{
    private readonly GClass3 gclass3_0 = new GClass3(stream_0, gclass11_0, int_0, gclass1_0);

    private readonly long long_0;

    private long long_1;

    public override bool CanRead => true;

    public override bool CanSeek => false;

    public override bool CanWrite => false;

    public override long Length => long_0;

    public override long Position
    {
        get
        {
            return long_1;
        }
        set
        {
            if (value < long_1 || value > long_0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            method_0(value - long_1);
        }
    }

    protected void Dispose(bool disposing)
    {
        if (disposing)
        {
            gclass3_0.Dispose();
        }
        base.Dispose(disposing);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        switch (origin)
        {
            default:
                throw new ArgumentOutOfRangeException("origin");
            case SeekOrigin.Begin:
                if (offset >= long_1 && offset <= long_0)
                {
                    offset -= long_1;
                    break;
                }
                throw new ArgumentOutOfRangeException("offset");
            case SeekOrigin.Current:
                if (offset < 0L || offset > long_0 - long_1)
                {
                    throw new ArgumentOutOfRangeException("offset");
                }
                break;
            case SeekOrigin.End:
                if (offset <= 0L && offset >= long_1 - long_0)
                {
                    offset += long_0;
                    break;
                }
                throw new ArgumentOutOfRangeException("offset");
        }
        method_0(offset);
        return long_1;
    }

    public void method_0(long long_2)
    {
        if (long_2 >= 0L && long_2 <= long_0 - long_1)
        {
            while (long_2 > 2147483647L)
            {
                gclass3_0.method_0(int.MaxValue);
                long_1 += 2147483647L;
                long_2 -= 2147483647L;
            }
            if (long_2 > 0L)
            {
                gclass3_0.method_0((int)long_2);
                long_1 += long_2;
            }
            return;
        }
        throw new ArgumentOutOfRangeException("offset");
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        if (buffer == null)
        {
            throw new ArgumentNullException("buffer");
        }
        if (offset >= 0 && offset <= buffer.Length)
        {
            if (count < 0 || count > buffer.Length - offset)
            {
                throw new ArgumentOutOfRangeException("count");
            }
            int num = gclass3_0.method_1(buffer, offset, count);
            long_1 += num;
            return num;
        }
        throw new ArgumentOutOfRangeException("offset");
    }

    public override void SetLength(long value)
    {
        throw new InvalidOperationException();
    }

    public override void Flush()
    {
        throw new InvalidOperationException();
    }

    public override Task FlushAsync(CancellationToken cancellationToken)
    {
        throw new InvalidOperationException();
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        throw new InvalidOperationException();
    }

    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        throw new InvalidOperationException();
    }
}
