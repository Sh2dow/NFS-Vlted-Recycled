using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(PreAlignBlock = 128, Type = GEnum15.const_41)]
internal sealed class Class142 : GClass119
{
    [CompilerGenerated]
    private byte[] byte_0;

    [CompilerGenerated]
    private byte[] byte_1;

    [CompilerGenerated]
    private IList<Class123> ilist_2;

    [CompilerGenerated]
    private uint uint_0;

    public byte[] Data
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

    public byte[] DecompressedData
    {
        [CompilerGenerated]
        get
        {
            return byte_1;
        }
        [CompilerGenerated]
        set
        {
            byte_1 = value;
        }
    }

    public IList<Class123> Menu
    {
        [CompilerGenerated]
        get
        {
            return ilist_2;
        }
        [CompilerGenerated]
        set
        {
            ilist_2 = value;
        }
    }

    [TypeConverter(typeof(GClass531))]
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

    public void imethod_3(BinaryReader binaryReader_0, int int_1)
    {
        Menu = [];
        Data = binaryReader_0.ReadBytes(int_1);
        BinaryReader binaryReader = new(new MemoryStream(Data));
        Hash = binaryReader.ReadUInt32();
        MemoryStream memoryStream = GClass481.smethod_0(binaryReader);
        DecompressedData = memoryStream.ToArray();
        BinaryReader binaryReader_1 = new(memoryStream);
        method_4(binaryReader_1);
        binaryReader.smethod_3(4);
    }

    private void method_4(BinaryReader binaryReader_0)
    {
        if (binaryReader_0.ReadUInt32() != 3882763590u)
        {
            throw new Exception();
        }
        binaryReader_0.ReadInt32();
        if ((long)binaryReader_0.ReadUInt32() != 1682467664L)
        {
            throw new Exception();
        }
        binaryReader_0.ReadInt32();
        binaryReader_0.ReadInt16();
        short num = binaryReader_0.ReadInt16();
        binaryReader_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            Class123 @class = new()
            {
                Unk = binaryReader_0.ReadUInt32()
            };
            Menu.Add(@class);
        }
        foreach (Class123 item in Menu)
        {
            item.NameLength = binaryReader_0.ReadInt32();
        }
        foreach (Class123 item2 in Menu)
        {
            item2.MenuName = binaryReader_0.smethod_5(item2.NameLength);
        }
    }

    public override string ToString()
    {
        Class123 @class = Menu.FirstOrDefault();
        object obj;
        if (@class == null)
        {
            obj = null;
        }
        else
        {
            obj = @class.MenuName;
            if (obj != null)
            {
                goto IL_0020;
            }
        }
        obj = string.Empty;
        goto IL_0020;
    IL_0020:
        return (string)obj;
    }

    public void imethod_4(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Data);
    }

    public void imethod_6(string string_0)
    {
        File.WriteAllBytes(string_0, DecompressedData);
    }
}
