using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VaultEditor;

public sealed class GClass505(GClass483 gclass483_1) : GClass500(GEnum23.const_4)
{
    private readonly GClass483 gclass483_0 = gclass483_1;

    private IList<GClass149> ilist_0;

    private IList<KeyValuePair<GClass149, GInterface4>> ilist_1;

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        ilist_0 = [];
        int num = binaryReader_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            GClass149 gClass = new();
            gClass.imethod_0(genum1_0, binaryReader_0);
            ilist_0.Add(gClass);
        }
    }

    public void method_0(GEnum1 genum1_0, BinaryReader binaryReader_0)
    {
        foreach (GClass149 item in ilist_0)
        {
            binaryReader_0.smethod_0(item.Offset);
            long position = binaryReader_0.BaseStream.Position;
            GInterface4 gInterface = method_1(item.ExpressionType);
            gInterface.Id = item.Id;
            gInterface.imethod_0(genum1_0, binaryReader_0);
            long num = binaryReader_0.BaseStream.Position - position;
            if (genum1_0 == GEnum1.const_3)
            {
                if (num != item.Size)
                {
                    throw new Exception();
                }
            }
            else if (num != item.Length)
            {
                throw new Exception();
            }
        }
    }

    private GInterface4 method_1(GEnum22 genum22_0)
    {
        switch (genum22_0)
        {
            default:
                return null;
            case GEnum22.const_0:
                if (!(gclass483_0.Name != "db") && gclass483_0.Types == null)
                {
                    gclass483_0.Types = new GClass152();
                    return gclass483_0.Types;
                }
                throw new Exception();
            case GEnum22.const_2:
                {
                    GClass537 gClass2 = new(gclass483_0.Name);
                    gclass483_0.Rows.Add(gClass2);
                    return gClass2;
                }
            case GEnum22.const_1:
                {
                    GClass536 gClass = new();
                    gclass483_0.Classes.Add(gClass);
                    return gClass;
                }
        }
    }

    public void method_2(GClass507 gclass507_0, BinaryReader binaryReader_0)
    {
        if (gclass483_0.Types != null)
        {
            smethod_0(gclass507_0, gclass483_0.Types);
        }
        foreach (GClass536 @class in gclass483_0.Classes)
        {
            smethod_0(gclass507_0, @class);
            foreach (GInterface5 item in GClass107<GInterface5>.smethod_1(@class))
            {
                GClass510 gClass = gclass507_0.method_0(item.Pointer);
                if (gClass != null)
                {
                    binaryReader_0.smethod_0(gClass.OffsetDest);
                    item.imethod_4(binaryReader_0);
                    if (item is GClass515 gClass2)
                    {
                        gClass2.method_0(binaryReader_0, gclass507_0);
                    }
                }
            }
        }
        foreach (GClass537 row in gclass483_0.Rows)
        {
            smethod_0(gclass507_0, row);
            foreach (GClass148 optionalDatum in row.OptionalData)
            {
                GClass510 gClass3 = gclass507_0.method_0(optionalDatum.Pointer);
                if (!optionalDatum.Boolean_0 || gClass3 != null)
                {
                    optionalDatum.OffsetDest = gClass3.OffsetDest;
                }
            }
        }
    }

    private static void smethod_0(GClass507 gclass507_0, GInterface4 ginterface4_0)
    {
        GClass510 gClass = gclass507_0.method_0(ginterface4_0.Pointer);
        if (gClass != null)
        {
            ginterface4_0.OffsetDest = gClass.OffsetDest;
        }
    }

    public void method_3(GEnum1 genum1_0, BinaryReader binaryReader_0, BinaryReader binaryReader_1, IDictionary<uint, GClass536> idictionary_0)
    {
        gclass483_0.Types?.method_0(binaryReader_0);
        foreach (GClass536 @class in gclass483_0.Classes)
        {
            @class.method_0(genum1_0, binaryReader_0, idictionary_0);
        }
        foreach (GClass537 row in gclass483_0.Rows)
        {
            row.method_1(binaryReader_0, binaryReader_1, idictionary_0);
        }
    }

    public void method_4(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        ilist_1 = [];
        if (gclass483_0.Types != null)
        {
            GClass149 gClass = new()
            {
                ExpressionType = GEnum22.const_0,
                Id = gclass483_0.Types.Id
            };
            smethod_1(genum1_0, binaryWriter_0, gClass, gclass483_0.Types);
            ilist_1.Add(new KeyValuePair<GClass149, GInterface4>(gClass, gclass483_0.Types));
        }
        if (gclass483_0.Classes.Any())
        {
            foreach (GClass536 @class in gclass483_0.Classes)
            {
                GClass149 gClass2 = new()
                {
                    ExpressionType = GEnum22.const_1,
                    Id = @class.UInt32_0
                };
                smethod_1(genum1_0, binaryWriter_0, gClass2, @class);
                ilist_1.Add(new KeyValuePair<GClass149, GInterface4>(gClass2, @class));
                foreach (GClass537 item in gclass483_0.method_0(@class.UInt32_0))
                {
                    GClass149 gClass3 = new()
                    {
                        ExpressionType = GEnum22.const_2,
                        Id = item.Id
                    };
                    smethod_1(genum1_0, binaryWriter_0, gClass3, item);
                    ilist_1.Add(new KeyValuePair<GClass149, GInterface4>(gClass3, item));
                }
            }
            return;
        }
        foreach (GClass537 row in gclass483_0.Rows)
        {
            GClass149 gClass4 = new()
            {
                ExpressionType = GEnum22.const_2,
                Id = row.Id
            };
            smethod_1(genum1_0, binaryWriter_0, gClass4, row);
            ilist_1.Add(new KeyValuePair<GClass149, GInterface4>(gClass4, row));
        }
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        method_5(genum1_0, binaryWriter_0);
    }

    private void method_5(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        int count = ilist_1.Count;
        binaryWriter_0.Write(count);
        foreach (KeyValuePair<GClass149, GInterface4> item in ilist_1)
        {
            item.Key.imethod_1(genum1_0, binaryWriter_0);
        }
    }

    private static void smethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0, GClass149 gclass149_0, GInterface4 ginterface4_0)
    {
        gclass149_0.Offset = (int)binaryWriter_0.BaseStream.Position;
        long position = binaryWriter_0.BaseStream.Position;
        ginterface4_0.imethod_1(genum1_0, binaryWriter_0);
        int num = (int)(binaryWriter_0.BaseStream.Position - position);
        if (genum1_0 == GEnum1.const_3)
        {
            gclass149_0.Size = num;
        }
        else
        {
            gclass149_0.Length = num;
        }
        binaryWriter_0.smethod_14(8, 0);
    }

    public void method_6(GEnum1 genum1_0, BinaryWriter binaryWriter_0, BinaryWriter binaryWriter_1)
    {
        if (gclass483_0.Types != null)
        {
            gclass483_0.Types.method_1(binaryWriter_0);
            binaryWriter_0.smethod_14(8, 0);
        }
        if (gclass483_0.Classes.Any())
        {
            foreach (GClass536 @class in gclass483_0.Classes)
            {
                @class.method_1(genum1_0, binaryWriter_0);
                smethod_2(binaryWriter_0, @class, 0);
                int requiredFieldsSize = @class.RequiredFieldsSize;
                foreach (GClass537 item in gclass483_0.method_0(@class.UInt32_0))
                {
                    item.method_2(binaryWriter_0, binaryWriter_1, requiredFieldsSize);
                    foreach (GClass154 item2 in item)
                    {
                        smethod_3(binaryWriter_0, item2);
                    }
                    binaryWriter_0.smethod_14((requiredFieldsSize == 0) ? 2 : 4, 0);
                }
                binaryWriter_0.smethod_14(8, 0);
            }
            return;
        }
        foreach (GClass537 row in gclass483_0.Rows)
        {
            int requiredFieldsSize2 = row.Class.RequiredFieldsSize;
            row.method_2(binaryWriter_0, binaryWriter_1, requiredFieldsSize2);
            foreach (GClass154 item3 in row)
            {
                smethod_3(binaryWriter_0, item3);
            }
            binaryWriter_0.smethod_14((requiredFieldsSize2 == 0) ? 2 : 4, 0);
        }
        binaryWriter_0.smethod_14(8, 0);
    }

    private static void smethod_2(BinaryWriter binaryWriter_0, GClass536 gclass536_0, int int_2 = 16)
    {
        foreach (GInterface5 item in GClass107<GInterface5>.smethod_1(gclass536_0))
        {
            if (item.imethod_3())
            {
                binaryWriter_0.smethod_14(int_2, 0);
                item.imethod_5(binaryWriter_0);
            }
        }
    }

    private static void smethod_3(BinaryWriter binaryWriter_0, GClass154 gclass154_0)
    {
        if (gclass154_0 is GClass155)
        {
            foreach (GClass154 item in (GClass155)gclass154_0)
            {
                smethod_3(binaryWriter_0, item);
            }
        }
        foreach (GInterface5 item2 in GClass107<GInterface5>.smethod_1(gclass154_0))
        {
            if (item2.imethod_3())
            {
                int int32_ = gclass154_0.Field.Int32_0;
                binaryWriter_0.smethod_14(int32_, 0);
                item2.imethod_5(binaryWriter_0);
            }
        }
    }
}
