using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[DebuggerDisplay("\\{DecoderMetadata {DecoderType,nq}\\}")]
public sealed class GClass14
{
    [CompilerGenerated]
    private readonly GStruct6 gstruct6_0;

    [CompilerGenerated]
    private readonly byte[] byte_0;

    [CompilerGenerated]
    private readonly IList<GStruct4> ilist_0;

    [CompilerGenerated]
    private readonly IList<GStruct5> ilist_1;

    public GStruct6 DecoderType
    {
        [CompilerGenerated]
        get
        {
            return gstruct6_0;
        }
    }

    public byte[] Settings
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
    }

    public IList<GStruct4> InputStreams
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
    }

    public IList<GStruct5> OutputStreams
    {
        [CompilerGenerated]
        get
        {
            return ilist_1;
        }
    }

    public GClass14(GStruct6 gstruct6_1, byte[] byte_1, IList<GStruct4> ilist_2, IList<GStruct5> ilist_3)
    {
        if (gstruct6_1.Boolean_0)
        {
            throw new ArgumentOutOfRangeException("type");
        }
        gstruct6_0 = gstruct6_1;
        byte_0 = byte_1;
        ilist_0 = ilist_2;
        ilist_1 = ilist_3;
    }
}
