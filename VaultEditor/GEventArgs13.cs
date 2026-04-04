using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GEventArgs13 : EventArgs
{
    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private string string_2;

    public string SourceLineText
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        private set
        {
            string_0 = value;
        }
    }

    public int DisplayedLineIndex
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

    public string DisplayedLineText
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
        [CompilerGenerated]
        private set
        {
            string_1 = value;
        }
    }

    public string SavedText
    {
        [CompilerGenerated]
        get
        {
            return string_2;
        }
        [CompilerGenerated]
        set
        {
            string_2 = value;
        }
    }

    public GEventArgs13(string string_3, int int_1, string string_4)
    {
        SourceLineText = string_3;
        DisplayedLineIndex = int_1;
        DisplayedLineText = string_4;
        SavedText = string_4;
    }
}
