using System.Collections.Generic;

namespace VaultEditor;

public struct GStruct9(int int_3)
{
    private List<int> list_0 = null;

    internal int int_0 = int_3;

    internal int int_1 = 0;

    internal int int_2 = 0;

    public GEnum10 genum10_0 = GEnum10.const_0;

    public List<int> List_0
    {
        get
        {
            list_0 ??= [];
            return list_0;
        }
    }

    public readonly int Int32_0
    {
        get
        {
            switch (genum10_0)
            {
                default:
                    return 0;
                case GEnum10.const_0:
                    if (list_0 == null)
                    {
                        return 1;
                    }
                    return list_0.Count + 1;
                case GEnum10.const_1:
                    return 1;
                case GEnum10.const_2:
                    return 0;
            }
        }
    }

    internal int method_0(int int_3)
    {
        if (int_3 != 0)
        {
            return List_0[int_3 - 1];
        }
        return 0;
    }

    internal int method_1(int int_3, GClass80 gclass80_0)
    {
        if (Int32_0 <= 0)
        {
            return 0;
        }
        if (int_3 != Int32_0 - 1)
        {
            return List_0[int_3] - 1;
        }
        return gclass80_0.Count - 1;
    }

    public readonly int method_2(int int_3)
    {
        if (list_0 != null && list_0.Count != 0)
        {
            int num = 0;
            while (true)
            {
                if (num < list_0.Count)
                {
                    if (list_0[num] > int_3)
                    {
                        break;
                    }
                    num++;
                    continue;
                }
                return list_0.Count;
            }
            return num;
        }
        return 0;
    }
}
