using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class236(uint uint_3, uint uint_4, int int_3, uint uint_5, string string_3, int int_4) : GClass541
{
    public static int int_0;

    public static string string_1;

    private readonly uint uint_0 = uint_3;

    private readonly uint uint_1 = uint_4;

    private readonly int int_1 = int_3;

    private readonly uint uint_2 = uint_5;

    private readonly string string_2 = string_3;

    private readonly int int_2 = int_4;

    private bool bool_0;

    private bool bool_1;

    private string String_1 => GClass486.smethod_5(uint_0);

    private string String_2 => GClass486.smethod_5(uint_1);

    private string String_3 => GClass486.smethod_5(uint_2);

    [SpecialName]
    public override string vmethod_0()
    {
        string text = string.Empty;
        if (bool_1)
        {
            text = $"[{int_1}]";
        }
        string text2 = string.Empty;
        if (!bool_0)
        {
            text2 = " " + string_2;
        }
        return string.Format("{0} {1} {2} {3}{4}{5} {6}", "resize_collection", String_1, String_2, String_3, text, text2, int_2);
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
            gClass.method_1("The class '" + String_1 + "' does not contain node '" + String_2 + "'.");
            return gClass;
        }
        GClass154 gClass5 = gClass4.method_4(gClass3);
        if (gClass5 == null)
        {
            gClass.method_1("Field '" + String_3 + "' does not exist in the node '" + String_2 + "'.");
            return gClass;
        }
        if (int_2 <= 65536 && int_2 >= 0)
        {
            GClass154 gClass7;
            if (gClass5 is GClass155)
            {
                bool_1 = true;
                GClass155 gClass6 = gClass5 as GClass155;
                if (gClass6.Int32_0 <= int_1)
                {
                    gClass.method_1($"The array index '{int_1}' out of bounds.");
                    return gClass;
                }
                gClass7 = gClass6[int_1];
            }
            else
            {
                gClass7 = gClass5;
            }
            bool_0 = gClass7.IsSingleValue;
            List<GClass509> source = [.. gClass7.GetProperties().OfType<GClass509>()];
            GClass509 gClass8 = (bool_0 ? source.First() : source.SingleOrDefault(gclass509_0 => gclass509_0.DisplayName == string_2));
            if (gClass8 == null)
            {
                gClass.method_1("Value '" + string_2 + "' cannot be found.");
                return gClass;
            }
            object value = gClass8.GetValue(null);
            if (value is not IList)
            {
                gClass.method_1("Value '" + string_2 + "' is not a collection.");
                return gClass;
            }
            IList list = value as IList;
            if (int_2 < 0)
            {
                gClass.method_1("Array size must be greater than 0.");
                return gClass;
            }
            int num = int_2;
            int count = list.Count;
            if (num < count)
            {
                for (int num2 = count - 1; num2 >= num; num2--)
                {
                    list.RemoveAt(num2);
                }
            }
            else if (num > count)
            {
                Type type = list.GetType().GetGenericArguments().Single();
                for (int num3 = 0; num3 < num - count; num3++)
                {
                    object value2 = Activator.CreateInstance(type);
                    list.Add(value2);
                }
            }
            gclass478_0.UnsavedChanges = true;
            return gClass;
        }
        gClass.method_1("Size of the collection '" + String_3 + "' cannot be changed to " + $"{int_2}. The correct value is from 0 to {65536}");
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

    public void method_0(bool bool_2, bool bool_3, GEnum20 genum20_0)
    {
        bool_0 = bool_2;
        bool_1 = bool_3;
    }

    [CompilerGenerated]
    private bool method_1(GClass509 gclass509_0)
    {
        return gclass509_0.DisplayName == string_2;
    }
}
