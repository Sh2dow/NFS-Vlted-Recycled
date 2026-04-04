using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GClass536 : GClass535, GInterface4, GInterface8, GInterface7, IComparable
{
    [CompilerGenerated]
    private sealed class Class198
    {
        public GClass537 gclass537_0;

        internal bool method_0(GClass537 gclass537_1)
        {
            return gclass537_1.ParentHash == gclass537_0.UInt32_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class200
    {
        public uint uint_0;

        public uint uint_1;

        internal void method_0(GClass537 gclass537_0)
        {
            if (gclass537_0.ParentHash == uint_0)
            {
                gclass537_0.ParentHash = uint_1;
            }
        }
    }

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private short short_0;

    [CompilerGenerated]
    private int int_1;

    private uint uint_0;

    private readonly IDictionary<uint, GClass537> idictionary_0;

    public IDictionary<uint, GClass151> idictionary_1;

    [CompilerGenerated]
    private IList<GClass151> ilist_0;

    [CompilerGenerated]
    private IList<GClass151> ilist_1;

    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [CompilerGenerated]
    private uint uint_4;

    [CompilerGenerated]
    private bool bool_3;

    [CompilerGenerated]
    private uint uint_5;

    public int _p1
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

    public short LayoutKeyShift
    {
        [CompilerGenerated]
        get
        {
            return short_0;
        }
        [CompilerGenerated]
        set
        {
            short_0 = value;
        }
    }

    public int RequiredFieldsSize
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        set
        {
            int_1 = value;
        }
    }

    public IList<GClass151> BaseFields
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
        [CompilerGenerated]
        set
        {
            ilist_0 = value;
        }
    }

    public IList<GClass151> OptionalFields
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

    public GInterface5 CustomData
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_0;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_0 = value;
        }
    }

    public uint CollectionReserve
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        set
        {
            uint_1 = value;
        }
    }

    public ushort RequiredFieldsCount
    {
        [CompilerGenerated]
        get
        {
            return ushort_0;
        }
        [CompilerGenerated]
        set
        {
            ushort_0 = value;
        }
    }

    public uint FieldsCount
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

    public uint Pointer
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        private set
        {
            uint_3 = value;
        }
    }

    public uint OffsetDest
    {
        [CompilerGenerated]
        get
        {
            return uint_4;
        }
        [CompilerGenerated]
        set
        {
            uint_4 = value;
        }
    }

    public bool HasBaseFields
    {
        [CompilerGenerated]
        get
        {
            return bool_3;
        }
        [CompilerGenerated]
        private set
        {
            bool_3 = value;
        }
    }

    public uint Id
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

    public override GClass536 Class
    {
        get
        {
            return this;
        }
        set
        {
            throw new Exception();
        }
    }

    public IEnumerable<GClass537> IEnumerable_0 => from gclass537_0 in idictionary_0.Values
                                                   orderby gclass537_0.Level, gclass537_0.UInt32_0
                                                   select gclass537_0;

    public IEnumerable<GClass151> IEnumerable_1 => idictionary_1.Values;

    public uint UInt32_0
    {
        get
        {
            return uint_0;
        }
        set
        {
            uint_0 = value;
            base.Text = GClass486.smethod_5(uint_0);
        }
    }

    public GClass536()
    {
        CustomData = new GClass515(this);
        idictionary_1 = new Dictionary<uint, GClass151>();
        idictionary_0 = new Dictionary<uint, GClass537>();
        base.ImageIndex = 0;
        base.SelectedImageIndex = 1;
    }

    public int CompareTo(object obj)
    {
        return UInt32_0.CompareTo(((GClass536)obj).UInt32_0);
    }

    public void imethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0)
    {
        UInt32_0 = binaryReader_0.ReadUInt32();
        if (genum1_0 == GEnum1.const_7 && UInt32_0 == GClass486.smethod_8("timeofdaylighting"))
        {
            CustomData = new GClass512();
        }
        CollectionReserve = binaryReader_0.ReadUInt32();
        FieldsCount = binaryReader_0.ReadUInt32();
        Pointer = binaryReader_0.smethod_10(0u);
        if (genum1_0 == GEnum1.const_3)
        {
            RequiredFieldsSize = binaryReader_0.ReadInt32();
            _p1 = binaryReader_0.ReadInt32();
            RequiredFieldsCount = binaryReader_0.ReadUInt16();
            LayoutKeyShift = binaryReader_0.ReadInt16();
        }
        else
        {
            CustomData.imethod_0(binaryReader_0);
            RequiredFieldsSize = binaryReader_0.ReadInt32();
            LayoutKeyShift = binaryReader_0.ReadInt16();
            RequiredFieldsCount = binaryReader_0.ReadUInt16();
        }
        if (_p1 != 0)
        {
            throw new Exception();
        }
        if (!genum1_0.smethod_3(GEnum1.const_7, GEnum1.const_8) && LayoutKeyShift != 0)
        {
            throw new Exception();
        }
    }

    public void imethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        if (genum1_0 == GEnum1.const_3 && GClass486.smethod_8("pvehicle") == UInt32_0)
        {
            CollectionReserve = 222u;
        }
        binaryWriter_0.Write(UInt32_0);
        binaryWriter_0.Write(CollectionReserve);
        binaryWriter_0.Write(FieldsCount);
        Pointer = binaryWriter_0.smethod_11();
        if (genum1_0 == GEnum1.const_3)
        {
            binaryWriter_0.Write(RequiredFieldsSize);
            binaryWriter_0.Write(_p1);
            binaryWriter_0.Write(RequiredFieldsCount);
            binaryWriter_0.Write(LayoutKeyShift);
        }
        else
        {
            CustomData.imethod_1(binaryWriter_0);
            binaryWriter_0.Write(RequiredFieldsSize);
            binaryWriter_0.Write(LayoutKeyShift);
            binaryWriter_0.Write(RequiredFieldsCount);
        }
    }

    public void method_0(GEnum1 genum1_0, BinaryReader binaryReader_0, IDictionary<uint, GClass536> idictionary_2)
    {
        GClass486.smethod_5(UInt32_0);
        binaryReader_0.smethod_0(OffsetDest);
        for (int i = 0; i < FieldsCount; i++)
        {
            GClass151 gClass = new();
            gClass.imethod_0(genum1_0, binaryReader_0);
            if (!gClass.Boolean_1)
            {
                HasBaseFields = true;
            }
            idictionary_1.Add(gClass.NameHash, gClass);
            GClass486.smethod_5(gClass.NameHash);
        }
        BaseFields = [.. (from gclass151_0 in idictionary_1.Values
                      where !gclass151_0.Boolean_1
                      orderby gclass151_0.Offset
                      select gclass151_0)];
        OptionalFields = [.. idictionary_1.Values.Where(gclass151_0 => gclass151_0.Boolean_1)];
        idictionary_2[UInt32_0] = this;
    }

    public void method_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        foreach (KeyValuePair<uint, GClass151> item in idictionary_1)
        {
            item.Value.imethod_1(genum1_0, binaryWriter_0);
        }
    }

    public GClass537 method_2(uint uint_6)
    {
        idictionary_0.TryGetValue(uint_6, out var value);
        return value;
    }

    public GClass537 method_3()
    {
        return method_2(GClass486.DefaultHash);
    }

    public GClass537 method_4()
    {
        return idictionary_0.FirstOrDefault().Value;
    }

    public void method_5(GClass537 gclass537_0)
    {
        idictionary_0.Add(gclass537_0.UInt32_0, gclass537_0);
    }

    public override string ToString()
    {
        return $"{uint_0:X}";
    }

    private static IEnumerable<GClass537> smethod_0(IList<GClass537> ilist_2, GClass537 gclass537_0)
    {
        IEnumerable<GClass537> enumerable = ilist_2.Where(gClass => gClass.ParentHash == gclass537_0.UInt32_0);
        foreach (GClass537 item in enumerable)
        {
            IEnumerable<GClass537> enumerable2 = smethod_0(ilist_2, item);
            foreach (GClass537 item2 in enumerable2)
            {
                yield return item2;
            }
        }
        yield return gclass537_0;
    }

    public void method_6(uint uint_6, uint uint_7)
    {
        GClass537 gClass = method_2(uint_6);
        idictionary_0.Remove(gClass.UInt32_0);
        gClass.UInt32_0 = uint_7;
        gClass.method_10();
        idictionary_0.Add(gClass.UInt32_0, gClass);
        idictionary_0.Values.ToList().ForEach(delegate (GClass537 gclass537_0)
        {
            if (gclass537_0.ParentHash == uint_6)
            {
                gclass537_0.ParentHash = uint_7;
            }
        });
    }

    public GClass151 method_7(uint uint_6)
    {
        idictionary_1.TryGetValue(uint_6, out var value);
        return value;
    }

    public IList<GClass537> method_8(GClass537 gclass537_0)
    {
        List<GClass537> list = [.. smethod_0([.. idictionary_0.Values], gclass537_0)];
        foreach (GClass537 item in list)
        {
            item.Parent.Nodes.Remove(item);
            idictionary_0.Remove(item.UInt32_0);
        }
        return list;
    }

    public IList<GClass537> method_9()
    {
        List<GClass537> result = [.. idictionary_0.Values];
        base.Nodes.Clear();
        idictionary_0.Clear();
        return result;
    }

    public GClass537 method_10(TreeNode treeNode_0, string string_0, GClass537 gclass537_0 = null)
    {
        uint parentHash;
        object obj;
        if (treeNode_0 is GClass536)
        {
            parentHash = 0u;
            GClass537 gClass = method_4();
            if (gClass == null)
            {
                obj = null;
            }
            else
            {
                obj = gClass.GroupName;
                if (obj != null)
                {
                    goto IL_0025;
                }
            }
            obj = "db";
            goto IL_0025;
        }
        GClass537 obj2 = (GClass537)treeNode_0;
        parentHash = obj2.UInt32_0;
        string string_1 = obj2.GroupName;
        goto IL_003b;
    IL_0025:
        string_1 = (string)obj;
        goto IL_003b;
    IL_003b:
        if (gclass537_0 != null)
        {
            string_1 = gclass537_0.GroupName;
        }
        uint num = GClass486.smethod_8(string_0);
        GClass537 gClass2 = new(string_1)
        {
            Id = num,
            OffsetDest = 999u,
            ClassNameHash = UInt32_0,
            Class = this,
            UInt32_0 = num,
            ParentHash = parentHash
        };
        gClass2.method_10();
        if (gclass537_0 != null)
        {
            gClass2.GroupName = gclass537_0.GroupName;
            foreach (GClass154 item in gclass537_0)
            {
                GClass151 field = item.Field;
                short short_ = 0;
                if (item is GClass155)
                {
                    short_ = (item as GClass155).MaxCount;
                }
                gClass2.method_8(field, gclass537_0, short_);
            }
        }
        else
        {
            GClass537 gclass537_1 = method_3();
            foreach (GClass151 baseField in BaseFields)
            {
                short count = baseField.Count;
                gClass2.method_8(baseField, gclass537_1, count);
            }
        }
        treeNode_0.Nodes.Add(gClass2);
        method_5(gClass2);
        return gClass2;
    }
}
