using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class ReplaceForm : Form
{
    private readonly FastColoredTextBox fastColoredTextBox_0;

    private bool bool_0 = true;

    private GStruct10 gstruct10_0;

    private readonly IContainer icontainer_0;

    private Button btClose;

    private Button btFindNext;

    private CheckBox cbRegex;

    private CheckBox cbMatchCase;

    private Label label1;

    private CheckBox cbWholeWord;

    private Button btReplace;

    private Button btReplaceAll;

    private Label label2;

    public TextBox tbFind;

    public TextBox tbReplace;

    public ReplaceForm(FastColoredTextBox fastColoredTextBox_1)
    {
        InitializeComponent();
        fastColoredTextBox_0 = fastColoredTextBox_1;
        this.smethod_1();
        label1.smethod_14();
        tbFind.smethod_18();
        cbMatchCase.smethod_6();
        cbWholeWord.smethod_6();
        cbRegex.smethod_6();
        label2.smethod_14();
        tbReplace.smethod_18();
        btFindNext.smethod_5();
        btReplace.smethod_5();
        btReplaceAll.smethod_5();
        btClose.smethod_5();
    }

    private void btClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btFindNext_Click(object sender, EventArgs e)
    {
        try
        {
            if (!method_1(tbFind.Text))
            {
                GClass109.smethod_1(this, "Not found");
            }
        }
        catch (Exception ex)
        {
            GClass109.smethod_1(this, ex.Message);
        }
    }

    public List<GClass84> method_0(string string_0)
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
        GClass84 obj = (fastColoredTextBox_0.GClass84_5.vmethod_0() ? fastColoredTextBox_0.GClass84_6.method_6() : fastColoredTextBox_0.GClass84_5.method_6());
        List<GClass84> list = [.. obj.method_30(string_0, regexOptions_)];
        return list;
    }

    public bool method_1(string string_0)
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
                fastColoredTextBox_0.GClass84_5.GStruct10_0 = current.GStruct10_0;
                fastColoredTextBox_0.GClass84_5.GStruct10_1 = current.GStruct10_1;
                fastColoredTextBox_0.method_50();
                fastColoredTextBox_0.method_4();
                return true;
            }
        }
        if (GStruct10.smethod_5(gClass.GStruct10_0, gstruct10_0) && GStruct10.smethod_4(gstruct10_0, GStruct10.GStruct10_0))
        {
            fastColoredTextBox_0.GClass84_5.GStruct10_0 = new GStruct10(0, 0);
            return method_1(string_0);
        }
        return false;
    }

    private void tbReplace_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\r')
        {
            btFindNext_Click(sender, null);
        }
        if (e.KeyChar == '\u001b')
        {
            Hide();
        }
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

    private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
        }
        fastColoredTextBox_0.Focus();
    }

    private void btReplace_Click(object sender, EventArgs e)
    {
        try
        {
            if (fastColoredTextBox_0.Int32_11 != 0 && !fastColoredTextBox_0.GClass84_5.Boolean_1)
            {
                fastColoredTextBox_0.vmethod_20(tbReplace.Text);
            }
            btFindNext_Click(sender, null);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btReplaceAll_Click(object sender, EventArgs e)
    {
        try
        {
            fastColoredTextBox_0.GClass84_5.method_38();
            List<GClass84> list = method_0(tbFind.Text);
            bool flag = false;
            foreach (GClass84 item in list)
            {
                if (item.Boolean_1)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag && list.Count > 0)
            {
                fastColoredTextBox_0.GClass97_0.Manager.vmethod_0(new GClass64(fastColoredTextBox_0.GClass97_0, list, tbReplace.Text));
                fastColoredTextBox_0.GClass84_5.GStruct10_0 = new GStruct10(0, 0);
            }
            fastColoredTextBox_0.method_4();
            MessageBox.Show(list.Count + " occurrence(s) replaced");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        fastColoredTextBox_0.GClass84_5.method_39();
    }

    protected override void OnActivated(EventArgs e)
    {
        tbFind.Focus();
        method_2();
    }

    private void method_2()
    {
        bool_0 = true;
    }

    private void tbReplace_TextChanged(object sender, EventArgs e)
    {
        method_2();
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
        this.btReplace = new System.Windows.Forms.Button();
        this.btReplaceAll = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.tbReplace = new System.Windows.Forms.TextBox();
        base.SuspendLayout();
        this.btClose.Location = new System.Drawing.Point(273, 153);
        this.btClose.Name = "btClose";
        this.btClose.Size = new System.Drawing.Size(75, 23);
        this.btClose.TabIndex = 8;
        this.btClose.Text = "Close";
        this.btClose.UseVisualStyleBackColor = true;
        this.btClose.Click += new System.EventHandler(btClose_Click);
        this.btFindNext.Location = new System.Drawing.Point(111, 124);
        this.btFindNext.Name = "btFindNext";
        this.btFindNext.Size = new System.Drawing.Size(75, 23);
        this.btFindNext.TabIndex = 5;
        this.btFindNext.Text = "Find next";
        this.btFindNext.UseVisualStyleBackColor = true;
        this.btFindNext.Click += new System.EventHandler(btFindNext_Click);
        this.tbFind.Location = new System.Drawing.Point(62, 12);
        this.tbFind.Name = "tbFind";
        this.tbFind.Size = new System.Drawing.Size(286, 20);
        this.tbFind.TabIndex = 0;
        this.tbFind.TextChanged += new System.EventHandler(tbReplace_TextChanged);
        this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tbReplace_KeyPress);
        this.cbRegex.AutoSize = true;
        this.cbRegex.Location = new System.Drawing.Point(273, 38);
        this.cbRegex.Name = "cbRegex";
        this.cbRegex.Size = new System.Drawing.Size(57, 17);
        this.cbRegex.TabIndex = 3;
        this.cbRegex.Text = "Regex";
        this.cbRegex.UseVisualStyleBackColor = true;
        this.cbRegex.CheckedChanged += new System.EventHandler(tbReplace_TextChanged);
        this.cbMatchCase.AutoSize = true;
        this.cbMatchCase.Location = new System.Drawing.Point(66, 38);
        this.cbMatchCase.Name = "cbMatchCase";
        this.cbMatchCase.Size = new System.Drawing.Size(82, 17);
        this.cbMatchCase.TabIndex = 1;
        this.cbMatchCase.Text = "Match case";
        this.cbMatchCase.UseVisualStyleBackColor = true;
        this.cbMatchCase.CheckedChanged += new System.EventHandler(tbReplace_TextChanged);
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(23, 14);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(33, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Find: ";
        this.cbWholeWord.AutoSize = true;
        this.cbWholeWord.Location = new System.Drawing.Point(154, 38);
        this.cbWholeWord.Name = "cbWholeWord";
        this.cbWholeWord.Size = new System.Drawing.Size(113, 17);
        this.cbWholeWord.TabIndex = 2;
        this.cbWholeWord.Text = "Match whole word";
        this.cbWholeWord.UseVisualStyleBackColor = true;
        this.cbWholeWord.CheckedChanged += new System.EventHandler(tbReplace_TextChanged);
        this.btReplace.Location = new System.Drawing.Point(192, 124);
        this.btReplace.Name = "btReplace";
        this.btReplace.Size = new System.Drawing.Size(75, 23);
        this.btReplace.TabIndex = 6;
        this.btReplace.Text = "Replace";
        this.btReplace.UseVisualStyleBackColor = true;
        this.btReplace.Click += new System.EventHandler(btReplace_Click);
        this.btReplaceAll.Location = new System.Drawing.Point(273, 124);
        this.btReplaceAll.Name = "btReplaceAll";
        this.btReplaceAll.Size = new System.Drawing.Size(75, 23);
        this.btReplaceAll.TabIndex = 7;
        this.btReplaceAll.Text = "Replace all";
        this.btReplaceAll.UseVisualStyleBackColor = true;
        this.btReplaceAll.Click += new System.EventHandler(btReplaceAll_Click);
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(6, 81);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(50, 13);
        this.label2.TabIndex = 9;
        this.label2.Text = "Replace:";
        this.tbReplace.Location = new System.Drawing.Point(62, 78);
        this.tbReplace.Name = "tbReplace";
        this.tbReplace.Size = new System.Drawing.Size(286, 20);
        this.tbReplace.TabIndex = 0;
        this.tbReplace.TextChanged += new System.EventHandler(tbReplace_TextChanged);
        this.tbReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tbReplace_KeyPress);
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(360, 191);
        base.Controls.Add(this.tbFind);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.tbReplace);
        base.Controls.Add(this.btReplaceAll);
        base.Controls.Add(this.btReplace);
        base.Controls.Add(this.cbWholeWord);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.cbMatchCase);
        base.Controls.Add(this.cbRegex);
        base.Controls.Add(this.btFindNext);
        base.Controls.Add(this.btClose);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        base.Name = "ReplaceForm";
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Find and replace";
        base.TopMost = true;
        base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ReplaceForm_FormClosing);
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
