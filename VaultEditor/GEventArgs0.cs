using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs0 : EventArgs
{
    [CompilerGenerated]
    private GClass51 gclass51_0;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private bool bool_1;

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

    public bool Cancel
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public int SelectedIndex
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public bool Handled
    {
        [CompilerGenerated]
        get
        {
            return bool_1;
        }
        [CompilerGenerated]
        set
        {
            bool_1 = value;
        }
    }
}
