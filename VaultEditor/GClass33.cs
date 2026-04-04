namespace VaultEditor;

public sealed class GClass33(GClass47 gclass47_1) : GClass30
{
    private readonly GClass47 gclass47_0 = gclass47_1;

    internal override GStruct6 vmethod_0()
    {
        return GStruct6.GStruct6_3;
    }

    private static uint smethod_0(int int_0)
    {
        return (uint)((2 | (int_0 & 1)) << int_0 / 2 + 11);
    }

    public static byte smethod_1(GClass47 gclass47_1)
    {
        uint num = gclass47_1.method_0().class67_0.method_1();
        int i;
        for (i = 0; i < 40 && num > smethod_0(i); i++)
        {
        }
        return (byte)i;
    }

    internal override byte[] vmethod_2()
    {
        return [smethod_1(gclass47_0)];
    }

    internal override Class42 vmethod_1()
    {
        return new Class45(gclass47_0);
    }
}
