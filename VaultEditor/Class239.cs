using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class239(string string_3) : GClass541
{
    public static string string_1;

    private readonly string string_2 = string_3;

    [SpecialName]
    public override string vmethod_0()
    {
        return "folder_create " + string_2.smethod_4();
    }

    public override GClass542 vmethod_2(VaultDatabase gclass478_0)
    {
        GClass542 gClass = new();
        if (string.IsNullOrEmpty(string_2))
        {
            gClass.method_1("Target folder is not set");
            return gClass;
        }
        string text = Path.Combine(gclass478_0.GameFolder, string_2);
        char[] invalidPathChars = Path.GetInvalidPathChars();
        List<char> list = [.. text.Intersect(invalidPathChars)];
        if (list.Any())
        {
            gClass.method_1("Folder can't contain the following characters: " + string.Join(", ", list));
            return gClass;
        }
        Directory.CreateDirectory(text);
        return gClass;
    }

    public override GClass540 vmethod_1(VaultDatabase gclass478_0)
    {
        return new GClass540();
    }
}
