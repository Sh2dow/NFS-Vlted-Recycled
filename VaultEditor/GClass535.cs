using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public abstract class GClass535 : TreeNode
{
    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private bool bool_1;

    [CompilerGenerated]
    private bool bool_2;

    public bool IsHighlighted
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

    public bool IsMatchedProperty
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

    public bool IsMatched
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

    public abstract GClass536 Class { get; set; }

    public bool Boolean_0
    {
        get
        {
            if (!IsMatched)
            {
                return IsMatchedProperty;
            }
            return true;
        }
    }
}
