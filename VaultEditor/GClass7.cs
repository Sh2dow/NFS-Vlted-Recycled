using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass7(string string_2, string string_3, List<GClass5> list_1) : GClass5(string_2, string_3)
{
    public sealed class GClass10 : GClass8
    {
        private readonly GClass7 gclass7_0;

        private List<GClass5> list_0;

        public List<GClass5> List_0 => list_0 ?? method_1();

        public GClass10()
        {
        }

        public GClass10(GClass7 gclass7_1)
            : base(gclass7_1)
        {
            gclass7_0 = gclass7_1;
        }

        private List<GClass5> method_1()
        {
            if (gclass7_0 == null)
            {
                list_0 = [];
            }
            else
            {
                list_0 = gclass7_0.Items;
            }
            return list_0;
        }

        private List<GClass5> method_2()
        {
            if (list_0 != null)
            {
                return list_0;
            }
            if (gclass7_0 != null)
            {
                return gclass7_0.Items;
            }
            return [];
        }

        internal override GClass5 vmethod_0()
        {
            return method_3();
        }

        public GClass7 method_3()
        {
            return new GClass7(base.FullName, base.Name, method_2());
        }
    }

    [CompilerGenerated]
    private readonly List<GClass5> list_0 = list_1;

    public List<GClass5> Items
    {
        [CompilerGenerated]
        get
        {
            return list_0;
        }
    }
}
