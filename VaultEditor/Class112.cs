using System;
using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

internal sealed class Class112
{
    public IDictionary<uint, string> method_0(string string_0)
    {
        Path.GetFileNameWithoutExtension(string_0).Contains("_");
        return new Dictionary<uint, string>();
    }

    private IDictionary<uint, string> method_1(string string_0)
    {
        Class113 @class = new();
        BinaryReader binaryReader_ = new(new MemoryStream(File.ReadAllBytes(string_0)));
        @class.method_0(binaryReader_);
        if (@class.ChunkId != 233472)
        {
            throw new Exception("Invalid file format");
        }
        return method_2(binaryReader_);
    }

    private IDictionary<uint, string> method_2(BinaryReader binaryReader_0)
    {
        IDictionary<uint, string> dictionary = new Dictionary<uint, string>();
        Class116 @class = new();
        @class.method_0(binaryReader_0);
        uint numStringRecords = @class.NumStringRecords;
        uint num = 8 + @class.StringRecordTablePos;
        uint num2 = 8 + @class.StringTablePos;
        for (uint num3 = 0u; num3 < numStringRecords; num3++)
        {
            num += 16;
            binaryReader_0.BaseStream.Seek(num, SeekOrigin.Begin);
            Class114 class2 = new();
            class2.method_0(binaryReader_0);
            uint num4 = num2 + class2.Offset;
            binaryReader_0.BaseStream.Seek(num4, SeekOrigin.Begin);
            string value = GClass145.smethod_0(binaryReader_0);
            dictionary[class2.Hash] = value;
        }
        return dictionary;
    }
}
