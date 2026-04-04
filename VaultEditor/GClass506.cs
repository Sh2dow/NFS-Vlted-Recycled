using System;
using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

public sealed class GClass506(string string_2) : GClass500(GEnum23.const_0)
{
    private readonly string string_0 = string_2 + ".vlt";

    private readonly string string_1 = string_2 + ".bin";

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        int num = binaryReader_0.ReadInt32();
        List<uint> list = [];
        for (int i = 0; i < num; i++)
        {
            list.Add(binaryReader_0.ReadUInt32());
        }
        if (list.Count != 2)
        {
            throw new Exception();
        }
        if (list[0] != GClass486.smethod_8(string_0))
        {
            throw new Exception();
        }
        if (list[1] != GClass486.smethod_8(string_1))
        {
            throw new Exception();
        }
        List<int> list2 = [];
        for (int j = 0; j < num; j++)
        {
            list2.Add(binaryReader_0.ReadInt32());
        }
        List<string> list3 = [];
        long position = binaryReader_0.BaseStream.Position;
        for (int k = 0; k < num; k++)
        {
            binaryReader_0.smethod_0(position + list2[k]);
            list3.Add(GClass145.smethod_0(binaryReader_0));
        }
        if (list3.Count != 2)
        {
            throw new Exception();
        }
        if (list3[0] != string_0)
        {
            throw new Exception();
        }
        if (list3[1] != string_1)
        {
            throw new Exception();
        }
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(2);
        uint value = GClass486.smethod_8(string_0);
        uint value2 = GClass486.smethod_8(string_1);
        binaryWriter_0.Write(value);
        binaryWriter_0.Write(value2);
        binaryWriter_0.Write(0);
        int value3 = 0 + (string_0.Length + 1);
        binaryWriter_0.Write(value3);
        GClass145.smethod_1(binaryWriter_0, string_0);
        GClass145.smethod_1(binaryWriter_0, string_1);
    }
}
