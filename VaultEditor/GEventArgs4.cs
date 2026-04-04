using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs4 : EventArgs
{
    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private List<int> list_0;

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

    public List<int> RemovedLineUniqueIds
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

    public GEventArgs4(int int_2, int int_3, List<int> list_1)
    {
        Index = int_2;
        Count = int_3;
        RemovedLineUniqueIds = list_1;
    }
}
