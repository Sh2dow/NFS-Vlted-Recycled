using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FormMessageBox : Form
{
    public enum GEnum0
    {
        const_0,
        const_1,
        const_2
    }

    [CompilerGenerated]
    private sealed class Class6
    {
        public DialogResult dialogResult_0;

        public FormMessageBox formMessageBox_0;

        internal void method_0(object sender, EventArgs e)
        {
            formMessageBox_0.Close();
            formMessageBox_0.DialogResult = dialogResult_0;
        }
    }

    private MessageBoxButtons messageBoxButtons_0;

    private readonly Label label_0;

    private readonly TextBox textBox_0;

    private DialogResult dialogResult_0;

    [CompilerGenerated]
    private IDictionary<string, string> idictionary_0;

    [CompilerGenerated]
    private GEnum0 genum0_0;

    private readonly IContainer icontainer_0;

    private FlowLayoutPanel FlowPanel;

    private FlowLayoutPanel ButtonsPanel;

    public IDictionary<string, string> Options
    {
        [CompilerGenerated]
        get
        {
            return idictionary_0;
        }
        [CompilerGenerated]
        set
        {
            idictionary_0 = value;
        }
    }

    public GEnum0 CurrentMode
    {
        [CompilerGenerated]
        get
        {
            return genum0_0;
        }
        [CompilerGenerated]
        set
        {
            genum0_0 = value;
        }
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams obj = base.CreateParams;
            obj.ClassStyle |= 512;
            return obj;
        }
    }

    public string String_0
    {
        get
        {
            return label_0.Text;
        }
        set
        {
            Label label = label_0;
            Size size = TextRenderer.MeasureText(value, label.Font);
            label.MinimumSize = size + new Size(label.Padding.Right + label.Padding.Left, label.Padding.Bottom + label.Padding.Top);
            label.Text = value;
        }
    }

    public MessageBoxButtons MessageBoxButtons_0
    {
        get
        {
            return messageBoxButtons_0;
        }
        set
        {
            messageBoxButtons_0 = value;
            switch (value)
            {
                default:
                    throw new ArgumentOutOfRangeException("value", value, null);
                case MessageBoxButtons.OK:
                    method_2(DialogResult.OK);
                    DialogResult_0 = DialogResult.OK;
                    break;
                case MessageBoxButtons.OKCancel:
                    method_2(DialogResult.OK, DialogResult.Cancel);
                    DialogResult_0 = DialogResult.OK;
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    method_2(DialogResult.Abort, DialogResult.Retry, DialogResult.Ignore);
                    DialogResult_0 = DialogResult.Retry;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    method_2(DialogResult.Yes, DialogResult.No, DialogResult.Cancel);
                    DialogResult_0 = DialogResult.Yes;
                    break;
                case MessageBoxButtons.YesNo:
                    method_2(DialogResult.Yes, DialogResult.No);
                    DialogResult_0 = DialogResult.Yes;
                    break;
                case MessageBoxButtons.RetryCancel:
                    method_2(DialogResult.Retry, DialogResult.Cancel);
                    DialogResult_0 = DialogResult.Retry;
                    break;
            }
        }
    }

    public string String_1
    {
        get
        {
            return textBox_0.Text;
        }
        set
        {
            textBox_0.Text = value;
            textBox_0.SelectAll();
        }
    }

    public IEnumerable<string> IEnumerable_0 => (from checkBox_0 in FlowPanel.Controls.OfType<CheckBox>()
                                                 where checkBox_0.Checked
                                                 select checkBox_0.Tag.ToString()).ToList();

    public DialogResult DialogResult_0
    {
        get
        {
            return dialogResult_0;
        }
        set
        {
            dialogResult_0 = value;
            base.ActiveControl = ButtonsPanel.Controls.OfType<Button>().FirstOrDefault(button_0 => (DialogResult)button_0.Tag == dialogResult_0);
        }
    }

    public FormMessageBox()
    {
        InitializeComponent();
        FlowPanel.AutoSize = true;
        label_0 = new Label
        {
            TextAlign = ContentAlignment.MiddleLeft
        };
        textBox_0 = new TextBox
        {
            MinimumSize = new Size(300, 0)
        };
        CurrentMode = GEnum0.const_0;
        method_0();
        Focus();
    }

    private void method_0()
    {
        this.smethod_2();
        label_0.smethod_14();
        textBox_0.smethod_18();
        FlowPanel.smethod_0();
        base.Load += FormMessageBox_Load;
    }

    private void FormMessageBox_Load(object sender, EventArgs e)
    {
        switch (CurrentMode)
        {
            default:
                throw new ArgumentOutOfRangeException("CurrentMode", CurrentMode, null);
            case GEnum0.const_0:
                FlowPanel.Controls.Add(label_0);
                break;
            case GEnum0.const_1:
                FlowPanel.Controls.Add(label_0);
                FlowPanel.Controls.Add(textBox_0);
                base.ActiveControl = textBox_0;
                break;
            case GEnum0.const_2:
                FlowPanel.Controls.Add(label_0);
                foreach (KeyValuePair<string, string> option in Options)
                {
                    CheckBox checkBox = new();
                    checkBox.smethod_6();
                    checkBox.CheckedChanged += method_1;
                    checkBox.AutoSize = true;
                    checkBox.Text = option.Key;
                    checkBox.Tag = option.Value;
                    FlowPanel.Controls.Add(checkBox);
                }
                method_1(null, null);
                break;
        }
        CenterToScreen();
    }

    private void method_1(object sender, EventArgs e)
    {
        if (base.AcceptButton != null)
        {
            ((Button)base.AcceptButton).Enabled = IEnumerable_0.Any();
        }
    }

    private void method_2(params DialogResult[] dialogResult_1)
    {
        foreach (DialogResult dialogResult_2 in dialogResult_1.Reverse())
        {
            Button button = new()
            {
                Width = 100,
                Height = 27,
                Text = dialogResult_2.ToString(),
                Tag = dialogResult_2,
                UseVisualStyleBackColor = true
            };
            button.Click += delegate
            {
                Close();
                base.DialogResult = dialogResult_2;
            };
            if (dialogResult_2.smethod_3(DialogResult.OK, DialogResult.Yes, DialogResult.Retry))
            {
                base.AcceptButton = button;
            }
            if (dialogResult_2.smethod_3(DialogResult.Cancel, DialogResult.Abort, DialogResult.No))
            {
                base.CancelButton = button;
            }
            ButtonsPanel.Controls.Add(button);
            button.smethod_5();
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
        System.ComponentModel.ComponentResourceManager resources = new(typeof(VaultEditor.FormMessageBox));
        this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
        this.ButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
        base.SuspendLayout();
        this.FlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.FlowPanel.AutoSize = true;
        this.FlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        this.FlowPanel.Location = new System.Drawing.Point(0, 0);
        this.FlowPanel.Name = "FlowPanel";
        this.FlowPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
        this.FlowPanel.Size = new System.Drawing.Size(434, 63);
        this.FlowPanel.TabIndex = 11;
        this.FlowPanel.WrapContents = false;
        this.ButtonsPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.ButtonsPanel.Location = new System.Drawing.Point(12, 74);
        this.ButtonsPanel.Name = "ButtonsPanel";
        this.ButtonsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.ButtonsPanel.Size = new System.Drawing.Size(410, 30);
        this.ButtonsPanel.TabIndex = 12;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        base.ClientSize = new System.Drawing.Size(434, 111);
        base.Controls.Add(this.ButtonsPanel);
        base.Controls.Add(this.FlowPanel);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        base.MinimizeBox = false;
        this.MinimumSize = new System.Drawing.Size(450, 150);
        base.Name = "FormMessageBox";
        base.ShowInTaskbar = false;
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        base.TopMost = true;
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    [CompilerGenerated]
    private bool method_3(Button button_0)
    {
        return (DialogResult)button_0.Tag == dialogResult_0;
    }
}
