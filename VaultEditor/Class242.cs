using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class242(string string_4, string string_5) : GClass541
{
    public static string string_1;

    [CompilerGenerated]
    private readonly string string_2 = string_4;

    [CompilerGenerated]
    private readonly string string_3 = string_5;

    public string ControlName
    {
        [CompilerGenerated]
        get
        {
            return string_2;
        }
    }

    public string Group
    {
        [CompilerGenerated]
        get
        {
            return string_3;
        }
    }

    public string String_1 => ControlName + Group;

    [SpecialName]
    public override string vmethod_0()
    {
        return "ui_option " + ControlName + " " + Group;
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        return new GClass542();
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
