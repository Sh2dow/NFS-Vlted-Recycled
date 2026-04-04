using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass50(uint uint_1)
{
    [CompilerGenerated]
    private readonly uint uint_0 = uint_1;

    public uint Hash
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
    }

    public override string ToString()
    {
        return "0x" + Hash.ToString("X").ToUpper().PadLeft(8, '0');
    }
}
