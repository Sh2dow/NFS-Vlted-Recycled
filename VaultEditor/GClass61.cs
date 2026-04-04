namespace VaultEditor;

public abstract class GClass61 : GClass60
{
    internal Class84 class84_0;

    internal Class84 class84_1;

    internal bool bool_0;

    public GClass61(GClass97 gclass97_1)
    {
        gclass97_0 = gclass97_1;
        class84_0 = new Class84(gclass97_1.FastColoredTextBox_0.GClass84_5);
    }

    public virtual void vmethod_1()
    {
        vmethod_2(bool_1: true);
    }

    public override void vmethod_0()
    {
        class84_1 = new Class84(gclass97_0.FastColoredTextBox_0.GClass84_5);
        vmethod_2(bool_1: false);
    }

    protected virtual void vmethod_2(bool bool_1)
    {
        bool flag = class84_0.Start.int_1 < class84_1.Start.int_1;
        if (bool_1)
        {
            if (flag)
            {
                gclass97_0.vmethod_14(class84_0.Start.int_1, class84_0.Start.int_1);
            }
            else
            {
                gclass97_0.vmethod_14(class84_0.Start.int_1, class84_1.Start.int_1);
            }
        }
        else if (flag)
        {
            gclass97_0.vmethod_14(class84_0.Start.int_1, class84_1.Start.int_1);
        }
        else
        {
            gclass97_0.vmethod_14(class84_1.Start.int_1, class84_1.Start.int_1);
        }
    }

    public abstract GClass61 vmethod_3();
}
