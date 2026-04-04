using System;
using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

public sealed class GClass27 : GClass26
{
    private struct Struct5
    {
        public string string_0;

        public bool bool_0;

        public bool bool_1;

        public bool bool_2;

        public long long_0;

        public GStruct0? nullable_0;

        public GEnum3? nullable_1;

        public DateTime? nullable_2;

        public DateTime? nullable_3;

        public DateTime? nullable_4;
    }

    private readonly DateTimeKind dateTimeKind_0;

    private readonly List<Struct5> list_0 = [];

    public GClass27()
    {
    }

    public GClass27(DateTimeKind dateTimeKind_1)
    {
        if ((uint)dateTimeKind_1 > 2u)
        {
            throw new ArgumentOutOfRangeException("unspecifiedDateTimeKind");
        }
        dateTimeKind_0 = dateTimeKind_1;
    }

    private void method_0(ref string string_0)
    {
        if (string.IsNullOrEmpty(string_0))
        {
            throw new InvalidOperationException("Name cannot be empty.");
        }
        string_0 = string_0.Replace('\\', '/');
        Class19.smethod_0();
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int num = 0;
        while (true)
        {
            int num2 = string_0.IndexOf('/', num);
            string obj = ((num2 >= 0) ? string_0.Substring(num, num2 - num) : string_0.Substring(num));
            if (!string.IsNullOrEmpty(obj))
            {
                if (!(obj == "."))
                {
                    if (!(obj == ".."))
                    {
                        if (obj.IndexOfAny(invalidFileNameChars) < 0)
                        {
                            if (num2 >= 0)
                            {
                                num = num2 + 1;
                                continue;
                            }
                            break;
                        }
                        throw new InvalidOperationException("Name contains invalid characters.");
                    }
                    throw new InvalidOperationException("Relative path component '..' is not allowed.");
                }
                throw new InvalidOperationException("Relative path component '.' is not allowed.");
            }
            throw new InvalidOperationException("Name contains empty path component.");
        }
    }

    private void method_1(ref GEnum3? nullable_0, bool bool_0)
    {
        if (!nullable_0.HasValue)
        {
            return;
        }
        if (bool_0)
        {
            if ((nullable_0.Value & (GEnum3)16) != GEnum3.flag_0)
            {
                throw new InvalidOperationException("Directory attribute cannot be set on a file.");
            }
        }
        else
        {
            nullable_0 = nullable_0.Value | (GEnum3)16;
        }
        GEnum3? gEnum = (GEnum3?)((uint?)nullable_0 & 0xFFFD0008u);
        if (!((gEnum.GetValueOrDefault() == GEnum3.flag_0) & gEnum.HasValue))
        {
            throw new InvalidOperationException("Invalid attributes have been set.");
        }
        gEnum = (GEnum3?)((uint?)nullable_0 & 0x4640u);
        if (!((gEnum.GetValueOrDefault() == GEnum3.flag_0) & gEnum.HasValue))
        {
            throw new InvalidOperationException("Some attributes are set which should not be present in a 7z archive.");
        }
        nullable_0 = nullable_0.Value & (GEnum3)(-170113);
    }

    private void method_2(ref DateTime? nullable_0)
    {
        if (!nullable_0.HasValue)
        {
            return;
        }
        DateTimeKind kind = nullable_0.Value.Kind;
        if (kind == DateTimeKind.Unspecified)
        {
            if (dateTimeKind_0 == DateTimeKind.Unspecified)
            {
                throw new InvalidOperationException("You did not specify how to treat DateTime values which do not provide their own DateTimeKind.");
            }
            kind = dateTimeKind_0;
            nullable_0 = new DateTime(nullable_0.Value.Ticks, kind);
        }
        if (kind == DateTimeKind.Local)
        {
            nullable_0 = nullable_0.Value.ToUniversalTime();
        }
    }

    public void method_3(string string_0, long long_0, GStruct0? nullable_0, FileAttributes? nullable_1, DateTime? nullable_2, DateTime? nullable_3, DateTime? nullable_4)
    {
        GEnum3? nullable_5 = null;
        if (nullable_1.HasValue)
        {
            nullable_5 = (GEnum3)nullable_1.Value;
        }
        method_4(string_0, long_0, nullable_0, nullable_5, nullable_2, nullable_3, nullable_4);
    }

    public void method_4(string string_0, long long_0, GStruct0? nullable_0, GEnum3? nullable_1, DateTime? nullable_2, DateTime? nullable_3, DateTime? nullable_4)
    {
        if (long_0 < 0L)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        method_0(ref string_0);
        method_1(ref nullable_1, bool_0: true);
        method_2(ref nullable_2);
        method_2(ref nullable_3);
        method_2(ref nullable_4);
        list_0.Add(new Struct5
        {
            string_0 = string_0,
            bool_0 = true,
            bool_1 = false,
            bool_2 = false,
            long_0 = long_0,
            nullable_0 = nullable_0,
            nullable_1 = nullable_1,
            nullable_2 = nullable_2,
            nullable_3 = nullable_3,
            nullable_4 = nullable_4
        });
    }

    public void method_5(string string_0, FileAttributes? nullable_0, DateTime? nullable_1, DateTime? nullable_2, DateTime? nullable_3)
    {
        GEnum3? nullable_4 = null;
        if (nullable_0.HasValue)
        {
            nullable_4 = (GEnum3)nullable_0.Value;
        }
        method_6(string_0, nullable_4, nullable_1, nullable_2, nullable_3);
    }

    public void method_6(string string_0, GEnum3? nullable_0, DateTime? nullable_1, DateTime? nullable_2, DateTime? nullable_3)
    {
        method_0(ref string_0);
        method_1(ref nullable_0, bool_0: false);
        method_2(ref nullable_1);
        method_2(ref nullable_2);
        method_2(ref nullable_3);
        Class19.smethod_0();
        list_0.Add(new Struct5
        {
            string_0 = string_0,
            bool_1 = true,
            nullable_1 = nullable_0
        });
    }

    public void method_7(string string_0)
    {
        method_0(ref string_0);
        list_0.Add(new Struct5
        {
            string_0 = string_0,
            bool_2 = true
        });
    }

    public void method_8(string string_0)
    {
        method_0(ref string_0);
        list_0.Add(new Struct5
        {
            string_0 = string_0,
            bool_1 = true,
            bool_2 = true
        });
    }

    public override int vmethod_0()
    {
        return list_0.Count;
    }

    public override string vmethod_1(int int_0)
    {
        return list_0[int_0].string_0;
    }

    public override bool vmethod_2(int int_0)
    {
        return list_0[int_0].bool_0;
    }

    public override bool vmethod_3(int int_0)
    {
        return list_0[int_0].bool_1;
    }

    public override bool vmethod_4(int int_0)
    {
        return list_0[int_0].bool_2;
    }

    public override long vmethod_5(int int_0)
    {
        return list_0[int_0].long_0;
    }

    public override GStruct0? vmethod_6(int int_0)
    {
        return list_0[int_0].nullable_0;
    }

    public override GEnum3? vmethod_7(int int_0)
    {
        return list_0[int_0].nullable_1;
    }

    public override DateTime? vmethod_8(int int_0)
    {
        return list_0[int_0].nullable_2;
    }

    public override DateTime? vmethod_9(int int_0)
    {
        return list_0[int_0].nullable_3;
    }

    public override DateTime? vmethod_10(int int_0)
    {
        return list_0[int_0].nullable_4;
    }
}
