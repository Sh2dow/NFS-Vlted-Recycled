using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UserSettings;

namespace VaultEditor;

public sealed class FormLogs : GForm0
{
    private readonly Class118 class118_0;

    [CompilerGenerated]
    private Settings settings_0;

    [CompilerGenerated]
    private GEnum1 genum1_0;

    private IContainer icontainer_0;

    private ComboBox LogsList;

    private CheckBox SkipCommentsCheckBox;

    private FastColoredTextBox ScriptTextBox;

    public Settings Settings
    {
        [CompilerGenerated]
        get
        {
            return settings_0;
        }
        [CompilerGenerated]
        set
        {
            settings_0 = value;
        }
    }

    public GEnum1 Version
    {
        [CompilerGenerated]
        get
        {
            return genum1_0;
        }
        [CompilerGenerated]
        set
        {
            genum1_0 = value;
        }
    }

    public FormLogs()
    {
        InitializeComponent();
        class118_0 = new Class118(ScriptTextBox);
        method_0();
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | Logs viewer";
        Text = text;
        base.Load += FormLogs_Load;
        LogsList.SelectedIndexChanged += LogsList_SelectedIndexChanged;
    }

    private void FormLogs_Load(object sender, EventArgs e)
    {
        SkipCommentsCheckBox.Checked = Settings.SkipComments;
        IOrderedEnumerable<string> orderedEnumerable = from string_0 in Class121.smethod_3(Version)
                                                       orderby string_0 descending
                                                       select string_0;
        foreach (string item in orderedEnumerable)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
            LogsList.Items.Add(fileNameWithoutExtension);
        }
        if (orderedEnumerable.Any())
        {
            LogsList.SelectedIndex = 0;
        }
    }

    private void LogsList_SelectedIndexChanged(object sender, EventArgs e)
    {
        ScriptTextBox.Text = string.Empty;
        IList<string> list = Class121.smethod_4(LogsList?.SelectedItem?.ToString());
        if (Settings.SkipComments)
        {
            list = [.. list.Where(string_0 => !string_0.StartsWith("#"))];
        }
        ScriptTextBox.Text = string.Join(Environment.NewLine, list);
    }

    private void method_0()
    {
        this.smethod_2();
        LogsList.smethod_8();
        ScriptTextBox.smethod_20();
        SkipCommentsCheckBox.smethod_6();
    }

    private void SkipCommentsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        Settings.SkipComments = SkipCommentsCheckBox.Checked;
        LogsList_SelectedIndexChanged(sender, null);
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
        this.LogsList = new System.Windows.Forms.ComboBox();
        this.SkipCommentsCheckBox = new System.Windows.Forms.CheckBox();
        this.ScriptTextBox = new VaultEditor.FastColoredTextBox();
        ((System.ComponentModel.ISupportInitialize)this.ScriptTextBox).BeginInit();
        base.SuspendLayout();
        this.LogsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.LogsList.FormattingEnabled = true;
        this.LogsList.Location = new System.Drawing.Point(12, 24);
        this.LogsList.Name = "LogsList";
        this.LogsList.Size = new System.Drawing.Size(316, 21);
        this.LogsList.TabIndex = 5;
        this.SkipCommentsCheckBox.AutoSize = true;
        this.SkipCommentsCheckBox.Location = new System.Drawing.Point(334, 27);
        this.SkipCommentsCheckBox.Name = "SkipCommentsCheckBox";
        this.SkipCommentsCheckBox.Size = new System.Drawing.Size(98, 17);
        this.SkipCommentsCheckBox.TabIndex = 7;
        this.SkipCommentsCheckBox.Text = "Skip comments";
        this.SkipCommentsCheckBox.UseVisualStyleBackColor = true;
        this.SkipCommentsCheckBox.CheckedChanged += new System.EventHandler(SkipCommentsCheckBox_CheckedChanged);
        this.ScriptTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.ScriptTextBox.Char_0 = ['(', ')', '{', '}', '[', ']', '"', '"', '\'', '\''];
        this.ScriptTextBox.Size_0 = new System.Drawing.Size(27, 14);
        this.ScriptTextBox.Brush_0 = null;
        this.ScriptTextBox.Int32_1 = 14;
        this.ScriptTextBox.CharWidth = 8;
        this.ScriptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.ScriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
        this.ScriptTextBox.Boolean_6 = false;
        this.ScriptTextBox.Location = new System.Drawing.Point(12, 51);
        this.ScriptTextBox.Name = "ScriptTextBox";
        this.ScriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
        this.ScriptTextBox.ReadOnly = true;
        this.ScriptTextBox.Color_8 = System.Drawing.Color.FromArgb(60, 0, 0, 255);
        this.ScriptTextBox.ServiceColors = null;
        this.ScriptTextBox.Size = new System.Drawing.Size(795, 387);
        this.ScriptTextBox.TabIndex = 8;
        this.ScriptTextBox.Int32_13 = 100;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(819, 450);
        base.Controls.Add(this.ScriptTextBox);
        base.Controls.Add(this.SkipCommentsCheckBox);
        base.Controls.Add(this.LogsList);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(500, 350);
        base.Name = "FormLogs";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormImportResult";
        ((System.ComponentModel.ISupportInitialize)this.ScriptTextBox).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
