using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class LogsControl : UserControl
{
    private readonly Class118 class118_0;

    [CompilerGenerated]
    private GEnum1 genum1_0;

    private IContainer icontainer_0;

    private Button ButtonLoadLogs;

    private FastColoredTextBox LogsTextBox;

    private CheckBox SkipCommentsCheckBox;

    private ComboBox LogsList;

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

    public bool Boolean_0
    {
        get
        {
            return SkipCommentsCheckBox.Checked;
        }
        set
        {
            SkipCommentsCheckBox.Checked = value;
        }
    }

    public LogsControl()
    {
        InitializeComponent();
        base.Load += LogsControl_Load;
        class118_0 = new Class118(LogsTextBox);
    }

    private void LogsControl_Load(object sender, EventArgs e)
    {
        LogsTextBox.smethod_20();
        SkipCommentsCheckBox.smethod_6();
        LogsList.smethod_8();
        ButtonLoadLogs.smethod_5();
    }

    private void ButtonLoadLogs_Click(object sender, EventArgs e)
    {
        LogsList.Items.Clear();
        GEnum1 version = Version;
        if (version == GEnum1.const_0 || version == GEnum1.const_9)
        {
            return;
        }
        List<string> list = [.. (from string_0 in Class121.smethod_3(Version)
                             orderby string_0 descending
                             select string_0)];
        foreach (string item in list)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
            LogsList.Items.Add(fileNameWithoutExtension);
        }
        if (list.Any())
        {
            LogsList.SelectedIndex = 0;
        }
    }

    private void SkipCommentsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        LogsList_SelectedIndexChanged(sender, null);
    }

    private void LogsList_SelectedIndexChanged(object sender, EventArgs e)
    {
        LogsTextBox.Text = string.Empty;
        IList<string> list = Class121.smethod_4(LogsList?.SelectedItem?.ToString());
        if (Boolean_0)
        {
            list = [.. list.Where(string_0 => !string_0.StartsWith("#"))];
        }
        LogsTextBox.Text = string.Join(Environment.NewLine, list);
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
        this.ButtonLoadLogs = new System.Windows.Forms.Button();
        this.LogsTextBox = new VaultEditor.FastColoredTextBox();
        this.SkipCommentsCheckBox = new System.Windows.Forms.CheckBox();
        this.LogsList = new System.Windows.Forms.ComboBox();
        ((System.ComponentModel.ISupportInitialize)this.LogsTextBox).BeginInit();
        base.SuspendLayout();
        this.ButtonLoadLogs.Location = new System.Drawing.Point(13, 14);
        this.ButtonLoadLogs.Name = "ButtonLoadLogs";
        this.ButtonLoadLogs.Size = new System.Drawing.Size(75, 23);
        this.ButtonLoadLogs.TabIndex = 16;
        this.ButtonLoadLogs.Text = "Load";
        this.ButtonLoadLogs.UseVisualStyleBackColor = true;
        this.ButtonLoadLogs.Click += new System.EventHandler(ButtonLoadLogs_Click);
        this.LogsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.LogsTextBox.Char_0 = ['(', ')', '{', '}', '[', ']', '"', '"', '\'', '\''];
        this.LogsTextBox.Size_0 = new System.Drawing.Size(27, 14);
        this.LogsTextBox.Brush_0 = null;
        this.LogsTextBox.Int32_1 = 14;
        this.LogsTextBox.CharWidth = 8;
        this.LogsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.LogsTextBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
        this.LogsTextBox.Boolean_6 = false;
        this.LogsTextBox.Location = new System.Drawing.Point(13, 43);
        this.LogsTextBox.Name = "LogsTextBox";
        this.LogsTextBox.Paddings = new System.Windows.Forms.Padding(0);
        this.LogsTextBox.ReadOnly = true;
        this.LogsTextBox.Color_8 = System.Drawing.Color.FromArgb(60, 0, 0, 255);
        this.LogsTextBox.ServiceColors = null;
        this.LogsTextBox.Size = new System.Drawing.Size(703, 467);
        this.LogsTextBox.TabIndex = 15;
        this.LogsTextBox.Int32_13 = 100;
        this.SkipCommentsCheckBox.AutoSize = true;
        this.SkipCommentsCheckBox.Location = new System.Drawing.Point(416, 17);
        this.SkipCommentsCheckBox.Name = "SkipCommentsCheckBox";
        this.SkipCommentsCheckBox.Size = new System.Drawing.Size(98, 17);
        this.SkipCommentsCheckBox.TabIndex = 14;
        this.SkipCommentsCheckBox.Text = "Skip comments";
        this.SkipCommentsCheckBox.UseVisualStyleBackColor = true;
        this.SkipCommentsCheckBox.CheckedChanged += new System.EventHandler(SkipCommentsCheckBox_CheckedChanged);
        this.LogsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.LogsList.FormattingEnabled = true;
        this.LogsList.Location = new System.Drawing.Point(94, 15);
        this.LogsList.Name = "LogsList";
        this.LogsList.Size = new System.Drawing.Size(316, 21);
        this.LogsList.TabIndex = 13;
        this.LogsList.SelectedIndexChanged += new System.EventHandler(LogsList_SelectedIndexChanged);
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.Controls.Add(this.ButtonLoadLogs);
        base.Controls.Add(this.LogsTextBox);
        base.Controls.Add(this.SkipCommentsCheckBox);
        base.Controls.Add(this.LogsList);
        base.Name = "LogsControl";
        base.Size = new System.Drawing.Size(731, 530);
        ((System.ComponentModel.ISupportInitialize)this.LogsTextBox).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
