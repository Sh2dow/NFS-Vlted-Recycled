using System.Runtime.CompilerServices;

namespace VaultEditor;

internal static class Class226
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte smethod_0(this byte byte_0, int int_0)
    {
        int_0 &= 7;
        return (byte)((byte_0 << int_0) | (byte_0 >> 8 - int_0));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort smethod_1(this ushort ushort_0, int int_0)
    {
        int_0 &= 0xF;
        return (ushort)((ushort_0 << int_0) | (ushort_0 >> 16 - int_0));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint smethod_2(this uint uint_0, int int_0)
    {
        int_0 &= 0x1F;
        return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong smethod_3(this ulong ulong_0, int int_0)
    {
        int_0 &= 0x3F;
        return (ulong_0 << int_0) | (ulong_0 >> 64 - int_0);
    }
}
