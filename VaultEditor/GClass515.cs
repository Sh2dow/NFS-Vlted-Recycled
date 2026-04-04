using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class GClass515(GClass536 gclass536_1) : GInterface5, GInterface6
{
    private readonly GClass536 gclass536_0 = gclass536_1;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private byte[] byte_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private GClass514<GClass525> gclass514_0;

    [CompilerGenerated]
    private GClass514<GClass524> gclass514_1;

    [CompilerGenerated]
    private GClass514<GClass525> gclass514_2;

    [CompilerGenerated]
    private IList<GClass521> ilist_0;

    public int Size
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        private set
        {
            int_0 = value;
        }
    }

    public int DataCount
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        private set
        {
            int_1 = value;
        }
    }

    public uint Pointer
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        protected set
        {
            uint_0 = value;
        }
    }

    public byte[] Data
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        private set
        {
            byte_0 = value;
        }
    }

    public uint OffsetDest
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        private set
        {
            uint_1 = value;
        }
    }

    public GClass514<GClass525> Pointer1
    {
        [CompilerGenerated]
        get
        {
            return gclass514_0;
        }
        [CompilerGenerated]
        set
        {
            gclass514_0 = value;
        }
    }

    public GClass514<GClass524> Pointer2
    {
        [CompilerGenerated]
        get
        {
            return gclass514_1;
        }
        [CompilerGenerated]
        set
        {
            gclass514_1 = value;
        }
    }

    public GClass514<GClass525> Pointer3
    {
        [CompilerGenerated]
        get
        {
            return gclass514_2;
        }
        [CompilerGenerated]
        set
        {
            gclass514_2 = value;
        }
    }

    public IList<GClass521> MultipleCustomData
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

    [SpecialName]
    public bool imethod_3()
    {
        return Data != null;
    }

    [SpecialName]
    public bool imethod_2()
    {
        return true;
    }

    public void imethod_0(BinaryReader binaryReader_0)
    {
        Size = binaryReader_0.ReadInt32();
        Pointer = binaryReader_0.smethod_10(0u);
    }

    public void imethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Size);
        Pointer = binaryWriter_0.smethod_11();
    }

    public void imethod_4(BinaryReader binaryReader_0)
    {
        if (Size == 16)
        {
            Data = new byte[4];
            DataCount = binaryReader_0.ReadInt32();
            if (DataCount > 0)
            {
                Pointer1 = new GClass514<GClass525>(DataCount);
                Pointer2 = new GClass514<GClass524>(DataCount);
                Pointer3 = new GClass514<GClass525>(0);
                Pointer1.imethod_0(binaryReader_0);
                Pointer2.imethod_0(binaryReader_0);
                Pointer3.imethod_0(binaryReader_0);
            }
        }
        else if (Size == 240)
        {
            Data = new byte[4];
            MultipleCustomData = [];
            for (int i = 0; i < 5; i++)
            {
                GClass521 gClass = new();
                gClass.method_0(binaryReader_0);
                MultipleCustomData.Add(gClass);
            }
        }
        else
        {
            Data = binaryReader_0.ReadBytes(Size);
        }
    }

    public void method_0(BinaryReader binaryReader_0, GClass507 gclass507_0)
    {
        if (Pointer1 != null)
        {
            GClass510 gClass = gclass507_0.method_1(Pointer1.Pointer);
            if (gClass != null)
            {
                binaryReader_0.smethod_0(gClass.OffsetDest);
                Pointer1.imethod_4(binaryReader_0);
                GClass510 gClass2 = gclass507_0.method_1(Pointer2.Pointer);
                binaryReader_0.smethod_0(gClass2.OffsetDest);
                Pointer2.imethod_4(binaryReader_0);
                GClass510 gClass3 = gclass507_0.method_1(Pointer3.Pointer);
                binaryReader_0.smethod_0(gClass3.OffsetDest);
                int num = Pointer2.Items.Sum(gclass524_0 => gclass524_0.ChildrenCount);
                Pointer3 = new GClass514<GClass525>(num);
                Pointer3.imethod_4(binaryReader_0);
            }
        }
        if (MultipleCustomData == null)
        {
            return;
        }
        foreach (GClass521 multipleCustomDatum in MultipleCustomData)
        {
            GClass510 gClass4 = gclass507_0.method_1(multipleCustomDatum.CustomData1.Pointer);
            binaryReader_0.smethod_0(gClass4.OffsetDest);
            multipleCustomDatum.CustomData1.imethod_4(binaryReader_0);
            GClass510 gClass5 = gclass507_0.method_1(multipleCustomDatum.CustomData2.Pointer);
            binaryReader_0.smethod_0(gClass5.OffsetDest);
            multipleCustomDatum.CustomData2.imethod_4(binaryReader_0);
            GClass510 gClass6 = gclass507_0.method_1(multipleCustomDatum.CustomData3.Pointer);
            binaryReader_0.smethod_0(gClass6.OffsetDest);
            multipleCustomDatum.CustomData3.imethod_4(binaryReader_0);
        }
    }

    private void method_1(IDictionary<string, int> idictionary_0, TreeNode treeNode_0, ref int int_2)
    {
        foreach (TreeNode node in treeNode_0.Nodes)
        {
            idictionary_0[node.Text] = int_2++;
        }
        foreach (TreeNode node2 in treeNode_0.Nodes)
        {
            method_1(idictionary_0, node2, ref int_2);
        }
    }

    public void imethod_5(BinaryWriter binaryWriter_0)
    {
        OffsetDest = (uint)binaryWriter_0.BaseStream.Position;
        if (Size == 16)
        {
            if ((from gclass537_0 in gclass536_0.IEnumerable_0.OrderBy(gclass537_0 => gclass537_0.UInt32_0).ToList()
                 where gclass537_0.Nodes.Count > 0
                 select gclass537_0).ToList().Any())
            {
                binaryWriter_0.Write(Pointer1.Items.Count);
                Pointer1.imethod_1(binaryWriter_0);
                Pointer2.imethod_1(binaryWriter_0);
                Pointer3.imethod_1(binaryWriter_0);
                Pointer1.imethod_5(binaryWriter_0);
                Pointer2.imethod_5(binaryWriter_0);
                Pointer3.imethod_5(binaryWriter_0);
            }
            return;
        }
        if (Size == 240)
        {
            foreach (GClass521 multipleCustomDatum in MultipleCustomData)
            {
                multipleCustomDatum.method_1(binaryWriter_0);
            }
            {
                foreach (GClass521 multipleCustomDatum2 in MultipleCustomData)
                {
                    multipleCustomDatum2.CustomData1.imethod_5(binaryWriter_0);
                    multipleCustomDatum2.CustomData2.imethod_5(binaryWriter_0);
                    multipleCustomDatum2.CustomData3.imethod_5(binaryWriter_0);
                }
                return;
            }
        }
        binaryWriter_0.Write(Data);
    }

    public GInterface5 imethod_6()
    {
        throw new NotImplementedException();
    }

    public bool imethod_7(Func<string, bool> func_0)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Extra data";
    }
}
