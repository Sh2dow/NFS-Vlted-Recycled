using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass525 : GInterface9
{
    [CompilerGenerated]
    private uint uint_0;

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

    public string String_0 => GClass486.smethod_5(Hash);

    public GClass525()
    {
    }

    public GClass525(uint uint_1)
    {
        Hash = uint_1;
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Hash = binaryReader_0.ReadUInt32();
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Hash);
    }

    public override string ToString()
    {
        return String_0;
    }
}
