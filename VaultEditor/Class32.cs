using System.IO;

namespace VaultEditor;

internal sealed class Class32(Stream stream_1)
{
    private readonly Stream stream_0 = stream_1;

    public int method_0(long long_0, byte[] byte_0, int int_0, int int_1)
    {
        stream_0.Position = long_0;
        return stream_0.Read(byte_0, int_0, int_1);
    }
}
