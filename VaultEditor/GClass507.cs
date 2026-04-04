using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass507 : GClass500
{
    [CompilerGenerated]
    private sealed class Class222
    {
        public GClass507 gclass507_0;

        public GClass504 gclass504_0;

        public Action<GClass154> action_0;

        internal void method_0(GClass154 gclass154_0)
        {
            gclass507_0.method_4(gclass504_0, gclass154_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class223
    {
        public GClass507 gclass507_0;

        public GClass504 gclass504_0;

        public BinaryReader binaryReader_0;

        public Action<GClass154> action_0;

        internal void method_0(GClass154 gclass154_0)
        {
            IEnumerable<GClass499> enumerable = GClass107<GClass499>.smethod_1(gclass154_0);
            GClass148 optionalData = gclass154_0.OptionalData;
            foreach (GClass499 item in enumerable)
            {
                GClass510 gClass = ((optionalData == null || !optionalData.Boolean_0) ? gclass507_0.method_1(item.Pointer) : gclass507_0.method_0(item.Pointer));
                if (gClass != null)
                {
                    item.String_0 = gclass504_0.method_0(gClass.OffsetDest);
                }
            }
            foreach (GInterface5 item2 in GClass107<GInterface5>.smethod_1(gclass154_0))
            {
                GClass510 gClass2 = gclass507_0.method_1(item2.Pointer);
                if (gClass2 != null)
                {
                    binaryReader_0.smethod_0(gClass2.OffsetDest);
                    item2.imethod_4(binaryReader_0);
                }
            }
        }
    }

    private IList<GClass510> ilist_0;

    private IDictionary<uint, GClass510> idictionary_0;

    private IDictionary<uint, GClass510> idictionary_1;

    private IList<GClass510> ilist_1;

    public GClass507()
        : base(GEnum23.const_5)
    {
        ilist_0 = [];
        idictionary_0 = new Dictionary<uint, GClass510>();
        idictionary_1 = new Dictionary<uint, GClass510>();
    }

    public GClass510 method_0(uint uint_0)
    {
        idictionary_1.TryGetValue(uint_0, out var value);
        return value;
    }

    public GClass510 method_1(uint uint_0)
    {
        idictionary_0.TryGetValue(uint_0, out var value);
        return value;
    }

    public void method_2(GClass510 gclass510_0)
    {
        if (gclass510_0.Vlt)
        {
            idictionary_1.Add(gclass510_0.OffsetSource, gclass510_0);
        }
        else
        {
            idictionary_0.Add(gclass510_0.OffsetSource, gclass510_0);
        }
    }

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        ilist_0 = [];
        idictionary_0 = new Dictionary<uint, GClass510>();
        idictionary_1 = new Dictionary<uint, GClass510>();
        bool flag = false;
        while (true)
        {
            GClass510 gClass = new();
            gClass.vmethod_0(binaryReader_0);
            if (gClass.Type == GClass510.GEnum21.const_1)
            {
                continue;
            }
            gClass.Vlt = flag;
            ilist_0.Add(gClass);
            switch (gClass.Type)
            {
                case GClass510.GEnum21.const_1:
                    if (flag)
                    {
                        idictionary_1.Add(gClass.OffsetSource, gClass);
                    }
                    else
                    {
                        idictionary_0.Add(gClass.OffsetSource, gClass);
                    }
                    break;
                case GClass510.GEnum21.const_2:
                    if (gClass.Identifier == 0 || gClass.Identifier == 1)
                    {
                        flag = gClass.Identifier == 0;
                        break;
                    }
                    throw new Exception("Invalid identifier: " + gClass.Identifier);
                case GClass510.GEnum21.const_3:
                    if (gClass.Identifier == 1)
                    {
                        if (flag)
                        {
                            idictionary_1.Add(gClass.OffsetSource, gClass);
                        }
                        else
                        {
                            idictionary_0.Add(gClass.OffsetSource, gClass);
                        }
                        break;
                    }
                    throw new Exception("Unknown pointer type.");
                default:
                    throw new Exception();
                case GClass510.GEnum21.const_0:
                    return;
            }
        }
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        ilist_1 = [];
        GClass510 gClass = new()
        {
            Identifier = 1,
            Type = GClass510.GEnum21.const_2
        };
        gClass.vmethod_1(binaryWriter_0);
        ilist_1.Add(gClass);
        foreach (GClass510 item in idictionary_0.Values.OrderBy(gclass510_0 => gclass510_0.OffsetSource))
        {
            item.vmethod_1(binaryWriter_0);
            ilist_1.Add(item);
        }
        GClass510 gClass2 = new()
        {
            Identifier = 0,
            Type = GClass510.GEnum21.const_2
        };
        gClass2.vmethod_1(binaryWriter_0);
        ilist_1.Add(gClass2);
        foreach (GClass510 item2 in idictionary_1.Values.OrderBy(gclass510_0 => gclass510_0.OffsetSource))
        {
            item2.vmethod_1(binaryWriter_0);
            ilist_1.Add(item2);
        }
        GClass510 gClass3 = new()
        {
            Type = GClass510.GEnum21.const_0
        };
        gClass3.vmethod_1(binaryWriter_0);
        ilist_1.Add(gClass3);
    }

    public void method_3(GClass483 gclass483_0, GClass504 gclass504_0)
    {
        if (gclass483_0.Types != null)
        {
            method_2(smethod_1(gclass483_0.Types));
        }
        foreach (GClass536 @class in gclass483_0.Classes)
        {
            method_2(smethod_1(@class));
        }
        foreach (GClass537 row in gclass483_0.Rows)
        {
            if (row.Class.HasBaseFields)
            {
                method_2(smethod_1(row));
            }
        }
        foreach (GClass536 class2 in gclass483_0.Classes)
        {
            foreach (GInterface5 item in GClass107<GInterface5>.smethod_1(class2))
            {
                if (!item.imethod_3())
                {
                    continue;
                }
                GClass510 gclass510_ = smethod_0(item);
                method_2(gclass510_);
                GClass515 gClass = item as GClass515;
                if (gClass?.Pointer1 != null)
                {
                    GClass510 gclass510_2 = smethod_0(gClass.Pointer1);
                    method_2(gclass510_2);
                    GClass510 gclass510_3 = smethod_0(gClass.Pointer2);
                    method_2(gclass510_3);
                    GClass510 gclass510_4 = smethod_0(gClass.Pointer3);
                    method_2(gclass510_4);
                }
                if (gClass?.MultipleCustomData == null)
                {
                    continue;
                }
                foreach (GClass521 multipleCustomDatum in gClass.MultipleCustomData)
                {
                    GClass510 gclass510_5 = smethod_0(multipleCustomDatum.CustomData1);
                    method_2(gclass510_5);
                    GClass510 gclass510_6 = smethod_0(multipleCustomDatum.CustomData2);
                    method_2(gclass510_6);
                    GClass510 gclass510_7 = smethod_0(multipleCustomDatum.CustomData3);
                    method_2(gclass510_7);
                }
            }
        }
        foreach (GClass537 row2 in gclass483_0.Rows)
        {
            row2.smethod_0(delegate (GClass154 gclass154_0)
            {
                method_4(gclass504_0, gclass154_0);
            });
        }
    }

    private static GClass510 smethod_0(GInterface5 ginterface5_0)
    {
        return new GClass510
        {
            OffsetSource = ginterface5_0.Pointer,
            OffsetDest = ginterface5_0.OffsetDest,
            Type = GClass510.GEnum21.const_3,
            Identifier = 1,
            Vlt = ginterface5_0.imethod_2()
        };
    }

    private static GClass510 smethod_1(GInterface8 ginterface8_0)
    {
        return new GClass510
        {
            OffsetSource = ginterface8_0.Pointer,
            OffsetDest = ginterface8_0.OffsetDest,
            Type = GClass510.GEnum21.const_3,
            Identifier = 1,
            Vlt = true
        };
    }

    private void method_4(GClass504 gclass504_0, GClass154 gclass154_0)
    {
        foreach (GClass499 item in GClass107<GClass499>.smethod_1(gclass154_0))
        {
            if (item.Pointer != 0 && item.GeneratePointer)
            {
                uint offsetDest = gclass504_0.method_1(item.String_0);
                GClass510 gclass510_ = new()
                {
                    OffsetSource = item.Pointer,
                    OffsetDest = offsetDest,
                    Type = GClass510.GEnum21.const_3,
                    Identifier = 1,
                    Vlt = (gclass154_0.OptionalData?.Boolean_0 ?? false)
                };
                method_2(gclass510_);
            }
        }
        foreach (GInterface5 item2 in GClass107<GInterface5>.smethod_1(gclass154_0))
        {
            if (item2.imethod_3())
            {
                GClass510 gclass510_2 = smethod_0(item2);
                method_2(gclass510_2);
            }
        }
        GClass148 optionalData = gclass154_0.OptionalData;
        if (optionalData != null && !optionalData.Boolean_0)
        {
            method_2(smethod_1(optionalData));
        }
    }

    public void method_5(GClass483 gclass483_0, GClass504 gclass504_0, BinaryReader binaryReader_0)
    {
        foreach (GClass537 row in gclass483_0.Rows)
        {
            row.smethod_0(delegate (GClass154 gclass154_0)
            {
                IEnumerable<GClass499> enumerable = GClass107<GClass499>.smethod_1(gclass154_0);
                GClass148 optionalData = gclass154_0.OptionalData;
                foreach (GClass499 item in enumerable)
                {
                    GClass510 gClass = ((optionalData == null || !optionalData.Boolean_0) ? method_1(item.Pointer) : method_0(item.Pointer));
                    if (gClass != null)
                    {
                        item.String_0 = gclass504_0.method_0(gClass.OffsetDest);
                    }
                }
                foreach (GInterface5 item2 in GClass107<GInterface5>.smethod_1(gclass154_0))
                {
                    GClass510 gClass2 = method_1(item2.Pointer);
                    if (gClass2 != null)
                    {
                        binaryReader_0.smethod_0(gClass2.OffsetDest);
                        item2.imethod_4(binaryReader_0);
                    }
                }
            });
        }
    }
}
