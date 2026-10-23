// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using Newtonsoft.Json.Linq;

    public static class WorkflowSettingsExtensions
    {
        public static TOperation WithTrackedProperty<TOperation, TValue>(
            this TOperation action, string name, Expression<Func<TValue>> value)
            where TOperation : IWorkflowAction<ITrackedPropertiesConfiguration>
        {
            AddTrackedProperty(action, action.Configuration, name, value);
            return action;
        }

        public static TOperation WithRetryPolicy<TOperation>(
            this TOperation operation, RetryPolicy retryPolicy)
            where TOperation : IWorkflowOperation<IRetryPolicyConfiguration>
        {
            SetRetryPolicy(operation.Configuration, retryPolicy);
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
            if (repetitions < 1 || repetitions > 50)
                throw new ArgumentOutOfRangeException(nameof(repetitions), "Iteration concurrency must be between 1 and 50.");
            action.Configuration.MaximumParallelIterations = repetitions;
            return action;
        }

        public static TOperation WithConcurrency<TOperation>(
            this TOperation trigger, int runs, int? maximumWaitingRuns = null)
            where TOperation : IWorkflowTrigger<ITriggerConcurrencyConfiguration>
        {
            SetConcurrency(trigger.Configuration, runs, maximumWaitingRuns);
            return trigger;
        }

        public static TOperation WithClientTrackingId<TOperation>(
            this TOperation trigger, Expression<Func<string>> clientTrackingId)
            where TOperation : IWorkflowTrigger<IClientTrackingIdConfiguration>
        {
            SetClientTrackingId(trigger.Configuration, clientTrackingId);
            return trigger;
        }

        public static TOperation WithSchemaValidation<TOperation>(
            this TOperation trigger)
            where TOperation : IWorkflowTrigger<IRequestSchemaValidationConfiguration>
        {
            trigger.Configuration.SchemaValidationEnabled = true;
            return trigger;
        }

        private static void AddTrackedProperty<TValue>(
            IWorkflowOperation operation,
            ITrackedPropertiesConfiguration configuration,
            string name,
            Expression<Func<TValue>> value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("A tracked property name is required.", nameof(name));
            var descriptor = WorkflowExpression.Compile(value, nameof(value), required: true);
            if (configuration.TrackedProperties.ContainsKey(name))
                throw new InvalidOperationException($"Tracked property '{name}' is already configured on operation '{operation.Name}'.");
            if (configuration.TrackedProperties.Count == 16)
                throw new InvalidOperationException("Logic Apps supports at most 16 tracked properties per action.");
            configuration.TrackedProperties.Add(name, ExpressionConverter.ConvertO(descriptor));
        }

        private static void SetRetryPolicy(
            IRetryPolicyConfiguration configuration,
            RetryPolicy retryPolicy) =>
            configuration.RetryPolicy = retryPolicy ?? throw new ArgumentNullException(nameof(retryPolicy));

        private static void SetConcurrency(
            ITriggerConcurrencyConfiguration configuration,
            int runs,
            int? maximumWaitingRuns)
        {
            if (runs < 1 || runs > 100)
                throw new ArgumentOutOfRangeException(nameof(runs), "Trigger concurrency must be between 1 and 100.");
            if (maximumWaitingRuns is < 1)
                throw new ArgumentOutOfRangeException(nameof(maximumWaitingRuns), "Maximum waiting runs must be positive.");
            configuration.ConcurrentRuns = runs;
            configuration.MaximumWaitingRuns = maximumWaitingRuns;
        }

        private static void SetClientTrackingId(
            IClientTrackingIdConfiguration configuration,
            Expression<Func<string>> clientTrackingId)
        {
            var descriptor = WorkflowExpression.Compile(clientTrackingId, nameof(clientTrackingId), required: true);
            configuration.ClientTrackingId = ExpressionConverter.Convert(descriptor);
        }
    }
}
