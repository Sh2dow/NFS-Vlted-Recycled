using System.Collections.Generic;

namespace VaultEditor;

public static class GClass118
{
    private static readonly IDictionary<uint, string> idictionary_0;

    static GClass118()
    {
        idictionary_0 = new Dictionary<uint, string>
        {
            { 0u, "PART_BASE" },
            { 1u, "KIT00_FRONT_BUMPER" },
            { 7u, "KIT00_ROOF" },
            { 8u, "KIT00_HOOD" },
            { 9u, "KIT00_TRUNK" },
            { 10u, "KIT00_SKIRT" },
            { 775u, "STYLE01_ROOF" },
            { 66049u, "KIT09_FRONT_BUMPER" },
            { 66050u, "KIT09_REAR_BUMPER" },
            { 66055u, "STYLE03_ROOF" },
            { 66056u, "STYLE05_HOOD" },
            { 66058u, "KIT09_SKIRT" },
            { 66059u, "STYLE10_SPOILER" },
            { 66305u, "KIT03_FRONT_BUMPER" },
            { 66306u, "KIT03_REAR_BUMPER" },
            { 66311u, "STYLE04_ROOF" },
            { 66312u, "STYLE01_HOOD" },
            { 66314u, "KIT03_SKIRT" },
            { 66315u, "STYLE01_SPOILER" },
            { 66317u, "STYLE01_HEADLIGHT" },
            { 66318u, "STYLE01_BRAKELIGHT" },
            { 66566u, "KITW01_BODY" },
            { 66568u, "STYLE10_HOOD" },
            { 66571u, "STYLE03_SPOILER" },
            { 65811u, "DECAL_HOOD_RECT_SMALL" },
            { 65816u, "DECAL_LEFT_QUARTER_RECT_SMALL" },
            { 721675u, "STYLE13_SPOILER" },
            { 721672u, "STYLE19_HOOD" }
        };
    }

    public static string smethod_0(uint uint_0)
    {
        if (idictionary_0.ContainsKey(uint_0))
        {
            return idictionary_0[uint_0];
        }
        return uint_0.ToString();
    }
}
