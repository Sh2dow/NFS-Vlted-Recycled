using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs10 : EventArgs
{
    [CompilerGenerated]
    private GClass77 gclass77_0;

    public GClass77 Hint
    {
        [CompilerGenerated]
        get
        {
            return gclass77_0;
        }
        [CompilerGenerated]
        private set
        {
            gclass77_0 = value;
        }
    }

    public GEventArgs10(GClass77 gclass77_1)
    {
        Hint = gclass77_1;
    }
}
