// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Build;

using Microsoft.CodeAnalysis.CSharp.Syntax;

internal enum SourceBindingKind
{
    Output,
    Body,
    TriggerOutput,
    TriggerBody,
    Variable,
    Item,
    AgentParameter,
}

internal sealed record SourceBindingFactory(
    SourceBindingKind Kind,
    ExpressionSyntax Receiver,
    string? Argument = null);
