using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormBytesEditor : Form
{
    public delegate void GDelegate0(int size);

    public delegate void GDelegate1(int index, string propertyName, object value);

    [CompilerGenerated]
    private byte[] byte_0;

    private readonly IContainer icontainer_0;

    private TextBox BytesTextbox;

    private Button ApplyChangesButton;

    public byte[] SelectedObject
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    public FormBytesEditor()
    {
        InitializeComponent();
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | Hex Viewer";
        Text = text;
        this.smethod_1();
        BytesTextbox.smethod_18();
        ApplyChangesButton.smethod_5();
        BytesTextbox.Font = new Font(FontFamily.GenericMonospace, BytesTextbox.Font.Size);
        base.Load += FormBytesEditor_Load;
    }

    private void FormBytesEditor_Load(object sender, EventArgs e)
    {
        method_0();
    }

    private void method_0()
    {
        BytesTextbox.Text = SelectedObject.smethod_1();
    }

    private void ApplyChangesButton_Click(object sender, EventArgs e)
    {
        try
        {
            byte[] selectedObject = BytesTextbox.Text.smethod_2();
            SelectedObject = selectedObject;
        }
        catch (Exception ex)
        {
            GClass109.smethod_1(this, ex.Message);
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
        this.BytesTextbox = new System.Windows.Forms.TextBox();
        this.ApplyChangesButton = new System.Windows.Forms.Button();
        base.SuspendLayout();
        this.BytesTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.BytesTextbox.Location = new System.Drawing.Point(12, 12);
        this.BytesTextbox.Multiline = true;
        this.BytesTextbox.Name = "BytesTextbox";
        this.BytesTextbox.Size = new System.Drawing.Size(776, 230);
        this.BytesTextbox.TabIndex = 0;
        this.ApplyChangesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.ApplyChangesButton.Location = new System.Drawing.Point(671, 248);
        this.ApplyChangesButton.Name = "ApplyChangesButton";
        this.ApplyChangesButton.Size = new System.Drawing.Size(117, 31);
        this.ApplyChangesButton.TabIndex = 1;
        this.ApplyChangesButton.Text = "Apply changes";
        this.ApplyChangesButton.UseVisualStyleBackColor = true;
        this.ApplyChangesButton.Click += new System.EventHandler(ApplyChangesButton_Click);
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(800, 283);
        base.Controls.Add(this.ApplyChangesButton);
        base.Controls.Add(this.BytesTextbox);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(400, 300);
        base.Name = "FormBytesEditor";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormCollectionsEditor";
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
