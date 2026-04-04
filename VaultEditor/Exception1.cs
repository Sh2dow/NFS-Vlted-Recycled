using System;
using System.Runtime.Serialization;

namespace VaultEditor;

internal sealed class Exception1 : InvalidOperationException
{
    public Exception1()
    {
    }

    private Exception1(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
        : base(serializationInfo_0, streamingContext_0)
    {
    }
}
