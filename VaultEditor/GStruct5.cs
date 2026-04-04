using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[DebuggerDisplay("\\{DecoderOutputMetadata {Length}\\}")]
public readonly struct GStruct5
{
    [CompilerGenerated]
    private readonly long long_0;

    public long Length
    {
        [CompilerGenerated]
        get
        {
            return long_0;
        }
    }

    public GStruct5(long long_1)
    {
        if (long_1 < 0L)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        long_0 = long_1;
    }
}
