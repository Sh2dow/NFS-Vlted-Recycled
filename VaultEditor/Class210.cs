using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace VaultEditor;

internal sealed class Class210 : Class209
{
    private sealed class Class213
    {
        [CompilerGenerated]
        private uint uint_0;

        [CompilerGenerated]
        private uint uint_1;

        [CompilerGenerated]
        private string string_0;

        public uint Magic
        {
            [CompilerGenerated]
            get
            {
                return uint_0;
            }
            [CompilerGenerated]
            set
            {
                uint_0 = value;
            }
        }

        public uint Version
        {
            [CompilerGenerated]
            get
            {
                return uint_1;
            }
            [CompilerGenerated]
            set
            {
                uint_1 = value;
            }
        }

        public string CreatedBy
        {
            [CompilerGenerated]
            get
            {
                return string_0;
            }
            [CompilerGenerated]
            set
            {
                string_0 = value;
            }
        }

        public void method_0(BinaryReader binaryReader_0)
        {
            Magic = binaryReader_0.ReadUInt32();
            Version = binaryReader_0.ReadUInt32();
            CreatedBy = Encoding.UTF8.GetString(binaryReader_0.ReadBytes(16));
        }

        public void method_1(BinaryWriter binaryWriter_0)
        {
            throw new NotImplementedException();
        }
    }

    private sealed class Class214
    {
        public readonly float[] float_0 = new float[16];

        public readonly byte[] byte_0 = new byte[6];

        public readonly byte[] byte_1 = new byte[6];

        [CompilerGenerated]
        private uint uint_0;

        public uint Hash
        {
            [CompilerGenerated]
            get
            {
                return uint_0;
            }
            [CompilerGenerated]
            set
            {
                uint_0 = value;
            }
        }

        public void method_0(BinaryReader binaryReader_0)
        {
            for (int i = 0; i < float_0.Length; i++)
            {
                float_0[i] = binaryReader_0.ReadSingle();
            }
            for (int j = 0; j < byte_0.Length; j++)
            {
                byte_0[j] = binaryReader_0.ReadByte();
            }
            for (int k = 0; k < byte_1.Length; k++)
            {
                byte_1[k] = binaryReader_0.ReadByte();
            }
            Hash = binaryReader_0.ReadUInt32();
        }

        public void method_1(BinaryWriter binaryWriter_0)
        {
            throw new NotImplementedException();
        }
    }

    public Class262<List<GClass541>> method_0(VaultDatabase gclass478_0, string string_0)
    {
        BinaryReader binaryReader = new(new MemoryStream(File.ReadAllBytes(string_0)));
        Class213 @class = new();
        @class.method_0(binaryReader);
        Class262<List<GClass541>> class2 = new();
        if (@class.Magic != 1195787075)
        {
            class2.method_1("Invalid file type.");
            return class2;
        }
        if (@class.Version != 1)
        {
            class2.method_1($"Unsupported version: {@class.Version}");
            return class2;
        }
        int count = (int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position);
        byte[] array = binaryReader.ReadBytes(count);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= 172;
        }
        byte[] array2 = new byte[84];
        GClass481.smethod_1(array, array2);
        BinaryReader binaryReader_ = new(new MemoryStream(array2));
        Class214 class3 = new();
        class3.method_0(binaryReader_);
        string string_1 = GClass486.smethod_7(class3.Hash).ToLower();
        uint uint_ = GClass486.smethod_8("ecar");
        uint uint_2 = GClass486.smethod_8(string_1);
        List<GClass541> list = [];
        for (int j = 0; j < class3.byte_1.Length; j++)
        {
            uint uint_3 = GClass486.smethod_8("KitWheelOffsetFront");
            byte b = class3.byte_1[j];
            Class259 item = new(uint_, uint_2, j, uint_3, "Value", b);
            list.Add(item);
        }
        for (int k = 0; k < class3.byte_0.Length; k++)
        {
            uint uint_4 = GClass486.smethod_8("KitWheelOffsetRear");
            byte b2 = class3.byte_1[k];
            Class259 item2 = new(uint_, uint_2, k, uint_4, "Value", b2);
            list.Add(item2);
        }
        string[] array3 = ["X", "Y", "Z", "W"];
        int num = 0;
        int num2 = 0;
        float[] float_ = class3.float_0;
        foreach (float num3 in float_)
        {
            uint uint_5 = GClass486.smethod_8("TireOffsets");
            string string_2 = array3[num2];
            Class259 item3 = new(uint_, uint_2, num, uint_5, string_2, num3);
            list.Add(item3);
            num2++;
            if (num2 == 4)
            {
                num2 = 0;
                num++;
            }
        }
        class2.Value = list;
        return class2;
    }
}
