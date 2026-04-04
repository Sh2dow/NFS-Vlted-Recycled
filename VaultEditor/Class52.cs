using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal static class Class52
{
    internal sealed class Class53
    {
        internal static int int_0;

        internal static uint uint_0;

        internal static uint uint_1;

        internal static uint uint_2;

        internal static uint uint_3;

        internal static int int_1;

        public Struct0<byte> struct0_0;

        public uint uint_4;

        public uint uint_5;

        public uint uint_6;

        public uint uint_7;

        public uint uint_8;

        public uint uint_9;

        public uint uint_10;

        public uint[] uint_11;

        public Struct0<uint> struct0_1;

        public uint uint_12;

        public uint uint_13;

        public Struct0<byte> struct0_2;

        public Interface2 interface2_0;

        public bool bool_0;

        public uint uint_14;

        public uint uint_15;

        public uint uint_16;

        public uint uint_17;

        public bool bool_1;

        public long long_0;

        public bool bool_2;

        public bool bool_3;

        public uint uint_18;

        public uint uint_19;

        public uint uint_20;

        public uint uint_21;

        public Struct21 struct21_0;

        internal Class53()
        {
            struct0_2 = Struct0<byte>.smethod_14(null);
            bool_1 = false;
            uint_11 = null;
            uint_13 = 32u;
            bool_2 = true;
            uint_17 = 4u;
            bool_3 = false;
        }

        internal bool method_0()
        {
            if (bool_1)
            {
                return false;
            }
            return Struct0<byte>.smethod_4(Struct0<byte>.smethod_10(struct0_2, uint_14), struct0_0) <= uint_16;
        }

        internal Struct0<byte> method_1()
        {
            return struct0_0;
        }

        internal void method_2()
        {
            Class20.smethod_2(struct0_2, Struct0<byte>.smethod_9(struct0_0, uint_15), uint_6 - uint_4 + uint_15);
            struct0_0 = Struct0<byte>.smethod_10(struct0_2, uint_15);
        }

        internal void method_3()
        {
            if (!bool_0 && uint_16 >= uint_6 - uint_4)
            {
                method_9();
            }
        }

        private void method_4(Class77 class77_0)
        {
            if (!bool_1)
            {
                class77_0.method_6(class77_0, struct0_2.gparam_0);
                struct0_2 = Struct0<byte>.smethod_14(null);
            }
        }

        private bool method_5(uint uint_22, Class77 class77_0)
        {
            uint num = uint_15 + uint_16 + uint_22;
            if (bool_1)
            {
                uint_14 = num;
                return true;
            }
            if (Struct0<byte>.smethod_15(struct0_2, Struct0<byte>.smethod_14(null)) || uint_14 != num)
            {
                method_4(class77_0);
                uint_14 = num;
                struct0_2 = Struct0<byte>.smethod_14(class77_0.method_2(class77_0, num));
            }
            return Struct0<byte>.smethod_16(struct0_2, Struct0<byte>.smethod_14(null));
        }

        internal byte method_6(int int_2)
        {
            return struct0_0[int_2];
        }

        internal uint method_7()
        {
            return uint_6 - uint_4;
        }

        internal void method_8(uint uint_22)
        {
            uint_5 -= uint_22;
            uint_4 -= uint_22;
            uint_6 -= uint_22;
        }

        private void method_9()
        {
            if (bool_0 || Struct21.smethod_1(struct21_0, Struct21_0))
            {
                return;
            }
            if (bool_1)
            {
                uint num = uint.MaxValue - uint_6;
                if (num > long_0)
                {
                    num = (uint)long_0;
                }
                long_0 -= num;
                uint_6 += num;
                if (long_0 == 0L)
                {
                    bool_0 = true;
                }
                return;
            }
            do
            {
                Struct0<byte> @struct = Struct0<byte>.smethod_10(struct0_0, uint_6 - uint_4);
                long num2 = Struct0<byte>.smethod_4(Struct0<byte>.smethod_10(struct0_2, uint_14), @struct);
                if (num2 != 0L)
                {
                    struct21_0 = interface2_0.imethod_0(@struct, ref num2);
                    if (!Struct21.smethod_1(struct21_0, Struct21_0))
                    {
                        if (num2 != 0L)
                        {
                            uint_6 += (uint)(int)num2;
                            continue;
                        }
                        bool_0 = true;
                        break;
                    }
                    break;
                }
                break;
            }
            while (uint_6 - uint_4 <= uint_16);
        }

        private void method_10()
        {
            if (method_0())
            {
                method_2();
            }
            method_9();
        }

        private void method_11(Class77 class77_0)
        {
            class77_0.method_8(class77_0, uint_11);
            uint_11 = null;
        }

        internal void method_12(Class77 class77_0)
        {
            method_11(class77_0);
            method_4(class77_0);
        }

        private static uint[] smethod_0(uint uint_22, Class77 class77_0)
        {
            if ((long)uint_22 * 4L / 4L != uint_22)
            {
                return null;
            }
            return class77_0.method_4(class77_0, uint_22);
        }

        internal bool method_13(uint uint_22, uint uint_23, uint uint_24, uint uint_25, Class77 class77_0)
        {
            if (uint_22 > 3221225472u)
            {
                method_12(class77_0);
                return false;
            }
            uint num = uint_22 >> 1;
            if (uint_22 > 2147483648u)
            {
                num = uint_22 >> 2;
            }
            num += (uint_23 + uint_24 + uint_25) / 2 + 524288;
            uint_15 = uint_22 + uint_23 + 1;
            uint_16 = uint_24 + uint_25;
            if (method_5(num, class77_0))
            {
                uint num2 = uint_22 + 1;
                uint_10 = uint_24;
                uint_19 = 0u;
                uint num3;
                if (uint_17 == 2)
                {
                    num3 = 65535u;
                }
                else
                {
                    num3 = uint_22 - 1;
                    num3 |= num3 >> 1;
                    num3 |= num3 >> 2;
                    num3 |= num3 >> 4;
                    num3 |= num3 >> 8;
                    num3 >>= 1;
                    num3 |= 0xFFFF;
                    if (num3 > 16777216)
                    {
                        num3 = ((uint_17 != 3) ? (num3 >> 1) : 16777215u);
                    }
                }
                uint_12 = num3;
                num3++;
                if (uint_17 > 2)
                {
                    uint_19 += 1024u;
                }
                if (uint_17 > 3)
                {
                    uint_19 += 65536u;
                }
                if (uint_17 > 4)
                {
                    uint_19 += 1048576u;
                }
                num3 += uint_19;
                uint num4 = uint_20 + uint_21;
                uint_18 = uint_22;
                uint_20 = num3;
                uint_9 = num2;
                uint_21 = (bool_2 ? (num2 * 2) : num2);
                uint num5 = uint_20 + uint_21;
                if (uint_11 != null && num4 == num5)
                {
                    return true;
                }
                method_11(class77_0);
                uint_11 = smethod_0(num5, class77_0);
                if (uint_11 != null)
                {
                    struct0_1 = Class15.smethod_1(uint_11, uint_20);
                    return true;
                }
            }
            method_12(class77_0);
            return false;
        }

        private void method_14()
        {
            uint num = uint.MaxValue - uint_4;
            uint num2 = uint_9 - uint_8;
            if (num2 < num)
            {
                num = num2;
            }
            num2 = uint_6 - uint_4;
            if (num2 <= uint_16)
            {
                if (num2 != 0)
                {
                    num2 = 1u;
                }
            }
            else
            {
                num2 -= uint_16;
            }
            if (num2 < num)
            {
                num = num2;
            }
            uint num3 = uint_6 - uint_4;
            if (num3 > uint_10)
            {
                num3 = uint_10;
            }
            uint_7 = num3;
            uint_5 = uint_4 + num;
        }

        internal void method_15()
        {
            Array.Clear(uint_11, 0, (int)uint_20);
            uint_8 = 0u;
            struct0_0 = struct0_2;
            uint_4 = uint_9;
            uint_6 = uint_9;
            struct21_0 = Struct21_0;
            bool_0 = false;
            method_9();
            method_14();
        }

        private uint method_16()
        {
            return (uint_4 - uint_18 - 1) & 0xFFFFFC00u;
        }

        internal static void smethod_1(uint uint_22, Struct0<uint> struct0_3, uint uint_23)
        {
            for (uint num = 0u; num < uint_23; num++)
            {
                uint num2 = struct0_3[num];
                num2 = ((num2 > uint_22) ? (num2 - uint_22) : 0u);
                struct0_3[num] = num2;
            }
        }

        private void method_17()
        {
            uint uint_ = method_16();
            smethod_1(uint_, Struct0<uint>.smethod_14(uint_11), uint_20 + uint_21);
            method_8(uint_);
        }

        private void method_18()
        {
            if (uint_4 == uint.MaxValue)
            {
                method_17();
            }
            if (!bool_0 && uint_16 == uint_6 - uint_4)
            {
                method_10();
            }
            if (uint_8 == uint_9)
            {
                uint_8 = 0u;
            }
            method_14();
        }

        private static Struct0<uint> smethod_2(uint uint_22, uint uint_23, uint uint_24, Struct0<byte> struct0_3, Struct0<uint> struct0_4, uint uint_25, uint uint_26, uint uint_27, Struct0<uint> struct0_5, uint uint_28)
        {
            struct0_4[uint_25] = uint_23;
            while (true)
            {
                uint num = uint_24 - uint_23;
                if (uint_27-- == 0 || num >= uint_26)
                {
                    break;
                }
                Struct0<byte> @struct = Struct0<byte>.smethod_9(struct0_3, num);
                uint_23 = struct0_4[uint_25 - num + ((num > uint_25) ? uint_26 : 0)];
                if (@struct[uint_28] != struct0_3[uint_28] || @struct[0] != struct0_3[0])
                {
                    continue;
                }
                uint num2 = 0u;
                while (++num2 != uint_22 && @struct[num2] == struct0_3[num2])
                {
                }
                if (uint_28 < num2)
                {
                    struct0_5[0] = (uint_28 = num2);
                    struct0_5 = Struct0<uint>.smethod_12(struct0_5);
                    struct0_5[0] = num - 1;
                    struct0_5 = Struct0<uint>.smethod_12(struct0_5);
                    if (num2 == uint_22)
                    {
                        return struct0_5;
                    }
                }
            }
            return struct0_5;
        }

        internal static Struct0<uint> smethod_3(uint uint_22, uint uint_23, uint uint_24, Struct0<byte> struct0_3, Struct0<uint> struct0_4, uint uint_25, uint uint_26, uint uint_27, Struct0<uint> struct0_5, uint uint_28)
        {
            Struct0<uint> @struct = Struct0<uint>.smethod_6(Struct0<uint>.smethod_10(struct0_4, uint_25 << 1), 1);
            Struct0<uint> struct2 = Struct0<uint>.smethod_10(struct0_4, uint_25 << 1);
            uint num = 0u;
            uint num2 = 0u;
            while (true)
            {
                uint num3 = uint_24 - uint_23;
                if (uint_27-- == 0 || num3 >= uint_26)
                {
                    break;
                }
                Struct0<uint> struct3 = Struct0<uint>.smethod_10(struct0_4, uint_25 - num3 + ((num3 > uint_25) ? uint_26 : 0) << 1);
                Struct0<byte> struct4 = Struct0<byte>.smethod_9(struct0_3, num3);
                uint num4 = ((num < num2) ? num : num2);
                if (struct4[num4] == struct0_3[num4])
                {
                    if (++num4 != uint_22 && struct4[num4] == struct0_3[num4])
                    {
                        while (++num4 != uint_22 && struct4[num4] == struct0_3[num4])
                        {
                        }
                    }
                    if (uint_28 < num4)
                    {
                        struct0_5[0] = (uint_28 = num4);
                        struct0_5 = Struct0<uint>.smethod_12(struct0_5);
                        struct0_5[0] = num3 - 1;
                        struct0_5 = Struct0<uint>.smethod_12(struct0_5);
                        if (num4 == uint_22)
                        {
                            struct2[0] = struct3[0];
                            @struct[0] = struct3[1];
                            return struct0_5;
                        }
                    }
                }
                if (struct4[num4] < struct0_3[num4])
                {
                    struct2[0] = uint_23;
                    struct2 = Struct0<uint>.smethod_6(struct3, 1);
                    uint_23 = struct2[0];
                    num2 = num4;
                }
                else
                {
                    @struct[0] = uint_23;
                    @struct = struct3;
                    uint_23 = @struct[0];
                    num = num4;
                }
            }
            struct2[0] = 0u;
            @struct[0] = 0u;
            return struct0_5;
        }

        private static void smethod_4(uint uint_22, uint uint_23, uint uint_24, Struct0<byte> struct0_3, Struct0<uint> struct0_4, uint uint_25, uint uint_26, uint uint_27)
        {
            Struct0<uint> @struct = Struct0<uint>.smethod_6(Struct0<uint>.smethod_10(struct0_4, uint_25 << 1), 1);
            Struct0<uint> struct2 = Struct0<uint>.smethod_10(struct0_4, uint_25 << 1);
            uint num = 0u;
            uint num2 = 0u;
            while (true)
            {
                uint num3 = uint_24 - uint_23;
                if (uint_27-- == 0 || num3 >= uint_26)
                {
                    break;
                }
                Struct0<uint> struct3 = Struct0<uint>.smethod_10(struct0_4, uint_25 - num3 + ((num3 > uint_25) ? uint_26 : 0) << 1);
                Struct0<byte> struct4 = Struct0<byte>.smethod_9(struct0_3, num3);
                uint num4 = ((num < num2) ? num : num2);
                if (struct4[num4] == struct0_3[num4])
                {
                    while (++num4 != uint_22 && struct4[num4] == struct0_3[num4])
                    {
                    }
                    if (num4 == uint_22)
                    {
                        struct2[0] = struct3[0];
                        @struct[0] = struct3[1];
                        return;
                    }
                }
                if (struct4[num4] < struct0_3[num4])
                {
                    struct2[0] = uint_23;
                    struct2 = Struct0<uint>.smethod_6(struct3, 1);
                    uint_23 = struct2[0];
                    num2 = num4;
                }
                else
                {
                    @struct[0] = uint_23;
                    @struct = struct3;
                    uint_23 = @struct[0];
                    num = num4;
                }
            }
            struct2[0] = 0u;
            @struct[0] = 0u;
        }

        private void method_19()
        {
            uint_8++;
            struct0_0 = Struct0<byte>.smethod_12(struct0_0);
            uint_4++;
            if (uint_4 == uint_5)
            {
                method_18();
            }
        }

        internal uint method_20(Struct0<uint> struct0_3)
        {
            uint num = uint_7;
            if (num < 2)
            {
                method_19();
                return 0u;
            }
            Struct0<byte> @struct = struct0_0;
            uint num2 = (uint)(@struct[0] | (@struct[1] << 8));
            uint uint_ = uint_11[num2];
            uint_11[num2] = uint_4;
            uint result = (uint)Struct0<uint>.smethod_4(smethod_3(num, uint_, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13, Struct0<uint>.smethod_10(struct0_3, 0u), 1u), struct0_3);
            uint_8++;
            struct0_0 = Struct0<byte>.smethod_12(struct0_0);
            if (++uint_4 == uint_5)
            {
                method_18();
            }
            return result;
        }

        internal uint method_21(Struct0<uint> struct0_3)
        {
            uint num = uint_7;
            if (num < 3)
            {
                method_19();
                return 0u;
            }
            Struct0<byte> @struct = struct0_0;
            uint num2 = @struct[0].smethod_0() ^ @struct[1];
            uint num3 = num2 & 0x3FF;
            uint num4 = (num2 ^ (uint)(@struct[2] << 8)) & uint_12;
            uint num5 = uint_4 - uint_11[num3];
            uint uint_ = uint_11[1024 + num4];
            uint_11[num3] = uint_4;
            uint_11[1024 + num4] = uint_4;
            uint num6 = 2u;
            uint result = 0u;
            if (num5 < uint_9 && @struct[0L - (long)num5] == @struct[0])
            {
                for (; num6 != num && @struct[num6 - num5] == @struct[num6]; num6++)
                {
                }
                struct0_3[0] = num6;
                struct0_3[1] = num5 - 1;
                result = 2u;
                if (num6 == num)
                {
                    smethod_4(num, uint_, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13);
                    uint_8++;
                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                    if (++uint_4 == uint_5)
                    {
                        method_18();
                    }
                    return result;
                }
            }
            result = (uint)Struct0<uint>.smethod_4(smethod_3(num, uint_, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13, Struct0<uint>.smethod_10(struct0_3, result), num6), struct0_3);
            uint_8++;
            struct0_0 = Struct0<byte>.smethod_12(struct0_0);
            if (++uint_4 == uint_5)
            {
                method_18();
            }
            return result;
        }

        internal uint method_22(Struct0<uint> struct0_3)
        {
            uint num = uint_7;
            if (num < 4)
            {
                method_19();
                return 0u;
            }
            Struct0<byte> @struct = struct0_0;
            uint num2 = @struct[0].smethod_0() ^ @struct[1];
            uint num3 = num2 & 0x3FF;
            uint num4 = (num2 ^ (uint)(@struct[2] << 8)) & 0xFFFF;
            uint num5 = (num2 ^ (uint)(@struct[2] << 8) ^ (@struct[3].smethod_0() << 5)) & uint_12;
            uint num6 = uint_4 - uint_11[num3];
            uint num7 = uint_4 - uint_11[1024 + num4];
            uint uint_ = uint_11[66560 + num5];
            uint_11[num3] = uint_4;
            uint_11[1024 + num4] = uint_4;
            uint_11[66560 + num5] = uint_4;
            uint num8 = 1u;
            uint num9 = 0u;
            if (num6 < uint_9 && @struct[0L - (long)num6] == @struct[0])
            {
                num8 = 2u;
                struct0_3[0] = 2u;
                struct0_3[1] = num6 - 1;
                num9 = 2u;
            }
            if (num6 != num7 && num7 < uint_9 && @struct[0L - (long)num7] == @struct[0])
            {
                num8 = 3u;
                struct0_3[num9 + 1] = num7 - 1;
                num9 += 2;
                num6 = num7;
            }
            if (num9 != 0)
            {
                for (; num8 != num && @struct[num8 - num6] == @struct[num8]; num8++)
                {
                }
                struct0_3[num9 - 2] = num8;
                if (num8 == num)
                {
                    smethod_4(num, uint_, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13);
                    uint_8++;
                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                    if (++uint_4 == uint_5)
                    {
                        method_18();
                    }
                    return num9;
                }
            }
            if (num8 < 3)
            {
                num8 = 3u;
            }
            num9 = (uint)Struct0<uint>.smethod_4(smethod_3(num, uint_, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13, Struct0<uint>.smethod_10(struct0_3, num9), num8), struct0_3);
            uint_8++;
            struct0_0 = Struct0<byte>.smethod_12(struct0_0);
            if (++uint_4 == uint_5)
            {
                method_18();
            }
            return num9;
        }

        internal uint method_23(Struct0<uint> struct0_3)
        {
            uint num = uint_7;
            if (num < 4)
            {
                method_19();
                return 0u;
            }
            Struct0<byte> @struct = struct0_0;
            uint num2 = @struct[0].smethod_0() ^ @struct[1];
            uint num3 = num2 & 0x3FF;
            uint num4 = (num2 ^ (uint)(@struct[2] << 8)) & 0xFFFF;
            uint num5 = (num2 ^ (uint)(@struct[2] << 8) ^ (@struct[3].smethod_0() << 5)) & uint_12;
            uint num6 = uint_4 - uint_11[num3];
            uint num7 = uint_4 - uint_11[1024 + num4];
            uint num8 = uint_11[66560 + num5];
            uint_11[num3] = uint_4;
            uint_11[1024 + num4] = uint_4;
            uint_11[66560 + num5] = uint_4;
            uint num9 = 1u;
            uint num10 = 0u;
            if (num6 < uint_9 && @struct[0L - (long)num6] == @struct[0])
            {
                num9 = 2u;
                struct0_3[0] = 2u;
                struct0_3[1] = num6 - 1;
                num10 = 2u;
            }
            if (num6 != num7 && num7 < uint_9 && @struct[0L - (long)num7] == @struct[0])
            {
                num9 = 3u;
                struct0_3[num10 + 1] = num7 - 1;
                num10 += 2;
                num6 = num7;
            }
            if (num10 != 0)
            {
                for (; num9 != num && @struct[num9 - num6] == @struct[num9]; num9++)
                {
                }
                struct0_3[num10 - 2] = num9;
                if (num9 == num)
                {
                    struct0_1[uint_8] = num8;
                    uint_8++;
                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                    uint_4++;
                    if (uint_4 == uint_5)
                    {
                        method_18();
                    }
                    return num10;
                }
            }
            if (num9 < 3)
            {
                num9 = 3u;
            }
            num10 = (uint)Struct0<uint>.smethod_4(smethod_2(num, num8, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13, Struct0<uint>.smethod_10(struct0_3, num10), num9), struct0_3);
            uint_8++;
            struct0_0 = Struct0<byte>.smethod_12(struct0_0);
            uint_4++;
            if (uint_4 == uint_5)
            {
                method_18();
            }
            return num10;
        }

        internal void method_24(uint uint_22)
        {
            do
            {
                uint num = uint_7;
                if (num >= 2)
                {
                    Struct0<byte> @struct = struct0_0;
                    uint num2 = (uint)(@struct[0] | (@struct[1] << 8));
                    uint uint_23 = uint_11[num2];
                    uint_11[num2] = uint_4;
                    smethod_4(num, uint_23, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13);
                    uint_8++;
                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                    if (++uint_4 == uint_5)
                    {
                        method_18();
                    }
                }
                else
                {
                    method_19();
                }
            }
            while (--uint_22 != 0);
        }

        internal void method_25(uint uint_22)
        {
            do
            {
                uint num = uint_7;
                if (num >= 3)
                {
                    Struct0<byte> @struct = struct0_0;
                    uint num2 = @struct[0].smethod_0() ^ @struct[1];
                    uint num3 = num2 & 0x3FF;
                    uint num4 = (num2 ^ (uint)(@struct[2] << 8)) & uint_12;
                    uint uint_23 = uint_11[1024 + num4];
                    uint_11[num3] = uint_4;
                    uint_11[1024 + num4] = uint_4;
                    smethod_4(num, uint_23, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13);
                    uint_8++;
                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                    if (++uint_4 == uint_5)
                    {
                        method_18();
                    }
                }
                else
                {
                    method_19();
                }
            }
            while (--uint_22 != 0);
        }

        internal void method_26(uint uint_22)
        {
            do
            {
                uint num = uint_7;
                if (num >= 4)
                {
                    Struct0<byte> @struct = struct0_0;
                    uint num2 = @struct[0].smethod_0() ^ @struct[1];
                    uint num3 = num2 & 0x3FF;
                    uint num4 = (num2 ^ (uint)(@struct[2] << 8)) & 0xFFFF;
                    uint num5 = (num2 ^ (uint)(@struct[2] << 8) ^ (@struct[3].smethod_0() << 5)) & uint_12;
                    uint uint_23 = uint_11[66560 + num5];
                    uint_11[num3] = uint_4;
                    uint_11[1024 + num4] = uint_4;
                    uint_11[66560 + num5] = uint_4;
                    smethod_4(num, uint_23, uint_4, struct0_0, struct0_1, uint_8, uint_9, uint_13);
                    uint_8++;
                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                    if (++uint_4 == uint_5)
                    {
                        method_18();
                    }
                }
                else
                {
                    method_19();
                }
            }
            while (--uint_22 != 0);
        }

        internal void method_27(uint uint_22)
        {
            do
            {
                if (uint_7 >= 4)
                {
                    Struct0<byte> @struct = struct0_0;
                    uint num = @struct[0].smethod_0() ^ @struct[1];
                    uint num2 = num & 0x3FF;
                    uint num3 = (num ^ (uint)(@struct[2] << 8)) & 0xFFFF;
                    uint num4 = (num ^ (uint)(@struct[2] << 8) ^ (@struct[3].smethod_0() << 5)) & uint_12;
                    uint value = uint_11[66560 + num4];
                    uint_11[num2] = uint_4;
                    uint_11[1024 + num3] = uint_4;
                    uint_11[66560 + num4] = uint_4;
                    struct0_1[uint_8] = value;
                    uint_8++;
                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                    if (++uint_4 == uint_5)
                    {
                        method_18();
                    }
                }
                else
                {
                    method_19();
                }
            }
            while (--uint_22 != 0);
        }
    }

    internal interface Interface1
    {
        void imethod_0(object object_0);

        byte imethod_1(object object_0, int int_0);

        uint imethod_2(object object_0);

        Struct0<byte> imethod_3(object object_0);

        uint imethod_4(object object_0, Struct0<uint> struct0_0);

        void imethod_5(object object_0, uint uint_0);
    }

    private abstract class Class54 : Interface1
    {
        public void imethod_0(object object_0)
        {
            ((Class53)object_0).method_15();
        }

        public byte imethod_1(object object_0, int int_0)
        {
            return ((Class53)object_0).method_6(int_0);
        }

        public uint imethod_2(object object_0)
        {
            return ((Class53)object_0).method_7();
        }

        public Struct0<byte> imethod_3(object object_0)
        {
            return ((Class53)object_0).method_1();
        }

        public abstract uint imethod_4(object object_0, Struct0<uint> struct0_0);

        public abstract void imethod_5(object object_0, uint uint_0);
    }

    private sealed class Class55 : Class54
    {
        public override uint imethod_4(object object_0, Struct0<uint> struct0_0)
        {
            return ((Class53)object_0).method_23(struct0_0);
        }

        public override void imethod_5(object object_0, uint uint_0)
        {
            ((Class53)object_0).method_27(uint_0);
        }
    }

    private sealed class Class56 : Class54
    {
        public override uint imethod_4(object object_0, Struct0<uint> struct0_0)
        {
            return ((Class53)object_0).method_20(struct0_0);
        }

        public override void imethod_5(object object_0, uint uint_0)
        {
            ((Class53)object_0).method_24(uint_0);
        }
    }

    private sealed class Class57 : Class54
    {
        public override uint imethod_4(object object_0, Struct0<uint> struct0_0)
        {
            return ((Class53)object_0).method_21(struct0_0);
        }

        public override void imethod_5(object object_0, uint uint_0)
        {
            ((Class53)object_0).method_25(uint_0);
        }
    }

    private sealed class Class58 : Class54
    {
        public override uint imethod_4(object object_0, Struct0<uint> struct0_0)
        {
            return ((Class53)object_0).method_22(struct0_0);
        }

        public override void imethod_5(object object_0, uint uint_0)
        {
            ((Class53)object_0).method_26(uint_0);
        }
    }

    public sealed class Class59
    {
        private enum Enum1
        {
            const_0,
            const_1,
            const_2,
            const_3,
            const_4,
            const_5,
            const_6,
            const_7,
            const_8,
            const_9
        }

        private static readonly int int_0;

        private static readonly int int_1;

        private static readonly int int_2;

        private static readonly int int_3;

        private static readonly int int_4;

        internal Class64 class64_0 = new();

        internal uint uint_0;

        internal uint uint_1;

        private Enum1 enum1_0;

        private byte byte_0;

        private bool bool_0;

        private bool bool_1;

        private bool bool_2;

        public static Struct21 smethod_0(Struct0<byte> struct0_0, ref long long_0, Struct0<byte> struct0_1, ref long long_1, byte byte_1, Enum3 enum3_0, out Enum4 enum4_0, Class77 class77_0)
        {
            long num = long_0;
            long num2 = long_1;
            long_0 = 0L;
            long_1 = 0L;
            enum4_0 = Enum4.const_0;
            Class59 @class = new();
            @class.method_3();
            Struct21 result;
            if (Struct21.smethod_1(result = @class.method_6(byte_1, class77_0), Struct21_0))
            {
                return result;
            }
            @class.class64_0.struct0_0 = struct0_0;
            @class.class64_0.long_1 = num;
            @class.method_8();
            long_1 = num2;
            result = @class.method_9(num, struct0_1, ref long_1, enum3_0, out enum4_0);
            long_0 = @class.class64_0.long_0;
            if (Struct21.smethod_0(result, Struct21_0) && enum4_0 == Enum4.const_3)
            {
                result = Struct21_6;
            }
            @class.method_4(class77_0);
            return result;
        }

        private bool method_0()
        {
            return (byte_0 & 0x80) == 0;
        }

        private int method_1()
        {
            return (byte_0 >> 5) & 3;
        }

        private static bool smethod_1(int int_5)
        {
            return int_5 >= 2;
        }

        private static uint smethod_2(byte byte_1)
        {
            return (uint)((2 | (byte_1 & 1)) << (byte_1 >> 1) + 11);
        }

        private static Struct21 smethod_3(byte byte_1, Struct0<byte> struct0_0)
        {
            if (byte_1 > 40)
            {
                return Struct21_4;
            }
            uint num = ((byte_1 == 40) ? uint.MaxValue : smethod_2(byte_1));
            struct0_0[0] = 4;
            struct0_0[1] = (byte)num;
            struct0_0[2] = (byte)(num >> 8);
            struct0_0[3] = (byte)(num >> 16);
            struct0_0[4] = (byte)(num >> 24);
            return Struct21_0;
        }

        private Enum1 method_2(byte byte_1)
        {
            switch (enum1_0)
            {
                default:
                    return Enum1.const_9;
                case Enum1.const_0:
                    byte_0 = byte_1;
                    if (byte_0 == 0)
                    {
                        return Enum1.const_8;
                    }
                    if (method_0())
                    {
                        if ((byte_0 & 0x7F) > 2)
                        {
                            return Enum1.const_9;
                        }
                        uint_1 = 0u;
                    }
                    else
                    {
                        uint_1 = (uint)((byte_0 & 0x1F) << 16);
                    }
                    return Enum1.const_1;
                case Enum1.const_1:
                    uint_1 |= (uint)(byte_1 << 8);
                    return Enum1.const_2;
                case Enum1.const_2:
                    uint_1 |= byte_1;
                    uint_1++;
                    if (method_0())
                    {
                        return Enum1.const_6;
                    }
                    return Enum1.const_3;
                case Enum1.const_3:
                    uint_0 = (uint)(byte_1 << 8);
                    return Enum1.const_4;
                case Enum1.const_4:
                    uint_0 |= byte_1;
                    uint_0++;
                    if (smethod_1(method_1()))
                    {
                        return Enum1.const_5;
                    }
                    if (bool_2)
                    {
                        return Enum1.const_9;
                    }
                    return Enum1.const_6;
                case Enum1.const_5:
                    {
                        if (byte_1 >= 225)
                        {
                            return Enum1.const_9;
                        }
                        int num = byte_1 % 9;
                        byte_1 /= 9;
                        class64_0.class63_0.int_3 = byte_1 / 5;
                        int num2 = byte_1 % 5;
                        if (num + num2 > 4)
                        {
                            return Enum1.const_9;
                        }
                        class64_0.class63_0.int_1 = num;
                        class64_0.class63_0.int_2 = num2;
                        bool_2 = false;
                        return Enum1.const_6;
                    }
            }
        }

        private static void smethod_4(Class64 class64_1, Struct0<byte> struct0_0, long long_0)
        {
            Class20.smethod_0(Struct0<byte>.smethod_7(class64_1.struct0_0, class64_1.long_0), struct0_0, long_0);
            class64_1.long_0 += long_0;
            if (class64_1.uint_7 == 0 && class64_1.class63_0.uint_0 - class64_1.uint_6 <= long_0)
            {
                class64_1.uint_7 = class64_1.class63_0.uint_0;
            }
            class64_1.uint_6 += (uint)(int)long_0;
        }

        public void method_3()
        {
            class64_0.method_0();
        }

        public void method_4(Class77 class77_0)
        {
            class64_0.method_3(class77_0);
        }

        public void method_5(Class77 class77_0)
        {
            class64_0.method_5(class77_0);
        }

        public Struct21 method_6(byte byte_1, Class77 class77_0)
        {
            byte[] gparam_ = new byte[5];
            Struct21 result;
            if (Struct21.smethod_1(result = smethod_3(byte_1, Struct0<byte>.smethod_14(gparam_)), Struct21_0))
            {
                return result;
            }
            return class64_0.method_2(Struct0<byte>.smethod_14(gparam_), 5u, class77_0);
        }

        public Struct21 method_7(byte byte_1, Class77 class77_0)
        {
            byte[] gparam_ = new byte[5];
            Struct21 result;
            if (Struct21.smethod_1(result = smethod_3(byte_1, Struct0<byte>.smethod_14(gparam_)), Struct21_0))
            {
                return result;
            }
            return class64_0.method_4(Struct0<byte>.smethod_14(gparam_), 5u, class77_0);
        }

        public void method_8()
        {
            enum1_0 = Enum1.const_0;
            bool_0 = true;
            bool_1 = true;
            bool_2 = true;
            class64_0.method_1();
        }

        public Struct21 method_9(long long_0, Struct0<byte> struct0_0, ref long long_1, Enum3 enum3_0, out Enum4 enum4_0)
        {
            long num = long_1;
            long_1 = 0L;
            enum4_0 = Enum4.const_0;
            while (true)
            {
                if (enum1_0 != Enum1.const_8)
                {
                    long long_2 = class64_0.long_0;
                    if (enum1_0 != Enum1.const_9)
                    {
                        if (long_2 != long_0 || enum3_0 != Enum3.const_0)
                        {
                            if (enum1_0 != Enum1.const_6 && enum1_0 != Enum1.const_7)
                            {
                                if (long_1 != num)
                                {
                                    long_1++;
                                    enum1_0 = method_2(struct0_0[0]);
                                    struct0_0 = Struct0<byte>.smethod_12(struct0_0);
                                    continue;
                                }
                                enum4_0 = Enum4.const_3;
                                return Struct21_0;
                            }
                            long num2 = long_0 - long_2;
                            long long_3 = num - long_1;
                            Enum3 enum3_1 = Enum3.const_0;
                            if (uint_1 <= num2)
                            {
                                num2 = uint_1;
                                enum3_1 = Enum3.const_1;
                            }
                            if (method_0())
                            {
                                if (long_1 != num)
                                {
                                    if (enum1_0 == Enum1.const_6)
                                    {
                                        bool flag;
                                        if (flag = byte_0 == 1)
                                        {
                                            bool_1 = true;
                                            bool_2 = true;
                                        }
                                        else if (bool_0)
                                        {
                                            return Struct21_1;
                                        }
                                        bool_0 = false;
                                        class64_0.method_8(flag, bool_3: false);
                                    }
                                    if (long_3 > num2)
                                    {
                                        long_3 = num2;
                                    }
                                    if (long_3 != 0L)
                                    {
                                        smethod_4(class64_0, struct0_0, long_3);
                                        struct0_0 = Struct0<byte>.smethod_7(struct0_0, long_3);
                                        long_1 += long_3;
                                        uint_1 -= (uint)(int)long_3;
                                        enum1_0 = ((uint_1 != 0) ? Enum1.const_7 : Enum1.const_0);
                                        continue;
                                    }
                                    return Struct21_1;
                                }
                                enum4_0 = Enum4.const_3;
                                return Struct21_0;
                            }
                            if (enum1_0 == Enum1.const_6)
                            {
                                int num3 = method_1();
                                bool flag2 = num3 == 3;
                                bool flag3 = num3 > 0;
                                if ((!flag2 && bool_0) || (!flag3 && bool_1))
                                {
                                    return Struct21_1;
                                }
                                class64_0.method_8(flag2, flag3);
                                bool_0 = false;
                                bool_1 = false;
                                enum1_0 = Enum1.const_7;
                            }
                            if (long_3 > uint_0)
                            {
                                long_3 = uint_0;
                            }
                            Struct21 @struct = class64_0.method_6(long_2 + num2, struct0_0, ref long_3, enum3_1, out enum4_0);
                            struct0_0 = Struct0<byte>.smethod_7(struct0_0, long_3);
                            long_1 += long_3;
                            uint_0 -= (uint)(int)long_3;
                            long num4 = class64_0.long_0 - long_2;
                            uint_1 -= (uint)(int)num4;
                            if (!Struct21.smethod_1(@struct, Struct21_0))
                            {
                                if (enum4_0 != Enum4.const_3)
                                {
                                    if (long_3 == 0L && num4 == 0L)
                                    {
                                        if (enum4_0 != Enum4.const_4 || uint_1 != 0 || uint_0 != 0)
                                        {
                                            break;
                                        }
                                        enum1_0 = Enum1.const_0;
                                    }
                                    if (enum4_0 == Enum4.const_4)
                                    {
                                        enum4_0 = Enum4.const_2;
                                    }
                                    continue;
                                }
                                return @struct;
                            }
                            return @struct;
                        }
                        enum4_0 = Enum4.const_2;
                        return Struct21_0;
                    }
                    return Struct21_1;
                }
                enum4_0 = Enum4.const_1;
                return Struct21_0;
            }
            return Struct21_1;
        }

        public Struct21 method_10(Struct0<byte> struct0_0, ref long long_0, Struct0<byte> struct0_1, ref long long_1, Enum3 enum3_0, out Enum4 enum4_0)
        {
            long num = long_0;
            long num2 = long_1;
            long_1 = 0L;
            long_0 = 0L;
            long long_3;
            do
            {
                if (class64_0.long_0 == class64_0.long_1)
                {
                    class64_0.long_0 = 0L;
                }
                long long_2 = class64_0.long_0;
                Enum3 enum3_1;
                if (num > class64_0.long_1 - long_2)
                {
                    long_3 = class64_0.long_1;
                    enum3_1 = Enum3.const_0;
                }
                else
                {
                    long_3 = long_2 + num;
                    enum3_1 = enum3_0;
                }
                long long_4 = num2;
                Struct21 @struct = method_9(long_3, struct0_1, ref long_4, enum3_1, out enum4_0);
                struct0_1 = Struct0<byte>.smethod_7(struct0_1, long_4);
                num2 -= long_4;
                long_1 += long_4;
                long_3 = class64_0.long_0 - long_2;
                Class20.smethod_0(struct0_0, Struct0<byte>.smethod_7(class64_0.struct0_0, long_2), long_3);
                struct0_0 = Struct0<byte>.smethod_7(struct0_0, long_3);
                num -= long_3;
                long_0 += long_3;
                if (Struct21.smethod_3(@struct, 0))
                {
                    return @struct;
                }
            }
            while (long_3 != 0L && num != 0L);
            return Struct21_0;
        }
    }

    public sealed class Class60
    {
        public Class67 class67_0;

        public long long_0;

        public int int_0;

        public int int_1;

        public Class60()
        {
        }

        public Class60(Class60 class60_0)
        {
            class67_0 = new Class67(class60_0.class67_0);
            long_0 = class60_0.long_0;
            int_0 = class60_0.int_0;
            int_1 = class60_0.int_1;
        }

        public void method_0()
        {
            class67_0 = Class67.smethod_0();
            int_1 = 1;
            int_0 = 1;
            long_0 = 0L;
        }

        public void method_1()
        {
            new Class67(class67_0).method_0();
            class67_0.int_8 = 1;
            int_0 = 1;
            int_1 = 1;
            class67_0.method_0();
            if (long_0 == 0L)
            {
                uint uint_ = class67_0.uint_0;
                long num = (long)((ulong)uint_ << 2);
                if (num < 1048576L)
                {
                    num = 1048576L;
                }
                if (num > 268435456L)
                {
                    num = 268435456L;
                }
                if (num < uint_)
                {
                    num = uint_;
                }
                long_0 = num;
            }
        }
    }

    internal sealed class Class61
    {
        private static readonly int int_0;

        private static readonly int int_1;

        private static readonly int int_2;

        private static readonly int int_3;

        private static readonly int int_4;

        private static readonly int int_5;

        private static readonly int int_6;

        internal static int int_7;

        private static readonly int int_8;

        internal Class73 class73_0;

        internal ulong ulong_0;

        internal byte byte_0;

        internal bool bool_0;

        internal bool bool_1;

        internal Struct21 method_0(Class60 class60_0)
        {
            byte[] array = new byte[5];
            long long_ = 5L;
            Struct21 result;
            if (Struct21.smethod_1(result = class73_0.method_7(class60_0.class67_0), Struct21_0))
            {
                return result;
            }
            if (Struct21.smethod_1(result = class73_0.method_8(Struct0<byte>.smethod_14(array), ref long_), Struct21_0))
            {
                return result;
            }
            ulong_0 = 0uL;
            byte_0 = array[0];
            bool_0 = true;
            bool_1 = true;
            return Struct21_0;
        }

        internal Struct21 method_1(Struct0<byte> struct0_0, ref long long_0, Interface3 interface3_0)
        {
            long num = long_0;
            long num2 = num;
            uint uint_ = 2097152u;
            uint num3 = (uint)(5 + (bool_1 ? 1 : 0));
            long_0 = 0L;
            if (num2 < num3)
            {
                return Struct21_7;
            }
            num2 -= num3;
            class73_0.method_11();
            Struct21 @struct = class73_0.method_33(bool_0, Struct0<byte>.smethod_10(struct0_0, num3), ref num2, 65536u, ref uint_);
            if (uint_ == 0)
            {
                return @struct;
            }
            bool flag;
            if (Struct21.smethod_0(@struct, Struct21_0))
            {
                flag = num2 + 2L >= uint_ || num2 > 65536L;
            }
            else
            {
                if (Struct21.smethod_1(@struct, Struct21_7))
                {
                    return @struct;
                }
                _ = Struct21_0;
                flag = true;
            }
            if (flag)
            {
                long num4 = 0L;
                while (true)
                {
                    if (uint_ != 0)
                    {
                        uint num5 = ((uint_ < 65536) ? uint_ : 65536u);
                        if (num - num4 >= num5 + 3)
                        {
                            struct0_0[num4++] = (byte)((ulong_0 == 0L) ? 1u : 2u);
                            struct0_0[num4++] = (byte)(num5 - 1 >> 8);
                            struct0_0[num4++] = (byte)(num5 - 1);
                            Class20.smethod_0(Struct0<byte>.smethod_7(struct0_0, num4), Struct0<byte>.smethod_9(class73_0.method_32(), uint_), num5);
                            uint_ -= num5;
                            num4 += num5;
                            ulong_0 += num5;
                            if (interface3_0 != null)
                            {
                                long_0 += num4;
                                if (interface3_0.imethod_0(struct0_0, num4) != num4)
                                {
                                    break;
                                }
                                num4 = 0L;
                            }
                            else
                            {
                                long_0 = num4;
                            }
                            continue;
                        }
                        return Struct21_7;
                    }
                    class73_0.method_12();
                    return Struct21_0;
                }
                return Struct21_9;
            }
            long num6 = 0L;
            uint num7 = uint_ - 1;
            uint num8 = (uint)(num2 - 1L);
            uint num9 = ((ulong_0 == 0L) ? 3u : (bool_0 ? ((!bool_1) ? 1u : 2u) : 0u));
            struct0_0[num6++] = (byte)(0x80 | (num9 << 5) | ((num7 >> 16) & 0x1F));
            struct0_0[num6++] = (byte)(num7 >> 8);
            struct0_0[num6++] = (byte)num7;
            struct0_0[num6++] = (byte)(num8 >> 8);
            struct0_0[num6++] = (byte)num8;
            if (bool_1)
            {
                struct0_0[num6++] = byte_0;
            }
            bool_1 = false;
            bool_0 = false;
            num6 += num2;
            ulong_0 += uint_;
            if (interface3_0 != null && interface3_0.imethod_0(struct0_0, num6) != num6)
            {
                return Struct21_9;
            }
            long_0 = num6;
            return Struct21_0;
        }

        private static Struct21 smethod_0(Interface4 interface4_0, ulong ulong_1, ulong ulong_2)
        {
            if (interface4_0 != null && Struct21.smethod_1(interface4_0.imethod_0(ulong_1, ulong_2), Struct21_0))
            {
                return Struct21_10;
            }
            return Struct21_0;
        }

        internal Struct21 method_2(Class62 class62_0, Interface3 interface3_0, Interface2 interface2_0, Interface4 interface4_0)
        {
            ulong num = 0uL;
            _ = Struct21_0;
            if (class62_0.byte_0 == null)
            {
                class62_0.byte_0 = smethod_7(class62_0.class77_0, 65552L);
                if (class62_0.byte_0 == null)
                {
                    return Struct21_2;
                }
            }
            Struct21 result;
            if (Struct21.smethod_1(result = method_0(class62_0.class60_0), Struct21_0))
            {
                return result;
            }
            if (Struct21.smethod_1(result = class73_0.method_28(interface2_0, 2097152u, class62_0.class77_0, class62_0.class77_1), Struct21_0))
            {
                return result;
            }
            long long_;
            do
            {
                long_ = 65552L;
                result = method_1(Struct0<byte>.smethod_14(class62_0.byte_0), ref long_, interface3_0);
                if (Struct21.smethod_1(result, Struct21_0))
                {
                    break;
                }
                num += (ulong)long_;
                result = smethod_0(interface4_0, ulong_0, num);
            }
            while (!Struct21.smethod_1(result, Struct21_0) && long_ != 0L);
            class73_0.method_30();
            if (Struct21.smethod_0(result, Struct21_0) && interface3_0.imethod_0(Struct0<byte>.smethod_14(new byte[1]), 1L) != 1L)
            {
                return Struct21_9;
            }
            return result;
        }
    }

    public sealed class Class62
    {
        private static readonly int int_0;

        internal Class60 class60_0 = new();

        internal byte[] byte_0;

        internal Class77 class77_0;

        internal Class77 class77_1;

        internal Class61 class61_0;

        public Class62(Class77 class77_2, Class77 class77_3)
        {
            class60_0.method_0();
            class60_0.method_1();
            byte_0 = null;
            class77_0 = class77_2;
            class77_1 = class77_3;
            class61_0 = new Class61();
        }

        public void method_0()
        {
            Class61 @class = class61_0;
            if (@class.class73_0 != null)
            {
                @class.class73_0.method_6(class77_0, class77_1);
                @class.class73_0 = null;
            }
            smethod_10(class77_0, byte_0);
            smethod_9(class77_0, this);
        }

        public Struct21 method_1(Class60 class60_1)
        {
            Class67 @class = new(class60_1.class67_0);
            @class.method_0();
            if (@class.int_1 + @class.int_2 > 4)
            {
                return Struct21_5;
            }
            class60_0 = new Class60(class60_1);
            class60_0.method_1();
            return Struct21_0;
        }

        private static uint smethod_0(int int_1)
        {
            return (uint)((2 | (int_1 & 1)) << int_1 / 2 + 11);
        }

        public byte method_2()
        {
            uint num = class60_0.class67_0.method_1();
            int i;
            for (i = 0; i < 40 && num > smethod_0(i); i++)
            {
            }
            return (byte)i;
        }

        public Struct21 method_3(Interface3 interface3_0, Interface2 interface2_0, Interface4 interface4_0)
        {
            class61_0.class73_0 = smethod_3(class77_0);
            if (class61_0.class73_0 == null)
            {
                return Struct21_2;
            }
            return class61_0.method_2(this, interface3_0, interface2_0, interface4_0);
        }
    }

    public sealed class Class63
    {
        private static readonly int int_0;

        public int int_1;

        public int int_2;

        public int int_3;

        public uint uint_0;

        public Class63()
        {
        }

        public Class63(Class63 class63_0)
        {
            int_1 = class63_0.int_1;
            int_2 = class63_0.int_2;
            int_3 = class63_0.int_3;
            uint_0 = class63_0.uint_0;
        }

        public Struct21 method_0(Struct0<byte> struct0_0, uint uint_1)
        {
            if (uint_1 < 5)
            {
                return Struct21_4;
            }
            uint num = (uint)(struct0_0[1] | (struct0_0[2] << 8) | (struct0_0[3] << 16) | (struct0_0[4] << 24));
            if (num < 4096)
            {
                num = 4096u;
            }
            uint_0 = num;
            byte b = struct0_0[0];
            if (b >= 225)
            {
                return Struct21_4;
            }
            int_1 = b % 9;
            b /= 9;
            int_3 = b / 5;
            int_2 = b % 5;
            return Struct21_0;
        }
    }

    public sealed class Class64
    {
        private enum Enum2
        {
            const_0,
            const_1,
            const_2,
            const_3
        }

        [CompilerGenerated]
        private sealed class Class65
        {
            public uint uint_0;
        }

        [CompilerGenerated]
        private sealed class Class66
        {
            public uint uint_0;

            public Class65 class65_0;

            internal void method_0()
            {
                class65_0.uint_0 &= ~uint_0;
            }

            internal void method_1()
            {
                class65_0.uint_0 &= uint_0;
            }
        }

        private static readonly int int_0;

        private static readonly uint uint_0;

        private static readonly int int_1;

        private static readonly int int_2;

        private static readonly int int_3;

        private static readonly int int_4;

        private static readonly int int_5;

        private static readonly int int_6;

        private static readonly int int_7;

        private static readonly int int_8;

        private static readonly int int_9;

        private static readonly int int_10;

        private static readonly int int_11;

        private static readonly int int_12;

        private static readonly int int_13;

        private static readonly int int_14;

        private static readonly int int_15;

        private static readonly int int_16;

        private static readonly int int_17;

        private static readonly int int_18;

        private static readonly int int_19;

        private static readonly uint uint_1;

        private static readonly int int_20;

        private static readonly int int_21;

        private static readonly int int_22;

        private static readonly int int_23;

        private static readonly int int_24;

        private static readonly int int_25;

        private static readonly int int_26;

        private static readonly int int_27;

        private static readonly int int_28;

        private static readonly int int_29;

        private static readonly int int_30;

        private static readonly int int_31;

        private static readonly int int_32;

        private static readonly int int_33;

        private static readonly int int_34;

        private static readonly int int_35;

        private static readonly int int_36;

        private static readonly int int_37;

        private static readonly int int_38;

        private static readonly int int_39;

        private static readonly int int_40;

        private static readonly uint uint_2;

        private static readonly uint uint_3;

        internal Class63 class63_0 = new();

        internal ushort[] ushort_0;

        internal Struct0<byte> struct0_0;

        internal Struct0<byte> struct0_1;

        internal uint uint_4;

        internal uint uint_5;

        internal long long_0;

        internal long long_1;

        internal uint uint_6;

        internal uint uint_7;

        internal uint uint_8;

        internal uint[] uint_9 = new uint[4];

        internal uint uint_10;

        internal bool bool_0;

        internal bool bool_1;

        internal uint uint_11;

        internal uint uint_12;

        internal byte[] byte_0 = new byte[20];

        public void method_0()
        {
            struct0_0 = Struct0<byte>.smethod_14(null);
            ushort_0 = null;
        }

        public void method_1()
        {
            long_0 = 0L;
            method_8(bool_2: true, bool_3: true);
        }

        public Struct21 method_2(Struct0<byte> struct0_2, uint uint_13, Class77 class77_0)
        {
            Class63 @class = new();
            Struct21 result;
            if (Struct21.smethod_1(result = @class.method_0(struct0_2, uint_13), Struct21_0))
            {
                return result;
            }
            if (Struct21.smethod_1(result = method_16(@class, class77_0), Struct21_0))
            {
                return result;
            }
            class63_0 = new Class63(@class);
            return Struct21_0;
        }

        public void method_3(Class77 class77_0)
        {
            class77_0.method_7(class77_0, ushort_0);
            ushort_0 = null;
        }

        public Struct21 method_4(Struct0<byte> struct0_2, uint uint_13, Class77 class77_0)
        {
            Class63 @class = new();
            Struct21 result;
            if (Struct21.smethod_1(result = @class.method_0(struct0_2, uint_13), Struct21_0))
            {
                return result;
            }
            if (Struct21.smethod_1(result = method_16(@class, class77_0), Struct21_0))
            {
                return result;
            }
            long num = @class.uint_0;
            if (Struct0<byte>.smethod_15(struct0_0, Struct0<byte>.smethod_14(null)) || num != long_1)
            {
                method_15(class77_0);
                struct0_0 = Struct0<byte>.smethod_14(class77_0.method_2(class77_0, num));
                if (Struct0<byte>.smethod_15(struct0_0, Struct0<byte>.smethod_14(null)))
                {
                    method_3(class77_0);
                    return Struct21_2;
                }
            }
            long_1 = num;
            class63_0 = new Class63(@class);
            return Struct21_0;
        }

        public void method_5(Class77 class77_0)
        {
            method_3(class77_0);
            method_15(class77_0);
        }

        public Struct21 method_6(long long_2, Struct0<byte> struct0_2, ref long long_3, Enum3 enum3_0, out Enum4 enum4_0)
        {
            long num = long_3;
            long_3 = 0L;
            method_10(long_2);
            enum4_0 = Enum4.const_0;
            while (true)
            {
                if (uint_10 != 274)
                {
                    if (bool_0)
                    {
                        while (num > 0L && uint_12 < 5)
                        {
                            byte_0[uint_12] = struct0_2[0];
                            uint_12++;
                            struct0_2 = Struct0<byte>.smethod_12(struct0_2);
                            long_3++;
                            num--;
                        }
                        if (uint_12 < 5)
                        {
                            enum4_0 = Enum4.const_3;
                            return Struct21_0;
                        }
                        if (byte_0[0] != 0)
                        {
                            return Struct21_1;
                        }
                        method_13(Struct0<byte>.smethod_14(byte_0));
                        uint_12 = 0u;
                    }
                    bool flag = false;
                    if (long_0 >= long_2)
                    {
                        if (uint_10 == 0 && uint_5 == 0)
                        {
                            enum4_0 = Enum4.const_4;
                            return Struct21_0;
                        }
                        if (enum3_0 == Enum3.const_0)
                        {
                            enum4_0 = Enum4.const_2;
                            return Struct21_0;
                        }
                        if (uint_10 != 0)
                        {
                            enum4_0 = Enum4.const_2;
                            return Struct21_1;
                        }
                        flag = true;
                    }
                    if (bool_1)
                    {
                        method_14();
                    }
                    if (uint_12 == 0)
                    {
                        Struct0<byte> struct0_3;
                        if (num < 20L || flag)
                        {
                            Enum2 @enum = method_12(struct0_2, num);
                            if (@enum == Enum2.const_0)
                            {
                                Class20.smethod_0(Struct0<byte>.smethod_14(byte_0), struct0_2, num);
                                uint_12 = (uint)num;
                                long_3 += num;
                                enum4_0 = Enum4.const_3;
                                return Struct21_0;
                            }
                            if (flag && @enum != Enum2.const_2)
                            {
                                enum4_0 = Enum4.const_2;
                                return Struct21_1;
                            }
                            struct0_3 = struct0_2;
                        }
                        else
                        {
                            struct0_3 = Struct0<byte>.smethod_5(Struct0<byte>.smethod_7(struct0_2, num), 20);
                        }
                        struct0_1 = struct0_2;
                        if (!Struct21.smethod_3(method_11(long_2, struct0_3), 0))
                        {
                            long num2 = Struct0<byte>.smethod_4(struct0_1, struct0_2);
                            long_3 += num2;
                            struct0_2 = Struct0<byte>.smethod_7(struct0_2, num2);
                            num -= num2;
                            continue;
                        }
                        return Struct21_1;
                    }
                    uint num3 = uint_12;
                    uint num4 = 0u;
                    while (num3 < 20 && num4 < num)
                    {
                        byte_0[num3++] = struct0_2[num4++];
                    }
                    uint_12 = num3;
                    if (num3 < 20 || flag)
                    {
                        Enum2 enum2 = method_12(Struct0<byte>.smethod_14(byte_0), num3);
                        if (enum2 == Enum2.const_0)
                        {
                            long_3 += num4;
                            enum4_0 = Enum4.const_3;
                            return Struct21_0;
                        }
                        if (flag && enum2 != Enum2.const_2)
                        {
                            enum4_0 = Enum4.const_2;
                            return Struct21_1;
                        }
                    }
                    struct0_1 = Struct0<byte>.smethod_14(byte_0);
                    if (Struct21.smethod_3(method_11(long_2, struct0_1), 0))
                    {
                        break;
                    }
                    num4 -= (uint)((int)num3 - Struct0<byte>.smethod_4(struct0_1, Struct0<byte>.smethod_14(byte_0)));
                    long_3 += num4;
                    struct0_2 = Struct0<byte>.smethod_10(struct0_2, num4);
                    num -= num4;
                    uint_12 = 0u;
                    continue;
                }
                if (uint_5 != 0)
                {
                    return Struct21_1;
                }
                enum4_0 = Enum4.const_1;
                return Struct21_0;
            }
            return Struct21_1;
        }

        public Struct21 method_7(Struct0<byte> struct0_2, ref long long_2, Struct0<byte> struct0_3, ref long long_3, Enum3 enum3_0, out Enum4 enum4_0)
        {
            long num = long_2;
            long num2 = long_3;
            long_2 = 0L;
            long_3 = 0L;
            long long_5;
            do
            {
                long long_4 = num2;
                if (long_0 == long_1)
                {
                    long_0 = 0L;
                }
                long num3 = long_0;
                Enum3 enum3_1;
                if (num > long_1 - num3)
                {
                    long_5 = long_1;
                    enum3_1 = Enum3.const_0;
                }
                else
                {
                    long_5 = num3 + num;
                    enum3_1 = enum3_0;
                }
                Struct21 @struct = method_6(long_5, struct0_3, ref long_4, enum3_1, out enum4_0);
                struct0_3 = Struct0<byte>.smethod_7(struct0_3, long_4);
                num2 -= long_4;
                long_3 += long_4;
                long_5 = long_0 - num3;
                Class20.smethod_0(struct0_2, Struct0<byte>.smethod_7(struct0_0, num3), long_5);
                struct0_2 = Struct0<byte>.smethod_7(struct0_2, long_5);
                num -= long_5;
                long_2 += long_5;
                if (Struct21.smethod_1(@struct, Struct21_0))
                {
                    return @struct;
                }
            }
            while (long_5 != 0L && num != 0L);
            return Struct21_0;
        }

        public static Struct21 smethod_0(Struct0<byte> struct0_2, ref long long_2, Struct0<byte> struct0_3, ref long long_3, Struct0<byte> struct0_4, uint uint_13, Enum3 enum3_0, out Enum4 enum4_0, Class77 class77_0)
        {
            long long_4 = long_2;
            long num = long_3;
            long_2 = 0L;
            long_3 = 0L;
            enum4_0 = Enum4.const_0;
            if (num < 5L)
            {
                return Struct21_6;
            }
            Class64 @class = new();
            @class.method_0();
            Struct21 result;
            if (Struct21.smethod_1(result = @class.method_2(struct0_4, uint_13, class77_0), Struct21_0))
            {
                return result;
            }
            @class.struct0_0 = struct0_2;
            @class.long_1 = long_4;
            @class.method_1();
            long_3 = num;
            result = @class.method_6(long_4, struct0_3, ref long_3, enum3_0, out enum4_0);
            long_2 = @class.long_0;
            if (Struct21.smethod_0(result, Struct21_0) && enum4_0 == Enum4.const_3)
            {
                result = Struct21_6;
            }
            @class.method_3(class77_0);
            return result;
        }

        internal void method_8(bool bool_2, bool bool_3)
        {
            bool_0 = true;
            uint_10 = 0u;
            uint_12 = 0u;
            if (bool_2)
            {
                uint_6 = 0u;
                uint_7 = 0u;
                bool_1 = true;
            }
            if (bool_3)
            {
                bool_1 = true;
            }
        }

        private Struct21 method_9(long long_2, Struct0<byte> struct0_2)
        {
            Struct0<ushort> @struct = Struct0<ushort>.smethod_14(ushort_0);
            uint num = this.uint_8;
            uint num2 = this.uint_9[0];
            uint num3 = this.uint_9[1];
            uint num4 = this.uint_9[2];
            uint num5 = this.uint_9[3];
            uint num6 = (uint)((1 << class63_0.int_3) - 1);
            uint num7 = (uint)((1 << class63_0.int_2) - 1);
            int num8 = class63_0.int_1;
            Struct0<byte> struct2 = struct0_0;
            long num9 = long_1;
            long num10 = long_0;
            uint num11 = this.uint_6;
            uint num12 = this.uint_7;
            uint uint_ = 0u;
            Struct0<byte> struct0_3 = struct0_1;
            uint uint_2 = this.uint_4;
            uint uint_3 = this.uint_5;
            do
            {
                uint num13 = num11 & num6;
                Struct0<ushort> struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 0), num << 4), num13);
                if (!smethod_2(struct0_4, out var uint_4, out var uint_5, ref uint_2, ref uint_3, ref struct0_3))
                {
                    smethod_4(struct0_4, uint_4, uint_5, ref uint_2, ref uint_3);
                    struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 192), num);
                    if (smethod_2(struct0_4, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                    {
                        smethod_3(struct0_4, uint_4, uint_5, ref uint_2);
                        num += 12;
                        struct0_4 = Struct0<ushort>.smethod_6(@struct, 818);
                    }
                    else
                    {
                        smethod_4(struct0_4, uint_4, uint_5, ref uint_2, ref uint_3);
                        if (num12 == 0 && num11 == 0)
                        {
                            return Struct21_1;
                        }
                        struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 204), num);
                        if (smethod_2(struct0_4, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                        {
                            smethod_3(struct0_4, uint_4, uint_5, ref uint_2);
                            struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 240), num << 4), num13);
                            if (smethod_2(struct0_4, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                            {
                                smethod_3(struct0_4, uint_4, uint_5, ref uint_2);
                                struct2[num10] = struct2[num10 - num2 + ((num10 < num2) ? num9 : 0L)];
                                num10++;
                                num11++;
                                num = ((num < 7) ? 9u : 11u);
                                continue;
                            }
                            smethod_4(struct0_4, uint_4, uint_5, ref uint_2, ref uint_3);
                        }
                        else
                        {
                            smethod_4(struct0_4, uint_4, uint_5, ref uint_2, ref uint_3);
                            struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 216), num);
                            uint num14;
                            if (smethod_2(struct0_4, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                            {
                                smethod_3(struct0_4, uint_4, uint_5, ref uint_2);
                                num14 = num3;
                            }
                            else
                            {
                                smethod_4(struct0_4, uint_4, uint_5, ref uint_2, ref uint_3);
                                struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 228), num);
                                if (smethod_2(struct0_4, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                                {
                                    smethod_3(struct0_4, uint_4, uint_5, ref uint_2);
                                    num14 = num4;
                                }
                                else
                                {
                                    smethod_4(struct0_4, uint_4, uint_5, ref uint_2, ref uint_3);
                                    num14 = num5;
                                    num5 = num4;
                                }
                                num4 = num3;
                            }
                            num3 = num2;
                            num2 = num14;
                        }
                        num = ((num < 7) ? 8u : 11u);
                        struct0_4 = Struct0<ushort>.smethod_6(@struct, 1332);
                    }
                    Struct0<ushort> struct0_5 = Struct0<ushort>.smethod_6(struct0_4, 0);
                    uint num15;
                    uint uint_6;
                    if (smethod_2(struct0_5, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                    {
                        smethod_3(struct0_5, uint_4, uint_5, ref uint_2);
                        struct0_5 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct0_4, 2), num13 << 3);
                        num15 = 0u;
                        uint_6 = 8u;
                    }
                    else
                    {
                        smethod_4(struct0_5, uint_4, uint_5, ref uint_2, ref uint_3);
                        struct0_5 = Struct0<ushort>.smethod_6(struct0_4, 1);
                        if (smethod_2(struct0_5, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                        {
                            smethod_3(struct0_5, uint_4, uint_5, ref uint_2);
                            struct0_5 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct0_4, 130), num13 << 3);
                            num15 = 8u;
                            uint_6 = 8u;
                        }
                        else
                        {
                            smethod_4(struct0_5, uint_4, uint_5, ref uint_2, ref uint_3);
                            struct0_5 = Struct0<ushort>.smethod_6(struct0_4, 258);
                            num15 = 16u;
                            uint_6 = 256u;
                        }
                    }
                    smethod_8(struct0_5, uint_6, out uint_, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3);
                    uint_ += num15;
                    if (num >= 12)
                    {
                        struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 432), ((uint_ < 4) ? uint_ : 3) << 6);
                        smethod_9(struct0_4, out var uint_7, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3);
                        if (uint_7 >= 4)
                        {
                            uint num16 = uint_7;
                            int num17 = (int)((uint_7 >> 1) - 1);
                            uint_7 = 2 | (uint_7 & 1);
                            if (num16 < 14)
                            {
                                uint_7 <<= num17;
                                struct0_4 = Struct0<ushort>.smethod_5(Struct0<ushort>.smethod_9(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(@struct, 688), uint_7), num16), 1);
                                uint num18 = 1u;
                                uint uint_8 = 1u;
                                do
                                {
                                    if (smethod_5(Struct0<ushort>.smethod_10(struct0_4, uint_8), ref uint_8, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                                    {
                                        uint_7 |= num18;
                                    }
                                    num18 <<= 1;
                                }
                                while (--num17 != 0);
                            }
                            else
                            {
                                num17 -= 4;
                                do
                                {
                                    smethod_1(ref uint_2, ref uint_3, ref struct0_3);
                                    uint_2 >>= 1;
                                    uint_3 -= uint_2;
                                    uint num19 = 0 - (uint_3 >> 31);
                                    uint_7 = (uint_7 << 1) + (num19 + 1);
                                    uint_3 += uint_2 & num19;
                                }
                                while (--num17 != 0);
                                struct0_4 = Struct0<ushort>.smethod_6(@struct, 802);
                                uint_7 <<= 4;
                                uint uint_9 = 1u;
                                if (smethod_5(Struct0<ushort>.smethod_10(struct0_4, 1u), ref uint_9, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                                {
                                    uint_7 |= 1;
                                }
                                if (smethod_5(Struct0<ushort>.smethod_10(struct0_4, uint_9), ref uint_9, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                                {
                                    uint_7 |= 2;
                                }
                                if (smethod_5(Struct0<ushort>.smethod_10(struct0_4, uint_9), ref uint_9, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                                {
                                    uint_7 |= 4;
                                }
                                if (smethod_5(Struct0<ushort>.smethod_10(struct0_4, uint_9), ref uint_9, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3))
                                {
                                    uint_7 |= 8;
                                }
                                if (uint_7 == uint.MaxValue)
                                {
                                    uint_ += 274;
                                    num -= 12;
                                    break;
                                }
                            }
                        }
                        num5 = num4;
                        num4 = num3;
                        num3 = num2;
                        num2 = uint_7 + 1;
                        if (num12 == 0)
                        {
                            if (uint_7 >= num11)
                            {
                                return Struct21_1;
                            }
                        }
                        else if (uint_7 >= num12)
                        {
                            return Struct21_1;
                        }
                        num = ((num < 19) ? 7u : 10u);
                    }
                    uint_ += 2;
                    if (long_2 != num10)
                    {
                        long num20 = long_2 - num10;
                        uint num21 = (uint)((num20 < uint_) ? num20 : uint_);
                        long num22 = num10 - num2 + ((num10 < num2) ? num9 : 0L);
                        num11 += num21;
                        uint_ -= num21;
                        if (num22 + num21 <= num9)
                        {
                            Struct0<byte> struct3 = Struct0<byte>.smethod_7(struct2, num10);
                            long num23 = num22 - num10;
                            Struct0<byte> struct4 = Struct0<byte>.smethod_10(struct3, num21);
                            num10 += num21;
                            do
                            {
                                struct3[0] = struct3[num23];
                            }
                            while (Struct0<byte>.smethod_16(struct3 = Struct0<byte>.smethod_12(struct3), struct4));
                            continue;
                        }
                        do
                        {
                            struct2[num10++] = struct2[num22];
                            if (++num22 == num9)
                            {
                                num22 = 0L;
                            }
                        }
                        while (--num21 != 0);
                        continue;
                    }
                    return Struct21_1;
                }
                smethod_3(struct0_4, uint_4, uint_5, ref uint_2);
                struct0_4 = Struct0<ushort>.smethod_6(@struct, 1846);
                if (num12 != 0 || num11 != 0)
                {
                    struct0_4 = Struct0<ushort>.smethod_7(struct0_4, 768L * (((num11 & num7) << num8) + (struct2[((num10 == 0L) ? num9 : num10) - 1L] >> 8 - num8)));
                }
                uint uint_10;
                if (num < 7)
                {
                    num -= ((num < 4) ? num : 3);
                    uint_10 = 1u;
                    do
                    {
                        smethod_6(Struct0<ushort>.smethod_10(struct0_4, uint_10), ref uint_10, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3);
                    }
                    while (uint_10 < 256);
                }
                else
                {
                    uint num24 = struct0_0[num10 - num2 + ((num10 < num2) ? num9 : 0L)];
                    uint num25 = 256u;
                    num -= (uint)((num < 10) ? 3 : 6);
                    uint_10 = 1u;
                    do
                    {
                        num24 <<= 1;
                        uint num26 = num24 & num25;
                        num25 = (smethod_5(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(struct0_4, num25), num26), uint_10), ref uint_10, out uint_4, out uint_5, ref uint_2, ref uint_3, ref struct0_3) ? (num25 & num26) : (num25 & ~num26));
                    }
                    while (uint_10 < 256);
                }
                struct2[num10++] = (byte)uint_10;
                num11++;
            }
            while (num10 < long_2 && Struct0<byte>.smethod_0(struct0_3, struct0_2));
            smethod_1(ref uint_2, ref uint_3, ref struct0_3);
            struct0_1 = struct0_3;
            this.uint_4 = uint_2;
            this.uint_5 = uint_3;
            this.uint_10 = uint_;
            long_0 = num10;
            this.uint_6 = num11;
            this.uint_9[0] = num2;
            this.uint_9[1] = num3;
            this.uint_9[2] = num4;
            this.uint_9[3] = num5;
            this.uint_8 = num;
            return Struct21_0;
        }

        private void method_10(long long_2)
        {
            if (uint_10 != 0 && uint_10 < 274)
            {
                Struct0<byte> @struct = struct0_0;
                long num = long_0;
                long num2 = long_1;
                uint num3 = uint_10;
                uint num4 = uint_9[0];
                if (long_2 - num < num3)
                {
                    num3 = (uint)(long_2 - num);
                }
                if (uint_7 == 0 && class63_0.uint_0 - uint_6 <= num3)
                {
                    uint_7 = class63_0.uint_0;
                }
                uint_6 += num3;
                uint_10 -= num3;
                while (num3 != 0)
                {
                    num3--;
                    @struct[num] = @struct[num - num4 + ((num < num4) ? num2 : 0L)];
                    num++;
                }
                long_0 = num;
            }
        }

        private Struct21 method_11(long long_2, Struct0<byte> struct0_2)
        {
            do
            {
                long long_3 = long_2;
                if (uint_7 == 0)
                {
                    uint num = class63_0.uint_0 - uint_6;
                    if (long_2 - long_0 > num)
                    {
                        long_3 = long_0 + num;
                    }
                }
                Struct21 result;
                if (!Struct21.smethod_1(result = method_9(long_3, struct0_2), Struct21_0))
                {
                    if (uint_6 >= class63_0.uint_0)
                    {
                        uint_7 = class63_0.uint_0;
                    }
                    method_10(long_2);
                    continue;
                }
                return result;
            }
            while (long_0 < long_2 && Struct0<byte>.smethod_0(struct0_1, struct0_2) && uint_10 < 274);
            if (uint_10 > 274)
            {
                uint_10 = 274u;
            }
            return Struct21_0;
        }

        private Enum2 method_12(Struct0<byte> struct0_2, long long_2)
        {
            uint uint_ = this.uint_4;
            uint uint_2 = this.uint_5;
            Struct0<byte> @struct = Struct0<byte>.smethod_7(struct0_2, long_2);
            Struct0<ushort> struct2 = Struct0<ushort>.smethod_14(ushort_0);
            uint num = this.uint_8;
            uint num2 = this.uint_6 & (uint)((1 << class63_0.int_3) - 1);
            Struct0<ushort> struct0_3 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 0), num << 4), num2);
            if (!smethod_11(out var bool_, struct0_3, out var uint_3, out var uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
            {
                return Enum2.const_0;
            }
            Enum2 result;
            if (bool_)
            {
                smethod_12(uint_4, ref uint_);
                struct0_3 = Struct0<ushort>.smethod_6(struct2, 1846);
                if (this.uint_7 != 0 || this.uint_6 != 0)
                {
                    struct0_3 = Struct0<ushort>.smethod_7(struct0_3, 768L * (((this.uint_6 & ((1 << class63_0.int_2) - 1)) << class63_0.int_1) + (struct0_0[((long_0 == 0L) ? long_1 : long_0) - 1L] >> 8 - class63_0.int_1)));
                }
                if (num < 7)
                {
                    uint uint_5 = 1u;
                    do
                    {
                        if (!smethod_15(Struct0<ushort>.smethod_10(struct0_3, uint_5), ref uint_5, out uint_3, ref uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                        {
                            return Enum2.const_0;
                        }
                    }
                    while (uint_5 < 256);
                }
                else
                {
                    uint num3 = struct0_0[long_0 - this.uint_9[0] + ((long_0 < this.uint_9[0]) ? long_1 : 0L)];
                    uint uint_6 = 256u;
                    uint uint_7 = 1u;
                    do
                    {
                        num3 <<= 1;
                        uint uint_8 = num3 & uint_6;
                        if (!smethod_14(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(struct0_3, uint_6), uint_8), uint_7), ref uint_7, delegate
                        {
                            uint_6 &= ~uint_8;
                        }, delegate
                        {
                            uint_6 &= uint_8;
                        }, out uint_3, ref uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                        {
                            return Enum2.const_0;
                        }
                    }
                    while (uint_7 < 256);
                }
                result = Enum2.const_1;
            }
            else
            {
                smethod_13(uint_4, ref uint_, ref uint_2);
                struct0_3 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 192), num);
                if (!smethod_11(out bool_, struct0_3, out uint_3, out uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                {
                    return Enum2.const_0;
                }
                if (bool_)
                {
                    smethod_12(uint_4, ref uint_);
                    num = 0u;
                    struct0_3 = Struct0<ushort>.smethod_6(struct2, 818);
                    result = Enum2.const_2;
                }
                else
                {
                    smethod_13(uint_4, ref uint_, ref uint_2);
                    result = Enum2.const_3;
                    struct0_3 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 204), num);
                    if (!smethod_11(out bool_, struct0_3, out uint_3, out uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                    {
                        return Enum2.const_0;
                    }
                    if (bool_)
                    {
                        smethod_12(uint_4, ref uint_);
                        struct0_3 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 240), num << 4), num2);
                        if (!smethod_11(out bool_, struct0_3, out uint_3, out uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                        {
                            return Enum2.const_0;
                        }
                        if (bool_)
                        {
                            smethod_12(uint_4, ref uint_);
                            if (!smethod_10(ref uint_, ref uint_2, ref struct0_2, @struct))
                            {
                                return Enum2.const_0;
                            }
                            return Enum2.const_3;
                        }
                        smethod_13(uint_4, ref uint_, ref uint_2);
                    }
                    else
                    {
                        smethod_13(uint_4, ref uint_, ref uint_2);
                        struct0_3 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 216), num);
                        if (!smethod_11(out bool_, struct0_3, out uint_3, out uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                        {
                            return Enum2.const_0;
                        }
                        if (bool_)
                        {
                            smethod_12(uint_4, ref uint_);
                        }
                        else
                        {
                            smethod_13(uint_4, ref uint_, ref uint_2);
                            struct0_3 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 228), num);
                            if (!smethod_11(out bool_, struct0_3, out uint_3, out uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                            {
                                return Enum2.const_0;
                            }
                            if (bool_)
                            {
                                smethod_12(uint_4, ref uint_);
                            }
                            else
                            {
                                smethod_13(uint_4, ref uint_, ref uint_2);
                            }
                        }
                    }
                    num = 12u;
                    struct0_3 = Struct0<ushort>.smethod_6(struct2, 1332);
                }
                Struct0<ushort> struct0_4 = Struct0<ushort>.smethod_6(struct0_3, 0);
                if (!smethod_11(out bool_, struct0_4, out uint_3, out uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                {
                    return Enum2.const_0;
                }
                uint num4;
                uint uint_9;
                if (bool_)
                {
                    smethod_12(uint_4, ref uint_);
                    struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct0_3, 2), num2 << 3);
                    num4 = 0u;
                    uint_9 = 8u;
                }
                else
                {
                    smethod_13(uint_4, ref uint_, ref uint_2);
                    struct0_4 = Struct0<ushort>.smethod_6(struct0_3, 1);
                    if (!smethod_11(out bool_, struct0_4, out uint_3, out uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                    {
                        return Enum2.const_0;
                    }
                    if (bool_)
                    {
                        smethod_12(uint_4, ref uint_);
                        struct0_4 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct0_3, 130), num2 << 3);
                        num4 = 8u;
                        uint_9 = 8u;
                    }
                    else
                    {
                        smethod_13(uint_4, ref uint_, ref uint_2);
                        struct0_4 = Struct0<ushort>.smethod_6(struct0_3, 258);
                        num4 = 16u;
                        uint_9 = 256u;
                    }
                }
                if (!smethod_16(struct0_4, uint_9, out var uint_10, out uint_3, ref uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                {
                    return Enum2.const_0;
                }
                uint_10 += num4;
                if (num < 4)
                {
                    struct0_3 = Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 432), ((uint_10 < 4) ? uint_10 : 3) << 6);
                    if (!smethod_16(struct0_3, 64u, out var uint_11, out uint_3, ref uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                    {
                        return Enum2.const_0;
                    }
                    if (uint_11 >= 4)
                    {
                        int num5 = ((int)uint_11 >> 1) - 1;
                        if (uint_11 < 14)
                        {
                            struct0_3 = Struct0<ushort>.smethod_5(Struct0<ushort>.smethod_9(Struct0<ushort>.smethod_10(Struct0<ushort>.smethod_6(struct2, 688), (2 | (uint_11 & 1)) << num5), uint_11), 1);
                        }
                        else
                        {
                            num5 -= 4;
                            do
                            {
                                if (smethod_10(ref uint_, ref uint_2, ref struct0_2, @struct))
                                {
                                    uint_ >>= 1;
                                    if (uint_2 >= uint_)
                                    {
                                        uint_2 -= uint_;
                                    }
                                    continue;
                                }
                                return Enum2.const_0;
                            }
                            while (--num5 != 0);
                            struct0_3 = Struct0<ushort>.smethod_6(struct2, 802);
                            num5 = 4;
                        }
                        uint uint_12 = 1u;
                        do
                        {
                            if (!smethod_15(Struct0<ushort>.smethod_10(struct0_3, uint_12), ref uint_12, out uint_3, ref uint_4, ref uint_, ref uint_2, ref struct0_2, @struct))
                            {
                                return Enum2.const_0;
                            }
                        }
                        while (--num5 != 0);
                    }
                }
            }
            if (!smethod_10(ref uint_, ref uint_2, ref struct0_2, @struct))
            {
                return Enum2.const_0;
            }
            return result;
        }

        private void method_13(Struct0<byte> struct0_2)
        {
            uint_5 = (uint)((struct0_2[1] << 24) | (struct0_2[2] << 16) | (struct0_2[3] << 8) | struct0_2[4]);
            uint_4 = uint.MaxValue;
            bool_0 = false;
        }

        private void method_14()
        {
            uint num = (uint)(1846 + (768 << class63_0.int_1 + class63_0.int_2));
            for (uint num2 = 0u; num2 < num; num2++)
            {
                ushort_0[num2] = 1024;
            }
            uint_9[0] = 1u;
            uint_9[1] = 1u;
            uint_9[2] = 1u;
            uint_9[3] = 1u;
            uint_8 = 0u;
            bool_1 = false;
        }

        private void method_15(Class77 class77_0)
        {
            class77_0.method_6(class77_0, struct0_0.gparam_0);
            struct0_0 = Struct0<byte>.smethod_14(null);
        }

        private Struct21 method_16(Class63 class63_1, Class77 class77_0)
        {
            uint num = smethod_17(class63_1);
            if (ushort_0 == null || num != uint_11)
            {
                method_3(class77_0);
                ushort_0 = class77_0.method_3(class77_0, num);
                uint_11 = num;
                if (ushort_0 == null)
                {
                    return Struct21_2;
                }
            }
            return Struct21_0;
        }

        private static void smethod_1(ref uint uint_13, ref uint uint_14, ref Struct0<byte> struct0_2)
        {
            if (uint_13 < 16777216)
            {
                uint_13 <<= 8;
                uint_14 = (uint_14 << 8) | struct0_2[0];
                struct0_2 = Struct0<byte>.smethod_12(struct0_2);
            }
        }

        private static bool smethod_2(Struct0<ushort> struct0_2, out uint uint_13, out uint uint_14, ref uint uint_15, ref uint uint_16, ref Struct0<byte> struct0_3)
        {
            uint_13 = struct0_2[0];
            smethod_1(ref uint_15, ref uint_16, ref struct0_3);
            uint_14 = (uint_15 >> 11) * uint_13;
            return uint_16 < uint_14;
        }

        private static void smethod_3(Struct0<ushort> struct0_2, uint uint_13, uint uint_14, ref uint uint_15)
        {
            uint_15 = uint_14;
            struct0_2[0] = (ushort)(uint_13 + (2048 - uint_13 >> 5));
        }

        private static void smethod_4(Struct0<ushort> struct0_2, uint uint_13, uint uint_14, ref uint uint_15, ref uint uint_16)
        {
            uint_15 -= uint_14;
            uint_16 -= uint_14;
            struct0_2[0] = (ushort)(uint_13 - (uint_13 >> 5));
        }

        private static bool smethod_5(Struct0<ushort> struct0_2, ref uint uint_13, out uint uint_14, out uint uint_15, ref uint uint_16, ref uint uint_17, ref Struct0<byte> struct0_3)
        {
            if (smethod_2(struct0_2, out uint_14, out uint_15, ref uint_16, ref uint_17, ref struct0_3))
            {
                smethod_3(struct0_2, uint_14, uint_15, ref uint_16);
                uint_13 += uint_13;
                return false;
            }
            smethod_4(struct0_2, uint_14, uint_15, ref uint_16, ref uint_17);
            uint_13 = uint_13 + uint_13 + 1;
            return true;
        }

        private static void smethod_6(Struct0<ushort> struct0_2, ref uint uint_13, out uint uint_14, out uint uint_15, ref uint uint_16, ref uint uint_17, ref Struct0<byte> struct0_3)
        {
            smethod_5(struct0_2, ref uint_13, out uint_14, out uint_15, ref uint_16, ref uint_17, ref struct0_3);
        }

        private static void smethod_7(Struct0<ushort> struct0_2, ref uint uint_13, out uint uint_14, out uint uint_15, ref uint uint_16, ref uint uint_17, ref Struct0<byte> struct0_3)
        {
            smethod_6(Struct0<ushort>.smethod_10(struct0_2, uint_13), ref uint_13, out uint_14, out uint_15, ref uint_16, ref uint_17, ref struct0_3);
        }

        private static void smethod_8(Struct0<ushort> struct0_2, uint uint_13, out uint uint_14, out uint uint_15, out uint uint_16, ref uint uint_17, ref uint uint_18, ref Struct0<byte> struct0_3)
        {
            uint_14 = 1u;
            do
            {
                smethod_7(struct0_2, ref uint_14, out uint_15, out uint_16, ref uint_17, ref uint_18, ref struct0_3);
            }
            while (uint_14 < uint_13);
            uint_14 -= uint_13;
        }

        private static void smethod_9(Struct0<ushort> struct0_2, out uint uint_13, out uint uint_14, out uint uint_15, ref uint uint_16, ref uint uint_17, ref Struct0<byte> struct0_3)
        {
            smethod_8(struct0_2, 64u, out uint_13, out uint_14, out uint_15, ref uint_16, ref uint_17, ref struct0_3);
        }

        private static bool smethod_10(ref uint uint_13, ref uint uint_14, ref Struct0<byte> struct0_2, Struct0<byte> struct0_3)
        {
            if (uint_13 < 16777216)
            {
                if (Struct0<byte>.smethod_3(struct0_2, struct0_3))
                {
                    return false;
                }
                uint_13 <<= 8;
                uint_14 = (uint_14 << 8) | struct0_2[0];
                struct0_2 = Struct0<byte>.smethod_12(struct0_2);
            }
            return true;
        }

        private static bool smethod_11(out bool bool_2, Struct0<ushort> struct0_2, out uint uint_13, out uint uint_14, ref uint uint_15, ref uint uint_16, ref Struct0<byte> struct0_3, Struct0<byte> struct0_4)
        {
            uint_13 = struct0_2[0];
            if (!smethod_10(ref uint_15, ref uint_16, ref struct0_3, struct0_4))
            {
                bool_2 = false;
                uint_14 = 0u;
                return false;
            }
            uint_14 = (uint_15 >> 11) * uint_13;
            bool_2 = uint_16 < uint_14;
            return true;
        }

        private static void smethod_12(uint uint_13, ref uint uint_14)
        {
            uint_14 = uint_13;
        }

        private static void smethod_13(uint uint_13, ref uint uint_14, ref uint uint_15)
        {
            uint_14 -= uint_13;
            uint_15 -= uint_13;
        }

        private static bool smethod_14(Struct0<ushort> struct0_2, ref uint uint_13, Action action_0, Action action_1, out uint uint_14, ref uint uint_15, ref uint uint_16, ref uint uint_17, ref Struct0<byte> struct0_3, Struct0<byte> struct0_4)
        {
            if (!smethod_11(out var bool_, struct0_2, out uint_14, out uint_15, ref uint_16, ref uint_17, ref struct0_3, struct0_4))
            {
                return false;
            }
            if (bool_)
            {
                smethod_12(uint_15, ref uint_16);
                uint_13 += uint_13;
                action_0();
            }
            else
            {
                smethod_13(uint_15, ref uint_16, ref uint_17);
                uint_13 = uint_13 + uint_13 + 1;
                action_1();
            }
            return true;
        }

        private static bool smethod_15(Struct0<ushort> struct0_2, ref uint uint_13, out uint uint_14, ref uint uint_15, ref uint uint_16, ref uint uint_17, ref Struct0<byte> struct0_3, Struct0<byte> struct0_4)
        {
            return smethod_14(struct0_2, ref uint_13, delegate
            {
            }, delegate
            {
            }, out uint_14, ref uint_15, ref uint_16, ref uint_17, ref struct0_3, struct0_4);
        }

        private static bool smethod_16(Struct0<ushort> struct0_2, uint uint_13, out uint uint_14, out uint uint_15, ref uint uint_16, ref uint uint_17, ref uint uint_18, ref Struct0<byte> struct0_3, Struct0<byte> struct0_4)
        {
            uint_14 = 1u;
            do
            {
                if (!smethod_15(Struct0<ushort>.smethod_10(struct0_2, uint_14), ref uint_14, out uint_15, ref uint_16, ref uint_17, ref uint_18, ref struct0_3, struct0_4))
                {
                    return false;
                }
            }
            while (uint_14 < uint_13);
            uint_14 -= uint_13;
            return true;
        }

        private static uint smethod_17(Class63 class63_1)
        {
            return (uint)(1846 + (768 << class63_1.int_1 + class63_1.int_2));
        }
    }

    public enum Enum3
    {
        const_0,
        const_1
    }

    public enum Enum4
    {
        const_0,
        const_1,
        const_2,
        const_3,
        const_4
    }

    public sealed class Class67
    {
        public int int_0;

        public uint uint_0;

        public uint uint_1;

        public int int_1;

        public int int_2;

        public int int_3;

        public int int_4;

        public int int_5;

        public int int_6;

        public int int_7;

        public uint uint_2;

        public uint uint_3;

        public int int_8;

        private Class67()
        {
            int_0 = 5;
            uint_0 = 0u;
            uint_2 = 0u;
            uint_1 = uint.MaxValue;
            int_1 = -1;
            int_2 = -1;
            int_3 = -1;
            int_4 = -1;
            int_5 = -1;
            int_6 = -1;
            int_7 = -1;
            int_8 = -1;
            uint_3 = 0u;
        }

        public Class67(Class67 class67_0)
        {
            int_0 = class67_0.int_0;
            uint_0 = class67_0.uint_0;
            uint_1 = class67_0.uint_1;
            int_1 = class67_0.int_1;
            int_2 = class67_0.int_2;
            int_3 = class67_0.int_3;
            int_4 = class67_0.int_4;
            int_5 = class67_0.int_5;
            int_6 = class67_0.int_6;
            int_7 = class67_0.int_7;
            uint_2 = class67_0.uint_2;
            uint_3 = class67_0.uint_3;
            int_8 = class67_0.int_8;
        }

        public static Class67 smethod_0()
        {
            return new Class67();
        }

        public void method_0()
        {
            int num = int_0;
            if (num < 0)
            {
                num = 5;
            }
            int_0 = num;
            if (uint_0 == 0)
            {
                if (num <= 5)
                {
                    uint_0 = (uint)(1 << num * 2 + 14);
                }
                else if (num == 6)
                {
                    uint_0 = 33554432u;
                }
                else
                {
                    uint_0 = 67108864u;
                }
            }
            if (uint_0 > uint_1)
            {
                for (int i = 15; i <= 30; i++)
                {
                    if (uint_1 > (uint)(2 << i))
                    {
                        if (uint_1 <= (uint)(3 << i))
                        {
                            uint_0 = (uint)(3 << i);
                            break;
                        }
                        continue;
                    }
                    uint_0 = (uint)(2 << i);
                    break;
                }
            }
            if (int_1 < 0)
            {
                int_1 = 3;
            }
            if (int_2 < 0)
            {
                int_2 = 0;
            }
            if (int_3 < 0)
            {
                int_3 = 2;
            }
            if (int_4 < 0)
            {
                int_4 = ((num >= 5) ? 1 : 0);
            }
            if (int_5 < 0)
            {
                int_5 = ((num < 7) ? 32 : 64);
            }
            if (int_6 < 0)
            {
                int_6 = ((int_4 != 0) ? 1 : 0);
            }
            if (int_7 < 0)
            {
                int_7 = 4;
            }
            if (uint_2 == 0)
            {
                uint_2 = (uint)(16 + (int_5 >>> 1)) >> ((int_6 == 0) ? 1 : 0);
            }
            if (int_8 < 0)
            {
                int_8 = ((int_6 == 0 || int_4 == 0) ? 1 : 2);
            }
        }

        internal uint method_1()
        {
            Class67 @class = new(this);
            @class.method_0();
            return @class.uint_0;
        }
    }

    internal struct Struct20
    {
        public uint uint_0;

        public uint uint_1;

        public uint uint_2;

        public uint uint_3;

        public uint this[uint uint_4]
        {
            readonly get
            {
                return uint_4 switch
                {
                    0u => uint_0,
                    1u => uint_1,
                    2u => uint_2,
                    3u => uint_3,
                    _ => throw new InvalidOperationException(),
                };
            }
            set
            {
                switch (uint_4)
                {
                    default:
                        throw new InvalidOperationException();
                    case 0u:
                        uint_0 = value;
                        break;
                    case 1u:
                        uint_1 = value;
                        break;
                    case 2u:
                        uint_2 = value;
                        break;
                    case 3u:
                        uint_3 = value;
                        break;
                }
            }
        }
    }

    internal sealed class Class68
    {
        internal uint uint_0;

        internal uint uint_1;

        internal bool bool_0;

        internal bool bool_1;

        internal uint uint_2;

        internal uint uint_3;

        internal uint uint_4;

        internal uint uint_5;

        internal Struct20 struct20_0;

        internal void method_0()
        {
            uint_5 = uint.MaxValue;
            bool_0 = false;
        }

        internal void method_1()
        {
            uint_5 = 0u;
            bool_0 = false;
        }

        internal bool method_2()
        {
            return uint_5 == 0;
        }
    }

    internal class Class69
    {
        public ushort ushort_0;

        public ushort ushort_1;

        public ushort[] ushort_2 = new ushort[128];

        public ushort[] ushort_3 = new ushort[128];

        public ushort[] ushort_4 = new ushort[256];

        public Class69()
        {
        }

        public Class69(Class69 class69_0)
        {
            ushort_0 = class69_0.ushort_0;
            ushort_1 = class69_0.ushort_1;
            for (int i = 0; i < ushort_2.Length; i++)
            {
                ushort_2[i] = class69_0.ushort_2[i];
            }
            for (int j = 0; j < ushort_3.Length; j++)
            {
                ushort_3[j] = class69_0.ushort_3[j];
            }
            for (int k = 0; k < ushort_4.Length; k++)
            {
                ushort_4[k] = class69_0.ushort_4[k];
            }
        }

        internal void method_0()
        {
            ushort_0 = 1024;
            ushort_1 = 1024;
            for (uint num = 0u; num < 128; num++)
            {
                ushort_2[num] = 1024;
            }
            for (uint num2 = 0u; num2 < 128; num2++)
            {
                ushort_3[num2] = 1024;
            }
            for (uint num3 = 0u; num3 < 256; num3++)
            {
                ushort_4[num3] = 1024;
            }
        }

        internal void method_1(Class71 class71_0, uint uint_0, uint uint_1)
        {
            if (uint_0 < 8)
            {
                class71_0.method_10(ref ushort_0, 0u);
                Class73.smethod_10(class71_0, Class15.smethod_1(ushort_2, uint_1 << 3), 3, uint_0);
                return;
            }
            class71_0.method_10(ref ushort_0, 1u);
            if (uint_0 < 16)
            {
                class71_0.method_10(ref ushort_1, 0u);
                Class73.smethod_10(class71_0, Class15.smethod_1(ushort_3, uint_1 << 3), 3, uint_0 - 8);
            }
            else
            {
                class71_0.method_10(ref ushort_1, 1u);
                Class73.smethod_10(class71_0, Struct0<ushort>.smethod_14(ushort_4), 8, uint_0 - 8 - 8);
            }
        }

        internal void method_2(uint uint_0, uint uint_1, Struct0<uint> struct0_0, Struct0<uint> struct0_1)
        {
            uint num = Class73.smethod_6(struct0_1, ushort_0);
            uint num2 = Class73.smethod_7(struct0_1, ushort_0);
            uint num3 = num2 + Class73.smethod_6(struct0_1, ushort_1);
            uint num4 = num2 + Class73.smethod_7(struct0_1, ushort_1);
            uint num5 = 0u;
            while (true)
            {
                if (num5 < 8)
                {
                    if (num5 < uint_1)
                    {
                        struct0_0[num5] = num + Class73.smethod_12(Class15.smethod_1(ushort_2, uint_0 << 3), 3, num5, struct0_1);
                        num5++;
                        continue;
                    }
                    break;
                }
                while (true)
                {
                    if (num5 < 16)
                    {
                        if (num5 < uint_1)
                        {
                            struct0_0[num5] = num3 + Class73.smethod_12(Class15.smethod_1(ushort_3, uint_0 << 3), 3, num5 - 8, struct0_1);
                            num5++;
                            continue;
                        }
                        break;
                    }
                    for (; num5 < uint_1; num5++)
                    {
                        struct0_0[num5] = num4 + Class73.smethod_12(Struct0<ushort>.smethod_14(ushort_4), 8, num5 - 16, struct0_1);
                    }
                    break;
                }
                break;
            }
        }
    }

    internal sealed class Class70 : Class69
    {
        internal uint[][] uint_0;

        internal uint uint_1;

        internal uint[] uint_2;

        internal Class70()
        {
            uint_0 = new uint[16][];
            for (int i = 0; i < uint_0.Length; i++)
            {
                uint_0[i] = new uint[272];
            }
            uint_2 = new uint[16];
        }

        internal Class70(Class70 class70_0)
            : base(class70_0)
        {
            uint_0 = new uint[16][];
            for (int i = 0; i < uint_0.Length; i++)
            {
                uint_0[i] = new uint[272];
                for (int j = 0; j < 272; j++)
                {
                    uint_0[i][j] = class70_0.uint_0[i][j];
                }
            }
            uint_1 = class70_0.uint_1;
            uint_2 = new uint[16];
            for (int k = 0; k < uint_2.Length; k++)
            {
                uint_2[k] = class70_0.uint_2[k];
            }
        }

        private void method_3(uint uint_3, Struct0<uint> struct0_0)
        {
            method_2(uint_3, uint_1, Struct0<uint>.smethod_14(uint_0[uint_3]), struct0_0);
            uint_2[uint_3] = uint_1;
        }

        internal void method_4(uint uint_3, Struct0<uint> struct0_0)
        {
            for (uint num = 0u; num < uint_3; num++)
            {
                method_3(num, struct0_0);
            }
        }

        internal void method_5(Class71 class71_0, uint uint_3, uint uint_4, bool bool_0, Struct0<uint> struct0_0)
        {
            method_1(class71_0, uint_3, uint_4);
            if (bool_0 && --uint_2[uint_4] == 0)
            {
                method_3(uint_4, struct0_0);
            }
        }
    }

    internal sealed class Class71
    {
        private static readonly int int_0;

        public uint uint_0;

        public byte byte_0;

        public ulong ulong_0;

        public ulong ulong_1;

        public Struct0<byte> struct0_0;

        public Struct0<byte> struct0_1;

        public Struct0<byte> struct0_2;

        public Interface3 interface3_0;

        public ulong ulong_2;

        public Struct21 struct21_0;

        internal void method_0()
        {
            interface3_0 = null;
            struct0_2 = Struct0<byte>.smethod_14(null);
        }

        internal ulong method_1()
        {
            return ulong_2 + (uint)Struct0<byte>.smethod_4(struct0_0, struct0_2) + ulong_1;
        }

        internal bool method_2(Class77 class77_0)
        {
            if (Struct0<byte>.smethod_15(struct0_2, Struct0<byte>.smethod_14(null)))
            {
                struct0_2 = Struct0<byte>.smethod_14(class77_0.method_2(class77_0, 65536L));
                if (Struct0<byte>.smethod_15(struct0_2, Struct0<byte>.smethod_14(null)))
                {
                    return false;
                }
                struct0_1 = Struct0<byte>.smethod_6(struct0_2, 65536);
            }
            return true;
        }

        internal void method_3(Class77 class77_0)
        {
            class77_0.method_6(class77_0, struct0_2.gparam_0);
            struct0_2 = Struct0<byte>.smethod_14(null);
        }

        internal void method_4()
        {
            ulong_0 = 0uL;
            uint_0 = uint.MaxValue;
            ulong_1 = 1uL;
            byte_0 = 0;
            struct0_0 = struct0_2;
            ulong_2 = 0uL;
            struct21_0 = Struct21_0;
        }

        internal void method_5()
        {
            if (!Struct21.smethod_1(struct21_0, Struct21_0))
            {
                long num = Struct0<byte>.smethod_4(struct0_0, struct0_2);
                if (num != interface3_0.imethod_0(struct0_2, num))
                {
                    struct21_0 = Struct21_9;
                }
                ulong_2 += (ulong)num;
                struct0_0 = struct0_2;
            }
        }

        internal void method_6()
        {
            if ((uint)ulong_0 < 4278190080u || (uint)(ulong_0 >> 32) != 0)
            {
                byte b = byte_0;
                do
                {
                    Struct0<byte> @struct = struct0_0;
                    @struct[0] = (byte)(b + (byte)(ulong_0 >> 32));
                    if (Struct0<byte>.smethod_15(struct0_0 = Struct0<byte>.smethod_12(@struct), struct0_1))
                    {
                        method_5();
                    }
                    b = byte.MaxValue;
                }
                while (--ulong_1 != 0L);
                byte_0 = (byte)((uint)ulong_0 >> 24);
            }
            ulong_1++;
            ulong_0 = (uint)((int)ulong_0 << 8);
        }

        internal void method_7()
        {
            for (int i = 0; i < 5; i++)
            {
                method_6();
            }
        }

        internal void method_8(uint uint_1, int int_1)
        {
            do
            {
                uint_0 >>= 1;
                ulong_0 += uint_0 & (0 - ((uint_1 >> --int_1) & 1));
                if (uint_0 < 16777216)
                {
                    uint_0 <<= 8;
                    method_6();
                }
            }
            while (int_1 != 0);
        }

        internal void method_9(Struct0<ushort> struct0_3, uint uint_1)
        {
            method_10(ref struct0_3.gparam_0[struct0_3.int_0], uint_1);
        }

        internal void method_10(ref ushort ushort_0, uint uint_1)
        {
            uint num = ushort_0;
            uint num2 = (uint_0 >> 11) * num;
            if (uint_1 == 0)
            {
                uint_0 = num2;
                num += 2048 - num >> 5;
            }
            else
            {
                ulong_0 += num2;
                uint_0 -= num2;
                num -= num >> 5;
            }
            ushort_0 = (ushort)num;
            if (uint_0 < 16777216)
            {
                uint_0 <<= 8;
                method_6();
            }
        }
    }

    internal sealed class Class72
    {
        public ushort[] ushort_0;

        public ushort[][] ushort_1 = Class20.smethod_4<ushort>(12, 16);

        public ushort[] ushort_2 = new ushort[12];

        public ushort[] ushort_3 = new ushort[12];

        public ushort[] ushort_4 = new ushort[12];

        public ushort[] ushort_5 = new ushort[12];

        public ushort[][] ushort_6 = Class20.smethod_4<ushort>(12, 16);

        public ushort[][] ushort_7 = Class20.smethod_4<ushort>(4, 64);

        public ushort[] ushort_8 = new ushort[114];

        public ushort[] ushort_9 = new ushort[16];

        public Class70 class70_0 = new();

        public Class70 class70_1 = new();

        public Struct20 struct20_0;

        public uint uint_0;
    }

    public sealed class Class73
    {
        private sealed class Class74 : Interface3
        {
            public Struct0<byte> struct0_0;

            public long long_0;

            public bool bool_0;

            public long imethod_0(Struct0<byte> struct0_1, long long_1)
            {
                if (long_0 < long_1)
                {
                    long_1 = long_0;
                    bool_0 = true;
                }
                Class20.smethod_0(struct0_0, struct0_1, long_1);
                long_0 -= long_1;
                struct0_0 = Struct0<byte>.smethod_7(struct0_0, long_1);
                return long_1;
            }
        }

        private static readonly int int_0;

        private static readonly int int_1;

        private static readonly int int_2;

        private static readonly int int_3;

        private static readonly int int_4;

        private static readonly int int_5;

        internal static uint uint_0;

        internal static int int_6;

        internal static int int_7;

        internal static int int_8;

        internal static int int_9;

        private static readonly int int_10;

        private static readonly int int_11;

        private static readonly int int_12;

        private static readonly int int_13;

        private static readonly int int_14;

        internal static int int_15;

        private static readonly int int_16;

        internal static int int_17;

        internal static int int_18;

        private static readonly int int_19;

        private static readonly int int_20;

        private static readonly int int_21;

        internal static int int_22;

        private static readonly int int_23;

        private static readonly int int_24;

        private static readonly int int_25;

        internal static int int_26;

        private static readonly int int_27;

        internal static int int_28;

        private static readonly int int_29;

        private static readonly int int_30;

        private static readonly int int_31;

        internal static int int_32;

        internal static int int_33;

        internal static int int_34;

        internal static int int_35;

        internal static int int_36;

        internal static int int_37;

        internal static int int_38;

        internal static int int_39;

        private static readonly int int_40;

        private static readonly int int_41;

        internal static int int_42;

        private static readonly uint[] uint_1 =
        [
            0u, 0u, 0u, 0u, 1u, 2u, 3u, 4u, 5u, 6u,
            4u, 5u
        ];

        private static readonly uint[] uint_2 =
        [
            7u, 7u, 7u, 7u, 7u, 7u, 7u, 10u, 10u, 10u,
            10u, 10u
        ];

        private static readonly uint[] uint_3 =
        [
            8u, 8u, 8u, 8u, 8u, 8u, 8u, 11u, 11u, 11u,
            11u, 11u
        ];

        private static readonly uint[] uint_4 =
        [
            9u, 9u, 9u, 9u, 9u, 9u, 9u, 11u, 11u, 11u,
            11u, 11u
        ];

        private static readonly int int_43;

        internal Interface1 interface1_0;

        internal object object_0;

        internal Class53 class53_0;

        internal uint uint_5;

        internal uint uint_6;

        internal uint uint_7;

        internal uint uint_8;

        internal uint uint_9;

        internal Class68[] class68_0 = Class20.smethod_3(4096, () => new Class68());

        internal byte[] byte_0 = new byte[8192];

        internal uint[] uint_10 = new uint[128];

        internal uint[] uint_11 = new uint[549];

        internal uint uint_12;

        internal uint uint_13;

        internal Struct20 struct20_0;

        internal uint uint_14;

        internal uint[][] uint_15 = Class20.smethod_4<uint>(4, 64);

        internal uint[][] uint_16 = Class20.smethod_4<uint>(4, 128);

        internal uint[] uint_17 = new uint[16];

        internal uint uint_18;

        internal uint uint_19;

        internal int int_44;

        internal int int_45;

        internal int int_46;

        internal uint uint_20;

        internal uint uint_21;

        internal ushort[] ushort_0;

        internal ushort[][] ushort_1 = Class20.smethod_4<ushort>(12, 16);

        internal ushort[] ushort_2 = new ushort[12];

        internal ushort[] ushort_3 = new ushort[12];

        internal ushort[] ushort_4 = new ushort[12];

        internal ushort[] ushort_5 = new ushort[12];

        internal ushort[][] ushort_6 = Class20.smethod_4<ushort>(12, 16);

        internal ushort[][] ushort_7 = Class20.smethod_4<ushort>(4, 64);

        internal ushort[] ushort_8 = new ushort[114];

        internal ushort[] ushort_9 = new ushort[16];

        internal Class70 class70_0 = new();

        internal Class70 class70_1 = new();

        internal int int_47;

        internal bool bool_0;

        internal Class71 class71_0 = new();

        internal bool bool_1;

        internal ulong ulong_0;

        internal uint uint_22;

        internal bool bool_2;

        internal bool bool_3;

        internal Struct21 struct21_0;

        internal uint uint_23;

        internal bool bool_4;

        internal Class72 class72_0 = new();

        private static readonly uint uint_24;

        internal Class73()
        {
            class71_0.method_0();
            class53_0 = new Class53();
            method_7(Class67.smethod_0());
            method_0();
            smethod_4(Struct0<uint>.smethod_14(uint_10));
            ushort_0 = null;
            class72_0.ushort_0 = null;
        }

        internal void method_0()
        {
            byte_0[0] = 0;
            byte_0[1] = 1;
            int num = 2;
            for (int i = 2; i < 26; i++)
            {
                int num2 = 1 << (i >> 1) - 1;
                for (int j = 0; j < num2; j++)
                {
                    byte_0[num++] = (byte)i;
                }
            }
        }

        private uint method_1(uint uint_25)
        {
            uint num = 6 + (0xC & (0 - (524287 - uint_25 >> 31)));
            return byte_0[uint_25 >> (int)num] + num * 2;
        }

        private byte method_2(uint uint_25)
        {
            return byte_0[uint_25];
        }

        private uint method_3(uint uint_25)
        {
            return method_1(uint_25);
        }

        private uint method_4(uint uint_25)
        {
            if (uint_25 < 128)
            {
                return byte_0[uint_25];
            }
            return method_1(uint_25);
        }

        private static bool smethod_0(uint uint_25)
        {
            return uint_25 < 7;
        }

        private static uint smethod_1(uint uint_25)
        {
            if (uint_25 >= 5)
            {
                return 3u;
            }
            return uint_25 - 2;
        }

        private static void smethod_2(Class71 class71_1, Struct0<ushort> struct0_0, uint uint_25)
        {
            uint_25 |= 0x100;
            do
            {
                class71_1.method_9(Struct0<ushort>.smethod_10(struct0_0, uint_25 >> 8), (uint_25 >> 7) & 1);
                uint_25 <<= 1;
            }
            while (uint_25 < 65536);
        }

        private static void smethod_3(Class71 class71_1, Struct0<ushort> struct0_0, uint uint_25, uint uint_26)
        {
            uint num = 256u;
            uint_25 |= 0x100;
            do
            {
                uint_26 <<= 1;
                class71_1.method_9(Struct0<ushort>.smethod_10(struct0_0, num + (uint_26 & num) + (uint_25 >> 8)), (uint_25 >> 7) & 1);
                uint_25 <<= 1;
                num &= ~(uint_26 ^ uint_25);
            }
            while (uint_25 < 65536);
        }

        internal static void smethod_4(Struct0<uint> struct0_0)
        {
            for (uint num = 8u; num < 2048; num += 16)
            {
                uint num2 = num;
                uint num3 = 0u;
                for (int i = 0; i < 4; i++)
                {
                    num2 *= num2;
                    num3 <<= 1;
                    while (num2 >= 65536)
                    {
                        num2 >>= 1;
                        num3++;
                    }
                }
                struct0_0[num >> 4] = 161 - num3;
            }
        }

        internal static uint smethod_5(Struct0<uint> struct0_0, ushort ushort_10, uint uint_25)
        {
            return struct0_0[(int)(ushort_10 ^ ((0 - uint_25) & 0x7FF)) >> 4];
        }

        internal static uint smethod_6(Struct0<uint> struct0_0, ushort ushort_10)
        {
            return struct0_0[ushort_10 >> 4];
        }

        internal static uint smethod_7(Struct0<uint> struct0_0, ushort ushort_10)
        {
            return struct0_0[(ushort_10 ^ 0x7FF) >> 4];
        }

        private static uint smethod_8(Struct0<ushort> struct0_0, uint uint_25, Struct0<uint> struct0_1)
        {
            uint num = 0u;
            uint_25 |= 0x100;
            do
            {
                num += smethod_5(struct0_1, struct0_0[uint_25 >> 8], (uint_25 >> 7) & 1);
                uint_25 <<= 1;
            }
            while (uint_25 < 65536);
            return num;
        }

        private static uint smethod_9(Struct0<ushort> struct0_0, uint uint_25, uint uint_26, Struct0<uint> struct0_1)
        {
            uint num = 0u;
            uint num2 = 256u;
            uint_25 |= 0x100;
            do
            {
                uint_26 <<= 1;
                num += smethod_5(struct0_1, struct0_0[num2 + (uint_26 & num2) + (uint_25 >> 8)], (uint_25 >> 7) & 1);
                uint_25 <<= 1;
                num2 &= ~(uint_26 ^ uint_25);
            }
            while (uint_25 < 65536);
            return num;
        }

        internal static void smethod_10(Class71 class71_1, Struct0<ushort> struct0_0, int int_48, uint uint_25)
        {
            uint num = 1u;
            int num2 = int_48;
            while (num2 != 0)
            {
                num2--;
                uint num3 = (uint_25 >> num2) & 1;
                class71_1.method_9(Struct0<ushort>.smethod_10(struct0_0, num), num3);
                num = (num << 1) | num3;
            }
        }

        private static void smethod_11(Class71 class71_1, Struct0<ushort> struct0_0, int int_48, uint uint_25)
        {
            uint num = 1u;
            for (int i = 0; i < int_48; i++)
            {
                uint num2 = uint_25 & 1;
                class71_1.method_9(Struct0<ushort>.smethod_10(struct0_0, num), num2);
                num = (num << 1) | num2;
                uint_25 >>= 1;
            }
        }

        internal static uint smethod_12(Struct0<ushort> struct0_0, int int_48, uint uint_25, Struct0<uint> struct0_1)
        {
            uint num = 0u;
            for (uint_25 |= (uint)(1 << int_48); uint_25 != 1; uint_25 >>= 1)
            {
                num += smethod_5(struct0_1, struct0_0[uint_25 >> 1], uint_25 & 1);
            }
            return num;
        }

        private static uint smethod_13(Struct0<ushort> struct0_0, int int_48, uint uint_25, Struct0<uint> struct0_1)
        {
            uint num = 0u;
            uint num2 = 1u;
            for (int num3 = int_48; num3 != 0; num3--)
            {
                uint num4 = uint_25 & 1;
                uint_25 >>= 1;
                num += smethod_5(struct0_1, struct0_0[num2], num4);
                num2 = (num2 << 1) | num4;
            }
            return num;
        }

        private Struct0<ushort> method_5(uint uint_25, byte byte_1)
        {
            return Class15.smethod_1(ushort_0, (uint)(((int)((uint_25 & uint_20) << int_44) + (byte_1 >>> 8 - int_44)) * 768));
        }

        private static bool smethod_14(uint uint_25, uint uint_26)
        {
            return uint_26 >> 7 > uint_25;
        }

        public void method_6(Class77 class77_0, Class77 class77_1)
        {
            class53_0.method_12(class77_1);
            method_20(class77_0);
            class71_0.method_3(class77_0);
            class77_0.method_5(class77_0, this);
        }

        public Struct21 method_7(Class67 class67_0)
        {
            Class67 @class = new(class67_0);
            @class.method_0();
            if (@class.int_1 <= 8 && @class.int_2 <= 4 && @class.int_3 <= 4 && @class.uint_0 <= 2147483648u && @class.uint_0 <= 1073741824)
            {
                uint_23 = @class.uint_0;
                uint num = (uint)@class.int_5;
                if (num < 5)
                {
                    num = 5u;
                }
                if (num > 273)
                {
                    num = 273u;
                }
                uint_12 = num;
                int_44 = @class.int_1;
                int_45 = @class.int_2;
                int_46 = @class.int_3;
                bool_0 = @class.int_4 == 0;
                class53_0.bool_2 = @class.int_6 != 0;
                uint num2 = 4u;
                if (@class.int_6 != 0)
                {
                    if (@class.int_7 < 2)
                    {
                        num2 = 2u;
                    }
                    else if (@class.int_7 < 4)
                    {
                        num2 = (uint)@class.int_7;
                    }
                }
                class53_0.uint_17 = num2;
                class53_0.uint_13 = @class.uint_2;
                bool_1 = @class.uint_3 != 0;
                bool_3 = @class.int_8 > 1;
                return Struct21_0;
            }
            return Struct21_5;
        }

        public Struct21 method_8(Struct0<byte> struct0_0, ref long long_0)
        {
            uint num = uint_23;
            if (long_0 < 5L)
            {
                return Struct21_5;
            }
            long_0 = 5L;
            struct0_0[0] = (byte)((int_46 * 5 + int_45) * 9 + int_44);
            for (int i = 11; i <= 30; i++)
            {
                if (num > (uint)(2 << i))
                {
                    if (num <= (uint)(3 << i))
                    {
                        num = (uint)(3 << i);
                        break;
                    }
                    continue;
                }
                num = (uint)(2 << i);
                break;
            }
            for (int j = 0; j < 4; j++)
            {
                struct0_0[1 + j] = (byte)(num >> 8 * j);
            }
            return Struct21_0;
        }

        public Struct21 method_9(Interface3 interface3_0, Interface2 interface2_0, Interface4 interface4_0, Class77 class77_0, Class77 class77_1)
        {
            Struct21 result;
            if (Struct21.smethod_1(result = method_27(interface3_0, interface2_0, class77_0, class77_1), Struct21_0))
            {
                return result;
            }
            return method_34(interface4_0);
        }

        public Struct21 method_10(Struct0<byte> struct0_0, ref long long_0, Struct0<byte> struct0_1, long long_1, bool bool_5, Interface4 interface4_0, Class77 class77_0, Class77 class77_1)
        {
            Class74 @class = new();
            method_26(struct0_1, long_1);
            @class.struct0_0 = struct0_0;
            @class.long_0 = long_0;
            @class.bool_0 = false;
            bool_1 = bool_5;
            class71_0.interface3_0 = @class;
            Struct21 result = method_29(struct0_1, long_1, 0u, class77_0, class77_1);
            if (Struct21.smethod_0(result, Struct21_0))
            {
                result = method_34(interface4_0);
            }
            long_0 -= @class.long_0;
            if (@class.bool_0)
            {
                return Struct21_7;
            }
            return result;
        }

        private static void smethod_15(ushort[] ushort_10, ushort[] ushort_11, int int_48)
        {
            if (ushort_10.Length != ushort_11.Length || int_48 != ushort_11.Length * 2)
            {
                throw new InvalidOperationException();
            }
            Buffer.BlockCopy(ushort_11, 0, ushort_10, 0, int_48);
        }

        private static void smethod_16(uint[] uint_25, uint[] uint_26, int int_48)
        {
            if (uint_25.Length != uint_26.Length || int_48 != uint_26.Length * 4)
            {
                throw new InvalidOperationException();
            }
            Buffer.BlockCopy(uint_26, 0, uint_25, 0, int_48);
        }

        internal void method_11()
        {
            class72_0.class70_0 = new Class70(class70_0);
            class72_0.class70_1 = new Class70(class70_1);
            class72_0.uint_0 = uint_14;
            for (int i = 0; i < 12; i++)
            {
                smethod_15(class72_0.ushort_1[i], ushort_1[i], 32);
                smethod_15(class72_0.ushort_6[i], ushort_6[i], 32);
            }
            for (int j = 0; j < 4; j++)
            {
                smethod_15(class72_0.ushort_7[j], ushort_7[j], 128);
            }
            smethod_15(class72_0.ushort_2, ushort_2, 24);
            smethod_15(class72_0.ushort_3, ushort_3, 24);
            smethod_15(class72_0.ushort_4, ushort_4, 24);
            smethod_15(class72_0.ushort_5, ushort_5, 24);
            smethod_15(class72_0.ushort_8, ushort_8, 228);
            smethod_15(class72_0.ushort_9, ushort_9, 32);
            class72_0.struct20_0 = struct20_0;
            smethod_15(class72_0.ushort_0, ushort_0, (768 << int_47) * 2);
        }

        internal void method_12()
        {
            class70_0 = new Class70(class72_0.class70_0);
            class70_1 = new Class70(class72_0.class70_1);
            uint_14 = class72_0.uint_0;
            for (int i = 0; i < 12; i++)
            {
                smethod_15(ushort_1[i], class72_0.ushort_1[i], 32);
                smethod_15(ushort_6[i], class72_0.ushort_6[i], 32);
            }
            for (int j = 0; j < 4; j++)
            {
                smethod_15(ushort_7[j], class72_0.ushort_7[j], 128);
            }
            smethod_15(ushort_2, class72_0.ushort_2, 24);
            smethod_15(ushort_3, class72_0.ushort_3, 24);
            smethod_15(ushort_4, class72_0.ushort_4, 24);
            smethod_15(ushort_5, class72_0.ushort_5, 24);
            smethod_15(ushort_8, class72_0.ushort_8, 228);
            smethod_15(ushort_9, class72_0.ushort_9, 32);
            struct20_0 = class72_0.struct20_0;
            smethod_15(ushort_0, class72_0.ushort_0, (768 << int_47) * 2);
        }

        private uint method_13(uint uint_25, out uint uint_26)
        {
            Struct20 @struct = default;
            if (uint_5 != uint_6)
            {
                Class68 @class = class68_0[uint_6];
                uint result = @class.uint_4 - uint_6;
                uint_26 = @class.uint_5;
                uint_6 = @class.uint_4;
                return result;
            }
            uint_6 = 0u;
            uint_5 = 0u;
            uint num;
            uint uint_27;
            if (uint_13 == 0)
            {
                num = method_36(out uint_27);
            }
            else
            {
                num = uint_7;
                uint_27 = uint_8;
            }
            uint num2 = uint_9;
            if (num2 < 2)
            {
                uint_26 = uint.MaxValue;
                return 1u;
            }
            if (num2 > 273)
            {
                num2 = 273u;
            }
            Struct0<byte> struct0_ = Struct0<byte>.smethod_5(interface1_0.imethod_3(object_0), 1);
            Struct20 struct2 = default;
            uint num3 = 0u;
            for (uint num4 = 0u; num4 < 4; num4++)
            {
                @struct[num4] = struct20_0[num4];
                Struct0<byte> struct3 = Struct0<byte>.smethod_9(struct0_, @struct[num4] + 1);
                if (struct0_[0] == struct3[0] && struct0_[1] == struct3[1])
                {
                    uint num5;
                    for (num5 = 2u; num5 < num2 && struct0_[num5] == struct3[num5]; num5++)
                    {
                    }
                    struct2[num4] = num5;
                    if (num5 > struct2[num3])
                    {
                        num3 = num4;
                    }
                }
                else
                {
                    struct2[num4] = 0u;
                }
            }
            if (struct2[num3] >= uint_12)
            {
                uint_26 = num3;
                uint num6 = struct2[num3];
                method_35(num6 - 1);
                return num6;
            }
            Struct0<uint> struct4 = Struct0<uint>.smethod_14(uint_11);
            if (num >= uint_12)
            {
                uint_26 = struct4[uint_27 - 1] + 4;
                method_35(num - 1);
                return num;
            }
            byte b = struct0_[0];
            byte b2 = Struct0<byte>.smethod_9(struct0_, @struct.uint_0 + 1)[0];
            if (num < 2 && b != b2 && struct2[num3] < 2)
            {
                uint_26 = uint.MaxValue;
                return 1u;
            }
            class68_0[0].uint_1 = uint_14;
            uint num7 = uint_25 & uint_21;
            Struct0<ushort> struct0_2 = method_5(uint_25, Struct0<byte>.smethod_5(struct0_, 1)[0]);
            class68_0[1].uint_0 = method_42(ushort_1[uint_14][num7]) + ((!smethod_0(uint_14)) ? smethod_9(struct0_2, b, b2, Struct0<uint>.smethod_14(uint_10)) : smethod_8(struct0_2, b, Struct0<uint>.smethod_14(uint_10)));
            class68_0[1].method_0();
            uint num8 = method_43(ushort_1[uint_14][num7]);
            uint num9 = num8 + method_43(ushort_2[uint_14]);
            if (b2 == b)
            {
                uint num10 = num9 + method_37(uint_14, num7);
                if (num10 < class68_0[1].uint_0)
                {
                    class68_0[1].uint_0 = num10;
                    class68_0[1].method_1();
                }
            }
            uint num11 = ((num >= struct2[num3]) ? num : struct2[num3]);
            if (num11 < 2)
            {
                uint_26 = class68_0[1].uint_5;
                return 1u;
            }
            class68_0[1].uint_4 = 0u;
            class68_0[0].struct20_0 = @struct;
            uint num12 = num11;
            do
            {
                class68_0[num12--].uint_0 = 1073741824u;
            }
            while (num12 >= 2);
            for (uint num13 = 0u; num13 < 4; num13++)
            {
                uint num14 = struct2[num13];
                if (num14 < 2)
                {
                    continue;
                }
                uint num15 = num9 + method_38(num13, uint_14, num7);
                do
                {
                    uint num16 = num15 + class70_1.uint_0[num7][num14 - 2];
                    Class68 class2 = class68_0[num14];
                    if (num16 < class2.uint_0)
                    {
                        class2.uint_0 = num16;
                        class2.uint_4 = 0u;
                        class2.uint_5 = num13;
                        class2.bool_0 = false;
                    }
                }
                while (--num14 >= 2);
            }
            uint num17 = num8 + method_42(ushort_2[uint_14]);
            num12 = ((struct2.uint_0 >= 2) ? (struct2.uint_0 + 1) : 2u);
            if (num12 <= num)
            {
                uint num18;
                for (num18 = 0u; num12 > struct4[num18]; num18 += 2)
                {
                }
                while (true)
                {
                    uint num19 = struct4[num18 + 1];
                    uint num20 = num17 + class70_0.uint_0[num7][num12 - 2];
                    uint num21 = smethod_1(num12);
                    if (num19 >= 128)
                    {
                        uint num22 = method_3(num19);
                        num20 += uint_17[num19 & 0xF] + uint_15[num21][num22];
                    }
                    else
                    {
                        num20 += uint_16[num21][num19];
                    }
                    Class68 class3 = class68_0[num12];
                    if (num20 < class3.uint_0)
                    {
                        class3.uint_0 = num20;
                        class3.uint_4 = 0u;
                        class3.uint_5 = num19 + 4;
                        class3.bool_0 = false;
                    }
                    if (num12 == struct4[num18])
                    {
                        num18 += 2;
                        if (num18 == uint_27)
                        {
                            break;
                        }
                    }
                    num12++;
                }
            }
            uint num23 = 0u;
            uint num24;
            uint uint_28;
            while (true)
            {
                num23++;
                if (num23 != num11)
                {
                    num24 = method_36(out uint_28);
                    if (num24 >= uint_12)
                    {
                        break;
                    }
                    uint_25++;
                    Class68 class4 = class68_0[num23];
                    uint num25 = class4.uint_4;
                    uint num26;
                    if (class4.bool_0)
                    {
                        num25--;
                        if (class4.bool_1)
                        {
                            num26 = class68_0[class4.uint_2].uint_1;
                            num26 = ((class4.uint_3 >= 4) ? uint_2[num26] : uint_3[num26]);
                        }
                        else
                        {
                            num26 = class68_0[num25].uint_1;
                        }
                        num26 = uint_1[num26];
                    }
                    else
                    {
                        num26 = class68_0[num25].uint_1;
                    }
                    if (num25 == num23 - 1)
                    {
                        num26 = ((!class4.method_2()) ? uint_1[num26] : uint_4[num26]);
                    }
                    else
                    {
                        uint num27;
                        if (class4.bool_0 && class4.bool_1)
                        {
                            num25 = class4.uint_2;
                            num27 = class4.uint_3;
                            num26 = uint_3[num26];
                        }
                        else
                        {
                            num27 = class4.uint_5;
                            num26 = ((num27 >= 4) ? uint_2[num26] : uint_3[num26]);
                        }
                        Class68 class5 = class68_0[num25];
                        if (num27 < 4)
                        {
                            @struct.uint_0 = class5.struct20_0[num27];
                            uint num28;
                            for (num28 = 1u; num28 <= num27; num28++)
                            {
                                @struct[num28] = class5.struct20_0[num28 - 1];
                            }
                            for (; num28 < 4; num28++)
                            {
                                @struct[num28] = class5.struct20_0[num28];
                            }
                        }
                        else
                        {
                            @struct.uint_0 = num27 - 4;
                            @struct.uint_1 = class5.struct20_0.uint_0;
                            @struct.uint_2 = class5.struct20_0.uint_1;
                            @struct.uint_3 = class5.struct20_0.uint_2;
                        }
                    }
                    class4.uint_1 = num26;
                    class4.struct20_0 = @struct;
                    uint num29 = class4.uint_0;
                    bool flag = false;
                    Struct0<byte> struct0_3 = Struct0<byte>.smethod_5(interface1_0.imethod_3(object_0), 1);
                    byte b3 = struct0_3[0];
                    byte b4 = Struct0<byte>.smethod_9(struct0_3, @struct.uint_0 + 1)[0];
                    uint num30 = uint_25 & uint_21;
                    uint num31 = num29 + method_42(ushort_1[num26][num30]);
                    Struct0<ushort> struct0_4 = method_5(uint_25, struct0_3[-1]);
                    num31 = (smethod_0(num26) ? (num31 + smethod_8(struct0_4, b3, Struct0<uint>.smethod_14(uint_10))) : (num31 + smethod_9(struct0_4, b3, b4, Struct0<uint>.smethod_14(uint_10))));
                    Class68 class6 = class68_0[num23 + 1];
                    if (num31 < class6.uint_0)
                    {
                        class6.uint_0 = num31;
                        class6.uint_4 = num23;
                        class6.method_0();
                        flag = true;
                    }
                    uint num32 = num29 + method_43(ushort_1[num26][num30]);
                    uint num33 = num32 + method_43(ushort_2[num26]);
                    if (b4 == b3 && (class6.uint_4 >= num23 || class6.uint_5 != 0))
                    {
                        uint num34 = num33 + method_37(num26, num30);
                        if (num34 <= class6.uint_0)
                        {
                            class6.uint_0 = num34;
                            class6.uint_4 = num23;
                            class6.method_1();
                            flag = true;
                        }
                    }
                    uint num35 = Math.Min(uint_9, 4095 - num23);
                    if (num35 < 2)
                    {
                        continue;
                    }
                    num2 = ((num35 <= uint_12) ? num35 : uint_12);
                    if (!flag && b4 != b3)
                    {
                        Struct0<byte> struct5 = Struct0<byte>.smethod_9(struct0_3, @struct.uint_0 + 1);
                        uint num36 = uint_12 + 1;
                        if (num36 > num35)
                        {
                            num36 = num35;
                        }
                        uint num37;
                        for (num37 = 1u; num37 < num36 && struct0_3[num37] == struct5[num37]; num37++)
                        {
                        }
                        uint num38 = num37 - 1;
                        if (num38 >= 2)
                        {
                            uint num39 = uint_1[num26];
                            uint num40 = (uint_25 + 1) & uint_21;
                            uint num41 = num31 + method_43(ushort_1[num39][num40]) + method_43(ushort_2[num39]);
                            uint num42 = num23 + 1 + num38;
                            while (num11 < num42)
                            {
                                class68_0[++num11].uint_0 = 1073741824u;
                            }
                            uint num43 = num41 + method_39(0u, num38, num39, num40);
                            Class68 class7 = class68_0[num42];
                            if (num43 < class7.uint_0)
                            {
                                class7.uint_0 = num43;
                                class7.uint_4 = num23 + 1;
                                class7.uint_5 = 0u;
                                class7.bool_0 = true;
                                class7.bool_1 = false;
                            }
                        }
                    }
                    uint num44 = 2u;
                    for (uint num45 = 0u; num45 < 4; num45++)
                    {
                        Struct0<byte> struct6 = Struct0<byte>.smethod_9(struct0_3, @struct[num45] + 1);
                        if (struct0_3[0] != struct6[0] || struct0_3[1] != struct6[1])
                        {
                            continue;
                        }
                        uint num46;
                        for (num46 = 2u; num46 < num2 && struct0_3[num46] == struct6[num46]; num46++)
                        {
                        }
                        while (num11 < num23 + num46)
                        {
                            class68_0[++num11].uint_0 = 1073741824u;
                        }
                        uint num47 = num46;
                        uint num48 = num33 + method_38(num45, num26, num30);
                        do
                        {
                            uint num49 = num48 + class70_1.uint_0[num30][num46 - 2];
                            Class68 class8 = class68_0[num23 + num46];
                            if (num49 < class8.uint_0)
                            {
                                class8.uint_0 = num49;
                                class8.uint_4 = num23;
                                class8.uint_5 = num45;
                                class8.bool_0 = false;
                            }
                        }
                        while (--num46 >= 2);
                        num46 = num47;
                        if (num45 == 0)
                        {
                            num44 = num46 + 1;
                        }
                        uint num50 = num46 + 1;
                        uint num51 = num50 + uint_12;
                        if (num51 > num35)
                        {
                            num51 = num35;
                        }
                        for (; num50 < num51 && struct0_3[num50] == struct6[num50]; num50++)
                        {
                        }
                        num50 -= num46 + 1;
                        if (num50 >= 2)
                        {
                            uint num52 = uint_3[num26];
                            uint num53 = (uint_25 + num46) & uint_21;
                            uint num54 = num48 + class70_1.uint_0[num30][num46 - 2] + method_42(ushort_1[num52][num53]) + smethod_9(method_5(uint_25 + num46, struct0_3[num46 - 1]), struct0_3[num46], struct6[num46], Struct0<uint>.smethod_14(uint_10));
                            num52 = uint_1[num52];
                            num53 = (uint_25 + num46 + 1) & uint_21;
                            uint num55 = num54 + method_43(ushort_1[num52][num53]) + method_43(ushort_2[num52]);
                            uint num56 = num23 + num46 + 1 + num50;
                            while (num11 < num56)
                            {
                                class68_0[++num11].uint_0 = 1073741824u;
                            }
                            uint num57 = num55 + method_39(0u, num50, num52, num53);
                            Class68 class9 = class68_0[num56];
                            if (num57 < class9.uint_0)
                            {
                                class9.uint_0 = num57;
                                class9.uint_4 = num23 + num46 + 1;
                                class9.uint_5 = 0u;
                                class9.bool_0 = true;
                                class9.bool_1 = true;
                                class9.uint_2 = num23;
                                class9.uint_3 = num45;
                            }
                        }
                    }
                    if (num24 > num2)
                    {
                        num24 = num2;
                        for (uint_28 = 0u; num24 > struct4[uint_28]; uint_28 += 2)
                        {
                        }
                        struct4[uint_28] = num24;
                        uint_28 += 2;
                    }
                    if (num24 < num44)
                    {
                        continue;
                    }
                    uint num58 = num32 + method_42(ushort_2[num26]);
                    while (num11 < num23 + num24)
                    {
                        class68_0[++num11].uint_0 = 1073741824u;
                    }
                    uint num59;
                    for (num59 = 0u; num44 > struct4[num59]; num59 += 2)
                    {
                    }
                    uint num60 = struct4[num59 + 1];
                    uint num61 = method_3(num60);
                    uint num62 = num44;
                    while (true)
                    {
                        uint num63 = num58 + class70_0.uint_0[num30][num62 - 2];
                        uint num64 = smethod_1(num62);
                        num63 = ((num60 < 128) ? (num63 + uint_16[num64][num60]) : (num63 + (uint_15[num64][num61] + uint_17[num60 & 0xF])));
                        Class68 class10 = class68_0[num23 + num62];
                        if (num63 < class10.uint_0)
                        {
                            class10.uint_0 = num63;
                            class10.uint_4 = num23;
                            class10.uint_5 = num60 + 4;
                            class10.bool_0 = false;
                        }
                        if (num62 == struct4[num59])
                        {
                            Struct0<byte> struct7 = Struct0<byte>.smethod_9(struct0_3, num60 + 1);
                            uint num65 = num62 + 1;
                            uint num66 = num65 + uint_12;
                            if (num66 > num35)
                            {
                                num66 = num35;
                            }
                            for (; num65 < num66 && struct0_3[num65] == struct7[num65]; num65++)
                            {
                            }
                            num65 -= num62 + 1;
                            if (num65 >= 2)
                            {
                                uint num67 = uint_2[num26];
                                uint num68 = (uint_25 + num62) & uint_21;
                                uint num69 = num63 + method_42(ushort_1[num67][num68]) + smethod_9(method_5(uint_25 + num62, struct0_3[num62 - 1]), struct0_3[num62], struct7[num62], Struct0<uint>.smethod_14(uint_10));
                                num67 = uint_1[num67];
                                num68 = (num68 + 1) & uint_21;
                                uint num70 = num69 + method_43(ushort_1[num67][num68]) + method_43(ushort_2[num67]);
                                uint num71 = num23 + num62 + 1 + num65;
                                while (num11 < num71)
                                {
                                    class68_0[++num11].uint_0 = 1073741824u;
                                }
                                uint num72 = num70 + method_39(0u, num65, num67, num68);
                                Class68 class11 = class68_0[num71];
                                if (num72 < class11.uint_0)
                                {
                                    class11.uint_0 = num72;
                                    class11.uint_4 = num23 + num62 + 1;
                                    class11.uint_5 = 0u;
                                    class11.bool_0 = true;
                                    class11.bool_1 = true;
                                    class11.uint_2 = num23;
                                    class11.uint_3 = num60 + 4;
                                }
                            }
                            num59 += 2;
                            if (num59 == uint_28)
                            {
                                break;
                            }
                            num60 = struct4[num59 + 1];
                            if (num60 >= 128)
                            {
                                num61 = method_3(num60);
                            }
                        }
                        num62++;
                    }
                    continue;
                }
                return method_40(out uint_26, num23);
            }
            uint_8 = uint_28;
            uint_7 = num24;
            return method_40(out uint_26, num23);
        }

        private uint method_14(out uint uint_25)
        {
            uint num;
            uint uint_26;
            if (uint_13 == 0)
            {
                num = method_36(out uint_26);
            }
            else
            {
                num = uint_7;
                uint_26 = uint_8;
            }
            uint num2 = uint_9;
            uint_25 = uint.MaxValue;
            if (num2 < 2)
            {
                return 1u;
            }
            if (num2 > 273)
            {
                num2 = 273u;
            }
            Struct0<byte> struct0_ = Struct0<byte>.smethod_5(interface1_0.imethod_3(object_0), 1);
            uint num3 = 0u;
            uint num4 = 0u;
            uint num5 = 0u;
            uint num6;
            while (true)
            {
                if (num5 < 4)
                {
                    Struct0<byte> @struct = Struct0<byte>.smethod_9(struct0_, struct20_0[num5] + 1);
                    if (struct0_[0] == @struct[0] && struct0_[1] == @struct[1])
                    {
                        for (num6 = 2u; num6 < num2 && struct0_[num6] == @struct[num6]; num6++)
                        {
                        }
                        if (num6 >= uint_12)
                        {
                            break;
                        }
                        if (num6 > num3)
                        {
                            num4 = num5;
                            num3 = num6;
                        }
                    }
                    num5++;
                    continue;
                }
                Struct0<uint> struct2 = Struct0<uint>.smethod_14(uint_11);
                if (num >= uint_12)
                {
                    uint_25 = struct2[uint_26 - 1] + 4;
                    method_35(num - 1);
                    return num;
                }
                uint num7 = 0u;
                if (num >= 2)
                {
                    num7 = struct2[uint_26 - 1];
                    while (uint_26 > 2 && num == struct2[uint_26 - 4] + 1 && smethod_14(struct2[uint_26 - 3], num7))
                    {
                        uint_26 -= 2;
                        num = struct2[uint_26 - 2];
                        num7 = struct2[uint_26 - 1];
                    }
                    if (num == 2 && num7 >= 128)
                    {
                        num = 1u;
                    }
                }
                if (num3 >= 2 && (num3 + 1 >= num || (num3 + 2 >= num && num7 >= 512) || (num3 + 3 >= num && num7 >= 32768)))
                {
                    uint_25 = num4;
                    method_35(num3 - 1);
                    return num3;
                }
                if (num >= 2 && num2 > 2)
                {
                    uint_7 = method_36(out uint_8);
                    if (uint_7 >= 2)
                    {
                        uint num8 = struct2[uint_8 - 1];
                        if ((uint_7 >= num && num8 < num7) || (uint_7 == num + 1 && !smethod_14(num7, num8)) || uint_7 > num + 1 || (uint_7 + 1 >= num && num >= 3 && smethod_14(num8, num7)))
                        {
                            return 1u;
                        }
                    }
                    struct0_ = Struct0<byte>.smethod_5(interface1_0.imethod_3(object_0), 1);
                    uint num9 = 0u;
                    while (true)
                    {
                        if (num9 < 4)
                        {
                            Struct0<byte> struct3 = Struct0<byte>.smethod_9(struct0_, struct20_0[num9] + 1);
                            if (struct0_[0] == struct3[0] && struct0_[1] == struct3[1])
                            {
                                uint num10 = num - 1;
                                uint num11;
                                for (num11 = 2u; num11 < num10 && struct0_[num11] == struct3[num11]; num11++)
                                {
                                }
                                if (num11 >= num10)
                                {
                                    break;
                                }
                            }
                            num9++;
                            continue;
                        }
                        uint_25 = num7 + 4;
                        method_35(num - 2);
                        return num;
                    }
                    return 1u;
                }
                return 1u;
            }
            uint_25 = num5;
            method_35(num6 - 1);
            return num6;
        }

        private void method_15(uint uint_25)
        {
            class71_0.method_10(ref ushort_1[uint_14][uint_25], 1u);
            class71_0.method_10(ref ushort_2[uint_14], 0u);
            uint_14 = uint_2[uint_14];
            class70_0.method_5(class71_0, 0u, uint_25, !bool_0, Struct0<uint>.smethod_14(uint_10));
            smethod_10(class71_0, Struct0<ushort>.smethod_14(ushort_7[smethod_1(2u)]), 6, 63u);
            class71_0.method_8(67108863u, 26);
            smethod_11(class71_0, Struct0<ushort>.smethod_14(ushort_9), 4, 15u);
        }

        private Struct21 method_16()
        {
            if (Struct21.smethod_1(struct21_0, Struct21_0))
            {
                return struct21_0;
            }
            if (Struct21.smethod_1(class71_0.struct21_0, Struct21_0))
            {
                struct21_0 = Struct21_9;
            }
            if (Struct21.smethod_1(class53_0.struct21_0, Struct21_0))
            {
                struct21_0 = Struct21_8;
            }
            if (Struct21.smethod_1(struct21_0, Struct21_0))
            {
                bool_2 = true;
            }
            return struct21_0;
        }

        private Struct21 method_17(uint uint_25)
        {
            bool_2 = true;
            if (bool_1)
            {
                method_15(uint_25 & uint_21);
            }
            class71_0.method_7();
            class71_0.method_5();
            return method_16();
        }

        private void method_18()
        {
            for (uint num = 0u; num < 16; num++)
            {
                uint_17[num] = smethod_13(Struct0<ushort>.smethod_14(ushort_9), 4, num, Struct0<uint>.smethod_14(uint_10));
            }
            uint_18 = 0u;
        }

        private void method_19()
        {
            uint[] array = new uint[128];
            for (uint num = 4u; num < 128; num++)
            {
                uint num2 = method_2(num);
                uint num3 = (num2 >> 1) - 1;
                uint num4 = (2 | (num2 & 1)) << (int)num3;
                array[num] = smethod_13(Class15.smethod_1(ushort_8, num4 - num2 - 1), (int)num3, num - num4, Struct0<uint>.smethod_14(uint_10));
            }
            for (uint num5 = 0u; num5 < 4; num5++)
            {
                Struct0<ushort> struct0_ = Struct0<ushort>.smethod_14(ushort_7[num5]);
                Struct0<uint> @struct = Struct0<uint>.smethod_14(uint_15[num5]);
                for (uint num6 = 0u; num6 < uint_19; num6++)
                {
                    @struct[num6] = smethod_12(struct0_, 6, num6, Struct0<uint>.smethod_14(uint_10));
                }
                for (uint num7 = 14u; num7 < uint_19; num7++)
                {
                    @struct[num7] += (num7 >> 1) - 1 - 4 << 4;
                }
                Struct0<uint> struct2 = Struct0<uint>.smethod_14(uint_16[num5]);
                uint num8;
                for (num8 = 0u; num8 < 4; num8++)
                {
                    struct2[num8] = @struct[num8];
                }
                for (; num8 < 128; num8++)
                {
                    struct2[num8] = @struct[method_2(num8)] + array[num8];
                }
            }
            uint_22 = 0u;
        }

        internal void method_20(Class77 class77_0)
        {
            class77_0.method_7(class77_0, ushort_0);
            class77_0.method_7(class77_0, class72_0.ushort_0);
            ushort_0 = null;
            class72_0.ushort_0 = null;
        }

        internal Struct21 method_21(bool bool_5, uint uint_25, uint uint_26)
        {
            if (bool_4)
            {
                interface1_0.imethod_0(object_0);
                bool_4 = false;
            }
            if (bool_2)
            {
                return struct21_0;
            }
            Struct21 result;
            if (Struct21.smethod_1(result = method_16(), Struct21_0))
            {
                return result;
            }
            uint num = (uint)ulong_0;
            uint num2 = num;
            if (ulong_0 == 0L)
            {
                if (interface1_0.imethod_2(object_0) == 0)
                {
                    return method_17(num);
                }
                method_36(out var _);
                class71_0.method_10(ref ushort_1[uint_14][0], 0u);
                uint_14 = uint_1[uint_14];
                byte uint_28 = interface1_0.imethod_1(object_0, (int)(0L - (long)uint_13));
                smethod_2(class71_0, Struct0<ushort>.smethod_14(ushort_0), uint_28);
                uint_13--;
                num++;
            }
            if (interface1_0.imethod_2(object_0) != 0)
            {
                while (true)
                {
                    uint num3 = (bool_0 ? method_14(out uint uint_29) : method_13(num, out uint_29));
                    uint num4 = num & uint_21;
                    if (num3 == 1 && uint_29 == uint.MaxValue)
                    {
                        class71_0.method_10(ref ushort_1[uint_14][num4], 0u);
                        Struct0<byte> struct0_ = Struct0<byte>.smethod_9(interface1_0.imethod_3(object_0), uint_13);
                        byte uint_30 = struct0_[0];
                        Struct0<ushort> struct0_2 = method_5(num, Struct0<byte>.smethod_5(struct0_, 1)[0]);
                        if (smethod_0(uint_14))
                        {
                            smethod_2(class71_0, struct0_2, uint_30);
                        }
                        else
                        {
                            smethod_3(class71_0, struct0_2, uint_30, Struct0<byte>.smethod_5(Struct0<byte>.smethod_9(struct0_, struct20_0.uint_0), 1)[0]);
                        }
                        uint_14 = uint_1[uint_14];
                    }
                    else
                    {
                        class71_0.method_10(ref ushort_1[uint_14][num4], 1u);
                        if (uint_29 < 4)
                        {
                            class71_0.method_10(ref ushort_2[uint_14], 1u);
                            if (uint_29 == 0)
                            {
                                class71_0.method_10(ref ushort_3[uint_14], 0u);
                                class71_0.method_10(ref ushort_6[uint_14][num4], (num3 != 1) ? 1u : 0u);
                            }
                            else
                            {
                                uint num5 = struct20_0[uint_29];
                                class71_0.method_10(ref ushort_3[uint_14], 1u);
                                if (uint_29 == 1)
                                {
                                    class71_0.method_10(ref ushort_4[uint_14], 0u);
                                }
                                else
                                {
                                    class71_0.method_10(ref ushort_4[uint_14], 1u);
                                    class71_0.method_10(ref ushort_5[uint_14], uint_29 - 2);
                                    if (uint_29 == 3)
                                    {
                                        struct20_0.uint_3 = struct20_0.uint_2;
                                    }
                                    struct20_0.uint_2 = struct20_0.uint_1;
                                }
                                struct20_0.uint_1 = struct20_0.uint_0;
                                struct20_0.uint_0 = num5;
                            }
                            if (num3 == 1)
                            {
                                uint_14 = uint_4[uint_14];
                            }
                            else
                            {
                                class70_1.method_5(class71_0, num3 - 2, num4, !bool_0, Struct0<uint>.smethod_14(uint_10));
                                uint_14 = uint_3[uint_14];
                            }
                        }
                        else
                        {
                            class71_0.method_10(ref ushort_2[uint_14], 0u);
                            uint_14 = uint_2[uint_14];
                            class70_0.method_5(class71_0, num3 - 2, num4, !bool_0, Struct0<uint>.smethod_14(uint_10));
                            uint_29 -= 4;
                            uint num6 = method_4(uint_29);
                            smethod_10(class71_0, Struct0<ushort>.smethod_14(ushort_7[smethod_1(num3)]), 6, num6);
                            if (num6 >= 4)
                            {
                                int num7 = (int)((num6 >> 1) - 1);
                                uint num8 = (2 | (num6 & 1)) << num7;
                                uint num9 = uint_29 - num8;
                                if (num6 < 14)
                                {
                                    smethod_11(class71_0, Class15.smethod_1(ushort_8, num8 - num6 - 1), num7, num9);
                                }
                                else
                                {
                                    class71_0.method_8(num9 >> 4, num7 - 4);
                                    smethod_11(class71_0, Struct0<ushort>.smethod_14(ushort_9), 4, num9 & 0xF);
                                    uint_18++;
                                }
                            }
                            struct20_0.uint_3 = struct20_0.uint_2;
                            struct20_0.uint_2 = struct20_0.uint_1;
                            struct20_0.uint_1 = struct20_0.uint_0;
                            struct20_0.uint_0 = uint_29;
                            uint_22++;
                        }
                    }
                    uint_13 -= num3;
                    num += num3;
                    if (uint_13 != 0)
                    {
                        continue;
                    }
                    if (!bool_0)
                    {
                        if (uint_22 >= 128)
                        {
                            method_19();
                        }
                        if (uint_18 >= 16)
                        {
                            method_18();
                        }
                    }
                    if (interface1_0.imethod_2(object_0) == 0)
                    {
                        break;
                    }
                    uint num10 = num - num2;
                    if (bool_5)
                    {
                        if (num10 + 4096 + 300 >= uint_26 || class71_0.method_1() + 8192L >= uint_25)
                        {
                            break;
                        }
                    }
                    else if (num10 >= 32768)
                    {
                        ulong_0 += num - num2;
                        return method_16();
                    }
                }
            }
            ulong_0 += num - num2;
            return method_17(num);
        }

        private Struct21 method_22(uint uint_25, Class77 class77_0, Class77 class77_1)
        {
            if (!class71_0.method_2(class77_0))
            {
                return Struct21_2;
            }
            int num = int_44 + int_45;
            if (ushort_0 == null || class72_0.ushort_0 == null || int_47 != num)
            {
                method_20(class77_0);
                ushort_0 = class77_0.method_3(class77_0, 768 << num);
                class72_0.ushort_0 = class77_0.method_3(class77_0, 768 << num);
                if (ushort_0 == null || class72_0.ushort_0 == null)
                {
                    method_20(class77_0);
                    return Struct21_2;
                }
                int_47 = num;
            }
            class53_0.bool_3 = uint_23 > 16777216;
            uint num2 = 4096u;
            if (4096 + uint_23 < uint_25)
            {
                num2 = uint_25 - uint_23;
            }
            if (!class53_0.method_13(uint_23, num2, uint_12, 273u, class77_1))
            {
                return Struct21_2;
            }
            object_0 = class53_0;
            Class52.smethod_2(class53_0, out interface1_0);
            return Struct21_0;
        }

        internal void method_23()
        {
            uint_14 = 0u;
            struct20_0 = default;
            class71_0.method_4();
            for (uint num = 0u; num < 12; num++)
            {
                for (uint num2 = 0u; num2 < 16; num2++)
                {
                    ushort_1[num][num2] = 1024;
                    ushort_6[num][num2] = 1024;
                }
                ushort_2[num] = 1024;
                ushort_3[num] = 1024;
                ushort_4[num] = 1024;
                ushort_5[num] = 1024;
            }
            uint num3 = (uint)(768 << int_45 + int_44);
            for (uint num4 = 0u; num4 < num3; num4++)
            {
                ushort_0[num4] = 1024;
            }
            for (uint num5 = 0u; num5 < 4; num5++)
            {
                Struct0<ushort> @struct = Struct0<ushort>.smethod_14(ushort_7[num5]);
                for (uint num6 = 0u; num6 < 64; num6++)
                {
                    @struct[num6] = 1024;
                }
            }
            for (uint num7 = 0u; num7 < 114; num7++)
            {
                ushort_8[num7] = 1024;
            }
            class70_0.method_0();
            class70_1.method_0();
            for (uint num8 = 0u; num8 < 16; num8++)
            {
                ushort_9[num8] = 1024;
            }
            uint_5 = 0u;
            uint_6 = 0u;
            uint_13 = 0u;
            uint_21 = (uint)((1 << int_46) - 1);
            uint_20 = (uint)((1 << int_45) - 1);
        }

        internal void method_24()
        {
            if (!bool_0)
            {
                method_19();
                method_18();
            }
            uint num = uint_12 + 1 - 2;
            class70_0.uint_1 = num;
            class70_1.uint_1 = num;
            class70_0.method_4((uint)(1 << int_46), Struct0<uint>.smethod_14(uint_10));
            class70_1.method_4((uint)(1 << int_46), Struct0<uint>.smethod_14(uint_10));
        }

        internal Struct21 method_25(uint uint_25, Class77 class77_0, Class77 class77_1)
        {
            uint num;
            for (num = 0u; num < 31 && uint_23 > (uint)(1 << (int)num); num++)
            {
            }
            uint_19 = num * 2;
            bool_2 = false;
            struct21_0 = Struct21_0;
            Struct21 result;
            if (Struct21.smethod_1(result = method_22(uint_25, class77_0, class77_1), Struct21_0))
            {
                return result;
            }
            method_23();
            method_24();
            ulong_0 = 0uL;
            return Struct21_0;
        }

        internal void method_26(Struct0<byte> struct0_0, long long_0)
        {
            class53_0.bool_1 = true;
            class53_0.struct0_2 = struct0_0;
            class53_0.long_0 = long_0;
        }

        internal Struct21 method_27(Interface3 interface3_0, Interface2 interface2_0, Class77 class77_0, Class77 class77_1)
        {
            class53_0.interface2_0 = interface2_0;
            bool_4 = true;
            class71_0.interface3_0 = interface3_0;
            return method_25(0u, class77_0, class77_1);
        }

        internal Struct21 method_28(Interface2 interface2_0, uint uint_25, Class77 class77_0, Class77 class77_1)
        {
            class53_0.interface2_0 = interface2_0;
            bool_4 = true;
            return method_25(uint_25, class77_0, class77_1);
        }

        internal Struct21 method_29(Struct0<byte> struct0_0, long long_0, uint uint_25, Class77 class77_0, Class77 class77_1)
        {
            method_26(struct0_0, long_0);
            bool_4 = true;
            return method_25(uint_25, class77_0, class77_1);
        }

        internal void method_30()
        {
        }

        internal uint method_31()
        {
            return interface1_0.imethod_2(object_0);
        }

        internal Struct0<byte> method_32()
        {
            return Struct0<byte>.smethod_9(interface1_0.imethod_3(object_0), uint_13);
        }

        internal Struct21 method_33(bool bool_5, Struct0<byte> struct0_0, ref long long_0, uint uint_25, ref uint uint_26)
        {
            Class74 @class = new()
            {
                struct0_0 = struct0_0,
                long_0 = long_0,
                bool_0 = false
            };
            bool_1 = false;
            bool_2 = false;
            struct21_0 = Struct21_0;
            if (bool_5)
            {
                method_23();
            }
            method_24();
            ulong num = ulong_0;
            class71_0.method_4();
            class71_0.interface3_0 = @class;
            Struct21 result = method_21(bool_5: true, uint_25, uint_26);
            uint_26 = (uint)(ulong_0 - num);
            long_0 -= @class.long_0;
            if (@class.bool_0)
            {
                return Struct21_7;
            }
            return result;
        }

        private Struct21 method_34(Interface4 interface4_0)
        {
            _ = Struct21_0;
            Struct21 result;
            while (true)
            {
                result = method_21(bool_5: false, 0u, 0u);
                if (Struct21.smethod_1(result, Struct21_0) || bool_2)
                {
                    break;
                }
                if (interface4_0 != null)
                {
                    result = interface4_0.imethod_0(ulong_0, class71_0.method_1());
                    if (Struct21.smethod_1(result, Struct21_0))
                    {
                        result = Struct21_10;
                        break;
                    }
                }
            }
            method_30();
            return result;
        }

        private void method_35(uint uint_25)
        {
            if (uint_25 != 0)
            {
                uint_13 += uint_25;
                interface1_0.imethod_5(object_0, uint_25);
            }
        }

        private uint method_36(out uint uint_25)
        {
            uint_9 = interface1_0.imethod_2(object_0);
            uint num = interface1_0.imethod_4(object_0, Struct0<uint>.smethod_14(uint_11));
            uint num2 = 0u;
            if (num != 0)
            {
                num2 = uint_11[num - 2];
                if (num2 == uint_12)
                {
                    Struct0<byte> struct0_ = Struct0<byte>.smethod_5(interface1_0.imethod_3(object_0), 1);
                    uint num3 = uint_11[num - 1] + 1;
                    uint num4 = uint_9;
                    if (num4 > 273)
                    {
                        num4 = 273u;
                    }
                    for (Struct0<byte> @struct = Struct0<byte>.smethod_9(struct0_, num3); num2 < num4 && struct0_[num2] == @struct[num2]; num2++)
                    {
                    }
                }
            }
            uint_13++;
            uint_25 = num;
            return num2;
        }

        private uint method_37(uint uint_25, uint uint_26)
        {
            return method_42(ushort_3[uint_25]) + method_42(ushort_6[uint_25][uint_26]);
        }

        private uint method_38(uint uint_25, uint uint_26, uint uint_27)
        {
            uint num;
            if (uint_25 == 0)
            {
                num = method_42(ushort_3[uint_26]);
                return num + method_43(ushort_6[uint_26][uint_27]);
            }
            num = method_43(ushort_3[uint_26]);
            if (uint_25 == 1)
            {
                return num + method_42(ushort_4[uint_26]);
            }
            num += method_43(ushort_4[uint_26]);
            return num + method_41(ushort_5[uint_26], uint_25 - 2);
        }

        private uint method_39(uint uint_25, uint uint_26, uint uint_27, uint uint_28)
        {
            return class70_1.uint_0[uint_28][uint_26 - 2] + method_38(uint_25, uint_27, uint_28);
        }

        private uint method_40(out uint uint_25, uint uint_26)
        {
            uint num = class68_0[uint_26].uint_4;
            uint num2 = class68_0[uint_26].uint_5;
            uint_5 = uint_26;
            do
            {
                if (class68_0[uint_26].bool_0)
                {
                    class68_0[num].method_0();
                    class68_0[num].uint_4 = num - 1;
                    if (class68_0[uint_26].bool_1)
                    {
                        class68_0[num - 1].bool_0 = false;
                        class68_0[num - 1].uint_4 = class68_0[uint_26].uint_2;
                        class68_0[num - 1].uint_5 = class68_0[uint_26].uint_3;
                    }
                }
                uint num3 = num;
                uint num4 = num2;
                num2 = class68_0[num3].uint_5;
                num = class68_0[num3].uint_4;
                class68_0[num3].uint_5 = num4;
                class68_0[num3].uint_4 = uint_26;
                uint_26 = num3;
            }
            while (uint_26 != 0);
            uint_25 = class68_0[0].uint_5;
            uint_6 = class68_0[0].uint_4;
            return uint_6;
        }

        private uint method_41(ushort ushort_10, uint uint_25)
        {
            return smethod_5(Struct0<uint>.smethod_14(uint_10), ushort_10, uint_25);
        }

        private uint method_42(ushort ushort_10)
        {
            return smethod_6(Struct0<uint>.smethod_14(uint_10), ushort_10);
        }

        private uint method_43(ushort ushort_10)
        {
            return smethod_7(Struct0<uint>.smethod_14(uint_10), ushort_10);
        }
    }

    public readonly struct Struct21(int int_1)
    {
        private readonly int int_0 = int_1;

        public override int GetHashCode()
        {
            return int_0;
        }

        public override bool Equals(object obj)
        {
            if (obj is Struct21)
            {
                return ((Struct21)obj).int_0 == int_0;
            }
            return false;
        }

        public bool method_0(Struct21 struct21_0)
        {
            return struct21_0.int_0 == int_0;
        }

        [SpecialName]
        public static bool smethod_0(Struct21 struct21_0, Struct21 struct21_1)
        {
            return struct21_0.int_0 == struct21_1.int_0;
        }

        [SpecialName]
        public static bool smethod_1(Struct21 struct21_0, Struct21 struct21_1)
        {
            return struct21_0.int_0 != struct21_1.int_0;
        }

        [SpecialName]
        public static bool smethod_2(Struct21 struct21_0, int int_1)
        {
            return struct21_0.int_0 == int_1;
        }

        [SpecialName]
        public static bool smethod_3(Struct21 struct21_0, int int_1)
        {
            return struct21_0.int_0 != int_1;
        }
    }

    public interface Interface2
    {
        Struct21 imethod_0(Struct0<byte> struct0_0, ref long long_0);
    }

    public sealed class Class75(Func<Struct0<byte>, long, long> func_1) : Interface2
    {
        private readonly Func<Struct0<byte>, long, long> func_0 = func_1;

        Struct21 Interface2.imethod_0(Struct0<byte> struct0_0, ref long long_0)
        {
            try
            {
                long_0 = func_0(struct0_0, long_0);
            }
            catch
            {
                return Struct21_8;
            }
            return Struct21_0;
        }
    }

    public interface Interface3
    {
        long imethod_0(Struct0<byte> struct0_0, long long_0);
    }

    public sealed class Class76(Action<Struct0<byte>, long> action_1) : Interface3
    {
        private readonly Action<Struct0<byte>, long> action_0 = action_1;

        long Interface3.imethod_0(Struct0<byte> struct0_0, long long_0)
        {
            if (long_0 <= 0L)
            {
                Debugger.Break();
                return -1L;
            }
            try
            {
                action_0(struct0_0, long_0);
                return long_0;
            }
            catch
            {
                return 0L;
            }
        }
    }

    public interface Interface4
    {
        Struct21 imethod_0(ulong ulong_0, ulong ulong_1);
    }

    public sealed class Class77
    {
        public static readonly Class77 class77_0 = new(200);

        public static readonly Class77 class77_1 = new(100);

        private static readonly Dictionary<long, List<byte[]>> dictionary_0 = [];

        private static readonly Dictionary<long, List<ushort[]>> dictionary_1 = [];

        private static readonly Dictionary<long, List<uint[]>> dictionary_2 = [];

        private readonly int int_0;

        private Class77(int int_1)
        {
            int_0 = int_1;
        }

        internal bool method_0<T>()
        {
            return true;
        }

        public T method_1<T>(object object_0) where T : class, new()
        {
            if (!method_0<T>())
            {
                return null;
            }
            return new T();
        }

        public byte[] method_2(object object_0, long long_0)
        {
            lock (dictionary_0)
            {
                if (dictionary_0.TryGetValue(long_0, out var value) && value.Count > 0)
                {
                    byte[] result = value[value.Count - 1];
                    value.RemoveAt(value.Count - 1);
                    return result;
                }
            }
            return new byte[long_0];
        }

        public ushort[] method_3(object object_0, long long_0)
        {
            lock (dictionary_1)
            {
                if (dictionary_1.TryGetValue(long_0, out var value) && value.Count > 0)
                {
                    ushort[] result = value[value.Count - 1];
                    value.RemoveAt(value.Count - 1);
                    return result;
                }
            }
            return new ushort[long_0];
        }

        public uint[] method_4(object object_0, long long_0)
        {
            lock (dictionary_2)
            {
                if (dictionary_2.TryGetValue(long_0, out var value) && value.Count > 0)
                {
                    uint[] result = value[value.Count - 1];
                    value.RemoveAt(value.Count - 1);
                    return result;
                }
            }
            return new uint[long_0];
        }

        public void method_5(object object_0, object object_1)
        {
        }

        public void method_6(object object_0, byte[] byte_0)
        {
            if (byte_0 == null)
            {
                return;
            }
            lock (dictionary_0)
            {
                if (!dictionary_0.TryGetValue(byte_0.Length, out var value))
                {
                    dictionary_0.Add(byte_0.Length, value = []);
                }
                value.Add(byte_0);
            }
        }

        public void method_7(object object_0, ushort[] ushort_0)
        {
            if (ushort_0 == null)
            {
                return;
            }
            lock (dictionary_1)
            {
                if (!dictionary_1.TryGetValue(ushort_0.Length, out var value))
                {
                    dictionary_1.Add(ushort_0.Length, value = []);
                }
                value.Add(ushort_0);
            }
        }

        public void method_8(object object_0, uint[] uint_0)
        {
            if (uint_0 == null)
            {
                return;
            }
            lock (dictionary_2)
            {
                if (!dictionary_2.TryGetValue(uint_0.Length, out var value))
                {
                    dictionary_2.Add(uint_0.Length, value = []);
                }
                value.Add(uint_0);
            }
        }
    }

    internal static int int_0;

    internal static int int_1;

    internal static int int_2;

    internal static int int_3;

    internal static int int_4;

    internal static int int_5;

    public static int int_6;

    public static int int_7;

    public static Struct21 Struct21_0 => new(0);

    public static Struct21 Struct21_1 => new(1);

    public static Struct21 Struct21_2 => new(2);

    public static Struct21 Struct21_3 => new(3);

    public static Struct21 Struct21_4 => new(4);

    public static Struct21 Struct21_5 => new(5);

    public static Struct21 Struct21_6 => new(6);

    public static Struct21 Struct21_7 => new(7);

    public static Struct21 Struct21_8 => new(8);

    public static Struct21 Struct21_9 => new(9);

    public static Struct21 Struct21_10 => new(10);

    public static Struct21 Struct21_11 => new(11);

    public static Struct21 Struct21_12 => new(12);

    public static Struct21 Struct21_13 => new(16);

    public static Struct21 Struct21_14 => new(17);

    [Conditional("SHOW_DEBUG_INFO")]
    internal static void smethod_0(string string_0, params object[] object_0)
    {
    }

    internal static void smethod_1(string string_0, params object[] object_0)
    {
    }

    internal static void smethod_2(Class53 class53_0, out Interface1 interface1_0)
    {
        if (!class53_0.bool_2)
        {
            interface1_0 = new Class55();
        }
        else if (class53_0.uint_17 == 2)
        {
            interface1_0 = new Class56();
        }
        else if (class53_0.uint_17 == 3)
        {
            interface1_0 = new Class57();
        }
        else
        {
            interface1_0 = new Class58();
        }
    }

    public static Class73 smethod_3(Class77 class77_0)
    {
        if (!class77_0.method_0<Class73>())
        {
            return null;
        }
        return new Class73();
    }

    public static Struct21 smethod_4(Struct0<byte> struct0_0, ref long long_0, Struct0<byte> struct0_1, long long_1, Class67 class67_0, Struct0<byte> struct0_2, ref long long_2, bool bool_0, Interface4 interface4_0, Class77 class77_0, Class77 class77_1)
    {
        Class73 @class = smethod_3(class77_0);
        if (@class == null)
        {
            return Struct21_2;
        }
        Struct21 @struct = @class.method_7(class67_0);
        if (Struct21.smethod_0(@struct, Struct21_0))
        {
            @struct = @class.method_8(struct0_2, ref long_2);
            if (Struct21.smethod_0(@struct, Struct21_0))
            {
                @struct = @class.method_10(struct0_0, ref long_0, struct0_1, long_1, bool_0, interface4_0, class77_0, class77_1);
            }
        }
        @class.method_6(class77_0, class77_1);
        return @struct;
    }

    public static Struct21 smethod_5(Struct0<byte> struct0_0, ref long long_0, Struct0<byte> struct0_1, long long_1, Struct0<byte> struct0_2, ref long long_2, int int_8, uint uint_0, int int_9, int int_10, int int_11, int int_12, int int_13)
    {
        Class67 @class = Class67.smethod_0();
        @class.int_0 = int_8;
        @class.uint_0 = uint_0;
        @class.int_1 = int_9;
        @class.int_2 = int_10;
        @class.int_3 = int_11;
        @class.int_5 = int_12;
        @class.int_8 = int_13;
        return smethod_4(struct0_0, ref long_0, struct0_1, long_1, @class, struct0_2, ref long_2, bool_0: false, null, Class77.class77_1, Class77.class77_0);
    }

    public static Struct21 smethod_6(Struct0<byte> struct0_0, ref long long_0, Struct0<byte> struct0_1, ref long long_1, Struct0<byte> struct0_2, long long_2)
    {
        return Class64.smethod_0(struct0_0, ref long_0, struct0_1, ref long_1, struct0_2, (uint)long_2, Enum3.const_0, out Enum4 enum4_, Class77.class77_1);
    }

    public static byte[] smethod_7(object object_0, long long_0)
    {
        return ((Class77)object_0).method_2(object_0, long_0);
    }

    public static uint[] smethod_8(object object_0, long long_0)
    {
        return ((Class77)object_0).method_4(object_0, long_0);
    }

    public static void smethod_9(object object_0, object object_1)
    {
        ((Class77)object_0).method_5(object_0, object_1);
    }

    public static void smethod_10(object object_0, byte[] byte_0)
    {
        ((Class77)object_0).method_6(object_0, byte_0);
    }

    public static void smethod_11(object object_0, uint[] uint_0)
    {
        ((Class77)object_0).method_8(object_0, uint_0);
    }
}
