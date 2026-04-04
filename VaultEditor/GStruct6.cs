using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public readonly struct GStruct6 : IEquatable<GStruct6>
{
    private static readonly int int_0;

    private static readonly int int_1;

    private static readonly int int_2;

    private static readonly int int_3;

    private static readonly int int_4;

    private static readonly int int_5;

    private static readonly int int_6;

    private readonly int int_7;

    private static byte[] Byte_0 => new byte[1];

    private static byte[] Byte_1 => [3];

    private static byte[] Byte_2 => [33];

    private static byte[] Byte_3 => [3, 1, 1];

    private static byte[] Byte_4 => [4, 1, 8];

    private static byte[] Byte_5 => [4, 2, 2];

    private static byte[] Byte_6 => [6, 241, 7, 1];

    public static GStruct6 GStruct6_0 => default;

    public static GStruct6 GStruct6_1 => new(0);

    public static GStruct6 GStruct6_2 => new(3);

    public static GStruct6 GStruct6_3 => new(33);

    public static GStruct6 GStruct6_4 => new(196865);

    public static GStruct6 GStruct6_5 => new(262408);

    public static GStruct6 GStruct6_6 => new(262658);

    public static GStruct6 GStruct6_7 => new(116459265);

    public bool Boolean_0 => int_7 == 0;

    private GStruct6(int int_8)
    {
        int_7 = ~int_8;
    }

    internal static GStruct6 smethod_0(int int_8)
    {
        return int_8 switch
        {
            0 or 3 or 33 or 196865 or 262408 or 262658 or 116459265 => new GStruct6(int_8),
            _ => GStruct6_0,
        };
    }

    internal byte[] method_0()
    {
        return ~int_7 switch
        {
            33 => Byte_2,
            3 => Byte_1,
            0 => Byte_0,
            262408 => Byte_4,
            196865 => Byte_3,
            116459265 => Byte_6,
            262658 => Byte_5,
            _ => throw new InvalidOperationException(),
        };
    }

    internal void method_1(int int_8, int int_9)
    {
        switch (~int_7)
        {
            case 0:
            case 33:
            case 196865:
            case 262408:
            case 116459265:
                if (int_8 != 1)
                {
                    throw new InvalidDataException();
                }
                if (int_9 != 1)
                {
                    throw new InvalidDataException();
                }
                break;
            default:
                throw new InvalidDataException();
            case 3:
            case 262658:
                throw new NotImplementedException();
        }
    }

    internal int method_2()
    {
        return ~int_7 switch
        {
            3 or 262658 => throw new NotImplementedException(),
            0 or 33 or 196865 or 262408 or 116459265 => 1,
            _ => throw new Exception1(),
        };
    }

    internal int method_3()
    {
        return ~int_7 switch
        {
            3 or 262658 => throw new NotImplementedException(),
            0 or 33 or 196865 or 262408 or 116459265 => 1,
            _ => throw new InvalidOperationException(),
        };
    }

    internal Class27 method_4(byte[] byte_0, IList<GStruct5> ilist_0, GClass1 gclass1_0)
    {
        return ~int_7 switch
        {
            33 => new Class30(byte_0, ilist_0.Single().Length),
            0 => new Class29(byte_0, ilist_0.Single().Length),
            196865 => new Class31(byte_0, ilist_0.Single().Length),
            3 or 262408 or 262658 => throw new NotImplementedException(),
            116459265 => new Class28(byte_0, gclass1_0, ilist_0.Single().Length),
            _ => throw new InvalidDataException(),
        };
    }

    public override string ToString()
    {
        return ~int_7 switch
        {
            33 => "LZMA2",
            3 => "Delta",
            0 => "Copy",
            262408 => "Deflate",
            196865 => "LZMA",
            116459265 => "AES",
            262658 => "BZip2",
            _ => "Undefined",
        };
    }

    public override int GetHashCode()
    {
        return int_7;
    }

    public override bool Equals(object obj)
    {
        if (obj is GStruct6)
        {
            return ((GStruct6)obj).int_7 == int_7;
        }
        return false;
    }

    public bool Equals(GStruct6 other)
    {
        return int_7 == other.int_7;
    }

    [SpecialName]
    public static bool smethod_1(GStruct6 gstruct6_0, GStruct6 gstruct6_1)
    {
        return gstruct6_0.int_7 == gstruct6_1.int_7;
    }

    [SpecialName]
    public static bool smethod_2(GStruct6 gstruct6_0, GStruct6 gstruct6_1)
    {
        return gstruct6_0.int_7 != gstruct6_1.int_7;
    }
}
