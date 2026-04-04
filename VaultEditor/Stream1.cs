using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace VaultEditor;

internal sealed class Stream1 : Stream
{
    private GClass3 gclass3_0;

    private long long_0;

    private readonly long long_1;

    public override bool CanRead => true;

    public override bool CanSeek => false;

    public override bool CanWrite => false;

    public override long Length => long_1;

    public override long Position
    {
        get
        {
            return long_0;
        }
        set
        {
            if (value < long_0 || value > long_1)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            method_0(value - long_0);
        }
    }

    internal Stream1(GClass3 gclass3_1, long long_2)
    {
        gclass3_0 = gclass3_1;
        long_1 = long_2;
    }

    protected void Dispose(bool disposing)
    {
        gclass3_0 = null;
        base.Dispose(disposing);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        switch (origin)
        {
            default:
                throw new ArgumentOutOfRangeException("origin");
            case SeekOrigin.Begin:
                if (offset >= long_0 && offset <= long_1)
                {
                    offset -= long_0;
                    break;
                }
                throw new ArgumentOutOfRangeException("offset");
            case SeekOrigin.Current:
                if (offset < 0L || offset > long_1 - long_0)
                {
                    throw new ArgumentOutOfRangeException("offset");
                }
                break;
            case SeekOrigin.End:
                if (offset <= 0L && offset >= long_0 - long_1)
                {
                    offset += long_1;
                    break;
                }
                throw new ArgumentOutOfRangeException("offset");
        }
        method_0(offset);
        return long_0;
    }

    public void method_0(long long_2)
    {
        if (long_2 >= 0L && long_2 <= long_1 - long_0)
        {
            while (long_2 > 2147483647L)
            {
                gclass3_0.method_0(int.MaxValue);
                long_0 += 2147483647L;
                long_2 -= 2147483647L;
            }
            if (long_2 > 0L)
            {
                gclass3_0.method_0((int)long_2);
                long_0 += long_2;
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
            if (count >= 0 && count <= buffer.Length - offset)
            {
                if (gclass3_0 == null)
                {
                    throw new ObjectDisposedException(null);
                }
                long num = long_1 - long_0;
                if (count > num)
                {
                    count = (int)num;
                }
                if (count == 0)
                {
                    return 0;
                }
                int num2 = gclass3_0.method_1(buffer, offset, count);
                if (num2 <= 0 || num2 > count)
                {
                    throw new Exception1();
                }
                long_0 += num2;
                return num2;
            }
            throw new ArgumentOutOfRangeException("count");
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
