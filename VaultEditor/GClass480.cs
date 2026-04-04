using System.Collections.Generic;
using System.IO;

namespace VaultEditor;

public sealed class GClass480
{
    public static void smethod_0(GEnum1 genum1_0, string string_0, GClass483 gclass483_0, IDictionary<uint, GClass536> idictionary_0, GClass502 gclass502_0)
    {
        MemoryStream binStream = gclass483_0.BinStream;
        BinaryReader binaryReader = new(gclass483_0.VltStream);
        BinaryReader binaryReader_ = new(binStream);
        if ((uint)(genum1_0 - 4) <= 4u)
        {
            gclass502_0.imethod_0(genum1_0, binaryReader);
        }
        GClass506 gClass = new(gclass483_0.Name);
        GClass508 gClass2 = new();
        switch (genum1_0)
        {
            case GEnum1.const_6:
            case GEnum1.const_7:
            case GEnum1.const_8:
                gClass2.imethod_0(genum1_0, binaryReader);
                gClass.imethod_0(genum1_0, binaryReader);
                break;
            case GEnum1.const_3:
            case GEnum1.const_4:
            case GEnum1.const_5:
                gClass.imethod_0(genum1_0, binaryReader);
                gClass2.imethod_0(genum1_0, binaryReader);
                break;
        }
        new GClass503().imethod_0(genum1_0, binaryReader);
        GClass505 gClass3 = new(gclass483_0);
        gClass3.imethod_0(genum1_0, binaryReader);
        GClass507 gClass4 = new();
        gClass4.imethod_0(genum1_0, binaryReader);
        if (genum1_0 == GEnum1.const_7)
        {
            new GClass501().imethod_0(genum1_0, binaryReader);
        }
        gClass3.method_0(genum1_0, binaryReader);
        gClass3.method_2(gClass4, binaryReader_);
        binStream.Seek(0L, SeekOrigin.Begin);
        GClass504 gClass5 = new();
        gClass5.imethod_0(genum1_0, binaryReader_);
        gClass3.method_3(genum1_0, binaryReader_, binaryReader, idictionary_0);
        gClass4.method_5(gclass483_0, gClass5, binaryReader_);
    }

    public static void smethod_1(GEnum1 genum1_0, GClass483 gclass483_0, GClass502 gclass502_0)
    {
        MemoryStream memoryStream = new();
        MemoryStream memoryStream2 = new();
        BinaryWriter binaryWriter = new(memoryStream);
        BinaryWriter binaryWriter_ = new(memoryStream2);
        memoryStream2.Seek(0L, SeekOrigin.Begin);
        GClass504 gClass = new(gclass483_0);
        if (genum1_0 == GEnum1.const_7)
        {
            gClass.int_1 = 0;
            gClass.imethod_1(genum1_0, binaryWriter_);
            new GClass501().imethod_1(genum1_0, binaryWriter_);
        }
        else
        {
            gClass.imethod_1(genum1_0, binaryWriter_);
        }
        if ((uint)(genum1_0 - 4) <= 4u)
        {
            gclass502_0.imethod_1(genum1_0, binaryWriter);
        }
        GClass506 gClass2 = new(gclass483_0.Name);
        GClass508 gClass3 = new();
        switch (genum1_0)
        {
            case GEnum1.const_6:
            case GEnum1.const_7:
            case GEnum1.const_8:
                gClass3.imethod_1(genum1_0, binaryWriter);
                gClass2.imethod_1(genum1_0, binaryWriter);
                break;
            case GEnum1.const_3:
            case GEnum1.const_4:
            case GEnum1.const_5:
                gClass2.imethod_1(genum1_0, binaryWriter);
                gClass3.imethod_1(genum1_0, binaryWriter);
                break;
        }
        GClass505 gClass4 = new(gclass483_0);
        new GClass503(gClass4).imethod_1(genum1_0, binaryWriter);
        gClass4.imethod_1(genum1_0, binaryWriter);
        gClass4.method_6(genum1_0, binaryWriter_, binaryWriter);
        GClass507 gClass5 = new();
        gClass5.method_3(gclass483_0, gClass);
        gClass5.imethod_1(genum1_0, binaryWriter);
        if (genum1_0 == GEnum1.const_7)
        {
            new GClass501().imethod_1(genum1_0, binaryWriter);
        }
        gclass483_0.BinStream = memoryStream2;
        gclass483_0.VltStream = memoryStream;
    }
}
