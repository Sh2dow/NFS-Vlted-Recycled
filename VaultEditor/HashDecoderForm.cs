using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaultEditor;

public sealed class HashDecoderForm : Form
{
    [Serializable]
    [CompilerGenerated]
    private sealed class _003C_003Ec
    {
        public static readonly _003C_003Ec _003C_003Ec_0 = new();

        public static Func<uint, uint> func_0;

        public static Action<Button> action_0;

        public static Action<Button> action_1;

        internal uint method_0(uint uint_0)
        {
            return uint_0;
        }

        internal void method_1(Button button_0)
        {
            button_0.Visible = true;
        }

        internal void method_2(Button button_0)
        {
            button_0.Visible = false;
        }
    }

    [CompilerGenerated]
    private sealed class Class80
    {
        public Stopwatch stopwatch_0;

        public HashDecoderForm hashDecoderForm_0;

        internal void method_0(int int_0)
        {
            double num = Math.Round((double)int_0 * 1.0 / (double)Count, 3);
            double num2 = (double)int_0 / stopwatch_0.Elapsed.TotalSeconds;
            string text = "Working... " + num.ToString("P") + " (" + num2.ToString("N0") + "/s) " + stopwatch_0.Elapsed.TotalSeconds.ToString("N0") + " s ";
            hashDecoderForm_0.ProgressLabel.Text = text;
        }
    }

    [CompilerGenerated]
    private sealed class Class81
    {
        public HashDecoderForm hashDecoderForm_0;

        public IProgress<int> iprogress_0;

        public List<string> list_0;

        public Action action_0;

        internal void method_0(object sender, EventArgs e)
        {
            hashDecoderForm_0.cancellationTokenSource_0.Cancel();
            hashDecoderForm_0.RunAsyncCheckingButton.Visible = true;
            hashDecoderForm_0.CancelTaskButton.Visible = false;
        }

        internal bool method_1()
        {
            string text = hashDecoderForm_0.AutoSearchPatternControl.Text;
            GClass48 obj = new()
            {
                func_2 = hashDecoderForm_0.method_9,
                action_0 = hashDecoderForm_0.method_10,
                func_0 = hashDecoderForm_0.method_8,
                func_1 = hashDecoderForm_0.method_7
            };
            obj.action_1 = (Action)Delegate.Combine(obj.action_1, (Action)delegate
            {
                hashDecoderForm_0.RunAsyncCheckingButton.smethod_0(_003C_003Ec._003C_003Ec_0.method_1);
                hashDecoderForm_0.CancelTaskButton.smethod_0(_003C_003Ec._003C_003Ec_0.method_2);
            });
            obj.method_0(iprogress_0, list_0, hashDecoderForm_0.cancellationTokenSource_0.Token, text);
            return true;
        }

        internal void method_2()
        {
            hashDecoderForm_0.RunAsyncCheckingButton.smethod_0(_003C_003Ec._003C_003Ec_0.method_1);
            hashDecoderForm_0.CancelTaskButton.smethod_0(_003C_003Ec._003C_003Ec_0.method_2);
        }
    }

    [CompilerGenerated]
    private sealed class Class82
    {
        public HashDecoderForm hashDecoderForm_0;

        public HashSet<Tuple<string, string>> hashSet_0;

        internal void method_0(ListView listView_0)
        {
            listView_0.BeginUpdate();
            string text = hashDecoderForm_0.HashDecoderTextBox.Text;
            foreach (Tuple<string, string> item in hashSet_0)
            {
                ListViewItem listViewItem = listView_0.Items.Add(text);
                listViewItem.SubItems.Add(item.Item1);
                listViewItem.SubItems.Add(item.Item2);
                uint num = GClass486.smethod_8(item.Item2);
                listViewItem.SubItems.Add("0x" + num.ToString("X2"));
            }
            listView_0.EndUpdate();
        }
    }

    private static readonly IDictionary<uint, string> idictionary_0 = new Dictionary<uint, string>();

    private readonly HashSet<Tuple<string, string>> hashSet_0 = [];

    private CancellationTokenSource cancellationTokenSource_0 = new();

    private readonly HashSet<string> hashSet_1 = [];

    private readonly HashSet<string> hashSet_2 = [];

    private readonly HashSet<string> hashSet_3 = [];

    private readonly TextInfo textInfo_0 = new CultureInfo("en-US", useUserOverride: false).TextInfo;

    [CompilerGenerated]
    private EventHandler eventHandler_0;

    [CompilerGenerated]
    private EventHandler<string> eventHandler_1;

    [CompilerGenerated]
    private EventHandler<uint> eventHandler_2;

    [CompilerGenerated]
    private static long long_0;

    private readonly IContainer icontainer_0;

    private Label StatsControl;

    private TextBox HashDecoderTextBox;

    private ListView ResultsListView;

    private ColumnHeader columnHeader_0;

    private ColumnHeader columnHeader_1;

    private ColumnHeader columnHeader_2;

    private Button ApplyButton;

    private Button SaveButton;

    private ColumnHeader columnHeader_3;

    private ListBox UnresolvedListControl;

    private Button RunAsyncCheckingButton;

    private Label ProgressLabel;

    private TextBox AutoSearchPatternControl;

    private Button CancelTaskButton;

    private Label label1;

    private CheckBox NewOnlyCheckbox;

    public static long Count
    {
        [CompilerGenerated]
        get
        {
            return long_0;
        }
        [CompilerGenerated]
        set
        {
            long_0 = value;
        }
    }

    public event EventHandler Event_0
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_0;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_0;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<string> Event_1
    {
        [CompilerGenerated]
        add
        {
            EventHandler<string> eventHandler = eventHandler_1;
            EventHandler<string> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<string> value2 = (EventHandler<string>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<string> eventHandler = eventHandler_1;
            EventHandler<string> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<string> value2 = (EventHandler<string>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public event EventHandler<uint> Event_2
    {
        [CompilerGenerated]
        add
        {
            EventHandler<uint> eventHandler = eventHandler_2;
            EventHandler<uint> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<uint> value2 = (EventHandler<uint>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<uint> eventHandler = eventHandler_2;
            EventHandler<uint> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<uint> value2 = (EventHandler<uint>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public HashDecoderForm()
    {
        InitializeComponent();
        CancelTaskButton.Visible = false;
        base.Closing += HashDecoderForm_Closing;
        method_0();
        HashDecoderTextBox.KeyPress += HashDecoderTextBox_KeyPress;
        HashDecoderTextBox.TextChanged += HashDecoderTextBox_TextChanged;
        ResultsListView.ItemActivate += ResultsListView_ItemActivate;
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        if (File.Exists(Path.Combine(baseDirectory, "Potentials.txt")))
        {
            hashSet_3.UnionWith(File.ReadAllLines(Path.Combine(baseDirectory, "Potentials.txt")));
        }
        string path = Path.Combine(baseDirectory, "List1.txt");
        if (File.Exists(path))
        {
            hashSet_1.UnionWith(File.ReadAllLines(path));
        }
        string path2 = Path.Combine(baseDirectory, "List2.txt");
        if (File.Exists(path2))
        {
            hashSet_2.UnionWith(File.ReadAllLines(path2));
        }
        method_4();
    }

    private void method_0()
    {
        UnresolvedListControl.Items.Clear();
        GClass486.Unresolved.OrderBy(uint_0 => uint_0).ToList().ForEach(delegate (uint uint_0)
        {
            UnresolvedListControl.Items.Add(new GClass50(uint_0));
        });
    }

    private void HashDecoderTextBox_TextChanged(object sender, EventArgs e)
    {
        string text = HashDecoderTextBox.Text;
        method_3(text, text);
        method_4();
    }

    private void ResultsListView_ItemActivate(object sender, EventArgs e)
    {
        try
        {
            ListViewItem listViewItem = ResultsListView.SelectedItems[0];
            string text = listViewItem.SubItems[1].Text;
            GClass486.smethod_8(text);
            if (!string.IsNullOrWhiteSpace(text))
            {
                eventHandler_1(null, text);
                return;
            }
            string e2 = GClass486.smethod_5(GClass486.smethod_8(listViewItem.SubItems[2].Text));
            eventHandler_1(null, e2);
        }
        catch (Exception)
        {
        }
    }

    private void HashDecoderForm_Closing(object sender, CancelEventArgs e)
    {
        smethod_0();
        cancellationTokenSource_0.Cancel();
    }

    private void HashDecoderTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != '\r')
        {
            e.Handled = false;
            return;
        }
        Stopwatch.StartNew();
        e.Handled = true;
        string text = HashDecoderTextBox.Text;
        method_3(text, text);
        method_3(text, text.ToLower());
        method_3(text, text.ToUpper());
        foreach (string item in hashSet_3)
        {
            method_1(item, text);
            method_1(text, item);
        }
        foreach (string item2 in hashSet_1)
        {
            foreach (string item3 in hashSet_2)
            {
                string string_ = text + "_" + item2 + "_" + item3;
                method_3(text, string_);
                string string_2 = text + "_" + item3 + "_" + item2;
                method_3(text, string_2);
            }
        }
        method_4();
    }

    private void method_1(string string_0, string string_1)
    {
        string text = string_0 + "_" + string_1;
        method_2(string_1, text.ToLower());
        method_2(string_1, text.ToUpper());
        string text2 = textInfo_0.ToTitleCase(string_1 + " " + string_0).Replace(" ", string.Empty);
        method_2(string_1, text2);
        method_2(string_1, text2.ToLower());
        method_2(string_1, text2);
        method_2(string_1, text2.ToLower());
    }

    public void method_2(string string_0, string string_1)
    {
        method_3(string_0, string_1);
        method_3(string_0, string_1 + "1");
        method_3(string_0, string_1 + "01");
        method_3(string_0, string_1 + "_1");
        method_3(string_0, string_1 + "_01");
    }

    public void method_3(string string_0, string string_1)
    {
        bool flag = false;
        string item = null;
        uint num = GClass486.smethod_8(string_1);
        if (idictionary_0.TryGetValue(num, out var value))
        {
            if (NewOnlyCheckbox.Checked)
            {
                return;
            }
            if (value != string_1)
            {
                item = value;
                flag = true;
            }
        }
        else if (method_9(num))
        {
            flag = true;
        }
        if (flag)
        {
            Tuple<string, string> item2 = new(item, string_1);
            if (!hashSet_0.Contains(item2))
            {
                ListViewItem listViewItem = ResultsListView.Items.Add(string_0);
                listViewItem.SubItems.Add(item);
                listViewItem.SubItems.Add(string_1);
                listViewItem.SubItems.Add($"0x{num:x8}");
                hashSet_0.Add(item2);
                ResultsListView.Items.OfType<ListViewItem>().Last().EnsureVisible();
            }
        }
    }

    private void method_4()
    {
        StatsControl.Text = $"Unresolved hashes ({GClass486.Unresolved.Count})";
    }

    public static void smethod_0()
    {
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        smethod_0();
        GClass109.smethod_2(null, "Changes have been saved.");
    }

    private void ApplyButton_Click(object sender, EventArgs e)
    {
    }

    private void UnresolvedListControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        GClass50 gClass = UnresolvedListControl.SelectedItem as GClass50;
        eventHandler_2(null, gClass.Hash);
    }

    private async void RunAsyncCheckingButton_Click(object sender, EventArgs e)
    {
        await method_5();
    }

    public async Task method_5()
    {
        Stopwatch stopwatch_0 = Stopwatch.StartNew();
        Progress<int> iprogress_ = new(delegate (int int_0)
        {
            double num = Math.Round((double)int_0 * 1.0 / (double)Count, 3);
            double num2 = (double)int_0 / stopwatch_0.Elapsed.TotalSeconds;
            string text = "Working... " + num.ToString("P") + " (" + num2.ToString("N0") + "/s) " + stopwatch_0.Elapsed.TotalSeconds.ToString("N0") + " s ";
            ProgressLabel.Text = text;
        });
        await method_6(iprogress_);
    }

    private Task<bool> method_6(IProgress<int> iprogress_0)
    {
        List<string> list_0 = [.. hashSet_3];
        Count = list_0.Count * list_0.Count;
        RunAsyncCheckingButton.Visible = false;
        CancelTaskButton.Visible = true;
        cancellationTokenSource_0 = new CancellationTokenSource();
        CancelTaskButton.Click += delegate
        {
            cancellationTokenSource_0.Cancel();
            RunAsyncCheckingButton.Visible = true;
            CancelTaskButton.Visible = false;
        };
        return Task.Run(delegate
        {
            string string_ = AutoSearchPatternControl.Text;
            GClass48 obj = new()
            {
                func_2 = method_9,
                action_0 = method_10,
                func_0 = method_8,
                func_1 = method_7
            };
            obj.action_1 = (Action)Delegate.Combine(obj.action_1, (Action)delegate
            {
                RunAsyncCheckingButton.smethod_0(_003C_003Ec._003C_003Ec_0.method_1);
                CancelTaskButton.smethod_0(_003C_003Ec._003C_003Ec_0.method_2);
            });
            obj.method_0(iprogress_0, list_0, cancellationTokenSource_0.Token, string_);
            return true;
        }, cancellationTokenSource_0.Token);
    }

    private string method_7(uint uint_0)
    {
        return null;
    }

    private uint method_8(string string_0)
    {
        return GClass486.smethod_8(string_0);
    }

    private bool method_9(uint uint_0)
    {
        return GClass486.Unresolved.Contains(uint_0);
    }

    private void method_10(HashSet<Tuple<string, string>> hashSet_4)
    {
        ResultsListView.smethod_0(delegate (ListView listView_0)
        {
            listView_0.BeginUpdate();
            string text = HashDecoderTextBox.Text;
            foreach (Tuple<string, string> item in hashSet_4)
            {
                ListViewItem listViewItem = listView_0.Items.Add(text);
                listViewItem.SubItems.Add(item.Item1);
                listViewItem.SubItems.Add(item.Item2);
                uint num = GClass486.smethod_8(item.Item2);
                listViewItem.SubItems.Add("0x" + num.ToString("X2"));
            }
            listView_0.EndUpdate();
        });
        hashSet_4.Clear();
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
        this.StatsControl = new System.Windows.Forms.Label();
        this.HashDecoderTextBox = new System.Windows.Forms.TextBox();
        this.ResultsListView = new System.Windows.Forms.ListView();
        this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
        this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
        this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
        this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
        this.ApplyButton = new System.Windows.Forms.Button();
        this.SaveButton = new System.Windows.Forms.Button();
        this.UnresolvedListControl = new System.Windows.Forms.ListBox();
        this.RunAsyncCheckingButton = new System.Windows.Forms.Button();
        this.ProgressLabel = new System.Windows.Forms.Label();
        this.AutoSearchPatternControl = new System.Windows.Forms.TextBox();
        this.CancelTaskButton = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.NewOnlyCheckbox = new System.Windows.Forms.CheckBox();
        base.SuspendLayout();
        this.StatsControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        this.StatsControl.Location = new System.Drawing.Point(664, 15);
        this.StatsControl.Name = "StatsControl";
        this.StatsControl.Size = new System.Drawing.Size(209, 17);
        this.StatsControl.TabIndex = 15;
        this.StatsControl.Text = "Stats...";
        this.StatsControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.HashDecoderTextBox.AcceptsReturn = true;
        this.HashDecoderTextBox.Location = new System.Drawing.Point(12, 12);
        this.HashDecoderTextBox.Name = "HashDecoderTextBox";
        this.HashDecoderTextBox.Size = new System.Drawing.Size(234, 20);
        this.HashDecoderTextBox.TabIndex = 14;
        this.ResultsListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.ResultsListView.CheckBoxes = true;
        this.ResultsListView.Columns.AddRange([this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_3]);
        this.ResultsListView.FullRowSelect = true;
        this.ResultsListView.GridLines = true;
        this.ResultsListView.HideSelection = false;
        this.ResultsListView.Location = new System.Drawing.Point(12, 38);
        this.ResultsListView.MultiSelect = false;
        this.ResultsListView.Name = "ResultsListView";
        this.ResultsListView.Size = new System.Drawing.Size(646, 550);
        this.ResultsListView.TabIndex = 16;
        this.ResultsListView.UseCompatibleStateImageBehavior = false;
        this.ResultsListView.View = System.Windows.Forms.View.Details;
        this.columnHeader_0.Text = "Search word";
        this.columnHeader_0.Width = 175;
        this.columnHeader_1.Text = "Old string";
        this.columnHeader_1.Width = 153;
        this.columnHeader_2.Text = "New string";
        this.columnHeader_2.Width = 148;
        this.columnHeader_3.Text = "Hash";
        this.columnHeader_3.Width = 91;
        this.ApplyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.ApplyButton.Location = new System.Drawing.Point(12, 594);
        this.ApplyButton.Name = "ApplyButton";
        this.ApplyButton.Size = new System.Drawing.Size(147, 31);
        this.ApplyButton.TabIndex = 17;
        this.ApplyButton.Text = "Apply checked items";
        this.ApplyButton.UseVisualStyleBackColor = true;
        this.ApplyButton.Click += new System.EventHandler(ApplyButton_Click);
        this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.SaveButton.Location = new System.Drawing.Point(165, 594);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new System.Drawing.Size(147, 31);
        this.SaveButton.TabIndex = 18;
        this.SaveButton.Text = "Save hashes";
        this.SaveButton.UseVisualStyleBackColor = true;
        this.SaveButton.Click += new System.EventHandler(SaveButton_Click);
        this.UnresolvedListControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.UnresolvedListControl.FormattingEnabled = true;
        this.UnresolvedListControl.Location = new System.Drawing.Point(664, 38);
        this.UnresolvedListControl.Name = "UnresolvedListControl";
        this.UnresolvedListControl.Size = new System.Drawing.Size(209, 550);
        this.UnresolvedListControl.TabIndex = 19;
        this.UnresolvedListControl.SelectedIndexChanged += new System.EventHandler(UnresolvedListControl_SelectedIndexChanged);
        this.RunAsyncCheckingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.RunAsyncCheckingButton.Location = new System.Drawing.Point(12, 672);
        this.RunAsyncCheckingButton.Name = "RunAsyncCheckingButton";
        this.RunAsyncCheckingButton.Size = new System.Drawing.Size(83, 49);
        this.RunAsyncCheckingButton.TabIndex = 20;
        this.RunAsyncCheckingButton.Text = "Run task";
        this.RunAsyncCheckingButton.UseVisualStyleBackColor = true;
        this.RunAsyncCheckingButton.Click += new System.EventHandler(RunAsyncCheckingButton_Click);
        this.ProgressLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.ProgressLabel.BackColor = System.Drawing.SystemColors.Control;
        this.ProgressLabel.Location = new System.Drawing.Point(104, 698);
        this.ProgressLabel.Name = "ProgressLabel";
        this.ProgressLabel.Size = new System.Drawing.Size(769, 23);
        this.ProgressLabel.TabIndex = 22;
        this.ProgressLabel.Text = "...";
        this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.AutoSearchPatternControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.AutoSearchPatternControl.Location = new System.Drawing.Point(104, 672);
        this.AutoSearchPatternControl.Name = "AutoSearchPatternControl";
        this.AutoSearchPatternControl.Size = new System.Drawing.Size(294, 20);
        this.AutoSearchPatternControl.TabIndex = 24;
        this.CancelTaskButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.CancelTaskButton.Location = new System.Drawing.Point(12, 672);
        this.CancelTaskButton.Name = "CancelTaskButton";
        this.CancelTaskButton.Size = new System.Drawing.Size(83, 49);
        this.CancelTaskButton.TabIndex = 25;
        this.CancelTaskButton.Text = "Cancel task";
        this.CancelTaskButton.UseVisualStyleBackColor = true;
        this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.label1.Location = new System.Drawing.Point(419, 594);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(454, 79);
        this.label1.TabIndex = 26;
        this.label1.Text = "%p1% - lowercase %P1% - uppercase %[P1]% - normal text %p2% - lowercase %P2% - uppercase %[P2]% - normal text";
        this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        this.NewOnlyCheckbox.AutoSize = true;
        this.NewOnlyCheckbox.Location = new System.Drawing.Point(254, 14);
        this.NewOnlyCheckbox.Name = "NewOnlyCheckbox";
        this.NewOnlyCheckbox.Size = new System.Drawing.Size(70, 17);
        this.NewOnlyCheckbox.TabIndex = 27;
        this.NewOnlyCheckbox.Text = "New only";
        this.NewOnlyCheckbox.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(885, 733);
        base.Controls.Add(this.NewOnlyCheckbox);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.CancelTaskButton);
        base.Controls.Add(this.AutoSearchPatternControl);
        base.Controls.Add(this.ProgressLabel);
        base.Controls.Add(this.RunAsyncCheckingButton);
        base.Controls.Add(this.UnresolvedListControl);
        base.Controls.Add(this.SaveButton);
        base.Controls.Add(this.ApplyButton);
        base.Controls.Add(this.ResultsListView);
        base.Controls.Add(this.StatsControl);
        base.Controls.Add(this.HashDecoderTextBox);
        this.MinimumSize = new System.Drawing.Size(400, 500);
        base.Name = "HashDecoderForm";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Hash Decoder 2.7 by nfsu360";
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    [CompilerGenerated]
    private void method_11(uint uint_0)
    {
        UnresolvedListControl.Items.Add(new GClass50(uint_0));
    }
}
