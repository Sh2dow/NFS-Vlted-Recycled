using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VaultEditor;

internal static class Class190
{
    public static void smethod_0(this BinaryReader binaryReader_0, long long_0)
    {
        binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
    }

    public static void smethod_1(this BinaryWriter binaryWriter_0, long long_0)
    {
        binaryWriter_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
    }

    public static int smethod_2(this BinaryWriter binaryWriter_0, int int_0, char char_0)
    {
        if (int_0 > 0 && binaryWriter_0.BaseStream.Position % int_0 != 0L)
        {
            long num = int_0 - binaryWriter_0.BaseStream.Position % int_0;
            for (int i = 0; i < num; i++)
            {
                binaryWriter_0.Write(char_0);
            }
            return (int)num;
        }
        return 0;
    }

    public static int smethod_3(this BinaryReader binaryReader_0, int int_0)
    {
        if (int_0 > 0 && binaryReader_0.BaseStream.Position % int_0 != 0L)
        {
            long num = int_0 - binaryReader_0.BaseStream.Position % int_0;
            if (num != 0L)
            {
                binaryReader_0.BaseStream.Position += num;
            }
            return (int)num;
        }
        return 0;
    }

    public static void smethod_4(this BinaryReader binaryReader_0)
    {
        if (binaryReader_0.ReadInt32() != 0)
        {
            throw new Exception();
        }
        int num = binaryReader_0.ReadInt32();
        binaryReader_0.BaseStream.Position += num;
    }

    public static string smethod_5(this BinaryReader binaryReader_0, int int_0)
    {
        return Encoding.ASCII.GetString(binaryReader_0.ReadBytes(int_0)).TrimEnd(default(char));
    }

    public static bool smethod_6(this BinaryReader binaryReader_0)
    {
        Stream baseStream = binaryReader_0.BaseStream;
        return baseStream.Position == baseStream.Length;
    }

    public static void smethod_7(this BinaryReader binaryReader_0)
    {
        if (binaryReader_0.ReadUInt32() != 0)
        {
            throw new Exception();
        }
    }

    public static void smethod_8(this BinaryReader binaryReader_0, int int_0)
    {
        byte[] array = binaryReader_0.ReadBytes(int_0);
        int num = 0;
        while (true)
        {
            if (num < array.Length)
            {
                if (array[num] != 0)
                {
                    break;
                }
                num++;
                continue;
            }
            return;
        }
        throw new Exception();
    }

    public static int smethod_9(this BinaryReader binaryReader_0, GEnum15 genum15_0)
    {
        int num = binaryReader_0.ReadInt32();
        if (genum15_0 != (GEnum15)num)
        {
            throw new Exception();
        }
        return binaryReader_0.ReadInt32();
    }

    public static uint smethod_10(this BinaryReader binaryReader_0, uint? nullable_0 = 0u)
    {
        int result = (int)binaryReader_0.BaseStream.Position;
        uint num = binaryReader_0.ReadUInt32();
        if (nullable_0.HasValue)
        {
            _ = num == nullable_0;
        }
        return (uint)result;
    }

    public static uint smethod_11(this BinaryWriter binaryWriter_0, uint uint_0 = 0u)
    {
        int result = (int)binaryWriter_0.BaseStream.Position;
        binaryWriter_0.Write(uint_0);
        return (uint)result;
    }

    public static void smethod_12(this BinaryWriter binaryWriter_0, GEnum15 genum15_0, int int_0)
    {
        binaryWriter_0.Write((int)genum15_0);
        binaryWriter_0.Write(int_0);
    }

    public static void smethod_13(this BinaryWriter binaryWriter_0, int int_0 = 128)
    {
        int num = ((int)binaryWriter_0.BaseStream.Position + 8).smethod_0(int_0);
        if (num > 0)
        {
            binaryWriter_0.smethod_12(GEnum15.const_0, num);
            for (int i = 0; i < num; i++)
            {
                binaryWriter_0.Write((byte)0);
            }
        }
    }

    public static int smethod_14(this BinaryWriter binaryWriter_0, int int_0, byte byte_0 = 0)
    {
        if (int_0 > 0 && binaryWriter_0.BaseStream.Position % int_0 != 0L)
        {
            long num = int_0 - binaryWriter_0.BaseStream.Position % int_0;
            for (int i = 0; i < num; i++)
            {
                binaryWriter_0.Write(byte_0);
            }
            return (int)num;
        }
        return 0;
    }

    public static void smethod_15(this BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(0u);
    }

    public static void smethod_16(this BinaryWriter binaryWriter_0, int int_0)
    {
        for (int i = 0; i < int_0; i++)
        {
            binaryWriter_0.Write((byte)0);
        }
    }

    public static void smethod_17(this BinaryWriter binaryWriter_0, string string_0, int int_0)
    {
        List<byte> list = [.. Encoding.ASCII.GetBytes(string_0).Take(int_0)];
        for (int i = list.Count; i < int_0; i++)
        {
            list.Add(0);
        }
        binaryWriter_0.Write(list.ToArray());
    }
}
