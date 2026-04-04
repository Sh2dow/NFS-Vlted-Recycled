using System.IO;

namespace VaultEditor;

internal sealed class Class219
{
    public static void smethod_0(string string_0, bool bool_0)
    {
        string text = Path.ChangeExtension(string_0, ".lzc");
        if (File.Exists(text))
        {
            if (bool_0)
            {
                GClass111.smethod_5(text, bool_0: true);
            }
            GClass111.smethod_7(text);
        }
        byte[] array = File.ReadAllBytes(string_0);
        GClass482 gClass = new()
        {
            DataSize = array.Length
        };
        gClass.BlockSize = array.Length + gClass.Int32_0;
        using FileStream output = new(text, FileMode.Create, FileAccess.ReadWrite);
        BinaryWriter binaryWriter = new(output);
        binaryWriter.smethod_1(0L);
        gClass.method_1(binaryWriter);
        binaryWriter.Write(array);
    }
}
