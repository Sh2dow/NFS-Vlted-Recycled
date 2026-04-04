using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using UserSettings;

namespace VaultEditor;

public sealed class MainForm : Form
{
    [CompilerGenerated]
    private sealed class Class9
    {
        public List<GClass541> list_0;

        public GClass537 gclass537_0;

        public MainForm mainForm_0;

        internal void method_0(GClass537 gclass537_1)
        {
            Class256 item = new(gclass537_1.Class.UInt32_0, gclass537_1.ParentHash, $"0x{gclass537_1.UInt32_0:x8}");
            list_0.Add(item);
            foreach (GClass154 item3 in gclass537_0)
            {
                uint nameHash = item3.Field.NameHash;
                if (item3.Field.Boolean_1)
                {
                    short short_ = 0;
                    if (item3 is GClass155 gClass)
                    {
                        short_ = gClass.ValidCount;
                    }
                    Class254 item2 = new(gclass537_1.Class.UInt32_0, gclass537_1.UInt32_0, nameHash, short_);
                    list_0.Add(item2);
                }
                IEnumerable<GClass541> collection = mainForm_0.method_24(item3, gclass537_0.Class.UInt32_0, gclass537_0.UInt32_0);
                list_0.AddRange(collection);
            }
        }
    }

    [CompilerGenerated]
    private sealed class Class11
    {
        public string string_0;

        public MainForm mainForm_0;

        internal void method_0(object sender, EventArgs e)
        {
            if (mainForm_0.gclass478_0 != null)
            {
                VaultDatabase gclass478_ = mainForm_0.gclass478_0;
                if (gclass478_ == null || gclass478_.UnsavedChanges)
                {
                    VaultDatabase gclass478_2 = mainForm_0.gclass478_0;
                    if (gclass478_2 == null || !gclass478_2.UnsavedChanges || GClass109.smethod_3(mainForm_0, "There are unsaved changes. Do you really want to continue?") != DialogResult.Yes)
                    {
                        return;
                    }
                }
            }
            mainForm_0.method_15(string_0);
        }
    }

    private readonly FormFind formFind_0;

    private readonly Settings settings_0;

    private readonly ImageList imageList_0 = new();

    private Class117 class117_0;

    private GEnum1 genum1_0;

    private VaultDatabase gclass478_0;

    private readonly string string_0;

    private readonly Class118 class118_0;

    private GClass537 gclass537_0;

    private IContainer icontainer_0;

    private MenuStrip MainMenu;

    private TreeView ClassesTree;

    private StatusStrip Status;

    private SplitContainer splitContainer1;

    private ToolStripMenuItem EditMenu;

    private ToolStripMenuItem MenuFindNext;

    private ToolStripStatusLabel LabelStatus;

    private ToolStripMenuItem MenuOptions;

    private ToolStripMenuItem MenuSettings;

    private ToolStripMenuItem helpToolStripMenuItem;

    private ToolStripMenuItem aboutToolStripMenuItem;

    private PropertyGrid PropertyGrid;

    private SplitContainer splitContainer3;

    private ToolStripMenuItem MenuMarkValue;

    private ToolStripMenuItem viewToolStripMenuItem;

    private ToolStripMenuItem valuesToolStripMenuItem;

    private ToolStripMenuItem MenuViewAlphabetical;

    private ToolStripMenuItem MenuViewCategorized;

    private ToolStripMenuItem LogsMenu;

    private ToolStripMenuItem FindMeu;

    private FastColoredTextBox ScriptTextBox;

    private ToolStripMenuItem MenuConvertMWPSToModScript;

    private ToolStripMenuItem MenuScriptEditor;

    private ToolStripMenuItem MenuScriptEditorClear;

    private ToolStripMenuItem MenuScriptEditorExecute;

    private ToolStripMenuItem MenuScriptEditorExecuteLine;

    private ToolStripMenuItem FileMenu;

    private ToolStripMenuItem MenuOpen;

    private ToolStripMenuItem MenuReload;

    private ToolStripMenuItem MenuSave;

    private ToolStripSeparator toolStripSeparator6;

    private ToolStripMenuItem MenuImport;

    private ToolStripMenuItem ImportModScriptMenu;

    private ToolStripMenuItem ImportModMenu;

    private ToolStripMenuItem ImportMWPSMenu;

    private ToolStripMenuItem MenuNFSCarbonConfiguration;

    private ToolStripMenuItem MenuExport;

    private ToolStripMenuItem ExportModScriptMenu;

    private ToolStripSeparator MenuMRUSeparator1;

    private ToolStripMenuItem MenuClearRecentlyUsed;

    private ToolStripSeparator MenuMRUSeparator2;

    private ToolStripMenuItem MenuExit;

    private ToolStripMenuItem MainMenuGame;

    private ToolStripMenuItem MenuRunGame;

    private ToolStripMenuItem MenuRestoreBackups;

    private ToolStripMenuItem MenuAssociateModScript;

    private ToolStripStatusLabel StatusCounter;

    public MainForm()
    {
        base.KeyPreview = true;
        settings_0 = Settings.smethod_0();
        Class187.DarkTheme = settings_0.DarkTheme;
        InitializeComponent();
        formFind_0 = new FormFind
        {
            ClassesTree = ClassesTree,
            PropertyGrid = PropertyGrid
        };
        method_13();
        method_32();
        string_0 = "NFS-VltEd v" + GClass0.ToolVersionString + " by nfsu360";
        Text = string_0;
        if (settings_0.StartMaximizedWindow)
        {
            base.WindowState = FormWindowState.Maximized;
        }
        else
        {
            Rectangle bounds = Screen.FromControl(this).Bounds;
            base.Size = new Size((int)((double)bounds.Width * 0.75), (int)((double)bounds.Height * 0.75));
            CenterToScreen();
        }
        FormCollectionsEditor.Event_0 += method_17;
        FormCollectionsEditor.Event_1 += method_18;
        ContextMenuStrip contextMenuStrip = new()
        {
            Items = { (ToolStripItem)new ToolStripMenuItem("Generate command", Class13.Mark, MenuMarkValue_Click, Keys.Insert) }
        };
        contextMenuStrip.smethod_12();
        PropertyGrid.ContextMenuStrip = contextMenuStrip;
        PropertyGrid.PropertyValueChanged += PropertyGrid_PropertyValueChanged;
        ClassesTree.DrawMode = TreeViewDrawMode.OwnerDrawText;
        ClassesTree.AfterSelect += ClassesTree_AfterSelect;
        imageList_0.Images.Add(Class13.root_folder);
        imageList_0.Images.Add(Class13.root_folder_selected);
        imageList_0.Images.Add(Class13.folder);
        imageList_0.Images.Add(Class13.folder_selected);
        ClassesTree.ImageList = imageList_0;
        class118_0 = new Class118(ScriptTextBox);
        class118_0.Event_0 += method_3;
        class118_0.Event_1 += method_1;
        if (settings_0.ScriptEditorAutoRestore)
        {
            class118_0.method_5();
        }
        base.Load += Editor_Load;
        base.Closing += Editor_Closing;
        base.Activated += Editor_Activated;
    }

    private void Editor_Activated(object sender, EventArgs e)
    {
        method_0();
    }

    private void method_0()
    {
        if (!method_31())
        {
            return;
        }
        bool flag = false;
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("The following files have been modified by another program or imported ModScript file:");
        stringBuilder.AppendLine();
        foreach (KeyValuePair<Class217, GClass502> item in gclass478_0.ilist_0)
        {
            Class217 key = item.Key;
            FileInfo fileInfo = new(key.Path);
            if (fileInfo.Exists)
            {
                DateTime lastWriteTime = fileInfo.LastWriteTime;
                if (lastWriteTime != key.TimeStamp)
                {
                    key.TimeStamp = lastWriteTime;
                    stringBuilder.AppendLine(key.Path);
                    flag = true;
                }
            }
        }
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("Do you want to reload the database?");
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("Yes - ALL changes will be lost due to loading files from the disk");
        stringBuilder.AppendLine("No - Leave the currently loaded database");
        if (flag)
        {
            if (GClass109.smethod_3(this, stringBuilder.ToString(), DialogResult.No) == DialogResult.Yes)
            {
                gclass478_0.UnsavedChanges = false;
                MenuReload_Click(null, null);
            }
            else
            {
                gclass478_0.method_10();
            }
        }
    }

    private void method_1(int int_0, int int_1)
    {
        method_27("Script executed (" + ((int_1 > int_0) ? $"lines: {int_0} - {int_1}" : $"line: {int_0}") + ")");
        PropertyGrid.Refresh();
    }

    private GridItem method_2(GridItem gridItem_0)
    {
        if (gridItem_0 == null)
        {
            return null;
        }
        if (gridItem_0.Value is GClass154)
        {
            return gridItem_0;
        }
        return method_2(gridItem_0.Parent);
    }

    private void method_3(string string_1)
    {
        if (method_31() && settings_0.ScriptEditorTracking)
        {
            GClass540 gClass = new Class234().method_1(string.Empty, string_1, 0).Value?.vmethod_1(gclass478_0);
            if (gClass?.Node != null)
            {
                ClassesTree.SelectedNode = gClass.Node;
            }
        }
    }

    private void method_4(object sender, EventArgs e)
    {
        TreeNode selectedNode = ClassesTree.SelectedNode;
        if (selectedNode is GClass537)
        {
            FormFieldsEditor formFieldsEditor = new()
            {
                Database = gclass478_0,
                Row = (selectedNode as GClass537)
            };
            formFieldsEditor.ShowDialog();
            method_5([.. formFieldsEditor.Results]);
            PropertyGrid.Refresh();
        }
    }

    private void method_5(params GClass541[] gclass541_0)
    {
        if (gclass541_0.Any())
        {
            string text = string.Join(Environment.NewLine, gclass541_0.Select(gClass2 => gClass2.vmethod_0())) + Environment.NewLine;
            class118_0.method_2(text);
            if (settings_0.LogHistory)
            {
                IList<string> list = [];
                list.Insert(0, $"# {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                foreach (GClass541 gClass in gclass541_0)
                {
                    list.Add(gClass.vmethod_0());
                }
                Class121.smethod_0(genum1_0, list);
            }
        }
        PropertyGrid.Refresh();
    }

    private void method_6(object sender, EventArgs e)
    {
        if (ClassesTree.SelectedNode is not GClass537 gClass)
        {
            return;
        }
        GClass537 gClass2 = gClass;
        bool flag = gClass2.Equals(gclass537_0);
        Class257 @class = new(gClass2.ClassNameHash, gClass2.UInt32_0);
        GClass542 gClass3 = @class.vmethod_2(gclass478_0);
        if (gClass3.Boolean_0)
        {
            GClass109.smethod_1(this, gClass3.method_0());
            return;
        }
        if (flag)
        {
            gclass537_0 = null;
        }
        method_5(@class);
    }

    private void method_7(object sender, EventArgs e)
    {
        if (ClassesTree.SelectedNode is GClass536 gClass)
        {
            Class240 @class = new(gClass.UInt32_0);
            GClass542 gClass2 = @class.vmethod_2(gclass478_0);
            if (gClass2.Boolean_0)
            {
                GClass109.smethod_1(this, gClass2.method_0());
                return;
            }
            gclass537_0 = null;
            method_5(@class);
        }
    }

    private void method_8(object sender, EventArgs e)
    {
        TreeNode selectedNode = ClassesTree.SelectedNode;
        if (selectedNode is GClass537)
        {
            gclass537_0 = (GClass537)selectedNode;
            method_21();
        }
    }

    private void method_9(object sender, EventArgs e)
    {
        if (gclass537_0 == null)
        {
            return;
        }
        smethod_0(ClassesTree.SelectedNode, out var gclass536_, out var uint_);
        if (gclass537_0.Class != gclass536_)
        {
            return;
        }
        string text = GClass109.smethod_4(this, "Enter a node name", gclass537_0.Text + "_copy");
        if (text != null)
        {
            Class252 @class = new(gclass536_.UInt32_0, gclass537_0.UInt32_0, uint_, text);
            GClass542 gClass = @class.vmethod_2(gclass478_0);
            if (gClass.Boolean_0)
            {
                GClass109.smethod_1(this, gClass.method_0());
                method_9(sender, e);
            }
            else
            {
                method_5(@class);
            }
        }
    }

    private void method_10(object sender, EventArgs e)
    {
        if (gclass537_0 == null || !(ClassesTree.SelectedNode is GClass537 { Class: var gClass2 } gClass) || gclass537_0.Class != gClass.Class)
        {
            return;
        }
        IDictionary<string, string> dictionary = new Dictionary<string, string>();
        if (gClass2.HasBaseFields)
        {
            dictionary.Add(Class245.keyValuePair_0);
        }
        if (gclass537_0.Any(gclass154_0 => gclass154_0.Field.Boolean_1))
        {
            dictionary.Add(Class245.keyValuePair_1);
            dictionary.Add(Class245.keyValuePair_2);
        }
        if (dictionary.Count == 0)
        {
            GClass109.smethod_1(this, "Nothing to copy from '" + gclass537_0.Text + "'");
            return;
        }
        List<string> list = [.. GClass109.smethod_5(this, "What would you like to copy from '" + gclass537_0.Text + "'?", dictionary)];
        if (list.Any())
        {
            Class245 @class = new(gClass2.UInt32_0, gclass537_0.UInt32_0, gClass.UInt32_0, list);
            GClass542 gClass3 = @class.vmethod_2(gclass478_0);
            if (gClass3.Boolean_0)
            {
                GClass109.smethod_1(this, gClass3.method_0());
                return;
            }
            method_5(@class);
        }
    }

    private void method_11(object sender, EventArgs e)
    {
        TreeNode selectedNode = ClassesTree.SelectedNode;
        if (selectedNode == null)
        {
            return;
        }
        string text = GClass109.smethod_4(this, "Enter a node name");
        if (text != null)
        {
            smethod_0(selectedNode, out var gclass536_, out var uint_);
            Class256 @class = new(gclass536_.UInt32_0, uint_, text);
            GClass542 gClass = @class.vmethod_2(gclass478_0);
            if (gClass.Boolean_0)
            {
                GClass109.smethod_1(this, gClass.method_0());
                method_11(sender, e);
            }
            else
            {
                method_5(@class);
            }
        }
    }

    private static void smethod_0(TreeNode treeNode_0, out GClass536 gclass536_0, out uint uint_0)
    {
        gclass536_0 = null;
        uint_0 = 0u;
        if (treeNode_0 is GClass536 gClass)
        {
            gclass536_0 = gClass;
            uint_0 = 0u;
        }
        if (treeNode_0 is GClass537 gClass2)
        {
            gclass536_0 = gClass2.Class;
            uint_0 = gClass2.UInt32_0;
        }
    }

    private void method_12(object sender, EventArgs e)
    {
        TreeNode selectedNode = ClassesTree.SelectedNode;
        if (selectedNode == null)
        {
            return;
        }
        if (selectedNode is GClass536)
        {
            GClass109.smethod_1(this, "Root node cannot be renamed");
            return;
        }
        string text = GClass109.smethod_4(this, "Enter a node name", selectedNode.Text);
        if (text != null)
        {
            GClass537 obj = (GClass537)selectedNode;
            uint classNameHash = obj.ClassNameHash;
            uint uInt32_ = obj.UInt32_0;
            Class258 @class = new(classNameHash, uInt32_, text);
            GClass542 gClass = @class.vmethod_2(gclass478_0);
            if (gClass.Boolean_0)
            {
                GClass109.smethod_1(this, gClass.method_0());
                method_12(sender, e);
            }
            else
            {
                method_5(@class);
            }
        }
    }

    private void method_13()
    {
        this.smethod_1();
        MainMenu.smethod_10();
        Status.smethod_23();
        LabelStatus.smethod_21();
        StatusCounter.smethod_21();
        ClassesTree.smethod_22();
        PropertyGrid.smethod_16();
        ScriptTextBox.smethod_20();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void Editor_Load(object sender, EventArgs e)
    {
        method_15(settings_0.FilePath);
        formFind_0.Boolean_1 = settings_0.SearchInNode;
        formFind_0.Boolean_0 = settings_0.SearchInField;
        formFind_0.Boolean_2 = settings_0.SearchInValue;
        formFind_0.String_2 = settings_0.SearchNodeText;
        formFind_0.String_0 = settings_0.SearchFieldText;
        formFind_0.String_1 = settings_0.SearchValueText;
    }

    private void method_14()
    {
        GClass535 gClass = ClassesTree.smethod_0().FirstOrDefault(gclass535_0 => gclass535_0.ToString() == settings_0.LastSelection);
        if (gClass != null)
        {
            ClassesTree.SelectedNode = gClass;
            gClass.EnsureVisible();
        }
    }

    private void Editor_Closing(object sender, CancelEventArgs e)
    {
        VaultDatabase gClass = gclass478_0;
        if (gClass != null && gClass.UnsavedChanges && GClass109.smethod_3(this, "There are unsaved changes. Do you really want to quit?") == DialogResult.No)
        {
            e.Cancel = true;
            return;
        }
        class118_0.method_4();
        settings_0.LastSelection = ClassesTree.SelectedNode?.ToString();
        settings_0.SearchNodeText = formFind_0.String_2;
        settings_0.SearchFieldText = formFind_0.String_0;
        settings_0.SearchValueText = formFind_0.String_1;
        settings_0.SearchInNode = formFind_0.Boolean_1;
        settings_0.SearchInField = formFind_0.Boolean_0;
        settings_0.SearchInValue = formFind_0.Boolean_2;
        Settings.smethod_1(settings_0);
    }

    private void method_15(string string_1)
    {
        if (string.IsNullOrWhiteSpace(string_1))
        {
            return;
        }
        Stopwatch.StartNew();
        if (!new DirectoryInfo(string_1).Exists)
        {
            GClass109.smethod_1(this, "The folder does not exist: " + string_1);
            return;
        }
        StatusCounter.Text = string.Empty;
        LabelStatus.Text = string.Empty;
        gclass478_0 = null;
        method_32();
        gclass537_0 = null;
        genum1_0 = GEnum1.const_0;
        class118_0.method_9();
        gclass478_0 = new VaultDatabase();
        Text = string_0;
        try
        {
            GEnum1 gEnum;
            try
            {
                class117_0 = new Class117();
                gEnum = class117_0.method_0(string_1);
            }
            catch (Exception ex)
            {
                throw new Exception0(ex.Message);
            }
            switch (gEnum)
            {
                default:
                    gclass478_0.method_2(gEnum, string_1);
                    genum1_0 = gEnum;
                    if (gclass478_0.Boolean_0)
                    {
                        string text = string.Join(", ", gclass478_0.method_1().Select(Path.GetFileName));
                        settings_0.FilePath = string_1;
                        method_27(string_1 + " (loaded: " + text + ")");
                        Text = string_0 + " | " + GClass0.smethod_0(genum1_0);
                        settings_0.method_0(string_1);
                    }
                    break;
                case GEnum1.const_9:
                    throw new Exception0("Invalid game version");
                case GEnum1.const_1:
                case GEnum1.const_2:
                    throw new Exception0("Not supported game: " + GClass0.smethod_0(gEnum));
                case GEnum1.const_0:
                    throw new Exception0("Unable to detect game version");
            }
        }
        catch (Exception0 exception)
        {
            gclass478_0 = null;
            string text2 = "The folder you selected:" + Environment.NewLine + Environment.NewLine + string_1 + Environment.NewLine + Environment.NewLine + "does not contain the supported version of the Need For Speed game." + Environment.NewLine + Environment.NewLine + "Reason: " + exception.Message;
            GClass109.smethod_1(this, text2);
        }
        catch (Exception)
        {
            gclass478_0 = null;
            string text3 = "The folder you selected:" + Environment.NewLine + Environment.NewLine + string_1 + Environment.NewLine + Environment.NewLine + "does not contain the supported version of the Need For Speed game.";
            GClass109.smethod_1(this, text3);
        }
        method_20();
        method_32();
        method_14();
        formFind_0.method_0();
    }

    private void method_16(GClass541 gclass541_0, VaultDatabase gclass478_1 = null)
    {
        GClass542 gClass = gclass541_0.vmethod_2(gclass478_1 ?? gclass478_0);
        if (gClass.Boolean_0)
        {
            GClass109.smethod_1(this, gClass.method_0());
            return;
        }
        method_5(gclass541_0);
    }

    private void PropertyGrid_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
    {
        PropertyGrid.Refresh();
        if (method_19(out var _, out var object_, out var uint_, out var uint_2, out var int_, out var uint_3, out var string_))
        {
            Class259 gclass541_ = new(uint_, uint_2, int_, uint_3, string_, object_);
            method_16(gclass541_);
        }
    }

    private void method_17(int int_0, string string_1, object object_0)
    {
        if (method_19(out var _, out var _, out var uint_, out var uint_2, out var int_1, out var uint_3, out var string_2))
        {
            Class237 gclass541_ = new(uint_, uint_2, int_1, uint_3, string_2, int_0, string_1, object_0);
            method_16(gclass541_);
        }
    }

    private void method_18(int int_0)
    {
        if (method_19(out var _, out var _, out var uint_, out var uint_2, out var int_1, out var uint_3, out var string_))
        {
            Class236 gclass541_ = new(uint_, uint_2, int_1, uint_3, string_, int_0);
            method_16(gclass541_);
        }
    }

    private bool method_19(out GClass154 gclass154_0, out object object_0, out uint uint_0, out uint uint_1, out int int_0, out uint uint_2, out string string_1)
    {
        object_0 = null;
        uint_0 = 0u;
        uint_1 = 0u;
        int_0 = 0;
        uint_2 = 0u;
        string_1 = null;
        PropertyDescriptor obj = PropertyGrid.SelectedGridItem?.PropertyDescriptor;
        gclass154_0 = null;
        object_0 = null;
        GClass509 gClass = obj as GClass509;
        if (gClass != null)
        {
            gclass154_0 = gClass.VltDataItem;
            object_0 = gClass.GetValue(gclass154_0);
            if (gClass.IsReadOnly)
            {
                return false;
            }
        }
        if (gclass154_0 == null)
        {
            return false;
        }
        uint_0 = gclass154_0.DataRow.ClassNameHash;
        uint_1 = gclass154_0.DataRow.UInt32_0;
        int_0 = gclass154_0.ArrayIndex;
        uint_2 = gclass154_0.Field.NameHash;
        bool isSingleValue = gclass154_0.IsSingleValue;
        string_1 = string.Empty;
        if (!isSingleValue)
        {
            string_1 = gClass.DisplayName;
        }
        return true;
    }

    private void method_20()
    {
        ClassesTree.Nodes.Clear();
        if (gclass478_0 != null)
        {
            foreach (GClass536 item in gclass478_0.Classes.Values.OrderBy(gclass536_0 => gclass536_0.Text))
            {
                ClassesTree.Nodes.Add(item);
            }
        }
        ClassesTree_AfterSelect(null, null);
    }

    private void ClassesTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
        method_26(e?.Node);
        method_21();
    }

    private void method_21()
    {
        TreeNode selectedNode = ClassesTree.SelectedNode;
        ContextMenuStrip contextMenuStrip = new();
        contextMenuStrip.Items.Add(new ToolStripMenuItem("Find", Class13.Search, FindMeu_Click, Keys.F | Keys.Control));
        contextMenuStrip.Items.Add(new ToolStripMenuItem("Find Next", Class13.Search, MenuFindNext_Click, Keys.F3));
        contextMenuStrip.Items.Add(new ToolStripSeparator());
        if (selectedNode is GClass536)
        {
            GClass536 gClass = selectedNode as GClass536;
            contextMenuStrip.Items.Add(new ToolStripMenuItem("Add", Class13.Add, method_11, Keys.A | Keys.Control));
            if (gclass537_0 != null && gclass537_0.Class == gClass)
            {
                contextMenuStrip.Items.Add(new ToolStripSeparator());
                contextMenuStrip.Items.Add(new ToolStripMenuItem("Paste [" + gclass537_0.Text + "]", Class13.Paste, method_9, Keys.V | Keys.Control));
            }
            ClassesTree.ContextMenuStrip = contextMenuStrip;
            ClassesTree.ContextMenuStrip.smethod_12();
        }
        else if (selectedNode is GClass537)
        {
            GClass537 gClass2 = selectedNode as GClass537;
            bool num = gClass2.Class.IEnumerable_1.Any(gclass151_0 => gclass151_0.Boolean_1) || gClass2.Class.IEnumerable_1.Any(gclass151_0 => gclass151_0.Boolean_0);
            contextMenuStrip.Items.Add(new ToolStripMenuItem("Add", Class13.Add, method_11, Keys.A | Keys.Control));
            contextMenuStrip.Items.Add(new ToolStripMenuItem("Rename", Class13.Rename, method_12, Keys.R | Keys.Control));
            contextMenuStrip.Items.Add(new ToolStripMenuItem("Delete", Class13.Delete, method_6, Keys.D | Keys.Control));
            contextMenuStrip.Items.Add(new ToolStripSeparator());
            contextMenuStrip.Items.Add(new ToolStripMenuItem("Copy", Class13.Copy, method_8, Keys.C | Keys.Control));
            if (gclass537_0 != null && gclass537_0.Class == gClass2.Class)
            {
                contextMenuStrip.Items.Add(new ToolStripMenuItem("Paste [" + gclass537_0.Text + "]", Class13.Paste, method_9, Keys.V | Keys.Control));
                if (!gClass2.Equals(gclass537_0))
                {
                    contextMenuStrip.Items.Add(new ToolStripMenuItem("Paste Into Selection [" + gclass537_0.Text + "]", Class13.Paste, method_10, Keys.B | Keys.Control));
                }
            }
            if (num)
            {
                contextMenuStrip.Items.Add(new ToolStripSeparator());
                contextMenuStrip.Items.Add(new ToolStripMenuItem("Edit fields", Class13.Edit, method_4, Keys.Z | Keys.Control));
            }
            if (gClass2.Class.UInt32_0 == GClass486.smethod_8("gameplay"))
            {
                contextMenuStrip.Items.Add(new ToolStripSeparator());
                contextMenuStrip.Items.Add(new ToolStripMenuItem("Change vault", Class13.Edit, method_25, Keys.W | Keys.Control));
            }
        }
        ClassesTree.ContextMenuStrip = contextMenuStrip;
        ClassesTree.ContextMenuStrip.smethod_12();
    }

    private void method_22(object sender, EventArgs e)
    {
        TreeNode selectedNode = ClassesTree.SelectedNode;
        if (selectedNode == null)
        {
            return;
        }
        List<GClass541> list = [];
        VaultDatabase gClass = gclass478_0.method_9();
        if (selectedNode is GClass536)
        {
            foreach (GClass537 item3 in selectedNode.Nodes.OfType<GClass537>())
            {
                Class257 item = new(item3.Class.UInt32_0, item3.UInt32_0);
                list.Add(item);
                IEnumerable<GClass541> collection = method_23(item3);
                list.AddRange(collection);
            }
        }
        else
        {
            GClass537 gClass2 = (GClass537)selectedNode;
            Class257 item2 = new(gClass2.Class.UInt32_0, gClass2.UInt32_0);
            list.Add(item2);
            IEnumerable<GClass541> collection2 = method_23(gClass2);
            list.AddRange(collection2);
        }
        IList<GClass541> list2 = [];
        GClass542 gClass3 = new();
        foreach (GClass541 item4 in list)
        {
            GClass542 gClass4 = item4.vmethod_2(gClass);
            if (gClass4.Boolean_0)
            {
                gClass3.method_3(gClass4);
            }
            else
            {
                list2.Add(item4);
            }
        }
        if (gClass3.Boolean_0)
        {
            GClass109.smethod_1(this, gClass3.method_0());
        }
        method_5([.. list2]);
    }

    private IEnumerable<GClass541> method_23(GClass537 gclass537_1)
    {
        List<GClass541> list_0 = [];
        gclass537_1.smethod_2(delegate (GClass537 gClass)
        {
            Class256 item = new(gClass.Class.UInt32_0, gClass.ParentHash, $"0x{gClass.UInt32_0:x8}");
            list_0.Add(item);
            foreach (GClass154 item3 in gclass537_1)
            {
                uint nameHash = item3.Field.NameHash;
                if (item3.Field.Boolean_1)
                {
                    short short_ = 0;
                    if (item3 is GClass155 gClass2)
                    {
                        short_ = gClass2.ValidCount;
                    }
                    Class254 item2 = new(gClass.Class.UInt32_0, gClass.UInt32_0, nameHash, short_);
                    list_0.Add(item2);
                }
                IEnumerable<GClass541> collection = method_24(item3, gclass537_1.Class.UInt32_0, gclass537_1.UInt32_0);
                list_0.AddRange(collection);
            }
        });
        return list_0;
    }

    private IEnumerable<GClass541> method_24(GClass154 gclass154_0, uint uint_0, uint uint_1)
    {
        List<PropertyDescriptor> list = [.. gclass154_0.GetProperties().OfType<PropertyDescriptor>()];
        foreach (PropertyDescriptor item in list)
        {
            string displayName = item.DisplayName;
            PropertyDescriptor propertyDescriptor = item;
            if (propertyDescriptor == null)
            {
                continue;
            }
            if (propertyDescriptor is not GClass509 gClass)
            {
                if (propertyDescriptor is not GClass489 gClass2)
                {
                    continue;
                }
                GClass489 gClass3 = gClass2;
                IEnumerable<GClass541> enumerable = method_24(gClass3.VltDataItem, uint_0, uint_1);
                foreach (GClass541 item2 in enumerable)
                {
                    yield return item2;
                }
            }
            else
            {
                GClass509 gClass4 = gClass;
                if (!item.IsReadOnly)
                {
                    GClass154 vltDataItem = gClass4.VltDataItem;
                    object value = item.GetValue(vltDataItem);
                    int arrayIndex = vltDataItem.ArrayIndex;
                    yield return new Class259(uint_0, uint_1, arrayIndex, gclass154_0.Field.NameHash, displayName, value);
                }
            }
        }
    }

    private void method_25(object sender, EventArgs e)
    {
        TreeNode selectedNode = ClassesTree.SelectedNode;
        if (selectedNode == null)
        {
            return;
        }
        if (selectedNode is GClass536)
        {
            GClass109.smethod_1(this, "Root node cannot be updated");
            return;
        }
        GClass537 gClass = (GClass537)selectedNode;
        string text = GClass109.smethod_4(this, "Enter a vault name", gClass.GroupName);
        if (text != null)
        {
            uint classNameHash = gClass.ClassNameHash;
            uint uInt32_ = gClass.UInt32_0;
            Class250 @class = new(classNameHash, uInt32_, text);
            GClass542 gClass2 = @class.vmethod_2(gclass478_0);
            if (gClass2.Boolean_0)
            {
                GClass109.smethod_1(this, gClass2.method_0());
                method_25(sender, e);
            }
            else
            {
                method_5(@class);
            }
        }
    }

    private void method_26(TreeNode treeNode_0)
    {
        PropertyGrid.SelectedObject = null;
        PropertyGrid.SelectedObjects = null;
        if (treeNode_0 == null)
        {
            return;
        }
        if (treeNode_0 is GClass536 gClass)
        {
            List<GClass537> list = [.. gClass.Nodes.OfType<GClass537>()];
            int int_ = list.Count;
            foreach (GClass537 item in list)
            {
                item.method_11(ref int_);
            }
            StatusCounter.Text = $"Nodes: {list.Count} Total: {int_}";
        }
        else if (treeNode_0 is GClass537 gClass2)
        {
            PropertyGrid.SelectedObject = gClass2;
            int count = gClass2.Nodes.Count;
            int int_2 = 0;
            gClass2.method_11(ref int_2);
            StatusCounter.Text = $"Nodes: {count} Total: {int_2}";
        }
    }

    private void MenuOpen_Click(object sender, EventArgs e)
    {
        VaultDatabase gClass = gclass478_0;
        if (gClass == null || !gClass.UnsavedChanges || GClass109.smethod_3(this, "There are unsaved changes. Do you really want to continue?") != DialogResult.No)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                Description = "Choose the root directory of Need For Speed: Most Wanted, Carbon, ProStreet, Undercover or World Online",
                SelectedPath = settings_0.FilePath
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                method_15(selectedPath);
            }
        }
    }

    private void MenuSave_Click(object sender, EventArgs e)
    {
        if (!method_28())
        {
            return;
        }
        try
        {
            gclass478_0.method_7(bool_1: true);
            new Class216().method_0(settings_0.FilePath);
            method_27("The changes have been saved.");
        }
        catch (Exception)
        {
            GClass109.smethod_1(this, "An error occurred while saving. The changes could not be saved.");
        }
    }

    private void method_27(string string_1)
    {
        LabelStatus.Text = $"{DateTime.Now:HH:mm:ss} | {string_1}";
    }

    private void MenuExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private bool method_28(params GEnum1[] genum1_1)
    {
        if (!method_31())
        {
            GClass109.smethod_0(this, "Load a database first");
            return false;
        }
        if (genum1_1.Any() && !genum1_1.Contains(genum1_0))
        {
            GClass109.smethod_0(this, "This feature can be used only for the following game(s):" + Environment.NewLine + string.Join(",", genum1_1.Select(GClass0.smethod_0)));
            return false;
        }
        return true;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new FormAbout().ShowDialog();
    }

    private void MenuReload_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            VaultDatabase gClass = gclass478_0;
            if (gClass == null || !gClass.UnsavedChanges || GClass109.smethod_3(this, "There are unsaved changes. Do you really want to reload the database?") != DialogResult.No)
            {
                settings_0.LastSelection = ClassesTree.SelectedNode?.ToString();
                method_15(settings_0.FilePath);
            }
        }
    }

    private void MenuMarkValue_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            PropertyGrid_PropertyValueChanged(null, null);
        }
    }

    private void MenuSettings_Click(object sender, EventArgs e)
    {
        FormSettings formSettings = new()
        {
            Settings_0 = settings_0
        };
        formSettings.ShowDialog(this);
        method_26(ClassesTree.SelectedNode);
    }

    private void MenuViewAlphabetical_Click(object sender, EventArgs e)
    {
        PropertyGrid.PropertySort = PropertySort.Alphabetical;
    }

    private void MenuViewCategorized_Click(object sender, EventArgs e)
    {
        PropertyGrid.PropertySort = PropertySort.Categorized;
    }

    private void ExportModScriptMenu_Click(object sender, EventArgs e)
    {
        if (!method_28())
        {
            return;
        }
        string text = class118_0.method_3();
        if (string.IsNullOrWhiteSpace(text))
        {
            GClass109.smethod_0(this, "No changes to export.");
            return;
        }
        SaveFileDialog saveFileDialog = new()
        {
            AddExtension = true,
            DefaultExt = "nfsms",
            Title = "Export ModScript file",
            Filter = "*.nfsms|*.nfsms"
        };
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        string fileName = saveFileDialog.FileName;
        try
        {
            File.WriteAllText(fileName, text);
        }
        catch (Exception)
        {
            GClass109.smethod_1(this, "Unable to export file");
        }
    }

    private void method_29(GForm0 gform0_0, bool bool_0)
    {
        gform0_0.ClassesTree = ClassesTree;
        gform0_0.Database = gclass478_0;
        gform0_0.ShowDialog();
        if (bool_0)
        {
            method_5([.. gform0_0.Commands]);
        }
        PropertyGrid.Refresh();
    }

    private void LogsMenu_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            FormLogs formLogs = new()
            {
                Version = genum1_0,
                Settings = settings_0
            };
            formLogs.ShowDialog();
        }
    }

    private void ImportModMenu_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            method_29(new FormCfgImporter(), bool_0: true);
        }
    }

    private void ImportModScriptMenu_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            FormModScriptImporter gform0_ = new();
            method_29(gform0_, settings_0.ScriptEditorStoreModCommands);
        }
    }

    private void ImportMWPSMenu_Click(object sender, EventArgs e)
    {
        if (method_28(GEnum1.const_3))
        {
            method_29(new FormMwpsImporter(), bool_0: true);
        }
    }

    private void MenuConvertMWPSToModScript_Click(object sender, EventArgs e)
    {
        if (method_28(GEnum1.const_3))
        {
            method_29(new FormMwpsConverter(), bool_0: true);
        }
    }

    private void MenuNFSCarbonConfiguration_Click(object sender, EventArgs e)
    {
        if (!method_28(GEnum1.const_4))
        {
            return;
        }
        OpenFileDialog openFileDialog = new()
        {
            AddExtension = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DefaultExt = "carbon",
            ShowReadOnly = true,
            Title = "Import NFS: Carbon Car Settings",
            Filter = "NFS:Carbon Settings (*.carbon)|*.carbon",
            Multiselect = false
        };
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        IList<GClass541> list = [];
        try
        {
            Class262<List<GClass541>> @class = new Class210().method_0(gclass478_0, openFileDialog.FileName);
            if (@class.Boolean_0)
            {
                GClass109.smethod_1(this, @class.method_0());
                return;
            }
            foreach (GClass541 item in @class.Value)
            {
                GClass542 gClass = item.vmethod_2(gclass478_0);
                if (!gClass.Boolean_0)
                {
                    list.Add(item);
                    continue;
                }
                GClass109.smethod_1(this, gClass.method_0());
                return;
            }
        }
        catch (Exception)
        {
            GClass109.smethod_1(this, "Unable to import the file:" + Environment.NewLine + openFileDialog.FileName);
        }
        method_5([.. list]);
    }

    private void method_30(string string_1, bool bool_0 = false)
    {
        ProcessStartInfo processStartInfo = new()
        {
            CreateNoWindow = false,
            UseShellExecute = true,
            FileName = string_1,
            WindowStyle = ProcessWindowStyle.Hidden,
            WorkingDirectory = Path.GetDirectoryName(string_1)
        };
        if (bool_0 && Environment.OSVersion.Version.Major >= 6)
        {
            processStartInfo.Verb = "runas";
        }
        try
        {
            Process.Start(processStartInfo);
        }
        catch (Exception ex)
        {
            GClass109.smethod_1(this, ex.Message);
        }
    }

    private void FindMeu_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            formFind_0.Show();
        }
    }

    private bool method_31()
    {
        if (gclass478_0 != null && gclass478_0.Boolean_0)
        {
            return true;
        }
        return false;
    }

    private void MenuScriptEditorClear_Click(object sender, EventArgs e)
    {
        if (GClass109.smethod_3(this, "The content of the Script Editor will be removed. Do you want to continue?") == DialogResult.Yes)
        {
            class118_0.method_6();
        }
    }

    private void MenuScriptEditorExecute_Click(object sender, EventArgs e)
    {
        if (method_28() && GClass109.smethod_3(this, "Would you like to run the script?") == DialogResult.Yes)
        {
            ClassesTree.BeginUpdate();
            class118_0.method_7(this, gclass478_0, bool_0: false);
            ClassesTree.EndUpdate();
        }
    }

    private void MenuScriptEditorExecuteLine_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            class118_0.method_7(this, gclass478_0, bool_0: true);
        }
    }

    private void method_32()
    {
        bool enabled = method_31();
        MenuSave.Enabled = enabled;
        MenuReload.Enabled = enabled;
        MenuMarkValue.Enabled = enabled;
        LogsMenu.Enabled = enabled;
        ImportModScriptMenu.Enabled = enabled;
        ExportModScriptMenu.Enabled = enabled;
        ImportModMenu.Enabled = enabled;
        ImportMWPSMenu.Enabled = enabled;
        FindMeu.Enabled = enabled;
        MenuFindNext.Enabled = enabled;
        MenuNFSCarbonConfiguration.Enabled = enabled;
        MenuScriptEditorExecuteLine.Enabled = enabled;
        MenuScriptEditorExecute.Enabled = enabled;
        MenuRunGame.Enabled = enabled;
        MenuRestoreBackups.Enabled = enabled;
        MenuConvertMWPSToModScript.Enabled = enabled;
        int num = FileMenu.DropDownItems.IndexOf(MenuMRUSeparator1);
        foreach (ToolStripMenuItem item in (from toolStripMenuItem_0 in FileMenu.DropDownItems.OfType<ToolStripMenuItem>()
                                            where toolStripMenuItem_0.Tag == "MRU"
                                            select toolStripMenuItem_0).ToList())
        {
            FileMenu.DropDownItems.Remove(item);
        }
        foreach (string string_0 in settings_0.MostRecentlyUsed)
        {
            num++;
            ToolStripMenuItem toolStripMenuItem = new(string_0, null, delegate
            {
                if (gclass478_0 != null)
                {
                    VaultDatabase gClass = gclass478_0;
                    if (gClass == null || gClass.UnsavedChanges)
                    {
                        VaultDatabase gClass2 = gclass478_0;
                        if (gClass2 == null || !gClass2.UnsavedChanges || GClass109.smethod_3(this, "There are unsaved changes. Do you really want to continue?") != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                }
                method_15(string_0);
            })
            {
                Tag = "MRU"
            };
            FileMenu.DropDownItems.Insert(num, toolStripMenuItem);
        }
        MainMenu.smethod_10();
    }

    private void MenuClearRecentlyUsed_Click(object sender, EventArgs e)
    {
        settings_0.method_1();
        method_32();
    }

    private void MenuFindNext_Click(object sender, EventArgs e)
    {
        formFind_0.method_1();
    }

    private void MenuRunGame_Click(object sender, EventArgs e)
    {
        if (method_28())
        {
            method_30(class117_0.String_0);
        }
    }

    private void MenuRestoreBackups_Click(object sender, EventArgs e)
    {
        if (method_28() && new Class119().method_0(this, class117_0.GameFolder))
        {
            settings_0.LastSelection = ClassesTree.SelectedNode?.ToString();
            method_15(settings_0.FilePath);
        }
    }

    private void MenuAssociateModScript_Click(object sender, EventArgs e)
    {
        string string_ = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NFS.VltEd.FileAssociation.exe");
        method_30(string_);
    }

    protected void Dispose(bool disposing)
    {
        if (disposing && icontainer_0 != null)
        {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.icontainer_0 = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new(typeof(MainForm));
        this.MainMenu = new System.Windows.Forms.MenuStrip();
        this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuReload = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
        this.MenuImport = new System.Windows.Forms.ToolStripMenuItem();
        this.ImportModScriptMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.ImportModMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.ImportMWPSMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuNFSCarbonConfiguration = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuExport = new System.Windows.Forms.ToolStripMenuItem();
        this.ExportModScriptMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuMRUSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.MenuClearRecentlyUsed = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuMRUSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
        this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.FindMeu = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuFindNext = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuMarkValue = new System.Windows.Forms.ToolStripMenuItem();
        this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.valuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuViewAlphabetical = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuViewCategorized = new System.Windows.Forms.ToolStripMenuItem();
        this.LogsMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuScriptEditor = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuScriptEditorClear = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuScriptEditorExecuteLine = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuScriptEditorExecute = new System.Windows.Forms.ToolStripMenuItem();
        this.MainMenuGame = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuRunGame = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuRestoreBackups = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuOptions = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuConvertMWPSToModScript = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuAssociateModScript = new System.Windows.Forms.ToolStripMenuItem();
        this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ClassesTree = new System.Windows.Forms.TreeView();
        this.Status = new System.Windows.Forms.StatusStrip();
        this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
        this.StatusCounter = new System.Windows.Forms.ToolStripStatusLabel();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        this.splitContainer3 = new System.Windows.Forms.SplitContainer();
        this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
        this.ScriptTextBox = new VaultEditor.FastColoredTextBox();
        this.MainMenu.SuspendLayout();
        this.Status.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.splitContainer3).BeginInit();
        this.splitContainer3.Panel1.SuspendLayout();
        this.splitContainer3.Panel2.SuspendLayout();
        this.splitContainer3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.ScriptTextBox).BeginInit();
        base.SuspendLayout();
        this.MainMenu.Items.AddRange([this.FileMenu, this.EditMenu, this.viewToolStripMenuItem, this.MenuScriptEditor, this.MainMenuGame, this.MenuOptions, this.helpToolStripMenuItem]);
        this.MainMenu.Location = new System.Drawing.Point(0, 0);
        this.MainMenu.Name = "MainMenu";
        this.MainMenu.Size = new System.Drawing.Size(784, 24);
        this.MainMenu.TabIndex = 0;
        this.MainMenu.Text = "menuStrip1";
        this.FileMenu.DropDownItems.AddRange([this.MenuOpen, this.MenuReload, this.MenuSave, this.toolStripSeparator6, this.MenuImport, this.MenuExport, this.MenuMRUSeparator1, this.MenuClearRecentlyUsed, this.MenuMRUSeparator2, this.MenuExit]);
        this.FileMenu.Name = "FileMenu";
        this.FileMenu.ShortcutKeys = System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control;
        this.FileMenu.Size = new System.Drawing.Size(37, 20);
        this.FileMenu.Text = "&File";
        this.MenuOpen.Image = VaultEditor.Class13.Open;
        this.MenuOpen.Name = "MenuOpen";
        this.MenuOpen.ShortcutKeys = System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Control;
        this.MenuOpen.Size = new System.Drawing.Size(178, 22);
        this.MenuOpen.Text = "Open";
        this.MenuOpen.Click += new System.EventHandler(MenuOpen_Click);
        this.MenuReload.Image = VaultEditor.Class13.Reload;
        this.MenuReload.Name = "MenuReload";
        this.MenuReload.ShortcutKeys = System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt;
        this.MenuReload.Size = new System.Drawing.Size(178, 22);
        this.MenuReload.Text = "Reload";
        this.MenuReload.Click += new System.EventHandler(MenuReload_Click);
        this.MenuSave.Image = (System.Drawing.Image)resources.GetObject("MenuSave.Image");
        this.MenuSave.Name = "MenuSave";
        this.MenuSave.ShortcutKeys = System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.Control;
        this.MenuSave.Size = new System.Drawing.Size(178, 22);
        this.MenuSave.Text = "Save";
        this.MenuSave.Click += new System.EventHandler(MenuSave_Click);
        this.toolStripSeparator6.Name = "toolStripSeparator6";
        this.toolStripSeparator6.Size = new System.Drawing.Size(175, 6);
        this.MenuImport.DropDownItems.AddRange([this.ImportModScriptMenu, this.ImportModMenu, this.ImportMWPSMenu, this.MenuNFSCarbonConfiguration]);
        this.MenuImport.Image = VaultEditor.Class13.Import;
        this.MenuImport.Name = "MenuImport";
        this.MenuImport.Size = new System.Drawing.Size(178, 22);
        this.MenuImport.Text = "Import";
        this.ImportModScriptMenu.Image = VaultEditor.Class13.Import;
        this.ImportModScriptMenu.Name = "ImportModScriptMenu";
        this.ImportModScriptMenu.ShortcutKeys = System.Windows.Forms.Keys.I | System.Windows.Forms.Keys.Control;
        this.ImportModScriptMenu.Size = new System.Drawing.Size(206, 22);
        this.ImportModScriptMenu.Text = "ModScript";
        this.ImportModScriptMenu.Click += new System.EventHandler(ImportModScriptMenu_Click);
        this.ImportModMenu.Image = VaultEditor.Class13.Import;
        this.ImportModMenu.Name = "ImportModMenu";
        this.ImportModMenu.Size = new System.Drawing.Size(206, 22);
        this.ImportModMenu.Text = "NFSCfg";
        this.ImportModMenu.Click += new System.EventHandler(ImportModMenu_Click);
        this.ImportMWPSMenu.Image = VaultEditor.Class13.Import;
        this.ImportMWPSMenu.Name = "ImportMWPSMenu";
        this.ImportMWPSMenu.Size = new System.Drawing.Size(206, 22);
        this.ImportMWPSMenu.Text = "&MWPS";
        this.ImportMWPSMenu.Click += new System.EventHandler(ImportMWPSMenu_Click);
        this.MenuNFSCarbonConfiguration.Image = VaultEditor.Class13.Import;
        this.MenuNFSCarbonConfiguration.Name = "MenuNFSCarbonConfiguration";
        this.MenuNFSCarbonConfiguration.Size = new System.Drawing.Size(206, 22);
        this.MenuNFSCarbonConfiguration.Text = "NFS: Carbon Car Settings";
        this.MenuNFSCarbonConfiguration.Click += new System.EventHandler(MenuNFSCarbonConfiguration_Click);
        this.MenuExport.DropDownItems.AddRange([this.ExportModScriptMenu]);
        this.MenuExport.Image = VaultEditor.Class13.Export;
        this.MenuExport.Name = "MenuExport";
        this.MenuExport.Size = new System.Drawing.Size(178, 22);
        this.MenuExport.Text = "Export";
        this.ExportModScriptMenu.Image = VaultEditor.Class13.Export;
        this.ExportModScriptMenu.Name = "ExportModScriptMenu";
        this.ExportModScriptMenu.ShortcutKeys = System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.Control;
        this.ExportModScriptMenu.Size = new System.Drawing.Size(169, 22);
        this.ExportModScriptMenu.Text = "ModScript";
        this.ExportModScriptMenu.Click += new System.EventHandler(ExportModScriptMenu_Click);
        this.MenuMRUSeparator1.Name = "MenuMRUSeparator1";
        this.MenuMRUSeparator1.Size = new System.Drawing.Size(175, 6);
        this.MenuClearRecentlyUsed.Image = VaultEditor.Class13.Delete;
        this.MenuClearRecentlyUsed.Name = "MenuClearRecentlyUsed";
        this.MenuClearRecentlyUsed.Size = new System.Drawing.Size(178, 22);
        this.MenuClearRecentlyUsed.Text = "Clear Recently Used";
        this.MenuClearRecentlyUsed.Click += new System.EventHandler(MenuClearRecentlyUsed_Click);
        this.MenuMRUSeparator2.Name = "MenuMRUSeparator2";
        this.MenuMRUSeparator2.Size = new System.Drawing.Size(175, 6);
        this.MenuExit.Image = VaultEditor.Class13.Close;
        this.MenuExit.Name = "MenuExit";
        this.MenuExit.Size = new System.Drawing.Size(178, 22);
        this.MenuExit.Text = "Exit";
        this.MenuExit.Click += new System.EventHandler(MenuExit_Click);
        this.EditMenu.DropDownItems.AddRange([this.FindMeu, this.MenuFindNext, this.MenuMarkValue]);
        this.EditMenu.Name = "EditMenu";
        this.EditMenu.Size = new System.Drawing.Size(39, 20);
        this.EditMenu.Text = "&Edit";
        this.FindMeu.Image = VaultEditor.Class13.Search;
        this.FindMeu.Name = "FindMeu";
        this.FindMeu.ShortcutKeyDisplayString = "Ctrl+F";
        this.FindMeu.Size = new System.Drawing.Size(215, 22);
        this.FindMeu.Text = "&Find";
        this.FindMeu.Click += new System.EventHandler(FindMeu_Click);
        this.MenuFindNext.Image = VaultEditor.Class13.Search;
        this.MenuFindNext.Name = "MenuFindNext";
        this.MenuFindNext.ShortcutKeyDisplayString = "F3";
        this.MenuFindNext.Size = new System.Drawing.Size(215, 22);
        this.MenuFindNext.Text = "Find Next";
        this.MenuFindNext.Click += new System.EventHandler(MenuFindNext_Click);
        this.MenuMarkValue.Image = VaultEditor.Class13.Mark;
        this.MenuMarkValue.Name = "MenuMarkValue";
        this.MenuMarkValue.ShortcutKeyDisplayString = "Insert";
        this.MenuMarkValue.Size = new System.Drawing.Size(215, 22);
        this.MenuMarkValue.Text = "Generate command";
        this.MenuMarkValue.Click += new System.EventHandler(MenuMarkValue_Click);
        this.viewToolStripMenuItem.DropDownItems.AddRange([this.valuesToolStripMenuItem, this.LogsMenu]);
        this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        this.viewToolStripMenuItem.Text = "&View";
        this.valuesToolStripMenuItem.DropDownItems.AddRange([this.MenuViewAlphabetical, this.MenuViewCategorized]);
        this.valuesToolStripMenuItem.Image = VaultEditor.Class13.View;
        this.valuesToolStripMenuItem.Name = "valuesToolStripMenuItem";
        this.valuesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
        this.valuesToolStripMenuItem.Text = "Values";
        this.MenuViewAlphabetical.Image = VaultEditor.Class13.SortAlphabetical;
        this.MenuViewAlphabetical.Name = "MenuViewAlphabetical";
        this.MenuViewAlphabetical.Size = new System.Drawing.Size(140, 22);
        this.MenuViewAlphabetical.Text = "&Alphabetical";
        this.MenuViewAlphabetical.Click += new System.EventHandler(MenuViewAlphabetical_Click);
        this.MenuViewCategorized.Image = VaultEditor.Class13.Sort;
        this.MenuViewCategorized.Name = "MenuViewCategorized";
        this.MenuViewCategorized.Size = new System.Drawing.Size(140, 22);
        this.MenuViewCategorized.Text = "&Categorized";
        this.MenuViewCategorized.Click += new System.EventHandler(MenuViewCategorized_Click);
        this.LogsMenu.Image = VaultEditor.Class13.View;
        this.LogsMenu.Name = "LogsMenu";
        this.LogsMenu.Size = new System.Drawing.Size(137, 22);
        this.LogsMenu.Text = "&Logs Viewer";
        this.LogsMenu.Click += new System.EventHandler(LogsMenu_Click);
        this.MenuScriptEditor.DropDownItems.AddRange([this.MenuScriptEditorClear, this.MenuScriptEditorExecuteLine, this.MenuScriptEditorExecute]);
        this.MenuScriptEditor.Name = "MenuScriptEditor";
        this.MenuScriptEditor.Size = new System.Drawing.Size(83, 20);
        this.MenuScriptEditor.Text = "&Script Editor";
        this.MenuScriptEditorClear.Image = VaultEditor.Class13.Delete;
        this.MenuScriptEditorClear.Name = "MenuScriptEditorClear";
        this.MenuScriptEditorClear.Size = new System.Drawing.Size(263, 22);
        this.MenuScriptEditorClear.Text = "Clear";
        this.MenuScriptEditorClear.Click += new System.EventHandler(MenuScriptEditorClear_Click);
        this.MenuScriptEditorExecuteLine.Image = VaultEditor.Class13.Run;
        this.MenuScriptEditorExecuteLine.Name = "MenuScriptEditorExecuteLine";
        this.MenuScriptEditorExecuteLine.ShortcutKeys = System.Windows.Forms.Keys.F5;
        this.MenuScriptEditorExecuteLine.Size = new System.Drawing.Size(263, 22);
        this.MenuScriptEditorExecuteLine.Text = "&Execute current / selected line(s)";
        this.MenuScriptEditorExecuteLine.Click += new System.EventHandler(MenuScriptEditorExecuteLine_Click);
        this.MenuScriptEditorExecute.Image = VaultEditor.Class13.Run;
        this.MenuScriptEditorExecute.Name = "MenuScriptEditorExecute";
        this.MenuScriptEditorExecute.ShortcutKeys = System.Windows.Forms.Keys.F9;
        this.MenuScriptEditorExecute.Size = new System.Drawing.Size(263, 22);
        this.MenuScriptEditorExecute.Text = "&Execute";
        this.MenuScriptEditorExecute.Click += new System.EventHandler(MenuScriptEditorExecute_Click);
        this.MainMenuGame.DropDownItems.AddRange([this.MenuRunGame, this.MenuRestoreBackups]);
        this.MainMenuGame.Name = "MainMenuGame";
        this.MainMenuGame.Size = new System.Drawing.Size(50, 20);
        this.MainMenuGame.Text = "&Game";
        this.MenuRunGame.Image = VaultEditor.Class13.Run;
        this.MenuRunGame.Name = "MenuRunGame";
        this.MenuRunGame.ShortcutKeys = System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt;
        this.MenuRunGame.Size = new System.Drawing.Size(160, 22);
        this.MenuRunGame.Text = "Run";
        this.MenuRunGame.Click += new System.EventHandler(MenuRunGame_Click);
        this.MenuRestoreBackups.Image = VaultEditor.Class13.Reload;
        this.MenuRestoreBackups.Name = "MenuRestoreBackups";
        this.MenuRestoreBackups.Size = new System.Drawing.Size(160, 22);
        this.MenuRestoreBackups.Text = "&Restore backups";
        this.MenuRestoreBackups.Click += new System.EventHandler(MenuRestoreBackups_Click);
        this.MenuOptions.DropDownItems.AddRange([this.MenuSettings, this.MenuConvertMWPSToModScript, this.MenuAssociateModScript]);
        this.MenuOptions.Name = "MenuOptions";
        this.MenuOptions.Size = new System.Drawing.Size(47, 20);
        this.MenuOptions.Text = "&Tools";
        this.MenuSettings.Image = VaultEditor.Class13.Settings;
        this.MenuSettings.Name = "MenuSettings";
        this.MenuSettings.Size = new System.Drawing.Size(226, 22);
        this.MenuSettings.Text = "Settings";
        this.MenuSettings.Click += new System.EventHandler(MenuSettings_Click);
        this.MenuConvertMWPSToModScript.Image = VaultEditor.Class13.Document;
        this.MenuConvertMWPSToModScript.Name = "MenuConvertMWPSToModScript";
        this.MenuConvertMWPSToModScript.Size = new System.Drawing.Size(226, 22);
        this.MenuConvertMWPSToModScript.Text = "&Convert MWPS to ModScript";
        this.MenuConvertMWPSToModScript.Click += new System.EventHandler(MenuConvertMWPSToModScript_Click);
        this.MenuAssociateModScript.Name = "MenuAssociateModScript";
        this.MenuAssociateModScript.Size = new System.Drawing.Size(226, 22);
        this.MenuAssociateModScript.Text = "Associate ModScript";
        this.MenuAssociateModScript.Visible = false;
        this.MenuAssociateModScript.Click += new System.EventHandler(MenuAssociateModScript_Click);
        this.helpToolStripMenuItem.DropDownItems.AddRange([this.aboutToolStripMenuItem]);
        this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        this.helpToolStripMenuItem.Text = "Help";
        this.aboutToolStripMenuItem.Image = VaultEditor.Class13.Help;
        this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
        this.aboutToolStripMenuItem.Text = "About";
        this.aboutToolStripMenuItem.Click += new System.EventHandler(aboutToolStripMenuItem_Click);
        this.ClassesTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.ClassesTree.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ClassesTree.Location = new System.Drawing.Point(0, 0);
        this.ClassesTree.Name = "ClassesTree";
        this.ClassesTree.Size = new System.Drawing.Size(249, 503);
        this.ClassesTree.TabIndex = 2;
        this.Status.Items.AddRange([this.LabelStatus, this.StatusCounter]);
        this.Status.Location = new System.Drawing.Point(0, 539);
        this.Status.Name = "Status";
        this.Status.Size = new System.Drawing.Size(784, 22);
        this.Status.SizingGrip = false;
        this.Status.TabIndex = 10;
        this.LabelStatus.Name = "LabelStatus";
        this.LabelStatus.Size = new System.Drawing.Size(769, 17);
        this.LabelStatus.Spring = true;
        this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.StatusCounter.Name = "StatusCounter";
        this.StatusCounter.Size = new System.Drawing.Size(0, 17);
        this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.splitContainer1.Location = new System.Drawing.Point(5, 28);
        this.splitContainer1.Name = "splitContainer1";
        this.splitContainer1.Panel1.Controls.Add(this.ClassesTree);
        this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
        this.splitContainer1.Size = new System.Drawing.Size(774, 503);
        this.splitContainer1.SplitterDistance = 249;
        this.splitContainer1.TabIndex = 12;
        this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer3.Location = new System.Drawing.Point(0, 0);
        this.splitContainer3.Name = "splitContainer3";
        this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
        this.splitContainer3.Panel1.Controls.Add(this.PropertyGrid);
        this.splitContainer3.Panel2.Controls.Add(this.ScriptTextBox);
        this.splitContainer3.Size = new System.Drawing.Size(521, 503);
        this.splitContainer3.SplitterDistance = 365;
        this.splitContainer3.TabIndex = 3;
        this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.PropertyGrid.HelpVisible = false;
        this.PropertyGrid.LineColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
        this.PropertyGrid.Margin = new System.Windows.Forms.Padding(0);
        this.PropertyGrid.Name = "PropertyGrid";
        this.PropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
        this.PropertyGrid.Size = new System.Drawing.Size(521, 365);
        this.PropertyGrid.TabIndex = 0;
        this.PropertyGrid.ToolbarVisible = false;
        this.ScriptTextBox.Char_0 = ['(', ')', '{', '}', '[', ']', '"', '"', '\'', '\''];
        this.ScriptTextBox.Size_0 = new System.Drawing.Size(27, 14);
        this.ScriptTextBox.Brush_0 = null;
        this.ScriptTextBox.Int32_1 = 14;
        this.ScriptTextBox.CharWidth = 8;
        this.ScriptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.ScriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
        this.ScriptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ScriptTextBox.Font = new System.Drawing.Font("Courier New", 9.75f);
        this.ScriptTextBox.Boolean_6 = false;
        this.ScriptTextBox.Location = new System.Drawing.Point(0, 0);
        this.ScriptTextBox.Name = "ScriptTextBox";
        this.ScriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
        this.ScriptTextBox.Color_8 = System.Drawing.Color.FromArgb(60, 0, 0, 255);
        this.ScriptTextBox.ServiceColors = null;
        this.ScriptTextBox.Size = new System.Drawing.Size(521, 134);
        this.ScriptTextBox.TabIndex = 1;
        this.ScriptTextBox.Int32_13 = 100;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(784, 561);
        base.Controls.Add(this.splitContainer1);
        base.Controls.Add(this.Status);
        base.Controls.Add(this.MainMenu);
        base.MainMenuStrip = this.MainMenu;
        this.MinimumSize = new System.Drawing.Size(600, 400);
        base.Name = "MainForm";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "NFS-VltEd by nfsu360";
        this.MainMenu.ResumeLayout(false);
        this.MainMenu.PerformLayout();
        this.Status.ResumeLayout(false);
        this.Status.PerformLayout();
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
        this.splitContainer1.ResumeLayout(false);
        this.splitContainer3.Panel1.ResumeLayout(false);
        this.splitContainer3.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.splitContainer3).EndInit();
        this.splitContainer3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.ScriptTextBox).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    [CompilerGenerated]
    private bool method_33(GClass535 gclass535_0)
    {
        return gclass535_0.ToString() == settings_0.LastSelection;
    }
}
