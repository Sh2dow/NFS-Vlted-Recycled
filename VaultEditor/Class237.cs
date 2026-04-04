using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class237(uint uint_3, uint uint_4, int int_2, uint uint_5, string string_5, int int_3, string string_6, object object_1) : GClass541
{
    public static string string_1;

    private readonly uint uint_0 = uint_3;

    private readonly uint uint_1 = uint_4;

    private readonly int int_0 = int_2;

    private readonly uint uint_2 = uint_5;

    private readonly string string_2 = string_5;

    private readonly string string_3 = string_6;

    private readonly int int_1 = int_3;

    private readonly object object_0 = object_1;

    private string string_4;

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
            text = $"[{int_0}]";
        }
        string text2 = string.Empty;
        if (!bool_0)
        {
            text2 = " " + string_2;
        }
        string text3 = string_4;
        if (string.IsNullOrWhiteSpace(string_4))
        {
            text3 = "\"\"";
        }
        else if (string_4.Any(char.IsWhiteSpace))
        {
            text3 = "\"" + string_4 + "\"";
        }
        return string.Format("{0} {1} {2} {3}{4}{5} {6} {7} {8}", "update_collection", String_1, String_2, String_3, text, text2, int_1, string_3, text3);
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
        GClass154 gClass7;
        if (gClass5 is GClass155)
        {
            bool_1 = true;
            GClass155 gClass6 = gClass5 as GClass155;
            if (gClass6.Int32_0 <= int_0)
            {
                gClass.method_1($"The array index '{int_0}' out of bounds.");
                return gClass;
            }
            gClass7 = gClass6[int_0];
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
        if (list.Count <= int_1)
        {
            gClass.method_1($"The array index '{int_1}' out of bounds.");
            return gClass;
        }
        object obj = list[int_1];
        if (obj is not GClass492)
        {
            gClass.method_1("Value '" + string_2 + "' is not a collection.");
            return gClass;
        }
        GClass498 gClass9 = (obj as GClass492).GetProperties().OfType<GClass498>().ToList()
            .SingleOrDefault(gclass498_0 => gclass498_0.DisplayName == string_3);
        if (gClass9 == null)
        {
            gClass.method_1(" Value '" + string_3 + "' cannot be found.");
            return gClass;
        }
        object value2;
        try
        {
            TypeConverter typeConverter = Class225.smethod_0(gClass9.GEnum20_0);
            value2 = ((typeConverter != null) ? typeConverter.ConvertFrom(object_0) : Convert.ChangeType(object_0, gClass9.PropertyType));
            string_4 = ((typeConverter != null) ? (typeConverter.ConvertTo(object_0, typeof(string)) as string) : (Convert.ChangeType(object_0, typeof(string)) as string));
        }
        catch (Exception ex)
        {
            gClass.method_1("Value cannot be parsed: " + ex.Message);
            return gClass;
        }
        gClass9.SetValue(gClass7, value2);
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

    [CompilerGenerated]
    private bool method_2(GClass498 gclass498_0)
    {
        return gclass498_0.DisplayName == string_3;
    }
}
