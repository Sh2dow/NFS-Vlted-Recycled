using System.Runtime.CompilerServices;

namespace VaultEditor;

public abstract class GClass5
{
    public abstract class GClass8
    {
        [CompilerGenerated]
        private string string_0;

        [CompilerGenerated]
        private string string_1;

        public string FullName
        {
            [CompilerGenerated]
            get
            {
                return string_0;
            }
            [CompilerGenerated]
            set
            {
                string_0 = value;
            }
        }

        public string Name
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

        internal GClass8()
        {
        }

        internal GClass8(GClass5 gclass5_0)
        {
            FullName = gclass5_0.FullName;
            Name = gclass5_0.Name;
        }

        internal abstract GClass5 vmethod_0();

        public GClass5 method_0()
        {
            return vmethod_0();
        }
    }

    [CompilerGenerated]
    private readonly string string_0;

    [CompilerGenerated]
    private readonly string string_1;

    public string FullName
    {
        [CompilerGenerated]
        get
        {
            return string_0;
        }
    }

    public string Name
    {
        [CompilerGenerated]
        get
        {
            return string_1;
        }
    }

    internal GClass5(string string_2, string string_3)
    {
        string_0 = string_2;
        string_1 = string_3;
    }
}
