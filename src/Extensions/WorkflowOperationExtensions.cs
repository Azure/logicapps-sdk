// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Extension methods for workflow operations.
    /// </summary>
    public static class WorkflowOperationExtensions
    {
        /// <summary>
        /// Sets the operation name and returns the same instance.
        /// </summary>
        /// <typeparam name="T">The operation type.</typeparam>
        /// <param name="operation">The workflow operation.</param>
        /// <param name="name">The name to assign.</param>
        public static T WithName<T>(this T operation, string name) where T : IWorkflowOperation
        {
            operation.Name = name;
            return operation;
        }
    }
}
