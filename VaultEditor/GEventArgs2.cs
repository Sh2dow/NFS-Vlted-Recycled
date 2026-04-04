using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GEventArgs2 : PaintEventArgs
{
    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private Rectangle rectangle_0;

    public int LineIndex
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        private set
        {
            int_0 = value;
        }
    }

    public Rectangle LineRect
    {
        [CompilerGenerated]
        get
        {
            return rectangle_0;
        }
        [CompilerGenerated]
        private set
        {
            rectangle_0 = value;
        }
    }

    public GEventArgs2(int int_1, Rectangle rectangle_1, Graphics graphics_0, Rectangle rectangle_2)
        : base(graphics_0, rectangle_2)
    {
        LineIndex = int_1;
        LineRect = rectangle_1;
    }
}
