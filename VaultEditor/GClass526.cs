using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;

namespace VaultEditor;

public sealed class GClass526 : ColorEditor
{
    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        if (value is not int)
        {
            throw new Exception("Only integer is allowed");
        }
        Color color = Color.FromArgb((int)value);
        if (base.EditValue(context, provider, (object)color) is not Color color2)
        {
            throw new Exception();
        }
        return color2.ToArgb();
    }

    public override void PaintValue(PaintValueEventArgs e)
    {
        object value = e.Value;
        if (value is not int)
        {
            throw new Exception("Only integer is allowed");
        }
        SolidBrush solidBrush = new(Color.FromArgb((int)value));
        e.Graphics.FillRectangle(solidBrush, e.Bounds);
        solidBrush.Dispose();
    }
}
