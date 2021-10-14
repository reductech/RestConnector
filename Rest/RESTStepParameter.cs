﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using Reductech.EDR.Core;
using Reductech.EDR.Core.Internal;

namespace Reductech.EDR.Connectors.Rest
{

public class RESTStepParameter : IStepParameter
{
    public RESTStepParameter(OpenApiParameter parameter)
    {
        Parameter  = parameter;
        ActualType = typeof(StringStream);
        StepType   = typeof(IStep<>).MakeGenericType(ActualType);
    }

    /// <summary>
    /// The OpenAPI parameter
    /// </summary>
    public OpenApiParameter Parameter { get; }

    /// <inheritdoc />
    public string Name => Parameter.Name;

    /// <inheritdoc />
    public Type StepType { get; }

    /// <inheritdoc />
    public Type ActualType { get; }

    /// <inheritdoc />
    public IReadOnlyCollection<string> Aliases => ImmutableArray<string>.Empty;

    /// <inheritdoc />
    public bool Required => Parameter.Required;

    /// <inheritdoc />
    public string Summary => Parameter.Description;

    /// <inheritdoc />
    public IReadOnlyDictionary<string, string> ExtraFields =>
        ImmutableDictionary<string, string>.Empty;

    /// <inheritdoc />
    public int? Order => null;

    /// <inheritdoc />
    public MemberType MemberType => MemberType.Step;
}

}
