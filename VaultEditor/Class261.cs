using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class261
{
    [CompilerGenerated]
    private IList<Image> ilist_0;

    [CompilerGenerated]
    private IList<Class263> ilist_1;

    [CompilerGenerated]
    private IList<Class263> ilist_2;

    [CompilerGenerated]
    private IList<Class260> ilist_3;

    public IList<Image> Images
    {
        [CompilerGenerated]
        get
        {
            return ilist_0;
        }
        [CompilerGenerated]
        set
        {
            ilist_0 = value;
        }
    }

    public IList<Class263> Commands
    {
        [CompilerGenerated]
        get
        {
            return ilist_1;
        }
        [CompilerGenerated]
        set
        {
            ilist_1 = value;
        }
    }

    public IList<Class263> Executed
    {
        [CompilerGenerated]
        get
        {
            return ilist_2;
        }
        [CompilerGenerated]
        set
        {
            ilist_2 = value;
        }
    }

    public IList<Class260> Controls
    {
        [CompilerGenerated]
        get
        {
            return ilist_3;
        }
        [CompilerGenerated]
        set
        {
            ilist_3 = value;
        }
    }

    public Class261()
    {
        Images = [];
        Commands = [];
        Executed = [];
        Controls = [];
    }

    public static Class261 smethod_0(IEnumerable<Class263> ienumerable_0)
    {
        Class261 @class = new();
        HashSet<string> hashSet = [];
        string text = null;
        foreach (Class263 item in ienumerable_0)
        {
            if (item.IsComment || item.Value is Class247 || item.Value is Class246)
            {
                continue;
            }
            if (item.Value is Class243)
            {
                Class243 class2 = item.Value as Class243;
                GClass542 gClass = class2.vmethod_2(null);
                if (!gClass.Boolean_0)
                {
                    string string_ = class2.Data.String_0;
                    if (!hashSet.Contains(string_))
                    {
                        hashSet.Add(string_);
                        @class.Controls.Add(class2.Data);
                        continue;
                    }
                    throw new Exception($"{item}:\r\nDuplicate control name has been found: {string_}");
                }
                throw new Exception($"{item}:\r\n{gClass.method_0()}");
            }
            if (item.Value is Class249)
            {
                Class249 class3 = item.Value as Class249;
                GClass542 gClass2 = class3.vmethod_2(null);
                if (!gClass2.Boolean_0)
                {
                    @class.Controls.Add(class3.Data);
                    continue;
                }
                throw new Exception($"{item}:\r\n{gClass2.method_0()}");
            }
            if (item.Value is Class248 class4)
            {
                class4.vmethod_2(null);
                if (!item.Boolean_0)
                {
                    @class.Images.Add(class4.Image);
                }
                continue;
            }
            if (item.Value is Class242 class5)
            {
                if (!hashSet.Contains(class5.String_1))
                {
                    throw new Exception($"{item}:\r\nThe control with the specified name wasn't found: " + class5.ControlName);
                }
                string string_2 = class5.String_1;
                if (text == null)
                {
                    text = string_2;
                }
                else
                {
                    if (text != string_2)
                    {
                        throw new Exception($"{item}:\r\nMissing closing ui_option: " + class5.ControlName);
                    }
                    text = null;
                }
            }
            @class.Commands.Add(item);
        }
        return @class;
    }
}
