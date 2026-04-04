using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class263 : Class262<GClass541>
{
    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private int int_2;

    public string Line
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

    public int LineNumber
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public bool IsComment
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

    public string ScriptName
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

    public int TextStart
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        set
        {
            int_1 = value;
        }
    }

    public int TextLength
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

    public override string ToString()
    {
        return $"{ScriptName}, line {LineNumber}";
    }

    public void method_4(VaultDatabase gclass478_0)
    {
        GClass542 gclass542_ = base.Value.vmethod_2(gclass478_0);
        method_3(gclass542_);
    }

    public bool method_5()
    {
        return base.Value != null;
    }
}
