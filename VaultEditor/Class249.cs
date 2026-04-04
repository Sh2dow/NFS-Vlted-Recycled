using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class249(string string_3) : GClass541
{
    public static string string_1;

    private readonly string string_2 = string_3;

    [CompilerGenerated]
    private Class260 class260_0;

    public Class260 Data
    {
        [CompilerGenerated]
        get
        {
            return class260_0;
        }
        [CompilerGenerated]
        private set
        {
            class260_0 = value;
        }
    }

    [SpecialName]
    public override string vmethod_0()
    {
        return "ui_text " + string_2;
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        Data = new Class260
        {
            Text = string_2,
            Type = Enum8.const_0
        };
        return new GClass542();
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
