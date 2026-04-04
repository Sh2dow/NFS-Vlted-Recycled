using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VaultEditor;

internal class Class209
{
    protected static IList<GClass541> smethod_0(Form form_0, VaultDatabase gclass478_0, GClass154 gclass154_0, MemoryStream memoryStream_0)
    {
        IList<GClass541> list = [];
        IEnumerable<GClass150> enumerable = GClass108.smethod_0(gclass154_0.GetType());
        IDictionary<GClass150, object> dictionary = new Dictionary<GClass150, object>();
        foreach (GClass150 item in enumerable)
        {
            dictionary.Add(item, item.method_0(gclass154_0));
        }
        BinaryReader binaryReader = new(memoryStream_0);
        binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
        gclass154_0.vmethod_0(binaryReader);
        foreach (KeyValuePair<GClass150, object> item2 in dictionary)
        {
            GClass150 key = item2.Key;
            GAttribute1 attribute = key.Attribute;
            object obj = key.method_0(gclass154_0);
            if (!obj.Equals(item2.Value))
            {
                uint classNameHash = gclass154_0.DataRow.ClassNameHash;
                uint uInt32_ = gclass154_0.DataRow.UInt32_0;
                int arrayIndex = gclass154_0.ArrayIndex;
                uint nameHash = gclass154_0.Field.NameHash;
                Class259 @class = new(classNameHash, uInt32_, arrayIndex, nameHash, attribute.Name, obj);
                GClass542 gClass = @class.vmethod_2(gclass478_0);
                if (gClass.Boolean_0)
                {
                    GClass109.smethod_1(form_0, gClass.method_0());
                }
                else
                {
                    list.Add(@class);
                }
            }
        }
        return list;
    }
}
