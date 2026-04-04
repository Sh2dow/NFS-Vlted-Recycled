using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class250(uint uint_2, uint uint_3, string string_4) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_2;

    private readonly uint uint_1 = uint_3;

    private readonly string string_2 = string_4;

    public static string[] string_3 = ["db", "frontend", "cars", "commerce"];

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    [SpecialName]
    public override string vmethod_0()
    {
        return "change_vault " + String_1 + " " + String_2 + " " + string_2;
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        if (string.IsNullOrWhiteSpace(string_2))
        {
            gClass.method_1("Name cannot be empty");
            return gClass;
        }
        if (string_2.Any(char.IsWhiteSpace))
        {
            gClass.method_1("Vault name cannot contain white space");
            return gClass;
        }
        GClass536 gClass2 = gclass478_0.method_0(uint_0);
        if (gClass2 == null)
        {
            gClass.method_1("Class '" + String_1 + "' does not exist.");
            return gClass;
        }
        if (gClass2.UInt32_0 != GClass486.smethod_8("gameplay"))
        {
            gClass.method_1("Change vault name for node of the class '" + String_1 + "' is not supported.");
            return gClass;
        }
        GClass537 gClass3 = gClass2.method_2(uint_1);
        if (gClass3 == null)
        {
            gClass.method_1("Node '" + String_2 + "' does not exist.");
            return gClass;
        }
        if (string_2.ToLower().smethod_3(string_3))
        {
            gClass.method_1("Tha vault name cannot be changed to one of the following: " + string.Join(", ", string_3));
            return gClass;
        }
        gClass3.GroupName = string_2;
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
        GClass537 node = gClass.method_2(uint_1);
        return new GClass540
        {
            Node = node
        };
    }
}
