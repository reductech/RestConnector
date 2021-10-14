﻿using System.Diagnostics;
using Reductech.EDR.Core.Internal.Errors;

namespace Reductech.EDR.Connectors.Rest.Errors
{

/// <summary>
/// Error Codes for the REST connector
/// </summary>
public sealed record ErrorCodeREST : ErrorCodeBase
{
    private ErrorCodeREST(string code) : base(code) { }

    /// <inheritdoc />
    public override string GetFormatString()
    {
        var localizedMessage =
            ErrorMessages_EN.ResourceManager.GetString(Code);

        Debug.Assert(localizedMessage != null, nameof(localizedMessage) + " != null");
        return localizedMessage;
    }


    /// <summary>
    /// Operation '{0}' is not implemented
    /// </summary>
    public static readonly ErrorCodeREST OperationNotImplemented = new(nameof(OperationNotImplemented));
}

}
