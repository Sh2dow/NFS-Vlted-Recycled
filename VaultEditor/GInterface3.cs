using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public interface GInterface3 : GInterface2
{
    IEnumerable<GInterface3> Prop_0 { get; }

    IEnumerable<GInterface3> Prop_1 { get; }

    [SpecialName]
    bool imethod_2();

    void imethod_3(BinaryReader binaryReader_0, int int_0);

    void imethod_4(BinaryWriter binaryWriter_0);

    [SpecialName]
    GEnum15 imethod_5();

    void imethod_6(string string_0);

    [SpecialName]
    bool imethod_7();
}
