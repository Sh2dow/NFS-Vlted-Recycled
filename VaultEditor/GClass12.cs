using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass12
{
    [CompilerGenerated]
    private readonly long long_0;

    [CompilerGenerated]
    private readonly long long_1;

    [CompilerGenerated]
    private readonly GStruct0? nullable_0;

    public long Offset
    {
        [CompilerGenerated]
        get
        {
            return long_0;
        }
    }

    public long Length
    {
        [CompilerGenerated]
        get
        {
            return long_1;
        }
    }

    public GStruct0? Checksum
    {
        [CompilerGenerated]
        get
        {
            return nullable_0;
        }
    }

    public GClass12(long long_2, long long_3, GStruct0? nullable_1)
    {
        if (long_2 < 0L)
        {
            throw new ArgumentOutOfRangeException("offset");
        }
        if (long_3 < 0L)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        long_0 = long_2;
        long_1 = long_3;
        nullable_0 = nullable_1;
    }
}
