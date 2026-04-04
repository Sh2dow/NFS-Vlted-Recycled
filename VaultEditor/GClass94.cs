using System.Text.RegularExpressions;

namespace VaultEditor;

public sealed class GClass94
{
    private Regex regex_0;

    public string string_0;

    public RegexOptions regexOptions_0;

    public GClass85 gclass85_0;

    public Regex Regex_0
    {
        get
        {
            regex_0 ??= new Regex(string_0, GClass96.RegexOptions_0 | regexOptions_0);
            return regex_0;
        }
    }
}
