using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class246 : GClass541
{
    public static string string_1;

    [CompilerGenerated]
    private string string_2;

    public string Path
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

    public Class246(string string_3)
    {
        Path = string_3;
    }

    [SpecialName]
    public override string vmethod_0()
    {
        return "script " + Path.smethod_4();
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
