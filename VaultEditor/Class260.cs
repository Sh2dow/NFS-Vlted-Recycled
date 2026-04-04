using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class260
{
    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private string string_2;

    [CompilerGenerated]
    private Enum8 enum8_0;

    [CompilerGenerated]
    private bool bool_0;

    public string Group
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

    public string Name
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

    public string Text
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

    public Enum8 Type
    {
        [CompilerGenerated]
        get
        {
            return enum8_0;
        }
        [CompilerGenerated]
        set
        {
            enum8_0 = value;
        }
    }

    public bool Checked
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

    public string String_0 => Name + Group;
}
