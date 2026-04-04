using System.IO;

namespace VaultEditor;

internal sealed class Class216
{
    public void method_0(string string_0)
    {
        method_1(string_0, "GlobalMemoryFile.bin", Class13.GlobalMemoryFile);
        method_1(string_0, "CarHeadersMemoryFile.bin", Class13.CarHeadersMemoryFile);
    }

    private void method_1(string string_0, string string_1, byte[] byte_0)
    {
        string text = Path.Combine(string_0, "GLOBAL", string_1);
        if (!File.Exists(text))
        {
            return;
        }
        string text2 = Path.ChangeExtension(text, "bak");
        if (!File.Exists(text2))
        {
            File.Copy(text, text2);
        }
        if (!File.Exists(text))
        {
            return;
        }
        using FileStream output = new(text, FileMode.Truncate, FileAccess.ReadWrite);
        new BinaryWriter(output).Write(byte_0);
    }

    private void method_2(string string_0)
    {
    }
}
