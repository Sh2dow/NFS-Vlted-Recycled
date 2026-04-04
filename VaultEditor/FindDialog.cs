using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormFind : Form
{
    [CompilerGenerated]
    private TreeView treeView_0;

    [CompilerGenerated]
    private PropertyGrid propertyGrid_0;

    private readonly IContainer icontainer_0;

    private Button ButtonSearch;

    private Button btFindNext;

    private CheckBox IncludeFieldsControl;

    public TextBox FieldTextBox;

    private Button ButtonFindType;

    private CheckBox IncludeValuesControl;

    public TextBox ValueTextBox;

    private CheckBox IncludeNodesControl;

    public TextBox NodeTextBox;

    public TreeView ClassesTree
    {
        [CompilerGenerated]
        get
        {
            return treeView_0;
        }
        [CompilerGenerated]
        set
        {
            treeView_0 = value;
        }
    }

    public PropertyGrid PropertyGrid
    {
        [CompilerGenerated]
        get
        {
            return propertyGrid_0;
        }
        [CompilerGenerated]
        set
        {
            propertyGrid_0 = value;
        }
    }

    public string String_0
    {
        get
        {
            return FieldTextBox.Text;
        }
        set
        {
            FieldTextBox.Text = value;
        }
    }

    public string String_1
    {
        get
        {
            return ValueTextBox.Text;
        }
        set
        {
            ValueTextBox.Text = value;
        }
    }

    public string String_2
    {
        get
        {
            return NodeTextBox.Text;
        }
        set
        {
            NodeTextBox.Text = value;
        }
    }

    public bool Boolean_0
    {
        get
        {
            return IncludeFieldsControl.Checked;
        }
        set
        {
            IncludeFieldsControl.Checked = value;
            IncludeNodesControl_CheckedChanged(null, null);
        }
    }

    public bool Boolean_1
    {
        get
        {
            return IncludeNodesControl.Checked;
        }
        set
        {
            IncludeNodesControl.Checked = value;
            IncludeNodesControl_CheckedChanged(null, null);
        }
    }

    public bool Boolean_2
    {
        get
        {
            return IncludeValuesControl.Checked;
        }
        set
        {
            IncludeValuesControl.Checked = value;
            IncludeNodesControl_CheckedChanged(null, null);
        }
    }

    public FormFind()
    {
        InitializeComponent();
        ButtonFindType.Visible = false;
        this.smethod_1();
        NodeTextBox.smethod_18();
        FieldTextBox.smethod_18();
        ValueTextBox.smethod_18();
        btFindNext.smethod_5();
        ButtonSearch.smethod_5();
        ButtonFindType.smethod_5();
        IncludeFieldsControl.smethod_6();
        btFindNext.Enabled = false;
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
        method_0();
    }

    private void btFindNext_Click(object sender, EventArgs e)
    {
        method_1();
    }

    private void FormFind_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
        }
    }

    protected override void OnActivated(EventArgs e)
    {
        FieldTextBox.Focus();
    }

    public void method_0()
    {
        string string_ = (Boolean_1 ? String_2 : string.Empty);
        string string_2 = (Boolean_0 ? String_0 : string.Empty);
        string string_3 = (Boolean_2 ? String_1 : string.Empty);
        int num = ClassesTree.smethod_4(string_, string_2, string_3);
        PropertyGrid.Refresh();
        Text = $"Find | {num}";
        btFindNext.Enabled = num > 0;
    }

    public void method_1()
    {
        ClassesTree.smethod_2();
    }

    private void IncludeNodesControl_CheckedChanged(object sender, EventArgs e)
    {
        NodeTextBox.Enabled = IncludeNodesControl.Checked;
        FieldTextBox.Enabled = IncludeFieldsControl.Checked;
        ValueTextBox.Enabled = IncludeValuesControl.Checked;
    }

    private void ButtonFindType_Click(object sender, EventArgs e)
    {
        int num = ClassesTree.smethod_3(String_1);
        PropertyGrid.Refresh();
        Text = $"Find | {num}";
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
        this.ButtonSearch = new System.Windows.Forms.Button();
        this.btFindNext = new System.Windows.Forms.Button();
        this.FieldTextBox = new System.Windows.Forms.TextBox();
        this.IncludeFieldsControl = new System.Windows.Forms.CheckBox();
        this.ButtonFindType = new System.Windows.Forms.Button();
        this.IncludeValuesControl = new System.Windows.Forms.CheckBox();
        this.ValueTextBox = new System.Windows.Forms.TextBox();
        this.IncludeNodesControl = new System.Windows.Forms.CheckBox();
        this.NodeTextBox = new System.Windows.Forms.TextBox();
        base.SuspendLayout();
        this.ButtonSearch.Location = new System.Drawing.Point(147, 162);
        this.ButtonSearch.Name = "ButtonSearch";
        this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
        this.ButtonSearch.TabIndex = 5;
        this.ButtonSearch.Text = "Search";
        this.ButtonSearch.UseVisualStyleBackColor = true;
        this.ButtonSearch.Click += new System.EventHandler(ButtonSearch_Click);
        this.btFindNext.Location = new System.Drawing.Point(228, 162);
        this.btFindNext.Name = "btFindNext";
        this.btFindNext.Size = new System.Drawing.Size(75, 23);
        this.btFindNext.TabIndex = 4;
        this.btFindNext.Text = "Find next";
        this.btFindNext.UseVisualStyleBackColor = true;
        this.btFindNext.Click += new System.EventHandler(btFindNext_Click);
        this.FieldTextBox.Location = new System.Drawing.Point(106, 71);
        this.FieldTextBox.Name = "FieldTextBox";
        this.FieldTextBox.Size = new System.Drawing.Size(197, 20);
        this.FieldTextBox.TabIndex = 0;
        this.IncludeFieldsControl.Location = new System.Drawing.Point(14, 71);
        this.IncludeFieldsControl.Name = "IncludeFieldsControl";
        this.IncludeFieldsControl.Size = new System.Drawing.Size(86, 20);
        this.IncludeFieldsControl.TabIndex = 1;
        this.IncludeFieldsControl.Text = "Fields";
        this.IncludeFieldsControl.UseVisualStyleBackColor = true;
        this.IncludeFieldsControl.CheckedChanged += new System.EventHandler(IncludeNodesControl_CheckedChanged);
        this.ButtonFindType.Location = new System.Drawing.Point(12, 162);
        this.ButtonFindType.Name = "ButtonFindType";
        this.ButtonFindType.Size = new System.Drawing.Size(75, 23);
        this.ButtonFindType.TabIndex = 6;
        this.ButtonFindType.Text = "Find Type";
        this.ButtonFindType.UseVisualStyleBackColor = true;
        this.ButtonFindType.Click += new System.EventHandler(ButtonFindType_Click);
        this.IncludeValuesControl.Location = new System.Drawing.Point(14, 119);
        this.IncludeValuesControl.Name = "IncludeValuesControl";
        this.IncludeValuesControl.Size = new System.Drawing.Size(86, 20);
        this.IncludeValuesControl.TabIndex = 7;
        this.IncludeValuesControl.Text = "Values";
        this.IncludeValuesControl.UseVisualStyleBackColor = true;
        this.IncludeValuesControl.CheckedChanged += new System.EventHandler(IncludeNodesControl_CheckedChanged);
        this.ValueTextBox.Location = new System.Drawing.Point(106, 119);
        this.ValueTextBox.Name = "ValueTextBox";
        this.ValueTextBox.Size = new System.Drawing.Size(197, 20);
        this.ValueTextBox.TabIndex = 8;
        this.IncludeNodesControl.Location = new System.Drawing.Point(14, 22);
        this.IncludeNodesControl.Name = "IncludeNodesControl";
        this.IncludeNodesControl.Size = new System.Drawing.Size(84, 20);
        this.IncludeNodesControl.TabIndex = 9;
        this.IncludeNodesControl.Text = "Nodes";
        this.IncludeNodesControl.UseVisualStyleBackColor = true;
        this.IncludeNodesControl.CheckedChanged += new System.EventHandler(IncludeNodesControl_CheckedChanged);
        this.NodeTextBox.Location = new System.Drawing.Point(106, 22);
        this.NodeTextBox.Name = "NodeTextBox";
        this.NodeTextBox.Size = new System.Drawing.Size(197, 20);
        this.NodeTextBox.TabIndex = 10;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(317, 202);
        base.Controls.Add(this.NodeTextBox);
        base.Controls.Add(this.IncludeNodesControl);
        base.Controls.Add(this.ValueTextBox);
        base.Controls.Add(this.IncludeValuesControl);
        base.Controls.Add(this.ButtonFindType);
        base.Controls.Add(this.IncludeFieldsControl);
        base.Controls.Add(this.FieldTextBox);
        base.Controls.Add(this.btFindNext);
        base.Controls.Add(this.ButtonSearch);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        base.Name = "FormFind";
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Find";
        base.TopMost = true;
        base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormFind_FormClosing);
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
