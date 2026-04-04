using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public class GClass542
{
    [CompilerGenerated]
    private sealed class Class264
    {
        public GEnum24[] genum24_0;

        internal bool method_0(Tuple<string, GEnum24> tuple_0)
        {
            if (genum24_0.Length != 0)
            {
                return genum24_0.Contains(tuple_0.Item2);
            }
            return true;
        }
    }

    private readonly List<Tuple<string, GEnum24>> list_0 = [];

    public bool Boolean_0 => list_0.Any(tuple_0 => tuple_0.Item2 == GEnum24.const_1);

    public string method_0(params GEnum24[] genum24_0)
    {
        return string.Join(Environment.NewLine, from tuple_0 in list_0
                                                where genum24_0.Length == 0 || genum24_0.Contains(tuple_0.Item2)
                                                select tuple_0.Item1);
    }

    public void method_1(string string_0)
    {
        list_0.Add(new Tuple<string, GEnum24>(string_0, GEnum24.const_1));
    }

    public void method_2(string string_0)
    {
        list_0.Add(new Tuple<string, GEnum24>(string_0, GEnum24.const_0));
    }

    public void method_3(GClass542 gclass542_0)
    {
        list_0.AddRange(gclass542_0.list_0);
    }
}
