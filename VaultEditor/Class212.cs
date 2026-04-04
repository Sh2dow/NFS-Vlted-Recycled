using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

internal sealed class Class212(Form form_1) : Class209
{
    public sealed class Class215
    {
        [CompilerGenerated]
        private GClass475 gclass475_0;

        [CompilerGenerated]
        private GClass154 gclass154_0;

        [CompilerGenerated]
        private List<GClass541> list_0;

        [CompilerGenerated]
        private bool bool_0;

        public GClass475 Header
        {
            [CompilerGenerated]
            get
            {
                return gclass475_0;
            }
            [CompilerGenerated]
            set
            {
                gclass475_0 = value;
            }
        }

        public GClass154 Item
        {
            [CompilerGenerated]
            get
            {
                return gclass154_0;
            }
            [CompilerGenerated]
            set
            {
                gclass154_0 = value;
            }
        }

        public List<GClass541> Commands
        {
            [CompilerGenerated]
            get
            {
                return list_0;
            }
            [CompilerGenerated]
            set
            {
                list_0 = value;
            }
        }

        public bool IsValid
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

        public Class215()
        {
            Commands = [];
        }

        public void method_0(BinaryReader binaryReader_0)
        {
            Header = new GClass475();
            Header.method_0(binaryReader_0);
            Type type = GClass487.smethod_4(Header.TypeHash, Header.NameHash);
            Item = (GClass154)Activator.CreateInstance(type);
            Item.vmethod_0(binaryReader_0);
        }

        public bool method_1(Class215 class215_0)
        {
            return class215_0.Header.NameHash == Header.CollectionParentHash;
        }
    }

    private readonly Form form_0 = form_1;

    private static readonly string string_0;

    private static readonly uint uint_0;

    public void method_0(IEnumerable<GClass154> ienumerable_0, string string_1)
    {
        HashSet<GClass154> hashSet = [];
        hashSet.UnionWith(ienumerable_0);
        using MemoryStream memoryStream = new();
        BinaryWriter binaryWriter = new(memoryStream);
        binaryWriter.Write("NFS Mod Installer Configuration File by nfsu360");
        binaryWriter.Write(538248724u);
        int num = 0;
        foreach (GClass154 item in hashSet)
        {
            if (item is GClass155)
            {
                GClass155 gClass = item as GClass155;
                num += gClass.Int32_0;
            }
            else
            {
                num++;
            }
        }
        binaryWriter.Write(num);
        foreach (GClass154 item2 in hashSet)
        {
            if (item2 is GClass155)
            {
                foreach (GClass154 item3 in item2 as GClass155)
                {
                    GClass475.smethod_0(binaryWriter, item3);
                    item3.vmethod_1(binaryWriter);
                }
            }
            else
            {
                GClass475.smethod_0(binaryWriter, item2);
                item2.vmethod_1(binaryWriter);
            }
        }
        File.WriteAllBytes(string_1, memoryStream.ToArray());
    }

    public IList<Class215> method_1(string string_1)
    {
        byte[] buffer = File.ReadAllBytes(string_1);
        IList<Class215> list = [];
        using MemoryStream input = new(buffer);
        BinaryReader binaryReader = new(input);
        if (binaryReader.ReadString() != "NFS Mod Installer Configuration File by nfsu360")
        {
            throw new Exception();
        }
        if (binaryReader.ReadInt32() != 538248724L)
        {
            throw new Exception();
        }
        int num = binaryReader.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            Class215 @class = new();
            @class.method_0(binaryReader);
            list.Add(@class);
        }
        return list;
    }

    public void method_2(IList<Class215> ilist_0, VaultDatabase gclass478_0, bool bool_0 = false)
    {
        foreach (Class215 item2 in ilist_0)
        {
            GClass475 header = item2.Header;
            GClass154 item = item2.Item;
            GClass537 gClass = gclass478_0.method_0(header.CollectionClassHash)?.method_2(header.CollectionNameHash);
            if (gClass != null && gClass.ParentHash == header.CollectionParentHash)
            {
                method_3(gclass478_0, bool_0, gClass, item2, item);
            }
        }
    }

    private void method_3(VaultDatabase gclass478_0, bool bool_0, GClass537 gclass537_0, Class215 class215_0, GClass154 gclass154_0)
    {
        foreach (GClass154 item in gclass537_0)
        {
            if (item is GClass155)
            {
                foreach (GClass154 item2 in item as GClass155)
                {
                    method_4(gclass478_0, item2, class215_0, gclass154_0, bool_0);
                }
            }
            else
            {
                method_4(gclass478_0, item, class215_0, gclass154_0, bool_0);
            }
        }
    }

    private void method_4(VaultDatabase gclass478_0, GClass154 gclass154_0, Class215 class215_0, GClass154 gclass154_1, bool bool_0)
    {
        GClass475 header = class215_0.Header;
        if (gclass154_0.Field.NameHash == header.NameHash && gclass154_0.Field.TypeHash == header.TypeHash && gclass154_0.ArrayIndex == header.ArrayIndex)
        {
            MemoryStream memoryStream = new();
            BinaryWriter binaryWriter_ = new(memoryStream);
            gclass154_1.vmethod_1(binaryWriter_);
            if (!bool_0)
            {
                IList<GClass541> collection = Class209.smethod_0(form_0, gclass478_0, gclass154_0, memoryStream);
                class215_0.Commands.AddRange(collection);
            }
            class215_0.IsValid = true;
        }
    }
}
