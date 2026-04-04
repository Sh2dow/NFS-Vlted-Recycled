namespace VaultEditor;

public sealed class GClass69(GClass97 gclass97_1) : GClass61(gclass97_1)
{
    public override void vmethod_0()
    {
        class84_1 = new Class84(gclass97_0.FastColoredTextBox_0.GClass84_5);
    }

    protected override void vmethod_2(bool bool_1)
    {
    }

    public override void vmethod_1()
    {
        gclass97_0.FastColoredTextBox_0.GClass84_5 = new GClass84(gclass97_0.FastColoredTextBox_0, class84_1.Start, class84_1.End);
    }

    public override GClass61 vmethod_3()
    {
        GClass69 gClass = new(gclass97_0);
        if (class84_1 != null)
        {
            gClass.class84_1 = new Class84(new GClass84(gclass97_0.FastColoredTextBox_0, class84_1.Start, class84_1.End));
        }
        return gClass;
    }
}
