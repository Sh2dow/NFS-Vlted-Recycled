using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace VaultEditor;

public static class GClass71
{
    private static readonly long long_0;

    public static Encoding smethod_0(string string_0)
    {
        using FileStream fileStream_ = File.OpenRead(string_0);
        return smethod_1(fileStream_, 65536L);
    }

    public static Encoding smethod_1(FileStream fileStream_0, long long_1)
    {
        return smethod_2(fileStream_0, 65536L, out bool bool_);
    }

    public static Encoding smethod_2(FileStream fileStream_0, long long_1, out bool bool_0)
    {
        long position = fileStream_0.Position;
        fileStream_0.Position = 0L;
        byte[] array = new byte[(fileStream_0.Length > 4L) ? 4L : fileStream_0.Length];
        fileStream_0.Read(array, 0, array.Length);
        Encoding encoding = smethod_3(array);
        if (encoding != null)
        {
            fileStream_0.Position = position;
            bool_0 = true;
            return encoding;
        }
        byte[] array2 = new byte[(long_1 > fileStream_0.Length) ? fileStream_0.Length : long_1];
        Array.Copy(array, array2, array.Length);
        if (fileStream_0.Length > array.Length)
        {
            fileStream_0.Read(array2, array.Length, array2.Length - array.Length);
        }
        fileStream_0.Position = position;
        encoding = smethod_4(array2);
        bool_0 = false;
        return encoding;
    }

    public static Encoding smethod_3(byte[] byte_0)
    {
        if (byte_0.Length < 2)
        {
            return null;
        }
        if (byte_0[0] == byte.MaxValue && byte_0[1] == 254 && (byte_0.Length < 4 || byte_0[2] != 0 || byte_0[3] != 0))
        {
            return Encoding.Unicode;
        }
        if (byte_0[0] == 254 && byte_0[1] == byte.MaxValue)
        {
            return Encoding.BigEndianUnicode;
        }
        if (byte_0.Length < 3)
        {
            return null;
        }
        if (byte_0[0] == 239 && byte_0[1] == 187 && byte_0[2] == 191)
        {
            return Encoding.UTF8;
        }
        if (byte_0[0] == 43 && byte_0[1] == 47 && byte_0[2] == 118)
        {
            return Encoding.UTF7;
        }
        if (byte_0.Length < 4)
        {
            return null;
        }
        if (byte_0[0] == byte.MaxValue && byte_0[1] == 254 && byte_0[2] == 0 && byte_0[3] == 0)
        {
            return Encoding.UTF32;
        }
        if (byte_0[0] == 0 && byte_0[1] == 0 && byte_0[2] == 254 && byte_0[3] == byte.MaxValue)
        {
            return Encoding.GetEncoding(12001);
        }
        return null;
    }

    public static Encoding smethod_4(byte[] byte_0)
    {
        long num = 0L;
        long num2 = 0L;
        long num3 = 0L;
        long num4 = 0L;
        long num5 = 0L;
        long num6 = 0L;
        int num7 = 0;
        for (; num6 < byte_0.Length; num6++)
        {
            if (byte_0[num6] == 0)
            {
                if (num6 % 2L == 0L)
                {
                    num2++;
                }
                else
                {
                    num++;
                }
            }
            if (smethod_5(byte_0[num6]))
            {
                num5++;
            }
            if (num7 == 0)
            {
                int num8 = smethod_6(byte_0, num6);
                if (num8 > 0)
                {
                    num3++;
                    num4 += num8;
                    num7 = num8 - 1;
                }
            }
            else
            {
                num7--;
            }
        }
        if ((double)num2 * 2.0 / (double)byte_0.Length < 0.2 && (double)num * 2.0 / (double)byte_0.Length > 0.6)
        {
            return Encoding.Unicode;
        }
        if ((double)num * 2.0 / (double)byte_0.Length < 0.2 && (double)num2 * 2.0 / (double)byte_0.Length > 0.6)
        {
            return Encoding.BigEndianUnicode;
        }
        string input = Encoding.ASCII.GetString(byte_0);
        if (new Regex("\\A([\\x09\\x0A\\x0D\\x20-\\x7E]|[\\xC2-\\xDF][\\x80-\\xBF]|\\xE0[\\xA0-\\xBF][\\x80-\\xBF]|[\\xE1-\\xEC\\xEE\\xEF][\\x80-\\xBF]{2}|\\xED[\\x80-\\x9F][\\x80-\\xBF]|\\xF0[\\x90-\\xBF][\\x80-\\xBF]{2}|[\\xF1-\\xF3][\\x80-\\xBF]{3}|\\xF4[\\x80-\\x8F][\\x80-\\xBF]{2})*\\z").IsMatch(input) && (double)num3 * 500000.0 / (double)byte_0.Length >= 1.0 && (byte_0.Length - num4 == 0L || (double)num5 * 1.0 / (double)(byte_0.Length - num4) >= 0.8))
        {
            return Encoding.UTF8;
        }
        return null;
    }

    private static bool smethod_5(byte byte_0)
    {
        switch (byte_0)
        {
            default:
                if ((byte_0 < 48 || byte_0 > 57) && (byte_0 < 58 || byte_0 > 64) && (byte_0 < 65 || byte_0 > 90) && (byte_0 < 91 || byte_0 > 96) && (byte_0 < 97 || byte_0 > 122) && (byte_0 < 123 || byte_0 > 126))
                {
                    return false;
                }
                break;
            case 9:
            case 10:
            case 13:
            case 32:
            case 33:
            case 34:
            case 35:
            case 36:
            case 37:
            case 38:
            case 39:
            case 40:
            case 41:
            case 42:
            case 43:
            case 44:
            case 45:
            case 46:
            case 47:
                break;
        }
        return true;
    }

    private static int smethod_6(byte[] byte_0, long long_1)
    {
        int result = 0;
        if (byte_0.Length >= long_1 + 1L && byte_0[long_1] == 194)
        {
            if (byte_0[long_1 + 1L] != 129 && byte_0[long_1 + 1L] != 141 && byte_0[long_1 + 1L] != 143)
            {
                if (byte_0[long_1 + 1L] != 144 && byte_0[long_1 + 1L] != 157)
                {
                    if (byte_0[long_1 + 1L] >= 160 && byte_0[long_1 + 1L] <= 191)
                    {
                        result = 2;
                    }
                }
                else
                {
                    result = 2;
                }
            }
            else
            {
                result = 2;
            }
        }
        else if (byte_0.Length >= long_1 + 1L && byte_0[long_1] == 195)
        {
            if (byte_0[long_1 + 1L] >= 128 && byte_0[long_1 + 1L] <= 191)
            {
                result = 2;
            }
        }
        else if (byte_0.Length >= long_1 + 1L && byte_0[long_1] == 197)
        {
            if (byte_0[long_1 + 1L] != 146 && byte_0[long_1 + 1L] != 147)
            {
                if (byte_0[long_1 + 1L] != 160 && byte_0[long_1 + 1L] != 161)
                {
                    if (byte_0[long_1 + 1L] == 184 || byte_0[long_1 + 1L] == 189 || byte_0[long_1 + 1L] == 190)
                    {
                        result = 2;
                    }
                }
                else
                {
                    result = 2;
                }
            }
            else
            {
                result = 2;
            }
        }
        else if (byte_0.Length >= long_1 + 1L && byte_0[long_1] == 198)
        {
            if (byte_0[long_1 + 1L] == 146)
            {
                result = 2;
            }
        }
        else if (byte_0.Length >= long_1 + 1L && byte_0[long_1] == 203)
        {
            if (byte_0[long_1 + 1L] == 134 || byte_0[long_1 + 1L] == 156)
            {
                result = 2;
            }
        }
        else if (byte_0.Length >= long_1 + 2L && byte_0[long_1] == 226)
        {
            if (byte_0[long_1 + 1L] == 128)
            {
                if (byte_0[long_1 + 2L] == 147 || byte_0[long_1 + 2L] == 148)
                {
                    result = 3;
                }
                if (byte_0[long_1 + 2L] == 152 || byte_0[long_1 + 2L] == 153 || byte_0[long_1 + 2L] == 154)
                {
                    result = 3;
                }
                if (byte_0[long_1 + 2L] == 156 || byte_0[long_1 + 2L] == 157 || byte_0[long_1 + 2L] == 158)
                {
                    result = 3;
                }
                if (byte_0[long_1 + 2L] == 160 || byte_0[long_1 + 2L] == 161 || byte_0[long_1 + 2L] == 162)
                {
                    result = 3;
                }
                if (byte_0[long_1 + 2L] == 166)
                {
                    result = 3;
                }
                if (byte_0[long_1 + 2L] == 176)
                {
                    result = 3;
                }
                if (byte_0[long_1 + 2L] == 185 || byte_0[long_1 + 2L] == 186)
                {
                    result = 3;
                }
            }
            else if (byte_0[long_1 + 1L] == 130 && byte_0[long_1 + 2L] == 172)
            {
                result = 3;
            }
            else if (byte_0[long_1 + 1L] == 132 && byte_0[long_1 + 2L] == 162)
            {
                result = 3;
            }
        }
        return result;
    }
}
