using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace VaultEditor;

public sealed class GClass82
{
    private readonly List<object> list_0 = [];

    [CompilerGenerated]
    private bool bool_0;

    private bool bool_1;

    [CompilerGenerated]
    private FastColoredTextBox fastColoredTextBox_0;

    public bool AllowMacroRecordingByUser
    {
        [CompilerGenerated]
        get
        {
            return bool_0;
        }
        [CompilerGenerated]
        set
        {
            bool_0 = value;
        }
    }

    public FastColoredTextBox UnderlayingControl
    {
        [CompilerGenerated]
        get
        {
            return fastColoredTextBox_0;
        }
        [CompilerGenerated]
        private set
        {
            fastColoredTextBox_0 = value;
        }
    }

    public bool Boolean_0
    {
        get
        {
            return bool_1;
        }
        set
        {
            bool_1 = value;
            UnderlayingControl.method_4();
        }
    }

    public bool Boolean_1 => list_0.Count == 0;

    public string String_0
    {
        get
        {
            CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            KeysConverter keysConverter = new();
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine("<macros>");
            foreach (object item in list_0)
            {
                if (item is Keys)
                {
                    stringBuilder.AppendFormat("<item key='{0}' />\r\n", keysConverter.ConvertToString((Keys)item));
                }
                else if (item is KeyValuePair<char, Keys> keyValuePair)
                {
                    stringBuilder.AppendFormat("<item char='{0}' key='{1}' />\r\n", (int)keyValuePair.Key, keysConverter.ConvertToString(keyValuePair.Value));
                }
            }
            stringBuilder.AppendLine("</macros>");
            Thread.CurrentThread.CurrentUICulture = currentUICulture;
            return stringBuilder.ToString();
        }
        set
        {
            bool_1 = false;
            method_3();
            if (string.IsNullOrEmpty(value))
            {
                return;
            }
            XmlDocument xmlDocument = new();
            xmlDocument.LoadXml(value);
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("./macros/item");
            CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            KeysConverter keysConverter = new();
            if (xmlNodeList != null)
            {
                foreach (XmlElement item in xmlNodeList)
                {
                    XmlAttribute attributeNode = item.GetAttributeNode("char");
                    XmlAttribute attributeNode2 = item.GetAttributeNode("key");
                    if (attributeNode != null)
                    {
                        if (attributeNode2 != null)
                        {
                            method_1((char)int.Parse(attributeNode.Value), (Keys)keysConverter.ConvertFromString(attributeNode2.Value));
                        }
                        else
                        {
                            method_1((char)int.Parse(attributeNode.Value), Keys.None);
                        }
                    }
                    else if (attributeNode2 != null)
                    {
                        method_2((Keys)keysConverter.ConvertFromString(attributeNode2.Value));
                    }
                }
            }
            Thread.CurrentThread.CurrentUICulture = currentUICulture;
        }
    }

    internal GClass82(FastColoredTextBox fastColoredTextBox_1)
    {
        UnderlayingControl = fastColoredTextBox_1;
        AllowMacroRecordingByUser = true;
    }

    public void method_0()
    {
        Boolean_0 = false;
        UnderlayingControl.method_86();
        UnderlayingControl.GClass84_5.method_38();
        UnderlayingControl.method_107();
        foreach (object item in list_0)
        {
            if (item is Keys)
            {
                UnderlayingControl.vmethod_30((Keys)item);
            }
            if (item is KeyValuePair<char, Keys> keyValuePair)
            {
                UnderlayingControl.vmethod_41(keyValuePair.Key, keyValuePair.Value);
            }
        }
        UnderlayingControl.method_108();
        UnderlayingControl.GClass84_5.method_39();
        UnderlayingControl.method_87();
    }

    public void method_1(char char_0, Keys keys_0)
    {
        list_0.Add(new KeyValuePair<char, Keys>(char_0, keys_0));
    }

    public void method_2(Keys keys_0)
    {
        list_0.Add(keys_0);
    }

    public void method_3()
    {
        list_0.Clear();
    }

    internal void method_4(Keys keys_0)
    {
        if (Boolean_0)
        {
            method_2(keys_0);
        }
    }

    internal void method_5(char char_0, Keys keys_0)
    {
        if (Boolean_0)
        {
            method_1(char_0, keys_0);
        }
    }
}
