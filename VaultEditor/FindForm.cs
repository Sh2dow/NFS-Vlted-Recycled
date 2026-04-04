using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class FindForm : Form
{
    private bool bool_0 = true;

    private GStruct10 gstruct10_0;

    private readonly FastColoredTextBox fastColoredTextBox_0;

    private readonly IContainer icontainer_0;

    private Button btClose;

    private Button btFindNext;

    private CheckBox cbRegex;

    private CheckBox cbMatchCase;

    private Label label1;

    private CheckBox cbWholeWord;

    public TextBox tbFind;

    public FindForm(FastColoredTextBox fastColoredTextBox_1)
    {
        InitializeComponent();
        fastColoredTextBox_0 = fastColoredTextBox_1;
        this.smethod_1();
        tbFind.smethod_18();
        btFindNext.smethod_5();
        btClose.smethod_5();
        cbMatchCase.smethod_6();
        cbWholeWord.smethod_6();
        cbRegex.smethod_6();
    }

    private void btClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btFindNext_Click(object sender, EventArgs e)
    {
        vmethod_0(tbFind.Text);
    }

    public void vmethod_0(string string_0)
    {
        try
        {
            RegexOptions regexOptions_ = ((!cbMatchCase.Checked) ? RegexOptions.IgnoreCase : RegexOptions.None);
            if (!cbRegex.Checked)
            {
                string_0 = Regex.Escape(string_0);
            }
            if (cbWholeWord.Checked)
            {
                string_0 = "\\b" + string_0 + "\\b";
            }
            GClass84 gClass = fastColoredTextBox_0.GClass84_5.method_6();
            gClass.method_40();
            if (bool_0)
            {
                gstruct10_0 = gClass.GStruct10_0;
                bool_0 = false;
            }
            gClass.GStruct10_0 = gClass.GStruct10_1;
            if (GStruct10.smethod_5(gClass.GStruct10_0, gstruct10_0))
            {
                gClass.GStruct10_1 = new GStruct10(fastColoredTextBox_0.method_23(fastColoredTextBox_0.Int32_9 - 1), fastColoredTextBox_0.Int32_9 - 1);
            }
            else
            {
                gClass.GStruct10_1 = gstruct10_0;
            }
            using (IEnumerator<GClass84> enumerator = gClass.method_30(string_0, regexOptions_).GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    GClass84 current = enumerator.Current;
                    fastColoredTextBox_0.GClass84_5 = current;
                    fastColoredTextBox_0.method_50();
                    fastColoredTextBox_0.method_4();
                    return;
                }
            }
            if (GStruct10.smethod_5(gClass.GStruct10_0, gstruct10_0) && GStruct10.smethod_4(gstruct10_0, GStruct10.GStruct10_0))
            {
                fastColoredTextBox_0.GClass84_5.GStruct10_0 = new GStruct10(0, 0);
                vmethod_0(string_0);
            }
            else
            {
                GClass109.smethod_1(this, "Not found");
            }
        }
        catch (Exception ex)
        {
            GClass109.smethod_1(this, ex.Message);
        }
    }

    private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\r')
        {
            btFindNext.PerformClick();
            e.Handled = true;
        }
        else if (e.KeyChar == '\u001b')
        {
            Hide();
            e.Handled = true;
        }
    }

    private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
        }
        fastColoredTextBox_0.Focus();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == Keys.Escape)
        {
            Close();
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    protected override void OnActivated(EventArgs e)
    {
        tbFind.Focus();
        method_0();
    }

    private void method_0()
    {
        bool_0 = true;
    }

    private void cbWholeWord_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
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
        this.btClose = new System.Windows.Forms.Button();
        this.btFindNext = new System.Windows.Forms.Button();
        this.tbFind = new System.Windows.Forms.TextBox();
        this.cbRegex = new System.Windows.Forms.CheckBox();
        this.cbMatchCase = new System.Windows.Forms.CheckBox();
        this.label1 = new System.Windows.Forms.Label();
        this.cbWholeWord = new System.Windows.Forms.CheckBox();
        base.SuspendLayout();
        this.btClose.Location = new System.Drawing.Point(273, 73);
        this.btClose.Name = "btClose";
        this.btClose.Size = new System.Drawing.Size(75, 23);
        this.btClose.TabIndex = 5;
        this.btClose.Text = "Close";
        this.btClose.UseVisualStyleBackColor = true;
        this.btClose.Click += new System.EventHandler(btClose_Click);
        this.btFindNext.Location = new System.Drawing.Point(192, 73);
        this.btFindNext.Name = "btFindNext";
        this.btFindNext.Size = new System.Drawing.Size(75, 23);
        this.btFindNext.TabIndex = 4;
        this.btFindNext.Text = "Find next";
        this.btFindNext.UseVisualStyleBackColor = true;
        this.btFindNext.Click += new System.EventHandler(btFindNext_Click);
        this.tbFind.Location = new System.Drawing.Point(42, 12);
        this.tbFind.Name = "tbFind";
        this.tbFind.Size = new System.Drawing.Size(306, 20);
        this.tbFind.TabIndex = 0;
        this.tbFind.TextChanged += new System.EventHandler(cbWholeWord_CheckedChanged);
        this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tbFind_KeyPress);
        this.cbRegex.AutoSize = true;
        this.cbRegex.Location = new System.Drawing.Point(249, 38);
        this.cbRegex.Name = "cbRegex";
        this.cbRegex.Size = new System.Drawing.Size(57, 17);
        this.cbRegex.TabIndex = 3;
        this.cbRegex.Text = "Regex";
        this.cbRegex.UseVisualStyleBackColor = true;
        this.cbRegex.CheckedChanged += new System.EventHandler(cbWholeWord_CheckedChanged);
        this.cbMatchCase.AutoSize = true;
        this.cbMatchCase.Location = new System.Drawing.Point(42, 38);
        this.cbMatchCase.Name = "cbMatchCase";
        this.cbMatchCase.Size = new System.Drawing.Size(82, 17);
        this.cbMatchCase.TabIndex = 1;
        this.cbMatchCase.Text = "Match case";
        this.cbMatchCase.UseVisualStyleBackColor = true;
        this.cbMatchCase.CheckedChanged += new System.EventHandler(cbWholeWord_CheckedChanged);
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(6, 15);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(33, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Find: ";
        this.cbWholeWord.AutoSize = true;
        this.cbWholeWord.Location = new System.Drawing.Point(130, 38);
        this.cbWholeWord.Name = "cbWholeWord";
        this.cbWholeWord.Size = new System.Drawing.Size(113, 17);
        this.cbWholeWord.TabIndex = 2;
        this.cbWholeWord.Text = "Match whole word";
        this.cbWholeWord.UseVisualStyleBackColor = true;
        this.cbWholeWord.CheckedChanged += new System.EventHandler(cbWholeWord_CheckedChanged);
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(360, 108);
        base.Controls.Add(this.cbWholeWord);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.cbMatchCase);
        base.Controls.Add(this.cbRegex);
        base.Controls.Add(this.tbFind);
        base.Controls.Add(this.btFindNext);
        base.Controls.Add(this.btClose);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        base.Name = "FindForm";
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Find";
        base.TopMost = true;
        base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FindForm_FormClosing);
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
