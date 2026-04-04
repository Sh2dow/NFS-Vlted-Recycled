using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass4
{
    private readonly List<GClass6> list_0;

    private readonly int[] int_0;

    [CompilerGenerated]
    private readonly GClass11 gclass11_0;

    [CompilerGenerated]
    private readonly GClass7 gclass7_0;

    public GClass11 Metadata
    {
        [CompilerGenerated]
        get
        {
            return gclass11_0;
        }
    }

    public GClass7 RootFolder
    {
        [CompilerGenerated]
        get
        {
            return gclass7_0;
        }
    }

    internal GClass4(GClass11 gclass11_1, GClass7 gclass7_1, int[] int_1, List<GClass6> list_1)
    {
        if (gclass11_1 == null)
        {
            throw new ArgumentNullException("metadata");
        }

        if (int_1.Length != gclass11_1.DecoderSections.Count + 1)
        {
            throw new Exception1();
        }
        gclass11_0 = gclass11_1;
        gclass7_0 = gclass7_1 ?? throw new ArgumentNullException("rootFolder");
        list_0 = list_1 ?? throw new ArgumentNullException("files");
        int_0 = int_1;
    }

    public List<GClass6> method_0(int int_1)
    {
        if (int_1 < 0 || int_1 >= Metadata.DecoderSections.Count)
        {
            throw new ArgumentOutOfRangeException("sectionIndex");
        }
        int num = int_0[int_1];
        int count = int_0[int_1 + 1] - num;
        return list_0.GetRange(num, count);
    }
}
