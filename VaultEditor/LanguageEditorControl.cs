using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class LanguageEditorControl : UserControl
{
    private readonly Class112 class112_0;

    private readonly IContainer icontainer_0;

    private DataGridView LanguageEntriesGrid;

    public LanguageEditorControl()
    {
        InitializeComponent();
        class112_0 = new Class112();
        base.Load += LanguageEditorControl_Load;
    }

    public void method_0(string string_0)
    {
        string string_1 = Path.Combine(string_0, "Langauges");
        class112_0.method_0(string_1);
    }

    private void LanguageEditorControl_Load(object sender, EventArgs e)
    {
        LanguageEntriesGrid.smethod_4();
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
        this.LanguageEntriesGrid = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)this.LanguageEntriesGrid).BeginInit();
        base.SuspendLayout();
        this.LanguageEntriesGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.LanguageEntriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.LanguageEntriesGrid.Location = new System.Drawing.Point(3, 3);
        this.LanguageEntriesGrid.Name = "LanguageEntriesGrid";
        this.LanguageEntriesGrid.Size = new System.Drawing.Size(996, 485);
        this.LanguageEntriesGrid.TabIndex = 0;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.Controls.Add(this.LanguageEntriesGrid);
        base.Name = "LanguageEditorControl";
        base.Size = new System.Drawing.Size(1002, 525);
        ((System.ComponentModel.ISupportInitialize)this.LanguageEntriesGrid).EndInit();
        base.ResumeLayout(false);
    }
}
