using System.IO;

namespace VaultEditor;

[GAttribute2(PreAlignBlock = 128, Type = GEnum15.const_43)]
internal sealed class Class146 : GClass119
{
    public void imethod_3(BinaryReader binaryReader_0, int int_1)
    {
        method_3<Class147>(binaryReader_0);
        method_3<Class154>(binaryReader_0);
        method_3<Class158>(binaryReader_0);
        method_3<Class145>(binaryReader_0);
        method_3<Class180>(binaryReader_0);
        method_3<Class159>(binaryReader_0);
        method_3<Class160>(binaryReader_0);
        method_3<Class161>(binaryReader_0);
        method_3<Class162>(binaryReader_0);
        method_3<Class163>(binaryReader_0);
        method_3<Class164>(binaryReader_0);
        method_3<Class155>(binaryReader_0);
        method_3<Class156>(binaryReader_0);
        method_3<Class157>(binaryReader_0);
    }

    public void imethod_4(BinaryWriter binaryWriter_0)
    {
        foreach (GInterface3 item in ilist_0)
        {
            item.imethod_1(binaryWriter_0);
        }
    }
}
