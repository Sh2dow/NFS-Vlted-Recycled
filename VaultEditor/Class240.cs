using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class240(uint uint_1) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_1;

    private string String_1 => GClass486.smethod_5(uint_0);

    [SpecialName]
    public override string vmethod_0()
    {
        return "delete_nodes " + String_1;
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        GClass536 gClass2 = gclass478_0.method_0(uint_0);
        if (gClass2 == null)
        {
            gClass.method_1("Class '" + String_1 + "' does not exist.");
            return gClass;
        }
        gClass2.method_9();
        gclass478_0.UnsavedChanges = true;
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
