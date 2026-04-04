using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[GAttribute2]
internal sealed class Class179 : GClass119
{
    [CompilerGenerated]
    private sealed class Class125
    {
        public string string_0;

        internal bool method_0(Type type_0)
        {
            if (typeof(GClass119).IsAssignableFrom(type_0))
            {
                return type_0.Namespace == string_0;
            }
            return false;
        }
    }

    private int int_1;

    private GEnum1 genum1_0;

    [CompilerGenerated]
    private string string_0;

    public string FilePath
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

    public void method_4(GEnum1 genum1_1, string string_1)
    {
        if (!string.IsNullOrEmpty(string_1) && File.Exists(string_1))
        {
            genum1_0 = genum1_1;
            FilePath = string_1;
            byte[] array = File.ReadAllBytes(string_1);
            BinaryReader binaryReader_ = new(new MemoryStream(array));
            imethod_3(binaryReader_, array.Length);
            int_1 = 0;
        }
    }

    public void method_5(GInterface3 ginterface3_0)
    {
        int_1++;
        List<GInterface3> list = ginterface3_0.Prop_0?.ToList();
        if (list != null && list.Any())
        {
            foreach (GInterface3 item in list)
            {
                method_5(item);
            }
            return;
        }
        string text = Path.Combine("F:\\NFS\\GlobalDump", $"{int_1} - {ginterface3_0.imethod_5()}");
        ginterface3_0.imethod_6(text);
    }

    public void method_6(string string_1)
    {
        MemoryStream memoryStream = new();
        BinaryWriter binaryWriter_ = new(memoryStream);
        foreach (GInterface3 item in ilist_0)
        {
            item.imethod_1(binaryWriter_);
        }
        File.WriteAllBytes(string_1, memoryStream.ToArray());
    }

    public void imethod_3(BinaryReader binaryReader_0, int int_2)
    {
        string string_0 = string.Empty;
        switch (genum1_0)
        {
            default:
                throw new ArgumentOutOfRangeException();
            case GEnum1.const_1:
                string_0 = typeof(Class127).Namespace;
                break;
            case GEnum1.const_2:
                string_0 = typeof(Class137).Namespace;
                break;
            case GEnum1.const_3:
                string_0 = typeof(Class169).Namespace;
                break;
            case GEnum1.const_4:
                string_0 = typeof(Class178).Namespace;
                break;
            case GEnum1.const_5:
                string_0 = typeof(Class168).Namespace;
                break;
            case GEnum1.const_6:
                string_0 = typeof(Class128).Namespace;
                break;
            case GEnum1.const_7:
                string_0 = typeof(Class126).Namespace;
                break;
            case GEnum1.const_8:
                break;
        }
        IDictionary<GEnum15, Type> dictionary = new Dictionary<GEnum15, Type>();
        foreach (Type item in (from type_0 in Assembly.GetExecutingAssembly().GetTypes()
                               where typeof(GClass119).IsAssignableFrom(type_0) && type_0.Namespace == string_0
                               select type_0).ToList())
        {
            GAttribute2 customAttribute = item.GetCustomAttribute<GAttribute2>();
            if (customAttribute != null)
            {
                dictionary.Add(customAttribute.Type, item);
            }
        }
        while (!binaryReader_0.smethod_6())
        {
            GEnum15 gEnum = (GEnum15)binaryReader_0.ReadUInt32();
            GEnum15 gEnum2 = (GEnum15)binaryReader_0.ReadUInt32();
            switch (gEnum)
            {
                case GEnum15.const_0:
                case GEnum15.const_3:
                case GEnum15.const_5:
                case GEnum15.const_17:
                    binaryReader_0.BaseStream.Position += (long)gEnum2;
                    continue;
            }
            binaryReader_0.BaseStream.Position -= 8L;
            GInterface3 gInterface = (GInterface3)Activator.CreateInstance(dictionary[gEnum]);
            gInterface.imethod_0(binaryReader_0);
            ilist_0.Add(gInterface);
        }
    }
}
