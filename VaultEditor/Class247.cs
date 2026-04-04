using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class247(IEnumerable<string> ienumerable_1) : GClass541
{
    public static string string_1;

    private readonly IEnumerable<string> ienumerable_0 = ienumerable_1;

    [SpecialName]
    public override string vmethod_0()
    {
        return "game " + string.Join(" ", ienumerable_0);
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        IList<GEnum1> list = [];
        foreach (string item in ienumerable_0)
        {
            switch (item)
            {
                case "WB":
                    list.Add(GEnum1.const_8);
                    break;
                case "W":
                    list.Add(GEnum1.const_7);
                    break;
                case "UC":
                    list.Add(GEnum1.const_6);
                    break;
                case "PS":
                    list.Add(GEnum1.const_5);
                    break;
                case "C":
                    list.Add(GEnum1.const_4);
                    break;
                case "MW":
                    list.Add(GEnum1.const_3);
                    break;
                default:
                    gClass.method_1("The parameter is not valid: " + item);
                    return gClass;
            }
        }
        if (!list.Contains(gclass478_0.Version))
        {
            gClass.method_1("This mod supports for the following game(s):" + Environment.NewLine + string.Join(Environment.NewLine, list.Select(GClass0.smethod_0)));
        }
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
