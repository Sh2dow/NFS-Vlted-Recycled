using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class241(uint uint_3, uint uint_4, uint uint_5) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_3;

    private readonly uint uint_1 = uint_4;

    private readonly uint uint_2 = uint_5;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    private string String_3 => GClass486.smethod_5(uint_2);

    [SpecialName]
    public override string vmethod_0()
    {
        return "move_node " + String_1 + " " + String_2 + " " + String_3;
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
            gClass.method_1("Node '" + String_2 + "' does not exist.");
            return gClass;
        }
        GClass537 gClass4 = gClass2.method_2(uint_2);
        if (gClass4 == null)
        {
            gClass.method_1("Node '" + String_3 + "' does not exist.");
            return gClass;
        }
        gClass3.Remove();
        gClass3.ParentHash = gClass4.UInt32_0;
        gClass4.Nodes.Add(gClass3);
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
