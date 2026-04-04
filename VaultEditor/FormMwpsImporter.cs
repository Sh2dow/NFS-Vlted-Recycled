using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormMwpsImporter : GForm0
{
    private readonly Class211 class211_0;

    private readonly Class118 class118_0;

    private IContainer icontainer_0;

    private Button ButtonImport;

    private Button ButtonOK;

    private Button ButtonCancel;

    private FastColoredTextBox TextBox;

    private Label InfoLabel;

    public FormMwpsImporter()
    {
        base.Commands = [];
        InitializeComponent();
        method_0();
        class118_0 = new Class118(TextBox);
        ButtonOK.Enabled = false;
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | MWPS Import results";
        Text = text;
        class211_0 = new Class211();
    }

    private void method_0()
    {
        this.smethod_2();
        InfoLabel.smethod_14();
        TextBox.smethod_20();
        ButtonOK.smethod_5();
        ButtonCancel.smethod_5();
        ButtonImport.smethod_5();
    }

    private void ButtonImport_Click(object sender, EventArgs e)
    {
        InfoLabel.Text = string.Empty;
        ButtonOK.Enabled = false;
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
            }
            if (num > 0)
            {
                InfoLabel.Text = $"{num} error(s)";
            }
            TextBox.Text = text;
            ButtonOK.Enabled = class211_0.ParsedEntries.Any();
        }
        catch (Exception ex)
        {
            GClass109.smethod_1(this, "The script is either corrupted or not a supported format." + Environment.NewLine + Environment.NewLine + ex.Message);
        }
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
        base.Commands.Clear();
        if (class211_0.ParsedEntries.Any())
        {
            foreach (GClass541 item in from class208_0 in class211_0.ParsedEntries
                                       where class208_0.Command != null
                                       select class208_0.Command)
            {
                if (!item.vmethod_2(base.Database).Boolean_0)
                {
                    base.Commands.Add(item);
                }
            }
        }
        Close();
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
        this.ButtonImport = new System.Windows.Forms.Button();
        this.ButtonOK = new System.Windows.Forms.Button();
        this.ButtonCancel = new System.Windows.Forms.Button();
        this.TextBox = new VaultEditor.FastColoredTextBox();
        this.InfoLabel = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)this.TextBox).BeginInit();
        base.SuspendLayout();
        this.ButtonImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.ButtonImport.Location = new System.Drawing.Point(585, 404);
        this.ButtonImport.Name = "ButtonImport";
        this.ButtonImport.Size = new System.Drawing.Size(108, 34);
        this.ButtonImport.TabIndex = 1;
        this.ButtonImport.Text = "Import";
        this.ButtonImport.UseVisualStyleBackColor = true;
        this.ButtonImport.Click += new System.EventHandler(ButtonImport_Click);
        this.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.ButtonOK.Location = new System.Drawing.Point(699, 404);
        this.ButtonOK.Name = "ButtonOK";
        this.ButtonOK.Size = new System.Drawing.Size(108, 34);
        this.ButtonOK.TabIndex = 2;
        this.ButtonOK.Text = "OK";
        this.ButtonOK.UseVisualStyleBackColor = true;
        this.ButtonOK.Click += new System.EventHandler(ButtonOK_Click);
        this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.ButtonCancel.Location = new System.Drawing.Point(12, 404);
        this.ButtonCancel.Name = "ButtonCancel";
        this.ButtonCancel.Size = new System.Drawing.Size(108, 34);
        this.ButtonCancel.TabIndex = 3;
        this.ButtonCancel.Text = "Cancel";
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
        this.TextBox.ReadOnly = true;
        this.TextBox.Color_8 = System.Drawing.Color.FromArgb(60, 0, 0, 255);
        this.TextBox.ServiceColors = null;
        this.TextBox.Size = new System.Drawing.Size(795, 386);
        this.TextBox.TabIndex = 4;
        this.TextBox.Int32_13 = 100;
        this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.InfoLabel.Location = new System.Drawing.Point(126, 404);
        this.InfoLabel.Name = "InfoLabel";
        this.InfoLabel.Size = new System.Drawing.Size(453, 34);
        this.InfoLabel.TabIndex = 5;
        this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(819, 450);
        base.Controls.Add(this.InfoLabel);
        base.Controls.Add(this.TextBox);
        base.Controls.Add(this.ButtonCancel);
        base.Controls.Add(this.ButtonOK);
        base.Controls.Add(this.ButtonImport);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(500, 350);
        base.Name = "FormMwpsImporter";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormImportResult";
        ((System.ComponentModel.ISupportInitialize)this.TextBox).EndInit();
        base.ResumeLayout(false);
    }
}
