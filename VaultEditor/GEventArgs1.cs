using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs1 : EventArgs
{
    [CompilerGenerated]
    private GClass51 gclass51_0;

    [CompilerGenerated]
    private FastColoredTextBox fastColoredTextBox_0;

    public GClass51 Item
    {
        [CompilerGenerated]
        get
        {
            return gclass51_0;
        }
        [CompilerGenerated]
        internal set
        {
            gclass51_0 = value;
        }
    }

    public FastColoredTextBox Tb
    {
        [CompilerGenerated]
        get
        {
            return fastColoredTextBox_0;
        }
        [CompilerGenerated]
        set
        {
            fastColoredTextBox_0 = value;
        }
    }
}
