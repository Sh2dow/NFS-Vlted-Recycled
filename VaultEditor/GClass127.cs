using System.IO;

namespace VaultEditor;

[GAttribute2(Type = GEnum15.const_6)]
public sealed class GClass127 : GClass119
{
    public void imethod_3(BinaryReader binaryReader_0, int int_1)
    {
        method_3<Class136>(binaryReader_0);
        method_3<Class131>(binaryReader_0);
        method_3<Class135>(binaryReader_0);
        method_3<Class132>(binaryReader_0);
        method_3<Class151>(binaryReader_0);
        method_3<Class133>(binaryReader_0);
        method_3<Class134>(binaryReader_0);
    }

    public void imethod_4(BinaryWriter binaryWriter_0)
    {
        foreach (GInterface3 item in ilist_0)
        {
            item.imethod_1(binaryWriter_0);
        }
    }
}
