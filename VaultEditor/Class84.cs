using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class84
{
    [CompilerGenerated]
    private GStruct10 gstruct10_0;

    [CompilerGenerated]
    private GStruct10 gstruct10_1;

    public GStruct10 Start
    {
        [CompilerGenerated]
        get
        {
            return gstruct10_0;
        }
        [CompilerGenerated]
        set
        {
            gstruct10_0 = value;
        }
    }

    public GStruct10 End
    {
        [CompilerGenerated]
        get
        {
            return gstruct10_1;
        }
        [CompilerGenerated]
        set
        {
            gstruct10_1 = value;
        }
    }

    internal int Int32_0
    {
        get
        {
            if (End.int_1 < Start.int_1)
            {
                return End.int_0;
            }
            if (End.int_1 > Start.int_1)
            {
                return Start.int_0;
            }
            return Math.Min(End.int_0, Start.int_0);
        }
    }

    public Class84(GClass84 gclass84_0)
    {
        Start = gclass84_0.GStruct10_0;
        End = gclass84_0.GStruct10_1;
    }
}
