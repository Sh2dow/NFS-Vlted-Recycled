using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public struct GStruct2
{
    [CompilerGenerated]
    private long long_0;

    [CompilerGenerated]
    private GStruct0? nullable_0;

    public long Length
    {
        [CompilerGenerated]
        readonly get
        {
            return long_0;
        }
        [CompilerGenerated]
        internal set
        {
            long_0 = value;
        }
    }

    public GStruct0? Checksum
    {
        [CompilerGenerated]
        readonly get
        {
            return nullable_0;
        }
        [CompilerGenerated]
        internal set
        {
            nullable_0 = value;
        }
    }

    public GStruct2(long long_1, GStruct0? nullable_1)
    {
        if (long_1 < 0L)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        Length = long_1;
        Checksum = nullable_1;
    }
}
