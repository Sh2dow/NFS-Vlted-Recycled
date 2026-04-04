using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public abstract class GClass119 : GInterface3, GInterface2
{
    private GAttribute2 gattribute2_0;

    protected IList<GInterface3> ilist_0 = [];

    private readonly IList<GInterface3> ilist_1 = [];

    [CompilerGenerated]
    private int int_0;

    public int Size
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

    [Browsable(false)]
    public IEnumerable<GInterface3> Prop_0 => ilist_0;

    [Browsable(false)]
    public IEnumerable<GInterface3> Prop_1 => ilist_1;

    protected GClass119()
    {
        gattribute2_0 = GetType().GetCustomAttribute<GAttribute2>();
    }

    [SpecialName]
    public GEnum15 imethod_5()
    {
        return gattribute2_0?.Type ?? GEnum15.const_0;
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        int num = (Size = binaryReader_0.smethod_9(gattribute2_0.Type));
        if (gattribute2_0.IsCollection)
        {
            num /= gattribute2_0.DataSize;
        }
        if (gattribute2_0.PreDataAlign > 0)
        {
            binaryReader_0.smethod_3(gattribute2_0.PreDataAlign);
        }
        if (gattribute2_0.IsCollection)
        {
            method_1(binaryReader_0, num);
        }
        else
        {
            imethod_3(binaryReader_0, num);
        }
        if (gattribute2_0.PostDataAlign > 0)
        {
            binaryReader_0.smethod_3(gattribute2_0.PostDataAlign);
        }
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        if (gattribute2_0.PreAlignBlock > 0)
        {
            binaryWriter_0.smethod_13(gattribute2_0.PreAlignBlock);
        }
        binaryWriter_0.smethod_12(gattribute2_0.Type, 0);
        int num = (int)binaryWriter_0.BaseStream.Position;
        if (gattribute2_0.PreDataAlign > 0)
        {
            binaryWriter_0.smethod_14(gattribute2_0.PreDataAlign, 17);
        }
        if (gattribute2_0.IsCollection)
        {
            method_2(binaryWriter_0);
        }
        else
        {
            imethod_4(binaryWriter_0);
        }
        if (gattribute2_0.PostDataAlign > 0)
        {
            binaryWriter_0.smethod_14(gattribute2_0.PostDataAlign, 0);
        }
        int num2 = (int)binaryWriter_0.BaseStream.Position;
        int offset = num - 4;
        int value = num2 - num;
        binaryWriter_0.Seek(offset, SeekOrigin.Begin);
        binaryWriter_0.Write(value);
        binaryWriter_0.Seek(num2, SeekOrigin.Begin);
    }

    public virtual void imethod_6(string string_0)
    {
        BinaryWriter binaryWriter_ = new(new FileStream(string_0, FileMode.Create));
        if (gattribute2_0.IsCollection)
        {
            foreach (GInterface3 item in ilist_1)
            {
                item.imethod_4(binaryWriter_);
            }
            return;
        }
        imethod_4(binaryWriter_);
    }

    [SpecialName]
    public virtual bool imethod_7()
    {
        return true;
    }

    public void imethod_3(BinaryReader binaryReader_0, int int_1)
    {
        this.smethod_0(binaryReader_0);
    }

    public void imethod_4(BinaryWriter binaryWriter_0)
    {
        this.smethod_1(binaryWriter_0);
    }

    protected void method_0<T>()
    {
        gattribute2_0 = typeof(T).GetCustomAttribute<GAttribute2>();
    }

    public void method_1(BinaryReader binaryReader_0, int int_1)
    {
        if (gattribute2_0.CountAsFirstData)
        {
            int_1 = binaryReader_0.ReadInt32();
        }
        for (int i = 0; i < int_1; i++)
        {
            GClass119 gClass = (GClass119)Activator.CreateInstance(GetType());
            gClass.imethod_3(binaryReader_0, int_1);
            ilist_1.Add(gClass);
        }
    }

    public void method_2(BinaryWriter binaryWriter_0)
    {
        if (gattribute2_0.CountAsFirstData)
        {
            binaryWriter_0.Write(ilist_1.Count);
        }
        foreach (GInterface3 item in ilist_1)
        {
            item.imethod_4(binaryWriter_0);
        }
    }

    public override string ToString()
    {
        GAttribute2 gAttribute = gattribute2_0;
        object obj;
        if (gAttribute == null)
        {
            obj = null;
        }
        else
        {
            obj = gAttribute.Type.smethod_1();
            if (obj != null)
            {
                goto IL_0026;
            }
        }
        obj = ToString();
        goto IL_0026;
    IL_0026:
        return (string)obj;
    }

    public void method_3<T>(BinaryReader binaryReader_0) where T : GInterface3
    {
        GInterface3 gInterface = Activator.CreateInstance<T>();
        gInterface.imethod_0(binaryReader_0);
        ilist_0.Add(gInterface);
    }

    [SpecialName]
    public bool imethod_2()
    {
        return gattribute2_0.IsCollection;
    }
}
