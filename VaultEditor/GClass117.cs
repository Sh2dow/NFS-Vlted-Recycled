using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class GClass117
{
    [CompilerGenerated]
    private byte byte_0;

    [CompilerGenerated]
    private byte byte_1;

    public byte B1
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    public byte B2
    {
        [CompilerGenerated]
        get
        {
            return byte_1;
        }
        [CompilerGenerated]
        set
        {
            byte_1 = value;
        }
    }

    public override string ToString()
    {
        return B1 + " " + B2;
    }
}
