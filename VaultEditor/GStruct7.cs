using System.Runtime.CompilerServices;

namespace VaultEditor;

public readonly struct GStruct7(long long_1, GStruct0? nullable_1)
{
    [CompilerGenerated]
    private readonly long long_0 = long_1;

    [CompilerGenerated]
    private readonly GStruct0? nullable_0 = nullable_1;

    public long Length
    {
        [CompilerGenerated]
        get
        {
            return long_0;
        }
    }

    public GStruct0? Checksum
    {
        [CompilerGenerated]
        get
        {
            return nullable_0;
        }
    }
}
