using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[DebuggerDisplay("\\{ArchiveDecoderSection #Decoders={Decoders.Length} #Streams={Streams.Length}\\}")]
public sealed class GClass13
{
    [CompilerGenerated]
    private readonly IList<GClass14> ilist_0;

    [CompilerGenerated]
    private readonly GStruct4 gstruct4_0;

    [CompilerGenerated]
    private readonly long long_0;

    [CompilerGenerated]
    private readonly GStruct0? nullable_0;

    [CompilerGenerated]
    private readonly IList<GStruct2> ilist_1;

    public IList<GClass14> Decoders
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
    }

    public GStruct4 DecodedStream
    {
        [CompilerGenerated]
        get
        {
            return gstruct4_0;
        }
    }

    public long Length
    {
        [CompilerGenerated]
        get
        {
            return long_0;
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

    public IList<GStruct2> Streams
    {
        [CompilerGenerated]
        get
        {
            return ilist_1;
        }
    }

    public GClass13(IList<GClass14> ilist_2, GStruct4 gstruct4_1, long long_1, GStruct0? nullable_1, IList<GStruct2> ilist_3)
    {
        if (long_1 < 0L)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        ilist_0 = ilist_2;
        gstruct4_0 = gstruct4_1;
        long_0 = long_1;
        nullable_0 = nullable_1;
        ilist_1 = ilist_3;
    }
}
