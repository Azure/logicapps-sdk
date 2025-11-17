// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Workflow action extensions.
    /// </summary>
    public static class IWorkflowActionExtensions
    {
        /// <summary>
        /// Converts an array of <see cref="RunAfterSpecification"/> objects into a dictionary
        /// mapping action names to their required <see cref="FlowStatus"/> conditions.
        /// </summary>
        /// <param name="runAfter">An array of <see cref="RunAfterSpecification"/> specifying dependencies for workflow actions.</param>
        public static Dictionary<string, FlowStatus[]> ConvertRunAfterSpecification(RunAfterSpecification[] runAfter)
        {
            return runAfter
                .Where(spec => spec?.Action?.Name != null && spec.Status != null)
                .ToDictionary(spec => spec.Action.Name, spec => spec.Status);
        }
    }
}
