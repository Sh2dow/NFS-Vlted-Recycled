using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormModScriptResults : Form
{
    private readonly IContainer icontainer_0;

    private DataGridView EntriesGrid;

    private Label label1;

    private DataGridViewTextBoxColumn Script;

    private DataGridViewTextBoxColumn ColumnLineNumber;

    private DataGridViewTextBoxColumn ColumnLine;

    private DataGridViewTextBoxColumn Collection;

    public FormModScriptResults()
    {
        InitializeComponent();
        method_0();
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | ModScript Installer | Errors";
        Text = text;
    }

    private void method_0()
    {
        this.smethod_2();
        EntriesGrid.smethod_4();
    }

    internal void method_1(IList<Class263> ilist_0)
    {
        EntriesGrid.Rows.Clear();
        foreach (Class263 item in ilist_0)
        {
            if (item.Boolean_0)
            {
                DataGridViewRow dataGridViewRow = new();
                dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
                {
                    Value = item.ScriptName
                });
                dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
                {
                    Value = item.LineNumber
                });
                dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
                {
                    Value = item.Line
                });
                string value = item.method_0();
                dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
                {
                    Value = value,
                    ErrorText = item.method_0(GEnum24.const_1)
                });
                EntriesGrid.Rows.Add(dataGridViewRow);
            }
        }
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
        this.EntriesGrid = new System.Windows.Forms.DataGridView();
        this.label1 = new System.Windows.Forms.Label();
        this.Script = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.ColumnLineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.ColumnLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)this.EntriesGrid).BeginInit();
        base.SuspendLayout();
        this.EntriesGrid.AllowUserToAddRows = false;
        this.EntriesGrid.AllowUserToDeleteRows = false;
        this.EntriesGrid.AllowUserToResizeRows = false;
        this.EntriesGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.EntriesGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.EntriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.EntriesGrid.Columns.AddRange(this.Script, this.ColumnLineNumber, this.ColumnLine, this.Collection);
        this.EntriesGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.EntriesGrid.Location = new System.Drawing.Point(12, 39);
        this.EntriesGrid.Name = "EntriesGrid";
        this.EntriesGrid.ReadOnly = true;
        this.EntriesGrid.RowHeadersVisible = false;
        this.EntriesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.EntriesGrid.Size = new System.Drawing.Size(760, 390);
        this.EntriesGrid.TabIndex = 13;
        this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.label1.ForeColor = System.Drawing.Color.Red;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(760, 27);
        this.label1.TabIndex = 14;
        this.label1.Text = "The mod has been installed but the following errors occurred during installation:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        this.Script.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.Script.HeaderText = "Script";
        this.Script.Name = "Script";
        this.Script.ReadOnly = true;
        this.Script.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.Script.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        this.Script.Width = 40;
        this.ColumnLineNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.ColumnLineNumber.HeaderText = "Line";
        this.ColumnLineNumber.Name = "ColumnLineNumber";
        this.ColumnLineNumber.ReadOnly = true;
        this.ColumnLineNumber.Width = 52;
        this.ColumnLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.ColumnLine.HeaderText = "Command";
        this.ColumnLine.Name = "ColumnLine";
        this.ColumnLine.ReadOnly = true;
        this.Collection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.Collection.DataPropertyName = "MessageColumn";
        this.Collection.HeaderText = "Message";
        this.Collection.Name = "Collection";
        this.Collection.ReadOnly = true;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(784, 441);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.EntriesGrid);
        this.MinimumSize = new System.Drawing.Size(500, 350);
        base.Name = "FormModScriptResults";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormModScriptResults";
        ((System.ComponentModel.ISupportInitialize)this.EntriesGrid).EndInit();
        base.ResumeLayout(false);
    }
}
