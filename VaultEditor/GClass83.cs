using System;
using System.Runtime.InteropServices;

namespace VaultEditor;

public static class GClass83
{
    private struct Struct24
    {
        public ushort ushort_0;

        public ushort ushort_1;

        public uint uint_0;

        public IntPtr intptr_0;

        public IntPtr intptr_1;

        public UIntPtr uintptr_0;

        public uint uint_1;

        public uint uint_2;

        public uint uint_3;

        public ushort ushort_2;

        public ushort ushort_3;
    }

    private static readonly ushort ushort_0;

    private static readonly ushort ushort_1;

    private static readonly ushort ushort_2;

    private static readonly ushort ushort_3;

    [DllImport("kernel32.dll")]
    private static extern void GetNativeSystemInfo(ref Struct24 struct24_0);

    [DllImport("kernel32.dll")]
    private static extern void GetSystemInfo(ref Struct24 struct24_0);

    public static GEnum12 smethod_0()
    {
        Struct24 struct24_ = default;
        if (Environment.OSVersion.Version.Major <= 5 && (Environment.OSVersion.Version.Major != 5 || Environment.OSVersion.Version.Minor < 1))
        {
            GetSystemInfo(ref struct24_);
        }
        else
        {
            GetNativeSystemInfo(ref struct24_);
        }
        return struct24_.ushort_0 switch
        {
            6 or 9 => GEnum12.const_1,
            0 => GEnum12.const_0,
            _ => GEnum12.const_2,
        };
    }
}
