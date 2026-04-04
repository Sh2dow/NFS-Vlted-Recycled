using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VaultEditor;

public static class GClass143
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 8)]
    private struct Struct25
    {
        public int int_0;

        public IntPtr intptr_0;

        public int int_1;

        public int int_2;

        [MarshalAs(UnmanagedType.LPTStr)]
        public readonly string string_0;

        public readonly int int_3;

        public readonly int int_4;

        public readonly int int_5;

        public readonly int int_6;

        public readonly IntPtr intptr_1;
    }

    private static readonly int int_0;

    private static readonly int int_1;

    private static readonly int int_2;

    private static readonly int int_3;

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessage(IntPtr intptr_0, int int_4, IntPtr intptr_1, ref Struct25 struct25_0);

    public static void smethod_0(this TreeNode treeNode_0)
    {
        Struct25 struct25_ = new()
        {
            intptr_0 = treeNode_0.Handle,
            int_0 = 8,
            int_2 = 61440,
            int_1 = 0
        };
        SendMessage(treeNode_0.TreeView.Handle, 4415, IntPtr.Zero, ref struct25_);
    }

    public static TreeNode smethod_1(this TreeNodeCollection treeNodeCollection_0, uint uint_0, object object_0)
    {
        TreeNode treeNode = new(GClass486.smethod_5(uint_0));
        treeNodeCollection_0.Add(treeNode);
        treeNode.Tag = object_0;
        return treeNode;
    }
}
