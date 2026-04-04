using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class238(uint uint_2, uint uint_3, string string_3) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_2;

    private readonly uint uint_1 = uint_3;

    private readonly string string_2 = string_3;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    [SpecialName]
    public override string vmethod_0()
    {
        return "convert_field " + String_1 + " " + String_2 + " " + string_2;
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        gClass.method_1("The command is not supported.");
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        gclass478_0.method_0(uint_0);
        return new GClass540();
    }
}
