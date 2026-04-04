using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TextEditor;

namespace VaultEditor;

internal sealed class Class96
{
    private bool bool_0;

    private bool bool_1;

    private bool bool_2;

    [CompilerGenerated]
    private Keys keys_0;

    [CompilerGenerated]
    private FCTBAction fctbaction_0;

    public Keys Key
    {
        [CompilerGenerated]
        get
        {
            return keys_0;
        }
        [CompilerGenerated]
        set
        {
            keys_0 = value;
        }
    }

    public FCTBAction Action
    {
        [CompilerGenerated]
        get
        {
            return fctbaction_0;
        }
        [CompilerGenerated]
        set
        {
            fctbaction_0 = value;
        }
    }

    public string String_0
    {
        get
        {
            string text = "";
            if (bool_0)
            {
                text += "Ctrl + ";
            }
            if (bool_1)
            {
                text += "Shift + ";
            }
            if (bool_2)
            {
                text += "Alt + ";
            }
            return text.Trim(' ', '+');
        }
        set
        {
            if (value == null)
            {
                bool_1 = false;
                bool_2 = false;
                bool_0 = false;
            }
            else
            {
                bool_0 = value.Contains("Ctrl");
                bool_1 = value.Contains("Shift");
                bool_2 = value.Contains("Alt");
            }
        }
    }

    public Class96(Keys keys_1, FCTBAction fctbaction_1)
    {
        KeyEventArgs e = new(keys_1);
        bool_0 = e.Control;
        bool_1 = e.Shift;
        bool_2 = e.Alt;
        Key = e.KeyCode;
        Action = fctbaction_1;
    }

    public Keys method_0()
    {
        Keys keys = Key;
        if (bool_0)
        {
            keys |= Keys.Control;
        }
        if (bool_2)
        {
            keys |= Keys.Alt;
        }
        if (bool_1)
        {
            keys |= Keys.Shift;
        }
        return keys;
    }
}
