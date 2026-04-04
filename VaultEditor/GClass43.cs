using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass43
{
    private long long_0;

    private int int_0;

    private int int_1;

    private int int_2;

    private int int_3;

    private int int_4;

    private int int_5;

    private int int_6;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private bool bool_1;

    [CompilerGenerated]
    private bool bool_2;

    [CompilerGenerated]
    private bool bool_3;

    public bool FastMode
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

    public bool BinaryTreeMode
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

    public bool MultiThreaded
    {
        [CompilerGenerated]
        get
        {
            return bool_2;
        }
        [CompilerGenerated]
        set
        {
            bool_2 = value;
        }
    }

    public bool WriteEndMark
    {
        [CompilerGenerated]
        get
        {
            return bool_3;
        }
        [CompilerGenerated]
        set
        {
            bool_3 = value;
        }
    }

    public long Int64_0
    {
        get
        {
            return long_0;
        }
        set
        {
            if (value < 0L)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            long_0 = value;
        }
    }

    public int Int32_0
    {
        get
        {
            return int_0;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            int_0 = value;
        }
    }

    public int Int32_1
    {
        get
        {
            return int_1;
        }
        set
        {
            if (value < 0 || value > 8)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            int_1 = value;
        }
    }

    public int Int32_2
    {
        get
        {
            return int_2;
        }
        set
        {
            if (value < 0 || value > 4)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            int_2 = value;
        }
    }

    public int Int32_3
    {
        get
        {
            return int_3;
        }
        set
        {
            if (value < 0 || value > 4)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            int_3 = value;
        }
    }

    public int Int32_4
    {
        get
        {
            return int_4;
        }
        set
        {
            if (value < 5 || value > 273)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            int_4 = value;
        }
    }

    public int Int32_5
    {
        get
        {
            return int_6;
        }
        set
        {
            if (value < 1 || value > 1073741824)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            int_6 = value;
        }
    }

    public int Int32_6
    {
        get
        {
            return int_5;
        }
        set
        {
            if (value < 2 || value > 4)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            int_5 = value;
        }
    }

    public GClass43()
    {
        long_0 = long.MaxValue;
        WriteEndMark = false;
        method_0(5);
    }

    public void method_0(int int_7)
    {
        if (int_7 >= 0 && int_7 <= 9)
        {
            if (int_7 <= 5)
            {
                int_0 = 1 << int_7 * 2 + 14;
            }
            else if (int_7 == 6)
            {
                int_0 = 33554432;
            }
            else
            {
                int_0 = 67108864;
            }
            int_1 = 3;
            int_2 = 0;
            int_3 = 2;
            FastMode = int_7 <= 4;
            int_4 = ((int_7 <= 6) ? 32 : 64);
            BinaryTreeMode = !FastMode;
            int_5 = 4;
            if (int_7 <= 4)
            {
                int_6 = 16;
            }
            else if (int_7 <= 6)
            {
                int_6 = 32;
            }
            else
            {
                int_6 = 48;
            }
            MultiThreaded = BinaryTreeMode && !FastMode;
            return;
        }
        throw new ArgumentOutOfRangeException("level");
    }

    public GClass41 method_1()
    {
        return new GClass41((uint)int_0, (byte)int_1, (byte)int_3, (byte)int_2);
    }

    internal Class52.Class67 method_2()
    {
        Class52.Class67 @class = Class52.Class67.smethod_0();
        @class.uint_0 = (uint)int_0;
        @class.uint_1 = (uint)((long_0 > 4294967295L) ? uint.MaxValue : long_0);
        @class.int_1 = int_1;
        @class.int_2 = int_2;
        @class.int_3 = int_3;
        @class.int_4 = ((!FastMode) ? 1 : 0);
        @class.int_5 = int_4;
        @class.int_6 = (BinaryTreeMode ? 1 : 0);
        @class.int_7 = int_5;
        @class.uint_2 = (uint)int_6;
        @class.uint_3 = (WriteEndMark ? 1u : 0u);
        @class.int_8 = ((!MultiThreaded) ? 1 : 2);
        return @class;
    }

    private static void smethod_0(Class52.Class67 class67_0, IList<byte> ilist_0)
    {
        class67_0.method_0();
        uint num = class67_0.uint_0;
        ilist_0.Add((byte)((class67_0.int_3 * 5 + class67_0.int_2) * 9 + class67_0.int_1));
        for (int i = 11; i <= 30; i++)
        {
            if (num > (uint)(2 << i))
            {
                if (num <= (uint)(3 << i))
                {
                    num = (uint)(3 << i);
                    break;
                }
                continue;
            }
            num = (uint)(2 << i);
            break;
        }
        for (int j = 0; j < 4; j++)
        {
            ilist_0.Add((byte)(num >> 8 * j));
        }
    }

    internal byte[] method_3()
    {
        List<byte> list = [];
        smethod_0(method_2(), list);
        return [.. list];
    }
}
