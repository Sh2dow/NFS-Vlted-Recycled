using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs8 : EventArgs
{
    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    public int iLine
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        internal set
        {
            int_0 = value;
        }
    }

    public int TabLength
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        internal set
        {
            int_1 = value;
        }
    }

    public string LineText
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        internal set
        {
            string_0 = value;
        }
    }

    public string PrevLineText
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
        [CompilerGenerated]
        internal set
        {
            string_1 = value;
        }
    }

    public int Shift
    {
        [CompilerGenerated]
        get
        {
            return int_2;
        }
        [CompilerGenerated]
        set
        {
            int_2 = value;
        }
    }

    public int ShiftNextLines
    {
        [CompilerGenerated]
        get
        {
            return int_3;
        }
        [CompilerGenerated]
        set
        {
            int_3 = value;
        }
    }

    public int AbsoluteIndentation
    {
        [CompilerGenerated]
        get
        {
            return int_4;
        }
        [CompilerGenerated]
        set
        {
            int_4 = value;
        }
    }

    public GEventArgs8(int int_5, string string_2, string string_3, int int_6, int int_7)
    {
        iLine = int_5;
        LineText = string_2;
        PrevLineText = string_3;
        TabLength = int_6;
        AbsoluteIndentation = int_7;
    }
}
