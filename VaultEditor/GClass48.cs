using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace VaultEditor;

public sealed class GClass48
{
    private sealed class Class79(string string_3)
    {
        [CompilerGenerated]
        private readonly string string_0 = string_3;

        [CompilerGenerated]
        private readonly string string_1 = string_3.ToUpper();

        [CompilerGenerated]
        private readonly string string_2 = string_3.ToLower();

        public string TextNormal
        {
            [CompilerGenerated]
            get
            {
                return string_0;
            }
        }

        public string TextUpper
        {
            [CompilerGenerated]
            get
            {
                return string_1;
            }
        }

        public string TextLower
        {
            [CompilerGenerated]
            get
            {
                return string_2;
            }
        }
    }

    public Func<string, uint> func_0;

    public Func<uint, string> func_1;

    public Func<uint, bool> func_2;

    public Action<HashSet<Tuple<string, string>>> action_0;

    public Action action_1;

    public void method_0(IProgress<int> iprogress_0, IList<string> ilist_0, CancellationToken cancellationToken_0, string string_0)
    {
        if (iprogress_0 == null)
        {
            return;
        }
        List<Class79> list_ = [.. ilist_0.Select(string_1 => new Class79(string_1))];
        int num = 0;
        if (string_0.Contains("%p1%") || string_0.Contains("%P1%") || string_0.Contains("%[P1]%"))
        {
            num = 1;
        }
        if (!string_0.Contains("%p2%") && !string_0.Contains("%P2%") && !string_0.Contains("%[P2]%"))
        {
            switch (num)
            {
                case 1:
                    method_1(iprogress_0, cancellationToken_0, string_0, list_);
                    goto IL_00c4;
                case 3:
                    method_2(iprogress_0, cancellationToken_0, string_0, list_);
                    goto IL_00c4;
                case 2:
                    break;
                default:
                    goto IL_00c4;
            }
        }
        method_2(iprogress_0, cancellationToken_0, string_0, list_);
        goto IL_00c4;
    IL_00c4:
        action_1();
    }

    private void method_1(IProgress<int> iprogress_0, CancellationToken cancellationToken_0, string string_0, List<Class79> list_0)
    {
        HashSet<Tuple<string, string>> hashSet = [];
        Stopwatch stopwatch = Stopwatch.StartNew();
        Stopwatch stopwatch2 = Stopwatch.StartNew();
        int num = 0;
        foreach (Class79 item in list_0)
        {
            if (!cancellationToken_0.IsCancellationRequested)
            {
                string text = string_0;
                text = text.Replace("%p1%", item.TextLower);
                text = text.Replace("%P1%", item.TextUpper);
                text = text.Replace("%[P1]%", item.TextNormal);
                method_3(hashSet, text);
                num++;
                if (stopwatch2.Elapsed.TotalMilliseconds > 500.0 || num <= 1)
                {
                    stopwatch2.Restart();
                    iprogress_0.Report(num);
                }
                if (stopwatch.Elapsed.TotalSeconds > 10.0)
                {
                    stopwatch.Restart();
                    action_0(hashSet);
                }
                continue;
            }
            break;
        }
        iprogress_0.Report(num);
        action_0(hashSet);
    }

    private void method_2(IProgress<int> iprogress_0, CancellationToken cancellationToken_0, string string_0, List<Class79> list_0)
    {
        HashSet<Tuple<string, string>> hashSet = [];
        Stopwatch stopwatch = Stopwatch.StartNew();
        Stopwatch stopwatch2 = Stopwatch.StartNew();
        int num = 0;
        foreach (Class79 item in list_0)
        {
            foreach (Class79 item2 in list_0)
            {
                if (!cancellationToken_0.IsCancellationRequested)
                {
                    string text = string_0;
                    text = text.Replace("%p1%", item.TextLower);
                    text = text.Replace("%P1%", item.TextUpper);
                    text = text.Replace("%[P1]%", item.TextNormal);
                    text = text.Replace("%p2%", item2.TextLower);
                    text = text.Replace("%P2%", item2.TextUpper);
                    text = text.Replace("%[P2]%", item2.TextNormal);
                    method_3(hashSet, text);
                    num++;
                    if (stopwatch2.Elapsed.TotalMilliseconds > 500.0 || num <= 1)
                    {
                        stopwatch2.Restart();
                        iprogress_0.Report(num);
                    }
                    if (stopwatch.Elapsed.TotalSeconds > 10.0)
                    {
                        stopwatch.Restart();
                        action_0(hashSet);
                    }
                    continue;
                }
                break;
            }
        }
        iprogress_0.Report(num);
        action_0(hashSet);
    }

    private void method_3(HashSet<Tuple<string, string>> hashSet_0, string string_0)
    {
        bool flag = false;
        string item = null;
        uint arg = func_0(string_0);
        string text = func_1(arg);
        if (!string.IsNullOrWhiteSpace(text))
        {
            if (text != string_0)
            {
                item = text;
                flag = true;
            }
        }
        else if (func_2(arg))
        {
            flag = true;
        }
        if (flag)
        {
            Tuple<string, string> item2 = new(item, string_0);
            if (!hashSet_0.Contains(item2))
            {
                hashSet_0.Add(item2);
            }
        }
    }
}
