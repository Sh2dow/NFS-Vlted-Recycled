using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormModScriptImporter : GForm0
{
    [CompilerGenerated]
    private sealed class Class1
    {
        public Class260 class260_0;
    }

    [CompilerGenerated]
    private sealed class Class2
    {
        public CheckBox checkBox_0;

        public Class1 class1_0;

        internal void method_0(object sender, EventArgs e)
        {
            class1_0.class260_0.Checked = checkBox_0.Checked;
        }
    }

    [CompilerGenerated]
    private sealed class Class3
    {
        public RadioButton radioButton_0;

        public Class1 class1_0;

        internal void method_0(object sender, EventArgs e)
        {
            class1_0.class260_0.Checked = radioButton_0.Checked;
        }
    }

    [CompilerGenerated]
    private sealed class Class4
    {
        public Form form_0;

        public PictureBox pictureBox_0;

        public EventHandler eventHandler_0;

        internal void method_0(object sender, EventArgs e)
        {
            form_0.smethod_2();
            PictureBox pictureBox = new()
            {
                Dock = DockStyle.Fill,
                Image = pictureBox_0.Image,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            form_0.Controls.Add(pictureBox);
            pictureBox.Click += delegate
            {
                form_0.Close();
            };
        }

        internal void method_1(object sender, EventArgs e)
        {
            form_0.Close();
        }

        internal void method_2(object sender, EventArgs e)
        {
            form_0.Close();
        }
    }

    private Class261 class261_0;

    private bool bool_0;

    private string string_0;

    private readonly IContainer icontainer_0;

    private Button ButtonInstall;

    private TableLayoutPanel LayoutPanel;

    private FlowLayoutPanel ControlsPanel;

    private FlowLayoutPanel ImagesPanel;

    public FormModScriptImporter()
    {
        InitializeComponent();
        base.Commands = [];
        class261_0 = new Class261();
        method_2();
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | ModScript Installer";
        Text = text;
        base.Load += FormModScriptImporter_Load;
    }

    private void FormModScriptImporter_Load(object sender, EventArgs e)
    {
        string_0 = string.Empty;
        OpenFileDialog openFileDialog = new()
        {
            AddExtension = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DefaultExt = "nfsms",
            ShowReadOnly = true,
            Title = "Import ModScript file",
            Filter = "*.nfsms|*.nfsms",
            Multiselect = false
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            method_0(string_0 = openFileDialog.FileName);
        }
        else
        {
            Close();
        }
    }

    private void method_0(string string_1)
    {
        try
        {
            class261_0 = new Class261();
            ImagesPanel.Controls.Clear();
            ControlsPanel.Controls.Clear();
            List<Class263> list = [.. new Class234().method_0(string_1)];
            foreach (Class263 item in list.Where(class263_0 => class263_0.Value is Class247 || class263_0.Value is Class244))
            {
                GClass542 gClass = item.Value.vmethod_2(base.Database);
                if (gClass.Boolean_0)
                {
                    GClass109.smethod_1(this, gClass.method_0());
                    Close();
                    return;
                }
            }
            class261_0 = Class261.smethod_0(list);
            method_1();
        }
        catch (Exception ex)
        {
            GClass109.smethod_1(this, "The ModScript file is either corrupted or not a supported format" + Environment.NewLine + ex.Message);
            Close();
        }
    }

    private void method_1()
    {
        bool flag = false;
        ControlsPanel.SuspendLayout();
        FlowLayoutPanel flowLayoutPanel = null;
        string text = string.Empty;
        foreach (Class260 class260_0 in class261_0.Controls)
        {
            switch (class260_0.Type)
            {
                case Enum8.const_0:
                    {
                        Label label = new();
                        label.smethod_14();
                        label.Text = class260_0.Text;
                        if (!string.IsNullOrWhiteSpace(class260_0.Text))
                        {
                            flag = true;
                        }
                        label.AutoSize = true;
                        ControlsPanel.Controls.Add(label);
                        break;
                    }
                case Enum8.const_1:
                    {
                        CheckBox checkBox_0 = new();
                        checkBox_0.smethod_6();
                        checkBox_0.Text = class260_0.Text;
                        checkBox_0.AutoSize = true;
                        checkBox_0.Checked = class260_0.Checked;
                        checkBox_0.CheckedChanged += delegate
                        {
                            class260_0.Checked = checkBox_0.Checked;
                        };
                        ControlsPanel.Controls.Add(checkBox_0);
                        break;
                    }
                case Enum8.const_2:
                    {
                        if (text != class260_0.Name)
                        {
                            flowLayoutPanel = new FlowLayoutPanel
                            {
                                FlowDirection = FlowDirection.TopDown,
                                AutoSize = true
                            };
                            ControlsPanel.Controls.Add(flowLayoutPanel);
                            text = class260_0.Name;
                        }
                        RadioButton radioButton_0 = new();
                        radioButton_0.smethod_7();
                        radioButton_0.Text = class260_0.Text;
                        radioButton_0.AutoSize = true;
                        radioButton_0.Checked = class260_0.Checked;
                        radioButton_0.CheckedChanged += delegate
                        {
                            class260_0.Checked = radioButton_0.Checked;
                        };
                        flowLayoutPanel.Controls.Add(radioButton_0);
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        foreach (Image image in class261_0.Images)
        {
            PictureBox pictureBox = new()
            {
                Width = 200,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = image
            };
            pictureBox.Click += method_3;
            ImagesPanel.Controls.Add(pictureBox);
        }
        if (!flag)
        {
            Label label2 = new();
            label2.smethod_14();
            label2.Text = "The mod does not have a description." + Environment.NewLine + string_0;
            label2.AutoSize = true;
            ControlsPanel.Controls.Add(label2);
        }
        ControlsPanel.ResumeLayout();
        ControlsPanel.Width -= 20;
        ControlsPanel.PerformLayout();
        ControlsPanel.Width += 20;
    }

    private void ButtonInstall_Click(object sender, EventArgs e)
    {
        if (bool_0)
        {
            Close();
            return;
        }
        bool_0 = true;
        ButtonInstall.Text = "Close";
        base.ClassesTree.BeginUpdate();
        Class234.smethod_0(class261_0, base.Database);
        base.ClassesTree.EndUpdate();
        base.Commands.Clear();
        foreach (Class263 item in class261_0.Executed.Where(class263_0 => !class263_0.Boolean_0 && class263_0.method_5()))
        {
            base.Commands.Add(item.Value);
        }
        if (class261_0.Commands.Any(class263_0 => class263_0.Boolean_0))
        {
            FormModScriptResults formModScriptResults = new();
            formModScriptResults.method_1(class261_0.Commands);
            formModScriptResults.ShowDialog();
        }
        else
        {
            Close();
        }
    }

    private void method_2()
    {
        this.smethod_2();
        ControlsPanel.smethod_0();
        ButtonInstall.smethod_5();
    }

    private void method_3(object sender, EventArgs e)
    {
        Rectangle bounds = Screen.FromControl(this).Bounds;
        PictureBox pictureBox_0 = sender as PictureBox;
        Form form_0 = new()
        {
            ShowInTaskbar = false,
            ShowIcon = false,
            FormBorderStyle = FormBorderStyle.SizableToolWindow,
            Size = new Size(bounds.Width / 2, bounds.Height / 2),
            MinimumSize = new Size(640, 480),
            StartPosition = FormStartPosition.CenterParent
        };
        form_0.Load += delegate
        {
            form_0.smethod_2();
            PictureBox pictureBox = new()
            {
                Dock = DockStyle.Fill,
                Image = pictureBox_0.Image,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            form_0.Controls.Add(pictureBox);
            pictureBox.Click += delegate
            {
                form_0.Close();
            };
        };
        form_0.Click += delegate
        {
            form_0.Close();
        };
        form_0.ShowDialog();
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
        this.ButtonInstall = new System.Windows.Forms.Button();
        this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        this.ImagesPanel = new System.Windows.Forms.FlowLayoutPanel();
        this.ControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
        this.LayoutPanel.SuspendLayout();
        base.SuspendLayout();
        this.ButtonInstall.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.ButtonInstall.Location = new System.Drawing.Point(649, 388);
        this.ButtonInstall.Name = "ButtonInstall";
        this.ButtonInstall.Size = new System.Drawing.Size(108, 34);
        this.ButtonInstall.TabIndex = 2;
        this.ButtonInstall.Text = "Install";
        this.ButtonInstall.UseVisualStyleBackColor = true;
        this.ButtonInstall.Click += new System.EventHandler(ButtonInstall_Click);
        this.LayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.LayoutPanel.ColumnCount = 2;
        this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
        this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.LayoutPanel.Controls.Add(this.ImagesPanel, 0, 0);
        this.LayoutPanel.Controls.Add(this.ControlsPanel, 0, 0);
        this.LayoutPanel.Location = new System.Drawing.Point(12, 12);
        this.LayoutPanel.Name = "LayoutPanel";
        this.LayoutPanel.RowCount = 1;
        this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
        this.LayoutPanel.Size = new System.Drawing.Size(760, 417);
        this.LayoutPanel.TabIndex = 15;
        this.ImagesPanel.AutoSize = true;
        this.ImagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ImagesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        this.ImagesPanel.Location = new System.Drawing.Point(757, 3);
        this.ImagesPanel.Name = "ImagesPanel";
        this.ImagesPanel.Size = new System.Drawing.Size(1, 411);
        this.ImagesPanel.TabIndex = 15;
        this.ImagesPanel.WrapContents = false;
        this.ControlsPanel.AutoScroll = true;
        this.ControlsPanel.AutoSize = true;
        this.ControlsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ControlsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        this.ControlsPanel.Location = new System.Drawing.Point(3, 3);
        this.ControlsPanel.Name = "ControlsPanel";
        this.ControlsPanel.Size = new System.Drawing.Size(748, 411);
        this.ControlsPanel.TabIndex = 14;
        this.ControlsPanel.WrapContents = false;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(784, 441);
        base.Controls.Add(this.ButtonInstall);
        base.Controls.Add(this.LayoutPanel);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(500, 350);
        base.Name = "FormModScriptImporter";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormImportResult";
        this.LayoutPanel.ResumeLayout(false);
        this.LayoutPanel.PerformLayout();
        base.ResumeLayout(false);
    }
}
