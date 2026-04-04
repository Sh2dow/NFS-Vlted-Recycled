using System.Drawing;
using System.Windows.Forms;

namespace VaultEditor;

public static class GClass137
{
    public static void smethod_0(this RichTextBox richTextBox_0, string string_0, Color color_0)
    {
        richTextBox_0.SelectionStart = richTextBox_0.TextLength;
        richTextBox_0.SelectionLength = 0;
        richTextBox_0.SelectionColor = color_0;
        richTextBox_0.AppendText(string_0);
        richTextBox_0.SelectionColor = richTextBox_0.ForeColor;
    }
}
