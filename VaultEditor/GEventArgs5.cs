using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs5 : EventArgs
{
    [CompilerGenerated]
    private GClass84 gclass84_0;

    public GClass84 ChangedRange
    {
        [CompilerGenerated]
        get
        {
            return gclass84_0;
        }
        [CompilerGenerated]
        set
        {
            gclass84_0 = value;
        }
    }

    public GEventArgs5(GClass84 gclass84_1)
    {
        ChangedRange = gclass84_1;
    }
}
