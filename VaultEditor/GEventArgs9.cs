using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GEventArgs9 : EventArgs
{
    [CompilerGenerated]
    private GStruct10 gstruct10_0;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private string string_2;

    [CompilerGenerated]
    private ToolTipIcon toolTipIcon_0;

    public GStruct10 Place
    {
        [CompilerGenerated]
        get
        {
            return gstruct10_0;
        }
        [CompilerGenerated]
        private set
        {
            gstruct10_0 = value;
        }
    }

    public string HoveredWord
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

    public string ToolTipTitle
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
        [CompilerGenerated]
        set
        {
            string_1 = value;
        }
    }

    public string ToolTipText
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

    public ToolTipIcon ToolTipIcon
    {
        [CompilerGenerated]
        get
        {
            return toolTipIcon_0;
        }
        [CompilerGenerated]
        set
        {
            toolTipIcon_0 = value;
        }
    }

    public GEventArgs9(GStruct10 gstruct10_1, string string_3)
    {
        HoveredWord = string_3;
        Place = gstruct10_1;
    }
}
