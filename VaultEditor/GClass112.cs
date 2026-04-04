using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace VaultEditor;

public static class GClass112
{
    public static T smethod_0<T>(string string_0) where T : class
    {
        using FileStream stream_ = new(string_0, FileMode.Open, FileAccess.Read);
        return smethod_2<T>(stream_);
    }

    public static void smethod_1<T>(string string_0, T gparam_0)
    {
        using FileStream stream_ = new(string_0, FileMode.Create, FileAccess.Write);
        smethod_3(stream_, gparam_0);
    }

    public static T smethod_2<T>(Stream stream_0) where T : class
    {
        return new XmlSerializer(typeof(T)).Deserialize(stream_0) as T;
    }

    public static void smethod_3<T>(Stream stream_0, T gparam_0)
    {
        XmlSerializer xmlSerializer = new(typeof(T));
        try
        {
            xmlSerializer.Serialize(stream_0, gparam_0);
        }
        catch (Exception)
        {
        }
    }

    public static void smethod_4<T, U>(Stream stream_0, Dictionary<T, U> dictionary_0)
    {
        new GClass110<T, U>().method_0(dictionary_0, stream_0);
    }

    public static Dictionary<T, U> smethod_5<T, U>(Stream stream_0)
    {
        return new GClass110<T, U>().method_1(stream_0);
    }
}
