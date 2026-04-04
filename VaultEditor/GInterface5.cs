using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public interface GInterface5 : GInterface6
{
    uint OffsetDest { get; }

    [SpecialName]
    bool imethod_2();

    [SpecialName]
    bool imethod_3();

    void imethod_4(BinaryReader binaryReader_0);

    void imethod_5(BinaryWriter binaryWriter_0);

    GInterface5 imethod_6();

    bool imethod_7(Func<string, bool> func_0);
}
