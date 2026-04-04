using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class253(uint uint_3, uint uint_4, uint uint_5) : GClass541
{
    private readonly uint uint_0 = uint_3;

    private readonly uint uint_1 = uint_4;

    private readonly uint uint_2 = uint_5;

    public static string string_1;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    private string String_3 => GClass486.smethod_5(uint_2);

    [SpecialName]
    public override string vmethod_0()
    {
        return "delete_field " + String_1 + " " + String_2 + " " + String_3;
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
        GClass151 gClass3 = gClass2.method_7(uint_2);
        if (gClass3 == null)
        {
            gClass.method_1("The class '" + String_1 + "' does not contain '" + String_3 + "' field.");
            return gClass;
        }
        if (!gClass3.Boolean_1)
        {
            gClass.method_1("The field '" + String_3 + "' cannot be removed. Only optional fields can be removed.");
            return gClass;
        }
        GClass537 gClass4 = gClass2.method_2(uint_1);
        if (gClass4 == null)
        {
            gClass.method_1("The class '" + String_1 + "' does not contain '" + String_2 + "' node.");
            return gClass;
        }
        GClass154 gClass5 = gClass4.method_4(gClass3);
        if (gClass5 == null)
        {
            gClass.method_1("The node '" + String_2 + "' does not contain '" + String_3 + "' field.");
            return gClass;
        }
        gClass4.method_7(gClass5);
        gclass478_0.UnsavedChanges = true;
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
