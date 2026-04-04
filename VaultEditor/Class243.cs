using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class243(string string_6, string string_7, string string_8, string string_9) : GClass541
{
    public static string string_1;

    private readonly string string_2 = string_7;

    private readonly string string_3 = string_9;

    private readonly string string_4 = string_6;

    private readonly string string_5 = string_8;

    [CompilerGenerated]
    private Class260 class260_0;

    public Class260 Data
    {
        [CompilerGenerated]
        get
        {
            return class260_0;
        }
        [CompilerGenerated]
        private set
        {
            class260_0 = value;
        }
    }

    [SpecialName]
    public override string vmethod_0()
    {
        return "ui_control " + string_4 + " " + string_2 + " " + string_5 + " \"" + string_3 + "\"";
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        string text = string_4.ToLower();
        if (!(text == "checkbox"))
        {
            if (!(text == "radiobutton"))
            {
                gClass.method_1("Not supported control type " + string_4);
            }
            else
            {
                Data = new Class260
                {
                    Text = string_3,
                    Type = Enum8.const_2,
                    Name = string_2,
                    Group = string_5
                };
            }
        }
        else
        {
            if (string_4 == "checkbox" && !string_5.smethod_0("true", "false"))
            {
                gClass.method_1("Not supported control attribute " + string_5);
            }
            bool flag = string_5.ToLower() == "true";
            Data = new Class260
            {
                Text = string_3,
                Type = Enum8.const_1,
                Name = string_2,
                Checked = flag
            };
        }
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
