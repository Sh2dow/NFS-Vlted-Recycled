using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class251(string string_5, string string_6, string string_7) : GClass541
{
    public static string string_1;

    private readonly string string_2 = string_5;

    private readonly string string_3 = string_6;

    private readonly string string_4 = string_7;

    [SpecialName]
    public override string vmethod_0()
    {
        return "file_copy " + string_3.smethod_4() + " " + string_4.smethod_4();
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
        string destFileName = Path.Combine(gclass478_0.GameFolder, string_4);
        GClass111.smethod_5(destFileName);
        File.Copy(text, destFileName, overwrite: true);
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
