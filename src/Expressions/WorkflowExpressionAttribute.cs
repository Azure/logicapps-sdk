// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>Marks an argument whose source the workflow compiler must capture.</summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class WorkflowExpressionAttribute : Attribute
    {
    }

    /// <summary>Links an authoring factory to its descriptor-taking entry point.</summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class WorkflowExpressionFactoryAttribute : Attribute
    {
        public WorkflowExpressionFactoryAttribute(string entryPoint) => this.EntryPoint = entryPoint;

        public string EntryPoint { get; }
    }
}
