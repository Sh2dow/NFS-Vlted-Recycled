using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace VaultEditor;

[GAttribute2(Type = GEnum15.const_10)]
internal sealed class Class131 : GClass119
{
    [CompilerGenerated]
    private List<string> list_0;

    [CompilerGenerated]
    private byte[] byte_0;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public List<string> Names
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

    public byte[] RawData
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    public void imethod_3(BinaryReader binaryReader_0, int int_1)
    {
        byte[] bytes = (RawData = binaryReader_0.ReadBytes(int_1));
        Names = [.. (from string_0 in Encoding.Default.GetString(bytes).Split(new char[1], StringSplitOptions.RemoveEmptyEntries)
                 select string_0.Trim())];
        foreach (string name in Names)
        {
            GClass486.smethod_9(name);
        }
    }

    public void imethod_4(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(RawData);
    }
}
