using System;

namespace VaultEditor;

public sealed class GClass53 : GClass51
{
    private string string_4;

    private readonly string string_5;

    public GClass53(string string_6)
        : base(string_6)
    {
        string_5 = string_0.ToLower();
    }

    public override GEnum4 vmethod_1(string string_6)
    {
        int num = string_6.LastIndexOf('.');
        if (num < 0)
        {
            return GEnum4.const_0;
        }
        string text = string_6.Substring(num + 1);
        string_4 = string_6.Substring(0, num);
        if (text == "")
        {
            return GEnum4.const_1;
        }
        if (string_0.StartsWith(text, StringComparison.InvariantCultureIgnoreCase))
        {
            return GEnum4.const_2;
        }
        if (string_5.Contains(text.ToLower()))
        {
            return GEnum4.const_1;
        }
        return GEnum4.const_0;
    }

    public override string vmethod_0()
    {
        return string_4 + "." + string_0;
    }
}
