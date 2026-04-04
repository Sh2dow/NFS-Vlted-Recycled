using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace VaultEditor;

internal sealed class Class211 : Class209
{
    private readonly Regex regex_0 = new("patch\\s+(?<type>\\w+)\\s+(?<file>bin|vlt):((0(x|X)(?<hex>[0-9a-fA-F]+))|(?<dec>[0-9]+))\\s+(?<value>[^#^\\s^]+)", RegexOptions.IgnoreCase);

    private readonly Regex regex_1 = new("vpak\\s+(?<vpak>[^\\s]+)\\s+(?<file>[^\\s]+)");

    private string string_0;

    private string string_1;

    private string string_2;

    [CompilerGenerated]
    private List<Class208> list_0;

    public List<Class208> ParsedEntries
    {
        [CompilerGenerated]
        get
        {
            return list_0;
        }
        [CompilerGenerated]
        set
        {
            list_0 = value;
        }
    }

    public void method_0(string string_3)
    {
        string_0 = "attributes.bin";
        string_1 = "db";
        string_2 = string_3;
        ParsedEntries = [];
        method_3();
        method_2();
    }

    private object method_1(Class208 class208_0, BinaryWriter binaryWriter_0)
    {
        string value = class208_0.Value;
        string type = class208_0.Type;
        switch (Class265.smethod_0(type))
        {
            case 132346577u:
                if (type == "int16")
                {
                    short num6 = short.Parse(value);
                    binaryWriter_0.Write(num6);
                    return num6;
                }
                goto default;
            case 64103268u:
                if (type == "int64")
                {
                    long num2 = long.Parse(value);
                    binaryWriter_0.Write(num2);
                    return num2;
                }
                goto default;
            case 1683620383u:
                if (type == "byte")
                {
                    byte b2 = byte.Parse(value);
                    binaryWriter_0.Write(b2);
                    return b2;
                }
                goto default;
            case 489901583u:
                if (type == "dword")
                {
                    uint num7 = ((!value.StartsWith("0x", StringComparison.InvariantCultureIgnoreCase)) ? Convert.ToUInt32(value) : uint.Parse(value.Substring(2), NumberStyles.HexNumber));
                    binaryWriter_0.Write(num7);
                    return num7;
                }
                goto default;
            case 398550328u:
                if (type == "string")
                {
                    return value;
                }
                goto default;
            case 2381355188u:
                if (type == "qword")
                {
                    ulong num4 = ulong.Parse(value);
                    binaryWriter_0.Write(num4);
                    return num4;
                }
                goto default;
            case 1788406269u:
                if (type == "word")
                {
                    ushort num8 = ushort.Parse(value);
                    binaryWriter_0.Write(num8);
                    return num8;
                }
                goto default;
            case 1687288466u:
                if (type == "int8")
                {
                    sbyte b = sbyte.Parse(value);
                    binaryWriter_0.Write(b);
                    return b;
                }
                goto default;
            case 4225688255u:
                if (type == "int32")
                {
                    int num5 = ((!value.StartsWith("0x", StringComparison.InvariantCultureIgnoreCase)) ? Convert.ToInt32(value) : int.Parse(value.Substring(2), NumberStyles.HexNumber));
                    binaryWriter_0.Write(num5);
                    return num5;
                }
                goto default;
            case 2797886853u:
                if (type == "float")
                {
                    float num3 = float.Parse(value);
                    binaryWriter_0.Write(num3);
                    return num3;
                }
                goto default;
            case 2699759368u:
                if (type == "double")
                {
                    double num = double.Parse(value);
                    binaryWriter_0.Write(num);
                    return num;
                }
                goto default;
            default:
                throw new InvalidDataException();
        }
    }

    private void method_2()
    {
        List<Class207> source = [.. (from class207_0 in Class206.smethod_0(string_1)
                                 orderby class207_0.OffsetStart
                                 select class207_0)];
        if (!source.Any())
        {
            throw new Exception("Required file not found: " + string_0 + ":" + string_1);
        }
        List<Class207> list = [.. (from class207_0 in source
                               where !class207_0.InlineData
                               orderby class207_0.OffsetStart
                               select class207_0)];
        List<Class207> list2 = [.. (from class207_0 in source
                                where class207_0.InlineData
                                orderby class207_0.OffsetStart
                                select class207_0)];
        List<Class208> list3 = [.. ParsedEntries.OrderBy(class208_0 => class208_0.Offset)];
        int num = 0;
        int num2 = 0;
        foreach (Class208 item in list3)
        {
            if (item.Boolean_0)
            {
                continue;
            }
            Class207 @class = null;
            if (item.IsBin)
            {
                for (int num3 = num; num3 < list.Count; num3++)
                {
                    Class207 class2 = list[num3];
                    if (item.Offset > class2.OffsetStart)
                    {
                        num = num3;
                    }
                    if (class2.method_2(item.Offset))
                    {
                        @class = class2;
                        break;
                    }
                }
            }
            else
            {
                for (int num4 = num2; num4 < list2.Count; num4++)
                {
                    Class207 class3 = list2[num4];
                    if (item.Offset > class3.OffsetStart)
                    {
                        num2 = num4;
                    }
                    if (class3.method_2(item.Offset))
                    {
                        @class = class3;
                        break;
                    }
                }
            }
            if (@class == null)
            {
                item.ValidationMessage = $"No value was found at offset {item.Offset}";
                continue;
            }
            Type type = GClass487.smethod_4(@class.TypeHash, @class.NameHash);
            IEnumerable<GClass150> enumerable = GClass108.smethod_0(type);
            GClass154 gClass = (GClass154)Activator.CreateInstance(type);
            MemoryStream memoryStream = new();
            BinaryWriter binaryWriter = new(memoryStream);
            gClass.vmethod_1(binaryWriter);
            binaryWriter.Seek(0, SeekOrigin.Begin);
            for (int num5 = 0; num5 < memoryStream.Length; num5++)
            {
                binaryWriter.Write(byte.MaxValue);
            }
            BinaryReader binaryReader = new(memoryStream);
            binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
            try
            {
                gClass.vmethod_0(binaryReader);
            }
            catch (Exception)
            {
                item.ValidationMessage = "Internal error occurred";
                continue;
            }
            IDictionary<GClass150, object> dictionary = new Dictionary<GClass150, object>();
            foreach (GClass150 item2 in enumerable)
            {
                object value = item2.method_0(gClass);
                dictionary.Add(item2, value);
            }
            object obj;
            try
            {
                binaryWriter.smethod_1(item.Offset - @class.OffsetStart);
                obj = method_1(item, binaryWriter);
            }
            catch (Exception)
            {
                item.ValidationMessage = "Unable to parse " + item.Value + " as " + item.Type;
                continue;
            }
            binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
            gClass.vmethod_0(binaryReader);
            foreach (KeyValuePair<GClass150, object> item3 in dictionary)
            {
                GClass150 key = item3.Key;
                GAttribute1 attribute = key.Attribute;
                if (!key.method_0(gClass).Equals(item3.Value))
                {
                    uint collectionClassHash = @class.CollectionClassHash;
                    uint collectionNameHash = @class.CollectionNameHash;
                    int arrayIndex = @class.ArrayIndex;
                    uint nameHash = @class.NameHash;
                    if (attribute.DataType == GEnum20.const_3 && obj is uint)
                    {
                        obj = GClass486.smethod_5((uint)obj);
                    }
                    Class259 class4 = new(collectionClassHash, collectionNameHash, arrayIndex, nameHash, attribute.Name, obj);
                    bool bool_ = GClass487.smethod_5(type);
                    class4.method_0(bool_, @class.IsArray, attribute.DataType);
                    item.Command = class4;
                }
            }
            if (item.Command == null)
            {
                item.ValidationMessage = $"No value was found at offset {item.Offset}";
            }
        }
    }

    private void method_3()
    {
        Match match = regex_1.Match(string_2);
        if (match.Success)
        {
            string_0 = Path.GetFileName(match.Groups["vpak"].Value);
            string_1 = Path.GetFileName(match.Groups["file"].Value);
        }
        foreach (Match item in regex_0.Matches(string_2))
        {
            Class208 @class = new()
            {
                ScriptTextStart = item.Index,
                ScriptTextLength = item.Length
            };
            string value = item.Groups["file"].Value;
            if (value.smethod_3("BIN"))
            {
                @class.IsBin = true;
            }
            else if (value.smethod_3("VLT"))
            {
                @class.IsBin = false;
            }
            string value2 = item.Groups["hex"].Value;
            string value3 = item.Groups["dec"].Value;
            int offset = 0;
            if (!string.IsNullOrWhiteSpace(value2))
            {
                offset = int.Parse(value2, NumberStyles.HexNumber);
            }
            else if (!string.IsNullOrWhiteSpace(value3))
            {
                offset = int.Parse(value2, NumberStyles.Integer);
            }
            @class.Offset = offset;
            string text = item.Groups["type"].Value.ToLower();
            if (!text.smethod_0("string", "float", "double", "byte", "int8", "word", "int16", "dword", "int32", "qword", "int64"))
            {
                @class.ValidationMessage = "The type of value '" + text + "' is not supported.";
            }
            string value4 = item.Groups["value"].Value;
            @class.Type = text;
            @class.Value = value4;
            ParsedEntries.Add(@class);
        }
    }
}
