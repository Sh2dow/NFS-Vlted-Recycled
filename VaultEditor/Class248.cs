using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class248(string string_4, string string_5) : GClass541
{
    public static string string_1;

    private readonly string string_2 = string_4;

    private readonly string string_3 = string_5;

    [CompilerGenerated]
    private Image image_0;

    public Image Image
    {
        [CompilerGenerated]
        get
        {
            return image_0;
        }
        [CompilerGenerated]
        private set
        {
            image_0 = value;
        }
    }

    [SpecialName]
    public override string vmethod_0()
    {
        return "ui_image " + string_3.smethod_4();
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        string text = Path.Combine(string_2, string_3);
        if (!File.Exists(text))
        {
            gClass.method_1("File does not exist: " + string_3);
            return gClass;
        }
        Image = Image.FromFile(text);
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
