using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class116
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private string string_0;

    public uint NumStringRecords
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

    public uint StringRecordTablePos
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

    public uint StringTablePos
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

    public string StringCategory
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
        NumStringRecords = binaryReader_0.ReadUInt32();
        StringRecordTablePos = binaryReader_0.ReadUInt32();
        StringTablePos = binaryReader_0.ReadUInt32();
        StringCategory = string.Concat(binaryReader_0.ReadChars(16));
    }
}
