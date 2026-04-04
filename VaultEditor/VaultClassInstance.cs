using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass537 : GClass535, IEnumerable<GClass154>, IEnumerable, ICustomTypeDescriptor, GInterface4, GInterface8, GInterface7
{
    [CompilerGenerated]
    private sealed class Class203
    {
        public GClass151 gclass151_0;

        internal bool method_0(GClass154 gclass154_0)
        {
            return gclass154_0.Field == gclass151_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class204
    {
        public GClass151 gclass151_0;

        internal bool method_0(GClass154 gclass154_0)
        {
            return gclass154_0.Field.Equals(gclass151_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class205
    {
        public GClass151 gclass151_0;

        internal bool method_0(GClass154 gclass154_0)
        {
            return gclass154_0.Field.Equals(gclass151_0);
        }
    }

    private IList<uint> ilist_0;

    private short short_0;

    private uint uint_0;

    private readonly List<GClass154> list_0;

    private uint uint_1;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private IList<GClass148> ilist_1;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [CompilerGenerated]
    private GClass536 gclass536_0;

    [CompilerGenerated]
    private uint uint_4;

    [CompilerGenerated]
    private uint uint_5;

    [CompilerGenerated]
    private uint uint_6;

    [GAttribute1(Name = "Vault", ReadOnly = true)]
    public string GroupName
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
        [CompilerGenerated]
        set
        {
            string_0 = value;
        }
    }

    public IList<GClass148> OptionalData
    {
        [CompilerGenerated]
        get
        {
            return ilist_1;
        }
        [CompilerGenerated]
        set
        {
            ilist_1 = value;
        }
    }

    public uint ClassNameHash
    {
        [CompilerGenerated]
        get
        {
            return uint_2;
        }
        [CompilerGenerated]
        set
        {
            uint_2 = value;
        }
    }

    public uint ParentHash
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        set
        {
            uint_3 = value;
        }
    }

    public override GClass536 Class
    {
        [CompilerGenerated]
        get
        {
            return gclass536_0;
        }
        [CompilerGenerated]
        set
        {
            gclass536_0 = value;
        }
    }

    public uint Pointer
    {
        [CompilerGenerated]
        get
        {
            return uint_4;
        }
        [CompilerGenerated]
        private set
        {
            uint_4 = value;
        }
    }

    public uint OffsetDest
    {
        [CompilerGenerated]
        get
        {
            return uint_5;
        }
        [CompilerGenerated]
        set
        {
            uint_5 = value;
        }
    }

    public uint Id
    {
        [CompilerGenerated]
        get
        {
            return uint_6;
        }
        [CompilerGenerated]
        set
        {
            uint_6 = value;
        }
    }

    public uint UInt32_0
    {
        get
        {
            return uint_1;
        }
        set
        {
            uint_1 = value;
            method_9();
        }
    }

    public bool Boolean_1
    {
        get
        {
            if (ParentHash == 0)
            {
                return UInt32_0 == GClass486.DefaultHash;
            }
            return false;
        }
    }

    public GClass537(string string_1)
    {
        GroupName = string_1;
        ilist_0 = [];
        list_0 = [];
        OptionalData = [];
        base.ImageIndex = 2;
        base.SelectedImageIndex = 3;
    }

    protected bool method_0(GClass537 gclass537_0)
    {
        if (ClassNameHash == gclass537_0.ClassNameHash && UInt32_0 == gclass537_0.UInt32_0)
        {
            return ParentHash == gclass537_0.ParentHash;
        }
        return false;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (this == obj)
        {
            return true;
        }
        if (obj.GetType() != GetType())
        {
            return false;
        }
        return method_0((GClass537)obj);
    }

    public override int GetHashCode()
    {
        return (int)((((ClassNameHash * 397) ^ UInt32_0) * 397) ^ ParentHash);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void imethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0)
    {
        UInt32_0 = binaryReader_0.ReadUInt32();
        ClassNameHash = binaryReader_0.ReadUInt32();
        ParentHash = binaryReader_0.ReadUInt32();
        int num = binaryReader_0.ReadInt32();
        uint_0 = binaryReader_0.ReadUInt32();
        int num2 = binaryReader_0.ReadInt32();
        if (num != num2)
        {
            throw new Exception();
        }
        short num3 = binaryReader_0.ReadInt16();
        short_0 = binaryReader_0.ReadInt16();
        Pointer = binaryReader_0.smethod_10(0u);
        ilist_0 = [];
        for (int i = 0; i < num3; i++)
        {
            uint item = binaryReader_0.ReadUInt32();
            ilist_0.Add(item);
        }
        short num4 = num3;
        while (true)
        {
            if (num4 < short_0)
            {
                if (binaryReader_0.ReadInt32() != 0)
                {
                    break;
                }
                num4++;
                continue;
            }
            OptionalData = [];
            for (int j = 0; j < num; j++)
            {
                GClass148 gClass = new();
                gClass.vmethod_0(binaryReader_0);
                OptionalData.Add(gClass);
            }
            return;
        }
        throw new Exception();
    }

    public void imethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        List<GClass154> source = [.. this.Where(gclass154_0 => gclass154_0.OptionalData != null)];
        List<uint> list = [.. Class.BaseFields.Select(gclass151_0 => gclass151_0.TypeHash)];
        list.AddRange(source.Select(gclass154_0 => gclass154_0.Field.TypeHash));
        list = [.. list.Distinct()];
        ilist_0 = list;
        List<GClass148> list2 = [.. source.Select(gclass154_0 => gclass154_0.OptionalData)];
        short num = (short)ilist_0.Count;
        if (genum1_0 == GEnum1.const_3)
        {
            short_0 = 0;
        }
        else
        {
            int count = ilist_0.Count;
            short_0 = (short)(count + count.smethod_0(2));
        }
        binaryWriter_0.Write(UInt32_0);
        binaryWriter_0.Write(ClassNameHash);
        binaryWriter_0.Write(ParentHash);
        binaryWriter_0.Write(list2.Count);
        binaryWriter_0.Write(uint_0);
        binaryWriter_0.Write(list2.Count);
        binaryWriter_0.Write(num);
        binaryWriter_0.Write(short_0);
        Pointer = binaryWriter_0.smethod_11();
        foreach (uint item in ilist_0)
        {
            binaryWriter_0.Write(item);
        }
        for (short num2 = num; num2 < short_0; num2++)
        {
            binaryWriter_0.Write(0);
        }
        foreach (GClass148 item2 in list2)
        {
            item2.Flags2 = item2.Field.OptionalFlags2;
            item2.TypeIndex = (short)ilist_0.IndexOf(item2.Field.TypeHash);
            item2.vmethod_1(binaryWriter_0);
        }
    }

    public void method_1(BinaryReader binaryReader_0, BinaryReader binaryReader_1, IDictionary<uint, GClass536> idictionary_0)
    {
        Class = idictionary_0[ClassNameHash];
        foreach (GClass151 baseField in Class.BaseFields)
        {
            if (OffsetDest != 0)
            {
                binaryReader_0.smethod_0(OffsetDest + baseField.Offset);
                GClass154 gClass = (baseField.Boolean_0 ? GClass155.smethod_2(baseField, this) : GClass154.smethod_0(baseField, this));
                gClass.method_0(binaryReader_0);
                method_5(gClass);
                continue;
            }
            throw new Exception();
        }
        foreach (GClass148 optionalDatum in OptionalData)
        {
            GClass151 gClass2 = (optionalDatum.Field = Class.method_7(optionalDatum.NameHash));
            BinaryReader binaryReader_2;
            if (optionalDatum.Boolean_0)
            {
                binaryReader_2 = binaryReader_1;
                binaryReader_2.smethod_0(optionalDatum.Pointer);
            }
            else
            {
                binaryReader_2 = binaryReader_0;
                binaryReader_2.smethod_0(optionalDatum.OffsetDest);
            }
            GClass154 gClass4 = (gClass2.Boolean_0 ? GClass155.smethod_2(gClass2, this) : GClass154.smethod_0(gClass2, this));
            gClass4.method_0(binaryReader_2);
            gClass4.OptionalData = optionalDatum;
            method_5(gClass4);
        }
        Class.method_5(this);
    }

    public void method_2(BinaryWriter binaryWriter_0, BinaryWriter binaryWriter_1, int int_0)
    {
        IOrderedEnumerable<GClass154> orderedEnumerable = from gclass154_0 in this
                                                          where !gclass154_0.Field.Boolean_1
                                                          orderby gclass154_0.Field.Offset
                                                          select gclass154_0;
        if (orderedEnumerable.Any())
        {
            int int32_ = orderedEnumerable.First().Field.Int32_0;
            binaryWriter_0.smethod_14(int32_, 0);
            OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
            foreach (GClass154 item in orderedEnumerable)
            {
                GClass151 field = item.Field;
                binaryWriter_0.smethod_1(OffsetDest + field.Offset);
                item.vmethod_1(binaryWriter_0);
            }
            int num = (int)binaryWriter_0.BaseStream.Position;
            int num2 = int_0 - (num - (int)OffsetDest);
            if (num2 > 0)
            {
                binaryWriter_0.BaseStream.Position += num2;
            }
        }
        using IEnumerator<GClass154> enumerator = GetEnumerator();
        while (enumerator.MoveNext())
        {
            GClass154 current2 = enumerator.Current;
            if (current2.Field.Boolean_1)
            {
                GClass148 optionalData = current2.OptionalData;
                if (optionalData.Boolean_0)
                {
                    binaryWriter_1.smethod_1(optionalData.Pointer);
                    current2.vmethod_1(binaryWriter_1);
                    binaryWriter_1.BaseStream.Seek(0L, SeekOrigin.End);
                }
                else
                {
                    binaryWriter_0.smethod_14(current2.Field.Int32_0, 0);
                    optionalData.OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
                    current2.vmethod_1(binaryWriter_0);
                }
            }
        }
    }

    public bool method_3(GClass151 gclass151_0)
    {
        return this.Any(gclass154_0 => gclass154_0.Field == gclass151_0);
    }

    public AttributeCollection GetAttributes()
    {
        return TypeDescriptor.GetAttributes(this, noCustomTypeDesc: true);
    }

    public string GetClassName()
    {
        return TypeDescriptor.GetClassName(this, noCustomTypeDesc: true);
    }

    public string GetComponentName()
    {
        return TypeDescriptor.GetComponentName(this, noCustomTypeDesc: true);
    }

    public TypeConverter GetConverter()
    {
        return TypeDescriptor.GetConverter(this, noCustomTypeDesc: true);
    }

    public EventDescriptor GetDefaultEvent()
    {
        return TypeDescriptor.GetDefaultEvent(this, noCustomTypeDesc: true);
    }

    public PropertyDescriptor GetDefaultProperty()
    {
        return TypeDescriptor.GetDefaultProperty(this, noCustomTypeDesc: true);
    }

    public object GetEditor(Type editorBaseType)
    {
        return TypeDescriptor.GetEditor(this, editorBaseType, noCustomTypeDesc: true);
    }

    public EventDescriptorCollection GetEvents(Attribute[] attributes)
    {
        return TypeDescriptor.GetEvents(this, attributes, noCustomTypeDesc: true);
    }

    public EventDescriptorCollection GetEvents()
    {
        return TypeDescriptor.GetEvents(this, noCustomTypeDesc: true);
    }

    public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
        return GetProperties();
    }

    public PropertyDescriptorCollection GetProperties()
    {
        IList<PropertyDescriptor> list = [];
        foreach (GClass150 item2 in GClass108.smethod_0(GetType()))
        {
            list.Add(new GClass491(this, item2, item2.Attribute));
        }
        using (IEnumerator<GClass154> enumerator2 = GetEnumerator())
        {
            while (enumerator2.MoveNext())
            {
                GClass154 current2 = enumerator2.Current;
                if (current2.IsSingleValue)
                {
                    foreach (GClass509 item3 in current2.GetProperties().OfType<GClass509>())
                    {
                        list.Add(item3);
                    }
                }
                else
                {
                    PropertyDescriptor item = new GClass489(current2);
                    list.Add(item);
                }
            }
        }
        list = [.. list.OrderBy(propertyDescriptor_0 => propertyDescriptor_0.DisplayName)];
        return new PropertyDescriptorCollection([.. list]);
    }

    public object GetPropertyOwner(PropertyDescriptor pd)
    {
        return this;
    }

    public override string ToString()
    {
        return $"{ClassNameHash:X}|{uint_1:X}";
    }

    public GClass154 method_4(GClass151 gclass151_0)
    {
        return this.SingleOrDefault(gclass154_0 => gclass154_0.Field.Equals(gclass151_0));
    }

    public IEnumerator<GClass154> GetEnumerator()
    {
        return list_0.GetEnumerator();
    }

    public void method_5(GClass154 gclass154_0)
    {
        list_0.Add(gclass154_0);
    }

    public bool method_6(GClass154 gclass154_0)
    {
        return list_0.Contains(gclass154_0);
    }

    public bool method_7(GClass154 gclass154_0)
    {
        return list_0.Remove(gclass154_0);
    }

    public void method_8(GClass151 gclass151_0, GClass537 gclass537_0, short short_1)
    {
        GClass154 gClass = gclass537_0?.method_4(gclass151_0);
        if (gclass151_0.Boolean_0)
        {
            if (short_1 < 0)
            {
                short_1 = (short)(from gclass154_0 in Class.IEnumerable_0.SelectMany(result => result)
                                  where gclass154_0.Field.Equals(gclass151_0)
                                  select gclass154_0).OfType<GClass155>().Max(gclass155_0 => gclass155_0.Int32_0);
            }
            GClass155 gClass2 = gClass as GClass155;
            GClass155 gClass3 = GClass155.smethod_2(gclass151_0, this);
            gClass3.DataSize = gclass151_0.Length;
            GClass148.smethod_0(gclass151_0, gClass3);
            for (int num = 0; num < short_1; num++)
            {
                GClass154 gClass4 = GClass154.smethod_0(gclass151_0, gClass3.DataRow);
                gClass4.ArrayIndex = num;
                if (gClass2 != null && gClass2.Int32_0 > num)
                {
                    gClass4.method_1(gClass2[num]);
                }
                gClass3.method_4(gClass4);
            }
            if (gClass2 != null)
            {
                gClass3.ValidCount = gClass2.ValidCount;
            }
            method_5(gClass3);
        }
        else
        {
            GClass154 gClass5 = GClass154.smethod_0(gclass151_0, this);
            GClass148.smethod_0(gclass151_0, gClass5);
            if (gClass != null)
            {
                gClass5.method_1(gClass);
            }
            method_5(gClass5);
        }
    }

    public void method_9()
    {
        base.Text = GClass486.smethod_5(uint_1) ?? "";
    }

    public void method_10()
    {
        uint id = GClass486.smethod_8(GClass486.smethod_5(ClassNameHash) + "/" + GClass486.smethod_5(UInt32_0));
        Id = id;
    }

    public void method_11(ref int int_0)
    {
        int_0 += base.Nodes.Count;
        foreach (object node in base.Nodes)
        {
            if (node is GClass537 gClass)
            {
                gClass.method_11(ref int_0);
            }
        }
    }
}
