// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Identifies a delegate parameter whose body is evaluated by the workflow runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class WorkflowExpressionAttribute : Attribute
    {
        public WorkflowExpressionAttribute(
            WorkflowExpressionLocation location = WorkflowExpressionLocation.CompleteValue)
        {
            this.Location = location;
        }

        public WorkflowExpressionLocation Location { get; }
    }

    /// <summary>
    /// Describes how a generated workflow expression is embedded in the workflow definition.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum WorkflowExpressionLocation
    {
        CompleteValue,
        InlineTemplate,
    }
}
