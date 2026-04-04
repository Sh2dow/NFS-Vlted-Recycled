using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

internal static class Class187
{
    [CompilerGenerated]
    private sealed class Class188
    {
        public TabControl tabControl_0;

        internal void method_0(object sender, DrawItemEventArgs e)
        {
            SolidBrush brush = new(Color.Red);
            e.Graphics.FillRectangle(brush, tabControl_0.DisplayRectangle);
            using Brush brush2 = new SolidBrush(color_1);
            e.Graphics.FillRectangle(brush2, e.Bounds);
            SizeF sizeF = e.Graphics.MeasureString(tabControl_0.TabPages[e.Index].Text, e.Font);
            e.Graphics.DrawString(tabControl_0.TabPages[e.Index].Text, e.Font, Brushes.Gainsboro, (float)e.Bounds.Left + ((float)e.Bounds.Width - sizeF.Width) / 2f, (float)e.Bounds.Top + ((float)e.Bounds.Height - sizeF.Height) / 2f + 1f);
        }
    }

    private static readonly Color color_0 = Color.LightSteelBlue;

    private static readonly Color color_1 = Color.FromArgb(70, 70, 70);

    private static readonly Color color_2 = Color.FromArgb(55, 55, 55);

    private static Brush brush_0 = Brushes.LightGreen;

    private static Brush brush_1 = Brushes.Gainsboro;

    private static Brush brush_2 = Brushes.LightSkyBlue;

    [CompilerGenerated]
    private static bool bool_0;

    public static bool DarkTheme
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public static void smethod_0(this FlowLayoutPanel flowLayoutPanel_0)
    {
        if (flowLayoutPanel_0 != null && !DarkTheme)
        {
            flowLayoutPanel_0.BackColor = Color.WhiteSmoke;
        }
    }

    public static void smethod_1(this Form form_0)
    {
        if (form_0 != null)
        {
            form_0.Icon = Class13.MainIcon;
            if (DarkTheme)
            {
                form_0.BackColor = color_1;
            }
            else
            {
                form_0.BackColor = Control.DefaultBackColor;
            }
        }
    }

    public static void smethod_2(this Form form_0)
    {
        if (form_0 != null)
        {
            form_0.Icon = Class13.MainIcon;
            form_0.ShowInTaskbar = true;
            if (DarkTheme)
            {
                form_0.BackColor = color_1;
            }
            else
            {
                form_0.BackColor = color_0;
            }
        }
    }

    public static void smethod_3(this SplitContainer splitContainer_0)
    {
        if (splitContainer_0 != null && !DarkTheme)
        {
            splitContainer_0.BackColor = Color.WhiteSmoke;
        }
    }

    public static void smethod_4(this DataGridView dataGridView_0)
    {
        if (dataGridView_0 != null && DarkTheme)
        {
            dataGridView_0.ColumnHeadersDefaultCellStyle.BackColor = color_1;
            dataGridView_0.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dataGridView_0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_0.EnableHeadersVisualStyles = false;
            dataGridView_0.BackgroundColor = color_2;
            dataGridView_0.DefaultCellStyle.BackColor = color_1;
            dataGridView_0.DefaultCellStyle.ForeColor = Color.Gainsboro;
            dataGridView_0.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
        }
    }

    public static void smethod_5(this Button button_0)
    {
        if (button_0 != null && DarkTheme)
        {
            button_0.ForeColor = Color.LightGray;
            button_0.BackColor = color_2;
            button_0.FlatStyle = FlatStyle.Flat;
            button_0.FlatAppearance.BorderColor = Color.Gray;
            button_0.FlatAppearance.BorderSize = 1;
        }
    }

    public static void smethod_6(this CheckBox checkBox_0)
    {
        if (checkBox_0 != null && DarkTheme)
        {
            checkBox_0.ForeColor = Color.LightGray;
        }
    }

    public static void smethod_7(this RadioButton radioButton_0)
    {
        if (radioButton_0 != null && DarkTheme)
        {
            radioButton_0.ForeColor = Color.LightGray;
        }
    }

    public static void smethod_8(this ComboBox comboBox_0)
    {
        if (comboBox_0 != null && DarkTheme)
        {
            comboBox_0.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox_0.DrawItem += smethod_9;
            comboBox_0.ForeColor = Color.LightGray;
            comboBox_0.BackColor = color_2;
        }
    }

    private static void smethod_9(object sender, DrawItemEventArgs e)
    {
        if (e.Index >= 0)
        {
            ComboBox comboBox = sender as ComboBox;
            if (e.State.HasFlag(DrawItemState.Selected))
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.SteelBlue), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(comboBox.BackColor), e.Bounds);
            }
            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, new SolidBrush(comboBox.ForeColor), new Point(e.Bounds.X, e.Bounds.Y));
            e.DrawFocusRectangle();
        }
    }

    public static void smethod_10(this MenuStrip menuStrip_0)
    {
        if (menuStrip_0 != null && DarkTheme)
        {
            menuStrip_0.ForeColor = Color.Gainsboro;
            menuStrip_0.BackColor = color_1;
            menuStrip_0.Renderer = new ToolStripProfessionalRenderer(new DarkThemeColorTable());
            smethod_11(menuStrip_0.Items, Color.Gainsboro, color_2);
        }
    }

    private static void smethod_11(ToolStripItemCollection toolStripItemCollection_0, Color color_3, Color color_4)
    {
        foreach (ToolStripItem item in toolStripItemCollection_0)
        {
            item.BackColor = color_4;
            item.ForeColor = color_3;
            if (item is ToolStripMenuItem)
            {
                smethod_11(((ToolStripMenuItem)item).DropDown.Items, color_3, color_4);
            }
        }
    }

    public static void smethod_12(this ContextMenuStrip contextMenuStrip_0)
    {
        if (contextMenuStrip_0 != null && DarkTheme)
        {
            contextMenuStrip_0.BackColor = color_1;
            contextMenuStrip_0.Renderer = new ToolStripProfessionalRenderer(new DarkThemeColorTable());
            smethod_11(contextMenuStrip_0.Items, Color.Gainsboro, color_2);
        }
    }

    public static void smethod_13(this LinkLabel linkLabel_0)
    {
        if (linkLabel_0 != null && DarkTheme)
        {
            linkLabel_0.ForeColor = Color.LightGray;
            linkLabel_0.LinkColor = Color.Gray;
        }
    }

    public static void smethod_14(this Label label_0)
    {
        if (label_0 != null)
        {
            if (DarkTheme)
            {
                label_0.ForeColor = Color.LightGray;
            }
            else
            {
                label_0.ForeColor = Color.Black;
            }
        }
    }

    public static void smethod_15(this TabControl tabControl_0)
    {
        if (tabControl_0 == null)
        {
            return;
        }
        if (DarkTheme)
        {
            tabControl_0.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl_0.DrawItem += delegate (object sender, DrawItemEventArgs e)
            {
                SolidBrush brush = new(Color.Red);
                e.Graphics.FillRectangle(brush, tabControl_0.DisplayRectangle);
                using Brush brush2 = new SolidBrush(color_1);
                e.Graphics.FillRectangle(brush2, e.Bounds);
                SizeF sizeF = e.Graphics.MeasureString(tabControl_0.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(tabControl_0.TabPages[e.Index].Text, e.Font, Brushes.Gainsboro, (float)e.Bounds.Left + ((float)e.Bounds.Width - sizeF.Width) / 2f, (float)e.Bounds.Top + ((float)e.Bounds.Height - sizeF.Height) / 2f + 1f);
            };
            tabControl_0.Appearance = TabAppearance.Buttons;
            tabControl_0.ForeColor = color_2;
            tabControl_0.BackColor = color_1;
            {
                foreach (TabPage tabPage in tabControl_0.TabPages)
                {
                    tabPage.BorderStyle = BorderStyle.FixedSingle;
                    tabPage.ForeColor = color_2;
                    tabPage.BackColor = color_1;
                }
                return;
            }
        }
        tabControl_0.ForeColor = Color.Black;
    }

    public static void smethod_16(this PropertyGrid propertyGrid_0)
    {
        if (propertyGrid_0 != null && DarkTheme)
        {
            propertyGrid_0.CategorySplitterColor = color_2;
            propertyGrid_0.DisabledItemForeColor = Color.FromArgb(127, 227, 227, 227);
            propertyGrid_0.HelpBackColor = SystemColors.ControlDark;
            propertyGrid_0.LineColor = SystemColors.WindowFrame;
            propertyGrid_0.SelectedItemWithFocusBackColor = SystemColors.ActiveCaption;
            propertyGrid_0.ViewBackColor = color_2;
            propertyGrid_0.ViewForeColor = Color.Gainsboro;
            propertyGrid_0.ViewBorderColor = Color.Black;
            propertyGrid_0.HelpBorderColor = Color.Gray;
            propertyGrid_0.CategoryForeColor = Color.Gainsboro;
            propertyGrid_0.CommandsBorderColor = Color.Black;
        }
    }

    public static void smethod_17(this ListBox listBox_0)
    {
        if (listBox_0 != null && DarkTheme)
        {
            listBox_0.BackColor = color_1;
            listBox_0.ForeColor = Color.LightGray;
        }
    }

    public static void smethod_18(this TextBox textBox_0)
    {
        if (textBox_0 != null && DarkTheme)
        {
            textBox_0.BackColor = color_2;
            textBox_0.ForeColor = Color.LightGray;
            textBox_0.BorderStyle = BorderStyle.FixedSingle;
        }
    }

    public static void smethod_19(this RichTextBox richTextBox_0)
    {
        if (richTextBox_0 != null && DarkTheme)
        {
            richTextBox_0.BackColor = color_2;
            richTextBox_0.ForeColor = Color.LightGray;
        }
    }

    public static void smethod_20(this FastColoredTextBox fastColoredTextBox_0)
    {
        if (fastColoredTextBox_0 != null && DarkTheme)
        {
            fastColoredTextBox_0.BackColor = color_2;
            fastColoredTextBox_0.ForeColor = Color.LightGray;
            fastColoredTextBox_0.Color_3 = Color.LightGray;
            fastColoredTextBox_0.Color_4 = color_1;
        }
    }

    public static void smethod_21(this ToolStripStatusLabel toolStripStatusLabel_0)
    {
        if (toolStripStatusLabel_0 != null && DarkTheme)
        {
            toolStripStatusLabel_0.BackColor = color_2;
            toolStripStatusLabel_0.ForeColor = Color.Gainsboro;
        }
    }

    public static void smethod_22(this TreeView treeView_0)
    {
        if (treeView_0 == null)
        {
            return;
        }
        if (DarkTheme)
        {
            treeView_0.BackColor = color_2;
            treeView_0.ForeColor = Color.Gainsboro;
            treeView_0.BorderStyle = BorderStyle.FixedSingle;
            brush_1 = new SolidBrush(Color.FromArgb(90, 90, 90));
            brush_0 = Brushes.DarkGreen;
            brush_2 = Brushes.SteelBlue;
        }
        treeView_0.DrawMode = TreeViewDrawMode.OwnerDrawText;
        treeView_0.DrawNode += delegate (object sender, DrawTreeNodeEventArgs e)
        {
            Brush transparent = Brushes.Transparent;
            GClass536 obj = e.Node as GClass536;
            GClass537 gClass = e.Node as GClass537;
            bool flag = obj?.IsHighlighted ?? gClass?.IsHighlighted ?? false;
            bool flag2 = obj?.IsMatched ?? gClass?.IsMatched ?? false;
            bool flag3 = obj?.IsMatchedProperty ?? gClass?.IsMatchedProperty ?? false;
            if (e.Node.IsSelected)
            {
                transparent = brush_2;
            }
            else if (flag2)
            {
                transparent = brush_0;
            }
            else if (flag || flag3)
            {
                transparent = brush_1;
            }
            e.Graphics.FillRectangle(transparent, e.Node.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font, e.Node.Bounds, DarkTheme ? Color.Gainsboro : Control.DefaultForeColor);
            e.DrawDefault = false;
        };
    }

    public static void smethod_23(this StatusStrip statusStrip_0)
    {
        if (statusStrip_0 != null && DarkTheme)
        {
            statusStrip_0.BackColor = color_2;
            statusStrip_0.RenderMode = ToolStripRenderMode.Professional;
        }
    }
}
