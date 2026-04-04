using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2(DataSize = 544, PreDataAlign = 16, PreAlignBlock = 128, Type = GEnum15.const_21, IsCollection = true, PostDataAlign = 32)]
internal sealed class Class138 : GClass119
{
    [CompilerGenerated]
    private byte[] byte_0;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private string string_2;

    [GAttribute3(400)]
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

    [GAttribute3(64)]
    public string T1
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

    [GAttribute3(48)]
    public string T2
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
        [CompilerGenerated]
        set
        {
            string_1 = value;
        }
    }

    [GAttribute3(32)]
    public string T3
    {
        [CompilerGenerated]
        get
        {
            return string_2;
        }
        [CompilerGenerated]
        set
        {
            string_2 = value;
        }
    }

    public override string ToString()
    {
        return T1;
    }
}
