using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class257(uint uint_2, uint uint_3) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_2;

    private readonly uint uint_1 = uint_3;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    [SpecialName]
    public override string vmethod_0()
    {
        return "delete_node " + String_1 + " " + String_2;
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
        GClass537 gClass3 = gClass2.method_2(uint_1);
        if (gClass3 == null)
        {
            gClass.method_1("The class '" + String_1 + "' does not contain node '" + String_2 + "'.");
            return gClass;
        }
        gClass2.method_8(gClass3);
        gclass478_0.UnsavedChanges = true;
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        GClass536 gClass = gclass478_0.method_0(uint_0);
        if (gClass == null)
        {
            return new GClass540();
        }
        uint uint_ = GClass486.smethod_8(String_2);
        GClass537 node = gClass.method_2(uint_);
        return new GClass540
        {
            Node = node
        };
    }
}
