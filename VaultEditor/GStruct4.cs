using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public readonly struct GStruct4 : IEquatable<GStruct4>
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int int_0;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int int_1;

    public int? Nullable_0
    {
        get
        {
            if (int_0 < 0)
            {
                return null;
            }
            return int_0;
        }
    }

    public int Int32_0 => int_1;

    public GStruct4(int? nullable_0, int int_2)
    {
        if (nullable_0 < 0)
        {
            throw new ArgumentOutOfRangeException("decoderIndex");
        }
        if (int_2 < 0)
        {
            throw new ArgumentOutOfRangeException("streamIndex");
        }
        int_0 = nullable_0 ?? (-1);
        int_1 = int_2;
    }

    public override string ToString()
    {
        if (!Nullable_0.HasValue)
        {
            return $"{{DecoderInputMetadata File Section #{Int32_0}}}";
        }
        return $"{{DecoderInputMetadata Decoder #{Nullable_0} Output #{Int32_0}}}";
    }

    public override int GetHashCode()
    {
        return (int_0 << 16) + int_1;
    }

    public override bool Equals(object obj)
    {
        if (obj is GStruct4)
        {
            return Equals((GStruct4)obj);
        }
        return false;
    }

    public bool Equals(GStruct4 other)
    {
        if (int_0 == other.int_0)
        {
            return int_1 == other.int_1;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_0(GStruct4 gstruct4_0, GStruct4 gstruct4_1)
    {
        return gstruct4_0.Equals(gstruct4_1);
    }

    [SpecialName]
    public static bool smethod_1(GStruct4 gstruct4_0, GStruct4 gstruct4_1)
    {
        return !gstruct4_0.Equals(gstruct4_1);
    }
}
