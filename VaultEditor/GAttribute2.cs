using System;

namespace VaultEditor;

public sealed class GAttribute2 : Attribute
{
    public GEnum15 Type { get; set; }

    public int DataSize { get; set; }

    public bool IsCollection { get; set; }

    public int PreAlignBlock { get; set; }

    public int PreDataAlign { get; set; }

    public int PostDataAlign { get; set; }

    public bool CountAsFirstData { get; set; }
}
