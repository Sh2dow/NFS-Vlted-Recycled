using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class VaultDatabase
{
    [CompilerGenerated]
    private sealed class Class218
    {
        public VaultDatabase gclass478_0;

        public VaultDatabase gclass478_1;

        internal void method_0(string string_0, MemoryStream memoryStream_0)
        {
            gclass478_0.method_6(gclass478_1.Version, string_0, memoryStream_0);
        }
    }

    internal readonly IList<KeyValuePair<Class217, GClass502>> ilist_0 = [];

    [CompilerGenerated]
    private readonly IDictionary<uint, GClass536> idictionary_0;

    private GClass152 gclass152_0 = new();

    [CompilerGenerated]
    private bool bool_0;

    [CompilerGenerated]
    private GEnum1 genum1_0;

    [CompilerGenerated]
    private string string_0;

    public IDictionary<uint, GClass536> Classes
    {
        [CompilerGenerated]
        get
        {
            return idictionary_0;
        }
    }

    public bool UnsavedChanges
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

    public GEnum1 Version
    {
        [CompilerGenerated]
        get
        {
            return genum1_0;
        }
        [CompilerGenerated]
        private set
        {
            genum1_0 = value;
        }
    }

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

    public bool Boolean_0 => ilist_0.Any();

    public VaultDatabase()
    {
        idictionary_0 = new Dictionary<uint, GClass536>();
    }

    public GClass536 method_0(uint uint_0)
    {
        Classes.TryGetValue(uint_0, out var value);
        return value;
    }

    public IList<string> method_1()
    {
        return [.. ilist_0.Select(keyValuePair_0 => keyValuePair_0.Key.Path)];
    }

    public void method_2(GEnum1 genum1_1, string string_1, string string_2 = "GLOBAL", string[] string_3 = null)
    {
        if ((uint)genum1_1 > 2u && genum1_1 != GEnum1.const_9)
        {
            Version = genum1_1;
            GameFolder = string_1;
            GClass487.smethod_6(genum1_1);
            string text = Path.Combine(string_1, string_2);
            if (!Directory.Exists(text))
            {
                throw new Exception();
            }
            string_3 ??= ["attributes.bin", "commerce.bin", "fe_attrib.bin", "cars_vault.bin", "gameplay.bin"];
            string[] array = string_3;
            foreach (string path in array)
            {
                string string_4 = Path.Combine(text, path);
                method_5(genum1_1, string_4);
            }
            method_3();
        }
    }

    private void method_3()
    {
        foreach (GClass536 value in Classes.Values)
        {
            method_4(value);
        }
    }

    private void method_4(GClass536 gclass536_0)
    {
        foreach (GClass537 item in gclass536_0.IEnumerable_0)
        {
            item.method_9();
        }
        foreach (GClass537 item2 in gclass536_0.IEnumerable_0.OrderBy(gclass537_0 => gclass537_0.Text))
        {
            GClass537 gClass = item2;
            if (gClass.ParentHash == 0)
            {
                gclass536_0.Nodes.Add(item2);
            }
            else
            {
                gclass536_0.method_2(gClass.ParentHash).Nodes.Add(item2);
            }
        }
    }

    public void method_5(GEnum1 genum1_1, string string_1)
    {
        if (File.Exists(string_1))
        {
            MemoryStream stream_ = new(File.ReadAllBytes(string_1));
            method_6(genum1_1, string_1, stream_);
        }
    }

    public void method_6(GEnum1 genum1_1, string string_1, Stream stream_0)
    {
        stream_0.Seek(0L, SeekOrigin.Begin);
        BinaryReader binaryReader = new(stream_0);
        GClass479 gClass = new();
        gClass.method_0(binaryReader);
        if (gClass.Magic != GEnum16.const_2)
        {
            return;
        }
        List<GClass477> list = [];
        for (int i = 0; i < gClass.FilesCount; i++)
        {
            GClass477 gClass2 = new();
            gClass2.method_0(binaryReader);
            list.Add(gClass2);
        }
        Dictionary<int, string> dictionary = smethod_0(gClass, binaryReader);
        GClass502 gClass3 = new();
        foreach (GClass477 item in list)
        {
            int nameOffset = item.NameOffset;
            string string_2 = dictionary[nameOffset];
            binaryReader.smethod_0(item.BinOffset);
            byte[] buffer = binaryReader.ReadBytes(item.BinSize);
            binaryReader.smethod_0(item.VltOffset);
            byte[] buffer2 = binaryReader.ReadBytes(item.VltSize);
            GClass483 gClass4 = new(string_2)
            {
                BinStream = new MemoryStream(buffer),
                VltStream = new MemoryStream(buffer2)
            };
            GClass480.smethod_0(genum1_1, string_1, gClass4, Classes, gClass3);
            if (gClass4.Types != null)
            {
                gclass152_0 = gClass4.Types;
            }
        }
        FileInfo fileInfo = new(string_1);
        Class217 key = new()
        {
            Path = string_1,
            TimeStamp = fileInfo.LastWriteTime
        };
        ilist_0.Add(new KeyValuePair<Class217, GClass502>(key, gClass3));
    }

    public void method_7(bool bool_1, Func<string, string> func_0 = null, Action<string, MemoryStream> action_0 = null)
    {
        Dictionary<string, GClass483> dictionary = (from gclass537_0 in Classes.Values.SelectMany(gclass536_0 => gclass536_0.IEnumerable_0)
                                                    group gclass537_0 by gclass537_0.GroupName into igrouping_0
                                                    select new GClass483(igrouping_0.Key)
                                                    {
                                                        Rows = [.. igrouping_0]
                                                    }).ToDictionary(gclass483_0 => gclass483_0.Name, gclass483_0 => gclass483_0);
        foreach (KeyValuePair<Class217, GClass502> item4 in ilist_0)
        {
            string text = item4.Key.Path;
            if (func_0 != null)
            {
                text = func_0(text);
            }
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
            List<GClass483> list = [];
            if (fileNameWithoutExtension.smethod_3("attributes"))
            {
                GClass483 gClass = dictionary["db"];
                gClass.Classes = [.. Classes.Values];
                gClass.Types = gclass152_0;
                list.Add(gClass);
            }
            else if (fileNameWithoutExtension.smethod_3("cars_vault"))
            {
                GClass483 item = dictionary["cars"];
                list.Add(item);
            }
            else if (fileNameWithoutExtension.smethod_3("commerce"))
            {
                GClass483 item2 = dictionary["commerce"];
                list.Add(item2);
            }
            else if (fileNameWithoutExtension.smethod_3("fe_attrib"))
            {
                GClass483 item3 = dictionary["frontend"];
                list.Add(item3);
            }
            else if (fileNameWithoutExtension.smethod_3("gameplay"))
            {
                IEnumerable<GClass483> collection = dictionary.Values.Where(gclass483_0 => !gclass483_0.Name.smethod_3("db", "frontend", "cars", "commerce"));
                list.AddRange(collection);
            }
            list.Sort((gclass483_0, gclass483_1) => string.Compare(gclass483_0.Name, gclass483_1.Name, StringComparison.Ordinal));
            foreach (GClass483 item5 in list)
            {
                GClass480.smethod_1(Version, item5, item4.Value);
            }
            List<string> ilist_ = [.. list.Select(gclass483_0 => gclass483_0.Name)];
            MemoryStream memoryStream = new();
            BinaryWriter binaryWriter_ = new(memoryStream);
            IDictionary<string, int> dictionary2 = method_8(ilist_, binaryWriter_);
            MemoryStream memoryStream2 = new();
            BinaryWriter binaryWriter = new(memoryStream2);
            int num = 16 + list.Count * 20;
            num += num.smethod_0(64);
            GClass479 gClass2 = new()
            {
                Magic = GEnum16.const_2,
                FilesCount = list.Count,
                NamesLength = (int)memoryStream.Length,
                Offset = num
            };
            gClass2.method_1(binaryWriter);
            int num2 = gClass2.Offset + gClass2.NamesLength;
            num2 += num2.smethod_0(64);
            foreach (GClass483 item6 in list)
            {
                GClass477 gClass3 = new()
                {
                    NameOffset = dictionary2[item6.Name],
                    BinSize = (int)item6.BinStream.Length,
                    VltSize = (int)item6.VltStream.Length,
                    BinOffset = num2
                };
                num2 = (gClass3.VltOffset = num2 + gClass3.BinSize);
                num2 += gClass3.VltSize;
                gClass3.method_1(binaryWriter);
            }
            binaryWriter.smethod_14(64, 0);
            binaryWriter.Write(memoryStream.ToArray());
            binaryWriter.smethod_14(64, 0);
            foreach (GClass483 item7 in list)
            {
                binaryWriter.Write(item7.BinStream.ToArray());
                binaryWriter.Write(item7.VltStream.ToArray());
            }
            if (action_0 != null)
            {
                action_0(text, memoryStream2);
                continue;
            }
            if (bool_1)
            {
                GClass111.smethod_5(text);
            }
            GClass111.smethod_7(text);
            File.WriteAllBytes(text, memoryStream2.ToArray());
            if (Path.GetFileNameWithoutExtension(text).smethod_1("gameplay"))
            {
                Class219.smethod_0(text, bool_1);
            }
        }
        if (action_0 == null)
        {
            UnsavedChanges = false;
        }
        method_10();
    }

    private IDictionary<string, int> method_8(IList<string> ilist_1, BinaryWriter binaryWriter_0)
    {
        IDictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (string item in ilist_1)
        {
            int value = (int)binaryWriter_0.BaseStream.Position;
            dictionary.Add(item, value);
            binaryWriter_0.Write(item.Select(char_0 => char_0).ToArray());
            binaryWriter_0.Write((byte)0);
        }
        return dictionary;
    }

    private static Dictionary<int, string> smethod_0(GClass479 gclass479_0, BinaryReader binaryReader_0)
    {
        binaryReader_0.smethod_0(gclass479_0.Offset);
        byte[] array = binaryReader_0.ReadBytes(gclass479_0.NamesLength);
        Dictionary<int, string> dictionary = [];
        int key = 0;
        string text = "";
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                dictionary[key] = text;
                key = i + 1;
                text = "";
            }
            else
            {
                string text2 = text;
                char c = (char)array[i];
                text = text2 + c;
            }
        }
        return dictionary;
    }

    public VaultDatabase method_9()
    {
        VaultDatabase gclass478_0 = new();
        method_7(bool_1: false, null, delegate (string string_0, MemoryStream memoryStream_0)
        {
            gclass478_0.method_6(Version, string_0, memoryStream_0);
        });
        gclass478_0.method_3();
        return gclass478_0;
    }

    public void method_10()
    {
        foreach (KeyValuePair<Class217, GClass502> item in ilist_0)
        {
            Class217 key = item.Key;
            FileInfo fileInfo = new(key.Path);
            if (fileInfo.Exists)
            {
                DateTime lastWriteTime = fileInfo.LastWriteTime;
                if (lastWriteTime != key.TimeStamp)
                {
                    key.TimeStamp = lastWriteTime;
                }
            }
        }
    }
}
