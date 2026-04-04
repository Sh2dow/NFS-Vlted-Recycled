using System;
using System.Collections.Generic;
using TextEditor;

namespace VaultEditor;

public sealed class GClass93 : IDisposable
{
    public char char_0 = '(';

    public char char_1 = ')';

    public char char_2 = '{';

    public char char_3 = '}';

    public BracketsHighlightStrategy bracketsHighlightStrategy_0 = BracketsHighlightStrategy.Strategy2;

    public readonly List<GClass85> list_0 = [];

    public readonly List<GClass94> list_1 = [];

    public readonly List<GClass95> list_2 = [];

    public void Dispose()
    {
        foreach (GClass85 item in list_0)
        {
            item.Dispose();
        }
    }
}
