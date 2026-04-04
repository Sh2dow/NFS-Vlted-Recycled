using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[DebuggerDisplay("\\{ArchiveMetadata #FileSections={FileSections.Length} #DecoderSections={DecoderSections.Length}\\}")]
public sealed class GClass11
{
    [CompilerGenerated]
    private readonly IList<GClass12> ilist_0;

    [CompilerGenerated]
    private readonly IList<GClass13> ilist_1;

    public IList<GClass12> FileSections
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
    }

    public IList<GClass13> DecoderSections
    {
        [CompilerGenerated]
        get
        {
            return ilist_1;
        }
    }

    public GClass11()
    {
        ilist_0 = [];
        ilist_1 = [];
    }

    public GClass11(IList<GClass12> ilist_2, IList<GClass13> ilist_3)
    {
        ilist_0 = ilist_2;
        ilist_1 = ilist_3;
    }
}
