using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public abstract class GClass154 : CustomTypeDescriptor
{
    [CompilerGenerated]
    private GClass537 gclass537_0;

    [CompilerGenerated]
    private GClass151 gclass151_0;

    [CompilerGenerated]
    private GClass148 gclass148_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private bool bool_0;

    private int int_1;

    private int int_2;

    [CompilerGenerated]
    private bool bool_1;

    public GClass537 DataRow
    {
        [CompilerGenerated]
        get
        {
            return gclass537_0;
        }
        [CompilerGenerated]
        protected set
        {
            gclass537_0 = value;
        }
    }

    public GClass151 Field
    {
        [CompilerGenerated]
        get
        {
            return gclass151_0;
        }
        [CompilerGenerated]
        set
        {
            gclass151_0 = value;
        }
    }

    public GClass148 OptionalData
    {
        [CompilerGenerated]
        get
        {
            return gclass148_0;
        }
        [CompilerGenerated]
        set
        {
            gclass148_0 = value;
        }
    }

    public int ArrayIndex
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public bool IsSingleValue
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        private set
        {
            bool_0 = value;
        }
    }

    public bool IsMatched
    {
        [CompilerGenerated]
        get
        {
            return bool_1;
        }
        [CompilerGenerated]
        set
        {
            bool_1 = value;
        }
    }

    public bool Boolean_0
    {
        get
        {
            if (OptionalData != null)
            {
                return !OptionalData.Boolean_0;
            }
            return true;
        }
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        int_1 = (int)binaryReader_0.BaseStream.Position;
        vmethod_0(binaryReader_0);
        int_2 = (int)binaryReader_0.BaseStream.Position;
        int num = int_2 - int_1;
        if (this is not GClass155 && this is not GClass296 && this is not GClass298 && Field?.Length != num)
        {
            throw new Exception();
        }
    }

    public abstract void vmethod_0(BinaryReader binaryReader_0);

    public abstract void vmethod_1(BinaryWriter binaryWriter_0);

    public static GClass154 smethod_0(GClass151 gclass151_1, GClass537 gclass537_1)
    {
        Type type = GClass487.smethod_4(gclass151_1.TypeHash, gclass151_1.NameHash, gclass151_1.Length);
        GClass154 obj = (GClass154)Activator.CreateInstance(type);
        obj.IsSingleValue = GClass487.smethod_5(type);
        obj.Field = gclass151_1;
        obj.DataRow = gclass537_1;
        return obj;
    }

    public override string ToString()
    {
        return this.smethod_0();
    }

    public override int GetHashCode()
    {
        return (int)((((((((((((DataRow.ClassNameHash * 397) ^ DataRow.UInt32_0) * 397) ^ DataRow.ParentHash) * 397) ^ (uint)ArrayIndex) * 397) ^ (uint)Boolean_0.GetHashCode()) * 397) ^ Field.NameHash) * 397) ^ Field.TypeHash);
    }

    public void method_1(GClass154 gclass154_0)
    {
        if (GetType() != gclass154_0.GetType())
        {
            throw new Exception();
        }
        MemoryStream memoryStream = new();
        BinaryWriter binaryWriter_ = new(memoryStream);
        gclass154_0.vmethod_1(binaryWriter_);
        BinaryReader binaryReader = new(memoryStream);
        binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
        vmethod_0(binaryReader);
        if (gclass154_0 is GClass155 gClass && this is GClass155 gClass2)
        {
            for (int i = 0; i < gClass2.Int32_0; i++)
            {
                GClass154 gclass154_1 = gClass2[i];
                GClass154 gclass154_2 = gClass[i];
                smethod_1(gclass154_1, gclass154_2);
            }
        }
        smethod_1(this, gclass154_0);
    }

    private static void smethod_1(GClass154 gclass154_0, GClass154 gclass154_1)
    {
        foreach (PropertyInfo item in GClass107<GClass499>.smethod_0(gclass154_0.GetType()))
        {
            GClass499 gClass = item.GetValue(gclass154_1) as GClass499;
            (item.GetValue(gclass154_0) as GClass499).String_0 = gClass.String_0;
        }
        foreach (PropertyInfo item2 in GClass107<GInterface5>.smethod_0(gclass154_0.GetType()))
        {
            GInterface5 value = (item2.GetValue(gclass154_1) as GInterface5).imethod_6();
            item2.SetValue(gclass154_0, value);
        }
    }

    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
        return GetProperties();
    }

    public override PropertyDescriptorCollection GetProperties()
    {
        PropertyDescriptorCollection propertyDescriptorCollection = new(null);
        foreach (GClass509 item in method_2(this))
        {
            propertyDescriptorCollection.Add(item);
        }
        return propertyDescriptorCollection;
    }

    private IEnumerable<GClass509> method_2(object object_0)
    {
        IEnumerable<GClass150> enumerable = GClass108.smethod_0(object_0.GetType());
        foreach (GClass150 item in enumerable)
        {
            foreach (GClass509 item2 in method_3(object_0, item))
            {
                item2.IsMatched = IsMatched;
                yield return item2;
            }
        }
    }

    private IEnumerable<GClass509> method_3(object object_0, GClass150 gclass150_0)
    {
        GAttribute1 attribute = gclass150_0.Attribute;
        if (gclass150_0.Type_0 == typeof(GClass499))
        {
            object object_1 = gclass150_0.method_0(object_0);
            IEnumerable<GClass509> enumerable = method_2(object_1);
            foreach (GClass509 item in enumerable)
            {
                item.CustomName = attribute.Name;
                yield return item;
            }
        }
        else if (typeof(GInterface5).IsAssignableFrom(gclass150_0.Type_0))
        {
            object object_2 = gclass150_0.method_0(object_0);
            IEnumerable<GClass509> enumerable2 = method_2(object_2);
            foreach (GClass509 item2 in enumerable2)
            {
                item2.CustomName = gclass150_0.Attribute.Name;
                yield return item2;
            }
        }
        else if (typeof(GInterface6).IsAssignableFrom(gclass150_0.Type_0))
        {
            object object_3 = gclass150_0.method_0(object_0);
            IEnumerable<GClass509> enumerable3 = method_2(object_3);
            foreach (GClass509 item3 in enumerable3)
            {
                item3.CustomName = gclass150_0.Attribute.Name;
                yield return item3;
            }
        }
        else
        {
            yield return new GClass509(this, object_0, gclass150_0, attribute)
            {
                IsMatched = IsMatched
            };
        }
    }

    public override object GetPropertyOwner(PropertyDescriptor pd)
    {
        return this;
    }
}
