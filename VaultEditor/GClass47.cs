namespace VaultEditor;

public sealed class GClass47
{
    private readonly GClass43 gclass43_0;

    private readonly long? nullable_0;

    private readonly int? nullable_1;

    private readonly int? nullable_2;

    public GClass47()
    {
        gclass43_0 = new GClass43();
    }

    internal Class52.Class60 method_0()
    {
        return new Class52.Class60
        {
            class67_0 = gclass43_0.method_2(),
            int_1 = (nullable_2 ?? (-1)),
            int_0 = (nullable_1 ?? (-1)),
            long_0 = (nullable_0 ?? 0L)
        };
    }
}
