using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormFieldsEditor : Form
{
    [CompilerGenerated]
    private sealed class Class8
    {
        public GClass151 gclass151_0;

        internal bool method_0(GClass154 gclass154_0)
        {
            return gclass154_0.Field.Equals(gclass151_0);
        }
    }

    [CompilerGenerated]
    private VaultDatabase gclass478_0;

    [CompilerGenerated]
    private GClass537 gclass537_0;

    [CompilerGenerated]
    private readonly IList<GClass541> ilist_0;

    private readonly IContainer icontainer_0;

    private Button ButtonApply;

    private DataGridView OptionalFieldsGrid;

    private SplitContainer splitContainer1;

    private DataGridView BaseFieldsGrid;

    private DataGridViewCheckBoxColumn CheckedColumn;

    private DataGridViewTextBoxColumn ColumnName;

    private DataGridViewTextBoxColumn ColumnTableCount;

    private DataGridViewTextBoxColumn BaseColumnName;

    private DataGridViewTextBoxColumn BaseColumnValidCount;

    public VaultDatabase Database
    {
        [CompilerGenerated]
        get
        {
            return gclass478_0;
        }
        [CompilerGenerated]
        set
        {
            gclass478_0 = value;
        }
    }

    public GClass537 Row
    {
        [CompilerGenerated]
        get
        {
            return gclass537_0;
        }
        [CompilerGenerated]
        set
        {
            gclass537_0 = value;
        }
    }

    public IList<GClass541> Results
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
    }

    public FormFieldsEditor()
    {
        ilist_0 = [];
        InitializeComponent();
        method_0();
        base.Load += FormFieldsEditor_Load;
        BaseFieldsGrid.CellEndEdit += BaseFieldsGrid_CellEndEdit;
        OptionalFieldsGrid.CellEndEdit += OptionalFieldsGrid_CellEndEdit;
    }

    private void BaseFieldsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 1)
        {
            DataGridViewRow dataGridViewRow = BaseFieldsGrid.Rows[e.RowIndex];
            GClass151 gclass151_ = dataGridViewRow.Tag as GClass151;
            GClass155 gClass = (GClass155)Row.method_4(gclass151_);
            DataGridViewCell dataGridViewCell = dataGridViewRow.Cells[e.ColumnIndex];
            if (!short.TryParse(dataGridViewCell.Value.ToString(), out var result))
            {
                result = gClass.ValidCount;
            }
            if (result > gClass.MaxCount)
            {
                result = gClass.ValidCount;
            }
            if (result < 0)
            {
                result = 0;
            }
            dataGridViewCell.Value = result;
        }
    }

    private void OptionalFieldsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 2)
        {
            DataGridViewCell dataGridViewCell = OptionalFieldsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (!uint.TryParse(dataGridViewCell.Value.ToString(), out var _))
            {
                dataGridViewCell.Value = 0;
            }
        }
    }

    private void method_0()
    {
        this.smethod_2();
        ButtonApply.smethod_5();
        OptionalFieldsGrid.smethod_4();
    }

    private void FormFieldsEditor_Load(object sender, EventArgs e)
    {
        foreach (GClass151 item in Row.Class.IEnumerable_1)
        {
            if (item.Boolean_1)
            {
                method_2(item);
            }
            else if (item.Boolean_0)
            {
                method_1(item);
            }
        }
        splitContainer1.Panel1Collapsed = BaseFieldsGrid.Rows.Count == 0;
        BaseFieldsGrid.Sort(BaseColumnName, ListSortDirection.Ascending);
        OptionalFieldsGrid.Sort(ColumnName, ListSortDirection.Ascending);
        BaseFieldsGrid.ClearSelection();
        OptionalFieldsGrid.ClearSelection();
    }

    private void method_1(GClass151 gclass151_0)
    {
        DataGridViewRow dataGridViewRow = new()
        {
            Tag = gclass151_0
        };
        string arg = GClass486.smethod_5(gclass151_0.NameHash);
        GClass155 gClass = (GClass155)Row.method_4(gclass151_0);
        dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
        {
            Value = $"{arg} [{gClass.MaxCount}]"
        });
        DataGridViewTextBoxCell dataGridViewCell = new()
        {
            Value = gClass.ValidCount,
            Tag = gClass.ValidCount
        };
        dataGridViewRow.Cells.Add(dataGridViewCell);
        BaseFieldsGrid.Rows.Add(dataGridViewRow);
    }

    private void method_2(GClass151 gclass151_0)
    {
        DataGridViewRow dataGridViewRow = new()
        {
            Tag = gclass151_0
        };
        DataGridViewCheckBoxCell dataGridViewCell = new()
        {
            Value = Row.method_3(gclass151_0)
        };
        dataGridViewRow.Cells.Add(dataGridViewCell);
        dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
        {
            Value = GClass486.smethod_5(gclass151_0.NameHash)
        });
        if (gclass151_0.Boolean_0)
        {
            GClass154 gClass = Row.method_4(gclass151_0);
            int num = ((gClass == null) ? gclass151_0.Count : ((GClass155)gClass).Int32_0);
            if (num <= 0)
            {
                List<GClass155> source = [.. (from gclass154_0 in Row.Class.IEnumerable_0.SelectMany(gclass537_0 => gclass537_0)
                                          where gclass154_0.Field.Equals(gclass151_0)
                                          select gclass154_0).OfType<GClass155>()];
                if (source.Any())
                {
                    num = source.Max(gclass155_0 => gclass155_0.Int32_0);
                }
            }
            DataGridViewTextBoxCell dataGridViewCell2 = new()
            {
                Value = num
            };
            dataGridViewRow.Cells.Add(dataGridViewCell2);
        }
        else
        {
            DataGridViewTextBoxCell dataGridViewTextBoxCell = new();
            dataGridViewRow.Cells.Add(dataGridViewTextBoxCell);
            dataGridViewTextBoxCell.ReadOnly = true;
        }
        OptionalFieldsGrid.Rows.Add(dataGridViewRow);
    }

    private void ButtonApply_Click(object sender, EventArgs e)
    {
        method_4();
        method_3();
        Close();
    }

    private void method_3()
    {
        foreach (DataGridViewRow item in BaseFieldsGrid.Rows.OfType<DataGridViewRow>().ToList())
        {
            GClass151 gClass = (GClass151)item.Tag;
            short num = Convert.ToInt16(item.Cells[1].Value);
            short num2 = Convert.ToInt16(item.Cells[1].Tag);
            if (num != num2)
            {
                uint nameHash = gClass.NameHash;
                uint classNameHash = Row.ClassNameHash;
                uint uInt32_ = Row.UInt32_0;
                Class255 gclass541_ = new(classNameHash, uInt32_, nameHash, num);
                method_5(gclass541_);
            }
        }
    }

    private void method_4()
    {
        foreach (DataGridViewRow item in OptionalFieldsGrid.Rows.OfType<DataGridViewRow>().ToList())
        {
            bool num = item.Cells[0].Value != null && (bool)item.Cells[0].Value;
            GClass151 gClass = (GClass151)item.Tag;
            short num2 = Convert.ToInt16(item.Cells[2].Value);
            uint nameHash = gClass.NameHash;
            uint classNameHash = Row.ClassNameHash;
            uint uInt32_ = Row.UInt32_0;
            bool flag = Row.method_3(gClass);
            if (num)
            {
                if (flag)
                {
                    if (gClass.Boolean_0)
                    {
                        GClass155 gClass2 = (GClass155)Row.method_4(gClass);
                        if ((gClass.Boolean_1 && gClass2.Int32_0 != num2) || (!gClass.Boolean_1 && gClass2.ValidCount != num2))
                        {
                            Class255 gclass541_ = new(classNameHash, uInt32_, nameHash, num2);
                            method_5(gclass541_);
                        }
                    }
                }
                else
                {
                    Class254 gclass541_2 = new(classNameHash, uInt32_, nameHash, num2);
                    method_5(gclass541_2);
                }
            }
            else if (flag)
            {
                Class253 gclass541_3 = new(classNameHash, uInt32_, nameHash);
                method_5(gclass541_3);
            }
        }
    }

    private void method_5(GClass541 gclass541_0)
    {
        GClass542 gClass = gclass541_0.vmethod_2(Database);
        if (gClass.Boolean_0)
        {
            GClass109.smethod_1(this, gClass.method_0());
        }
        else
        {
            Results.Add(gclass541_0);
        }
    }

    private void BaseFieldsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new();
        this.ButtonApply = new System.Windows.Forms.Button();
        this.OptionalFieldsGrid = new System.Windows.Forms.DataGridView();
        this.CheckedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.ColumnTableCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.BaseFieldsGrid = new System.Windows.Forms.DataGridView();
        this.BaseColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.BaseColumnValidCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)this.OptionalFieldsGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.BaseFieldsGrid).BeginInit();
        base.SuspendLayout();
        this.ButtonApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.ButtonApply.Location = new System.Drawing.Point(313, 436);
        this.ButtonApply.Name = "ButtonApply";
        this.ButtonApply.Size = new System.Drawing.Size(75, 23);
        this.ButtonApply.TabIndex = 2;
        this.ButtonApply.Text = "Apply";
        this.ButtonApply.UseVisualStyleBackColor = true;
        this.ButtonApply.Click += new System.EventHandler(ButtonApply_Click);
        this.OptionalFieldsGrid.AllowUserToAddRows = false;
        this.OptionalFieldsGrid.AllowUserToDeleteRows = false;
        this.OptionalFieldsGrid.AllowUserToResizeRows = false;
        dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
        dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.OptionalFieldsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
        this.OptionalFieldsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        this.OptionalFieldsGrid.Columns.AddRange(this.CheckedColumn, this.ColumnName, this.ColumnTableCount);
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.OptionalFieldsGrid.DefaultCellStyle = dataGridViewCellStyle2;
        this.OptionalFieldsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.OptionalFieldsGrid.Location = new System.Drawing.Point(0, 0);
        this.OptionalFieldsGrid.MultiSelect = false;
        this.OptionalFieldsGrid.Name = "OptionalFieldsGrid";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.OptionalFieldsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        this.OptionalFieldsGrid.RowHeadersVisible = false;
        this.OptionalFieldsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        this.OptionalFieldsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.OptionalFieldsGrid.Size = new System.Drawing.Size(376, 205);
        this.OptionalFieldsGrid.TabIndex = 3;
        this.CheckedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.CheckedColumn.HeaderText = "";
        this.CheckedColumn.Name = "CheckedColumn";
        this.CheckedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        this.CheckedColumn.Width = 5;
        this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.ColumnName.HeaderText = "Optional field";
        this.ColumnName.Name = "ColumnName";
        this.ColumnName.ReadOnly = true;
        this.ColumnTableCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.ColumnTableCount.HeaderText = "Array size";
        this.ColumnTableCount.Name = "ColumnTableCount";
        this.ColumnTableCount.Width = 77;
        this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.splitContainer1.Location = new System.Drawing.Point(12, 12);
        this.splitContainer1.Name = "splitContainer1";
        this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        this.splitContainer1.Panel1.Controls.Add(this.BaseFieldsGrid);
        this.splitContainer1.Panel2.Controls.Add(this.OptionalFieldsGrid);
        this.splitContainer1.Size = new System.Drawing.Size(376, 418);
        this.splitContainer1.SplitterDistance = 209;
        this.splitContainer1.TabIndex = 4;
        this.BaseFieldsGrid.AllowUserToAddRows = false;
        this.BaseFieldsGrid.AllowUserToDeleteRows = false;
        this.BaseFieldsGrid.AllowUserToResizeRows = false;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.BaseFieldsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
        this.BaseFieldsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        this.BaseFieldsGrid.Columns.AddRange(this.BaseColumnName, this.BaseColumnValidCount);
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
        dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.BaseFieldsGrid.DefaultCellStyle = dataGridViewCellStyle5;
        this.BaseFieldsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.BaseFieldsGrid.Location = new System.Drawing.Point(0, 0);
        this.BaseFieldsGrid.MultiSelect = false;
        this.BaseFieldsGrid.Name = "BaseFieldsGrid";
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
        dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.BaseFieldsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
        this.BaseFieldsGrid.RowHeadersVisible = false;
        this.BaseFieldsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        this.BaseFieldsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.BaseFieldsGrid.Size = new System.Drawing.Size(376, 209);
        this.BaseFieldsGrid.TabIndex = 4;
        this.BaseFieldsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(BaseFieldsGrid_CellContentClick);
        this.BaseColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.BaseColumnName.HeaderText = "Base field";
        this.BaseColumnName.Name = "BaseColumnName";
        this.BaseColumnName.ReadOnly = true;
        this.BaseColumnValidCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.BaseColumnValidCount.HeaderText = "Enabled count";
        this.BaseColumnValidCount.Name = "BaseColumnValidCount";
        this.BaseColumnValidCount.Width = 101;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(400, 461);
        base.Controls.Add(this.splitContainer1);
        base.Controls.Add(this.ButtonApply);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(300, 500);
        base.Name = "FormFieldsEditor";
        base.ShowInTaskbar = false;
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Fields Editor";
        ((System.ComponentModel.ISupportInitialize)this.OptionalFieldsGrid).EndInit();
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
        this.splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.BaseFieldsGrid).EndInit();
        base.ResumeLayout(false);
    }
}
