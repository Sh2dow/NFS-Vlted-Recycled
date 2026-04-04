using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using VaultEditor;

namespace UserSettings;

[Serializable]
public class Settings
{
    [Browsable(false)]
    public string FilePath { get; set; }

    [DisplayName("Dark theme")]
    [Description("Restart is required for changes to take effect.")]
    public bool DarkTheme { get; set; }

    [DisplayName("Start maximized window")]
    public bool StartMaximizedWindow { get; set; }

    [DisplayName("Save command history to a log file")]
    public bool LogHistory { get; set; }

    [Description("Script Editor content will be remembered while closing and will be restored on startup.")]
    [Category("Script Editor")]
    [DisplayName("Automatically restore script")]
    public bool ScriptEditorAutoRestore { get; set; }

    [Category("Script Editor")]
    [DisplayName("Track active command in tree")]
    [Description("Node associated with current command being edited will be selected on tree automatically.")]
    public bool ScriptEditorTracking { get; set; }

    [DisplayName("Store mod commands")]
    [Description("After installing the ModScript file, the commands will be stored in the Script Editor (not recommended).")]
    [Category("Script Editor")]
    public bool ScriptEditorStoreModCommands { get; set; }

    [Browsable(false)]
    public string LastSelection { get; set; }

    [Browsable(false)]
    public bool SkipComments { get; set; }

    [Browsable(false)]
    public List<string> MostRecentlyUsed { get; set; }

    [Browsable(false)]
    public string SearchNodeText { get; set; }

    [Browsable(false)]
    public string SearchFieldText { get; set; }

    [Browsable(false)]
    public string SearchValueText { get; set; }

    [Browsable(false)]
    public bool SearchInNode { get; set; }

    [Browsable(false)]
    public bool SearchInField { get; set; }

    [Browsable(false)]
    public bool SearchInValue { get; set; }

    public Settings()
    {
        SearchInNode = true;
        SearchInField = true;
        SearchInValue = false;
        LogHistory = true;
        ScriptEditorAutoRestore = true;
        ScriptEditorTracking = true;
        MostRecentlyUsed = [];
    }

    public void method_0(string string_0)
    {
        MostRecentlyUsed.Insert(0, string_0);
        MostRecentlyUsed = [.. MostRecentlyUsed.Distinct()];
        if (MostRecentlyUsed.Count > 10)
        {
            MostRecentlyUsed = [.. MostRecentlyUsed.Take(10)];
        }
    }

    public void method_1()
    {
        MostRecentlyUsed.Clear();
    }

    public static Settings smethod_0()
    {
        try
        {
            using FileStream stream_ = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings.xml"), FileMode.Open);
            return GClass112.smethod_2<Settings>(stream_);
        }
        catch (Exception)
        {
            return new Settings();
        }
    }

    public static void smethod_1(Settings settings_0)
    {
        try
        {
            using FileStream stream_ = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings.xml"), FileMode.Create);
            GClass112.smethod_3(stream_, settings_0);
        }
        catch (Exception)
        {
        }
    }
}
