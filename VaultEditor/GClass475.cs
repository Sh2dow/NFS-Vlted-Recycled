using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public class GClass475
{
    public static int int_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private uint uint_3;

    [CompilerGenerated]
    private uint uint_4;

    public uint CollectionClassHash
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

    public uint CollectionNameHash
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

    public uint CollectionParentHash
    {
        [CompilerGenerated]
        get
        {
            return uint_2;
        }
        [CompilerGenerated]
        set
        {
            uint_2 = value;
        }
    }

    public int ArrayIndex
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

    public bool InlineData
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public uint NameHash
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        set
        {
            uint_3 = value;
        }
    }

    public uint TypeHash
    {
        [CompilerGenerated]
        get
        {
            return uint_4;
        }
        [CompilerGenerated]
        set
        {
            uint_4 = value;
        }
    }

    public static void smethod_0(BinaryWriter binaryWriter_0, GClass154 gclass154_0)
    {
        if (gclass154_0 is GClass155)
        {
            throw new Exception();
        }
        binaryWriter_0.Write(537403413);
        binaryWriter_0.Write(gclass154_0.DataRow.ClassNameHash);
        binaryWriter_0.Write(gclass154_0.DataRow.UInt32_0);
        binaryWriter_0.Write(gclass154_0.DataRow.ParentHash);
        binaryWriter_0.Write(gclass154_0.ArrayIndex);
        binaryWriter_0.Write(!gclass154_0.Boolean_0);
        binaryWriter_0.Write(gclass154_0.Field.NameHash);
        binaryWriter_0.Write(gclass154_0.Field.TypeHash);
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        if (binaryReader_0.ReadInt32() != 537403413)
        {
            throw new Exception();
        }
        CollectionClassHash = binaryReader_0.ReadUInt32();
        CollectionNameHash = binaryReader_0.ReadUInt32();
        CollectionParentHash = binaryReader_0.ReadUInt32();
        ArrayIndex = binaryReader_0.ReadInt32();
        InlineData = binaryReader_0.ReadBoolean();
        NameHash = binaryReader_0.ReadUInt32();
        TypeHash = binaryReader_0.ReadUInt32();
    }

    public override int GetHashCode()
    {
        return (int)((((((((((((CollectionClassHash * 397) ^ CollectionNameHash) * 397) ^ CollectionParentHash) * 397) ^ (uint)ArrayIndex) * 397) ^ (uint)(!InlineData).GetHashCode()) * 397) ^ NameHash) * 397) ^ TypeHash);
    }
}
