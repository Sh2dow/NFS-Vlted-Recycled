using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass113
{
    public enum GEnum14
    {
        const_0 = 1514947658,
        const_1 = 1465336146
    }

    public sealed class GClass114
    {
        private GEnum14 genum14_0;

        private ushort ushort_0;

        private char char_0;

        [CompilerGenerated]
        private char char_1;

        [CompilerGenerated]
        private int int_0;

        [CompilerGenerated]
        private int int_1;

        public char Type
        {
            [CompilerGenerated]
            get
            {
                return char_1;
            }
            [CompilerGenerated]
            private set
            {
                char_1 = value;
            }
        }

        public int DataSize
        {
            [CompilerGenerated]
            get
            {
                return int_0;
            }
            [CompilerGenerated]
            set
            {
                int_0 = value;
            }
        }

        public int BlockSize
        {
            [CompilerGenerated]
            get
            {
                return int_1;
            }
            [CompilerGenerated]
            set
            {
                int_1 = value;
            }
        }

        public GEnum14 GEnum14_0
        {
            get
            {
                return genum14_0;
            }
            set
            {
                switch (value)
                {
                    case GEnum14.const_0:
                        Type = '\u0002';
                        break;
                    case GEnum14.const_1:
                        Type = '\u0001';
                        break;
                }
                genum14_0 = value;
            }
        }

        public GClass114()
        {
            GEnum14_0 = GEnum14.const_1;
            char_0 = '\u0010';
            ushort_0 = 0;
        }

        public void method_0(BinaryReader binaryReader_0)
        {
            GEnum14_0 = (GEnum14)binaryReader_0.ReadUInt32();
            Type = binaryReader_0.ReadChar();
            char_0 = binaryReader_0.ReadChar();
            ushort_0 = binaryReader_0.ReadUInt16();
            DataSize = binaryReader_0.ReadInt32();
            BlockSize = binaryReader_0.ReadInt32();
        }

        public void method_1(BinaryWriter binaryWriter_0)
        {
            binaryWriter_0.Write((uint)GEnum14_0);
            binaryWriter_0.Write(Type);
            binaryWriter_0.Write(char_0);
            binaryWriter_0.Write(ushort_0);
            binaryWriter_0.Write(DataSize);
            binaryWriter_0.Write(BlockSize);
        }
    }

    public static byte[] smethod_0(string string_0)
    {
        byte[] array = File.ReadAllBytes(string_0);
        BinaryReader binaryReader = new(new MemoryStream(array));
        if (array.Count() == 0)
        {
            throw new Exception("No data found");
        }
        GClass114 gClass = new();
        gClass.method_0(binaryReader);
        switch (gClass.GEnum14_0)
        {
            default:
                return null;
            case GEnum14.const_0:
                {
                    binaryReader.smethod_0(0L);
                    byte[] byte_ = binaryReader.ReadBytes(gClass.BlockSize);
                    byte[] byte_2 = new byte[gClass.DataSize];
                    smethod_1(gClass, byte_, ref byte_2);
                    FileInfo fileInfo = new(string_0);
                    if (fileInfo.IsReadOnly)
                    {
                        fileInfo.IsReadOnly = false;
                    }
                    using FileStream output = new(string_0, FileMode.Truncate);
                    BinaryWriter binaryWriter = new(output);
                    GClass114 gClass2 = new()
                    {
                        DataSize = byte_2.Length,
                        BlockSize = byte_2.Length + 16
                    };
                    gClass2.method_1(binaryWriter);
                    binaryWriter.Write(byte_2);
                    return byte_2;
                }
            case GEnum14.const_1:
                binaryReader.smethod_0(0L);
                return [.. binaryReader.ReadBytes(gClass.BlockSize).Skip(16).Take(gClass.DataSize)];
        }
    }

    public static int smethod_1(GClass114 gclass114_0, byte[] byte_0, ref byte[] byte_1)
    {
        if (gclass114_0.GEnum14_0 == GEnum14.const_0 && gclass114_0.Type == '\u0002')
        {
            int num = 0;
            int dataSize = gclass114_0.DataSize;
            short num2 = (short)((byte_0[16] & 0xFF) | 0x100);
            short num3 = (short)((byte_0[17] & 0xFF) | 0x100);
            int num4 = 18;
            int num5 = gclass114_0.BlockSize - 18;
            while (num5 != 0)
            {
                if ((num2 & 1) == 0)
                {
                    if (num < dataSize)
                    {
                        byte_1[num] = byte_0[num4];
                        num++;
                        num4++;
                    }
                    num5--;
                }
                else
                {
                    int num6 = byte_0[num4 + 1] & 0xFF;
                    int num7;
                    if ((num3 & 1) == 0)
                    {
                        num7 = (byte_0[num4] & 0x1F) + 3;
                        int num8 = (((byte_0[num4] & 0xE0) << 3) | num6) + 17;
                        int num9 = num - num8;
                        for (int i = 0; i < num7; i++)
                        {
                            byte_1[num + i] = byte_1[num9 + i];
                        }
                    }
                    else
                    {
                        num7 = (((byte_0[num4] & 0xF0) << 4) | num6) + 3;
                        int num8 = (byte_0[num4] & 0xF) + 1;
                        int num9 = num - num8;
                        for (int j = 0; j < num7; j++)
                        {
                            byte_1[num + j] = byte_1[num9 + j];
                        }
                    }
                    num3 >>= 1;
                    num4 += 2;
                    num5 -= 2;
                    num += num7;
                }
                num2 >>= 1;
                if (num2 == 1)
                {
                    num2 = (short)((byte_0[num4] & 0xFF) | 0x100);
                    num4++;
                    num5--;
                }
                if (num3 == 1)
                {
                    num3 = (short)((byte_0[num4] & 0xFF) | 0x100);
                    num4++;
                    num5--;
                }
            }
            return dataSize;
        }
        return 0;
    }
}
