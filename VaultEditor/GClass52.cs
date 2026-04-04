using System;

namespace VaultEditor;

public sealed class GClass52 : GClass51
{
    public GClass52(string string_4)
    {
        string_0 = string_4.Replace("\r", "");
        vmethod_4("Code snippet:");
        vmethod_6(string_0);
    }

    public override string ToString()
    {
        return vmethod_7() ?? string_0.Replace("\n", " ").Replace("^", "");
    }

    public override string vmethod_0()
    {
        return string_0;
    }

    public override void vmethod_2(GClass55 gclass55_1, GEventArgs1 geventArgs1_0)
    {
        geventArgs1_0.Tb.method_86();
        geventArgs1_0.Tb.GClass84_5.method_38();
        GStruct10 gStruct10_ = gclass55_1.Fragment.GStruct10_0;
        GStruct10 gStruct10_2 = geventArgs1_0.Tb.GClass84_5.GStruct10_0;
        if (geventArgs1_0.Tb.AutoIndent)
        {
            for (int i = gStruct10_.int_1 + 1; i <= gStruct10_2.int_1; i++)
            {
                geventArgs1_0.Tb.GClass84_5.GStruct10_0 = new GStruct10(0, i);
                geventArgs1_0.Tb.vmethod_44(i);
            }
        }
        geventArgs1_0.Tb.GClass84_5.GStruct10_0 = gStruct10_;
        while (geventArgs1_0.Tb.GClass84_5.Char_1 != '^' && geventArgs1_0.Tb.GClass84_5.vmethod_3())
        {
        }
        geventArgs1_0.Tb.GClass84_5.method_10(bool_1: true);
        geventArgs1_0.Tb.vmethod_20("");
        geventArgs1_0.Tb.GClass84_5.method_39();
        geventArgs1_0.Tb.method_87();
    }

    public override GEnum4 vmethod_1(string string_4)
    {
        if (string_0.StartsWith(string_4, StringComparison.InvariantCultureIgnoreCase) && string_0 != string_4)
        {
            return GEnum4.const_1;
        }
        return GEnum4.const_0;
    }
}
