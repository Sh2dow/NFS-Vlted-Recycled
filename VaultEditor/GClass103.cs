using System.Drawing;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass103 : GClass99
{
    [CompilerGenerated]
    private GClass85 gclass85_0;

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

    public GClass103(Rectangle rectangle_1, GClass85 gclass85_1)
        : base(rectangle_1)
    {
        Style = gclass85_1;
    }
}
