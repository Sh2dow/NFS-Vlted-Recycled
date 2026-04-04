using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormCollectionsEditor : Form
{
    public delegate void GDelegate2(int size);

    public delegate void GDelegate3(int index, string propertyName, object value);

    private sealed class Class5
    {
        [CompilerGenerated]
        private object object_0;

        public object Label
        {
            [CompilerGenerated]
            get
            {
                return object_0;
            }
            [CompilerGenerated]
            set
            {
                object_0 = value;
            }
        }
    }

    [CompilerGenerated]
    private IList ilist_0;

    [CompilerGenerated]
    private static GDelegate3 gdelegate3_0;

    [CompilerGenerated]
    private static GDelegate2 gdelegate2_0;

    private readonly IContainer icontainer_0;

    private SplitContainer splitContainer1;

    private PropertyGrid PropertyGrid;

    private Button ButtonResize;

    private DataGridView Grid;

    private Label StatusLabel;

    private DataGridViewTextBoxColumn Label;

    public IList SelectedObject
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
        [CompilerGenerated]
        set
        {
            ilist_0 = value;
        }
    }

    public static event GDelegate3 Event_0
    {
        [CompilerGenerated]
        add
        {
            GDelegate3 gDelegate = gdelegate3_0;
            GDelegate3 gDelegate2;
            do
            {
                gDelegate2 = gDelegate;
                GDelegate3 value2 = (GDelegate3)Delegate.Combine(gDelegate2, value);
                gDelegate = Interlocked.CompareExchange(ref gdelegate3_0, value2, gDelegate2);
            }
            while ((object)gDelegate != gDelegate2);
        }
        [CompilerGenerated]
        remove
        {
            GDelegate3 gDelegate = gdelegate3_0;
            GDelegate3 gDelegate2;
            do
            {
                gDelegate2 = gDelegate;
                GDelegate3 value2 = (GDelegate3)Delegate.Remove(gDelegate2, value);
                gDelegate = Interlocked.CompareExchange(ref gdelegate3_0, value2, gDelegate2);
            }
            while ((object)gDelegate != gDelegate2);
        }
    }

    public static event GDelegate2 Event_1
    {
        [CompilerGenerated]
        add
        {
            GDelegate2 gDelegate = gdelegate2_0;
            GDelegate2 gDelegate2;
            do
            {
                gDelegate2 = gDelegate;
                GDelegate2 value2 = (GDelegate2)Delegate.Combine(gDelegate2, value);
                gDelegate = Interlocked.CompareExchange(ref gdelegate2_0, value2, gDelegate2);
            }
            while ((object)gDelegate != gDelegate2);
        }
        [CompilerGenerated]
        remove
        {
            GDelegate2 gDelegate = gdelegate2_0;
            GDelegate2 gDelegate2;
            do
            {
                gDelegate2 = gDelegate;
                GDelegate2 value2 = (GDelegate2)Delegate.Remove(gDelegate2, value);
                gDelegate = Interlocked.CompareExchange(ref gdelegate2_0, value2, gDelegate2);
            }
            while ((object)gDelegate != gDelegate2);
        }
    }

    public FormCollectionsEditor()
    {
        InitializeComponent();
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | Collection Editor";
        Text = text;
        method_0();
        Grid.AutoGenerateColumns = false;
        base.Load += FormCollectionsEditor_Load;
        Grid.CurrentCellChanged += Grid_CurrentCellChanged;
        PropertyGrid.PropertyValueChanged += PropertyGrid_PropertyValueChanged;
    }

    private void method_0()
    {
        this.smethod_1();
        PropertyGrid.smethod_16();
        StatusLabel.smethod_14();
        ButtonResize.smethod_5();
        Grid.smethod_4();
    }

    private void Grid_CurrentCellChanged(object sender, EventArgs e)
    {
        PropertyGrid.SelectedObject = Grid.CurrentCell?.Value;
    }

    private void FormCollectionsEditor_Load(object sender, EventArgs e)
    {
        method_1();
    }

    private void method_1()
    {
        List<Class5> list = [];
        foreach (object item in SelectedObject)
        {
            list.Add(new Class5
            {
                Label = item
            });
        }
        Grid.DataSource = list;
        StatusLabel.Text = $"Total: {Grid.Rows.Count}";
    }

    private void PropertyGrid_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
    {
        object value = Grid.CurrentCell.Value;
        int index = SelectedObject.IndexOf(value);
        if (PropertyGrid.SelectedGridItem.PropertyDescriptor is GClass498 { DisplayName: var displayName } gClass)
        {
            object value2 = gClass.GetValue(value);
            gdelegate3_0(index, displayName, value2);
            PropertyGrid.Refresh();
        }
    }

    private void ButtonResize_Click(object sender, EventArgs e)
    {
        string text = GClass109.smethod_4(this, $"Enter a new size (0 - {65536})", string.Empty);
        if (text != null)
        {
            if (int.TryParse(text, out var result))
            {
                gdelegate2_0(result);
                Grid.DataSource = null;
                method_1();
            }
            else
            {
                ButtonResize_Click(sender, e);
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
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.Grid = new System.Windows.Forms.DataGridView();
        this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
        this.ButtonResize = new System.Windows.Forms.Button();
        this.StatusLabel = new System.Windows.Forms.Label();
        this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.Grid).BeginInit();
        base.SuspendLayout();
        this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.splitContainer1.Location = new System.Drawing.Point(12, 12);
        this.splitContainer1.Name = "splitContainer1";
        this.splitContainer1.Panel1.Controls.Add(this.Grid);
        this.splitContainer1.Panel2.Controls.Add(this.PropertyGrid);
        this.splitContainer1.Size = new System.Drawing.Size(869, 605);
        this.splitContainer1.SplitterDistance = 279;
        this.splitContainer1.TabIndex = 16;
        this.Grid.AllowUserToAddRows = false;
        this.Grid.AllowUserToDeleteRows = false;
        this.Grid.AllowUserToResizeRows = false;
        this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.Grid.ColumnHeadersVisible = false;
        this.Grid.Columns.AddRange(this.Label);
        this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Grid.Location = new System.Drawing.Point(0, 0);
        this.Grid.MultiSelect = false;
        this.Grid.Name = "Grid";
        this.Grid.ReadOnly = true;
        this.Grid.RowHeadersVisible = false;
        this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.Grid.Size = new System.Drawing.Size(279, 605);
        this.Grid.TabIndex = 2;
        this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.PropertyGrid.HelpVisible = false;
        this.PropertyGrid.LineColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
        this.PropertyGrid.Margin = new System.Windows.Forms.Padding(0);
        this.PropertyGrid.Name = "PropertyGrid";
        this.PropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
        this.PropertyGrid.Size = new System.Drawing.Size(586, 605);
        this.PropertyGrid.TabIndex = 1;
        this.PropertyGrid.ToolbarVisible = false;
        this.ButtonResize.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.ButtonResize.Location = new System.Drawing.Point(12, 628);
        this.ButtonResize.Name = "ButtonResize";
        this.ButtonResize.Size = new System.Drawing.Size(75, 23);
        this.ButtonResize.TabIndex = 17;
        this.ButtonResize.Text = "Resize";
        this.ButtonResize.UseVisualStyleBackColor = true;
        this.ButtonResize.Click += new System.EventHandler(ButtonResize_Click);
        this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.StatusLabel.Location = new System.Drawing.Point(295, 628);
        this.StatusLabel.Name = "StatusLabel";
        this.StatusLabel.Size = new System.Drawing.Size(586, 23);
        this.StatusLabel.TabIndex = 18;
        this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.Label.DataPropertyName = "Label";
        this.Label.HeaderText = "Label";
        this.Label.Name = "Label";
        this.Label.ReadOnly = true;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(893, 663);
        base.Controls.Add(this.StatusLabel);
        base.Controls.Add(this.ButtonResize);
        base.Controls.Add(this.splitContainer1);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(400, 300);
        base.Name = "FormCollectionsEditor";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormCollectionsEditor";
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
        this.splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.Grid).EndInit();
        base.ResumeLayout(false);
    }
}
