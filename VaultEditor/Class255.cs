using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class255(uint uint_3, uint uint_4, uint uint_5, short short_1) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_3;

    private readonly uint uint_1 = uint_4;

    private readonly uint uint_2 = uint_5;

    private readonly short short_0 = short_1;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    private string String_3 => GClass486.smethod_5(uint_2);

    [SpecialName]
    public override string vmethod_0()
    {
        return string.Format("{0} {1} {2} {3} {4}", "resize_field", String_1, String_2, String_3, short_0);
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
        GClass537 gClass4 = gClass2.method_2(uint_1);
        if (gClass4 == null)
        {
            gClass.method_1("The class '" + String_1 + "' does not contain '" + String_2 + "' node.");
            return gClass;
        }
        GClass154 gClass5 = gClass4.method_4(gClass3);
        if (gClass5 == null)
        {
            gClass.method_1("The class '" + String_2 + "' does not contain '" + String_3 + "' field.");
            return gClass;
        }
        if (gClass3.Boolean_0 && gClass5 is GClass155)
        {
            GClass155 gClass6 = (GClass155)gClass5;
            if (!gClass3.Boolean_1)
            {
                if (short_0 > gClass6.MaxCount || short_0 < 0)
                {
                    gClass.method_1("Size of the array '" + String_3 + "' cannot be changed to " + $"{short_0}. The correct value is from 0 to {gClass6.MaxCount}");
                    return gClass;
                }
                gClass6.ValidCount = short_0;
                gclass478_0.UnsavedChanges = true;
            }
            else
            {
                if (short_0 < 0)
                {
                    gClass.method_1("Array size must be greater than 0.");
                    return gClass;
                }
                gClass6.method_5(short_0);
                gclass478_0.UnsavedChanges = true;
            }
            return gClass;
        }
        gClass.method_1("The field '" + String_3 + "' is not an array.");
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
