using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GEventArgs15 : MouseEventArgs
{
    [CompilerGenerated]
    private GClass85 gclass85_0;

    [CompilerGenerated]
    private GClass103 gclass103_0;

    public GClass85 Style
    {
        [CompilerGenerated]
        get
        {
            return gclass85_0;
        }
        [CompilerGenerated]
        private set
        {
            gclass85_0 = value;
        }
    }

    public GClass103 Marker
    {
        [CompilerGenerated]
        get
        {
            return gclass103_0;
        }
        [CompilerGenerated]
        private set
        {
            gclass103_0 = value;
        }
    }

    public GEventArgs15(GClass85 gclass85_1, GClass103 gclass103_1, MouseEventArgs mouseEventArgs_0)
        : base(mouseEventArgs_0.Button, mouseEventArgs_0.Clicks, mouseEventArgs_0.X, mouseEventArgs_0.Y, mouseEventArgs_0.Delta)
    {
        Style = gclass85_1;
        Marker = gclass103_1;
    }
}
