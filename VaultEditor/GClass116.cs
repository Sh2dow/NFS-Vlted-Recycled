using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class GClass116
{
    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private float float_1;

    public float Single_0
    {
        [CompilerGenerated]
        get
        {
            return float_0;
        }
        [CompilerGenerated]
        set
        {
            float_0 = value;
        }
    }

    public float Single_1
    {
        [CompilerGenerated]
        get
        {
            return float_1;
        }
        [CompilerGenerated]
        set
        {
            float_1 = value;
        }
    }

    public override string ToString()
    {
        return $"{Single_0}, {Single_1}";
    }
}
