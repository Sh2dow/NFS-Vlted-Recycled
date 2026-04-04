using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public static class GClass144
{
    [CompilerGenerated]
    private sealed class Class196
    {
        public string string_0;

        public Func<GClass154, bool> func_0;

        internal bool method_0(GClass154 gclass154_0)
        {
            return gclass154_0.GetType().Name.smethod_1(string_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class197
    {
        public string string_0;

        public Func<string, bool> func_0;

        public Func<string, bool> func_1;

        internal bool method_0(string string_1)
        {
            return string_1?.smethod_1(string_0) ?? false;
        }

        internal bool method_1(string string_1)
        {
            return string_1?.smethod_1(string_0) ?? false;
        }
    }

    public static IEnumerable<GClass535> smethod_0(this TreeView treeView_0)
    {
        return treeView_0.Nodes.smethod_1();
    }

    public static IEnumerable<GClass535> smethod_1(this TreeNodeCollection treeNodeCollection_0)
    {
        IEnumerable<GClass535> enumerable = treeNodeCollection_0.OfType<GClass535>();
        foreach (GClass535 item in enumerable)
        {
            yield return item;
            IEnumerable<GClass535> enumerable2 = item.Nodes.smethod_1();
            foreach (GClass535 item2 in enumerable2)
            {
                yield return item2;
            }
        }
    }

    public static void smethod_2(this TreeView treeView_0)
    {
        List<GClass535> list = [.. treeView_0.smethod_0()];
        GClass535 gClass = ((treeView_0.SelectedNode is GClass535 item) ? (list.Skip(list.IndexOf(item)).Skip(1).FirstOrDefault(gclass535_0 => gclass535_0.Boolean_0) ?? list.FirstOrDefault(gclass535_0 => gclass535_0.Boolean_0)) : list.FirstOrDefault(gclass535_0 => gclass535_0.Boolean_0));
        if (gClass != null)
        {
            treeView_0.Focus();
            treeView_0.SelectedNode = gClass;
        }
    }

    public static int smethod_3(this TreeView treeView_0, string string_0)
    {
        int num = 0;
        IEnumerable<GClass535> enumerable = treeView_0.smethod_0();
        foreach (GClass535 item in enumerable)
        {
            item.IsHighlighted = false;
        }
        foreach (GClass535 item2 in enumerable)
        {
            bool flag = false;
            if (item2 is GClass537)
            {
                foreach (GClass154 item3 in item2 as GClass537)
                {
                    if (item3 is GClass155)
                    {
                        if ((item3 as GClass155).Any(gclass154_0 => gclass154_0.GetType().Name.smethod_1(string_0)))
                        {
                            flag = true;
                        }
                    }
                    else if (item3.GetType().Name.smethod_1(string_0))
                    {
                        flag = true;
                    }
                }
            }
            item2.IsMatched = flag;
            if (flag)
            {
                smethod_5(item2);
                num++;
            }
        }
        treeView_0.Refresh();
        return num;
    }

    public static int smethod_4(this TreeView treeView_0, string string_0, string string_1, string string_2)
    {
        bool flag = !string.IsNullOrWhiteSpace(string_0);
        bool flag2 = !string.IsNullOrWhiteSpace(string_1);
        bool flag3 = !string.IsNullOrWhiteSpace(string_2);
        bool flag4 = flag || flag2 || flag3;
        int num = 0;
        List<GClass535> list = [.. treeView_0.smethod_0()];
        foreach (GClass535 item in list)
        {
            item.IsHighlighted = false;
            item.IsMatched = false;
            item.IsMatchedProperty = false;
            if (item is not GClass537 gClass)
            {
                continue;
            }
            foreach (GClass154 item2 in gClass)
            {
                item2.IsMatched = false;
            }
        }
        if (flag4)
        {
            foreach (GClass535 item3 in list)
            {
                bool flag5 = false;
                bool flag6 = false;
                if (flag)
                {
                    flag6 = item3.Text.smethod_1(string_0);
                }
                bool flag7 = !flag || flag6;
                if (item3 is GClass537 gClass2)
                {
                    foreach (GClass154 item4 in gClass2)
                    {
                        bool flag8 = false;
                        if (flag2 && flag7)
                        {
                            flag8 = GClass486.smethod_5(item4.Field.NameHash).smethod_1(string_1);
                        }
                        bool flag9 = false;
                        if (flag3 && flag7)
                        {
                            if (item4 is GClass155 gClass3)
                            {
                                foreach (GClass154 item5 in gClass3)
                                {
                                    if (flag9 || (flag9 = item5.ToString().smethod_1(string_2)))
                                    {
                                        continue;
                                    }
                                    foreach (GInterface5 item6 in GClass107<GInterface5>.smethod_1(item5))
                                    {
                                        flag9 = item6.imethod_7(text => text?.smethod_1(string_2) ?? false);
                                    }
                                }
                            }
                            else if (!(flag9 = item4.ToString().smethod_1(string_2)))
                            {
                                foreach (GInterface5 item7 in GClass107<GInterface5>.smethod_1(item4))
                                {
                                    flag9 = item7.imethod_7(text => text?.smethod_1(string_2) ?? false);
                                }
                            }
                        }
                        if (flag7 && (!flag2 || flag8) && (!flag3 || flag9))
                        {
                            item3.IsMatched = flag6;
                            item3.IsMatchedProperty = flag8 || flag9;
                            item4.IsMatched = flag8 || flag9;
                            gClass2.IsMatched = flag6 || item4.IsMatched;
                            flag5 = true;
                        }
                    }
                }
                if (flag5)
                {
                    smethod_5(item3);
                    num++;
                }
            }
        }
        treeView_0.Refresh();
        return num;
    }

    private static void smethod_5(GClass535 gclass535_0)
    {
        if (gclass535_0 != null && !gclass535_0.IsHighlighted)
        {
            gclass535_0.IsHighlighted = true;
            if (gclass535_0.Parent != null)
            {
                smethod_5(gclass535_0.Parent as GClass535);
            }
        }
    }
}
