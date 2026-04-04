using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public class GForm0 : Form
{
    [CompilerGenerated]
    private VaultDatabase gclass478_0;

    [CompilerGenerated]
    private TreeView treeView_0;

    [CompilerGenerated]
    private IList<GClass541> ilist_0;

    internal VaultDatabase Database
    {
        [CompilerGenerated]
        get
        {
            return gclass478_0;
        }
        [CompilerGenerated]
        set
        {
            gclass478_0 = value;
        }
    }

    internal TreeView ClassesTree
    {
        [CompilerGenerated]
        get
        {
            return treeView_0;
        }
        [CompilerGenerated]
        set
        {
            treeView_0 = value;
        }
    }

    public IList<GClass541> Commands
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
        [CompilerGenerated]
        protected set
        {
            ilist_0 = value;
        }
    }
}
