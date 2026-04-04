using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace VaultEditor;

public sealed class GClass110<T, U>
{
    public struct GStruct12<V, W>(KeyValuePair<V, W> keyValuePair_0)
    {
        public V gparam_0 = keyValuePair_0.Key;

        public W gparam_1 = keyValuePair_0.Value;
    }

    private readonly XmlSerializer xmlSerializer_0 = new(typeof(List<GStruct12<T, U>>));

    public void method_0(Dictionary<T, U> dictionary_0, Stream stream_0)
    {
        xmlSerializer_0.Serialize(stream_0, smethod_0(dictionary_0));
    }

    private static List<GStruct12<T, U>> smethod_0(Dictionary<T, U> dictionary_0)
    {
        return [.. dictionary_0.Select(keyValuePair_0 => new GStruct12<T, U>(keyValuePair_0))];
    }

    public Dictionary<T, U> method_1(Stream stream_0)
    {
        return smethod_1(xmlSerializer_0.Deserialize(stream_0) as List<GStruct12<T, U>>);
    }

    private static Dictionary<T, U> smethod_1(ICollection<GStruct12<T, U>> icollection_0)
    {
        Dictionary<T, U> dictionary = new(icollection_0.Count);
        foreach (GStruct12<T, U> item in icollection_0)
        {
            dictionary.Add(item.gparam_0, item.gparam_1);
        }
        return dictionary;
    }
}
