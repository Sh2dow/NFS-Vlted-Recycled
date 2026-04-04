using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace VaultEditor;

public sealed class GClass307 : GClass154
{
    private static readonly string string_0;

    private byte[] byte_0;

    [GAttribute1("DataType", ReadOnly = true)]
    public string String_0 => GClass486.smethod_5(base.Field.TypeHash);

    [GAttribute1("Length", ReadOnly = true)]
    public ushort UInt16_0 => base.Field.Length;

    [GAttribute1("Data")]
    public string String_1
    {
        get
        {
            return method_5(byte_0);
        }
        set
        {
            byte_0 = method_4(value);
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        byte_0 = binaryReader_0.ReadBytes(UInt16_0);
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(byte_0);
    }

    public byte[] method_4(string string_1)
    {
        if (byte_0 == null)
        {
            throw new Exception("This value cannot be changed.");
        }
        byte[] array;
        try
        {
            array = [.. (from s in string_1.Split([' '], StringSplitOptions.RemoveEmptyEntries)
                     select byte.Parse(s, NumberStyles.HexNumber))];
        }
        catch (Exception)
        {
            throw new Exception("String cannot be parsed to hex values");
        }
        if (array.Length != UInt16_0)
        {
            throw new Exception("Length does not match");
        }
        return array;
    }

    public string method_5(byte[] byte_1)
    {
        if (byte_0 == null)
        {
            return "[invalid data]";
        }
        return string.Join(" ", [.. byte_0.Select(b => b.ToString("X2"))]);
    }

    public override string ToString()
    {
        return base.ToString() ?? "";
    }
}
