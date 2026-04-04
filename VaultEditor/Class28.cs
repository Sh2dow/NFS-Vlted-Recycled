using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace VaultEditor;

internal sealed class Class28 : Class27
{
    private sealed class Stream3 : Stream
    {
        private Class21 class21_0;

        private long long_0;

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length => long_0;

        public override long Position
        {
            get
            {
                throw new InvalidOperationException();
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        public void method_0(Class21 class21_1, long long_1)
        {
            if (class21_0 != null)
            {
                throw new InvalidOperationException();
            }
            class21_0 = class21_1 ?? throw new ArgumentNullException("stream");
            long_0 = long_1;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (class21_0 == null)
            {
                throw new InvalidOperationException();
            }
            return class21_0.vmethod_1(buffer, offset, count);
        }

        public override void Flush()
        {
            throw new InvalidOperationException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new InvalidOperationException();
        }

        public override void SetLength(long value)
        {
            throw new InvalidOperationException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new InvalidOperationException();
        }
    }

    private sealed class Class23(Class28 class28_1) : Class21
    {
        private Class28 class28_0 = class28_1;

    public override void Dispose()
        {
            class28_0 = null;
        }

        public override void vmethod_0(int int_0)
        {
            class28_0.method_0(int_0);
        }

        public override int vmethod_1(byte[] byte_0, int int_0, int int_1)
        {
            return class28_0.method_1(byte_0, int_0, int_1);
        }
    }

    private readonly Stream3 stream3_0;

    private readonly Class23 class23_0;

    private readonly long long_0;

    private long long_1;

    private Stream stream_0;

    private ICryptoTransform icryptoTransform_0;

    private byte[] byte_0;

    private long long_2;

    private long long_3;

    private int int_0;

    private int int_1;

    private int int_2;

    public Class28(byte[] byte_1, GClass1 gclass1_0, long long_4)
    {
        if (gclass1_0 == null)
        {
            throw new InvalidOperationException("Password required.");
        }
        stream3_0 = new Stream3();
        class23_0 = new Class23(this);
        long_0 = long_4;
        method_2(stream3_0, byte_1, gclass1_0, long_4);
    }

    public void Dispose()
    {
        Class19.smethod_0();
        stream_0.Dispose();
        icryptoTransform_0.Dispose();
        class23_0.Dispose();
        stream3_0?.Dispose();
    }

    public override void vmethod_0(int int_3, Class21 class21_0, long long_4)
    {
        if (int_3 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        if (class21_0 == null)
        {
            throw new ArgumentNullException("stream");
        }
        stream3_0.method_0(class21_0, long_4);
    }

    public override Class21 vmethod_1(int int_3)
    {
        if (int_3 != 0)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return class23_0;
    }

    private void method_0(int int_3)
    {
        Class19.smethod_1();
        byte[] array = new byte[Math.Min(16384, int_3)];
        while (true)
        {
            if (int_3 > 0)
            {
                int num = method_1(array, 0, Math.Min(array.Length, int_3));
                if (num == 0)
                {
                    break;
                }
                int_3 -= num;
                continue;
            }
            return;
        }
        throw new InvalidOperationException("Skipping beyond end of stream.");
    }

    private int method_1(byte[] byte_1, int int_3, int int_4)
    {
        int num = method_3(byte_1, int_3, int_4);
        long_1 += num;
        return num;
    }

    private void method_2(Stream stream_1, byte[] byte_1, GClass1 gclass1_0, long long_4)
    {
        byte_0 = new byte[4096];
        stream_0 = stream_1;
        long_3 = long_4;
        if (((int)stream_1.Length & 0xF) != 0)
        {
            throw new NotSupportedException("7z requires AES streams to be properly padded.");
        }
        method_4(byte_1, out var int_, out var byte_2, out var byte_3);
        byte[] gparam_ = null;
        byte[] gparam_2 = null;
        try
        {
            using (GStruct1 gstruct1_ = gclass1_0.method_0())
            {
                gparam_ = Encoding.Unicode.GetBytes(GStruct1.smethod_2(gstruct1_));
            }
            gparam_2 = smethod_0(int_, byte_2, gparam_);
            using Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.None;
            icryptoTransform_0 = aes.CreateDecryptor(gparam_2, byte_3);
        }
        finally
        {
            Class19.smethod_2(ref gparam_);
            Class19.smethod_2(ref gparam_2);
        }
    }

    private int method_3(byte[] byte_1, int int_3, int int_4)
    {
        if (int_4 != 0 && long_2 != long_3)
        {
            if (int_2 > 0)
            {
                return method_5(byte_1, int_3, int_4);
            }
            if (int_1 - int_0 < 16)
            {
                Buffer.BlockCopy(byte_0, int_0, byte_0, 0, int_1 - int_0);
                int_1 -= int_0;
                int_0 = 0;
                do
                {
                    int num = stream_0.Read(byte_0, int_1, byte_0.Length - int_1);
                    if (num != 0)
                    {
                        int_1 += num;
                        continue;
                    }
                    throw new EndOfStreamException();
                }
                while (int_1 - int_0 < 16);
            }
            if (int_4 > long_3 - long_2)
            {
                int_4 = (int)(long_3 - long_2);
            }
            if (int_4 < 16)
            {
                return method_5(byte_1, int_3, int_4);
            }
            if (int_4 > int_1 - int_0)
            {
                int_4 = int_1 - int_0;
            }
            int num2 = icryptoTransform_0.TransformBlock(byte_0, int_0, int_4 & -16, byte_1, int_3);
            int_0 += num2;
            long_2 += num2;
            return num2;
        }
        return 0;
    }

    private void method_4(byte[] byte_1, out int int_3, out byte[] byte_2, out byte[] byte_3)
    {
        byte b = byte_1[0];
        int_3 = b & 0x3F;
        if ((b & 0xC0) == 0)
        {
            byte_2 = [];
            byte_3 = [];
            return;
        }
        int num = (b >> 7) & 1;
        int num2 = (b >> 6) & 1;
        if (byte_1.Length == 1)
        {
            throw new InvalidDataException();
        }
        byte b2 = byte_1[1];
        num += b2 >> 4;
        num2 += b2 & 0xF;
        if (byte_1.Length < 2 + num + num2)
        {
            throw new InvalidDataException();
        }
        byte_2 = new byte[num];
        for (int i = 0; i < num; i++)
        {
            byte_2[i] = byte_1[i + 2];
        }
        byte_3 = new byte[16];
        for (int j = 0; j < num2; j++)
        {
            byte_3[j] = byte_1[j + num + 2];
        }
        if (int_3 <= 24)
        {
            return;
        }
        throw new NotSupportedException();
    }

    internal static byte[] smethod_0(int int_3, byte[] byte_1, byte[] byte_2)
    {
        if (int_3 == 63)
        {
            byte[] array = new byte[32];
            int i;
            for (i = 0; i < byte_1.Length; i++)
            {
                array[i] = byte_1[i];
            }
            for (int j = 0; j < byte_2.Length; j++)
            {
                if (i >= 32)
                {
                    break;
                }
                array[i++] = byte_2[j];
            }
            return array;
        }
        using SHA256 sHA = SHA256.Create();
        byte[] array2 = new byte[8];
        long num = 1L << int_3;
        for (long num2 = 0L; num2 < num; num2++)
        {
            sHA.TransformBlock(byte_1, 0, byte_1.Length, null, 0);
            sHA.TransformBlock(byte_2, 0, byte_2.Length, null, 0);
            sHA.TransformBlock(array2, 0, 8, null, 0);
            for (int k = 0; k < 8; k++)
            {
                if (++array2[k] != 0)
                {
                    break;
                }
            }
        }
        sHA.TransformFinalBlock(array2, 0, 0);
        return sHA.Hash;
    }

    private int method_5(byte[] byte_1, int int_3, int int_4)
    {
        if (int_2 == 0)
        {
            int inputCount = (int_1 - int_0) & -16;
            int_2 = icryptoTransform_0.TransformBlock(byte_0, int_0, inputCount, byte_0, int_0);
        }
        if (int_4 > int_2)
        {
            int_4 = int_2;
        }
        Buffer.BlockCopy(byte_0, int_0, byte_1, int_3, int_4);
        long_2 += int_4;
        int_0 += int_4;
        int_2 -= int_4;
        return int_4;
    }
}
