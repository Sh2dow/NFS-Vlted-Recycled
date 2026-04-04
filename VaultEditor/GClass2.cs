using System.IO;

namespace VaultEditor;

public static class GClass2
{
    internal static GEnum3 genum3_0;

    internal static GEnum3 genum3_1;

    internal static GEnum3 genum3_2;

    internal static GEnum3 genum3_3;

    internal static GEnum3 genum3_4;

    internal static GEnum3 genum3_5;

    internal static GEnum3 genum3_6;

    public static FileAttributes fileAttributes_0;

    public static FileAttributes smethod_0(this GEnum3 genum3_7)
    {
        return (FileAttributes)genum3_7;
    }

    public static FileAttributes? smethod_1(this GEnum3? nullable_0)
    {
        if (!nullable_0.HasValue)
        {
            return null;
        }
        return (FileAttributes)nullable_0.Value;
    }
}
