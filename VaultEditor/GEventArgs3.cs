using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs3 : EventArgs
{
    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    public int Index
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        private set
        {
            int_0 = value;
        }
    }

    public int Count
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        private set
        {
            int_1 = value;
        }
    }

    public GEventArgs3(int int_2, int int_3)
    {
        Index = int_2;
        Count = int_3;
    }
}
