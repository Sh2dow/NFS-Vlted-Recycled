using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VaultEditor;

internal sealed class Class119
{
    private readonly IList<string> ilist_0 = ["attributes", "commerce", "fe_attrib", "cars_vault", "gameplay", "gameplay.lzc"];

    public bool method_0(Form form_0, string string_0)
    {
        string path = Path.Combine(string_0, "global");
        IList<FileInfo> list = [];
        foreach (string item2 in ilist_0)
        {
            string text = Path.Combine(path, item2 + ".bak");
            if (File.Exists(text))
            {
                FileInfo item = new(text);
                list.Add(item);
            }
        }
        if (!list.Any())
        {
            GClass109.smethod_1(form_0, "No backup files found");
            return false;
        }
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("The following file" + ((list.Count > 1) ? "s" : "") + " will be restored:");
        stringBuilder.AppendLine();
        foreach (FileInfo item3 in list)
        {
            stringBuilder.AppendLine($"{item3.Name} (Modified: {item3.LastWriteTime:F}) ");
        }
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("then the database will be automatically reloaded. All currently made changes will be discarded. Would you like to continue?");
        if (GClass109.smethod_3(form_0, stringBuilder.ToString(), DialogResult.No) == DialogResult.Yes)
        {
            foreach (FileInfo item4 in list)
            {
                string sourceFileName = Path.Combine(item4.DirectoryName, Path.ChangeExtension(item4.Name, "bak"));
                string text2 = Path.Combine(item4.DirectoryName, Path.ChangeExtension(item4.Name, item4.Name.smethod_1("gameplay.lzc") ? null : "bin"));
                GClass111.smethod_7(text2);
                File.Copy(sourceFileName, text2, overwrite: true);
            }
            return true;
        }
        return false;
    }
}
