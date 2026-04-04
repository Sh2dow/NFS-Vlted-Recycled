using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormMwpsConverter : GForm0
{
    private readonly Class211 class211_0;

    private readonly Class118 class118_0;

    private readonly Regex regex_0 = new("(vpak|memfile).*$", RegexOptions.Multiline);

    private IContainer icontainer_0;

    private Button ButtonImportMWPS;

    private Button ButtonExportModScript;

    private Button ButtonCancel;

    private FastColoredTextBox TextBox;

    private Label InfoLabel;

    public FormMwpsConverter()
    {
        base.Commands = [];
        InitializeComponent();
        method_0();
        class118_0 = new Class118(TextBox);
        ButtonExportModScript.Enabled = false;
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | MWPS to ModScript Converter";
        Text = text;
        class211_0 = new Class211();
    }

    private void method_0()
    {
        this.smethod_2();
        InfoLabel.smethod_14();
        TextBox.smethod_20();
        ButtonExportModScript.smethod_5();
        ButtonCancel.smethod_5();
        ButtonImportMWPS.smethod_5();
    }

    private void ButtonImportMWPS_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            AddExtension = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DefaultExt = "mwps",
            ShowReadOnly = true,
            Title = "Import NFS:MW Patch Script",
            Filter = "NFS:MW Patch Script (*.mwps)|*.mwps",
            Multiselect = false
        };
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        try
        {
            InfoLabel.Text = string.Empty;
            ButtonExportModScript.Enabled = false;
            int num = 0;
            byte[] bytes = File.ReadAllBytes(openFileDialog.FileName);
            byte[] bytes2 = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes);
            string text = Encoding.UTF8.GetString(bytes2);
            class211_0.method_0(text);
            foreach (Class208 item in class211_0.ParsedEntries.OrderByDescending(class208_0 => class208_0.ScriptTextStart))
            {
                if (item.Boolean_0)
                {
                    num++;
                    int num2 = item.ScriptTextStart + item.ScriptTextLength;
                    text = text.Substring(0, num2) + " !!! " + item.ValidationMessage + " " + text.Substring(num2);
                }
                else
                {
                    int scriptTextStart = item.ScriptTextStart;
                    int startIndex = item.ScriptTextStart + item.ScriptTextLength;
                    text = text.Substring(0, scriptTextStart) + item.Command.vmethod_0() + text.Substring(startIndex);
                }
            }
            text = regex_0.Replace(text, string.Empty);
            if (num > 0)
            {
                InfoLabel.Text = $"{num} error(s)";
            }
            TextBox.Text = text;
            ButtonExportModScript.Enabled = class211_0.ParsedEntries.Any();
        }
        catch (Exception ex)
        {
            GClass109.smethod_1(this, "The script is either corrupted or not a supported format." + Environment.NewLine + Environment.NewLine + ex.Message);
        }
    }

    private void ButtonExportModScript_Click(object sender, EventArgs e)
    {
        string text = TextBox.Text;
        if (string.IsNullOrWhiteSpace(text))
        {
            GClass109.smethod_0(this, "No changes to export.");
            return;
        }
        SaveFileDialog saveFileDialog = new()
        {
            AddExtension = true,
            DefaultExt = "nfsms",
            Title = "Export ModScript file",
            Filter = "*.nfsms|*.nfsms"
        };
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        string fileName = saveFileDialog.FileName;
        try
        {
            File.WriteAllText(fileName, text);
        }
        catch (Exception)
        {
            GClass109.smethod_1(this, "Unable to export file");
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    protected void Dispose(bool disposing)
    {
        if (disposing && icontainer_0 != null)
        {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.icontainer_0 = new System.ComponentModel.Container();
        this.ButtonImportMWPS = new System.Windows.Forms.Button();
        this.ButtonExportModScript = new System.Windows.Forms.Button();
        this.ButtonCancel = new System.Windows.Forms.Button();
        this.TextBox = new VaultEditor.FastColoredTextBox();
        this.InfoLabel = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)this.TextBox).BeginInit();
        base.SuspendLayout();
        this.ButtonImportMWPS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.ButtonImportMWPS.Location = new System.Drawing.Point(585, 404);
        this.ButtonImportMWPS.Name = "ButtonImportMWPS";
        this.ButtonImportMWPS.Size = new System.Drawing.Size(108, 34);
        this.ButtonImportMWPS.TabIndex = 1;
        this.ButtonImportMWPS.Text = "Import MWPS";
        this.ButtonImportMWPS.UseVisualStyleBackColor = true;
        this.ButtonImportMWPS.Click += new System.EventHandler(ButtonImportMWPS_Click);
        this.ButtonExportModScript.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.ButtonExportModScript.Location = new System.Drawing.Point(699, 404);
        this.ButtonExportModScript.Name = "ButtonExportModScript";
        this.ButtonExportModScript.Size = new System.Drawing.Size(108, 34);
        this.ButtonExportModScript.TabIndex = 2;
        this.ButtonExportModScript.Text = "Export ModScript";
        this.ButtonExportModScript.UseVisualStyleBackColor = true;
        this.ButtonExportModScript.Click += new System.EventHandler(ButtonExportModScript_Click);
        this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.ButtonCancel.Location = new System.Drawing.Point(12, 404);
        this.ButtonCancel.Name = "ButtonCancel";
        this.ButtonCancel.Size = new System.Drawing.Size(108, 34);
        this.ButtonCancel.TabIndex = 3;
        this.ButtonCancel.Text = "Close";
        this.ButtonCancel.UseVisualStyleBackColor = true;
        this.ButtonCancel.Click += new System.EventHandler(ButtonCancel_Click);
        this.TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.TextBox.Char_0 = ['(', ')', '{', '}', '[', ']', '"', '"', '\'', '\''];
        this.TextBox.Size_0 = new System.Drawing.Size(27, 14);
        this.TextBox.Brush_0 = null;
        this.TextBox.Int32_1 = 14;
        this.TextBox.CharWidth = 8;
        this.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.TextBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
        this.TextBox.Font = new System.Drawing.Font("Courier New", 9.75f);
        this.TextBox.Boolean_6 = false;
        this.TextBox.Location = new System.Drawing.Point(12, 12);
        this.TextBox.Name = "TextBox";
        this.TextBox.Paddings = new System.Windows.Forms.Padding(0);
        this.TextBox.Color_8 = System.Drawing.Color.FromArgb(60, 0, 0, 255);
        this.TextBox.ServiceColors = null;
        this.TextBox.Size = new System.Drawing.Size(795, 386);
        this.TextBox.TabIndex = 4;
        this.TextBox.Int32_13 = 100;
        this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.InfoLabel.Location = new System.Drawing.Point(126, 404);
        this.InfoLabel.Name = "InfoLabel";
        this.InfoLabel.Size = new System.Drawing.Size(453, 34);
        this.InfoLabel.TabIndex = 6;
        this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(819, 450);
        base.Controls.Add(this.InfoLabel);
        base.Controls.Add(this.TextBox);
        base.Controls.Add(this.ButtonCancel);
        base.Controls.Add(this.ButtonExportModScript);
        base.Controls.Add(this.ButtonImportMWPS);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(500, 350);
        base.Name = "FormMwpsConverter";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormImportResult";
        ((System.ComponentModel.ISupportInitialize)this.TextBox).EndInit();
        base.ResumeLayout(false);
    }
}
