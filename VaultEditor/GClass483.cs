using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass483
{
    [CompilerGenerated]
    private sealed class Class220
    {
        public uint uint_0;

        internal bool method_0(GClass537 gclass537_0)
        {
            return gclass537_0.ClassNameHash == uint_0;
        }
    }

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private IList<GClass537> ilist_0;

    [CompilerGenerated]
    private IList<GClass536> ilist_1;

    [CompilerGenerated]
    private GClass152 gclass152_0;

    [CompilerGenerated]
    private MemoryStream memoryStream_0;

    [CompilerGenerated]
    private MemoryStream memoryStream_1;

    public string Name
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public IList<GClass537> Rows
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
        [CompilerGenerated]
        set
        {
            ilist_0 = value;
        }
    }

    public IList<GClass536> Classes
    {
        [CompilerGenerated]
        get
        {
            return ilist_1;
        }
        [CompilerGenerated]
        set
        {
            ilist_1 = value;
        }
    }

    public GClass152 Types
    {
        [CompilerGenerated]
        get
        {
            return gclass152_0;
        }
        [CompilerGenerated]
        set
        {
            gclass152_0 = value;
        }
    }

    public MemoryStream BinStream
    {
        [CompilerGenerated]
        get
        {
            return memoryStream_0;
        }
        [CompilerGenerated]
        set
        {
            memoryStream_0 = value;
        }
    }

    public MemoryStream VltStream
    {
        [CompilerGenerated]
        get
        {
            return memoryStream_1;
        }
        [CompilerGenerated]
        set
        {
            memoryStream_1 = value;
        }
    }

    public GClass483(string string_1)
    {
        Name = string_1;
        Rows = [];
        Classes = [];
    }

    public IList<GClass537> method_0(uint uint_0)
    {
        return [.. (from gclass537_0 in Rows
                where gclass537_0.ClassNameHash == uint_0
                orderby gclass537_0.Level
                select gclass537_0)];
    }
}
