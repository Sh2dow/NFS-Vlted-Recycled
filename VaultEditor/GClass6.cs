using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass6(string string_2, string string_3, GStruct3 gstruct3_1, long long_2, long long_3, GStruct0? nullable_5, GEnum3? nullable_6, DateTime? nullable_7, DateTime? nullable_8, DateTime? nullable_9) : GClass5(string_2, string_3)
{
    public sealed class GClass9 : GClass8
    {
        [CompilerGenerated]
        private GStruct3 gstruct3_0;

        [CompilerGenerated]
        private long long_0;

        [CompilerGenerated]
        private long long_1;

        [CompilerGenerated]
        private GStruct0? nullable_0;

        [CompilerGenerated]
        private GEnum3? nullable_1;

        [CompilerGenerated]
        private DateTime? nullable_2;

        [CompilerGenerated]
        private DateTime? nullable_3;

        [CompilerGenerated]
        private DateTime? nullable_4;

        public GStruct3 Stream
        {
            [CompilerGenerated]
            get
            {
                return gstruct3_0;
            }
            [CompilerGenerated]
            set
            {
                gstruct3_0 = value;
            }
        }

        public long Offset
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

        public long Length
        {
            [CompilerGenerated]
            get
            {
                return long_1;
            }
            [CompilerGenerated]
            set
            {
                long_1 = value;
            }
        }

        public GStruct0? Checksum
        {
            [CompilerGenerated]
            get
            {
                return nullable_0;
            }
            [CompilerGenerated]
            set
            {
                nullable_0 = value;
            }
        }

        public GEnum3? Attributes
        {
            [CompilerGenerated]
            get
            {
                return nullable_1;
            }
            [CompilerGenerated]
            set
            {
                nullable_1 = value;
            }
        }

        public DateTime? Creation
        {
            [CompilerGenerated]
            get
            {
                return nullable_2;
            }
            [CompilerGenerated]
            set
            {
                nullable_2 = value;
            }
        }

        public DateTime? LastWrite
        {
            [CompilerGenerated]
            get
            {
                return nullable_3;
            }
            [CompilerGenerated]
            set
            {
                nullable_3 = value;
            }
        }

        public DateTime? LastAccess
        {
            [CompilerGenerated]
            get
            {
                return nullable_4;
            }
            [CompilerGenerated]
            set
            {
                nullable_4 = value;
            }
        }

        public GClass9()
        {
        }

        public GClass9(GClass6 gclass6_0)
            : base(gclass6_0)
        {
            Stream = gclass6_0.Stream;
            Offset = gclass6_0.Offset;
            Length = gclass6_0.Length;
            Checksum = gclass6_0.Checksum;
            Attributes = gclass6_0.Attributes;
            Creation = gclass6_0.Creation;
            LastWrite = gclass6_0.LastWrite;
            LastAccess = gclass6_0.LastAccess;
        }

        internal override GClass5 vmethod_0()
        {
            return method_1();
        }

        public GClass6 method_1()
        {
            return new GClass6(base.FullName, base.Name, Stream, Offset, Length, Checksum, Attributes, Creation, LastWrite, LastAccess);
        }
    }

    [CompilerGenerated]
    private readonly GStruct3 gstruct3_0 = gstruct3_1;

    [CompilerGenerated]
    private readonly long long_0 = long_2;

    [CompilerGenerated]
    private readonly long long_1 = long_3;

    [CompilerGenerated]
    private readonly GStruct0? nullable_0 = nullable_5;

    [CompilerGenerated]
    private readonly GEnum3? nullable_1 = nullable_6;

    [CompilerGenerated]
    private readonly DateTime? nullable_2 = nullable_7;

    [CompilerGenerated]
    private readonly DateTime? nullable_3 = nullable_8;

    [CompilerGenerated]
    private readonly DateTime? nullable_4 = nullable_9;

    public GStruct3 Stream
    {
        [CompilerGenerated]
        get
        {
            return gstruct3_0;
        }
    }

    public long Offset
    {
        [CompilerGenerated]
        get
        {
            return long_0;
        }
    }

    public long Length
    {
        [CompilerGenerated]
        get
        {
            return long_1;
        }
    }

    public GStruct0? Checksum
    {
        [CompilerGenerated]
        get
        {
            return nullable_0;
        }
    }

    public GEnum3? Attributes
    {
        [CompilerGenerated]
        get
        {
            return nullable_1;
        }
    }

    public DateTime? Creation
    {
        [CompilerGenerated]
        get
        {
            return nullable_2;
        }
    }

    public DateTime? LastWrite
    {
        [CompilerGenerated]
        get
        {
            return nullable_3;
        }
    }

    public DateTime? LastAccess
    {
        [CompilerGenerated]
        get
        {
            return nullable_4;
        }
    }
}
