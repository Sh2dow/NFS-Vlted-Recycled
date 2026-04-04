using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

internal static class Class206
{
    public static HashSet<Class207> smethod_0(string string_0)
    {
        MemoryStream memoryStream = new(Class13.mw_db);
        GClass4 gClass = new GClass21
        {
            EnablePosixFileAttributeExtension = true
        }.method_29(memoryStream);
        for (int i = 0; i < gClass.Metadata.DecoderSections.Count; i++)
        {
            using GClass23 gClass2 = new(memoryStream, gClass.Metadata, i, null);
            List<GClass6> list = gClass.method_0(i);
            while (gClass2.Int32_1 < gClass2.Int32_0)
            {
                GClass6 gClass3 = list[gClass2.Int32_1];
                if (gClass3 == null || !(gClass3.Name.ToLower() == string_0.ToLower()))
                {
                    gClass2.method_1();
                    continue;
                }
                Stream stream = gClass2.method_0();
                MemoryStream memoryStream2 = new();
                stream.CopyTo(memoryStream2);
                List<Class207> list2 = [];
                BinaryReader binaryReader = new(memoryStream2);
                binaryReader.BaseStream.Position = 0L;
                while (binaryReader.BaseStream.Position != gClass3.Length)
                {
                    Class207 @class = new();
                    @class.method_0(binaryReader);
                    @class.method_1(binaryReader);
                    list2.Add(@class);
                }
                HashSet<Class207> hashSet = [];
                hashSet.UnionWith(list2);
                return hashSet;
            }
        }
        return null;
    }
}
