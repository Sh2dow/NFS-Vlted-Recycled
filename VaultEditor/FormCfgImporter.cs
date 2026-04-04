using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormCfgImporter : GForm0
{
    private IList<Class212.Class215> ilist_1;

    private readonly Class212 class212_0;

    private readonly IContainer icontainer_0;

    private Button ButtonImport;

    private Button ButtonOK;

    private Button ButtonCancel;

    private DataGridView EntriesGrid;

    private DataGridViewTextBoxColumn Class;

    private DataGridViewTextBoxColumn Collection;

    private DataGridViewTextBoxColumn Field;

    private DataGridViewTextBoxColumn Value;

    public FormCfgImporter()
    {
        base.Commands = [];
        class212_0 = new Class212(this);
        InitializeComponent();
        method_0();
        ButtonOK.Enabled = false;
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | NFSCfg Import results";
        Text = text;
    }

    private void method_0()
    {
        this.smethod_2();
        ButtonOK.smethod_5();
        ButtonCancel.smethod_5();
        ButtonImport.smethod_5();
        EntriesGrid.smethod_4();
    }

    private void ButtonImport_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            AddExtension = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DefaultExt = "nfscfg",
            ShowReadOnly = true,
            Title = "Open NFS Mod Installer by nfsu360 configuration file",
            Filter = "*.nfscfg|*.nfscfg",
            Multiselect = false
        };
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        try
        {
            string fileName = openFileDialog.FileName;
            ilist_1 = class212_0.method_1(fileName);
            class212_0.method_2(ilist_1, base.Database, bool_0: true);
            method_1(EntriesGrid, ilist_1);
            ButtonOK.Enabled = ilist_1.Any(class215_0 => class215_0.IsValid);
        }
        catch (Exception)
        {
            ButtonOK.Enabled = false;
            EntriesGrid.Rows.Clear();
            GClass109.smethod_1(this, "The configuration is either corrupted or not a supported format");
        }
    }

    private void method_1(DataGridView dataGridView_0, IList<Class212.Class215> ilist_2)
    {
        dataGridView_0.Rows.Clear();
        foreach (Class212.Class215 item in ilist_2)
        {
            string value = GClass486.smethod_5(item.Header.CollectionClassHash);
            string value2 = GClass486.smethod_5(item.Header.CollectionNameHash);
            string value3 = GClass486.smethod_5(item.Header.NameHash);
            string value4 = item.Item.ToString();
            DataGridViewRow dataGridViewRow = new()
            {
                Tag = item.Item
            };
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
            {
                Value = value
            });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
            {
                Value = value2
            });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
            {
                Value = value3
            });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
            {
                Value = value4
            });
            if (!item.IsValid)
            {
                dataGridViewRow.DefaultCellStyle.BackColor = Color.DarkRed;
            }
            dataGridView_0.Rows.Insert(0, dataGridViewRow);
        }
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
        if (ilist_1 != null)
        {
            class212_0.method_2(ilist_1, base.Database);
            base.Commands = [.. ilist_1.SelectMany(class215_0 => class215_0.Commands)];
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
        this.ButtonImport = new System.Windows.Forms.Button();
        this.ButtonOK = new System.Windows.Forms.Button();
        this.ButtonCancel = new System.Windows.Forms.Button();
        this.EntriesGrid = new System.Windows.Forms.DataGridView();
        this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)this.EntriesGrid).BeginInit();
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
        this.EntriesGrid.AllowUserToAddRows = false;
        this.EntriesGrid.AllowUserToDeleteRows = false;
        this.EntriesGrid.AllowUserToResizeRows = false;
        this.EntriesGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.EntriesGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.EntriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.EntriesGrid.Columns.AddRange(this.Class, this.Collection, this.Field, this.Value);
        this.EntriesGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.EntriesGrid.Location = new System.Drawing.Point(12, 12);
        this.EntriesGrid.Name = "EntriesGrid";
        this.EntriesGrid.ReadOnly = true;
        this.EntriesGrid.RowHeadersVisible = false;
        this.EntriesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.EntriesGrid.Size = new System.Drawing.Size(795, 382);
        this.EntriesGrid.TabIndex = 4;
        this.Class.HeaderText = "Class";
        this.Class.Name = "Class";
        this.Class.ReadOnly = true;
        this.Collection.HeaderText = "Collection";
        this.Collection.Name = "Collection";
        this.Collection.ReadOnly = true;
        this.Field.HeaderText = "Field";
        this.Field.Name = "Field";
        this.Field.ReadOnly = true;
        this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.Value.HeaderText = "Value";
        this.Value.Name = "Value";
        this.Value.ReadOnly = true;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(819, 450);
        base.Controls.Add(this.EntriesGrid);
        base.Controls.Add(this.ButtonCancel);
        base.Controls.Add(this.ButtonOK);
        base.Controls.Add(this.ButtonImport);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(500, 350);
        base.Name = "FormCfgImporter";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormImportResult";
        ((System.ComponentModel.ISupportInitialize)this.EntriesGrid).EndInit();
        base.ResumeLayout(false);
    }
}
