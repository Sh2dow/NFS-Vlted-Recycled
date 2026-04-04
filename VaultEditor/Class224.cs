using System.Drawing.Design;

namespace VaultEditor;

internal sealed class Class224
{
    public static UITypeEditor smethod_0(GEnum20 genum20_0)
    {
        return genum20_0 switch
        {
            GEnum20.const_5 => new GClass106(),
            GEnum20.const_6 => new GClass526(),
            GEnum20.const_8 => new GClass105(),
            _ => null,
        };
    }
}
