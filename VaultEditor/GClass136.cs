using System;
using System.Linq;

namespace VaultEditor;

public static class GClass136
{
    public static void smethod_0(this GClass537 gclass537_0, Action<GClass154> action_0)
    {
        foreach (GClass154 item in gclass537_0)
        {
            if (item is GClass155)
            {
                GClass155 gClass = item as GClass155;
                smethod_1(action_0, gClass);
                foreach (GClass154 item2 in gClass)
                {
                    smethod_1(action_0, item2);
                }
            }
            else
            {
                smethod_1(action_0, item);
            }
        }
    }

    private static void smethod_1(Action<GClass154> action_0, GClass154 gclass154_0)
    {
        action_0(gclass154_0);
    }

    public static void smethod_2(this GClass537 gclass537_0, Action<GClass537> action_0)
    {
        action_0(gclass537_0);
        foreach (GClass537 item in gclass537_0.Nodes.OfType<GClass537>())
        {
            item.smethod_2(action_0);
        }
    }
}
