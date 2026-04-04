using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class245(uint uint_3, uint uint_4, uint uint_5, IList<string> ilist_1) : GClass541
{
    public static string string_1;

    private static readonly string string_2 = "base";

    private static readonly string string_3 = "optional";

    private static readonly string string_4 = "overwrite";

    public static KeyValuePair<string, string> keyValuePair_0 = new("Overwrite base fields", string_2);

    public static KeyValuePair<string, string> keyValuePair_1 = new("Paste optional fields without overwriting anything", string_3);

    public static KeyValuePair<string, string> keyValuePair_2 = new("Only overwrite existing optional fields", string_4);

    private readonly uint uint_0 = uint_3;

    private readonly uint uint_1 = uint_4;

    private readonly uint uint_2 = uint_5;

    private readonly IList<string> ilist_0 = ilist_1;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    private string String_3 => GClass486.smethod_5(uint_2);

    [SpecialName]
    public override string vmethod_0()
    {
        return "copy_fields " + String_1 + " " + String_2 + " " + String_3 + " " + string.Join("|", ilist_0);
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
        GClass537 gClass4 = gClass2.method_2(uint_2);
        if (gClass4 == null)
        {
            gClass.method_1("The class '" + String_1 + "' does not contain node '" + String_3 + "'.");
            return gClass;
        }
        if (gClass3.Equals(gClass4))
        {
            gClass.method_1("Fields cannot be copied to the same node.");
            return gClass;
        }
        bool flag = ilist_0.Contains(string_2);
        bool flag2 = ilist_0.Contains(string_3);
        bool flag3 = ilist_0.Contains(string_4);
        if (!flag && !flag2 && !flag3)
        {
            gClass.method_1("Missing command parameters.");
            return gClass;
        }
        if (flag)
        {
            foreach (GClass151 baseField in gClass2.BaseFields)
            {
                GClass154 gclass154_ = gClass3.method_4(baseField);
                gClass4.method_4(baseField).method_1(gclass154_);
                gclass478_0.UnsavedChanges = true;
            }
        }
        if (flag2 || flag3)
        {
            foreach (GClass151 optionalField in gClass2.OptionalFields)
            {
                GClass154 gClass5 = gClass3.method_4(optionalField);
                if (gClass5 == null)
                {
                    continue;
                }
                GClass154 gClass6 = gClass4.method_4(optionalField);
                if (gClass6 != null)
                {
                    if (flag3)
                    {
                        gClass6.method_1(gClass5);
                        gclass478_0.UnsavedChanges = true;
                    }
                }
                else if (flag2)
                {
                    gClass4.method_8(optionalField, gClass3, (gClass5 as GClass155)?.MaxCount ?? 0);
                    gclass478_0.UnsavedChanges = true;
                }
            }
        }
        Class233.smethod_0(gClass4);
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        GClass536 gClass = gclass478_0.method_0(uint_0);
        if (gClass == null)
        {
            return new GClass540();
        }
        GClass537 node = gClass.method_2(uint_2);
        return new GClass540
        {
            Node = node
        };
    }
}
