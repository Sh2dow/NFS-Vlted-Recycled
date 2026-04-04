using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs7 : EventArgs
{
    [CompilerGenerated]
    private List<int> list_0;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private GClass80 gclass80_0;

    public List<int> CutOffPositions
    {
        [CompilerGenerated]
        get
        {
            return list_0;
        }
        [CompilerGenerated]
        private set
        {
            list_0 = value;
        }
    }

    public bool ImeAllowed
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        private set
        {
            bool_0 = value;
        }
    }

    public GClass80 Line
    {
        [CompilerGenerated]
        get
        {
            return gclass80_0;
        }
        [CompilerGenerated]
        private set
        {
            gclass80_0 = value;
        }
    }

    public GEventArgs7(List<int> list_1, bool bool_1, GClass80 gclass80_1)
    {
        CutOffPositions = list_1;
        ImeAllowed = bool_1;
        Line = gclass80_1;
    }
}
