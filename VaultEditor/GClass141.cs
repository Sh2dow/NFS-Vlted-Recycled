using System.Collections.Generic;
using System.Windows.Forms;

namespace VaultEditor;

public static class GClass141
{
    public static IEnumerable<GridItem> smethod_0(this PropertyGrid propertyGrid_0)
    {
        if (propertyGrid_0 == null)
        {
            yield break;
        }
        GridItem gridItem = propertyGrid_0.SelectedGridItem;
        while (gridItem.Parent != null)
        {
            gridItem = gridItem.Parent;
        }
        foreach (GridItem item in gridItem.smethod_1())
        {
            yield return item;
        }
    }

    public static IEnumerable<GridItem> smethod_1(this GridItem gridItem_0)
    {
        if (gridItem_0 == null)
        {
            yield break;
        }
        yield return gridItem_0;
        foreach (GridItem gridItem in gridItem_0.GridItems)
        {
            foreach (GridItem item in gridItem.smethod_1())
            {
                yield return item;
            }
        }
    }
}
