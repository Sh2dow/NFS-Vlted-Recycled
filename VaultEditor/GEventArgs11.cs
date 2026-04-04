using System;
using System.Runtime.CompilerServices;
using TextEditor;

namespace VaultEditor;

public sealed class GEventArgs11 : EventArgs
{
    [CompilerGenerated]
    private FCTBAction fctbaction_0;

    public FCTBAction Action
    {
        [CompilerGenerated]
        get
        {
            return fctbaction_0;
        }
        [CompilerGenerated]
        private set
        {
            fctbaction_0 = value;
        }
    }

    public GEventArgs11(FCTBAction fctbaction_1)
    {
        Action = fctbaction_1;
    }
}
