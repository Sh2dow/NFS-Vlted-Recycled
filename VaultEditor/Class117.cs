using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class117
{
    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private string string_1;

    public string GameFolder
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        private set
        {
            string_0 = value;
        }
    }

    public string GameExeFileName
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
        [CompilerGenerated]
        private set
        {
            string_1 = value;
        }
    }

    public string String_0 => Path.Combine(GameFolder, GameExeFileName);

    public GEnum1 method_0(string string_2)
    {
        GameFolder = string_2;
        GameExeFileName = string.Empty;
        List<string> list = [.. Directory.GetFiles(string_2, "*.exe", SearchOption.TopDirectoryOnly).Select(Path.GetFileNameWithoutExtension)];
        if (list.Count == 0)
        {
            throw new Exception0("Executable file (for example speed.exe) can not be found");
        }
        string path = Path.Combine(string_2, "TRACKS");
        string path2 = Path.Combine(string_2, "TracksHigh");
        List<string> list2 = [];
        if (Directory.Exists(path))
        {
            List<string> collection = [.. Directory.GetFiles(path, "STREAM*.BUN", SearchOption.TopDirectoryOnly).Select(Path.GetFileNameWithoutExtension)];
            list2.AddRange(collection);
        }
        if (Directory.Exists(path2))
        {
            List<string> collection2 = [.. Directory.GetFiles(path2, "STREAM*.BUN", SearchOption.TopDirectoryOnly).Select(Path.GetFileNameWithoutExtension)];
            list2.AddRange(collection2);
        }
        if (list2.Count == 0)
        {
            throw new Exception0("Tracks or TracksHigh folder can not be found");
        }
        if (list.Any(text => text.smethod_3("speed")) && list2.Any(text => text.smethod_2("STREAML1R")))
        {
            GameExeFileName = "speed.exe";
            return GEnum1.const_1;
        }
        if (list.Any(text => text.smethod_3("speed")) && list2.Any(text => text.smethod_2("STREAML4R")))
        {
            GameExeFileName = "speed2.exe";
            return GEnum1.const_2;
        }
        if (list.Any(text => text.smethod_3("speed")) && list2.Any(text => text.smethod_2("STREAML2R")))
        {
            GameExeFileName = "speed.exe";
            return GEnum1.const_3;
        }
        if (list.Any(text => text.smethod_3("nfsc")) && list2.Any(text => text.smethod_2("STREAML5R")))
        {
            GameExeFileName = "nfsc.exe";
            return GEnum1.const_4;
        }
        if (list.Any(text => text.smethod_3("nfs")) && list2.Any(text => text.smethod_2("STREAML6R")))
        {
            GameExeFileName = "nfs.exe";
            return GEnum1.const_5;
        }
        if (list.Any(text => text.smethod_3("nfs")) && list2.Any(text => text.smethod_2("STREAML8R")))
        {
            GameExeFileName = "nfs.exe";
            return GEnum1.const_6;
        }
        if (list.Any(text => text.smethod_3("nfswo")) && list2.Any(text => text.smethod_2("STREAML5R")))
        {
            GameExeFileName = "nfswo.exe";
            return GEnum1.const_8;
        }
        if (list.Any(text => text.smethod_3("nfsw")) && list2.Any(text => text.smethod_2("STREAML5R")))
        {
            GameExeFileName = "nfsw.exe";
            return GEnum1.const_7;
        }
        return GEnum1.const_0;
    }
}
