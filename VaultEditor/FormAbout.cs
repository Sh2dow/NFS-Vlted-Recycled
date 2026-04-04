using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormAbout : Form
{
    private readonly IContainer icontainer_0;

    private Label LabelMain;

    private LinkLabel LabelURL;

    private Label LabelDescription;

    public FormAbout()
    {
        InitializeComponent();
        method_0();
        base.Load += FormAbout_Load;
    }

    private void method_0()
    {
        this.smethod_2();
        LabelMain.smethod_14();
        LabelURL.smethod_13();
        LabelDescription.smethod_14();
    }

    private void FormAbout_Load(object sender, EventArgs e)
    {
        string text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360 | About";
        Text = text;
        LabelMain.Text = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360";
        LabelURL.Text = "Click here to visit Need For Speed Modding Tools";
        LabelURL.LinkClicked += LabelURL_LinkClicked;
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("Some Rights Reserved. Release / distribute as you wish, as long as no modifications are made to any part of this package without prior permission, and you don't profit from any such distribution.");
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("Thanks to Robin'7t4, ArturoPlayerOne, Speedyheart, 379Felipe, nlgzrgn, Arushan (this tool uses some parts of VLTEdit)");
        LabelDescription.Text = stringBuilder.ToString();
    }

    private void LabelURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("https://nfs-tools.blogspot.com/");
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
        this.LabelMain = new System.Windows.Forms.Label();
        this.LabelURL = new System.Windows.Forms.LinkLabel();
        this.LabelDescription = new System.Windows.Forms.Label();
        base.SuspendLayout();
        this.LabelMain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.LabelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.LabelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
        this.LabelMain.Location = new System.Drawing.Point(12, 9);
        this.LabelMain.Name = "LabelMain";
        this.LabelMain.Size = new System.Drawing.Size(460, 109);
        this.LabelMain.TabIndex = 0;
        this.LabelMain.Text = "LabelMain";
        this.LabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LabelURL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.LabelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 238);
        this.LabelURL.Location = new System.Drawing.Point(12, 118);
        this.LabelURL.Name = "LabelURL";
        this.LabelURL.Size = new System.Drawing.Size(460, 28);
        this.LabelURL.TabIndex = 1;
        this.LabelURL.TabStop = true;
        this.LabelURL.Text = "LabelURL";
        this.LabelURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LabelDescription.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.LabelDescription.Location = new System.Drawing.Point(14, 159);
        this.LabelDescription.Name = "LabelDescription";
        this.LabelDescription.Size = new System.Drawing.Size(458, 102);
        this.LabelDescription.TabIndex = 2;
        this.LabelDescription.Text = "LabelDescription";
        this.LabelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(484, 270);
        base.Controls.Add(this.LabelDescription);
        base.Controls.Add(this.LabelURL);
        base.Controls.Add(this.LabelMain);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        base.Name = "FormAbout";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "NFS-VltEd by nfsu360";
        base.ResumeLayout(false);
    }
}
