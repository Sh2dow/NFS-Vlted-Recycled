using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace VaultEditor;

internal sealed class Class234
{
    private static Regex regex_0;

    private static readonly Regex regex_1 = new("\"(?<p1>[^\"]*)\"|(?<p1>[^\\s]+)");

    public Class234()
    {
        string text = string.Join("|", GClass541.String_0);
        regex_0 = new Regex("^\\s*(?<c>" + text + ")\\s*(?<p>[^\\n#]*)");
    }

    public IEnumerable<Class263> method_0(string string_0)
    {
        string[] array = File.ReadAllLines(string_0);
        string directoryName = Path.GetDirectoryName(string_0);
        int num = 0;
        string[] array2 = array;
        foreach (string string_1 in array2)
        {
            int num2 = num + 1;
            num = num2;
            Class263 @class = method_1(string_0, string_1, num);
            yield return @class;
            if (@class.Value is not Class246)
            {
                continue;
            }
            Class246 class2 = (Class246)@class.Value;
            string string_2 = Path.Combine(directoryName, class2.Path);
            IEnumerable<Class263> enumerable = method_0(string_2);
            foreach (Class263 item in enumerable)
            {
                yield return item;
            }
        }
    }

    public Class263 method_1(string string_0, string string_1, int int_0)
    {
        string string_2 = string.Empty;
        string scriptName = string.Empty;
        if (File.Exists(string_0))
        {
            string_2 = Path.GetDirectoryName(string_0);
            scriptName = Path.GetFileName(string_0);
        }
        Class263 @class = new()
        {
            Line = string_1,
            LineNumber = int_0,
            ScriptName = scriptName
        };
        try
        {
            Match match = regex_0.Match(string_1);
            if (!match.Success)
            {
                @class.IsComment = true;
                return @class;
            }
            @class.Line = match.Value;
            string value = match.Groups["c"].Value;
            string value2 = match.Groups["p"].Value;
            @class.TextStart = match.Index;
            @class.TextLength = match.Length;
            if (value == "ui_text")
            {
                @class.Value = method_2(value, [value2], string_2);
            }
            else
            {
                List<string> ilist_ = [.. (from match_0 in regex_1.Matches(value2).OfType<Match>()
                                       select match_0.Groups["p1"].Value)];
                @class.Value = method_2(value, ilist_, string_2);
            }
        }
        catch (Exception ex)
        {
            @class.method_1(ex.Message);
        }
        return @class;
    }

    public static void smethod_0(Class261 class261_0, VaultDatabase gclass478_0)
    {
        class261_0.Executed.Clear();
        Dictionary<string, bool> dictionary = class261_0.Controls.Where(class260_0 => !string.IsNullOrEmpty(class260_0.String_0)).ToDictionary(class260_0 => class260_0.String_0, class260_0 => class260_0.Checked);
        string text = null;
        bool flag = true;
        foreach (Class263 command in class261_0.Commands)
        {
            try
            {
                if (command.Value is Class242 { String_1: var string_ })
                {
                    if (text == null)
                    {
                        flag = dictionary[string_];
                        text = string_;
                    }
                    else
                    {
                        flag = true;
                        text = null;
                    }
                }
                else if (flag && command.Value != null)
                {
                    command.method_4(gclass478_0);
                    class261_0.Executed.Add(command);
                }
            }
            catch (Exception ex)
            {
                command.method_1($"Unable to execute command. {command}: {ex.Message}");
            }
        }
    }

    private GClass541 method_2(string string_0, IList<string> ilist_0, string string_1)
    {
        switch (Class265.smethod_0(string_0))
        {
            case 755820523u:
                if (string_0 == "ui_text")
                {
                    return new Class249(ilist_0[0]);
                }
                goto default;
            case 615907305u:
                if (string_0 == "copy_node")
                {
                    if (ilist_0.Count == 3)
                    {
                        uint uint_6 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_7 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        string string_5 = ilist_0[2];
                        return new Class252(uint_6, uint_7, 0u, string_5);
                    }
                    if (ilist_0.Count == 4)
                    {
                        uint uint_8 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_9 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        uint uint_10 = GClass486.smethod_8(ilist_0[2], bool_0: true);
                        string string_6 = ilist_0[3];
                        return new Class252(uint_8, uint_9, uint_10, string_6);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 540962730u:
                if (string_0 == "script")
                {
                    if (ilist_0.Count == 1)
                    {
                        return new Class246(ilist_0[0]);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 1181855383u:
                if (string_0 == "version")
                {
                    if (ilist_0.Count == 1)
                    {
                        return new Class244(ilist_0[0]);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 1112135431u:
                if (string_0 == "game")
                {
                    return new Class247(ilist_0);
                }
                goto default;
            case 1083392391u:
                if (string_0 == "convert_field")
                {
                    if (ilist_0.Count == 3)
                    {
                        uint uint_28 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_29 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        string string_17 = ilist_0[2];
                        return new Class238(uint_28, uint_29, string_17);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 1859251540u:
                if (string_0 == "delete_nodes")
                {
                    if (ilist_0.Count == 1)
                    {
                        return new Class240(GClass486.smethod_8(ilist_0[0], bool_0: true));
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 1640196987u:
                if (string_0 == "add_field")
                {
                    if (ilist_0.Count != 3 && ilist_0.Count != 4)
                    {
                        throw new Exception("Invalid parameter count");
                    }
                    uint uint_17 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                    uint uint_18 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                    uint uint_19 = GClass486.smethod_8(ilist_0[2], bool_0: true);
                    short short_ = 0;
                    if (ilist_0.Count == 4)
                    {
                        short_ = Convert.ToInt16(ilist_0[3]);
                    }
                    return new Class254(uint_17, uint_18, uint_19, short_);
                }
                goto default;
            case 1630654826u:
                if (string_0 == "resize_collection")
                {
                    if ((ilist_0.Count == 4) | (ilist_0.Count == 5))
                    {
                        uint uint_38 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_39 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        string[] array3 = ilist_0[2].Split(['[', ']'], StringSplitOptions.RemoveEmptyEntries);
                        uint uint_40 = GClass486.smethod_8(array3[0], bool_0: true);
                        int int_4 = 0;
                        if (array3.Length > 1)
                        {
                            int_4 = Convert.ToInt32(array3[1]);
                        }
                        string string_20 = string.Empty;
                        int int_5;
                        if (ilist_0.Count == 4)
                        {
                            int_5 = Convert.ToInt32(ilist_0[3]);
                        }
                        else
                        {
                            string_20 = ilist_0[3];
                            int_5 = Convert.ToInt32(ilist_0[4]);
                        }
                        return new Class236(uint_38, uint_39, int_4, uint_40, string_20, int_5);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 2295961317u:
                if (string_0 == "update_collection")
                {
                    if ((ilist_0.Count == 6) | (ilist_0.Count == 7))
                    {
                        uint uint_30 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_31 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        string[] array2 = ilist_0[2].Split(['[', ']'], StringSplitOptions.RemoveEmptyEntries);
                        uint uint_32 = GClass486.smethod_8(array2[0], bool_0: true);
                        int int_2 = 0;
                        if (array2.Length > 1)
                        {
                            int_2 = Convert.ToInt32(array2[1]);
                        }
                        string string_18 = string.Empty;
                        int int_3;
                        string string_19;
                        string object_2;
                        if (ilist_0.Count == 6)
                        {
                            int_3 = Convert.ToInt32(ilist_0[3]);
                            string_19 = ilist_0[4];
                            object_2 = ilist_0[5];
                        }
                        else
                        {
                            string_18 = ilist_0[3];
                            int_3 = Convert.ToInt32(ilist_0[4]);
                            string_19 = ilist_0[5];
                            object_2 = ilist_0[6];
                        }
                        return new Class237(uint_30, uint_31, int_2, uint_32, string_18, int_3, string_19, object_2);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 2227483509u:
                if (string_0 == "ui_option")
                {
                    if (ilist_0.Count != 1 && ilist_0.Count != 2)
                    {
                        throw new Exception("Invalid parameter count");
                    }
                    string string_3 = ilist_0[0];
                    string string_4 = string.Empty;
                    if (ilist_0.Count == 2)
                    {
                        string_4 = ilist_0[1];
                    }
                    return new Class242(string_3, string_4);
                }
                goto default;
            case 1911044526u:
                if (string_0 == "resize_field")
                {
                    if (ilist_0.Count == 4)
                    {
                        uint uint_35 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_36 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        uint uint_37 = GClass486.smethod_8(ilist_0[2], bool_0: true);
                        short short_2 = Convert.ToInt16(ilist_0[3]);
                        return new Class255(uint_35, uint_36, uint_37, short_2);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 3232154048u:
                if (string_0 == "rename_node")
                {
                    if (ilist_0.Count == 3)
                    {
                        uint uint_26 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_27 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        string string_16 = ilist_0[2];
                        return new Class258(uint_26, uint_27, string_16);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 3217812049u:
                if (string_0 == "delete_field")
                {
                    if (ilist_0.Count == 3)
                    {
                        uint uint_11 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_12 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        uint uint_13 = GClass486.smethod_8(ilist_0[2], bool_0: true);
                        return new Class253(uint_11, uint_12, uint_13);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 2374829186u:
                if (string_0 == "folder_create")
                {
                    if (ilist_0.Count == 1)
                    {
                        return new Class239(ilist_0[0]);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 3746890159u:
                if (string_0 == "delete_node")
                {
                    if (ilist_0.Count == 2)
                    {
                        uint uint_33 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_34 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        return new Class257(uint_33, uint_34);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 3687054425u:
                if (string_0 == "add_node")
                {
                    if (ilist_0.Count == 2)
                    {
                        uint uint_23 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        string string_14 = ilist_0[1];
                        return new Class256(uint_23, 0u, string_14);
                    }
                    if (ilist_0.Count == 3)
                    {
                        uint uint_24 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_25 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        string string_15 = ilist_0[2];
                        return new Class256(uint_24, uint_25, string_15);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 3591018449u:
                if (string_0 == "ui_control")
                {
                    if (ilist_0.Count == 4)
                    {
                        string string_9 = ilist_0[0];
                        string string_10 = ilist_0[1];
                        string string_11 = ilist_0[2];
                        string string_12 = ilist_0[3];
                        return new Class243(string_9, string_10, string_11, string_12);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 4009621177u:
                if (string_0 == "move_node")
                {
                    if (ilist_0.Count == 3)
                    {
                        uint uint_3 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_4 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        uint uint_5 = GClass486.smethod_8(ilist_0[2], bool_0: true);
                        return new Class241(uint_3, uint_4, uint_5);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 3775585545u:
                if (string_0 == "ui_image")
                {
                    if (ilist_0.Count == 1)
                    {
                        return new Class248(string_1, ilist_0[0]);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 3755335035u:
                if (string_0 == "update_field")
                {
                    if ((ilist_0.Count == 4) | (ilist_0.Count == 5))
                    {
                        uint uint_20 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_21 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        string[] array = ilist_0[2].Split(['[', ']'], StringSplitOptions.RemoveEmptyEntries);
                        uint uint_22 = GClass486.smethod_8(array[0], bool_0: true);
                        int int_ = 0;
                        if (array.Length > 1)
                        {
                            int_ = Convert.ToInt32(array[1]);
                        }
                        string string_13 = string.Empty;
                        object object_ = null;
                        if (ilist_0.Count == 4)
                        {
                            object_ = ilist_0[3];
                        }
                        else if (ilist_0.Count == 5)
                        {
                            string_13 = ilist_0[3];
                            object_ = ilist_0[4];
                        }
                        return new Class259(uint_20, uint_21, int_, uint_22, string_13, object_);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 4178771016u:
                if (string_0 == "copy_fields")
                {
                    if (ilist_0.Count == 4)
                    {
                        uint uint_14 = GClass486.smethod_8(ilist_0[0], bool_0: true);
                        uint uint_15 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                        uint uint_16 = GClass486.smethod_8(ilist_0[2], bool_0: true);
                        List<string> ilist_1 = [.. ilist_0[3].Split('|')];
                        return new Class245(uint_14, uint_15, uint_16, ilist_1);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 4052575577u:
                if (string_0 == "file_copy")
                {
                    if (ilist_0.Count == 2)
                    {
                        string string_7 = ilist_0[0];
                        string string_8 = ilist_0[1];
                        return new Class251(string_1, string_7, string_8);
                    }
                    throw new Exception("Invalid parameter count");
                }
                goto default;
            case 4009666330u:
                if (string_0 == "change_vault")
                {
                    if (ilist_0.Count != 3)
                    {
                        throw new Exception("Invalid parameter count");
                    }
                    uint uint_ = GClass486.smethod_8(ilist_0[0], bool_0: true);
                    uint uint_2 = GClass486.smethod_8(ilist_0[1], bool_0: true);
                    string string_2 = ilist_0[2];
                    return new Class250(uint_, uint_2, string_2);
                }
                goto default;
            default:
                throw new Exception("Unsupported command");
        }
    }
}
