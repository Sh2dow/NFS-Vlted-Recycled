using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class208
{
    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private int int_2;

    [CompilerGenerated]
    private string string_2;

    [CompilerGenerated]
    private GClass541 gclass541_0;

    public bool IsBin
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

    public int Offset
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

    public string Type
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

    public string Value
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

    public int ScriptTextStart
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

    public int ScriptTextLength
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

    public string ValidationMessage
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

    public GClass541 Command
    {
        [CompilerGenerated]
        get
        {
            return gclass541_0;
        }
        [CompilerGenerated]
        set
        {
            gclass541_0 = value;
        }
    }

    public bool Boolean_0 => !string.IsNullOrWhiteSpace(ValidationMessage);
}
