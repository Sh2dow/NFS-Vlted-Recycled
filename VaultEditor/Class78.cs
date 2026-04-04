namespace VaultEditor;

internal static class Class78
{
    private static readonly uint[] uint_0;

    static Class78()
    {
        uint_0 = new uint[256];
        for (uint num = 0u; num < 256; num++)
        {
            uint num2 = num;
            for (int i = 0; i < 8; i++)
            {
                num2 = (num2 >> 1) ^ (0xEDB88320u & ~((num2 & 1) - 1));
            }
            uint_0[num] = num2;
        }
    }

    public static uint smethod_0(this byte byte_0)
    {
        return uint_0[byte_0];
    }
}
