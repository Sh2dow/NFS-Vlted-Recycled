using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.Win32;
using TextEditor;

namespace VaultEditor;

public sealed class FastColoredTextBox : UserControl, ISupportInitialize
{
    private sealed class Class85(int int_1) : IComparer<GStruct9>
    {
        private readonly int int_0 = int_1;

        public int Compare(GStruct9 x, GStruct9 y)
        {
            if (x.int_0 == -10)
            {
                return -y.int_0.CompareTo(int_0);
            }
            return x.int_0.CompareTo(int_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class86
    {
        public FastColoredTextBox fastColoredTextBox_0;

        public System.Windows.Forms.Timer timer_0;

        internal void method_0()
        {
            fastColoredTextBox_0.method_20(timer_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class87
    {
        public DataObject dataObject_0;

        public FastColoredTextBox fastColoredTextBox_0;

        internal void method_0()
        {
            fastColoredTextBox_0.method_25(dataObject_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class88
    {
        public DataObject dataObject_0;

        public FastColoredTextBox fastColoredTextBox_0;

        internal void method_0()
        {
            fastColoredTextBox_0.method_25(dataObject_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class89
    {
        public string string_0;

        internal void method_0()
        {
            if (Clipboard.ContainsText())
            {
                string_0 = Clipboard.GetText();
            }
        }
    }

    [CompilerGenerated]
    private sealed class Class90
    {
        public FastColoredTextBox fastColoredTextBox_0;

        public Rectangle rectangle_0;

        public System.Threading.Timer timer_0;

        internal void method_0(object object_0)
        {
            fastColoredTextBox_0.Invalidate(rectangle_0);
            timer_0.Dispose();
        }
    }

    internal static int int_0;

    private static readonly int int_1;

    private static readonly int int_2;

    private static readonly int int_3;

    private static readonly int int_4;

    private static readonly int int_5;

    private static readonly int int_6;

    private static readonly int int_7;

    public readonly List<GStruct9> list_0 = [];

    private readonly GClass84 gclass84_0;

    private readonly System.Windows.Forms.Timer timer_0 = new();

    private readonly System.Windows.Forms.Timer timer_1 = new();

    private readonly System.Windows.Forms.Timer timer_2 = new();

    private readonly List<GClass99> list_1 = [];

    public int int_8;

    public bool bool_0 = true;

    private Brush brush_0;

    private GClass56 gclass56_0;

    private bool bool_1;

    private Color color_0;

    private int int_9;

    private Color color_1;

    private Cursor cursor_0;

    private GClass84 gclass84_1;

    private string string_0;

    private int int_10 = -1;

    private Color color_2;

    protected Dictionary<int, int> dictionary_0 = [];

    private bool bool_2;

    private bool bool_3;

    private GClass76 gclass76_0;

    private Color color_3;

    private bool bool_4;

    private bool bool_5;

    private bool bool_6;

    private GEnum13 genum13_0;

    private Keys keys_0;

    private Point point_0;

    private DateTime dateTime_0;

    private GClass84 gclass84_2;

    private GClass84 gclass84_3;

    private int int_11;

    private int int_12;

    private Color color_4;

    private uint uint_0;

    private int int_13;

    private GClass97 gclass97_0;

    private IntPtr intptr_0;

    private int int_14;

    private bool bool_7;

    private bool bool_8;

    private bool bool_9;

    protected bool bool_10;

    protected bool bool_11;

    private Point point_1;

    private bool bool_12;

    private bool bool_13;

    private bool bool_14;

    private bool bool_15;

    private Color color_5;

    private int int_15;

    private GClass84 gclass84_4;

    private GClass84 gclass84_5;

    private bool bool_16;

    private Color color_6;

    private Color color_7;

    private bool bool_17;

    private bool bool_18;

    private FastColoredTextBox fastColoredTextBox_0;

    private int int_16 = -1;

    private int int_17;

    private GClass84 gclass84_6;

    private GClass84 gclass84_7;

    private bool bool_19;

    private GEnum5 genum5_0;

    private int int_18 = 1;

    private int int_19 = 100;

    private Size size_0;

    private char[] char_0 = ['(', ')', '{', '}', '[', ']', '"', '"', '\'', '\''];

    [CompilerGenerated]
    private bool bool_20;

    [CompilerGenerated]
    private ServiceColors serviceColors_0;

    [CompilerGenerated]
    private Dictionary<int, int> dictionary_1;

    [CompilerGenerated]
    private BracketsHighlightStrategy bracketsHighlightStrategy_0;

    [CompilerGenerated]
    private bool bool_21;

    [CompilerGenerated]
    private int int_20;

    private readonly GClass82 gclass82_0;

    [CompilerGenerated]
    private ToolTip toolTip_0;

    [CompilerGenerated]
    private Color color_8;

    [CompilerGenerated]
    private bool bool_22;

    [CompilerGenerated]
    private GEnum7 genum7_0;

    [CompilerGenerated]
    private bool bool_23;

    [CompilerGenerated]
    private bool bool_24;

    [CompilerGenerated]
    private bool bool_25;

    [CompilerGenerated]
    private bool bool_26;

    private Color color_9;

    private GEnum8 genum8_0;

    [CompilerGenerated]
    private int int_21;

    [CompilerGenerated]
    private int int_22;

    [CompilerGenerated]
    private int int_23;

    [CompilerGenerated]
    private bool bool_27;

    [CompilerGenerated]
    private Color color_10;

    [CompilerGenerated]
    private Color color_11;

    [CompilerGenerated]
    private bool bool_28;

    [CompilerGenerated]
    private Padding padding_0;

    [CompilerGenerated]
    private int int_24;

    [CompilerGenerated]
    private GClass78 gclass78_0;

    [CompilerGenerated]
    private GClass88 gclass88_0;

    [CompilerGenerated]
    private GClass86 gclass86_0;

    [CompilerGenerated]
    private GClass89 gclass89_0;

    [CompilerGenerated]
    private GClass89 gclass89_1;

    [CompilerGenerated]
    private char char_1;

    [CompilerGenerated]
    private char char_2;

    [CompilerGenerated]
    private char char_3;

    [CompilerGenerated]
    private char char_4;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private GEnum6 genum6_0;

    [CompilerGenerated]
    private bool bool_29;

    [CompilerGenerated]
    private bool bool_30;

    [CompilerGenerated]
    private bool bool_31;

    [CompilerGenerated]
    private GClass96 gclass96_0;

    private bool bool_32;

    [CompilerGenerated]
    private FindForm findForm_0;

    [CompilerGenerated]
    private ReplaceForm replaceForm_0;

    private Font font_0;

    [CompilerGenerated]
    private EventHandler<GEventArgs9> eventHandler_0;

    [CompilerGenerated]
    private EventHandler<GEventArgs10> eventHandler_1;

    [CompilerGenerated]
    private EventHandler<GEventArgs5> eventHandler_2;

    [CompilerGenerated]
    private EventHandler eventHandler_3;

    [CompilerGenerated]
    private EventHandler<GEventArgs6> eventHandler_4;

    [CompilerGenerated]
    private EventHandler<GEventArgs6> eventHandler_5;

    [CompilerGenerated]
    private EventHandler eventHandler_6;

    [CompilerGenerated]
    private EventHandler eventHandler_7;

    [CompilerGenerated]
    private EventHandler<GEventArgs5> eventHandler_8;

    [CompilerGenerated]
    private EventHandler eventHandler_9;

    [CompilerGenerated]
    private EventHandler eventHandler_10;

    [CompilerGenerated]
    private EventHandler<GEventArgs15> eventHandler_11;

    [CompilerGenerated]
    private KeyPressEventHandler keyPressEventHandler_0;

    [CompilerGenerated]
    private KeyPressEventHandler keyPressEventHandler_1;

    [CompilerGenerated]
    private EventHandler<GEventArgs8> eventHandler_12;

    [CompilerGenerated]
    private EventHandler<GEventArgs2> eventHandler_13;

    [CompilerGenerated]
    private EventHandler<GEventArgs3> eventHandler_14;

    [CompilerGenerated]
    private EventHandler<GEventArgs4> eventHandler_15;

    [CompilerGenerated]
    private EventHandler<EventArgs> eventHandler_16;

    [CompilerGenerated]
    private EventHandler<EventArgs> eventHandler_17;

    [CompilerGenerated]
    private EventHandler eventHandler_18;

    [CompilerGenerated]
    private EventHandler<GEventArgs11> eventHandler_19;

    [CompilerGenerated]
    private EventHandler eventHandler_20;

    [CompilerGenerated]
    private EventHandler<GEventArgs7> eventHandler_21;

    private readonly Dictionary<System.Windows.Forms.Timer, System.Windows.Forms.Timer> dictionary_2 = [];

    private readonly List<Control> list_2 = [];

    private bool bool_33;

    private static readonly Dictionary<FCTBAction, bool> dictionary_3 = new()
    {
        {
            FCTBAction.ScrollDown,
            true
        },
        {
            FCTBAction.ScrollUp,
            true
        },
        {
            FCTBAction.ZoomOut,
            true
        },
        {
            FCTBAction.ZoomIn,
            true
        },
        {
            FCTBAction.ZoomNormal,
            true
        }
    };

    private Font font_1;

    private static readonly int int_25;

    [CompilerGenerated]
    private bool bool_34;

    [CompilerGenerated]
    private string string_2;

    private Rectangle rectangle_0;

    protected GClass84 gclass84_8;

    [CompilerGenerated]
    private bool bool_35;

    private bool bool_36;

    private Point point_2;

    private Point point_3;

    private readonly System.Windows.Forms.Timer timer_3 = new();

    private GEnum9 genum9_0;

    private static readonly int int_26;

    [Description("AutoComplete brackets.")]
    [DefaultValue(false)]
    public bool AutoCompleteBrackets
    {
        [CompilerGenerated]
        get
        {
            return bool_20;
        }
        [CompilerGenerated]
        set
        {
            bool_20 = value;
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Colors of some service visual markers.")]
    [Browsable(true)]
    public ServiceColors ServiceColors
    {
        [CompilerGenerated]
        get
        {
            return serviceColors_0;
        }
        [CompilerGenerated]
        set
        {
            serviceColors_0 = value;
        }
    }

    [Browsable(false)]
    public Dictionary<int, int> FoldedBlocks
    {
        [CompilerGenerated]
        get
        {
            return dictionary_1;
        }
        [CompilerGenerated]
        private set
        {
            dictionary_1 = value;
        }
    }

    [DefaultValue(typeof(BracketsHighlightStrategy), "Strategy1")]
    [Description("Strategy of search of brackets to highlighting.")]
    public BracketsHighlightStrategy BracketsHighlightStrategy
    {
        [CompilerGenerated]
        get
        {
            return bracketsHighlightStrategy_0;
        }
        [CompilerGenerated]
        set
        {
            bracketsHighlightStrategy_0 = value;
        }
    }

    [Description("Automatically shifts secondary wordwrap lines on the shift amount of the first line.")]
    [DefaultValue(true)]
    public bool WordWrapAutoIndent
    {
        [CompilerGenerated]
        get
        {
            return bool_21;
        }
        [CompilerGenerated]
        set
        {
            bool_21 = value;
        }
    }

    [DefaultValue(0)]
    [Description("Indent of secondary wordwrap lines (in chars).")]
    public int WordWrapIndent
    {
        [CompilerGenerated]
        get
        {
            return int_20;
        }
        [CompilerGenerated]
        set
        {
            int_20 = value;
        }
    }

    [Browsable(false)]
    public GClass82 GClass82_0 => gclass82_0;

    [Description("Allows drag and drop")]
    [DefaultValue(true)]
    public override bool AllowDrop
    {
        get
        {
            return base.AllowDrop;
        }
        set
        {
            base.AllowDrop = value;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public GClass76 GClass76_0
    {
        get
        {
            return gclass76_0;
        }
        set
        {
            gclass76_0 = value;
        }
    }

    [Description("Delay(ms) of ToolTip.")]
    [DefaultValue(500)]
    [Browsable(true)]
    public int Int32_0
    {
        get
        {
            return timer_2.Interval;
        }
        set
        {
            timer_2.Interval = value;
        }
    }

    [Description("ToolTip component.")]
    [Browsable(true)]
    public ToolTip ToolTip
    {
        [CompilerGenerated]
        get
        {
            return toolTip_0;
        }
        [CompilerGenerated]
        set
        {
            toolTip_0 = value;
        }
    }

    [Description("Color of bookmarks.")]
    [Browsable(true)]
    [DefaultValue(typeof(Color), "PowderBlue")]
    public Color BookmarkColor
    {
        [CompilerGenerated]
        get
        {
            return color_8;
        }
        [CompilerGenerated]
        set
        {
            color_8 = value;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GClass56 GClass56_0
    {
        get
        {
            return gclass56_0;
        }
        set
        {
            gclass56_0 = value;
        }
    }

    [Description("Enables spaces.")]
    [DefaultValue(false)]
    public bool VirtualSpace
    {
        [CompilerGenerated]
        get
        {
            return bool_22;
        }
        [CompilerGenerated]
        set
        {
            bool_22 = value;
        }
    }

    [DefaultValue(GEnum7.const_0)]
    [Description("Strategy of search of end of folding block.")]
    public GEnum7 FindEndOfFoldingBlockStrategy
    {
        [CompilerGenerated]
        get
        {
            return genum7_0;
        }
        [CompilerGenerated]
        set
        {
            genum7_0 = value;
        }
    }

    [DefaultValue(true)]
    [Description("Indicates if tab characters are accepted as input.")]
    public bool AcceptsTab
    {
        [CompilerGenerated]
        get
        {
            return bool_23;
        }
        [CompilerGenerated]
        set
        {
            bool_23 = value;
        }
    }

    [DefaultValue(true)]
    [Description("Indicates if return characters are accepted as input.")]
    public bool AcceptsReturn
    {
        [CompilerGenerated]
        get
        {
            return bool_24;
        }
        [CompilerGenerated]
        set
        {
            bool_24 = value;
        }
    }

    [Description("Shows or hides the caret")]
    [DefaultValue(true)]
    public bool Boolean_0
    {
        get
        {
            return bool_1;
        }
        set
        {
            bool_1 = value;
            method_4();
        }
    }

    [DefaultValue(true)]
    [Description("Enables caret blinking")]
    public bool CaretBlinking
    {
        [CompilerGenerated]
        get
        {
            return bool_25;
        }
        [CompilerGenerated]
        set
        {
            bool_25 = value;
        }
    }

    [DefaultValue(false)]
    public bool ShowCaretWhenInactive
    {
        [CompilerGenerated]
        get
        {
            return bool_26;
        }
        [CompilerGenerated]
        set
        {
            bool_26 = value;
        }
    }

    [Description("Color of border of text area")]
    [DefaultValue(typeof(Color), "Black")]
    public Color Color_0
    {
        get
        {
            return color_9;
        }
        set
        {
            color_9 = value;
            method_4();
        }
    }

    [DefaultValue(typeof(GEnum8), "None")]
    [Description("Type of border of text area")]
    public GEnum8 GEnum8_0
    {
        get
        {
            return genum8_0;
        }
        set
        {
            genum8_0 = value;
            method_4();
        }
    }

    [Description("Background color for current line. Set to Color.Transparent to hide current line highlighting")]
    [DefaultValue(typeof(Color), "Transparent")]
    public Color Color_1
    {
        get
        {
            return color_1;
        }
        set
        {
            color_1 = value;
            method_4();
        }
    }

    [DefaultValue(typeof(Color), "Transparent")]
    [Description("Background color for highlighting of changed lines. Set to Color.Transparent to hide changed line highlighting")]
    public Color Color_2
    {
        get
        {
            return color_0;
        }
        set
        {
            color_0 = value;
            method_4();
        }
    }

    public override Color ForeColor
    {
        get
        {
            return base.ForeColor;
        }
        set
        {
            base.ForeColor = value;
            gclass97_0.vmethod_2();
            method_4();
        }
    }

    [Browsable(false)]
    public int Int32_1
    {
        get
        {
            return int_9;
        }
        set
        {
            int_9 = value;
            method_10();
            vmethod_5();
        }
    }

    [DefaultValue(0)]
    [Description("Interval between lines in pixels")]
    public int Int32_2
    {
        get
        {
            return int_12;
        }
        set
        {
            int_12 = value;
            method_0(Font);
            method_4();
        }
    }

    [Browsable(false)]
    public int CharWidth
    {
        [CompilerGenerated]
        get
        {
            return int_21;
        }
        [CompilerGenerated]
        set
        {
            int_21 = value;
        }
    }

    [Description("Spaces count for tab")]
    [DefaultValue(4)]
    public int TabLength
    {
        [CompilerGenerated]
        get
        {
            return int_22;
        }
        [CompilerGenerated]
        set
        {
            int_22 = value;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool Boolean_1
    {
        get
        {
            return bool_4;
        }
        set
        {
            if (!value)
            {
                gclass97_0.vmethod_0();
            }
            bool_4 = value;
        }
    }

    [Browsable(false)]
    public int TextVersion
    {
        [CompilerGenerated]
        get
        {
            return int_23;
        }
        [CompilerGenerated]
        private set
        {
            int_23 = value;
        }
    }

    [DefaultValue(false)]
    public bool ReadOnly
    {
        [CompilerGenerated]
        get
        {
            return bool_27;
        }
        [CompilerGenerated]
        set
        {
            bool_27 = value;
        }
    }

    [Description("Shows line numbers.")]
    [DefaultValue(true)]
    public bool Boolean_2
    {
        get
        {
            return bool_18;
        }
        set
        {
            bool_18 = value;
            method_10();
            method_4();
        }
    }

    [Description("Shows vertical lines between folding start line and folding end line.")]
    [DefaultValue(false)]
    public bool Boolean_3
    {
        get
        {
            return bool_17;
        }
        set
        {
            bool_17 = value;
            method_4();
        }
    }

    [Browsable(false)]
    public Rectangle Rectangle_0
    {
        get
        {
            int val = LeftIndent + int_14 * CharWidth + Paddings.Left + 1;
            val = Math.Max(base.ClientSize.Width - Paddings.Right, val);
            int val2 = int_8 + Paddings.Top;
            val2 = Math.Max(base.ClientSize.Height - Paddings.Bottom, val2);
            int top = Math.Max(0, Paddings.Top - 1) - base.VerticalScroll.Value;
            return Rectangle.FromLTRB(LeftIndent - base.HorizontalScroll.Value - 2 + Math.Max(0, Paddings.Left - 1), top, val - base.HorizontalScroll.Value, val2 - base.VerticalScroll.Value);
        }
    }

    [Description("Color of line numbers.")]
    [DefaultValue(typeof(Color), "Teal")]
    public Color Color_3
    {
        get
        {
            return color_4;
        }
        set
        {
            color_4 = value;
            method_4();
        }
    }

    [DefaultValue(typeof(uint), "1")]
    [Description("Start value of first line number.")]
    public uint UInt32_0
    {
        get
        {
            return uint_0;
        }
        set
        {
            uint_0 = value;
            bool_10 = true;
            method_4();
        }
    }

    [Description("Background color of indent area")]
    [DefaultValue(typeof(Color), "WhiteSmoke")]
    public Color Color_4
    {
        get
        {
            return color_3;
        }
        set
        {
            color_3 = value;
            method_4();
        }
    }

    [DefaultValue(typeof(Color), "Transparent")]
    [Description("Background color of padding area")]
    public Color Color_5
    {
        get
        {
            return color_5;
        }
        set
        {
            color_5 = value;
            method_4();
        }
    }

    [DefaultValue(typeof(Color), "100;180;180;180")]
    [Description("Color of disabled component")]
    public Color DisabledColor
    {
        [CompilerGenerated]
        get
        {
            return color_10;
        }
        [CompilerGenerated]
        set
        {
            color_10 = value;
        }
    }

    [Description("Color of caret.")]
    [DefaultValue(typeof(Color), "Black")]
    public Color CaretColor
    {
        [CompilerGenerated]
        get
        {
            return color_11;
        }
        [CompilerGenerated]
        set
        {
            color_11 = value;
        }
    }

    [DefaultValue(false)]
    [Description("Wide caret.")]
    public bool WideCaret
    {
        [CompilerGenerated]
        get
        {
            return bool_28;
        }
        [CompilerGenerated]
        set
        {
            bool_28 = value;
        }
    }

    [Description("Color of service lines (folding lines, borders of blocks etc.)")]
    [DefaultValue(typeof(Color), "Silver")]
    public Color Color_6
    {
        get
        {
            return color_7;
        }
        set
        {
            color_7 = value;
            method_4();
        }
    }

    [Browsable(true)]
    [Description("Paddings of text area.")]
    public Padding Paddings
    {
        [CompilerGenerated]
        get
        {
            return padding_0;
        }
        [CompilerGenerated]
        set
        {
            padding_0 = value;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Padding Padding_0
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool Boolean_4
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    [DefaultValue(typeof(Color), "Green")]
    [Description("Color of folding area indicator.")]
    public Color Color_7
    {
        get
        {
            return color_2;
        }
        set
        {
            color_2 = value;
            method_4();
        }
    }

    [Description("Enables folding indicator (left vertical line between folding bounds)")]
    [DefaultValue(true)]
    public bool Boolean_5
    {
        get
        {
            return bool_3;
        }
        set
        {
            bool_3 = value;
            method_4();
        }
    }

    [Description("Left distance to text beginning.")]
    [Browsable(false)]
    public int LeftIndent
    {
        [CompilerGenerated]
        get
        {
            return int_24;
        }
        [CompilerGenerated]
        private set
        {
            int_24 = value;
        }
    }

    [Description("Width of left service area (in pixels)")]
    [DefaultValue(0)]
    public int Int32_3
    {
        get
        {
            return int_11;
        }
        set
        {
            int_11 = value;
            method_4();
        }
    }

    [DefaultValue(0)]
    [Description("This property draws vertical line after defined char position. Set to 0 for disable drawing of vertical line.")]
    public int Int32_4
    {
        get
        {
            return int_15;
        }
        set
        {
            int_15 = value;
            method_4();
        }
    }

    [Browsable(false)]
    public GClass85[] GClass85_0 => gclass97_0.gclass85_0;

    [Description("Here you can change hotkeys for FastColoredTextBox.")]
    [DefaultValue("Tab=IndentIncrease, Escape=ClearHints, PgUp=GoPageUp, PgDn=GoPageDown, End=GoEnd, Home=GoHome, Left=GoLeft, Up=GoUp, Right=GoRight, Down=GoDown, Ins=ReplaceMode, Del=DeleteCharRight, F3=FindNext, Shift+Tab=IndentDecrease, Shift+PgUp=GoPageUpWithSelection, Shift+PgDn=GoPageDownWithSelection, Shift+End=GoEndWithSelection, Shift+Home=GoHomeWithSelection, Shift+Left=GoLeftWithSelection, Shift+Up=GoUpWithSelection, Shift+Right=GoRightWithSelection, Shift+Down=GoDownWithSelection, Shift+Ins=Paste, Shift+Del=Cut, Ctrl+Back=ClearWordLeft, Ctrl+Space=AutocompleteMenu, Ctrl+End=GoLastLine, Ctrl+Home=GoFirstLine, Ctrl+Left=GoWordLeft, Ctrl+Up=ScrollUp, Ctrl+Right=GoWordRight, Ctrl+Down=ScrollDown, Ctrl+Ins=Copy, Ctrl+Del=ClearWordRight, Ctrl+0=ZoomNormal, Ctrl+A=SelectAll, Ctrl+B=BookmarkLine, Ctrl+C=Copy, Ctrl+E=MacroExecute, Ctrl+F=FindDialog, Ctrl+G=GoToDialog, Ctrl+H=ReplaceDialog, Ctrl+I=AutoIndentChars, Ctrl+M=MacroRecord, Ctrl+N=GoNextBookmark, Ctrl+R=Redo, Ctrl+U=UpperCase, Ctrl+V=Paste, Ctrl+X=Cut, Ctrl+Z=Undo, Ctrl+Add=ZoomIn, Ctrl+Subtract=ZoomOut, Ctrl+OemMinus=NavigateBackward, Ctrl+Shift+End=GoLastLineWithSelection, Ctrl+Shift+Home=GoFirstLineWithSelection, Ctrl+Shift+Left=GoWordLeftWithSelection, Ctrl+Shift+Right=GoWordRightWithSelection, Ctrl+Shift+B=UnbookmarkLine, Ctrl+Shift+C=CommentSelected, Ctrl+Shift+N=GoPrevBookmark, Ctrl+Shift+U=LowerCase, Ctrl+Shift+OemMinus=NavigateForward, Alt+Back=Undo, Alt+Up=MoveSelectedLinesUp, Alt+Down=MoveSelectedLinesDown, Alt+F=FindChar, Alt+Shift+Left=GoLeft_ColumnSelectionMode, Alt+Shift+Up=GoUp_ColumnSelectionMode, Alt+Shift+Right=GoRight_ColumnSelectionMode, Alt+Shift+Down=GoDown_ColumnSelectionMode")]
    [Editor(typeof(Class95), typeof(UITypeEditor))]
    public string String_0
    {
        get
        {
            return HotkeysMapping.ToString();
        }
        set
        {
            HotkeysMapping = GClass78.smethod_0(value);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GClass78 HotkeysMapping
    {
        [CompilerGenerated]
        get
        {
            return gclass78_0;
        }
        [CompilerGenerated]
        set
        {
            gclass78_0 = value;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public GClass86 GClass86_0
    {
        get
        {
            return gclass97_0.DefaultStyle;
        }
        set
        {
            gclass97_0.DefaultStyle = value;
        }
    }

    [Browsable(false)]
    public GClass88 SelectionStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass88_0;
        }
        [CompilerGenerated]
        set
        {
            gclass88_0 = value;
        }
    }

    [Browsable(false)]
    public GClass86 FoldedBlockStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass86_0;
        }
        [CompilerGenerated]
        set
        {
            gclass86_0 = value;
        }
    }

    [Browsable(false)]
    public GClass89 BracketsStyle
    {
        [CompilerGenerated]
        get
        {
            return gclass89_0;
        }
        [CompilerGenerated]
        set
        {
            gclass89_0 = value;
        }
    }

    [Browsable(false)]
    public GClass89 BracketsStyle2
    {
        [CompilerGenerated]
        get
        {
            return gclass89_1;
        }
        [CompilerGenerated]
        set
        {
            gclass89_1 = value;
        }
    }

    [Description("Opening bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
    [DefaultValue('\0')]
    public char LeftBracket
    {
        [CompilerGenerated]
        get
        {
            return char_1;
        }
        [CompilerGenerated]
        set
        {
            char_1 = value;
        }
    }

    [Description("Closing bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
    [DefaultValue('\0')]
    public char RightBracket
    {
        [CompilerGenerated]
        get
        {
            return char_2;
        }
        [CompilerGenerated]
        set
        {
            char_2 = value;
        }
    }

    [DefaultValue('\0')]
    [Description("Alternative opening bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
    public char LeftBracket2
    {
        [CompilerGenerated]
        get
        {
            return char_3;
        }
        [CompilerGenerated]
        set
        {
            char_3 = value;
        }
    }

    [DefaultValue('\0')]
    [Description("Alternative closing bracket for brackets highlighting. Set to '\\x0' for disable brackets highlighting.")]
    public char RightBracket2
    {
        [CompilerGenerated]
        get
        {
            return char_4;
        }
        [CompilerGenerated]
        set
        {
            char_4 = value;
        }
    }

    [DefaultValue("//")]
    [Description("Comment line prefix.")]
    public string CommentPrefix
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
        [CompilerGenerated]
        set
        {
            string_1 = value;
        }
    }

    [Description("This property specifies which part of the text will be highlighted as you type.")]
    [DefaultValue(typeof(GEnum6), "ChangedRange")]
    public GEnum6 HighlightingRangeType
    {
        [CompilerGenerated]
        get
        {
            return genum6_0;
        }
        [CompilerGenerated]
        set
        {
            genum6_0 = value;
        }
    }

    [Browsable(false)]
    public bool Boolean_6
    {
        get
        {
            if (bool_6 && GClass84_5.vmethod_0() && !GClass84_5.Boolean_0)
            {
                return GClass84_5.GStruct10_0.int_0 < gclass97_0[GClass84_5.GStruct10_0.int_1].Count;
            }
            return false;
        }
        set
        {
            bool_6 = value;
        }
    }

    [Description("Allows text rendering several styles same time.")]
    [DefaultValue(false)]
    [Browsable(true)]
    public bool AllowSeveralTextStyleDrawing
    {
        [CompilerGenerated]
        get
        {
            return bool_29;
        }
        [CompilerGenerated]
        set
        {
            bool_29 = value;
        }
    }

    [DefaultValue(true)]
    [Browsable(true)]
    [Description("Allows to record macros.")]
    public bool Boolean_7
    {
        get
        {
            return gclass82_0.AllowMacroRecordingByUser;
        }
        set
        {
            gclass82_0.AllowMacroRecordingByUser = value;
        }
    }

    [Description("Allows auto indent. Inserts spaces before line chars.")]
    [DefaultValue(true)]
    public bool AutoIndent
    {
        [CompilerGenerated]
        get
        {
            return bool_30;
        }
        [CompilerGenerated]
        set
        {
            bool_30 = value;
        }
    }

    [Description("Does autoindenting in existing lines. It works only if AutoIndent is True.")]
    [DefaultValue(true)]
    public bool AutoIndentExistingLines
    {
        [CompilerGenerated]
        get
        {
            return bool_31;
        }
        [CompilerGenerated]
        set
        {
            bool_31 = value;
        }
    }

    [DefaultValue(100)]
    [Description("Minimal delay(ms) for delayed events (except TextChangedDelayed).")]
    [Browsable(true)]
    public int Int32_5
    {
        get
        {
            return timer_0.Interval;
        }
        set
        {
            timer_0.Interval = value;
        }
    }

    [Browsable(true)]
    [Description("Minimal delay(ms) for TextChangedDelayed event.")]
    [DefaultValue(100)]
    public int Int32_6
    {
        get
        {
            return timer_1.Interval;
        }
        set
        {
            timer_1.Interval = value;
        }
    }

    [Description("Language for highlighting by built-in highlighter.")]
    [Browsable(true)]
    [DefaultValue(typeof(GEnum13), "Custom")]
    public GEnum13 GEnum13_0
    {
        get
        {
            return genum13_0;
        }
        set
        {
            genum13_0 = value;
            SyntaxHighlighter?.method_10(genum13_0);
            method_4();
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public GClass96 SyntaxHighlighter
    {
        [CompilerGenerated]
        get
        {
            return gclass96_0;
        }
        [CompilerGenerated]
        set
        {
            gclass96_0 = value;
        }
    }

    [DefaultValue(null)]
    [Description("XML file with description of syntax highlighting. This property works only with Language == Language.Custom.")]
    [Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
    [Browsable(true)]
    public string String_1
    {
        get
        {
            return string_0;
        }
        set
        {
            string_0 = value;
            method_4();
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GClass84 GClass84_0 => gclass84_2;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public GClass84 GClass84_1 => gclass84_4;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GClass84 GClass84_2 => gclass84_3;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GClass84 GClass84_3 => gclass84_5;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Int32_7 => int_16;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Int32_8 => int_10;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public GClass97 GClass97_0
    {
        get
        {
            return gclass97_0;
        }
        set
        {
            vmethod_7(value);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool Boolean_8 => FastColoredTextBox_0 != null;

    [DefaultValue(null)]
    [Description("Allows to get text from other FastColoredTextBox.")]
    [Browsable(true)]
    public FastColoredTextBox FastColoredTextBox_0
    {
        get
        {
            return fastColoredTextBox_0;
        }
        set
        {
            if (value != fastColoredTextBox_0)
            {
                fastColoredTextBox_0 = value;
                if (fastColoredTextBox_0 == null)
                {
                    vmethod_7(vmethod_6());
                    gclass97_0.vmethod_7(0, GClass97_0.vmethod_1());
                    Boolean_1 = false;
                }
                else
                {
                    vmethod_7(FastColoredTextBox_0.GClass97_0);
                    bool_4 = false;
                }
                method_4();
            }
        }
    }

    [Browsable(false)]
    public GClass84 GClass84_4
    {
        get
        {
            if (gclass84_7 != null)
            {
                return gclass84_7;
            }
            return method_96(method_83(new Point(LeftIndent, 0)), method_83(new Point(base.ClientSize.Width, base.ClientSize.Height)));
        }
    }

    [Browsable(false)]
    public GClass84 GClass84_5
    {
        get
        {
            return gclass84_0;
        }
        set
        {
            if (value != gclass84_0)
            {
                gclass84_0.method_38();
                gclass84_0.GStruct10_0 = value.GStruct10_0;
                gclass84_0.GStruct10_1 = value.GStruct10_1;
                gclass84_0.method_39();
                method_4();
            }
        }
    }

    [DefaultValue(typeof(Color), "White")]
    [Description("Background color.")]
    public override Color BackColor
    {
        get
        {
            return base.BackColor;
        }
        set
        {
            base.BackColor = value;
        }
    }

    [Browsable(false)]
    public Brush Brush_0
    {
        get
        {
            return brush_0;
        }
        set
        {
            brush_0 = value;
            method_4();
        }
    }

    [Browsable(true)]
    [DefaultValue(true)]
    [Description("Scollbars visibility.")]
    public bool Boolean_9
    {
        get
        {
            return bool_16;
        }
        set
        {
            if (value != bool_16)
            {
                bool_16 = value;
                bool_10 = true;
                method_4();
            }
        }
    }

    [Description("Multiline mode.")]
    [DefaultValue(true)]
    [Browsable(true)]
    public bool Boolean_10
    {
        get
        {
            return bool_9;
        }
        set
        {
            if (bool_9 == value)
            {
                return;
            }
            bool_9 = value;
            bool_10 = true;
            if (bool_9)
            {
                base.AutoScroll = true;
                Boolean_9 = true;
            }
            else
            {
                base.AutoScroll = false;
                Boolean_9 = false;
                if (gclass97_0.Count > 1)
                {
                    gclass97_0.vmethod_12(1, gclass97_0.Count - 1);
                }
                gclass97_0.Manager.method_5();
            }
            method_4();
        }
    }

    [Browsable(true)]
    [Description("WordWrap.")]
    [DefaultValue(false)]
    public bool Boolean_11
    {
        get
        {
            return bool_19;
        }
        set
        {
            if (bool_19 != value)
            {
                bool_19 = value;
                if (bool_19)
                {
                    GClass84_5.Boolean_0 = false;
                }
                method_12(bool_37: false, bool_38: true);
                method_4();
            }
        }
    }

    [DefaultValue(typeof(GEnum5), "WordWrapControlWidth")]
    [Description("WordWrap mode.")]
    [Browsable(true)]
    public GEnum5 GEnum5_0
    {
        get
        {
            return genum5_0;
        }
        set
        {
            if (genum5_0 != value)
            {
                genum5_0 = value;
                method_12(bool_37: false, bool_38: true);
                method_4();
            }
        }
    }

    [Description("If enabled then line ends included into the selection will be selected too. Then line ends will be shown as selected blank character.")]
    [DefaultValue(true)]
    public bool Boolean_12
    {
        get
        {
            return bool_32;
        }
        set
        {
            bool_32 = value;
            method_4();
        }
    }

    [Browsable(false)]
    public FindForm findForm
    {
        [CompilerGenerated]
        get
        {
            return findForm_0;
        }
        [CompilerGenerated]
        private set
        {
            findForm_0 = value;
        }
    }

    [Browsable(false)]
    public ReplaceForm replaceForm
    {
        [CompilerGenerated]
        get
        {
            return replaceForm_0;
        }
        [CompilerGenerated]
        private set
        {
            replaceForm_0 = value;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public override bool AutoScroll
    {
        get
        {
            return base.AutoScroll;
        }
        set
        {
        }
    }

    [Browsable(false)]
    public int Int32_9 => gclass97_0.Count;

    [Description("Text of the control.")]
    [Bindable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Localizable(true)]
    [Browsable(true)]
    [SettingsBindable(true)]
    [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
    public override string Text
    {
        get
        {
            if (Int32_9 == 0)
            {
                return "";
            }
            GClass84 gClass = new(this);
            gClass.method_2();
            return gClass.vmethod_2();
        }
        set
        {
            if (value == Text && value != "")
            {
                return;
            }
            method_6();
            GClass84_5.Boolean_0 = false;
            GClass84_5.method_38();
            try
            {
                GClass84_5.method_2();
                vmethod_20(value);
                method_28();
            }
            finally
            {
                GClass84_5.method_39();
            }
        }
    }

    [Browsable(false)]
    public IList<string> IList_0 => gclass97_0.vmethod_4();

    [Browsable(false)]
    public string String_2
    {
        get
        {
            GClass72 gClass = new()
            {
                UseNbsp = false,
                UseStyleTag = false,
                UseBr = false
            };
            return "<pre>" + gClass.method_0(this) + "</pre>";
        }
    }

    [Browsable(false)]
    public string String_3 => new GClass73().method_0(this);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string String_4
    {
        get
        {
            return GClass84_5.vmethod_2();
        }
        set
        {
            vmethod_20(value);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int Int32_10
    {
        get
        {
            return Math.Min(method_91(GClass84_5.GStruct10_0), method_91(GClass84_5.GStruct10_1));
        }
        set
        {
            GClass84_5.GStruct10_0 = method_92(value);
        }
    }

    [Browsable(false)]
    [DefaultValue(0)]
    public int Int32_11
    {
        get
        {
            return GClass84_5.Int32_0;
        }
        set
        {
            if (value > 0)
            {
                GClass84_5.GStruct10_1 = method_92(Int32_10 + value);
            }
        }
    }

    [DefaultValue(typeof(Font), "Courier New, 9.75")]
    public override Font Font
    {
        get
        {
            return Font_0;
        }
        set
        {
            font_1 = (Font)value.Clone();
            method_0(value);
        }
    }

    [DefaultValue(typeof(Font), "Courier New, 9.75")]
    private Font Font_0
    {
        get
        {
            return font_0;
        }
        set
        {
            font_0 = value;
        }
    }

    [Browsable(false)]
    public bool Boolean_13
    {
        get
        {
            if (base.ImeMode != ImeMode.Disable && base.ImeMode != ImeMode.Off)
            {
                return base.ImeMode != ImeMode.NoControl;
            }
            return false;
        }
    }

    [Browsable(false)]
    public bool Boolean_14 => gclass97_0.Manager.Boolean_0;

    [Browsable(false)]
    public bool Boolean_15 => gclass97_0.Manager.Boolean_1;

    [Browsable(false)]
    public GClass84 GClass84_6 => new(this, new GStruct10(0, 0), new GStruct10(gclass97_0[gclass97_0.Count - 1].Count, gclass97_0.Count - 1));

    [DefaultValue(typeof(Color), "Blue")]
    [Description("Color of selected area.")]
    public Color Color_8
    {
        get
        {
            return color_6;
        }
        set
        {
            color_6 = value;
            if (color_6.A == byte.MaxValue)
            {
                color_6 = Color.FromArgb(60, color_6);
            }
            SelectionStyle = new GClass88(new SolidBrush(color_6));
            method_4();
        }
    }

    public override Cursor Cursor
    {
        get
        {
            return base.Cursor;
        }
        set
        {
            cursor_0 = value;
            base.Cursor = value;
        }
    }

    [Description("Reserved space for line number characters. If smaller than needed (e. g. line count >= 10 and this value set to 1) this value will have no impact. If you want to reserve space, e. g. for line numbers >= 10 or >= 100, than you can set this value to 2 or 3 or higher.")]
    [DefaultValue(1)]
    public int Int32_12
    {
        get
        {
            return int_18;
        }
        set
        {
            int_18 = value;
            method_10();
            method_4();
        }
    }

    [DefaultValue(true)]
    [Description("Enables AutoIndentChars mode")]
    public bool AutoIndentChars
    {
        [CompilerGenerated]
        get
        {
            return bool_34;
        }
        [CompilerGenerated]
        set
        {
            bool_34 = value;
        }
    }

    [Description("Regex patterns for AutoIndentChars (one regex per line)")]
    [DefaultValue("^\\s*[\\w\\.]+\\s*(?<range>=)\\s*(?<range>[^;]+);")]
    [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
    public string AutoIndentCharsPatterns
    {
        [CompilerGenerated]
        get
        {
            return string_2;
        }
        [CompilerGenerated]
        set
        {
            string_2 = value;
        }
    }

    [Browsable(false)]
    public int Int32_13
    {
        get
        {
            return int_19;
        }
        set
        {
            int_19 = value;
            method_79((float)int_19 / 100f);
            vmethod_51();
        }
    }

    private bool IsDragDrop
    {
        [CompilerGenerated]
        get
        {
            return bool_35;
        }
        [CompilerGenerated]
        set
        {
            bool_35 = value;
        }
    }

    public char[] Char_0
    {
        get
        {
            return char_0;
        }
        set
        {
            char_0 = value;
        }
    }

    public GStruct8 this[GStruct10 gstruct10_0]
    {
        get
        {
            return gclass97_0[gstruct10_0.int_1][gstruct10_0.int_0];
        }
        set
        {
            gclass97_0[gstruct10_0.int_1][gstruct10_0.int_0] = value;
        }
    }

    public GClass80 this[int int_27] => gclass97_0[int_27];

    public int Int32_14
    {
        get
        {
            if (Int32_9 == 0)
            {
                return 0;
            }
            GClass84 gClass = new(this);
            gClass.method_2();
            return gClass.Int32_0;
        }
    }

    public Size Size_0
    {
        get
        {
            if (bool_16)
            {
                return base.AutoScrollMinSize;
            }
            return size_0;
        }
        set
        {
            if (bool_16)
            {
                if (!base.AutoScroll)
                {
                    base.AutoScroll = true;
                }
                Size autoScrollMinSize = value;
                if (Boolean_11 && GEnum5_0 != GEnum5.const_4)
                {
                    int val = method_44();
                    autoScrollMinSize = new Size(Math.Min(autoScrollMinSize.Width, val), autoScrollMinSize.Height);
                }
                base.AutoScrollMinSize = autoScrollMinSize;
            }
            else
            {
                if (base.AutoScroll)
                {
                    base.AutoScroll = false;
                }
                base.AutoScrollMinSize = new Size(0, 0);
                base.VerticalScroll.Visible = false;
                base.HorizontalScroll.Visible = false;
                base.VerticalScroll.Maximum = Math.Max(0, value.Height - base.ClientSize.Height);
                base.HorizontalScroll.Maximum = Math.Max(0, value.Width - base.ClientSize.Width);
                size_0 = value;
            }
        }
    }

    private int Int32_15 => LeftIndent - 4 - 3;

    [Description("Occurs when mouse is moving over text and tooltip is needed.")]
    [Browsable(true)]
    public event EventHandler<GEventArgs9> Event_0
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs9> eventHandler = eventHandler_0;
            EventHandler<GEventArgs9> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs9> value2 = (EventHandler<GEventArgs9>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs9> eventHandler = eventHandler_0;
            EventHandler<GEventArgs9> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs9> value2 = (EventHandler<GEventArgs9>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Description("It occurs if user click on the hint.")]
    [Browsable(true)]
    public event EventHandler<GEventArgs10> Event_1
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs10> eventHandler = eventHandler_1;
            EventHandler<GEventArgs10> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs10> value2 = (EventHandler<GEventArgs10>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs10> eventHandler = eventHandler_1;
            EventHandler<GEventArgs10> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs10> value2 = (EventHandler<GEventArgs10>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs after insert, delete, clear, undo and redo operations.")]
    public event EventHandler<GEventArgs5> Event_2
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs5> eventHandler = eventHandler_2;
            EventHandler<GEventArgs5> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs5> value2 = (EventHandler<GEventArgs5>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs5> eventHandler = eventHandler_2;
            EventHandler<GEventArgs5> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs5> value2 = (EventHandler<GEventArgs5>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(false)]
    internal event EventHandler Event_3
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_3;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_3;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Description("Occurs when user paste text from clipboard")]
    public event EventHandler<GEventArgs6> Event_4
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs6> eventHandler = eventHandler_4;
            EventHandler<GEventArgs6> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs6> value2 = (EventHandler<GEventArgs6>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs6> eventHandler = eventHandler_4;
            EventHandler<GEventArgs6> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs6> value2 = (EventHandler<GEventArgs6>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs before insert, delete, clear, undo and redo operations.")]
    public event EventHandler<GEventArgs6> Event_5
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs6> eventHandler = eventHandler_5;
            EventHandler<GEventArgs6> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs6> value2 = (EventHandler<GEventArgs6>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs6> eventHandler = eventHandler_5;
            EventHandler<GEventArgs6> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs6> value2 = (EventHandler<GEventArgs6>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Description("It occurs after changing of selection.")]
    [Browsable(true)]
    public event EventHandler Event_6
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_6;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_6;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Description("It occurs after changing of visible range.")]
    [Browsable(true)]
    public event EventHandler Event_7
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_7;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_7, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_7;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_7, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs after insert, delete, clear, undo and redo operations. This event occurs with a delay relative to TextChanged, and fires only once.")]
    public event EventHandler<GEventArgs5> Event_8
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs5> eventHandler = eventHandler_8;
            EventHandler<GEventArgs5> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs5> value2 = (EventHandler<GEventArgs5>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_8, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs5> eventHandler = eventHandler_8;
            EventHandler<GEventArgs5> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs5> value2 = (EventHandler<GEventArgs5>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_8, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs after changing of selection. This event occurs with a delay relative to SelectionChanged, and fires only once.")]
    public event EventHandler Event_9
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_9;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_9, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_9;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_9, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Description("It occurs after changing of visible range. This event occurs with a delay relative to VisibleRangeChanged, and fires only once.")]
    [Browsable(true)]
    public event EventHandler Event_10
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_10;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_10, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_10;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_10, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs when user click on VisualMarker.")]
    public event EventHandler<GEventArgs15> Event_11
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs15> eventHandler = eventHandler_11;
            EventHandler<GEventArgs15> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs15> value2 = (EventHandler<GEventArgs15>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_11, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs15> eventHandler = eventHandler_11;
            EventHandler<GEventArgs15> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs15> value2 = (EventHandler<GEventArgs15>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_11, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs when visible char is enetering (alphabetic, digit, punctuation, DEL, BACKSPACE).")]
    public event KeyPressEventHandler Event_12
    {
        [CompilerGenerated]
        add
        {
            KeyPressEventHandler keyPressEventHandler = keyPressEventHandler_0;
            KeyPressEventHandler keyPressEventHandler2;
            do
            {
                keyPressEventHandler2 = keyPressEventHandler;
                KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine(keyPressEventHandler2, value);
                keyPressEventHandler = Interlocked.CompareExchange(ref keyPressEventHandler_0, value2, keyPressEventHandler2);
            }
            while ((object)keyPressEventHandler != keyPressEventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            KeyPressEventHandler keyPressEventHandler = keyPressEventHandler_0;
            KeyPressEventHandler keyPressEventHandler2;
            do
            {
                keyPressEventHandler2 = keyPressEventHandler;
                KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove(keyPressEventHandler2, value);
                keyPressEventHandler = Interlocked.CompareExchange(ref keyPressEventHandler_0, value2, keyPressEventHandler2);
            }
            while ((object)keyPressEventHandler != keyPressEventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs when visible char is enetered (alphabetic, digit, punctuation, DEL, BACKSPACE).")]
    public event KeyPressEventHandler Event_13
    {
        [CompilerGenerated]
        add
        {
            KeyPressEventHandler keyPressEventHandler = keyPressEventHandler_1;
            KeyPressEventHandler keyPressEventHandler2;
            do
            {
                keyPressEventHandler2 = keyPressEventHandler;
                KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine(keyPressEventHandler2, value);
                keyPressEventHandler = Interlocked.CompareExchange(ref keyPressEventHandler_1, value2, keyPressEventHandler2);
            }
            while ((object)keyPressEventHandler != keyPressEventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            KeyPressEventHandler keyPressEventHandler = keyPressEventHandler_1;
            KeyPressEventHandler keyPressEventHandler2;
            do
            {
                keyPressEventHandler2 = keyPressEventHandler;
                KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove(keyPressEventHandler2, value);
                keyPressEventHandler = Interlocked.CompareExchange(ref keyPressEventHandler_1, value2, keyPressEventHandler2);
            }
            while ((object)keyPressEventHandler != keyPressEventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs when calculates AutoIndent for new line.")]
    public event EventHandler<GEventArgs8> Event_14
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs8> eventHandler = eventHandler_12;
            EventHandler<GEventArgs8> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs8> value2 = (EventHandler<GEventArgs8>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_12, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs8> eventHandler = eventHandler_12;
            EventHandler<GEventArgs8> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs8> value2 = (EventHandler<GEventArgs8>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_12, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("It occurs when line background is painting.")]
    public event EventHandler<GEventArgs2> Event_15
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs2> eventHandler = eventHandler_13;
            EventHandler<GEventArgs2> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_13, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs2> eventHandler = eventHandler_13;
            EventHandler<GEventArgs2> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_13, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Description("Occurs when line was inserted/added.")]
    [Browsable(true)]
    public event EventHandler<GEventArgs3> Event_16
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs3> eventHandler = eventHandler_14;
            EventHandler<GEventArgs3> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_14, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs3> eventHandler = eventHandler_14;
            EventHandler<GEventArgs3> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_14, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("Occurs when line was removed.")]
    public event EventHandler<GEventArgs4> Event_17
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs4> eventHandler = eventHandler_15;
            EventHandler<GEventArgs4> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs4> value2 = (EventHandler<GEventArgs4>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_15, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs4> eventHandler = eventHandler_15;
            EventHandler<GEventArgs4> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs4> value2 = (EventHandler<GEventArgs4>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_15, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("Occurs when current highlighted folding area is changed.")]
    public event EventHandler<EventArgs> Event_18
    {
        [CompilerGenerated]
        add
        {
            EventHandler<EventArgs> eventHandler = eventHandler_16;
            EventHandler<EventArgs> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<EventArgs> value2 = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_16, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<EventArgs> eventHandler = eventHandler_16;
            EventHandler<EventArgs> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<EventArgs> value2 = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_16, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("Occurs when undo/redo stack is changed.")]
    public event EventHandler<EventArgs> Event_19
    {
        [CompilerGenerated]
        add
        {
            EventHandler<EventArgs> eventHandler = eventHandler_17;
            EventHandler<EventArgs> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<EventArgs> value2 = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_17, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<EventArgs> eventHandler = eventHandler_17;
            EventHandler<EventArgs> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<EventArgs> value2 = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_17, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("Occurs when component was zoomed.")]
    public event EventHandler Event_20
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_18;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_18, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_18;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_18, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("Occurs when user pressed key, that specified as CustomAction.")]
    public event EventHandler<GEventArgs11> Event_21
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs11> eventHandler = eventHandler_19;
            EventHandler<GEventArgs11> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs11> value2 = (EventHandler<GEventArgs11>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_19, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs11> eventHandler = eventHandler_19;
            EventHandler<GEventArgs11> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs11> value2 = (EventHandler<GEventArgs11>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_19, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Browsable(true)]
    [Description("Occurs when scroolbars are updated.")]
    public event EventHandler Event_22
    {
        [CompilerGenerated]
        add
        {
            EventHandler eventHandler = eventHandler_20;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_20, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler eventHandler = eventHandler_20;
            EventHandler eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_20, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    [Description("Occurs when custom wordwrap is needed.")]
    [Browsable(true)]
    public event EventHandler<GEventArgs7> Event_23
    {
        [CompilerGenerated]
        add
        {
            EventHandler<GEventArgs7> eventHandler = eventHandler_21;
            EventHandler<GEventArgs7> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs7> value2 = (EventHandler<GEventArgs7>)Delegate.Combine(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_21, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
        [CompilerGenerated]
        remove
        {
            EventHandler<GEventArgs7> eventHandler = eventHandler_21;
            EventHandler<GEventArgs7> eventHandler2;
            do
            {
                eventHandler2 = eventHandler;
                EventHandler<GEventArgs7> value2 = (EventHandler<GEventArgs7>)Delegate.Remove(eventHandler2, value);
                eventHandler = Interlocked.CompareExchange(ref eventHandler_21, value2, eventHandler2);
            }
            while ((object)eventHandler != eventHandler2);
        }
    }

    public FastColoredTextBox()
    {
        TypeDescriptionProvider provider = TypeDescriptor.GetProvider(GetType());
        if (provider.GetType().GetField("Provider", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(provider)
            .GetType() != typeof(Class109))
        {
            TypeDescriptor.AddProvider(new Class109(GetType()), GetType());
        }
        SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
        Font = new Font(FontFamily.GenericMonospace, 9.75f);
        vmethod_7(vmethod_6());
        if (gclass97_0.Count == 0)
        {
            gclass97_0.vmethod_7(0, gclass97_0.vmethod_1());
        }
        gclass84_0 = new GClass84(this)
        {
            GStruct10_0 = new GStruct10(0, 0)
        };
        Cursor = Cursors.IBeam;
        BackColor = Color.White;
        Color_3 = Color.Teal;
        Color_4 = Color.WhiteSmoke;
        Color_6 = Color.Silver;
        Color_7 = Color.Green;
        Color_1 = Color.Transparent;
        Color_2 = Color.Transparent;
        Boolean_5 = true;
        Boolean_2 = true;
        TabLength = 4;
        FoldedBlockStyle = new GClass87(Brushes.Gray, null, FontStyle.Regular);
        Color_8 = Color.Blue;
        BracketsStyle = new GClass89(new SolidBrush(Color.FromArgb(80, Color.Lime)));
        BracketsStyle2 = new GClass89(new SolidBrush(Color.FromArgb(60, Color.Red)));
        Int32_5 = 100;
        Int32_6 = 100;
        AllowSeveralTextStyleDrawing = false;
        LeftBracket = '\0';
        RightBracket = '\0';
        LeftBracket2 = '\0';
        RightBracket2 = '\0';
        SyntaxHighlighter = new GClass96(this);
        genum13_0 = GEnum13.const_0;
        Int32_4 = 0;
        bool_10 = true;
        dateTime_0 = DateTime.Now;
        AutoIndent = true;
        AutoIndentExistingLines = true;
        CommentPrefix = "//";
        uint_0 = 1u;
        bool_9 = true;
        bool_16 = true;
        AcceptsTab = true;
        AcceptsReturn = true;
        bool_1 = true;
        CaretColor = Color.Black;
        WideCaret = false;
        Paddings = new Padding(0, 0, 0, 0);
        Color_5 = Color.Transparent;
        DisabledColor = Color.FromArgb(100, 180, 180, 180);
        bool_12 = true;
        AllowDrop = true;
        FindEndOfFoldingBlockStrategy = GEnum7.const_0;
        VirtualSpace = false;
        gclass56_0 = new GClass57(this);
        BookmarkColor = Color.PowderBlue;
        ToolTip = new ToolTip();
        timer_2.Interval = 500;
        gclass76_0 = new GClass76(this);
        Boolean_12 = true;
        genum8_0 = GEnum8.const_0;
        color_9 = Color.Black;
        gclass82_0 = new GClass82(this);
        HotkeysMapping = [];
        HotkeysMapping.vmethod_0();
        WordWrapAutoIndent = true;
        FoldedBlocks = [];
        AutoCompleteBrackets = false;
        AutoIndentCharsPatterns = "^\\s*[\\w\\.]+\\s*(?<range>=)\\s*(?<range>[^;]+);";
        AutoIndentChars = true;
        CaretBlinking = true;
        ServiceColors = new ServiceColors();
        base.AutoScroll = true;
        timer_0.Tick += timer_0_Tick;
        timer_1.Tick += timer_1_Tick;
        timer_2.Tick += timer_2_Tick;
        timer_3.Tick += timer_3_Tick;
    }

    private void method_0(Font font_2)
    {
        Font_0 = font_2;
        SizeF sizeF = smethod_1(Font_0, 'M');
        SizeF sizeF2 = smethod_1(Font_0, '.');
        if (sizeF != sizeF2)
        {
            Font_0 = new Font("Courier New", Font_0.SizeInPoints, FontStyle.Regular, GraphicsUnit.Point);
        }
        SizeF sizeF3 = smethod_1(Font_0, 'M');
        CharWidth = (int)Math.Round(sizeF3.Width * 1f) - 1;
        Int32_1 = int_12 + (int)Math.Round(sizeF3.Height * 1f) - 1;
        method_12(bool_37: false, bool_19);
        method_4();
    }

    public void method_1()
    {
        GClass76_0?.Clear();
    }

    public GClass77 vmethod_0(GClass84 gclass84_9, Control control_0, bool bool_37, bool bool_38, bool bool_39)
    {
        GClass77 gClass = new(gclass84_9, control_0, bool_38, bool_39);
        GClass76_0.Add(gClass);
        if (bool_37)
        {
            gClass.vmethod_0();
        }
        return gClass;
    }

    public GClass77 method_2(GClass84 gclass84_9, Control control_0)
    {
        return vmethod_0(gclass84_9, control_0, bool_37: true, bool_38: true, bool_39: true);
    }

    public GClass77 vmethod_1(GClass84 gclass84_9, string string_3, bool bool_37, bool bool_38, bool bool_39)
    {
        GClass77 gClass = new(gclass84_9, string_3, bool_38, bool_39);
        GClass76_0.Add(gClass);
        if (bool_37)
        {
            gClass.vmethod_0();
        }
        return gClass;
    }

    public GClass77 method_3(GClass84 gclass84_9, string string_3)
    {
        return vmethod_1(gclass84_9, string_3, bool_37: true, bool_38: true, bool_39: true);
    }

    public void vmethod_2(GClass77 gclass77_0)
    {
        eventHandler_1?.Invoke(this, new GEventArgs10(gclass77_0));
    }

    private void timer_2_Tick(object sender, EventArgs e)
    {
        timer_2.Stop();
        vmethod_3();
    }

    protected void vmethod_3()
    {
        if (ToolTip == null || eventHandler_0 == null)
        {
            return;
        }
        GStruct10 gStruct = method_83(point_0);
        Point point = method_94(gStruct);
        if (Math.Abs(point.X - point_0.X) <= CharWidth * 2 && Math.Abs(point.Y - point_0.Y) <= Int32_1 * 2)
        {
            string string_ = new GClass84(this, gStruct, gStruct).method_43("[a-zA-Z]").vmethod_2();
            GEventArgs9 gEventArgs = new(gStruct, string_);
            eventHandler_0(this, gEventArgs);
            if (gEventArgs.ToolTipText != null)
            {
                ToolTip.ToolTipTitle = gEventArgs.ToolTipTitle;
                ToolTip.ToolTipIcon = gEventArgs.ToolTipIcon;
                ToolTip.Show(gEventArgs.ToolTipText, this, new Point(point_0.X, point_0.Y + Int32_1));
            }
        }
    }

    public void vmethod_4()
    {
        bool_12 = true;
        bool_15 = true;
        method_20(timer_0);
        eventHandler_7?.Invoke(this, new EventArgs());
    }

    public void method_4()
    {
        if (base.InvokeRequired)
        {
            BeginInvoke(new System.Windows.Forms.MethodInvoker(method_4));
        }
        else
        {
            Invalidate();
        }
    }

    protected void vmethod_5()
    {
        base.VerticalScroll.SmallChange = int_9;
        base.VerticalScroll.LargeChange = 10 * int_9;
        base.HorizontalScroll.SmallChange = CharWidth;
    }

    public List<GClass85> method_5(GStruct10 gstruct10_0)
    {
        List<GClass85> list = [];
        if (gstruct10_0.int_1 < Int32_9 && gstruct10_0.int_0 < this[gstruct10_0.int_1].Count)
        {
            ushort styleIndex_ = (ushort)this[gstruct10_0].styleIndex_0;
            for (int i = 0; i < 16; i++)
            {
                if ((styleIndex_ & (1 << i)) != 0)
                {
                    list.Add(GClass85_0[i]);
                }
            }
        }
        return list;
    }

    protected GClass97 vmethod_6()
    {
        return new GClass97(this);
    }

    private void method_6()
    {
        GClass97_0.FastColoredTextBox_0 = this;
    }

    protected void vmethod_7(GClass97 gclass97_1)
    {
        if (gclass97_0 != null)
        {
            gclass97_0.Event_0 -= method_15;
            gclass97_0.Event_1 -= method_14;
            gclass97_0.Event_2 -= method_13;
            gclass97_0.Event_3 -= method_9;
            gclass97_0.Event_4 -= method_7;
            gclass97_0.Event_5 -= method_8;
            gclass97_0.Dispose();
        }
        list_0.Clear();
        method_1();
        GClass56_0?.Clear();
        gclass97_0 = gclass97_1;
        if (gclass97_1 != null)
        {
            gclass97_1.Event_0 += method_15;
            gclass97_1.Event_1 += method_14;
            gclass97_1.Event_2 += method_13;
            gclass97_1.Event_3 += method_9;
            gclass97_1.Event_4 += method_7;
            gclass97_1.Event_5 += method_8;
            while (list_0.Count < gclass97_1.Count)
            {
                list_0.Add(new GStruct9(-1));
            }
        }
        bool_4 = false;
        bool_10 = true;
    }

    private void method_7(object sender, GClass97.GEventArgs14 e)
    {
        method_45(e.int_0, e.int_1);
    }

    private void method_8(object sender, GEventArgs6 e)
    {
        if (GClass97_0.FastColoredTextBox_0 == this)
        {
            string string_ = e.InsertingText;
            vmethod_52(ref string_);
            e.InsertingText = string_;
        }
    }

    private void method_9(object sender, GClass97.GEventArgs14 e)
    {
        if (e.int_0 == e.int_1 && !Boolean_11 && gclass97_0.Count > 100000)
        {
            method_42(e.int_0);
        }
        else
        {
            method_12(bool_37: false, Boolean_11);
        }
    }

    public void method_10()
    {
        method_11(bool_37: false);
    }

    public void method_11(bool bool_37)
    {
        method_12(bool_37, bool_38: false);
    }

    public void method_12(bool bool_37, bool bool_38)
    {
        bool_10 = true;
        if (bool_38)
        {
            point_1 = new Point(0, Int32_9 - 1);
            bool_11 = true;
        }
        if (bool_37)
        {
            method_40();
        }
    }

    private void method_13(object sender, GClass97.GEventArgs14 e)
    {
        if (e.int_0 == e.int_1 && !Boolean_11)
        {
            method_42(e.int_0);
        }
        else
        {
            bool_10 = true;
        }
        method_4();
        if (GClass97_0.FastColoredTextBox_0 == this)
        {
            vmethod_55(e.int_0, e.int_1);
        }
    }

    private void method_14(object sender, GEventArgs4 e)
    {
        list_0.RemoveRange(e.Index, e.Count);
        method_122(e.Index, e.Count, e.RemovedLineUniqueIds);
    }

    private void method_15(object sender, GEventArgs3 e)
    {
        GEnum10 genum10_ = GEnum10.const_0;
        if (e.Index >= 0 && e.Index < list_0.Count && list_0[e.Index].genum10_0 == GEnum10.const_2)
        {
            genum10_ = GEnum10.const_2;
        }
        if (e.Count > 100000)
        {
            list_0.Capacity = list_0.Count + e.Count + 1000;
        }
        GStruct9[] array = new GStruct9[e.Count];
        for (int i = 0; i < e.Count; i++)
        {
            array[i].int_0 = -1;
            array[i].genum10_0 = genum10_;
        }
        list_0.InsertRange(e.Index, array);
        if (e.Count > 1000000)
        {
            GC.Collect();
        }
        method_121(e.Index, e.Count);
    }

    public bool method_16()
    {
        DateTime dateTime = DateTime.Now;
        int num = -1;
        for (int i = 0; i < Int32_9; i++)
        {
            if (gclass97_0.vmethod_3(i) && gclass97_0[i].LastVisit > dateTime_0 && gclass97_0[i].LastVisit < dateTime)
            {
                dateTime = gclass97_0[i].LastVisit;
                num = i;
            }
        }
        if (num >= 0)
        {
            method_18(num);
            return true;
        }
        return false;
    }

    public bool method_17()
    {
        DateTime dateTime = default;
        int num = -1;
        for (int i = 0; i < Int32_9; i++)
        {
            if (gclass97_0.vmethod_3(i) && gclass97_0[i].LastVisit < dateTime_0 && gclass97_0[i].LastVisit > dateTime)
            {
                dateTime = gclass97_0[i].LastVisit;
                num = i;
            }
        }
        if (num >= 0)
        {
            method_18(num);
            return true;
        }
        return false;
    }

    public void method_18(int int_27)
    {
        if (int_27 < Int32_9)
        {
            dateTime_0 = gclass97_0[int_27].LastVisit;
            GClass84_5.GStruct10_0 = new GStruct10(0, int_27);
            method_50();
        }
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        intptr_0 = ImmGetContext(base.Handle);
    }

    private void timer_1_Tick(object sender, EventArgs e)
    {
        timer_1.Enabled = false;
        if (bool_14)
        {
            bool_14 = false;
            if (gclass84_1 != null)
            {
                gclass84_1 = GClass84_6.vmethod_1(gclass84_1);
                gclass84_1.method_42();
                vmethod_8(gclass84_1);
                gclass84_1 = null;
            }
        }
    }

    public void method_19(GClass99 gclass99_0)
    {
        list_1.Add(gclass99_0);
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
        timer_0.Enabled = false;
        if (bool_13)
        {
            bool_13 = false;
            vmethod_9();
        }
        if (bool_15)
        {
            bool_15 = false;
            vmethod_10();
        }
    }

    public void vmethod_8(GClass84 gclass84_9)
    {
        eventHandler_8?.Invoke(this, new GEventArgs5(gclass84_9));
    }

    public void vmethod_9()
    {
        method_42(GClass84_5.GStruct10_0.int_1);
        method_109();
        if (LeftBracket != 0 && RightBracket != 0)
        {
            method_110(LeftBracket, RightBracket, ref gclass84_2, ref gclass84_4);
        }
        if (LeftBracket2 != 0 && RightBracket2 != 0)
        {
            method_110(LeftBracket2, RightBracket2, ref gclass84_3, ref gclass84_5);
        }
        if (GClass84_5.vmethod_0() && GClass84_5.GStruct10_0.int_1 < Int32_9 && dateTime_0 != gclass97_0[GClass84_5.GStruct10_0.int_1].LastVisit)
        {
            gclass97_0[GClass84_5.GStruct10_0.int_1].LastVisit = DateTime.Now;
            dateTime_0 = gclass97_0[GClass84_5.GStruct10_0.int_1].LastVisit;
        }
        eventHandler_9?.Invoke(this, new EventArgs());
    }

    public void vmethod_10()
    {
        eventHandler_10?.Invoke(this, new EventArgs());
    }

    private void method_20(System.Windows.Forms.Timer timer_4)
    {
        if (base.InvokeRequired)
        {
            BeginInvoke((System.Windows.Forms.MethodInvoker)delegate
            {
                method_20(timer_4);
            });
            return;
        }
        timer_4.Stop();
        if (base.IsHandleCreated)
        {
            timer_4.Start();
        }
        else
        {
            dictionary_2[timer_4] = timer_4;
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        foreach (System.Windows.Forms.Timer item in new List<System.Windows.Forms.Timer>(dictionary_2.Keys))
        {
            method_20(item);
        }
        dictionary_2.Clear();
        vmethod_29();
    }

    public int method_21(GClass85 gclass85_0)
    {
        if (gclass85_0 == null)
        {
            return -1;
        }
        int num = method_32(gclass85_0);
        if (num >= 0)
        {
            return num;
        }
        num = method_22();
        GClass85_0[num] = gclass85_0;
        return num;
    }

    public int method_22()
    {
        int num = GClass85_0.Length - 1;
        while (num >= 0 && GClass85_0[num] == null)
        {
            num--;
        }
        num++;
        if (num >= GClass85_0.Length)
        {
            throw new Exception("Maximum count of Styles is exceeded.");
        }
        return num;
    }

    public void vmethod_11()
    {
        vmethod_12(null);
    }

    public void vmethod_12(string string_3)
    {
        findForm ??= new FindForm(this);
        if (string_3 != null)
        {
            findForm.tbFind.Text = string_3;
        }
        else if (!GClass84_5.vmethod_0() && GClass84_5.GStruct10_0.int_1 == GClass84_5.GStruct10_1.int_1)
        {
            findForm.tbFind.Text = GClass84_5.vmethod_2();
        }
        findForm.tbFind.SelectAll();
        findForm.Show();
        findForm.Focus();
    }

    public void vmethod_13()
    {
        vmethod_14(null);
    }

    public void vmethod_14(string string_3)
    {
        if (!ReadOnly)
        {
            replaceForm ??= new ReplaceForm(this);
            if (string_3 != null)
            {
                replaceForm.tbFind.Text = string_3;
            }
            else if (!GClass84_5.vmethod_0() && GClass84_5.GStruct10_0.int_1 == GClass84_5.GStruct10_1.int_1)
            {
                replaceForm.tbFind.Text = GClass84_5.vmethod_2();
            }
            replaceForm.tbFind.SelectAll();
            replaceForm.Show();
            replaceForm.Focus();
        }
    }

    public int method_23(int int_27)
    {
        if (int_27 < 0 || int_27 >= gclass97_0.Count)
        {
            throw new ArgumentOutOfRangeException("Line index out of range");
        }
        return gclass97_0[int_27].Count;
    }

    public GClass84 method_24(int int_27)
    {
        if (int_27 < 0 || int_27 >= gclass97_0.Count)
        {
            throw new ArgumentOutOfRangeException("Line index out of range");
        }
        return new GClass84(this)
        {
            GStruct10_0 = new GStruct10(0, int_27),
            GStruct10_1 = new GStruct10(gclass97_0[int_27].Count, int_27)
        };
    }

    public void vmethod_15()
    {
        if (GClass84_5.vmethod_0())
        {
            GClass84_5.method_42();
        }
        if (!GClass84_5.vmethod_0())
        {
            DataObject dataObject_0 = new();
            vmethod_16(dataObject_0);
            Thread thread = new((ThreadStart)delegate
            {
                method_25(dataObject_0);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }

    protected void vmethod_16(DataObject dataObject_0)
    {
        GClass72 gClass = new()
        {
            UseBr = false,
            UseNbsp = false,
            UseStyleTag = true
        };
        string string_ = "<pre>" + gClass.method_1(GClass84_5.method_6()) + "</pre>";
        dataObject_0.SetData(DataFormats.UnicodeText, autoConvert: true, GClass84_5.vmethod_2());
        dataObject_0.SetData(DataFormats.Html, smethod_0(string_));
        dataObject_0.SetData(DataFormats.Rtf, new GClass73().method_1(GClass84_5.method_6()));
    }

    [DllImport("user32.dll")]
    private static extern IntPtr GetOpenClipboardWindow();

    [DllImport("user32.dll")]
    private static extern IntPtr CloseClipboard();

    protected void method_25(DataObject dataObject_0)
    {
        try
        {
            CloseClipboard();
            Clipboard.SetDataObject(dataObject_0, copy: true, 5, 100);
        }
        catch (ExternalException)
        {
        }
    }

    public static MemoryStream smethod_0(string string_3)
    {
        Encoding uTF = Encoding.UTF8;
        string format = "Version:0.9\r\nStartHTML:{0:000000}\r\nEndHTML:{1:000000}\r\nStartFragment:{2:000000}\r\nEndFragment:{3:000000}\r\n";
        string text = "<html>\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=" + uTF.WebName + "\">\r\n<title>HTML clipboard</title>\r\n</head>\r\n<body>\r\n<!--StartFragment-->";
        string text2 = "<!--EndFragment-->\r\n</body>\r\n</html>\r\n";
        string s = string.Format(format, 0, 0, 0, 0);
        int byteCount = uTF.GetByteCount(s);
        int byteCount2 = uTF.GetByteCount(text);
        int byteCount3 = uTF.GetByteCount(string_3);
        int byteCount4 = uTF.GetByteCount(text2);
        string s2 = string.Format(format, byteCount, byteCount + byteCount2 + byteCount3 + byteCount4, byteCount + byteCount2, byteCount + byteCount2 + byteCount3) + text + string_3 + text2;
        return new MemoryStream(uTF.GetBytes(s2));
    }

    public void vmethod_17()
    {
        if (!GClass84_5.vmethod_0())
        {
            vmethod_15();
            vmethod_28();
            return;
        }
        if (Int32_9 == 1)
        {
            GClass84_5.method_2();
            vmethod_15();
            vmethod_28();
            return;
        }
        DataObject dataObject_0 = new();
        vmethod_16(dataObject_0);
        Thread thread = new((ThreadStart)delegate
        {
            method_25(dataObject_0);
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
        if (GClass84_5.GStruct10_0.int_1 >= 0 && GClass84_5.GStruct10_0.int_1 < Int32_9)
        {
            int num = GClass84_5.GStruct10_0.int_1;
            method_133([num]);
            GClass84_5.GStruct10_0 = new GStruct10(0, Math.Max(0, Math.Min(num, Int32_9 - 1)));
        }
    }

    public void vmethod_18()
    {
        string string_0 = null;
        Thread thread = new((ThreadStart)delegate
        {
            if (Clipboard.ContainsText())
            {
                string_0 = Clipboard.GetText();
            }
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
        if (eventHandler_4 != null)
        {
            GEventArgs6 gEventArgs = new()
            {
                Cancel = false,
                InsertingText = string_0
            };
            eventHandler_4(this, gEventArgs);
            if (gEventArgs.Cancel)
            {
                string_0 = string.Empty;
            }
            else
            {
                string_0 = gEventArgs.InsertingText;
            }
        }
        if (!string.IsNullOrEmpty(string_0))
        {
            vmethod_20(string_0);
        }
    }

    public void method_26()
    {
        GClass84_5.method_2();
    }

    public void method_27()
    {
        if (gclass97_0.Count > 0)
        {
            GClass84_5.GStruct10_0 = new GStruct10(gclass97_0[gclass97_0.Count - 1].Count, gclass97_0.Count - 1);
        }
        else
        {
            GClass84_5.GStruct10_0 = new GStruct10(0, 0);
        }
        method_48();
    }

    public void method_28()
    {
        GClass84_5.GStruct10_0 = new GStruct10(0, 0);
        method_48();
    }

    public void vmethod_19()
    {
        GClass84_5.method_38();
        try
        {
            GClass84_5.method_2();
            vmethod_28();
            gclass97_0.Manager.method_5();
            method_4();
        }
        finally
        {
            GClass84_5.method_39();
        }
    }

    public void method_29()
    {
        for (int i = 0; i < GClass85_0.Length; i++)
        {
            GClass85_0[i] = null;
        }
    }

    public void method_30(StyleIndex styleIndex_0)
    {
        foreach (GClass80 item in gclass97_0)
        {
            item.method_0(styleIndex_0);
        }
        for (int i = 0; i < list_0.Count; i++)
        {
            method_128(i, GEnum10.const_0);
        }
        method_4();
    }

    public void method_31()
    {
        gclass97_0.Manager.method_5();
    }

    public void vmethod_20(string string_3)
    {
        vmethod_21(string_3, bool_37: true);
    }

    public void vmethod_21(string string_3, bool bool_37)
    {
        if (string_3 == null)
        {
            return;
        }
        if (string_3 == "\r")
        {
            string_3 = "\n";
        }
        gclass97_0.Manager.method_4();
        try
        {
            if (!GClass84_5.vmethod_0())
            {
                gclass97_0.Manager.vmethod_0(new GClass65(GClass97_0));
            }
            if (GClass97_0.Count > 0 && GClass84_5.vmethod_0() && GClass84_5.GStruct10_0.int_0 > method_23(GClass84_5.GStruct10_0.int_1) && VirtualSpace)
            {
                method_38();
            }
            gclass97_0.Manager.vmethod_0(new GClass63(GClass97_0, string_3));
            if (int_17 <= 0 && bool_37)
            {
                method_48();
            }
        }
        finally
        {
            gclass97_0.Manager.method_3();
        }
        method_4();
    }

    public GClass84 vmethod_22(string string_3, GClass85 gclass85_0)
    {
        return vmethod_23(string_3, gclass85_0, bool_37: true);
    }

    public GClass84 vmethod_23(string string_3, GClass85 gclass85_0, bool bool_37)
    {
        if (string_3 == null)
        {
            return null;
        }
        GStruct10 gstruct10_ = (GStruct10.smethod_4(GClass84_5.GStruct10_0, GClass84_5.GStruct10_1) ? GClass84_5.GStruct10_1 : GClass84_5.GStruct10_0);
        vmethod_21(string_3, bool_37);
        GClass84 gClass = new GClass84(this, gstruct10_, GClass84_5.GStruct10_0)
        {
            Boolean_0 = GClass84_5.Boolean_0
        }.vmethod_1(GClass84_6);
        gClass.method_18(gclass85_0);
        return gClass;
    }

    public GClass84 vmethod_24(GClass84 gclass84_9, string string_3, GClass85 gclass85_0)
    {
        if (string_3 == null)
        {
            return null;
        }
        int num = method_91(GClass84_5.GStruct10_0);
        int num2 = method_91(GClass84_5.GStruct10_1);
        int length = gclass84_9.vmethod_2().Length;
        int num3 = method_91(gclass84_9.GStruct10_0);
        GClass84_5.method_38();
        GClass84_5 = gclass84_9;
        GClass84 gClass = vmethod_22(string_3, gclass85_0);
        length = gClass.vmethod_2().Length - length;
        GClass84_5.GStruct10_0 = method_92(num + ((num >= num3) ? length : 0));
        GClass84_5.GStruct10_1 = method_92(num2 + ((num2 >= num3) ? length : 0));
        GClass84_5.method_39();
        return gClass;
    }

    public void vmethod_25(string string_3)
    {
        vmethod_26(string_3, null);
    }

    public void vmethod_26(string string_3, GClass85 gclass85_0)
    {
        if (string_3 == null)
        {
            return;
        }
        GClass84_5.Boolean_0 = false;
        GStruct10 gStruct10_ = GClass84_5.GStruct10_0;
        GStruct10 gStruct10_2 = GClass84_5.GStruct10_1;
        GClass84_5.method_38();
        gclass97_0.Manager.method_4();
        try
        {
            if (gclass97_0.Count > 0)
            {
                GClass84_5.GStruct10_0 = new GStruct10(gclass97_0[gclass97_0.Count - 1].Count, gclass97_0.Count - 1);
            }
            else
            {
                GClass84_5.GStruct10_0 = new GStruct10(0, 0);
            }
            GStruct10 gStruct10_3 = GClass84_5.GStruct10_0;
            gclass97_0.Manager.vmethod_0(new GClass63(GClass97_0, string_3));
            if (gclass85_0 != null)
            {
                new GClass84(this, gStruct10_3, GClass84_5.GStruct10_0).method_18(gclass85_0);
            }
        }
        finally
        {
            gclass97_0.Manager.method_3();
            GClass84_5.GStruct10_0 = gStruct10_;
            GClass84_5.GStruct10_1 = gStruct10_2;
            GClass84_5.method_39();
        }
        method_4();
    }

    public int method_32(GClass85 gclass85_0)
    {
        return Array.IndexOf(GClass85_0, gclass85_0);
    }

    public StyleIndex method_33(GClass85[] gclass85_0)
    {
        StyleIndex styleIndex = StyleIndex.None;
        foreach (GClass85 gclass85_1 in gclass85_0)
        {
            int num = method_32(gclass85_1);
            if (num >= 0)
            {
                styleIndex |= GClass84.smethod_0(num);
            }
        }
        return styleIndex;
    }

    internal int method_34(GClass85 gclass85_0)
    {
        int num = method_32(gclass85_0);
        if (num < 0)
        {
            num = method_21(gclass85_0);
        }
        return num;
    }

    public static SizeF smethod_1(Font font_2, char char_5)
    {
        Size size = TextRenderer.MeasureText("<" + char_5 + ">", font_2);
        Size size2 = TextRenderer.MeasureText("<>", font_2);
        return new SizeF(size.Width - size2.Width + 1, font_2.Height);
    }

    [DllImport("Imm32.dll")]
    public static extern IntPtr ImmGetContext(IntPtr intptr_1);

    [DllImport("Imm32.dll")]
    public static extern IntPtr ImmAssociateContext(IntPtr intptr_1, IntPtr intptr_2);

    protected override void WndProc(ref Message m)
    {
        if ((m.Msg == 276 || m.Msg == 277) && m.WParam.ToInt32() != 8)
        {
            method_4();
        }
        base.WndProc(ref m);
        if (Boolean_13 && m.Msg == 641 && m.WParam.ToInt32() == 1)
        {
            ImmAssociateContext(base.Handle, intptr_0);
        }
    }

    private void method_35()
    {
        if (Boolean_9 || GClass76_0.Count <= 0)
        {
            return;
        }
        SuspendLayout();
        foreach (Control control in base.Controls)
        {
            list_2.Add(control);
        }
        base.Controls.Clear();
    }

    private void method_36()
    {
        if (Boolean_9 || GClass76_0.Count <= 0)
        {
            return;
        }
        foreach (Control item in list_2)
        {
            base.Controls.Add(item);
        }
        list_2.Clear();
        ResumeLayout(performLayout: false);
        if (!Focused)
        {
            Focus();
        }
    }

    public void method_37(ScrollEventArgs scrollEventArgs_0, bool bool_37)
    {
        method_35();
        if (scrollEventArgs_0.ScrollOrientation == ScrollOrientation.VerticalScroll)
        {
            int num = scrollEventArgs_0.NewValue;
            if (bool_37)
            {
                num = (int)(Math.Ceiling(1.0 * (double)num / (double)Int32_1) * (double)Int32_1);
            }
            base.VerticalScroll.Value = Math.Max(base.VerticalScroll.Minimum, Math.Min(base.VerticalScroll.Maximum, num));
        }
        if (scrollEventArgs_0.ScrollOrientation == ScrollOrientation.HorizontalScroll)
        {
            base.HorizontalScroll.Value = Math.Max(base.HorizontalScroll.Minimum, Math.Min(base.HorizontalScroll.Maximum, scrollEventArgs_0.NewValue));
        }
        method_47();
        method_36();
        method_4();
        base.OnScroll(scrollEventArgs_0);
        vmethod_4();
    }

    protected override void OnScroll(ScrollEventArgs se)
    {
        method_37(se, bool_37: true);
    }

    protected void vmethod_27(char char_5)
    {
        gclass97_0.Manager.method_4();
        try
        {
            if (!GClass84_5.vmethod_0())
            {
                gclass97_0.Manager.vmethod_0(new GClass65(GClass97_0));
            }
            if (GClass84_5.vmethod_0() && GClass84_5.GStruct10_0.int_0 > method_23(GClass84_5.GStruct10_0.int_1) && VirtualSpace)
            {
                method_38();
            }
            gclass97_0.Manager.vmethod_0(new GClass62(GClass97_0, char_5));
        }
        finally
        {
            gclass97_0.Manager.method_3();
        }
        method_4();
    }

    private void method_38()
    {
        int num = method_23(GClass84_5.GStruct10_0.int_1);
        int count = GClass84_5.GStruct10_0.int_0 - num;
        GClass84_5.method_38();
        try
        {
            GClass84_5.GStruct10_0 = new GStruct10(num, GClass84_5.GStruct10_0.int_1);
            gclass97_0.Manager.vmethod_0(new GClass63(GClass97_0, new string(' ', count)));
        }
        finally
        {
            GClass84_5.method_39();
        }
    }

    public void vmethod_28()
    {
        if (!GClass84_5.vmethod_0())
        {
            gclass97_0.Manager.vmethod_0(new GClass65(GClass97_0));
            method_4();
        }
    }

    public void method_39()
    {
        GClass84_5.method_42();
        gclass97_0.Manager.vmethod_0(new GClass65(GClass97_0));
        if (GClass84_5.GStruct10_0.int_1 != 0 || GClass84_5.vmethod_3())
        {
            if (GClass84_5.GStruct10_0.int_1 > 0)
            {
                gclass97_0.Manager.vmethod_0(new GClass62(GClass97_0, '\b'));
            }
            method_4();
        }
    }

    private void method_40()
    {
        if (!bool_10)
        {
            return;
        }
        bool_10 = false;
        LeftIndent = Int32_3;
        long num = Int32_9 + uint_0 - 1L;
        int num2 = 2 + ((num > 0L) ? ((int)Math.Log10(num)) : 0);
        if (Int32_12 + 1 > num2)
        {
            num2 = Int32_12 + 1;
        }
        if (base.Created)
        {
            if (Boolean_2)
            {
                LeftIndent += num2 * CharWidth + 8 + 1;
            }
            if (bool_11)
            {
                method_45(point_1.X, point_1.Y);
                bool_11 = false;
            }
        }
        else
        {
            bool_10 = true;
        }
        int_8 = 0;
        int_14 = method_43();
        method_41(out var int_, ref int_14);
        Size_0 = new Size(int_, int_8 + Paddings.Top + Paddings.Bottom);
        method_47();
    }

    private void method_41(out int int_27, ref int int_28)
    {
        int_27 = LeftIndent + int_28 * CharWidth + 2 + Paddings.Left + Paddings.Right;
        if (bool_19)
        {
            switch (GEnum5_0)
            {
                case GEnum5.const_0:
                case GEnum5.const_2:
                    int_28 = Math.Min(int_28, (base.ClientSize.Width - LeftIndent - Paddings.Left - Paddings.Right) / CharWidth);
                    int_27 = 0;
                    break;
                case GEnum5.const_1:
                case GEnum5.const_3:
                    int_28 = Math.Min(int_28, Int32_4);
                    int_27 = LeftIndent + Int32_4 * CharWidth + 2 + Paddings.Left + Paddings.Right;
                    break;
            }
        }
    }

    private void method_42(int int_27)
    {
        if (int_27 < gclass97_0.Count)
        {
            int int_28 = gclass97_0[int_27].Count;
            if (int_14 < int_28 && !Boolean_11)
            {
                int_14 = int_28;
            }
            method_41(out var int_29, ref int_28);
            if (Size_0.Width < int_29)
            {
                Size_0 = new Size(int_29, Size_0.Height);
            }
        }
    }

    private int method_43()
    {
        int num = 0;
        GClass97 gClass = gclass97_0;
        int count = gClass.Count;
        int int32_ = Int32_1;
        int num2 = (int_8 = Paddings.Top);
        for (int i = 0; i < count; i++)
        {
            int num3 = gClass.vmethod_19(i);
            GStruct9 value = list_0[i];
            if (num3 > num && value.genum10_0 == GEnum10.const_0)
            {
                num = num3;
            }
            value.int_0 = int_8;
            int_8 += value.Int32_0 * int32_ + value.int_1;
            list_0[i] = value;
        }
        int_8 -= num2;
        return num;
    }

    private int method_44()
    {
        if (bool_19)
        {
            switch (genum5_0)
            {
                case GEnum5.const_0:
                case GEnum5.const_2:
                    return base.ClientSize.Width;
                case GEnum5.const_1:
                case GEnum5.const_3:
                    return LeftIndent + Int32_4 * CharWidth + 2 + Paddings.Left + Paddings.Right;
            }
        }
        return int.MaxValue;
    }

    private void method_45(int int_27, int int_28)
    {
        int num = 0;
        bool bool_ = false;
        int_28 = Math.Min(Int32_9 - 1, int_28);
        switch (GEnum5_0)
        {
            case GEnum5.const_0:
                num = (base.ClientSize.Width - LeftIndent - Paddings.Left - Paddings.Right) / CharWidth;
                break;
            case GEnum5.const_1:
                num = Int32_4;
                break;
            case GEnum5.const_2:
                num = (base.ClientSize.Width - LeftIndent - Paddings.Left - Paddings.Right) / CharWidth;
                bool_ = true;
                break;
            case GEnum5.const_3:
                num = Int32_4;
                bool_ = true;
                break;
        }
        for (int i = int_27; i <= int_28; i++)
        {
            if (!gclass97_0.vmethod_3(i))
            {
                continue;
            }
            if (!bool_19)
            {
                list_0[i].List_0.Clear();
                continue;
            }
            GStruct9 value = list_0[i];
            value.int_2 = (WordWrapAutoIndent ? (gclass97_0[i].Int32_0 + WordWrapIndent) : WordWrapIndent);
            if (GEnum5_0 == GEnum5.const_4)
            {
                eventHandler_21?.Invoke(this, new GEventArgs7(value.List_0, Boolean_13, gclass97_0[i]));
            }
            else
            {
                smethod_2(value.List_0, num, num - value.int_2, Boolean_13, bool_, gclass97_0[i]);
            }
            list_0[i] = value;
        }
        bool_10 = true;
    }

    public static void smethod_2(List<int> list_3, int int_27, int int_28, bool bool_37, bool bool_38, GClass80 gclass80_0)
    {
        if (int_28 < 1)
        {
            int_28 = 1;
        }
        if (int_27 < 1)
        {
            int_27 = 1;
        }
        int num = 0;
        int num2 = 0;
        list_3.Clear();
        for (int i = 0; i < gclass80_0.Count - 1; i++)
        {
            char c = gclass80_0[i].char_0;
            if (bool_38)
            {
                num2 = i + 1;
            }
            else if (bool_37 && smethod_3(c))
            {
                num2 = i;
            }
            else if (!char.IsLetterOrDigit(c) && c != '_' && c != '\'' && c != '\u00a0' && ((c != '.' && c != ',') || !char.IsDigit(gclass80_0[i + 1].char_0)))
            {
                num2 = Math.Min(i + 1, gclass80_0.Count - 1);
            }
            num++;
            if (num == int_27)
            {
                if (num2 == 0 || (list_3.Count > 0 && num2 == list_3[list_3.Count - 1]))
                {
                    num2 = i + 1;
                }
                list_3.Add(num2);
                num = 1 + i - num2;
                int_27 = int_28;
            }
        }
    }

    public static bool smethod_3(char char_5)
    {
        int num = Convert.ToInt32(char_5);
        if ((num >= 13056 && num <= 13311) || (num >= 65072 && num <= 65103) || (num >= 63744 && num <= 64255) || (num >= 11904 && num <= 12031) || (num >= 12736 && num <= 12783) || (num >= 19968 && num <= 40959) || (num >= 13312 && num <= 19903) || (num >= 12800 && num <= 13055) || (num >= 9312 && num <= 9471) || (num >= 12352 && num <= 12447) || (num >= 12032 && num <= 12255) || (num >= 12704 && num <= 12735) || (num >= 19904 && num <= 19967) || (num >= 12544 && num <= 12591) || (num >= 12448 && num <= 12543) || (num >= 12784 && num <= 12799) || (num >= 12272 && num <= 12287) || (num >= 4352 && num <= 4607) || (num >= 43360 && num <= 43391) || (num >= 55216 && num <= 55295) || (num >= 12592 && num <= 12687))
        {
            return true;
        }
        if (num >= 44032)
        {
            return num <= 55215;
        }
        return false;
    }

    protected override void OnClientSizeChanged(EventArgs e)
    {
        base.OnClientSizeChanged(e);
        if (Boolean_11)
        {
            method_12(bool_37: false, bool_38: true);
            method_4();
        }
        vmethod_4();
        method_47();
    }

    internal void method_46(Rectangle rectangle_1)
    {
        method_35();
        int value = base.VerticalScroll.Value;
        int num = base.VerticalScroll.Value;
        int num2 = base.HorizontalScroll.Value;
        if (rectangle_1.Bottom > base.ClientRectangle.Height)
        {
            num += rectangle_1.Bottom - base.ClientRectangle.Height;
        }
        else if (rectangle_1.Top < 0)
        {
            num += rectangle_1.Top;
        }
        if (rectangle_1.Right > base.ClientRectangle.Width)
        {
            num2 += rectangle_1.Right - base.ClientRectangle.Width;
        }
        else if (rectangle_1.Left < LeftIndent)
        {
            num2 += rectangle_1.Left - LeftIndent;
        }
        if (!Boolean_10)
        {
            num = 0;
        }
        num = Math.Max(base.VerticalScroll.Minimum, num);
        num2 = Math.Max(base.HorizontalScroll.Minimum, num2);
        try
        {
            if (base.VerticalScroll.Visible || !Boolean_9)
            {
                base.VerticalScroll.Value = Math.Min(num, base.VerticalScroll.Maximum);
            }
            if (base.HorizontalScroll.Visible || !Boolean_9)
            {
                base.HorizontalScroll.Value = Math.Min(num2, base.HorizontalScroll.Maximum);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
        }
        method_47();
        method_36();
        if (value != base.VerticalScroll.Value)
        {
            vmethod_4();
        }
    }

    public void method_47()
    {
        if (Boolean_9)
        {
            base.AutoScrollMinSize -= new Size(1, 0);
            base.AutoScrollMinSize += new Size(1, 0);
        }
        else
        {
            PerformLayout();
        }
        if (base.IsHandleCreated)
        {
            BeginInvoke(new System.Windows.Forms.MethodInvoker(vmethod_29));
        }
    }

    protected void vmethod_29()
    {
        eventHandler_20?.Invoke(this, EventArgs.Empty);
    }

    public void method_48()
    {
        method_4();
        method_40();
        Point location = method_94(GClass84_5.GStruct10_0);
        location.Offset(-CharWidth, 0);
        method_46(new Rectangle(location, new Size(2 * CharWidth, 2 * Int32_1)));
    }

    public void method_49()
    {
        method_4();
        base.HorizontalScroll.Value = 0;
        Size_0 -= new Size(1, 0);
        Size_0 += new Size(1, 0);
    }

    public void method_50()
    {
        if (list_0[GClass84_5.GStruct10_1.int_1].genum10_0 != GEnum10.const_0)
        {
            method_100(GClass84_5.GStruct10_1.int_1);
        }
        if (list_0[GClass84_5.GStruct10_0.int_1].genum10_0 != GEnum10.const_0)
        {
            method_100(GClass84_5.GStruct10_0.int_1);
        }
        method_40();
        method_46(new Rectangle(method_94(new GStruct10(0, GClass84_5.GStruct10_1.int_1)), new Size(2 * CharWidth, 2 * Int32_1)));
        Point location = method_94(GClass84_5.GStruct10_0);
        Point point = method_94(GClass84_5.GStruct10_1);
        location.Offset(-CharWidth, -base.ClientSize.Height / 2);
        method_46(new Rectangle(location, new Size(Math.Abs(point.X - location.X), base.ClientSize.Height)));
        method_4();
    }

    public void method_51(GClass84 gclass84_9)
    {
        method_52(gclass84_9, bool_37: false);
    }

    public void method_52(GClass84 gclass84_9, bool bool_37)
    {
        gclass84_9 = gclass84_9.method_6();
        gclass84_9.method_40();
        gclass84_9.GStruct10_1 = new GStruct10(gclass84_9.GStruct10_1.int_0, Math.Min(gclass84_9.GStruct10_1.int_1, gclass84_9.GStruct10_0.int_1 + base.ClientSize.Height / Int32_1));
        if (list_0[gclass84_9.GStruct10_1.int_1].genum10_0 != GEnum10.const_0)
        {
            method_100(gclass84_9.GStruct10_1.int_1);
        }
        if (list_0[gclass84_9.GStruct10_0.int_1].genum10_0 != GEnum10.const_0)
        {
            method_100(gclass84_9.GStruct10_0.int_1);
        }
        method_40();
        int num = (1 + gclass84_9.GStruct10_1.int_1 - gclass84_9.GStruct10_0.int_1) * Int32_1;
        Point location = method_94(new GStruct10(0, gclass84_9.GStruct10_0.int_1));
        if (bool_37)
        {
            location.Offset(0, -base.ClientSize.Height / 2);
            num = base.ClientSize.Height;
        }
        method_46(new Rectangle(location, new Size(2 * CharWidth, num)));
        method_4();
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
        base.OnKeyUp(e);
        if (e.KeyCode == Keys.ShiftKey)
        {
            keys_0 &= ~Keys.Shift;
        }
        if (e.KeyCode == Keys.Alt)
        {
            keys_0 &= ~Keys.Alt;
        }
        if (e.KeyCode == Keys.ControlKey)
        {
            keys_0 &= ~Keys.Control;
        }
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (!bool_36)
        {
            base.OnKeyDown(e);
            if (Focused)
            {
                keys_0 = e.Modifiers;
            }
            bool_2 = false;
            if (e.Handled)
            {
                bool_2 = true;
            }
            else if (!vmethod_30(e.KeyData))
            {
                e.Handled = true;
                method_48();
                method_4();
            }
        }
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
        if ((keyData & Keys.Alt) > Keys.None && HotkeysMapping.ContainsKey(keyData))
        {
            vmethod_30(keyData);
            return true;
        }
        return base.ProcessDialogKey(keyData);
    }

    public bool vmethod_30(Keys keys_1)
    {
        KeyEventArgs e = new(keys_1);
        if (e.KeyCode == Keys.Tab && !AcceptsTab)
        {
            return false;
        }
        if (gclass82_0 != null && (!HotkeysMapping.ContainsKey(keys_1) || (HotkeysMapping[keys_1] != FCTBAction.MacroExecute && HotkeysMapping[keys_1] != FCTBAction.MacroRecord)))
        {
            gclass82_0.method_4(keys_1);
        }
        if (HotkeysMapping.ContainsKey(keys_1))
        {
            FCTBAction fCTBAction = HotkeysMapping[keys_1];
            method_53(fCTBAction);
            if (dictionary_3.ContainsKey(fCTBAction))
            {
                return true;
            }
            if (keys_1 == Keys.Tab || keys_1 == (Keys.Tab | Keys.Shift))
            {
                bool_2 = true;
                return true;
            }
        }
        else
        {
            if (e.KeyCode == Keys.Alt)
            {
                return true;
            }
            if ((e.Modifiers & Keys.Control) != Keys.None)
            {
                return true;
            }
            if ((e.Modifiers & Keys.Alt) != Keys.None)
            {
                if ((Control.MouseButtons & MouseButtons.Left) != MouseButtons.None)
                {
                    vmethod_50();
                }
                return true;
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                return true;
            }
        }
        return false;
    }

    private void method_53(FCTBAction fctbaction_0)
    {
        switch (fctbaction_0)
        {
            case FCTBAction.AutoIndentChars:
                if (!GClass84_5.Boolean_1)
                {
                    method_62(GClass84_5.GStruct10_0.int_1);
                }
                break;
            case FCTBAction.BookmarkLine:
                vmethod_32(GClass84_5.GStruct10_0.int_1);
                break;
            case FCTBAction.ClearHints:
                method_1();
                if (GClass82_0 != null)
                {
                    GClass82_0.Boolean_0 = false;
                }
                break;
            case FCTBAction.ClearWordLeft:
                if (method_60('\b'))
                {
                    break;
                }
                if (!GClass84_5.Boolean_1)
                {
                    if (!GClass84_5.vmethod_0())
                    {
                        vmethod_28();
                    }
                    GClass84_5.method_48(bool_1: true);
                    if (!GClass84_5.Boolean_1)
                    {
                        vmethod_28();
                    }
                }
                method_61('\b');
                break;
            case FCTBAction.ClearWordRight:
                if (method_60('ÿ'))
                {
                    break;
                }
                if (!GClass84_5.Boolean_1)
                {
                    if (!GClass84_5.vmethod_0())
                    {
                        vmethod_28();
                    }
                    GClass84_5.method_49(bool_1: true);
                    if (!GClass84_5.Boolean_1)
                    {
                        vmethod_28();
                    }
                }
                method_61('ÿ');
                break;
            case FCTBAction.CommentSelected:
                method_58();
                break;
            case FCTBAction.Copy:
                vmethod_15();
                break;
            case FCTBAction.Cut:
                if (!GClass84_5.Boolean_1)
                {
                    vmethod_17();
                }
                break;
            case FCTBAction.DeleteCharRight:
                if (GClass84_5.Boolean_1 || method_60('ÿ'))
                {
                    break;
                }
                if (!GClass84_5.vmethod_0())
                {
                    vmethod_28();
                }
                else
                {
                    if (this[GClass84_5.GStruct10_0.int_1].Int32_0 == this[GClass84_5.GStruct10_0.int_1].Count)
                    {
                        method_66();
                    }
                    if (!GClass84_5.method_54() && GClass84_5.vmethod_3())
                    {
                        int num = GClass84_5.GStruct10_0.int_1;
                        vmethod_27('\b');
                        if (num != GClass84_5.GStruct10_0.int_1 && AutoIndent && GClass84_5.GStruct10_0.int_0 > 0)
                        {
                            method_66();
                        }
                    }
                }
                if (AutoIndentChars)
                {
                    method_62(GClass84_5.GStruct10_0.int_1);
                }
                method_61('ÿ');
                break;
            case FCTBAction.FindChar:
                bool_33 = true;
                break;
            case FCTBAction.FindDialog:
                vmethod_11();
                break;
            case FCTBAction.FindNext:
                if (findForm != null && !(findForm.tbFind.Text == ""))
                {
                    findForm.vmethod_0(findForm.tbFind.Text);
                }
                else
                {
                    vmethod_11();
                }
                break;
            case FCTBAction.GoDown:
                GClass84_5.method_14(bool_1: false);
                method_49();
                break;
            case FCTBAction.GoDownWithSelection:
                GClass84_5.method_14(bool_1: true);
                method_49();
                break;
            case FCTBAction.GoDown_ColumnSelectionMode:
                vmethod_50();
                if (GClass84_5.Boolean_0)
                {
                    GClass84_5.method_60();
                }
                method_4();
                break;
            case FCTBAction.GoEnd:
                GClass84_5.method_17(bool_1: false);
                break;
            case FCTBAction.GoEndWithSelection:
                GClass84_5.method_17(bool_1: true);
                break;
            case FCTBAction.GoFirstLine:
                GClass84_5.method_50(bool_1: false);
                break;
            case FCTBAction.GoFirstLineWithSelection:
                GClass84_5.method_50(bool_1: true);
                break;
            case FCTBAction.GoHome:
                method_57(bool_37: false);
                method_49();
                break;
            case FCTBAction.GoHomeWithSelection:
                method_57(bool_37: true);
                method_49();
                break;
            case FCTBAction.GoLastLine:
                GClass84_5.method_51(bool_1: false);
                break;
            case FCTBAction.GoLastLineWithSelection:
                GClass84_5.method_51(bool_1: true);
                break;
            case FCTBAction.GoLeft:
                GClass84_5.method_10(bool_1: false);
                break;
            case FCTBAction.GoLeftWithSelection:
                GClass84_5.method_10(bool_1: true);
                break;
            case FCTBAction.GoLeft_ColumnSelectionMode:
                vmethod_50();
                if (GClass84_5.Boolean_0)
                {
                    GClass84_5.method_63();
                }
                method_4();
                break;
            case FCTBAction.GoPageDown:
                GClass84_5.method_15(bool_1: false);
                method_49();
                break;
            case FCTBAction.GoPageDownWithSelection:
                GClass84_5.method_15(bool_1: true);
                method_49();
                break;
            case FCTBAction.GoPageUp:
                GClass84_5.method_13(bool_1: false);
                method_49();
                break;
            case FCTBAction.GoPageUpWithSelection:
                GClass84_5.method_13(bool_1: true);
                method_49();
                break;
            case FCTBAction.GoRight:
                GClass84_5.method_11(bool_1: false);
                break;
            case FCTBAction.GoRightWithSelection:
                GClass84_5.method_11(bool_1: true);
                break;
            case FCTBAction.GoRight_ColumnSelectionMode:
                vmethod_50();
                if (GClass84_5.Boolean_0)
                {
                    GClass84_5.method_62();
                }
                method_4();
                break;
            case FCTBAction.GoToDialog:
                method_130();
                break;
            case FCTBAction.GoNextBookmark:
                method_55(GClass84_5.GStruct10_0.int_1);
                break;
            case FCTBAction.GoPrevBookmark:
                method_56(GClass84_5.GStruct10_0.int_1);
                break;
            case FCTBAction.GoUp:
                GClass84_5.method_12(bool_1: false);
                method_49();
                break;
            case FCTBAction.GoUpWithSelection:
                GClass84_5.method_12(bool_1: true);
                method_49();
                break;
            case FCTBAction.GoUp_ColumnSelectionMode:
                vmethod_50();
                if (GClass84_5.Boolean_0)
                {
                    GClass84_5.method_61();
                }
                method_4();
                break;
            case FCTBAction.GoWordLeft:
                GClass84_5.method_48(bool_1: false);
                break;
            case FCTBAction.GoWordLeftWithSelection:
                GClass84_5.method_48(bool_1: true);
                break;
            case FCTBAction.GoWordRight:
                GClass84_5.method_49(bool_1: false, bool_2: true);
                break;
            case FCTBAction.GoWordRightWithSelection:
                GClass84_5.method_49(bool_1: true, bool_2: true);
                break;
            case FCTBAction.IndentIncrease:
                {
                    if (GClass84_5.Boolean_1)
                    {
                        break;
                    }
                    GClass84 gClass3 = GClass84_5.method_6();
                    bool flag = GStruct10.smethod_4(gClass3.GStruct10_0, gClass3.GStruct10_1);
                    gClass3.method_40();
                    int int32_ = this[gClass3.GStruct10_0.int_1].Int32_0;
                    if (gClass3.GStruct10_0.int_1 == gClass3.GStruct10_1.int_1 && (gClass3.GStruct10_0.int_0 > int32_ || gClass3.GStruct10_1.int_0 != this[gClass3.GStruct10_0.int_1].Count) && gClass3.GStruct10_1.int_0 > int32_)
                    {
                        vmethod_41('\t', Keys.None);
                        break;
                    }
                    vmethod_69();
                    if (gClass3.GStruct10_0.int_1 == gClass3.GStruct10_1.int_1 && !gClass3.vmethod_0())
                    {
                        GClass84_5 = new GClass84(this, this[gClass3.GStruct10_0.int_1].Int32_0, gClass3.GStruct10_1.int_1, this[gClass3.GStruct10_0.int_1].Count, gClass3.GStruct10_1.int_1);
                        if (flag)
                        {
                            GClass84_5.method_41();
                        }
                    }
                    break;
                }
            case FCTBAction.IndentDecrease:
                {
                    if (GClass84_5.Boolean_1)
                    {
                        break;
                    }
                    GClass84 gClass = GClass84_5.method_6();
                    if (gClass.GStruct10_0.int_1 == gClass.GStruct10_1.int_1)
                    {
                        GClass80 gClass2 = this[gClass.GStruct10_0.int_1];
                        if (gClass.GStruct10_0.int_0 == 0 && gClass.GStruct10_1.int_0 == gClass2.Count)
                        {
                            GClass84_5 = new GClass84(this, gClass2.Int32_0, gClass.GStruct10_0.int_1, gClass2.Count, gClass.GStruct10_0.int_1);
                        }
                        else if (gClass.GStruct10_0.int_0 == gClass2.Count && gClass.GStruct10_1.int_0 == 0)
                        {
                            GClass84_5 = new GClass84(this, gClass2.Count, gClass.GStruct10_0.int_1, gClass2.Int32_0, gClass.GStruct10_0.int_1);
                        }
                    }
                    vmethod_70();
                    break;
                }
            case FCTBAction.LowerCase:
                if (!GClass84_5.Boolean_1)
                {
                    vmethod_37();
                }
                break;
            case FCTBAction.MacroExecute:
                if (GClass82_0 != null)
                {
                    GClass82_0.Boolean_0 = false;
                    GClass82_0.method_0();
                }
                break;
            case FCTBAction.MacroRecord:
                if (GClass82_0 != null)
                {
                    if (GClass82_0.AllowMacroRecordingByUser)
                    {
                        GClass82_0.Boolean_0 = !GClass82_0.Boolean_0;
                    }
                    if (GClass82_0.Boolean_0)
                    {
                        GClass82_0.method_3();
                    }
                }
                break;
            case FCTBAction.MoveSelectedLinesDown:
                if (!GClass84_5.Boolean_0)
                {
                    vmethod_34();
                }
                break;
            case FCTBAction.MoveSelectedLinesUp:
                if (!GClass84_5.Boolean_0)
                {
                    vmethod_35();
                }
                break;
            case FCTBAction.NavigateBackward:
                method_17();
                break;
            case FCTBAction.NavigateForward:
                method_16();
                break;
            case FCTBAction.Paste:
                if (!GClass84_5.Boolean_1)
                {
                    vmethod_18();
                }
                break;
            case FCTBAction.Redo:
                if (!ReadOnly)
                {
                    vmethod_48();
                }
                break;
            case FCTBAction.ReplaceDialog:
                vmethod_13();
                break;
            case FCTBAction.ReplaceMode:
                if (!ReadOnly)
                {
                    bool_6 = !bool_6;
                }
                break;
            case FCTBAction.ScrollDown:
                method_77(1, -1);
                break;
            case FCTBAction.ScrollUp:
                method_77(1, 1);
                break;
            case FCTBAction.SelectAll:
                GClass84_5.method_2();
                break;
            case FCTBAction.UnbookmarkLine:
                vmethod_33(GClass84_5.GStruct10_0.int_1);
                break;
            case FCTBAction.Undo:
                if (!ReadOnly)
                {
                    vmethod_47();
                }
                break;
            case FCTBAction.UpperCase:
                if (!GClass84_5.Boolean_1)
                {
                    vmethod_36();
                }
                break;
            case FCTBAction.ZoomIn:
                method_78(2);
                break;
            case FCTBAction.ZoomNormal:
                method_54();
                break;
            case FCTBAction.ZoomOut:
                method_78(-2);
                break;
            case FCTBAction.CustomAction1:
            case FCTBAction.CustomAction2:
            case FCTBAction.CustomAction3:
            case FCTBAction.CustomAction4:
            case FCTBAction.CustomAction5:
            case FCTBAction.CustomAction6:
            case FCTBAction.CustomAction7:
            case FCTBAction.CustomAction8:
            case FCTBAction.CustomAction9:
            case FCTBAction.CustomAction10:
            case FCTBAction.CustomAction11:
            case FCTBAction.CustomAction12:
            case FCTBAction.CustomAction13:
            case FCTBAction.CustomAction14:
            case FCTBAction.CustomAction15:
            case FCTBAction.CustomAction16:
            case FCTBAction.CustomAction17:
            case FCTBAction.CustomAction18:
            case FCTBAction.CustomAction19:
            case FCTBAction.CustomAction20:
                vmethod_31(new GEventArgs11(fctbaction_0));
                break;
        }
    }

    protected void vmethod_31(GEventArgs11 geventArgs11_0)
    {
        eventHandler_19?.Invoke(this, geventArgs11_0);
    }

    private void method_54()
    {
        Int32_13 = 100;
    }

    public bool method_55(int int_27)
    {
        GClass58 gClass = null;
        int num = int.MaxValue;
        GClass58 gClass2 = null;
        int num2 = int.MaxValue;
        foreach (GClass58 item in gclass56_0)
        {
            if (item.LineIndex < num2)
            {
                num2 = item.LineIndex;
                gClass2 = item;
            }
            if (item.LineIndex > int_27 && item.LineIndex < num)
            {
                num = item.LineIndex;
                gClass = item;
            }
        }
        if (gClass != null)
        {
            gClass.vmethod_0();
            return true;
        }
        if (gClass2 != null)
        {
            gClass2.vmethod_0();
            return true;
        }
        return false;
    }

    public bool method_56(int int_27)
    {
        GClass58 gClass = null;
        int num = -1;
        GClass58 gClass2 = null;
        int num2 = -1;
        foreach (GClass58 item in gclass56_0)
        {
            if (item.LineIndex > num2)
            {
                num2 = item.LineIndex;
                gClass2 = item;
            }
            if (item.LineIndex < int_27 && item.LineIndex > num)
            {
                num = item.LineIndex;
                gClass = item;
            }
        }
        if (gClass != null)
        {
            gClass.vmethod_0();
            return true;
        }
        if (gClass2 != null)
        {
            gClass2.vmethod_0();
            return true;
        }
        return false;
    }

    public void vmethod_32(int int_27)
    {
        if (!gclass56_0.Contains(int_27))
        {
            gclass56_0.Add(int_27);
        }
    }

    public void vmethod_33(int int_27)
    {
        gclass56_0.Remove(int_27);
    }

    public void vmethod_34()
    {
        GClass84 gClass = GClass84_5.method_6();
        GClass84_5.method_42();
        if (!GClass84_5.Boolean_1)
        {
            int int_ = GClass84_5.GStruct10_0.int_1;
            if (GClass84_5.GStruct10_1.int_1 >= Int32_9 - 1)
            {
                GClass84_5 = gClass;
                return;
            }
            string string_ = String_4;
            List<int> list = [];
            for (int i = GClass84_5.GStruct10_0.int_1; i <= GClass84_5.GStruct10_1.int_1; i++)
            {
                list.Add(i);
            }
            method_133(list);
            GClass84_5.GStruct10_0 = new GStruct10(method_23(int_), int_);
            String_4 = "\n" + string_;
            GClass84_5.GStruct10_0 = new GStruct10(gClass.GStruct10_0.int_0, gClass.GStruct10_0.int_1 + 1);
            GClass84_5.GStruct10_1 = new GStruct10(gClass.GStruct10_1.int_0, gClass.GStruct10_1.int_1 + 1);
        }
        else
        {
            GClass84_5 = gClass;
        }
    }

    public void vmethod_35()
    {
        GClass84 gClass = GClass84_5.method_6();
        GClass84_5.method_42();
        if (!GClass84_5.Boolean_1)
        {
            int num = GClass84_5.GStruct10_0.int_1;
            if (num == 0)
            {
                GClass84_5 = gClass;
                return;
            }
            string string_ = String_4;
            List<int> list = [];
            for (int i = GClass84_5.GStruct10_0.int_1; i <= GClass84_5.GStruct10_1.int_1; i++)
            {
                list.Add(i);
            }
            method_133(list);
            GClass84_5.GStruct10_0 = new GStruct10(0, num - 1);
            String_4 = string_ + "\n";
            GClass84_5.GStruct10_0 = new GStruct10(gClass.GStruct10_0.int_0, gClass.GStruct10_0.int_1 - 1);
            GClass84_5.GStruct10_1 = new GStruct10(gClass.GStruct10_1.int_0, gClass.GStruct10_1.int_1 - 1);
        }
        else
        {
            GClass84_5 = gClass;
        }
    }

    private void method_57(bool bool_37)
    {
        GClass84_5.method_38();
        try
        {
            int int_ = GClass84_5.GStruct10_0.int_1;
            int int32_ = this[int_].Int32_0;
            if (GClass84_5.GStruct10_0.int_0 <= int32_)
            {
                GClass84_5.method_16(bool_37);
                return;
            }
            GClass84_5.method_16(bool_37);
            for (int i = 0; i < int32_; i++)
            {
                GClass84_5.method_11(bool_37);
            }
        }
        finally
        {
            GClass84_5.method_39();
        }
    }

    public void vmethod_36()
    {
        GClass84 gClass = GClass84_5.method_6();
        String_4 = String_4.ToUpper();
        GClass84_5.GStruct10_0 = gClass.GStruct10_0;
        GClass84_5.GStruct10_1 = gClass.GStruct10_1;
    }

    public void vmethod_37()
    {
        GClass84 gClass = GClass84_5.method_6();
        String_4 = String_4.ToLower();
        GClass84_5.GStruct10_0 = gClass.GStruct10_0;
        GClass84_5.GStruct10_1 = gClass.GStruct10_1;
    }

    public void vmethod_38()
    {
        GClass84 gClass = GClass84_5.method_6();
        String_4 = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(String_4.ToLower());
        GClass84_5.GStruct10_0 = gClass.GStruct10_0;
        GClass84_5.GStruct10_1 = gClass.GStruct10_1;
    }

    public void vmethod_39()
    {
        GClass84 gClass = GClass84_5.method_6();
        string input = String_4.ToLower();
        Regex regex = new("(^\\S)|[\\.\\?!:]\\s+(\\S)", RegexOptions.ExplicitCapture);
        String_4 = regex.Replace(input, match_0 => match_0.Value.ToUpper());
        GClass84_5.GStruct10_0 = gClass.GStruct10_0;
        GClass84_5.GStruct10_1 = gClass.GStruct10_1;
    }

    public void method_58()
    {
        vmethod_40(CommentPrefix);
    }

    public void vmethod_40(string string_3)
    {
        if (!string.IsNullOrEmpty(string_3))
        {
            GClass84_5.method_40();
            if (gclass97_0[GClass84_5.GStruct10_0.int_1].vmethod_0().TrimStart().StartsWith(string_3))
            {
                vmethod_74(string_3);
            }
            else
            {
                vmethod_73(string_3);
            }
        }
    }

    public void method_59(KeyPressEventArgs keyPressEventArgs_0)
    {
        keyPressEventHandler_0?.Invoke(this, keyPressEventArgs_0);
    }

    private bool method_60(char char_5)
    {
        if (bool_33)
        {
            bool_33 = false;
            vmethod_42(char_5);
            return true;
        }
        KeyPressEventArgs e = new(char_5);
        method_59(e);
        return e.Handled;
    }

    public void method_61(char char_5)
    {
        KeyPressEventArgs e = new(char_5);
        keyPressEventHandler_1?.Invoke(this, e);
    }

    protected override bool ProcessMnemonic(char charCode)
    {
        if (bool_36)
        {
            return false;
        }
        if (Focused)
        {
            if (!vmethod_41(charCode, keys_0))
            {
                return base.ProcessMnemonic(charCode);
            }
            return true;
        }
        return false;
    }

    protected override bool ProcessKeyMessage(ref Message m)
    {
        if (m.Msg == 258)
        {
            ProcessMnemonic(Convert.ToChar(m.WParam.ToInt32()));
        }
        return base.ProcessKeyMessage(ref m);
    }

    public bool vmethod_41(char char_5, Keys keys_1)
    {
        if (bool_2)
        {
            return true;
        }
        gclass82_0?.method_5(char_5, keys_1);
        if (char_5 == '\b' && (keys_1 == Keys.None || keys_1 == Keys.Shift || (keys_1 & Keys.Alt) != Keys.None))
        {
            if (!ReadOnly && base.Enabled)
            {
                if (method_60(char_5))
                {
                    return true;
                }
                if (GClass84_5.Boolean_1)
                {
                    return false;
                }
                if (!GClass84_5.vmethod_0())
                {
                    vmethod_28();
                }
                else if (!GClass84_5.method_53())
                {
                    vmethod_27('\b');
                }
                if (AutoIndentChars)
                {
                    method_62(GClass84_5.GStruct10_0.int_1);
                }
                method_61('\b');
                return true;
            }
            return false;
        }
        if (char.IsControl(char_5) && char_5 != '\r' && char_5 != '\t')
        {
            return false;
        }
        if (!ReadOnly && base.Enabled)
        {
            if (keys_1 != Keys.None && keys_1 != Keys.Shift && keys_1 != (Keys.Control | Keys.Alt) && keys_1 != (Keys.Shift | Keys.Control | Keys.Alt) && (keys_1 != Keys.Alt || char.IsLetterOrDigit(char_5)))
            {
                return false;
            }
            char char_6 = char_5;
            if (method_60(char_6))
            {
                return true;
            }
            if (GClass84_5.Boolean_1)
            {
                return false;
            }
            if (char_5 == '\r' && !AcceptsReturn)
            {
                return false;
            }
            if (char_5 == '\r')
            {
                char_5 = '\n';
            }
            if (Boolean_6)
            {
                GClass84_5.method_11(bool_1: true);
                GClass84_5.method_41();
            }
            if (!GClass84_5.Boolean_1 && !method_64(char_5))
            {
                vmethod_27(char_5);
            }
            if (char_5 == '\n' || AutoIndentExistingLines)
            {
                vmethod_43();
            }
            if (AutoIndentChars)
            {
                method_62(GClass84_5.GStruct10_0.int_1);
            }
            method_48();
            method_4();
            method_61(char_6);
            return true;
        }
        return false;
    }

    public void method_62(int int_27)
    {
        string[] array = AutoIndentCharsPatterns.Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
        int num = 0;
        string pattern;
        while (true)
        {
            if (num < array.Length)
            {
                pattern = array[num];
                if (Regex.Match(this[int_27].vmethod_0(), pattern).Success)
                {
                    break;
                }
                num++;
                continue;
            }
            return;
        }
        method_63(int_27, new Regex(pattern));
    }

    protected void method_63(int int_27, Regex regex_0)
    {
        GClass84 gClass = GClass84_5.method_6();
        SortedDictionary<int, CaptureCollection> sortedDictionary = [];
        SortedDictionary<int, string> sortedDictionary2 = [];
        int num = 0;
        int int32_ = this[int_27].Int32_0;
        int num2 = int_27;
        while (num2 >= 0 && int32_ == this[num2].Int32_0)
        {
            string text = this[num2].vmethod_0();
            Match match = regex_0.Match(text);
            if (!match.Success)
            {
                break;
            }
            sortedDictionary[num2] = match.Groups["range"].Captures;
            sortedDictionary2[num2] = text;
            if (sortedDictionary[num2].Count > num)
            {
                num = sortedDictionary[num2].Count;
            }
            num2--;
        }
        for (int i = int_27 + 1; i < Int32_9 && int32_ == this[i].Int32_0; i++)
        {
            string text2 = this[i].vmethod_0();
            Match match2 = regex_0.Match(text2);
            if (!match2.Success)
            {
                break;
            }
            sortedDictionary[i] = match2.Groups["range"].Captures;
            sortedDictionary2[i] = text2;
            if (sortedDictionary[i].Count > num)
            {
                num = sortedDictionary[i].Count;
            }
        }
        Dictionary<int, bool> dictionary = [];
        bool flag = false;
        for (int num3 = num - 1; num3 >= 0; num3--)
        {
            int num4 = 0;
            foreach (int key in sortedDictionary.Keys)
            {
                CaptureCollection captureCollection = sortedDictionary[key];
                if (captureCollection.Count > num3)
                {
                    int num5 = captureCollection[num3].Index;
                    string text3 = sortedDictionary2[key];
                    while (num5 > 0 && text3[num5 - 1] == ' ')
                    {
                        num5--;
                    }
                    int num6 = ((num3 != 0) ? (num5 - captureCollection[num3 - 1].Index - 1) : num5);
                    if (num6 > num4)
                    {
                        num4 = num6;
                    }
                }
            }
            foreach (int item in new List<int>(sortedDictionary2.Keys))
            {
                if (sortedDictionary[item].Count <= num3)
                {
                    continue;
                }
                Capture capture = sortedDictionary[item][num3];
                int num7 = ((num3 != 0) ? (capture.Index - sortedDictionary[item][num3 - 1].Index - 1) : capture.Index);
                int num8 = num4 - num7 + 1;
                if (num8 != 0)
                {
                    if (gClass.GStruct10_0.int_1 == item && gClass.GStruct10_0.int_0 > capture.Index)
                    {
                        gClass.GStruct10_0 = new GStruct10(gClass.GStruct10_0.int_0 + num8, item);
                    }
                    if (num8 > 0)
                    {
                        sortedDictionary2[item] = sortedDictionary2[item].Insert(capture.Index, new string(' ', num8));
                    }
                    else
                    {
                        sortedDictionary2[item] = sortedDictionary2[item].Remove(capture.Index + num8, -num8);
                    }
                    dictionary[item] = true;
                    flag = true;
                }
            }
        }
        if (!flag)
        {
            return;
        }
        GClass84_5.method_38();
        method_107();
        method_86();
        GClass97_0.Manager.vmethod_0(new GClass69(GClass97_0));
        foreach (int key2 in sortedDictionary2.Keys)
        {
            if (dictionary.ContainsKey(key2))
            {
                GClass84_5 = new GClass84(this, 0, key2, this[key2].Count, key2);
                if (!GClass84_5.Boolean_1)
                {
                    vmethod_20(sortedDictionary2[key2]);
                }
            }
        }
        GClass84_5 = gClass;
        method_87();
        method_108();
        GClass84_5.method_39();
    }

    private bool method_64(char char_5)
    {
        if (AutoCompleteBrackets)
        {
            if (!GClass84_5.Boolean_0)
            {
                for (int i = 1; i < char_0.Length; i += 2)
                {
                    if (char_5 == char_0[i] && char_5 == GClass84_5.Char_0)
                    {
                        GClass84_5.method_7();
                        return true;
                    }
                }
            }
            for (int j = 0; j < char_0.Length; j += 2)
            {
                if (char_5 == char_0[j])
                {
                    method_65(char_0[j], char_0[j + 1]);
                    return true;
                }
            }
        }
        return false;
    }

    private bool method_65(char char_5, char char_6)
    {
        if (GClass84_5.Boolean_0)
        {
            GClass84 gClass = GClass84_5.method_6();
            gClass.method_40();
            GClass84_5.method_38();
            method_107();
            GClass84_5 = new GClass84(this, gClass.GStruct10_0.int_0, gClass.GStruct10_0.int_1, gClass.GStruct10_0.int_0, gClass.GStruct10_1.int_1)
            {
                Boolean_0 = true
            };
            vmethod_27(char_5);
            GClass84_5 = new GClass84(this, gClass.GStruct10_1.int_0 + 1, gClass.GStruct10_0.int_1, gClass.GStruct10_1.int_0 + 1, gClass.GStruct10_1.int_1)
            {
                Boolean_0 = true
            };
            vmethod_27(char_6);
            if (gClass.vmethod_0())
            {
                GClass84_5 = new GClass84(this, gClass.GStruct10_1.int_0 + 1, gClass.GStruct10_0.int_1, gClass.GStruct10_1.int_0 + 1, gClass.GStruct10_1.int_1)
                {
                    Boolean_0 = true
                };
            }
            method_108();
            GClass84_5.method_39();
        }
        else if (GClass84_5.vmethod_0())
        {
            vmethod_20(char_5.ToString() + char_6);
            GClass84_5.method_8();
        }
        else
        {
            vmethod_20(char_5 + String_4 + char_6);
        }
        return true;
    }

    protected void vmethod_42(char char_5)
    {
        if (char_5 == '\r')
        {
            char_5 = '\n';
        }
        GClass84 gClass = GClass84_5.method_6();
        do
        {
            if (!gClass.method_7())
            {
                return;
            }
        }
        while (gClass.Char_1 != char_5);
        GClass84_5 = gClass;
        method_48();
    }

    public void vmethod_43()
    {
        if (!GClass84_5.Boolean_0 && AutoIndent)
        {
            method_48();
            int num = vmethod_45(GClass84_5.GStruct10_0.int_1);
            if (this[GClass84_5.GStruct10_0.int_1].AutoIndentSpacesNeededCount != num)
            {
                vmethod_44(GClass84_5.GStruct10_0.int_1);
                this[GClass84_5.GStruct10_0.int_1].AutoIndentSpacesNeededCount = num;
            }
        }
    }

    private void method_66()
    {
        if (GClass84_5.vmethod_0())
        {
            _ = GClass84_5.GStruct10_0;
            while (GClass84_5.Char_0 == ' ')
            {
                GClass84_5.method_11(bool_1: true);
            }
            vmethod_28();
        }
    }

    public void vmethod_44(int int_27)
    {
        if (GClass84_5.Boolean_0)
        {
            return;
        }
        GStruct10 gStruct10_ = GClass84_5.GStruct10_0;
        int num = vmethod_45(int_27);
        int int32_ = gclass97_0[int_27].Int32_0;
        int num2 = num - int32_;
        if (num2 < 0)
        {
            num2 = -Math.Min(-num2, int32_);
        }
        if (num2 != 0)
        {
            GClass84_5.GStruct10_0 = new GStruct10(0, int_27);
            if (num2 > 0)
            {
                vmethod_20(new string(' ', num2));
            }
            else
            {
                GClass84_5.GStruct10_0 = new GStruct10(0, int_27);
                GClass84_5.GStruct10_1 = new GStruct10(-num2, int_27);
                vmethod_28();
            }
            GClass84_5.GStruct10_0 = new GStruct10(Math.Min(gclass97_0[int_27].Count, Math.Max(0, gStruct10_.int_0 + num2)), int_27);
        }
    }

    public int vmethod_45(int int_27)
    {
        if (int_27 >= 0 && int_27 < Int32_9)
        {
            EventHandler<GEventArgs8> eventHandler = eventHandler_12 ?? ((GEnum13_0 == GEnum13.const_0 || SyntaxHighlighter == null) ? new EventHandler<GEventArgs8>(vmethod_46) : new EventHandler<GEventArgs8>(SyntaxHighlighter.vmethod_2));
            Stack<GEventArgs8> stack = new();
            int num;
            for (num = int_27 - 1; num >= 0; num--)
            {
                GEventArgs8 gEventArgs = new(num, gclass97_0[num].vmethod_0(), (num > 0) ? gclass97_0[num - 1].vmethod_0() : "", TabLength, 0);
                eventHandler(this, gEventArgs);
                stack.Push(gEventArgs);
                if (gEventArgs.Shift == 0 && gEventArgs.AbsoluteIndentation == 0 && gEventArgs.LineText.Trim() != "")
                {
                    break;
                }
            }
            int num2 = gclass97_0[(num >= 0) ? num : 0].Int32_0;
            while (stack.Count != 0)
            {
                GEventArgs8 gEventArgs2 = stack.Pop();
                num2 = ((gEventArgs2.AbsoluteIndentation == 0) ? (num2 + gEventArgs2.ShiftNextLines) : (gEventArgs2.AbsoluteIndentation + gEventArgs2.ShiftNextLines));
            }
            GEventArgs8 gEventArgs3 = new(int_27, gclass97_0[int_27].vmethod_0(), (int_27 > 0) ? gclass97_0[int_27 - 1].vmethod_0() : "", TabLength, num2);
            eventHandler(this, gEventArgs3);
            return gEventArgs3.AbsoluteIndentation + gEventArgs3.Shift;
        }
        return 0;
    }

    internal void vmethod_46(object sender, GEventArgs8 e)
    {
        if (string.IsNullOrEmpty(gclass97_0[e.iLine].FoldingEndMarker) && !string.IsNullOrEmpty(gclass97_0[e.iLine].FoldingStartMarker))
        {
            e.ShiftNextLines = TabLength;
        }
        else if (!string.IsNullOrEmpty(gclass97_0[e.iLine].FoldingEndMarker) && string.IsNullOrEmpty(gclass97_0[e.iLine].FoldingStartMarker))
        {
            e.Shift = -TabLength;
            e.ShiftNextLines = -TabLength;
        }
    }

    protected int method_67(int int_27, int int_28)
    {
        if (int_27 > int_28)
        {
            return 0;
        }
        int num = int.MaxValue;
        for (int i = int_27; i <= int_28; i++)
        {
            int int32_ = gclass97_0[i].Int32_0;
            if (int32_ < num)
            {
                num = int32_;
            }
        }
        return num;
    }

    protected int method_68(int int_27, int int_28)
    {
        if (int_27 > int_28)
        {
            return 0;
        }
        int num = 0;
        for (int i = int_27; i <= int_28; i++)
        {
            int int32_ = gclass97_0[i].Int32_0;
            if (int32_ > num)
            {
                num = int32_;
            }
        }
        return num;
    }

    public void vmethod_47()
    {
        gclass97_0.Manager.method_0();
        method_48();
        method_4();
    }

    public void vmethod_48()
    {
        gclass97_0.Manager.method_6();
        method_48();
        method_4();
    }

    protected override bool IsInputKey(Keys keyData)
    {
        if (keyData == Keys.Tab && !AcceptsTab)
        {
            return false;
        }
        if (keyData == Keys.Return && !AcceptsReturn)
        {
            return false;
        }
        if ((keyData & Keys.Alt) == 0 && (keyData & Keys.KeyCode) == Keys.Return)
        {
            return true;
        }
        if ((keyData & Keys.Alt) != Keys.Alt)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Prior:
                case Keys.Next:
                case Keys.End:
                case Keys.Home:
                case Keys.Left:
                case Keys.Up:
                case Keys.Right:
                case Keys.Down:
                    return true;
                case Keys.Escape:
                    return false;
                case Keys.Tab:
                    return (keyData & Keys.Control) == 0;
            }
        }
        return base.IsInputKey(keyData);
    }

    [DllImport("User32.dll")]
    private static extern bool CreateCaret(IntPtr intptr_1, int int_27, int int_28, int int_29);

    [DllImport("User32.dll")]
    private static extern bool SetCaretPos(int int_27, int int_28);

    [DllImport("User32.dll")]
    private static extern bool DestroyCaret();

    [DllImport("User32.dll")]
    private static extern bool ShowCaret(IntPtr intptr_1);

    [DllImport("User32.dll")]
    private static extern bool HideCaret(IntPtr intptr_1);

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        if (Brush_0 == null)
        {
            base.OnPaintBackground(e);
        }
        else
        {
            e.Graphics.FillRectangle(Brush_0, base.ClientRectangle);
        }
    }

    public void method_69(Graphics graphics_0, GStruct10 gstruct10_0, Size size_1)
    {
        if (bool_10)
        {
            method_40();
        }
        if (bool_12)
        {
            vmethod_67();
        }
        Point point = method_94(gstruct10_0);
        int num = point.Y + base.VerticalScroll.Value;
        int num2 = point.X + base.HorizontalScroll.Value - LeftIndent - Paddings.Left;
        int int_ = gstruct10_0.int_0;
        int int_2 = (num2 + size_1.Width) / CharWidth;
        for (int i = gstruct10_0.int_1; i < gclass97_0.Count; i++)
        {
            GClass80 gClass = gclass97_0[i];
            GStruct9 gStruct = list_0[i];
            if (gStruct.int_0 > num + size_1.Height)
            {
                break;
            }
            if (gStruct.int_0 + gStruct.Int32_0 * Int32_1 >= num && gStruct.genum10_0 != GEnum10.const_2)
            {
                int num3 = gStruct.int_0 - num;
                graphics_0.SmoothingMode = SmoothingMode.None;
                if (gStruct.genum10_0 == GEnum10.const_0 && gClass.BackgroundBrush != null)
                {
                    graphics_0.FillRectangle(gClass.BackgroundBrush, new Rectangle(0, num3, size_1.Width, Int32_1 * gStruct.Int32_0));
                }
                graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
                for (int j = 0; j < gStruct.Int32_0; j++)
                {
                    num3 = gStruct.int_0 + j * Int32_1 - num;
                    int num4 = ((j != 0) ? (gStruct.int_2 * CharWidth) : 0);
                    method_74(graphics_0, int_, int_2, i, j, -num2 + num4, num3);
                }
            }
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (bool_10)
        {
            method_40();
        }
        if (bool_12)
        {
            vmethod_67();
        }
        list_1.Clear();
        e.Graphics.SmoothingMode = SmoothingMode.None;
        Pen pen = new(Color_6);
        Brush brush = new SolidBrush(Color_2);
        Brush brush2 = new SolidBrush(Color_4);
        Brush brush3 = new SolidBrush(Color_5);
        Brush brush4 = new SolidBrush(Color.FromArgb((Color_1.A == byte.MaxValue) ? 50 : Color_1.A, Color_1));
        Rectangle rectangle = Rectangle_0;
        e.Graphics.FillRectangle(brush3, 0, -base.VerticalScroll.Value, base.ClientSize.Width, Math.Max(0, Paddings.Top - 1));
        e.Graphics.FillRectangle(brush3, 0, rectangle.Bottom, base.ClientSize.Width, base.ClientSize.Height);
        e.Graphics.FillRectangle(brush3, rectangle.Right, 0, base.ClientSize.Width, base.ClientSize.Height);
        e.Graphics.FillRectangle(brush3, Int32_15, 0, LeftIndent - Int32_15 - 1, base.ClientSize.Height);
        if (base.HorizontalScroll.Value <= Paddings.Left)
        {
            e.Graphics.FillRectangle(brush3, LeftIndent - base.HorizontalScroll.Value - 2, 0, Math.Max(0, Paddings.Left - 1), base.ClientSize.Height);
        }
        Math.Max(LeftIndent, LeftIndent + Paddings.Left - base.HorizontalScroll.Value);
        _ = rectangle.Width;
        e.Graphics.FillRectangle(brush2, 0, 0, Int32_15, base.ClientSize.Height);
        if (LeftIndent > 8)
        {
            e.Graphics.DrawLine(pen, Int32_15, 0, Int32_15, base.ClientSize.Height);
        }
        if (Int32_4 > 0)
        {
            e.Graphics.DrawLine(pen, new Point(LeftIndent + Paddings.Left + Int32_4 * CharWidth - base.HorizontalScroll.Value + 1, rectangle.Top + 1), new Point(LeftIndent + Paddings.Left + Int32_4 * CharWidth - base.HorizontalScroll.Value + 1, rectangle.Bottom - 1));
        }
        method_72(e.Graphics);
        int num = Math.Max(0, base.HorizontalScroll.Value - Paddings.Left) / CharWidth;
        int int_ = (base.HorizontalScroll.Value + base.ClientSize.Width) / CharWidth;
        int num2 = LeftIndent + Paddings.Left - base.HorizontalScroll.Value;
        if (num2 < LeftIndent)
        {
            num++;
        }
        Dictionary<int, GClass58> dictionary = [];
        foreach (GClass58 item in gclass56_0)
        {
            dictionary[item.LineIndex] = item;
        }
        int num3 = method_82(base.VerticalScroll.Value);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        int i;
        for (i = num3; i < gclass97_0.Count; i++)
        {
            GClass80 gClass = gclass97_0[i];
            GStruct9 gStruct = list_0[i];
            if (gStruct.int_0 > base.VerticalScroll.Value + base.ClientSize.Height)
            {
                break;
            }
            if (gStruct.int_0 + gStruct.Int32_0 * Int32_1 < base.VerticalScroll.Value || gStruct.genum10_0 == GEnum10.const_2)
            {
                continue;
            }
            int num4 = gStruct.int_0 - base.VerticalScroll.Value;
            e.Graphics.SmoothingMode = SmoothingMode.None;
            if (gStruct.genum10_0 == GEnum10.const_0 && gClass.BackgroundBrush != null)
            {
                e.Graphics.FillRectangle(gClass.BackgroundBrush, new Rectangle(rectangle.Left, num4, rectangle.Width, Int32_1 * gStruct.Int32_0));
            }
            if (Color_1 != Color.Transparent && i == GClass84_5.GStruct10_0.int_1 && GClass84_5.vmethod_0())
            {
                e.Graphics.FillRectangle(brush4, new Rectangle(rectangle.Left, num4, rectangle.Width, Int32_1));
            }
            if (Color_2 != Color.Transparent && gClass.IsChanged)
            {
                e.Graphics.FillRectangle(brush, new RectangleF(-10f, num4, LeftIndent - 8 - 2 + 10, Int32_1 + 1));
            }
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (dictionary.ContainsKey(i))
            {
                dictionary[i].vmethod_1(e.Graphics, new Rectangle(LeftIndent, num4, base.Width, Int32_1 * gStruct.Int32_0));
            }
            if (gStruct.genum10_0 == GEnum10.const_0)
            {
                vmethod_81(new GEventArgs2(i, new Rectangle(LeftIndent, num4, base.Width, Int32_1 * gStruct.Int32_0), e.Graphics, e.ClipRectangle));
            }
            if (Boolean_2)
            {
                using SolidBrush brush5 = new(Color_3);
                e.Graphics.DrawString((i + uint_0).ToString(), Font, brush5, new RectangleF(-10f, num4, LeftIndent - 8 - 2 + 10, Int32_1 + (int)((float)int_12 * 0.5f)), new StringFormat(StringFormatFlags.DirectionRightToLeft)
                {
                    LineAlignment = StringAlignment.Center
                });
            }
            if (gStruct.genum10_0 == GEnum10.const_1)
            {
                list_1.Add(new GClass101(i, new Rectangle(Int32_15 - 4, num4 + Int32_1 / 2 - 3, 8, 8)));
            }
            if (!string.IsNullOrEmpty(gClass.FoldingStartMarker) && gStruct.genum10_0 == GEnum10.const_0 && string.IsNullOrEmpty(gClass.FoldingEndMarker))
            {
                list_1.Add(new GClass100(i, new Rectangle(Int32_15 - 4, num4 + Int32_1 / 2 - 3, 8, 8)));
            }
            if (gStruct.genum10_0 == GEnum10.const_0 && !string.IsNullOrEmpty(gClass.FoldingEndMarker) && string.IsNullOrEmpty(gClass.FoldingStartMarker))
            {
                e.Graphics.DrawLine(pen, Int32_15, num4 + Int32_1 * gStruct.Int32_0 - 1, Int32_15 + 4, num4 + Int32_1 * gStruct.Int32_0 - 1);
            }
            for (int j = 0; j < gStruct.Int32_0; j++)
            {
                num4 = gStruct.int_0 + j * Int32_1 - base.VerticalScroll.Value;
                if (num4 > base.VerticalScroll.Value + base.ClientSize.Height)
                {
                    break;
                }
                if (gStruct.int_0 + j * Int32_1 >= base.VerticalScroll.Value)
                {
                    int num5 = ((j != 0) ? (gStruct.int_2 * CharWidth) : 0);
                    method_74(e.Graphics, num, int_, i, j, num2 + num5, num4);
                }
            }
        }
        int int_2 = i - 1;
        if (Boolean_3)
        {
            vmethod_49(e, num3, int_2);
        }
        if (GClass84_5.Boolean_0 && SelectionStyle.BackgroundBrush is SolidBrush)
        {
            Color color = ((SolidBrush)SelectionStyle.BackgroundBrush).Color;
            Point point = method_94(GClass84_5.GStruct10_0);
            Point point2 = method_94(GClass84_5.GStruct10_1);
            using Pen pen2 = new(color);
            e.Graphics.DrawRectangle(pen2, Rectangle.FromLTRB(Math.Min(point.X, point2.X) - 1, Math.Min(point.Y, point2.Y), Math.Max(point.X, point2.X), Math.Max(point.Y, point2.Y) + Int32_1));
        }
        if (BracketsStyle != null && gclass84_2 != null && gclass84_4 != null)
        {
            BracketsStyle.vmethod_0(e.Graphics, method_94(gclass84_2.GStruct10_0), gclass84_2);
            BracketsStyle.vmethod_0(e.Graphics, method_94(gclass84_4.GStruct10_0), gclass84_4);
        }
        if (BracketsStyle2 != null && gclass84_3 != null && gclass84_5 != null)
        {
            BracketsStyle2.vmethod_0(e.Graphics, method_94(gclass84_3.GStruct10_0), gclass84_3);
            BracketsStyle2.vmethod_0(e.Graphics, method_94(gclass84_5.GStruct10_0), gclass84_5);
        }
        e.Graphics.SmoothingMode = SmoothingMode.None;
        if ((int_16 >= 0 || int_10 >= 0) && GStruct10.smethod_1(GClass84_5.GStruct10_0, GClass84_5.GStruct10_1) && int_10 < list_0.Count)
        {
            int y = ((int_16 >= 0) ? list_0[int_16].int_0 : 0) - base.VerticalScroll.Value + Int32_1 / 2;
            int y2 = ((int_10 >= 0) ? (list_0[int_10].int_0 + (list_0[int_10].Int32_0 - 1) * Int32_1) : (int_8 + Int32_1)) - base.VerticalScroll.Value + Int32_1;
            using Pen pen3 = new(Color.FromArgb(100, Color_7), 4f);
            e.Graphics.DrawLine(pen3, LeftIndent - 5, y, LeftIndent - 5, y2);
        }
        method_73(e.Graphics);
        method_70(e, pen);
        Point point3 = method_94(GClass84_5.GStruct10_0);
        int num6 = Int32_1 - int_12;
        point3.Offset(0, int_12 / 2);
        if ((Focused || IsDragDrop || ShowCaretWhenInactive) && point3.X >= LeftIndent && Boolean_0)
        {
            int int_3 = ((!Boolean_6 && !WideCaret) ? 1 : CharWidth);
            if (WideCaret)
            {
                using SolidBrush brush6 = new(CaretColor);
                e.Graphics.FillRectangle(brush6, point3.X, point3.Y, int_3, num6 + 1);
            }
            else
            {
                using Pen pen4 = new(CaretColor);
                e.Graphics.DrawLine(pen4, point3.X, point3.Y, point3.X, point3.Y + num6);
            }
            Rectangle rectangle2 = new(base.HorizontalScroll.Value + point3.X, base.VerticalScroll.Value + point3.Y, int_3, num6 + 1);
            if (CaretBlinking && (rectangle_0 != rectangle2 || !Boolean_9))
            {
                CreateCaret(base.Handle, 0, int_3, num6 + 1);
                SetCaretPos(point3.X, point3.Y);
                ShowCaret(base.Handle);
            }
            rectangle_0 = rectangle2;
        }
        else
        {
            HideCaret(base.Handle);
            rectangle_0 = Rectangle.Empty;
        }
        if (!base.Enabled)
        {
            using SolidBrush brush7 = new(DisabledColor);
            e.Graphics.FillRectangle(brush7, base.ClientRectangle);
        }
        if (GClass82_0.Boolean_0)
        {
            method_71(e.Graphics);
        }
        if (bool_36)
        {
            method_138(e.Graphics);
        }
        pen.Dispose();
        brush.Dispose();
        brush2.Dispose();
        brush4.Dispose();
        brush3.Dispose();
        base.OnPaint(e);
    }

    private void method_70(PaintEventArgs paintEventArgs_0, Pen pen_0)
    {
        foreach (GClass99 item in list_1)
        {
            if (item is GClass100)
            {
                using SolidBrush solidBrush = new(ServiceColors.CollapseMarkerBackColor);
                using Pen pen_1 = new(ServiceColors.CollapseMarkerForeColor);
                using Pen pen_2 = new(ServiceColors.CollapseMarkerBorderColor);
                (item as GClass100).method_0(paintEventArgs_0.Graphics, pen_2, solidBrush, pen_1);
            }
            else if (item is GClass101)
            {
                using SolidBrush solidBrush2 = new(ServiceColors.ExpandMarkerBackColor);
                using Pen pen_3 = new(ServiceColors.ExpandMarkerForeColor);
                using Pen pen_4 = new(ServiceColors.ExpandMarkerBorderColor);
                (item as GClass101).method_0(paintEventArgs_0.Graphics, pen_4, solidBrush2, pen_3);
            }
            else
            {
                item.vmethod_0(paintEventArgs_0.Graphics, pen_0);
            }
        }
    }

    private void method_71(Graphics graphics_0)
    {
        Rectangle rectangle_0 = new(base.ClientRectangle.Right - 75, base.ClientRectangle.Bottom - 13, 75, 13);
        Rectangle rect = new(-3, -3, 6, 6);
        GraphicsState gstate = graphics_0.Save();
        graphics_0.SmoothingMode = SmoothingMode.HighQuality;
        graphics_0.TranslateTransform(rectangle_0.Left + 6, rectangle_0.Top + 6);
        new TimeSpan(DateTime.Now.Ticks);
        graphics_0.RotateTransform(180f * ((float)DateTime.Now.Millisecond / 1000f));
        using (Pen pen = new(Color.Red, 2f))
        {
            graphics_0.DrawArc(pen, rect, 0f, 90f);
            graphics_0.DrawArc(pen, rect, 180f, 90f);
        }
        graphics_0.DrawEllipse(Pens.Red, rect);
        graphics_0.Restore(gstate);
        using (Font font = new(FontFamily.GenericSansSerif, 8f))
        {
            graphics_0.DrawString("Recording...", font, Brushes.Red, new PointF(rectangle_0.Left + 13, rectangle_0.Top));
        }
        System.Threading.Timer timer_0 = null;
        timer_0 = new System.Threading.Timer(delegate
        {
            Invalidate(rectangle_0);
            timer_0.Dispose();
        }, null, 200, -1);
    }

    private void method_72(Graphics graphics_0)
    {
        if (GEnum8_0 == GEnum8.const_0)
        {
            return;
        }
        Rectangle rect = Rectangle_0;
        if (GEnum8_0 == GEnum8.const_2)
        {
            Rectangle rect2 = new(rect.Left + 4, rect.Bottom, rect.Width - 4, 4);
            Rectangle rect3 = new(rect.Right, rect.Bottom, 4, 4);
            Rectangle rect4 = new(rect.Right, rect.Top + 4, 4, rect.Height - 4);
            using SolidBrush brush = new(Color.FromArgb(80, Color_0));
            graphics_0.FillRectangle(brush, rect2);
            graphics_0.FillRectangle(brush, rect4);
            graphics_0.FillRectangle(brush, rect3);
        }
        using Pen pen = new(Color_0);
        graphics_0.DrawRectangle(pen, rect);
    }

    private void method_73(Graphics graphics_0)
    {
        foreach (GClass77 item in gclass76_0)
        {
            GClass84 gClass = item.Range.method_6();
            gClass.method_40();
            Point point = method_94(gClass.GStruct10_0);
            Point point2 = method_94(gClass.GStruct10_1);
            if (method_129(gClass.GStruct10_0.int_1) != GEnum10.const_0 || method_129(gClass.GStruct10_1.int_1) != GEnum10.const_0)
            {
                continue;
            }
            using Pen pen = new(item.Color_2);
            pen.DashStyle = DashStyle.Dash;
            if (gClass.vmethod_0())
            {
                point.Offset(1, -1);
                graphics_0.DrawLines(pen, new Point[2]
                {
                    point,
                    new(point.X, point.Y + int_9 + 2)
                });
                continue;
            }
            point.Offset(-1, -1);
            point2.Offset(1, -1);
            graphics_0.DrawLines(pen, new Point[4]
            {
                new(point.X + CharWidth / 2, point.Y),
                point,
                new(point.X, point.Y + int_9 + 2),
                new(point.X + CharWidth / 2, point.Y + int_9 + 2)
            });
            graphics_0.DrawLines(pen, new Point[4]
            {
                new(point2.X - CharWidth / 2, point2.Y),
                point2,
                new(point2.X, point2.Y + int_9 + 2),
                new(point2.X - CharWidth / 2, point2.Y + int_9 + 2)
            });
        }
    }

    protected void vmethod_49(PaintEventArgs paintEventArgs_0, int int_27, int int_28)
    {
        paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.None;
        using Pen pen = new(Color.FromArgb(200, Color_6))
        {
            DashStyle = DashStyle.Dot
        };
        foreach (KeyValuePair<int, int> item in dictionary_0)
        {
            if (item.Key >= int_28 || item.Value <= int_27)
            {
                continue;
            }
            GClass80 gClass = gclass97_0[item.Key];
            int num = list_0[item.Key].int_0 - base.VerticalScroll.Value + Int32_1;
            num += num % 2;
            int num2;
            if (item.Value >= Int32_9)
            {
                num2 = list_0[Int32_9 - 1].int_0 + Int32_1 - base.VerticalScroll.Value;
            }
            else
            {
                if (list_0[item.Value].genum10_0 != GEnum10.const_0)
                {
                    continue;
                }
                int num3 = 0;
                int int32_ = gClass.Int32_0;
                if (gclass97_0[item.Value].Count <= int32_ || gclass97_0[item.Value][int32_].char_0 == ' ')
                {
                    num3 = Int32_1;
                }
                num2 = list_0[item.Value].int_0 - base.VerticalScroll.Value + num3;
            }
            int num4 = LeftIndent + Paddings.Left + gClass.Int32_0 * CharWidth - base.HorizontalScroll.Value;
            if (num4 >= LeftIndent + Paddings.Left)
            {
                paintEventArgs_0.Graphics.DrawLine(pen, num4, (num >= 0) ? num : 0, num4, (num2 < base.ClientSize.Height) ? num2 : base.ClientSize.Height);
            }
        }
    }

    private void method_74(Graphics graphics_0, int int_27, int int_28, int int_29, int int_30, int int_31, int int_32)
    {
        GClass80 gClass = gclass97_0[int_29];
        GStruct9 gStruct = list_0[int_29];
        int num = gStruct.method_0(int_30);
        int_28 = Math.Min(gStruct.method_1(int_30, gClass) - num, int_28);
        graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
        if (gStruct.genum10_0 == GEnum10.const_1)
        {
            FoldedBlockStyle.vmethod_0(graphics_0, new Point(int_31 + int_27 * CharWidth, int_32), new GClass84(this, num + int_27, int_29, num + int_28 + 1, int_29));
        }
        else
        {
            StyleIndex styleIndex = StyleIndex.None;
            int num2 = int_27 - 1;
            for (int i = int_27; i <= int_28; i++)
            {
                StyleIndex styleIndex_ = gClass[num + i].styleIndex_0;
                if (styleIndex != styleIndex_)
                {
                    method_75(graphics_0, styleIndex, new Point(int_31 + (num2 + 1) * CharWidth, int_32), new GClass84(this, num + num2 + 1, int_29, num + i, int_29));
                    num2 = i - 1;
                    styleIndex = styleIndex_;
                }
            }
            method_75(graphics_0, styleIndex, new Point(int_31 + (num2 + 1) * CharWidth, int_32), new GClass84(this, num + num2 + 1, int_29, num + int_28 + 1, int_29));
        }
        if (Boolean_12 && int_30 == gStruct.Int32_0 - 1)
        {
            int_28++;
        }
        if (!GClass84_5.vmethod_0() && int_28 >= int_27)
        {
            graphics_0.SmoothingMode = SmoothingMode.None;
            GClass84 gClass2 = new(this, num + int_27, int_29, num + int_28 + 1, int_29);
            gClass2 = GClass84_5.vmethod_1(gClass2);
            if (gClass2 != null && SelectionStyle != null)
            {
                SelectionStyle.vmethod_0(graphics_0, new Point(int_31 + (gClass2.GStruct10_0.int_0 - num) * CharWidth, 1 + int_32), gClass2);
            }
        }
    }

    private void method_75(Graphics graphics_0, StyleIndex styleIndex_0, Point point_4, GClass84 gclass84_9)
    {
        if (!GStruct10.smethod_4(gclass84_9.GStruct10_1, gclass84_9.GStruct10_0))
        {
            return;
        }
        int num = 1;
        bool flag = false;
        for (int i = 0; i < GClass85_0.Length; i++)
        {
            if (GClass85_0[i] != null && ((uint)styleIndex_0 & (uint)num) != 0)
            {
                GClass85 gClass = GClass85_0[i];
                bool flag2 = gClass is GClass86;
                if (!flag || !flag2 || AllowSeveralTextStyleDrawing)
                {
                    gClass.vmethod_0(graphics_0, point_4, gclass84_9);
                }
                flag = flag || flag2;
            }
            num <<= 1;
        }
        if (!flag)
        {
            GClass86_0.vmethod_0(graphics_0, point_4, gclass84_9);
        }
    }

    protected override void OnEnter(EventArgs e)
    {
        base.OnEnter(e);
        bool_7 = false;
        bool_8 = false;
        gclass84_8 = null;
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        bool_5 = false;
        if (e.Button == MouseButtons.Left && bool_8)
        {
            method_76(e);
        }
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (bool_36)
        {
            method_136();
            bool_7 = false;
            if (e.Button == MouseButtons.Middle)
            {
                method_137();
            }
            return;
        }
        GClass82_0.Boolean_0 = false;
        Select();
        base.ActiveControl = null;
        if (e.Button == MouseButtons.Left)
        {
            GClass99 gClass = method_106(e.Location);
            if (gClass != null)
            {
                bool_7 = false;
                bool_8 = false;
                gclass84_8 = null;
                vmethod_76(e, gClass);
                return;
            }
            bool_7 = true;
            bool_8 = false;
            gclass84_8 = null;
            bool_5 = e.Location.X < Int32_15;
            if (!bool_5)
            {
                GStruct10 gStruct = method_83(e.Location);
                if (e.Clicks == 2)
                {
                    bool_7 = false;
                    bool_8 = false;
                    gclass84_8 = null;
                    method_81(gStruct);
                }
                else if (!GClass84_5.vmethod_0() && GClass84_5.method_0(gStruct) && this[gStruct.int_1].Count > gStruct.int_0 && !ReadOnly)
                {
                    bool_8 = true;
                    bool_7 = false;
                }
                else
                {
                    method_76(e);
                }
            }
            else
            {
                vmethod_50();
                GClass84_5.method_38();
                int int_ = (int_13 = method_84(e.Location).int_1);
                GClass84_5.GStruct10_0 = new GStruct10(0, int_);
                GClass84_5.GStruct10_1 = new GStruct10(method_23(int_), int_);
                GClass84_5.method_39();
                method_4();
            }
        }
        else if (e.Button == MouseButtons.Middle)
        {
            method_135(e);
        }
    }

    private void method_76(MouseEventArgs mouseEventArgs_0)
    {
        GStruct10 gStruct10_ = GClass84_5.GStruct10_1;
        GClass84_5.method_38();
        if (GClass84_5.Boolean_0)
        {
            GClass84_5.GStruct10_0 = method_84(mouseEventArgs_0.Location);
            GClass84_5.Boolean_0 = true;
        }
        else if (VirtualSpace)
        {
            GClass84_5.GStruct10_0 = method_84(mouseEventArgs_0.Location);
        }
        else
        {
            GClass84_5.GStruct10_0 = method_83(mouseEventArgs_0.Location);
        }
        if ((keys_0 & Keys.Shift) != Keys.None)
        {
            GClass84_5.GStruct10_1 = gStruct10_;
        }
        vmethod_50();
        GClass84_5.method_39();
        method_4();
    }

    protected void vmethod_50()
    {
        if ((Control.ModifierKeys & Keys.Alt) != Keys.None && !Boolean_11)
        {
            GClass84_5.Boolean_0 = true;
        }
        else
        {
            GClass84_5.Boolean_0 = false;
        }
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        method_4();
        if (keys_0 == Keys.Control)
        {
            method_78(2 * Math.Sign(e.Delta));
            ((HandledMouseEventArgs)e).Handled = true;
        }
        else if (base.VerticalScroll.Visible || !Boolean_9)
        {
            int int_ = smethod_4();
            method_77(int_, e.Delta);
            ((HandledMouseEventArgs)e).Handled = true;
        }
        method_136();
    }

    private void method_77(int int_27, int int_28)
    {
        if (base.VerticalScroll.Visible || !Boolean_9)
        {
            int num = base.ClientSize.Height / Int32_1;
            int num2 = ((int_27 == -1 || int_27 > num) ? (Int32_1 * num) : (Int32_1 * int_27));
            int newValue = base.VerticalScroll.Value - Math.Sign(int_28) * num2;
            ScrollEventArgs se = new((int_28 <= 0) ? ScrollEventType.SmallIncrement : ScrollEventType.SmallDecrement, base.VerticalScroll.Value, newValue, ScrollOrientation.VerticalScroll);
            OnScroll(se);
        }
    }

    private static int smethod_4()
    {
        try
        {
            using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: false);
            return Convert.ToInt32(registryKey.GetValue("WheelScrollLines"));
        }
        catch
        {
            return 1;
        }
    }

    public void method_78(int int_27)
    {
        float sizeInPoints = Font.SizeInPoints;
        using Graphics graphics = Graphics.FromHwnd(base.Handle);
        float dpiY = graphics.DpiY;
        float num = sizeInPoints + (float)int_27 * 72f / dpiY;
        if (!(num < 1f))
        {
            float num2 = num / font_1.SizeInPoints;
            Int32_13 = (int)(100f * num2);
        }
    }

    protected void vmethod_51()
    {
        eventHandler_18?.Invoke(this, EventArgs.Empty);
    }

    private void method_79(float float_0)
    {
        int num = method_82(base.VerticalScroll.Value);
        float sizeInPoints = font_1.SizeInPoints;
        sizeInPoints *= float_0;
        if (!(sizeInPoints < 1f) && sizeInPoints <= 300f)
        {
            Font font = Font;
            method_0(new Font(Font.FontFamily, sizeInPoints, Font.Style, GraphicsUnit.Point));
            font.Dispose();
            method_11(bool_37: true);
            if (num < Int32_9)
            {
                base.VerticalScroll.Value = Math.Min(base.VerticalScroll.Maximum, list_0[num].int_0 - Paddings.Top);
            }
            method_47();
            method_4();
            vmethod_4();
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        method_80();
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (bool_36)
        {
            return;
        }
        if (point_0 != e.Location)
        {
            method_80();
            timer_2.Start();
        }
        point_0 = e.Location;
        if (e.Button == MouseButtons.Left && bool_8)
        {
            gclass84_8 = GClass84_5.method_6();
            DoDragDrop(String_4, DragDropEffects.Copy);
            gclass84_8 = null;
            return;
        }
        if (e.Button == MouseButtons.Left && bool_7)
        {
            GStruct10 gStruct = ((GClass84_5.Boolean_0 || VirtualSpace) ? method_84(e.Location) : method_83(e.Location));
            if (bool_5)
            {
                GClass84_5.method_38();
                int num = gStruct.int_1;
                if (num < int_13)
                {
                    GClass84_5.GStruct10_0 = new GStruct10(0, num);
                    GClass84_5.GStruct10_1 = new GStruct10(method_23(int_13), int_13);
                }
                else
                {
                    GClass84_5.GStruct10_0 = new GStruct10(method_23(num), num);
                    GClass84_5.GStruct10_1 = new GStruct10(0, int_13);
                }
                GClass84_5.method_39();
                method_48();
                base.HorizontalScroll.Value = 0;
                method_47();
                method_4();
            }
            else if (GStruct10.smethod_0(gStruct, GClass84_5.GStruct10_0))
            {
                GStruct10 gStruct10_ = GClass84_5.GStruct10_1;
                GClass84_5.method_38();
                if (GClass84_5.Boolean_0)
                {
                    GClass84_5.GStruct10_0 = gStruct;
                    GClass84_5.Boolean_0 = true;
                }
                else
                {
                    GClass84_5.GStruct10_0 = gStruct;
                }
                GClass84_5.GStruct10_1 = gStruct10_;
                GClass84_5.method_39();
                method_48();
                method_4();
                return;
            }
        }
        GClass99 gClass = method_106(e.Location);
        if (gClass != null)
        {
            base.Cursor = gClass.vmethod_1();
        }
        else if (e.Location.X >= Int32_15 && !bool_5)
        {
            base.Cursor = cursor_0;
        }
        else
        {
            base.Cursor = Cursors.Arrow;
        }
    }

    private void method_80()
    {
        timer_2.Stop();
        if (ToolTip != null && !string.IsNullOrEmpty(ToolTip.GetToolTip(this)))
        {
            ToolTip.Hide(this);
            ToolTip.SetToolTip(this, null);
        }
    }

    protected override void OnMouseDoubleClick(MouseEventArgs e)
    {
        base.OnMouseDoubleClick(e);
        GClass99 gClass = method_106(e.Location);
        if (gClass != null)
        {
            vmethod_77(gClass);
        }
    }

    private void method_81(GStruct10 gstruct10_0)
    {
        int num = gstruct10_0.int_0;
        int num2 = gstruct10_0.int_0;
        for (int i = gstruct10_0.int_0; i < gclass97_0[gstruct10_0.int_1].Count; i++)
        {
            char c = gclass97_0[gstruct10_0.int_1][i].char_0;
            if (!char.IsLetterOrDigit(c) && c != '_')
            {
                break;
            }
            num2 = i + 1;
        }
        for (int num3 = gstruct10_0.int_0 - 1; num3 >= 0; num3--)
        {
            char c2 = gclass97_0[gstruct10_0.int_1][num3].char_0;
            if (!char.IsLetterOrDigit(c2) && c2 != '_')
            {
                break;
            }
            num = num3;
        }
        GClass84_5 = new GClass84(this, num2, gstruct10_0.int_1, num, gstruct10_0.int_1);
    }

    public int method_82(int int_27)
    {
        int num = list_0.BinarySearch(new GStruct9(-10), new Class85(int_27));
        num = ((num < 0) ? (-num - 2) : num);
        if (num < 0)
        {
            return 0;
        }
        if (num > gclass97_0.Count - 1)
        {
            return gclass97_0.Count - 1;
        }
        return num;
    }

    public GStruct10 method_83(Point point_4)
    {
        point_4.Offset(base.HorizontalScroll.Value, base.VerticalScroll.Value);
        point_4.Offset(-LeftIndent - Paddings.Left, 0);
        int i = method_82(point_4.Y);
        if (i < 0)
        {
            return GStruct10.GStruct10_0;
        }
        int num = 0;
        for (; i < gclass97_0.Count; i++)
        {
            num = list_0[i].int_0 + list_0[i].Int32_0 * Int32_1;
            if (num > point_4.Y && list_0[i].genum10_0 == GEnum10.const_0)
            {
                break;
            }
        }
        if (i >= gclass97_0.Count)
        {
            i = gclass97_0.Count - 1;
        }
        if (list_0[i].genum10_0 != GEnum10.const_0)
        {
            i = method_105(i);
        }
        int num2 = list_0[i].Int32_0;
        if (num > point_4.Y)
        {
            int num3 = (num - point_4.Y - Int32_1) / Int32_1;
            num -= num3 * Int32_1;
            num2 -= num3;
        }
        do
        {
            num2--;
            num -= Int32_1;
        }
        while (num > point_4.Y);
        if (num2 < 0)
        {
            num2 = 0;
        }
        int num4 = list_0[i].method_0(num2);
        int num5 = list_0[i].method_1(num2, gclass97_0[i]);
        int num6 = (int)Math.Round((float)point_4.X / (float)CharWidth);
        if (num2 > 0)
        {
            num6 -= list_0[i].int_2;
        }
        num6 = ((num6 < 0) ? num4 : (num4 + num6));
        if (num6 > num5)
        {
            num6 = num5 + 1;
        }
        if (num6 > gclass97_0[i].Count)
        {
            num6 = gclass97_0[i].Count;
        }
        return new GStruct10(num6, i);
    }

    private GStruct10 method_84(Point point_4)
    {
        point_4.Offset(base.HorizontalScroll.Value, base.VerticalScroll.Value);
        point_4.Offset(-LeftIndent - Paddings.Left, 0);
        int num = method_82(point_4.Y);
        int num2 = (int)Math.Round((float)point_4.X / (float)CharWidth);
        if (num2 < 0)
        {
            num2 = 0;
        }
        return new GStruct10(num2, num);
    }

    public int method_85(Point point_4)
    {
        return method_91(method_83(point_4));
    }

    public void vmethod_52(ref string string_3)
    {
        method_109();
        if (eventHandler_5 != null)
        {
            GEventArgs6 gEventArgs = new()
            {
                InsertingText = string_3
            };
            eventHandler_5(this, gEventArgs);
            string_3 = gEventArgs.InsertingText;
            if (gEventArgs.Cancel)
            {
                string_3 = string.Empty;
            }
        }
    }

    public void vmethod_53()
    {
        string string_ = null;
        vmethod_52(ref string_);
    }

    public void vmethod_54()
    {
        GClass84 gClass = new(this);
        gClass.method_2();
        vmethod_57(new GEventArgs5(gClass));
    }

    public void vmethod_55(int int_27, int int_28)
    {
        GClass84 gClass = new(this)
        {
            GStruct10_0 = new GStruct10(0, Math.Min(int_27, int_28)),
            GStruct10_1 = new GStruct10(gclass97_0[Math.Max(int_27, int_28)].Count, Math.Max(int_27, int_28))
        };
        vmethod_57(new GEventArgs5(gClass));
    }

    public void vmethod_56(GClass84 gclass84_9)
    {
        vmethod_57(new GEventArgs5(gclass84_9));
    }

    public void method_86()
    {
        if (int_17 == 0)
        {
            gclass84_6 = null;
        }
        int_17++;
    }

    public void method_87()
    {
        int_17--;
        if (int_17 == 0 && gclass84_6 != null)
        {
            gclass84_6.method_42();
            vmethod_56(gclass84_6);
        }
    }

    protected void vmethod_57(GEventArgs5 geventArgs5_0)
    {
        geventArgs5_0.ChangedRange.method_40();
        if (int_17 > 0)
        {
            if (gclass84_6 == null)
            {
                gclass84_6 = geventArgs5_0.ChangedRange.method_6();
                return;
            }
            if (gclass84_6.GStruct10_0.int_1 > geventArgs5_0.ChangedRange.GStruct10_0.int_1)
            {
                gclass84_6.GStruct10_0 = new GStruct10(0, geventArgs5_0.ChangedRange.GStruct10_0.int_1);
            }
            if (gclass84_6.GStruct10_1.int_1 < geventArgs5_0.ChangedRange.GStruct10_1.int_1)
            {
                gclass84_6.GStruct10_1 = new GStruct10(gclass97_0[geventArgs5_0.ChangedRange.GStruct10_1.int_1].Count, geventArgs5_0.ChangedRange.GStruct10_1.int_1);
            }
            gclass84_6 = gclass84_6.vmethod_1(GClass84_6);
            return;
        }
        method_80();
        method_1();
        Boolean_1 = true;
        TextVersion++;
        method_89(geventArgs5_0.ChangedRange);
        method_88(geventArgs5_0.ChangedRange);
        if (bool_19)
        {
            method_45(geventArgs5_0.ChangedRange.GStruct10_0.int_1, geventArgs5_0.ChangedRange.GStruct10_1.int_1);
        }
        base.OnTextChanged(geventArgs5_0);
        if (gclass84_1 == null)
        {
            gclass84_1 = geventArgs5_0.ChangedRange.method_6();
        }
        else
        {
            gclass84_1 = gclass84_1.method_1(geventArgs5_0.ChangedRange);
        }
        bool_14 = true;
        method_20(timer_1);
        vmethod_78(geventArgs5_0);
        eventHandler_2?.Invoke(this, geventArgs5_0);
        eventHandler_3?.Invoke(this, EventArgs.Empty);
        base.OnTextChanged(EventArgs.Empty);
        vmethod_4();
    }

    private void method_88(GClass84 gclass84_9)
    {
        for (int i = gclass84_9.GStruct10_0.int_1; i <= gclass84_9.GStruct10_1.int_1; i++)
        {
            if (i >= 0 && i < gclass97_0.Count)
            {
                FoldedBlocks.Remove(this[i].UniqueId);
            }
        }
    }

    private void method_89(GClass84 gclass84_9)
    {
        for (int i = gclass84_9.GStruct10_0.int_1; i <= gclass84_9.GStruct10_1.int_1; i++)
        {
            if (i >= 0 && i < gclass97_0.Count)
            {
                gclass97_0[i].IsChanged = true;
            }
        }
    }

    public void vmethod_58()
    {
        if (Boolean_5)
        {
            method_90();
        }
        bool_13 = true;
        method_20(timer_0);
        eventHandler_6?.Invoke(this, new EventArgs());
    }

    private void method_90()
    {
        if (Int32_9 == 0)
        {
            return;
        }
        int num = int_16;
        int num2 = int_10;
        int_16 = -1;
        int_10 = -1;
        int num3 = 0;
        for (int num4 = GClass84_5.GStruct10_0.int_1; num4 >= Math.Max(GClass84_5.GStruct10_0.int_1 - 3000, 0); num4--)
        {
            bool flag = gclass97_0.vmethod_20(num4);
            bool flag2;
            if (!((flag2 = gclass97_0.vmethod_21(num4)) && flag))
            {
                if (flag)
                {
                    num3--;
                    if (num3 == -1)
                    {
                        int_16 = num4;
                        break;
                    }
                }
                if (flag2 && num4 != GClass84_5.GStruct10_0.int_1)
                {
                    num3++;
                }
            }
        }
        if (int_16 >= 0)
        {
            int_10 = vmethod_66(int_16, 3000);
            if (int_10 == int_16)
            {
                int_10 = -1;
            }
        }
        if (int_16 != num || int_10 != num2)
        {
            vmethod_59();
        }
    }

    protected void vmethod_59()
    {
        eventHandler_16?.Invoke(this, EventArgs.Empty);
    }

    protected override void OnGotFocus(EventArgs e)
    {
        method_6();
        base.OnGotFocus(e);
        method_4();
    }

    protected override void OnLostFocus(EventArgs e)
    {
        keys_0 = Keys.None;
        method_136();
        base.OnLostFocus(e);
        method_4();
    }

    public int method_91(GStruct10 gstruct10_0)
    {
        if (gstruct10_0.int_1 >= 0 && gstruct10_0.int_1 < gclass97_0.Count && gstruct10_0.int_0 < gclass97_0[gstruct10_0.int_1].Count + Environment.NewLine.Length)
        {
            int num = 0;
            for (int i = 0; i < gstruct10_0.int_1; i++)
            {
                num += gclass97_0[i].Count + Environment.NewLine.Length;
            }
            return num + gstruct10_0.int_0;
        }
        return -1;
    }

    public GStruct10 method_92(int int_27)
    {
        if (int_27 < 0)
        {
            return new GStruct10(0, 0);
        }
        int num = 0;
        while (true)
        {
            if (num < gclass97_0.Count)
            {
                int num2 = gclass97_0[num].Count + Environment.NewLine.Length;
                if (int_27 >= gclass97_0[num].Count)
                {
                    if (int_27 < num2)
                    {
                        break;
                    }
                    int_27 -= num2;
                    num++;
                    continue;
                }
                return new GStruct10(int_27, num);
            }
            if (gclass97_0.Count > 0)
            {
                return new GStruct10(gclass97_0[gclass97_0.Count - 1].Count, gclass97_0.Count - 1);
            }
            return new GStruct10(0, 0);
        }
        return new GStruct10(gclass97_0[num].Count, num);
    }

    public Point method_93(int int_27)
    {
        return method_94(method_92(int_27));
    }

    public Point method_94(GStruct10 gstruct10_0)
    {
        if (gstruct10_0.int_1 >= list_0.Count)
        {
            return default;
        }
        int num = list_0[gstruct10_0.int_1].int_0;
        int num2 = list_0[gstruct10_0.int_1].method_2(gstruct10_0.int_0);
        num += num2 * Int32_1;
        int num3 = (gstruct10_0.int_0 - list_0[gstruct10_0.int_1].method_0(num2)) * CharWidth;
        if (num2 > 0)
        {
            num3 += list_0[gstruct10_0.int_1].int_2 * CharWidth;
        }
        num -= base.VerticalScroll.Value;
        num3 = LeftIndent + Paddings.Left + num3 - base.HorizontalScroll.Value;
        return new Point(num3, num);
    }

    public GClass84 method_95(int int_27, int int_28)
    {
        return new GClass84(this)
        {
            GStruct10_0 = method_92(int_27),
            GStruct10_1 = method_92(int_28)
        };
    }

    public GClass84 method_96(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        return new GClass84(this, gstruct10_0, gstruct10_1);
    }

    public IEnumerable<GClass84> method_97(string string_3)
    {
        GClass84 gClass = new(this);
        gClass.method_2();
        foreach (GClass84 item in gClass.method_29(string_3, RegexOptions.None))
        {
            yield return item;
        }
    }

    public IEnumerable<GClass84> method_98(string string_3, RegexOptions regexOptions_0)
    {
        GClass84 gClass = new(this);
        gClass.method_2();
        foreach (GClass84 item in gClass.method_29(string_3, regexOptions_0))
        {
            yield return item;
        }
    }

    public string method_99(int int_27)
    {
        if (int_27 >= 0 && int_27 < gclass97_0.Count)
        {
            StringBuilder stringBuilder = new(gclass97_0[int_27].Count);
            foreach (GStruct8 item in gclass97_0[int_27])
            {
                stringBuilder.Append(item.char_0);
            }
            return stringBuilder.ToString();
        }
        throw new ArgumentOutOfRangeException("Line index out of range");
    }

    public void vmethod_60(int int_27)
    {
        if (int_27 >= 0 && int_27 < gclass97_0.Count)
        {
            int i;
            for (i = int_27; i < Int32_9 - 1 && list_0[i + 1].genum10_0 == GEnum10.const_2; i++)
            {
            }
            vmethod_62(int_27, i);
            FoldedBlocks.Remove(this[int_27].UniqueId);
            vmethod_61();
            return;
        }
        throw new ArgumentOutOfRangeException("Line index out of range");
    }

    public void vmethod_61()
    {
        for (int i = 0; i < Int32_9; i++)
        {
            if (list_0[i].genum10_0 == GEnum10.const_0 && FoldedBlocks.ContainsKey(this[i].UniqueId))
            {
                vmethod_65(i);
            }
        }
    }

    public void vmethod_62(int int_27, int int_28)
    {
        int num = Math.Min(int_27, int_28);
        int num2 = Math.Max(int_27, int_28);
        for (int i = num; i <= num2; i++)
        {
            method_128(i, GEnum10.const_0);
        }
        bool_10 = true;
        method_4();
        vmethod_4();
    }

    public void method_100(int int_27)
    {
        if (list_0[int_27].genum10_0 != GEnum10.const_0)
        {
            for (int i = int_27; i < Int32_9 && list_0[i].genum10_0 != GEnum10.const_0; i++)
            {
                method_128(i, GEnum10.const_0);
                bool_10 = true;
            }
            int num = int_27 - 1;
            while (num >= 0 && list_0[num].genum10_0 != GEnum10.const_0)
            {
                method_128(num, GEnum10.const_0);
                bool_10 = true;
                num--;
            }
            method_4();
            vmethod_4();
        }
    }

    public void vmethod_63()
    {
        for (int i = 0; i < Int32_9; i++)
        {
            if (gclass97_0.vmethod_20(i))
            {
                int num = method_101(i);
                if (num >= 0)
                {
                    vmethod_68(i, num);
                    i = num;
                }
            }
        }
        vmethod_4();
        method_47();
    }

    public void vmethod_64()
    {
        for (int i = 0; i < Int32_9; i++)
        {
            method_128(i, GEnum10.const_0);
        }
        FoldedBlocks.Clear();
        vmethod_4();
        method_4();
        method_47();
    }

    public void vmethod_65(int int_27)
    {
        if (int_27 >= 0 && int_27 < gclass97_0.Count)
        {
            if (string.IsNullOrEmpty(gclass97_0[int_27].FoldingStartMarker))
            {
                throw new ArgumentOutOfRangeException("This line is not folding start line");
            }
            int num = method_101(int_27);
            if (num >= 0)
            {
                vmethod_68(int_27, num);
                int uniqueId = this[int_27].UniqueId;
                FoldedBlocks[uniqueId] = uniqueId;
            }
            return;
        }
        throw new ArgumentOutOfRangeException("Line index out of range");
    }

    private int method_101(int int_27)
    {
        return vmethod_66(int_27, int.MaxValue);
    }

    protected int vmethod_66(int int_27, int int_28)
    {
        _ = gclass97_0[int_27].FoldingStartMarker;
        Stack<string> stack = new();
        switch (FindEndOfFoldingBlockStrategy)
        {
            case GEnum7.const_1:
                {
                    for (int i = int_27; i < Int32_9; i++)
                    {
                        if (gclass97_0.vmethod_21(i))
                        {
                            string foldingEndMarker2 = gclass97_0[i].FoldingEndMarker;
                            while (stack.Count > 0 && stack.Pop() != foldingEndMarker2)
                            {
                            }
                            if (stack.Count == 0)
                            {
                                return i;
                            }
                        }
                        if (gclass97_0.vmethod_20(i))
                        {
                            stack.Push(gclass97_0[i].FoldingStartMarker);
                        }
                        int_28--;
                        if (int_28 < 0)
                        {
                            return i;
                        }
                    }
                    break;
                }
            case GEnum7.const_0:
                {
                    for (int i = int_27; i < Int32_9; i++)
                    {
                        if (gclass97_0.vmethod_20(i))
                        {
                            stack.Push(gclass97_0[i].FoldingStartMarker);
                        }
                        if (gclass97_0.vmethod_21(i))
                        {
                            string foldingEndMarker = gclass97_0[i].FoldingEndMarker;
                            while (stack.Count > 0 && stack.Pop() != foldingEndMarker)
                            {
                            }
                            if (stack.Count == 0)
                            {
                                return i;
                            }
                        }
                        int_28--;
                        if (int_28 < 0)
                        {
                            return i;
                        }
                    }
                    break;
                }
        }
        return Int32_9 - 1;
    }

    public string method_102(int int_27)
    {
        if (gclass97_0.vmethod_20(int_27))
        {
            return gclass97_0[int_27].FoldingStartMarker;
        }
        return null;
    }

    public string method_103(int int_27)
    {
        if (gclass97_0.vmethod_21(int_27))
        {
            return gclass97_0[int_27].FoldingEndMarker;
        }
        return null;
    }

    protected void vmethod_67()
    {
        if (!bool_12)
        {
            return;
        }
        bool_12 = false;
        if (!Boolean_3)
        {
            return;
        }
        dictionary_0.Clear();
        GClass84 gClass84_ = GClass84_4;
        int num = Math.Max(gClass84_.GStruct10_0.int_1 - 3000, 0);
        int num2 = Math.Min(gClass84_.GStruct10_1.int_1 + 3000, Math.Max(gClass84_.GStruct10_1.int_1, Int32_9 - 1));
        Stack<int> stack = new();
        for (int i = num; i <= num2; i++)
        {
            bool flag = gclass97_0.vmethod_20(i);
            bool flag2;
            if ((flag2 = gclass97_0.vmethod_21(i)) && flag)
            {
                continue;
            }
            if (flag)
            {
                stack.Push(i);
            }
            if (!flag2)
            {
                continue;
            }
            string foldingEndMarker = gclass97_0[i].FoldingEndMarker;
            while (stack.Count > 0)
            {
                int num3 = stack.Pop();
                dictionary_0[num3] = i;
                if (foldingEndMarker == gclass97_0[num3].FoldingStartMarker)
                {
                    break;
                }
            }
        }
        while (stack.Count > 0)
        {
            dictionary_0[stack.Pop()] = num2 + 1;
        }
    }

    public void vmethod_68(int int_27, int int_28)
    {
        int i = Math.Min(int_27, int_28);
        int num = Math.Max(int_27, int_28);
        if (i == num)
        {
            return;
        }
        for (; i <= num; i++)
        {
            if (method_99(i).Trim().Length > 0)
            {
                for (int j = i + 1; j <= num; j++)
                {
                    method_128(j, GEnum10.const_2);
                }
                method_128(i, GEnum10.const_1);
                method_4();
                break;
            }
        }
        i = Math.Min(int_27, int_28);
        num = Math.Max(int_27, int_28);
        int num2 = method_104(num);
        if (num2 == num)
        {
            num2 = method_105(i);
        }
        GClass84_5.GStruct10_0 = new GStruct10(0, num2);
        bool_10 = true;
        method_4();
        vmethod_4();
    }

    internal int method_104(int int_27)
    {
        if (int_27 >= gclass97_0.Count - 1)
        {
            return int_27;
        }
        int result = int_27;
        do
        {
            int_27++;
        }
        while (int_27 < gclass97_0.Count - 1 && list_0[int_27].genum10_0 != GEnum10.const_0);
        if (list_0[int_27].genum10_0 != GEnum10.const_0)
        {
            return result;
        }
        return int_27;
    }

    internal int method_105(int int_27)
    {
        if (int_27 <= 0)
        {
            return int_27;
        }
        int result = int_27;
        do
        {
            int_27--;
        }
        while (int_27 > 0 && list_0[int_27].genum10_0 != GEnum10.const_0);
        if (list_0[int_27].genum10_0 != GEnum10.const_0)
        {
            return result;
        }
        return int_27;
    }

    private GClass99 method_106(Point point_4)
    {
        foreach (GClass99 item in list_1)
        {
            if (item.rectangle_0.Contains(point_4))
            {
                return item;
            }
        }
        return null;
    }

    public void vmethod_69()
    {
        if (GStruct10.smethod_1(GClass84_5.GStruct10_0, GClass84_5.GStruct10_1))
        {
            if (GClass84_5.Boolean_1)
            {
                return;
            }
            GClass84_5.GStruct10_0 = new GStruct10(this[GClass84_5.GStruct10_0.int_1].Int32_0, GClass84_5.GStruct10_0.int_1);
            int num = TabLength - GClass84_5.GStruct10_0.int_0 % TabLength;
            if (Boolean_6)
            {
                for (int i = 0; i < num; i++)
                {
                    GClass84_5.method_11(bool_1: true);
                }
                GClass84_5.method_41();
            }
            vmethod_20(new string(' ', num));
            return;
        }
        bool flag = GStruct10.smethod_4(GClass84_5.GStruct10_0, GClass84_5.GStruct10_1) && !GClass84_5.Boolean_0;
        int num2 = 0;
        if (GClass84_5.Boolean_0)
        {
            num2 = Math.Min(GClass84_5.GStruct10_1.int_0, GClass84_5.GStruct10_0.int_0);
        }
        method_86();
        GClass84_5.method_38();
        gclass97_0.Manager.method_4();
        GClass84 gClass84_ = GClass84_5.method_6();
        gclass97_0.Manager.vmethod_0(new GClass69(GClass97_0));
        GClass84_5.method_40();
        GClass84 gClass = GClass84_5.method_6();
        int num3 = GClass84_5.GStruct10_0.int_1;
        int num4 = GClass84_5.GStruct10_1.int_1;
        if (!GClass84_5.Boolean_0 && GClass84_5.GStruct10_1.int_0 == 0)
        {
            num4--;
        }
        for (int j = num3; j <= num4; j++)
        {
            if (gclass97_0[j].Count != 0)
            {
                GClass84_5.GStruct10_0 = new GStruct10(num2, j);
                gclass97_0.Manager.vmethod_0(new GClass63(GClass97_0, new string(' ', TabLength)));
            }
        }
        if (!GClass84_5.Boolean_0)
        {
            int num5 = gClass.GStruct10_0.int_0 + TabLength;
            int num6 = gClass.GStruct10_1.int_0 + ((gClass.GStruct10_1.int_1 == num4) ? TabLength : 0);
            GClass84_5.GStruct10_0 = new GStruct10(num5, gClass.GStruct10_0.int_1);
            GClass84_5.GStruct10_1 = new GStruct10(num6, gClass.GStruct10_1.int_1);
        }
        else
        {
            GClass84_5 = gClass84_;
        }
        gclass97_0.Manager.method_3();
        if (flag)
        {
            GClass84_5.method_41();
        }
        bool_10 = true;
        GClass84_5.method_39();
        method_87();
        method_4();
    }

    public void vmethod_70()
    {
        if (GClass84_5.GStruct10_0.int_1 == GClass84_5.GStruct10_1.int_1)
        {
            vmethod_71();
            return;
        }
        int num = 0;
        if (GClass84_5.Boolean_0)
        {
            num = Math.Min(GClass84_5.GStruct10_1.int_0, GClass84_5.GStruct10_0.int_0);
        }
        method_86();
        GClass84_5.method_38();
        gclass97_0.Manager.method_4();
        GClass84 gClass84_ = GClass84_5.method_6();
        gclass97_0.Manager.vmethod_0(new GClass69(GClass97_0));
        GClass84 gClass = GClass84_5.method_6();
        GClass84_5.method_40();
        int num2 = GClass84_5.GStruct10_0.int_1;
        int num3 = GClass84_5.GStruct10_1.int_1;
        if (!GClass84_5.Boolean_0 && GClass84_5.GStruct10_1.int_0 == 0)
        {
            num3--;
        }
        int num4 = 0;
        int num5 = 0;
        for (int i = num2; i <= num3; i++)
        {
            if (num <= gclass97_0[i].Count)
            {
                int num6 = Math.Min(gclass97_0[i].Count, num + TabLength);
                string text = gclass97_0[i].vmethod_0().Substring(num, num6 - num);
                num6 = Math.Min(num6, num + text.Length - text.TrimStart().Length);
                GClass84_5 = new GClass84(this, new GStruct10(num, i), new GStruct10(num6, i));
                int num7 = num6 - num;
                if (i == gClass.GStruct10_0.int_1)
                {
                    num4 = num7;
                }
                if (i == gClass.GStruct10_1.int_1)
                {
                    num5 = num7;
                }
                if (!GClass84_5.vmethod_0())
                {
                    vmethod_28();
                }
            }
        }
        if (!GClass84_5.Boolean_0)
        {
            int num8 = Math.Max(0, gClass.GStruct10_0.int_0 - num4);
            int num9 = Math.Max(0, gClass.GStruct10_1.int_0 - num5);
            GClass84_5.GStruct10_0 = new GStruct10(num8, gClass.GStruct10_0.int_1);
            GClass84_5.GStruct10_1 = new GStruct10(num9, gClass.GStruct10_1.int_1);
        }
        else
        {
            GClass84_5 = gClass84_;
        }
        gclass97_0.Manager.method_3();
        bool_10 = true;
        GClass84_5.method_39();
        method_87();
        method_4();
    }

    protected void vmethod_71()
    {
        if (GClass84_5.GStruct10_0.int_1 == GClass84_5.GStruct10_1.int_1)
        {
            GClass84 gClass = GClass84_5.method_6();
            int i = GClass84_5.GStruct10_0.int_1;
            int num = Math.Min(GClass84_5.GStruct10_0.int_0, GClass84_5.GStruct10_1.int_0);
            string input = gclass97_0[i].vmethod_0();
            Match match = new Regex("\\s*", RegexOptions.RightToLeft).Match(input, num);
            int index = match.Index;
            int length = match.Length;
            int num2 = 0;
            if (length > 0)
            {
                int num3 = ((TabLength > 0) ? (num % TabLength) : 0);
                num2 = ((num3 != 0) ? Math.Min(num3, length) : Math.Min(TabLength, length));
            }
            if (num2 > 0)
            {
                method_86();
                GClass84_5.method_38();
                gclass97_0.Manager.method_4();
                gclass97_0.Manager.vmethod_0(new GClass69(GClass97_0));
                GClass84_5.GStruct10_0 = new GStruct10(index, i);
                GClass84_5.GStruct10_1 = new GStruct10(index + num2, i);
                vmethod_28();
                int num4 = gClass.GStruct10_0.int_0 - num2;
                int num5 = gClass.GStruct10_1.int_0 - num2;
                GClass84_5.GStruct10_0 = new GStruct10(num4, i);
                GClass84_5.GStruct10_1 = new GStruct10(num5, i);
                gclass97_0.Manager.vmethod_0(new GClass69(GClass97_0));
                gclass97_0.Manager.method_3();
                GClass84_5.method_39();
                method_87();
            }
            method_4();
        }
    }

    public void vmethod_72()
    {
        if (!GClass84_5.Boolean_0)
        {
            GClass84 gClass = GClass84_5.method_6();
            gClass.method_40();
            method_86();
            GClass84_5.method_38();
            gclass97_0.Manager.method_4();
            for (int i = gClass.GStruct10_0.int_1; i <= gClass.GStruct10_1.int_1; i++)
            {
                vmethod_44(i);
            }
            gclass97_0.Manager.method_3();
            GClass84_5.GStruct10_0 = gClass.GStruct10_0;
            GClass84_5.GStruct10_1 = gClass.GStruct10_1;
            GClass84_5.method_42();
            GClass84_5.method_39();
            method_87();
        }
    }

    public void vmethod_73(string string_3)
    {
        GClass84_5.method_6();
        int num = Math.Min(GClass84_5.GStruct10_0.int_1, GClass84_5.GStruct10_1.int_1);
        int num2 = Math.Max(GClass84_5.GStruct10_0.int_1, GClass84_5.GStruct10_1.int_1);
        method_86();
        GClass84_5.method_38();
        gclass97_0.Manager.method_4();
        gclass97_0.Manager.vmethod_0(new GClass69(GClass97_0));
        int num3 = method_67(num, num2);
        for (int i = num; i <= num2; i++)
        {
            GClass84_5.GStruct10_0 = new GStruct10(num3, i);
            gclass97_0.Manager.vmethod_0(new GClass63(GClass97_0, string_3));
        }
        GClass84_5.GStruct10_0 = new GStruct10(0, num);
        GClass84_5.GStruct10_1 = new GStruct10(gclass97_0[num2].Count, num2);
        bool_10 = true;
        gclass97_0.Manager.method_3();
        GClass84_5.method_39();
        method_87();
        method_4();
    }

    public void vmethod_74(string string_3)
    {
        GClass84_5.method_6();
        int num = Math.Min(GClass84_5.GStruct10_0.int_1, GClass84_5.GStruct10_1.int_1);
        int num2 = Math.Max(GClass84_5.GStruct10_0.int_1, GClass84_5.GStruct10_1.int_1);
        method_86();
        GClass84_5.method_38();
        gclass97_0.Manager.method_4();
        gclass97_0.Manager.vmethod_0(new GClass69(GClass97_0));
        for (int i = num; i <= num2; i++)
        {
            string text = gclass97_0[i].vmethod_0();
            string text2 = text.TrimStart();
            if (text2.StartsWith(string_3))
            {
                int num3 = text.Length - text2.Length;
                GClass84_5.GStruct10_0 = new GStruct10(num3, i);
                GClass84_5.GStruct10_1 = new GStruct10(num3 + string_3.Length, i);
                vmethod_28();
            }
        }
        GClass84_5.GStruct10_0 = new GStruct10(0, num);
        GClass84_5.GStruct10_1 = new GStruct10(gclass97_0[num2].Count, num2);
        bool_10 = true;
        gclass97_0.Manager.method_3();
        GClass84_5.method_39();
        method_87();
    }

    public void method_107()
    {
        gclass97_0.Manager.method_4();
    }

    public void method_108()
    {
        gclass97_0.Manager.method_3();
    }

    public void vmethod_75(MouseEventArgs mouseEventArgs_0, GClass103 gclass103_0)
    {
        eventHandler_11?.Invoke(this, new GEventArgs15(gclass103_0.Style, gclass103_0, mouseEventArgs_0));
        gclass103_0.Style.vmethod_1(this, new GEventArgs15(gclass103_0.Style, gclass103_0, mouseEventArgs_0));
    }

    protected void vmethod_76(MouseEventArgs mouseEventArgs_0, GClass99 gclass99_0)
    {
        if (gclass99_0 is GClass103)
        {
            vmethod_75(mouseEventArgs_0, gclass99_0 as GClass103);
        }
        else if (gclass99_0 is GClass100)
        {
            vmethod_65((gclass99_0 as GClass100).int_0);
        }
        else if (gclass99_0 is GClass101)
        {
            vmethod_60((gclass99_0 as GClass101).int_0);
        }
        else if (gclass99_0 is GClass102)
        {
            int int_ = (gclass99_0 as GClass102).int_0;
            int num = method_101(int_);
            if (num >= 0)
            {
                GClass84_5.method_38();
                GClass84_5.GStruct10_0 = new GStruct10(0, int_);
                GClass84_5.GStruct10_1 = new GStruct10(gclass97_0[num].Count, num);
                GClass84_5.method_39();
                method_4();
            }
        }
    }

    protected void vmethod_77(GClass99 gclass99_0)
    {
        if (gclass99_0 is GClass102)
        {
            vmethod_60((gclass99_0 as GClass102).int_0);
            method_4();
        }
    }

    private void method_109()
    {
        gclass84_2 = null;
        gclass84_4 = null;
        gclass84_3 = null;
        gclass84_5 = null;
    }

    private void method_110(char char_5, char char_6, ref GClass84 gclass84_9, ref GClass84 gclass84_10)
    {
        switch (BracketsHighlightStrategy)
        {
            case BracketsHighlightStrategy.Strategy2:
                method_113(char_5, char_6, ref gclass84_9, ref gclass84_10);
                break;
            case BracketsHighlightStrategy.Strategy1:
                method_111(char_5, char_6, ref gclass84_9, ref gclass84_10);
                break;
        }
    }

    private void method_111(char char_5, char char_6, ref GClass84 gclass84_9, ref GClass84 gclass84_10)
    {
        if (GClass84_5.vmethod_0() && Int32_9 != 0)
        {
            GClass84 obj = gclass84_9;
            GClass84 gClass = gclass84_10;
            GClass84 gClass2 = method_112(GClass84_5.GStruct10_0, char_5, char_6, bool_37: true);
            if (gClass2 != null)
            {
                gclass84_9 = new GClass84(this, gClass2.GStruct10_0, new GStruct10(gClass2.GStruct10_0.int_0 + 1, gClass2.GStruct10_0.int_1));
                gclass84_10 = new GClass84(this, new GStruct10(gClass2.GStruct10_1.int_0 - 1, gClass2.GStruct10_1.int_1), gClass2.GStruct10_1);
            }
            if (obj != gclass84_9 || gClass != gclass84_10)
            {
                method_4();
            }
        }
    }

    public GClass84 method_112(GStruct10 gstruct10_0, char char_5, char char_6, bool bool_37)
    {
        GClass84 gClass = new(this, gstruct10_0, gstruct10_0);
        GClass84 gClass2 = gClass.method_6();
        GClass84 gClass3 = null;
        GClass84 gClass4 = null;
        int num = 0;
        int num2 = 1000;
        while (gClass2.method_9())
        {
            if (gClass2.Char_0 == char_5)
            {
                num++;
            }
            if (gClass2.Char_0 == char_6)
            {
                num--;
            }
            if (num != 1)
            {
                num2--;
                if (num2 <= 0)
                {
                    break;
                }
                continue;
            }
            gClass2.GStruct10_0 = new GStruct10(gClass2.GStruct10_0.int_0 + ((!bool_37) ? 1 : 0), gClass2.GStruct10_0.int_1);
            gClass3 = gClass2;
            break;
        }
        gClass2 = gClass.method_6();
        num = 0;
        num2 = 1000;
        do
        {
            if (gClass2.Char_0 == char_5)
            {
                num++;
            }
            if (gClass2.Char_0 == char_6)
            {
                num--;
            }
            if (num != -1)
            {
                num2--;
                continue;
            }
            gClass2.GStruct10_1 = new GStruct10(gClass2.GStruct10_0.int_0 + (bool_37 ? 1 : 0), gClass2.GStruct10_0.int_1);
            gClass4 = gClass2;
            break;
        }
        while (num2 > 0 && gClass2.vmethod_3());
        if (gClass3 != null && gClass4 != null)
        {
            return new GClass84(this, gClass3.GStruct10_0, gClass4.GStruct10_1);
        }
        return null;
    }

    private void method_113(char char_5, char char_6, ref GClass84 gclass84_9, ref GClass84 gclass84_10)
    {
        if (!GClass84_5.vmethod_0() || Int32_9 == 0)
        {
            return;
        }
        GClass84 gClass = gclass84_9;
        GClass84 gClass2 = gclass84_10;
        GClass84 gClass3 = GClass84_5.method_6();
        bool flag = false;
        int num = 0;
        int num2 = 1000;
        if (gClass3.Char_1 == char_6)
        {
            gclass84_10 = new GClass84(this, gClass3.GStruct10_0.int_0 - 1, gClass3.GStruct10_0.int_1, gClass3.GStruct10_0.int_0, gClass3.GStruct10_0.int_1);
            while (gClass3.method_9())
            {
                if (gClass3.Char_0 == char_5)
                {
                    num++;
                }
                if (gClass3.Char_0 == char_6)
                {
                    num--;
                }
                if (num != 0)
                {
                    num2--;
                    if (num2 <= 0)
                    {
                        break;
                    }
                    continue;
                }
                gClass3.GStruct10_1 = new GStruct10(gClass3.GStruct10_0.int_0 + 1, gClass3.GStruct10_0.int_1);
                gclass84_9 = gClass3;
                flag = true;
                break;
            }
        }
        gClass3 = GClass84_5.method_6();
        num = 0;
        num2 = 1000;
        if (!flag && gClass3.Char_0 == char_5)
        {
            gclass84_9 = new GClass84(this, gClass3.GStruct10_0.int_0, gClass3.GStruct10_0.int_1, gClass3.GStruct10_0.int_0 + 1, gClass3.GStruct10_0.int_1);
            do
            {
                if (gClass3.Char_0 == char_5)
                {
                    num++;
                }
                if (gClass3.Char_0 == char_6)
                {
                    num--;
                }
                if (num != 0)
                {
                    num2--;
                    continue;
                }
                gClass3.GStruct10_1 = new GStruct10(gClass3.GStruct10_0.int_0 + 1, gClass3.GStruct10_0.int_1);
                gclass84_10 = gClass3;
                break;
            }
            while (num2 > 0 && gClass3.vmethod_3());
        }
        if (gClass != gclass84_9 || gClass2 != gclass84_10)
        {
            method_4();
        }
    }

    public bool method_114(string string_3, bool bool_37 = false, RegexOptions regexOptions_0 = RegexOptions.None)
    {
        GClass84 gClass = GClass84_5.method_6();
        gClass.method_40();
        GClass84 obj = (bool_37 ? new GClass84(this, GClass84_6.GStruct10_0, gClass.GStruct10_0) : new GClass84(this, gClass.GStruct10_1, GClass84_6.GStruct10_1));
        GClass84 gClass2 = null;
        foreach (GClass84 item in obj.method_29(string_3, regexOptions_0))
        {
            gClass2 = item;
            if (!bool_37)
            {
                break;
            }
        }
        if (gClass2 == null)
        {
            return false;
        }
        GClass84_5 = gClass2;
        method_4();
        return true;
    }

    public void vmethod_78(GEventArgs5 geventArgs5_0)
    {
        GClass84 gClass = HighlightingRangeType switch
        {
            GEnum6.const_2 => GClass84_6,
            GEnum6.const_1 => GClass84_4.method_1(geventArgs5_0.ChangedRange),
            _ => geventArgs5_0.ChangedRange,
        };
        if (SyntaxHighlighter != null)
        {
            if (GEnum13_0 == GEnum13.const_0 && !string.IsNullOrEmpty(String_1))
            {
                SyntaxHighlighter.vmethod_1(String_1, gClass);
            }
            else
            {
                SyntaxHighlighter.vmethod_0(GEnum13_0, gClass);
            }
        }
    }

    private void method_115()
    {
        SuspendLayout();
        base.Name = "FastColoredTextBox";
        ResumeLayout(performLayout: false);
    }

    public void vmethod_79(GClass84 gclass84_9, GClass75 gclass75_0)
    {
        GClass72 gClass = new()
        {
            UseBr = true,
            UseForwardNbsp = true,
            UseNbsp = true,
            UseStyleTag = false,
            IncludeLineNumbers = gclass75_0.IncludeLineNumbers
        };
        gclass84_9 ??= GClass84_6;
        if (gclass84_9.vmethod_2() == string.Empty)
        {
            return;
        }
        gclass84_7 = gclass84_9;
        try
        {
            eventHandler_7?.Invoke(this, new EventArgs());
            eventHandler_10?.Invoke(this, new EventArgs());
        }
        finally
        {
            gclass84_7 = null;
        }
        string text = gClass.method_1(gclass84_9);
        text = "<META HTTP-EQUIV=\"Content-Type\" CONTENT=\"text/html; charset=UTF-8\"><head><title>" + vmethod_80(gclass75_0.Title) + "</title></head>" + text + "<br>" + method_119();
        string text2 = Path.GetTempPath() + "fctb.html";
        File.WriteAllText(text2, text);
        smethod_5(gclass75_0);
        WebBrowser webBrowser = new()
        {
            Tag = gclass75_0,
            Visible = false,
            Location = new Point(-1000, -1000),
            Parent = this
        };
        webBrowser.StatusTextChanged += method_116;
        webBrowser.Navigate(text2);
    }

    protected string vmethod_80(string string_3)
    {
        return string_3.Replace("<", "&lt;").Replace(">", "&gt;").Replace("&", "&amp;");
    }

    private void method_116(object sender, EventArgs e)
    {
        WebBrowser webBrowser = sender as WebBrowser;
        if (!webBrowser.StatusText.Contains("#print"))
        {
            return;
        }
        GClass75 gClass = webBrowser.Tag as GClass75;
        try
        {
            if (gClass.ShowPrintPreviewDialog)
            {
                webBrowser.ShowPrintPreviewDialog();
                return;
            }
            if (gClass.ShowPageSetupDialog)
            {
                webBrowser.ShowPageSetupDialog();
            }
            if (gClass.ShowPrintDialog)
            {
                webBrowser.ShowPrintDialog();
            }
            else
            {
                webBrowser.Print();
            }
        }
        finally
        {
            webBrowser.Parent = null;
            webBrowser.Dispose();
        }
    }

    public void method_117(GClass75 gclass75_0)
    {
        vmethod_79(GClass84_6, gclass75_0);
    }

    public void method_118()
    {
        vmethod_79(GClass84_6, new GClass75
        {
            ShowPageSetupDialog = false,
            ShowPrintDialog = false,
            ShowPrintPreviewDialog = false
        });
    }

    private string method_119()
    {
        GClass84 gClass = GClass84_5.method_6();
        gClass.method_40();
        int num = method_91(gClass.GStruct10_0) - gClass.GStruct10_0.int_1;
        int num2 = gClass.vmethod_2().Length - (gClass.GStruct10_1.int_1 - gClass.GStruct10_0.int_1);
        return $"<script type=\"text/javascript\">\ntry{{\n    var sel = document.selection;\n    var rng = sel.createRange();\n    rng.moveStart(\"character\", {num});\n    rng.moveEnd(\"character\", {num2});\n    rng.select();\n}}catch(ex){{}}\nwindow.status = \"#print\";\n</script>";
    }

    private static void smethod_5(GClass75 gclass75_0)
    {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\PageSetup", writable: true);
        if (registryKey != null)
        {
            registryKey.SetValue("footer", gclass75_0.Footer);
            registryKey.SetValue("header", gclass75_0.Header);
        }
    }

    protected void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (disposing)
        {
            SyntaxHighlighter?.Dispose();
            timer_0.Dispose();
            timer_1.Dispose();
            timer_3.Dispose();
            findForm?.Dispose();
            replaceForm?.Dispose();
            GClass97_0?.Dispose();
            ToolTip?.Dispose();
        }
    }

    protected void vmethod_81(GEventArgs2 geventArgs2_0)
    {
        eventHandler_13?.Invoke(this, geventArgs2_0);
    }

    internal void method_120(int int_27)
    {
        method_121(int_27, 1);
    }

    internal void method_121(int int_27, int int_28)
    {
        eventHandler_14?.Invoke(this, new GEventArgs3(int_27, int_28));
    }

    internal void method_122(int int_27, int int_28, List<int> list_3)
    {
        if (int_28 > 0 && eventHandler_15 != null)
        {
            eventHandler_15(this, new GEventArgs4(int_27, int_28, list_3));
        }
    }

    public void method_123(string string_3, Encoding encoding_0)
    {
        GClass97 gclass97_ = vmethod_6();
        try
        {
            vmethod_7(gclass97_);
            Text = File.ReadAllText(string_3, encoding_0);
            method_31();
            Boolean_1 = false;
            vmethod_4();
        }
        catch
        {
            vmethod_7(vmethod_6());
            gclass97_0.vmethod_7(0, GClass97_0.vmethod_1());
            Boolean_1 = false;
            throw;
        }
        GClass84_5.GStruct10_0 = GStruct10.GStruct10_0;
        method_50();
    }

    public void method_124(string string_3)
    {
        try
        {
            Encoding encoding = GClass71.smethod_0(string_3);
            if (encoding != null)
            {
                method_123(string_3, encoding);
            }
            else
            {
                method_123(string_3, Encoding.Default);
            }
        }
        catch
        {
            vmethod_7(vmethod_6());
            gclass97_0.vmethod_7(0, GClass97_0.vmethod_1());
            Boolean_1 = false;
            throw;
        }
    }

    public void method_125(string string_3, Encoding encoding_0)
    {
        GClass98 gClass = new(this);
        try
        {
            vmethod_7(gClass);
            gClass.method_2(string_3, encoding_0);
            Boolean_1 = false;
            vmethod_4();
        }
        catch
        {
            gClass.method_4();
            vmethod_7(vmethod_6());
            gclass97_0.vmethod_7(0, GClass97_0.vmethod_1());
            Boolean_1 = false;
            throw;
        }
        method_4();
    }

    public void method_126()
    {
        if (gclass97_0 is GClass98)
        {
            (gclass97_0 as GClass98).method_4();
            vmethod_7(vmethod_6());
            gclass97_0.vmethod_7(0, GClass97_0.vmethod_1());
            Boolean_1 = false;
            method_4();
        }
    }

    public void method_127(string string_3, Encoding encoding_0)
    {
        gclass97_0.vmethod_22(string_3, encoding_0);
        Boolean_1 = false;
        vmethod_4();
        method_47();
    }

    public void method_128(int int_27, GEnum10 genum10_0)
    {
        GStruct9 value = list_0[int_27];
        value.genum10_0 = genum10_0;
        list_0[int_27] = value;
        bool_10 = true;
    }

    public GEnum10 method_129(int int_27)
    {
        return list_0[int_27].genum10_0;
    }

    public void method_130()
    {
        GoToForm goToForm = new()
        {
            TotalLineCount = Int32_9,
            SelectedLineNumber = GClass84_5.GStruct10_0.int_1 + 1
        };
        if (goToForm.ShowDialog() == DialogResult.OK)
        {
            int num = Math.Min(Int32_9 - 1, Math.Max(0, goToForm.SelectedLineNumber - 1));
            GClass84_5 = new GClass84(this, 0, num, 0, num);
            method_50();
        }
    }

    public void method_131()
    {
        eventHandler_17?.Invoke(this, EventArgs.Empty);
    }

    public List<int> method_132(string string_3, RegexOptions regexOptions_0)
    {
        List<int> list = [];
        foreach (GClass84 item in GClass84_6.method_30(string_3, regexOptions_0))
        {
            list.Add(item.GStruct10_0.int_1);
        }
        return list;
    }

    public void method_133(List<int> list_3)
    {
        GClass97_0.Manager.vmethod_0(new GClass67(GClass97_0, list_3));
        if (list_3.Count > 0)
        {
            Boolean_1 = true;
        }
        if (Int32_9 == 0)
        {
            Text = "";
        }
        method_10();
        method_4();
    }

    void ISupportInitialize.BeginInit()
    {
    }

    void ISupportInitialize.EndInit()
    {
        vmethod_54();
        GClass84_5.GStruct10_0 = GStruct10.GStruct10_0;
        method_48();
        Boolean_1 = false;
        method_31();
    }

    protected override void OnDragEnter(DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.Text) && AllowDrop)
        {
            e.Effect = DragDropEffects.Copy;
            IsDragDrop = true;
        }
        base.OnDragEnter(e);
    }

    protected override void OnDragDrop(DragEventArgs e)
    {
        if (!ReadOnly && AllowDrop)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                base.ParentForm?.Activate();
                Focus();
                Point point_ = PointToClient(new Point(e.X, e.Y));
                string string_ = e.Data.GetData(DataFormats.Text).ToString();
                GStruct10 gstruct10_ = method_83(point_);
                vmethod_82(gstruct10_, string_);
                IsDragDrop = false;
            }
            base.OnDragDrop(e);
        }
        else
        {
            IsDragDrop = false;
        }
    }

    private void method_134(GStruct10 gstruct10_0, string string_3)
    {
        GClass84 gClass = new(this, gstruct10_0, gstruct10_0);
        if (gClass.Boolean_1 || (gclass84_8 != null && gclass84_8.method_0(gstruct10_0)))
        {
            return;
        }
        bool flag = gclass84_8 == null || gclass84_8.Boolean_1 || (Control.ModifierKeys & Keys.Control) != 0;
        if (gclass84_8 == null)
        {
            GClass84_5.method_38();
            GClass84_5.GStruct10_0 = gstruct10_0;
            vmethod_20(string_3);
            GClass84_5 = new GClass84(this, gstruct10_0, GClass84_5.GStruct10_0);
            GClass84_5.method_39();
            return;
        }
        method_107();
        GClass84_5.method_38();
        GClass84_5 = gclass84_8;
        gclass97_0.Manager.vmethod_0(new GClass69(gclass97_0));
        if (gclass84_8.Boolean_0)
        {
            gclass84_8.method_40();
            gClass = new GClass84(this, gstruct10_0, new GStruct10(gstruct10_0.int_0, gstruct10_0.int_1 + gclass84_8.GStruct10_1.int_1 - gclass84_8.GStruct10_0.int_1))
            {
                Boolean_0 = true
            };
            for (int i = Int32_9; i <= gClass.GStruct10_1.int_1; i++)
            {
                GClass84_5.method_51(bool_1: false);
                vmethod_27('\n');
            }
        }
        if (!gClass.Boolean_1)
        {
            GStruct10 gStruct10_;
            if (GStruct10.smethod_2(gstruct10_0, gclass84_8.GStruct10_0))
            {
                if (!flag)
                {
                    GClass84_5 = gclass84_8;
                    vmethod_28();
                }
                GClass84_5 = gClass;
                GClass84_5.Boolean_0 = gClass.Boolean_0;
                vmethod_20(string_3);
                gStruct10_ = GClass84_5.GStruct10_0;
            }
            else
            {
                GClass84_5 = gClass;
                GClass84_5.Boolean_0 = gClass.Boolean_0;
                vmethod_20(string_3);
                gStruct10_ = GClass84_5.GStruct10_0;
                int count = this[gStruct10_.int_1].Count;
                if (!flag)
                {
                    GClass84_5 = gclass84_8;
                    vmethod_28();
                }
                int num = count - this[gStruct10_.int_1].Count;
                gStruct10_.int_0 -= num;
                gstruct10_0.int_0 -= num;
            }
            if (!gclass84_8.Boolean_0)
            {
                GClass84_5 = new GClass84(this, gstruct10_0, gStruct10_);
            }
            else
            {
                gclass84_8.method_40();
                GClass84_5 = new GClass84(this, gstruct10_0, new GStruct10(gstruct10_0.int_0 + gclass84_8.GStruct10_1.int_0 - gclass84_8.GStruct10_0.int_0, gstruct10_0.int_1 + gclass84_8.GStruct10_1.int_1 - gclass84_8.GStruct10_0.int_1))
                {
                    Boolean_0 = true
                };
            }
        }
        GClass84_5.method_39();
        method_108();
        gclass84_8 = null;
    }

    protected void vmethod_82(GStruct10 gstruct10_0, string string_3)
    {
        GClass84 gClass = new(this, gstruct10_0, gstruct10_0);
        if (gClass.Boolean_1 || (gclass84_8 != null && gclass84_8.method_0(gstruct10_0)))
        {
            return;
        }
        bool flag = gclass84_8 == null || gclass84_8.Boolean_1 || (Control.ModifierKeys & Keys.Control) != 0;
        if (gclass84_8 == null)
        {
            GClass84_5.method_38();
            GClass84_5.GStruct10_0 = gstruct10_0;
            vmethod_20(string_3);
            GClass84_5 = new GClass84(this, gstruct10_0, GClass84_5.GStruct10_0);
            GClass84_5.method_39();
        }
        else
        {
            if (!gclass84_8.method_0(gstruct10_0))
            {
                method_107();
                GClass84_5 = gclass84_8;
                gclass97_0.Manager.vmethod_0(new GClass69(gclass97_0));
                if (gclass84_8.Boolean_0)
                {
                    gclass84_8.method_40();
                    gClass = new GClass84(this, gstruct10_0, new GStruct10(gstruct10_0.int_0, gstruct10_0.int_1 + gclass84_8.GStruct10_1.int_1 - gclass84_8.GStruct10_0.int_1))
                    {
                        Boolean_0 = true
                    };
                    for (int i = Int32_9; i <= gClass.GStruct10_1.int_1; i++)
                    {
                        GClass84_5.method_51(bool_1: false);
                        vmethod_27('\n');
                    }
                }
                if (!gClass.Boolean_1)
                {
                    if (GStruct10.smethod_2(gstruct10_0, gclass84_8.GStruct10_0))
                    {
                        if (!flag)
                        {
                            GClass84_5 = gclass84_8;
                            vmethod_28();
                        }
                        GClass84_5 = gClass;
                        GClass84_5.Boolean_0 = gClass.Boolean_0;
                        vmethod_20(string_3);
                    }
                    else
                    {
                        GClass84_5 = gClass;
                        GClass84_5.Boolean_0 = gClass.Boolean_0;
                        vmethod_20(string_3);
                        if (!flag)
                        {
                            GClass84_5 = gclass84_8;
                            vmethod_28();
                        }
                    }
                }
                GStruct10 gstruct10_1 = gstruct10_0;
                GStruct10 gstruct10_2 = GClass84_5.GStruct10_0;
                GClass84 gClass2 = (GStruct10.smethod_4(gclass84_8.GStruct10_1, gclass84_8.GStruct10_0) ? method_96(gclass84_8.GStruct10_0, gclass84_8.GStruct10_1) : method_96(gclass84_8.GStruct10_1, gclass84_8.GStruct10_0));
                GStruct10 gStruct = gstruct10_0;
                if (GStruct10.smethod_4(gstruct10_0, gclass84_8.GStruct10_0) && !flag && !gclass84_8.Boolean_0)
                {
                    int num;
                    int num2;
                    if (gClass2.GStruct10_0.int_1 != gClass2.GStruct10_1.int_1)
                    {
                        num = ((gClass2.GStruct10_1.int_1 != gStruct.int_1) ? gStruct.int_0 : (gClass2.GStruct10_0.int_0 + (gStruct.int_0 - gClass2.GStruct10_1.int_0)));
                        num2 = gClass2.GStruct10_1.int_0;
                    }
                    else if (gClass2.GStruct10_1.int_1 == gStruct.int_1)
                    {
                        num = gStruct.int_0 - gClass2.vmethod_2().Length;
                        num2 = gStruct.int_0;
                    }
                    else
                    {
                        num = gStruct.int_0;
                        num2 = gStruct.int_0 + gClass2.vmethod_2().Length;
                    }
                    int num3;
                    int num4;
                    if (gClass2.GStruct10_1.int_1 != gStruct.int_1)
                    {
                        num3 = gStruct.int_1 - (gClass2.GStruct10_1.int_1 - gClass2.GStruct10_0.int_1);
                        num4 = gStruct.int_1;
                    }
                    else
                    {
                        num3 = gClass2.GStruct10_0.int_1;
                        num4 = gClass2.GStruct10_1.int_1;
                    }
                    gstruct10_1 = new GStruct10(num, num3);
                    gstruct10_2 = new GStruct10(num2, num4);
                }
                if (!gclass84_8.Boolean_0)
                {
                    GClass84_5 = new GClass84(this, gstruct10_1, gstruct10_2);
                }
                else
                {
                    int num;
                    int num2;
                    if (!flag && gstruct10_0.int_1 >= gClass2.GStruct10_0.int_1 && gstruct10_0.int_1 <= gClass2.GStruct10_1.int_1 && gstruct10_0.int_0 >= gClass2.GStruct10_1.int_0)
                    {
                        num = gStruct.int_0 - (gClass2.GStruct10_1.int_0 - gClass2.GStruct10_0.int_0);
                        num2 = gStruct.int_0;
                    }
                    else
                    {
                        num = gStruct.int_0;
                        num2 = gStruct.int_0 + (gClass2.GStruct10_1.int_0 - gClass2.GStruct10_0.int_0);
                    }
                    int num3 = gStruct.int_1;
                    int num4 = gStruct.int_1 + (gClass2.GStruct10_1.int_1 - gClass2.GStruct10_0.int_1);
                    gstruct10_1 = new GStruct10(num, num3);
                    gstruct10_2 = new GStruct10(num2, num4);
                    GClass84_5 = new GClass84(this, gstruct10_1, gstruct10_2)
                    {
                        Boolean_0 = true
                    };
                }
                method_108();
            }
            gclass84_0.method_41();
            vmethod_58();
        }
        gclass84_8 = null;
    }

    protected override void OnDragOver(DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.Text))
        {
            Point point_ = PointToClient(new Point(e.X, e.Y));
            GClass84_5.GStruct10_0 = method_83(point_);
            if (point_.Y < 6 && base.VerticalScroll.Visible && base.VerticalScroll.Value > 0)
            {
                base.VerticalScroll.Value = Math.Max(0, base.VerticalScroll.Value - int_9);
            }
            method_48();
            method_4();
        }
        base.OnDragOver(e);
    }

    protected override void OnDragLeave(EventArgs e)
    {
        IsDragDrop = false;
        base.OnDragLeave(e);
    }

    private void method_135(MouseEventArgs mouseEventArgs_0)
    {
        if (!bool_36 && (base.HorizontalScroll.Visible || base.VerticalScroll.Visible || !Boolean_9))
        {
            bool_36 = true;
            point_2 = mouseEventArgs_0.Location;
            point_3 = new Point(base.HorizontalScroll.Value, base.VerticalScroll.Value);
            timer_3.Interval = 50;
            timer_3.Enabled = true;
            base.Capture = true;
            Refresh();
            SendMessage(base.Handle, 11, 0, 0);
        }
    }

    private void method_136()
    {
        if (bool_36)
        {
            bool_36 = false;
            timer_3.Enabled = false;
            base.Capture = false;
            base.Cursor = cursor_0;
            SendMessage(base.Handle, 11, 1, 0);
            method_4();
        }
    }

    private void method_137()
    {
        ScrollEventArgs se = new(ScrollEventType.ThumbPosition, base.HorizontalScroll.Value, point_3.X, ScrollOrientation.HorizontalScroll);
        OnScroll(se);
        ScrollEventArgs se2 = new(ScrollEventType.ThumbPosition, base.VerticalScroll.Value, point_3.Y, ScrollOrientation.VerticalScroll);
        OnScroll(se2);
    }

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr intptr_1, int int_27, int int_28, int int_29);

    private void timer_3_Tick(object sender, EventArgs e)
    {
        if (base.IsDisposed || !bool_36)
        {
            return;
        }
        Point point = PointToClient(Cursor.Position);
        base.Capture = true;
        int num = point_2.X - point.X;
        int num2 = point_2.Y - point.Y;
        if (!base.VerticalScroll.Visible && Boolean_9)
        {
            num2 = 0;
        }
        if (!base.HorizontalScroll.Visible && Boolean_9)
        {
            num = 0;
        }
        double num3 = 180.0 - Math.Atan2(num2, num) * 180.0 / Math.PI;
        if (Math.Sqrt(Math.Pow(num, 2.0) + Math.Pow(num2, 2.0)) > 10.0)
        {
            if (!(num3 >= 325.0) && num3 > 35.0)
            {
                if (num3 <= 55.0)
                {
                    genum9_0 = GEnum9.flag_2 | GEnum9.flag_3;
                }
                else if (num3 <= 125.0)
                {
                    genum9_0 = GEnum9.flag_3;
                }
                else if (num3 <= 145.0)
                {
                    genum9_0 = GEnum9.flag_1 | GEnum9.flag_3;
                }
                else if (num3 <= 215.0)
                {
                    genum9_0 = GEnum9.flag_1;
                }
                else if (num3 <= 235.0)
                {
                    genum9_0 = GEnum9.flag_1 | GEnum9.flag_4;
                }
                else if (num3 <= 305.0)
                {
                    genum9_0 = GEnum9.flag_4;
                }
                else
                {
                    genum9_0 = GEnum9.flag_2 | GEnum9.flag_4;
                }
            }
            else
            {
                genum9_0 = GEnum9.flag_2;
            }
        }
        else
        {
            genum9_0 = GEnum9.flag_0;
        }
        switch (genum9_0)
        {
            case GEnum9.flag_1:
                base.Cursor = Cursors.PanWest;
                break;
            case GEnum9.flag_2:
                base.Cursor = Cursors.PanEast;
                break;
            case GEnum9.flag_3:
                base.Cursor = Cursors.PanNorth;
                break;
            case GEnum9.flag_1 | GEnum9.flag_3:
                base.Cursor = Cursors.PanNW;
                break;
            case GEnum9.flag_2 | GEnum9.flag_3:
                base.Cursor = Cursors.PanNE;
                break;
            default:
                base.Cursor = cursor_0;
                return;
            case GEnum9.flag_4:
                base.Cursor = Cursors.PanSouth;
                break;
            case GEnum9.flag_1 | GEnum9.flag_4:
                base.Cursor = Cursors.PanSW;
                break;
            case GEnum9.flag_2 | GEnum9.flag_4:
                base.Cursor = Cursors.PanSE;
                break;
        }
        int num4 = (int)((double)(-num) / 5.0);
        int num5 = (int)((double)(-num2) / 5.0);
        ScrollEventArgs se = new((num4 < 0) ? ScrollEventType.SmallIncrement : ScrollEventType.SmallDecrement, base.HorizontalScroll.Value, base.HorizontalScroll.Value + num4, ScrollOrientation.HorizontalScroll);
        ScrollEventArgs scrollEventArgs_ = new((num5 >= 0) ? ScrollEventType.SmallIncrement : ScrollEventType.SmallDecrement, base.VerticalScroll.Value, base.VerticalScroll.Value + num5, ScrollOrientation.VerticalScroll);
        if ((int)(genum9_0 & (GEnum9.flag_3 | GEnum9.flag_4)) > 0)
        {
            method_37(scrollEventArgs_, bool_37: false);
        }
        if ((int)(genum9_0 & (GEnum9.flag_1 | GEnum9.flag_2)) > 0)
        {
            OnScroll(se);
        }
        SendMessage(base.Handle, 11, 1, 0);
        Refresh();
        SendMessage(base.Handle, 11, 0, 0);
    }

    private void method_138(Graphics graphics_0)
    {
        bool flag = base.VerticalScroll.Visible || !Boolean_9;
        bool flag2 = base.HorizontalScroll.Visible || !Boolean_9;
        using SolidBrush solidBrush = new(Color.FromArgb(100, (byte)(~BackColor.R), (byte)(~BackColor.G), (byte)(~BackColor.B)));
        Point point = point_2;
        GraphicsState gstate = graphics_0.Save();
        graphics_0.SmoothingMode = SmoothingMode.HighQuality;
        graphics_0.TranslateTransform(point.X, point.Y);
        graphics_0.FillEllipse(solidBrush, -2, -2, 4, 4);
        if (flag)
        {
            method_139(graphics_0, solidBrush);
        }
        graphics_0.RotateTransform(90f);
        if (flag2)
        {
            method_139(graphics_0, solidBrush);
        }
        graphics_0.RotateTransform(90f);
        if (flag)
        {
            method_139(graphics_0, solidBrush);
        }
        graphics_0.RotateTransform(90f);
        if (flag2)
        {
            method_139(graphics_0, solidBrush);
        }
        graphics_0.Restore(gstate);
    }

    private void method_139(Graphics graphics_0, Brush brush_1)
    {
        Point[] points =
        [
            new(5, 10),
            new(0, 15),
            new(-5, 10)
        ];
        graphics_0.FillPolygon(brush_1, points);
    }
}
