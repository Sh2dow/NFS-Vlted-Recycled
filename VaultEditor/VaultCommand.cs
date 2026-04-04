using System.Runtime.CompilerServices;

namespace VaultEditor;

public abstract class GClass541
{
    [CompilerGenerated]
    private string string_0;

    public string Comment
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

    public static string[] String_0 =>
    [
        "version", "add_field", "delete_field", "resize_field", "copy_fields", "update_field", "convert_field", "file_copy", "game", "add_node",
        "change_vault", "copy_node", "delete_nodes", "delete_node", "rename_node", "move_node", "script", "ui_image", "ui_text", "ui_control",
        "ui_option", "folder_create", "update_collection", "resize_collection"
    ];

    [SpecialName]
    public abstract string vmethod_0();

    public abstract GClass540 vmethod_1(VaultDatabase gclass478_0);

    public abstract GClass542 vmethod_2(VaultDatabase gclass478_0);

    public override string ToString()
    {
        if (string.IsNullOrWhiteSpace(Comment))
        {
            return vmethod_0();
        }
        return vmethod_0() + " #" + Comment;
    }
}
