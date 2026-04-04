using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UserSettings;

namespace VaultEditor;

public sealed class FormSettings : Form
{
    private Settings settings_0;

    private readonly IContainer icontainer_0;

    private PropertyGrid PropertyGrid;

    public Settings Settings_0
    {
        get
        {
            return settings_0;
        }
        set
        {
            settings_0 = value;
            PropertyGrid.SelectedObject = settings_0;
        }
    }

    public FormSettings()
    {
        InitializeComponent();
        method_0();
    }

    private void method_0()
    {
        this.smethod_2();
        PropertyGrid.smethod_16();
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
        this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
        base.SuspendLayout();
        this.PropertyGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.PropertyGrid.Location = new System.Drawing.Point(12, 12);
        this.PropertyGrid.Name = "PropertyGrid";
        this.PropertyGrid.Size = new System.Drawing.Size(580, 337);
        this.PropertyGrid.TabIndex = 0;
        this.PropertyGrid.ToolbarVisible = false;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(604, 361);
        base.Controls.Add(this.PropertyGrid);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.MinimumSize = new System.Drawing.Size(500, 400);
        base.Name = "FormSettings";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Settings";
        base.ResumeLayout(false);
    }
}
