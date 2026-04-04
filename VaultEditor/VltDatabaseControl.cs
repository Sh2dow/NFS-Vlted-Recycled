using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class VltDatabaseControl : UserControl
{
    private IContainer icontainer_0;

    private SplitContainer splitContainer1;

    private TreeView ClassesTree;

    private SplitContainer splitContainer3;

    private PropertyGrid PropertyGrid;

    private FastColoredTextBox ScriptTextBox;

    public VltDatabaseControl()
    {
        InitializeComponent();
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
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.ClassesTree = new System.Windows.Forms.TreeView();
        this.splitContainer3 = new System.Windows.Forms.SplitContainer();
        this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
        this.ScriptTextBox = new VaultEditor.FastColoredTextBox();
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.splitContainer3).BeginInit();
        this.splitContainer3.Panel1.SuspendLayout();
        this.splitContainer3.Panel2.SuspendLayout();
        this.splitContainer3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.ScriptTextBox).BeginInit();
        base.SuspendLayout();
        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        this.splitContainer1.Name = "splitContainer1";
        this.splitContainer1.Panel1.Controls.Add(this.ClassesTree);
        this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
        this.splitContainer1.Size = new System.Drawing.Size(1190, 799);
        this.splitContainer1.SplitterDistance = 352;
        this.splitContainer1.TabIndex = 13;
        this.ClassesTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.ClassesTree.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ClassesTree.Location = new System.Drawing.Point(0, 0);
        this.ClassesTree.Name = "ClassesTree";
        this.ClassesTree.Size = new System.Drawing.Size(352, 799);
        this.ClassesTree.TabIndex = 2;
        this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer3.Location = new System.Drawing.Point(0, 0);
        this.splitContainer3.Name = "splitContainer3";
        this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
        this.splitContainer3.Panel1.Controls.Add(this.PropertyGrid);
        this.splitContainer3.Panel2.Controls.Add(this.ScriptTextBox);
        this.splitContainer3.Size = new System.Drawing.Size(834, 799);
        this.splitContainer3.SplitterDistance = 424;
        this.splitContainer3.TabIndex = 3;
        this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.PropertyGrid.HelpVisible = false;
        this.PropertyGrid.LineColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
        this.PropertyGrid.Margin = new System.Windows.Forms.Padding(0);
        this.PropertyGrid.Name = "PropertyGrid";
        this.PropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
        this.PropertyGrid.Size = new System.Drawing.Size(834, 424);
        this.PropertyGrid.TabIndex = 0;
        this.PropertyGrid.ToolbarVisible = false;
        this.ScriptTextBox.Char_0 = ['(', ')', '{', '}', '[', ']', '"', '"', '\'', '\''];
        this.ScriptTextBox.Size_0 = new System.Drawing.Size(27, 14);
        this.ScriptTextBox.Brush_0 = null;
        this.ScriptTextBox.Int32_1 = 14;
        this.ScriptTextBox.CharWidth = 8;
        this.ScriptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.ScriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
        this.ScriptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ScriptTextBox.Boolean_6 = false;
        this.ScriptTextBox.Location = new System.Drawing.Point(0, 0);
        this.ScriptTextBox.Name = "ScriptTextBox";
        this.ScriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
        this.ScriptTextBox.Color_8 = System.Drawing.Color.FromArgb(60, 0, 0, 255);
        this.ScriptTextBox.ServiceColors = null;
        this.ScriptTextBox.Size = new System.Drawing.Size(834, 371);
        this.ScriptTextBox.TabIndex = 1;
        this.ScriptTextBox.Int32_13 = 100;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.Controls.Add(this.splitContainer1);
        base.Name = "VltDatabaseControl";
        base.Size = new System.Drawing.Size(1190, 799);
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
        this.splitContainer1.ResumeLayout(false);
        this.splitContainer3.Panel1.ResumeLayout(false);
        this.splitContainer3.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.splitContainer3).EndInit();
        this.splitContainer3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.ScriptTextBox).EndInit();
        base.ResumeLayout(false);
    }
}
