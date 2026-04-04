using System.Drawing;

namespace VaultEditor;

public sealed class GClass87(Brush brush_2, Brush brush_3, FontStyle fontStyle_1) : GClass86(brush_2, brush_3, fontStyle_1)
{
    public override void vmethod_0(Graphics graphics_0, Point point_0, GClass84 gclass84_0)
    {
        if (gclass84_0.GStruct10_1.int_0 > gclass84_0.GStruct10_0.int_0)
        {
            base.vmethod_0(graphics_0, point_0, gclass84_0);
            int num = point_0.X;
            for (int i = gclass84_0.GStruct10_0.int_0; i < gclass84_0.GStruct10_1.int_0 && gclass84_0.fastColoredTextBox_0[gclass84_0.GStruct10_0.int_1][i].char_0 == ' '; i++)
            {
                num += gclass84_0.fastColoredTextBox_0.CharWidth;
            }
            gclass84_0.fastColoredTextBox_0.method_19(new GClass102(gclass84_0.GStruct10_0.int_1, new Rectangle(num, point_0.Y, point_0.X + (gclass84_0.GStruct10_1.int_0 - gclass84_0.GStruct10_0.int_0) * gclass84_0.fastColoredTextBox_0.CharWidth - num, gclass84_0.fastColoredTextBox_0.Int32_1)));
        }
        else
        {
            using (Font font = new(gclass84_0.fastColoredTextBox_0.Font, base.FontStyle))
            {
                graphics_0.DrawString("...", font, base.ForeBrush, gclass84_0.fastColoredTextBox_0.LeftIndent, point_0.Y - 2);
            }
            gclass84_0.fastColoredTextBox_0.method_19(new GClass102(gclass84_0.GStruct10_0.int_1, new Rectangle(gclass84_0.fastColoredTextBox_0.LeftIndent + 2, point_0.Y, 2 * gclass84_0.fastColoredTextBox_0.Int32_1, gclass84_0.fastColoredTextBox_0.Int32_1)));
        }
    }
}
