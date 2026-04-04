using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class256(uint uint_3, uint uint_4, string string_3) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_3;

    private uint uint_1;

    private readonly uint uint_2 = uint_4;

    private readonly string string_2 = string_3;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    private string String_3 => GClass486.smethod_5(uint_2);

    [SpecialName]
    public override string vmethod_0()
    {
        string text = ((uint_2 == 0) ? "" : (" " + String_3));
        return "add_node " + String_1 + text + " " + String_2;
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
            gClass.method_1("Name cannot contain white space");
            return gClass;
        }
        uint uint_;
        try
        {
            uint_ = GClass486.smethod_8(string_2, bool_0: true);
        }
        catch (Exception ex)
        {
            gClass.method_1("Invalid hash: " + ex.Message);
            return gClass;
        }
        GClass536 gClass2 = gclass478_0.method_0(uint_0);
        if (gClass2 == null)
        {
            gClass.method_1("Class '" + String_1 + "' does not exist.");
            return gClass;
        }
        if (gClass2.method_2(uint_) != null)
        {
            gClass.method_1("The child node '" + string_2 + "' of the class '" + String_1 + "' with the same name already exists.");
            return gClass;
        }
        GClass537 gclass537_;
        if (uint_2 == 0)
        {
            gClass2.method_4();
            gclass537_ = gClass2.method_10(gClass2, string_2);
            gclass478_0.UnsavedChanges = true;
        }
        else
        {
            GClass537 gClass3 = gClass2.method_2(uint_2);
            if (gClass3 == null)
            {
                gClass.method_1("The class '" + String_1 + "' does not contain node '" + String_3 + "'.");
                return gClass;
            }
            gclass537_ = gClass2.method_10(gClass3, string_2);
            gclass478_0.UnsavedChanges = true;
        }
        Class233.smethod_0(gclass537_);
        uint_1 = uint_;
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        GClass536 gClass = gclass478_0.method_0(uint_0);
        if (gClass == null)
        {
            return new GClass540();
        }
        uint uint_ = GClass486.smethod_8(string_2);
        GClass537 node = gClass.method_2(uint_);
        return new GClass540
        {
            Node = node
        };
    }
}
