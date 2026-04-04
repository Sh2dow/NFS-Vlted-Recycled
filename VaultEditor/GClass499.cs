using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass499 : GInterface6
{
    private string string_0;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("String")]
    public string String_0
    {
        get
        {
            return string_0;
        }
        set
        {
            GeneratePointer = true;
            string_0 = value;
        }
    }

    public uint Value
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

    public bool GeneratePointer
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        private set
        {
            bool_0 = value;
        }
    }

    public uint Pointer
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        private set
        {
            uint_1 = value;
        }
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Pointer = (uint)binaryReader_0.BaseStream.Position;
        Value = binaryReader_0.ReadUInt32();
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        Pointer = binaryWriter_0.smethod_11(Value);
    }

    public override string ToString()
    {
        return String_0;
    }
}
