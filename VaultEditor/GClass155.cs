using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass155 : GClass154, IEnumerable<GClass154>, IEnumerable
{
    private IList<GClass154> ilist_0;

    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private short short_0;

    [CompilerGenerated]
    private short short_1;

    private byte byte_0;

    public ushort DataSize
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

    [GAttribute1("Capacity", ReadOnly = true)]
    public short MaxCount
    {
        [CompilerGenerated]
        get
        {
            return short_0;
        }
        [CompilerGenerated]
        private set
        {
            short_0 = value;
        }
    }

    [GAttribute1("Count", ReadOnly = true)]
    public short ValidCount
    {
        [CompilerGenerated]
        get
        {
            return short_1;
        }
        [CompilerGenerated]
        set
        {
            short_1 = value;
        }
    }

    public int Int32_0 => ilist_0.Count;

    public GClass154 this[int int_3]
    {
        get
        {
            return ilist_0[int_3];
        }
        set
        {
            ilist_0[int_3] = value;
        }
    }

    private GClass155()
    {
    }

    public void method_4(GClass154 gclass154_0)
    {
        ilist_0.Add(gclass154_0);
        ValidCount = (short)ilist_0.Count;
        MaxCount = (short)ilist_0.Count;
    }

    public void method_5(short short_2)
    {
        if (short_2 < ilist_0.Count)
        {
            ilist_0 = [.. ilist_0.Take(short_2)];
        }
        if (short_2 > ilist_0.Count)
        {
            int num = short_2 - ilist_0.Count;
            for (int i = 0; i < num; i++)
            {
                GClass154 gClass = GClass154.smethod_0(base.Field, base.DataRow);
                gClass.ArrayIndex = ilist_0.Count;
                ilist_0.Add(gClass);
            }
        }
        ValidCount = (short)ilist_0.Count;
        MaxCount = (short)ilist_0.Count;
    }

    public override string ToString()
    {
        return string.Join(" | ", ilist_0);
    }

    public bool method_6(GClass154 gclass154_0)
    {
        return ilist_0.Contains(gclass154_0);
    }

    public static GClass155 smethod_2(GClass151 gclass151_1, GClass537 gclass537_1)
    {
        byte b = GClass487.smethod_3(gclass151_1.TypeHash);
        return new GClass155
        {
            Field = gclass151_1,
            DataRow = gclass537_1,
            byte_0 = b,
            ilist_0 = []
        };
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        MaxCount = binaryReader_0.ReadInt16();
        ValidCount = binaryReader_0.ReadInt16();
        DataSize = binaryReader_0.ReadUInt16();
        binaryReader_0.ReadByte();
        binaryReader_0.ReadByte();
        ilist_0.Clear();
        int num = (int)binaryReader_0.BaseStream.Position;
        int num2 = 0;
        int num3 = 0;
        while (true)
        {
            if (num3 < MaxCount)
            {
                num2 += binaryReader_0.smethod_3(base.Field.Int32_0);
                GClass154 gClass = GClass154.smethod_0(base.Field, base.DataRow);
                gClass.ArrayIndex = num3;
                int num4 = (int)binaryReader_0.BaseStream.Position;
                gClass.method_0(binaryReader_0);
                int num5 = (int)binaryReader_0.BaseStream.Position - num4;
                if (DataSize == 0 || DataSize == num5)
                {
                    ilist_0.Add(gClass);
                    num3++;
                    continue;
                }
                throw new Exception();
            }
            int num6 = (int)binaryReader_0.BaseStream.Position - num;
            if (base.Field.Length * MaxCount + num2 != num6)
            {
                throw new Exception();
            }
            break;
        }
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(MaxCount);
        binaryWriter_0.Write(ValidCount);
        binaryWriter_0.Write(DataSize);
        binaryWriter_0.Write((byte)0);
        binaryWriter_0.Write(byte_0);
        foreach (GClass154 item in ilist_0)
        {
            binaryWriter_0.smethod_14(base.Field.Int32_0, 0);
            item.vmethod_1(binaryWriter_0);
        }
    }

    public IEnumerator<GClass154> GetEnumerator()
    {
        return ilist_0.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override AttributeCollection GetAttributes()
    {
        return TypeDescriptor.GetAttributes(this, noCustomTypeDesc: true);
    }

    public override string GetClassName()
    {
        return TypeDescriptor.GetClassName(this, noCustomTypeDesc: true);
    }

    public override string GetComponentName()
    {
        return TypeDescriptor.GetComponentName(this, noCustomTypeDesc: true);
    }

    public override TypeConverter GetConverter()
    {
        return TypeDescriptor.GetConverter(this, noCustomTypeDesc: true);
    }

    public override EventDescriptor GetDefaultEvent()
    {
        return TypeDescriptor.GetDefaultEvent(this, noCustomTypeDesc: true);
    }

    public override PropertyDescriptor GetDefaultProperty()
    {
        return TypeDescriptor.GetDefaultProperty(this, noCustomTypeDesc: true);
    }

    public override object GetEditor(Type editorBaseType)
    {
        return TypeDescriptor.GetEditor(this, editorBaseType, noCustomTypeDesc: true);
    }

    public override EventDescriptorCollection GetEvents(Attribute[] attributes)
    {
        return TypeDescriptor.GetEvents(this, attributes, noCustomTypeDesc: true);
    }

    public override EventDescriptorCollection GetEvents()
    {
        return TypeDescriptor.GetEvents(this, noCustomTypeDesc: true);
    }

    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
        return GetProperties();
    }

    public override PropertyDescriptorCollection GetProperties()
    {
        PropertyDescriptorCollection properties = base.GetProperties();
        foreach (GClass154 item in ilist_0)
        {
            if (item.IsSingleValue)
            {
                foreach (GClass509 item2 in item.GetProperties().OfType<GClass509>())
                {
                    item2.IsArray = true;
                    properties.Add(item2);
                }
            }
            else
            {
                PropertyDescriptor value = new GClass489(item)
                {
                    IsArray = true
                };
                properties.Add(value);
            }
        }
        return properties;
    }

    public override object GetPropertyOwner(PropertyDescriptor pd)
    {
        return this;
    }
}
