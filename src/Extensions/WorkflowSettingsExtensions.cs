// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;

    public static class WorkflowSettingsExtensions
    {
        public static TOperation WithTrackedProperty<TOperation, TValue>(
            this TOperation action, string name, Expression<Func<TValue>> value)
            where TOperation : IWorkflowAction<ITrackedPropertiesConfiguration>
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            var descriptor = WorkflowExpression.Compile(value, nameof(value), required: true);
            action.Configuration.TrackedProperties.Add(
                name,
                () => ExpressionConverter.ConvertO(descriptor));

            return action;
        }

        public static TOperation WithRetryPolicy<TOperation>(
            this TOperation operation, RetryPolicy retryPolicy)
            where TOperation : IWorkflowOperation<IRetryPolicyConfiguration>
        {
            operation.Configuration.RetryPolicy = retryPolicy ?? throw new ArgumentNullException(nameof(retryPolicy));
            return operation;
        }

        public static TOperation WithSecureInputs<TOperation>(
            this TOperation operation)
            where TOperation : IWorkflowOperation<ISecureInputsConfiguration>
        {
            operation.Configuration.SecureInputs = true;
            return operation;
        }

        public static TOperation WithSecureOutputs<TOperation>(
            this TOperation operation)
            where TOperation : IWorkflowOperation<ISecureOutputsConfiguration>
        {
            operation.Configuration.SecureOutputs = true;
            return operation;
        }

        public static TOperation WithIterationConcurrency<TOperation>(
            this TOperation action, int repetitions)
            where TOperation : IWorkflowAction<IIterationConcurrencyConfiguration>
        {
            action.Configuration.MaximumParallelIterations = repetitions;
            return action;
        }

        public static TOperation WithConcurrency<TOperation>(
            this TOperation trigger, int runs, int? maximumWaitingRuns = null)
            where TOperation : IWorkflowTrigger<ITriggerConcurrencyConfiguration>
        {
            trigger.Configuration.ConcurrentRuns = runs;
            trigger.Configuration.MaximumWaitingRuns = maximumWaitingRuns;
            return trigger;
        }

        public static TOperation WithClientTrackingId<TOperation>(
            this TOperation trigger, Expression<Func<string>> clientTrackingId)
            where TOperation : IWorkflowTrigger<IClientTrackingIdConfiguration>
        {
            var descriptor = WorkflowExpression.Compile(clientTrackingId, nameof(clientTrackingId), required: true);
            trigger.Configuration.ClientTrackingId = () => ExpressionConverter.Convert(descriptor);
            return trigger;
        }

        public static TOperation WithSchemaValidation<TOperation>(
            this TOperation trigger)
            where TOperation : IWorkflowTrigger<IRequestSchemaValidationConfiguration>
        {
            trigger.Configuration.SchemaValidationEnabled = true;
            return trigger;
        }
    }
}
