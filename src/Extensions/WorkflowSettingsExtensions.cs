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
        public static IWorkflowAction<TConfiguration> WithTrackedProperty<TConfiguration, TValue>(
            this IWorkflowAction<TConfiguration> action, string name, Expression<Func<TValue>> value)
            where TConfiguration : IWorkflowOperationConfiguration, ITrackedPropertiesConfigurationHolder
        {
            AddTrackedProperty(action, action.Configuration, name, value);
            return action;
        }

        public static IBodyWorkflowAction<TBody, TConfiguration> WithTrackedProperty<TBody, TConfiguration, TValue>(
            this IBodyWorkflowAction<TBody, TConfiguration> action, string name, Expression<Func<TValue>> value)
            where TConfiguration : IWorkflowOperationConfiguration, ITrackedPropertiesConfigurationHolder
        {
            AddTrackedProperty(action, action.Configuration, name, value);
            return action;
        }

        public static IOutputWorkflowAction<TOutput, TConfiguration> WithTrackedProperty<TOutput, TConfiguration, TValue>(
            this IOutputWorkflowAction<TOutput, TConfiguration> action, string name, Expression<Func<TValue>> value)
            where TConfiguration : IWorkflowOperationConfiguration, ITrackedPropertiesConfigurationHolder
        {
            AddTrackedProperty(action, action.Configuration, name, value);
            return action;
        }

        public static IVariableWorkflowAction<TConfiguration> WithTrackedProperty<TConfiguration, TValue>(
            this IVariableWorkflowAction<TConfiguration> action, string name, Expression<Func<TValue>> value)
            where TConfiguration : IWorkflowOperationConfiguration, ITrackedPropertiesConfigurationHolder
        {
            AddTrackedProperty(action, action.Configuration, name, value);
            return action;
        }

        public static IAgentWorkflowAction<TConfiguration> WithTrackedProperty<TConfiguration, TValue>(
            this IAgentWorkflowAction<TConfiguration> action, string name, Expression<Func<TValue>> value)
            where TConfiguration : IWorkflowOperationConfiguration, ITrackedPropertiesConfigurationHolder
        {
            AddTrackedProperty(action, action.Configuration, name, value);
            return action;
        }

        public static IWorkflowAction<TConfiguration> WithRetryPolicy<TConfiguration>(
            this IWorkflowAction<TConfiguration> action, RetryPolicy retryPolicy)
            where TConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder
        {
            SetRetryPolicy(action.Configuration, retryPolicy);
            return action;
        }

        public static IBodyWorkflowAction<TBody, TConfiguration> WithRetryPolicy<TBody, TConfiguration>(
            this IBodyWorkflowAction<TBody, TConfiguration> action, RetryPolicy retryPolicy)
            where TConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder
        {
            SetRetryPolicy(action.Configuration, retryPolicy);
            return action;
        }

        public static IOutputWorkflowAction<TOutput, TConfiguration> WithRetryPolicy<TOutput, TConfiguration>(
            this IOutputWorkflowAction<TOutput, TConfiguration> action, RetryPolicy retryPolicy)
            where TConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder
        {
            SetRetryPolicy(action.Configuration, retryPolicy);
            return action;
        }

        public static IAgentWorkflowAction<TConfiguration> WithRetryPolicy<TConfiguration>(
            this IAgentWorkflowAction<TConfiguration> action, RetryPolicy retryPolicy)
            where TConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder
        {
            SetRetryPolicy(action.Configuration, retryPolicy);
            return action;
        }

        public static IWorkflowTrigger<TConfiguration> WithRetryPolicy<TConfiguration>(
            this IWorkflowTrigger<TConfiguration> trigger, RetryPolicy retryPolicy)
            where TConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder
        {
            SetRetryPolicy(trigger.Configuration, retryPolicy);
            return trigger;
        }

        public static IBodyWorkflowTrigger<TBody, TConfiguration> WithRetryPolicy<TBody, TConfiguration>(
            this IBodyWorkflowTrigger<TBody, TConfiguration> trigger, RetryPolicy retryPolicy)
            where TConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder
        {
            SetRetryPolicy(trigger.Configuration, retryPolicy);
            return trigger;
        }

        public static IOutputWorkflowTrigger<TOutput, TConfiguration> WithRetryPolicy<TOutput, TConfiguration>(
            this IOutputWorkflowTrigger<TOutput, TConfiguration> trigger, RetryPolicy retryPolicy)
            where TConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder
        {
            SetRetryPolicy(trigger.Configuration, retryPolicy);
            return trigger;
        }

        public static IWorkflowAction<TConfiguration> WithSecureInputs<TConfiguration>(
            this IWorkflowAction<TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder
        {
            SetSecureInputs(action.Configuration);
            return action;
        }

        public static IBodyWorkflowAction<TBody, TConfiguration> WithSecureInputs<TBody, TConfiguration>(
            this IBodyWorkflowAction<TBody, TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder
        {
            SetSecureInputs(action.Configuration);
            return action;
        }

        public static IOutputWorkflowAction<TOutput, TConfiguration> WithSecureInputs<TOutput, TConfiguration>(
            this IOutputWorkflowAction<TOutput, TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder
        {
            SetSecureInputs(action.Configuration);
            return action;
        }

        public static IAgentWorkflowAction<TConfiguration> WithSecureInputs<TConfiguration>(
            this IAgentWorkflowAction<TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder
        {
            SetSecureInputs(action.Configuration);
            return action;
        }

        public static IWorkflowTrigger<TConfiguration> WithSecureInputs<TConfiguration>(
            this IWorkflowTrigger<TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder
        {
            SetSecureInputs(trigger.Configuration);
            return trigger;
        }

        public static IBodyWorkflowTrigger<TBody, TConfiguration> WithSecureInputs<TBody, TConfiguration>(
            this IBodyWorkflowTrigger<TBody, TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder
        {
            SetSecureInputs(trigger.Configuration);
            return trigger;
        }

        public static IOutputWorkflowTrigger<TOutput, TConfiguration> WithSecureInputs<TOutput, TConfiguration>(
            this IOutputWorkflowTrigger<TOutput, TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder
        {
            SetSecureInputs(trigger.Configuration);
            return trigger;
        }

        public static IWorkflowAction<TConfiguration> WithSecureOutputs<TConfiguration>(
            this IWorkflowAction<TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureOutputsConfigurationHolder
        {
            action.Configuration.SecureOutputs = true;
            return action;
        }

        public static IBodyWorkflowAction<TBody, TConfiguration> WithSecureOutputs<TBody, TConfiguration>(
            this IBodyWorkflowAction<TBody, TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureOutputsConfigurationHolder
        {
            action.Configuration.SecureOutputs = true;
            return action;
        }

        public static IOutputWorkflowAction<TOutput, TConfiguration> WithSecureOutputs<TOutput, TConfiguration>(
            this IOutputWorkflowAction<TOutput, TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureOutputsConfigurationHolder
        {
            action.Configuration.SecureOutputs = true;
            return action;
        }

        public static IAgentWorkflowAction<TConfiguration> WithSecureOutputs<TConfiguration>(
            this IAgentWorkflowAction<TConfiguration> action)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureOutputsConfigurationHolder
        {
            action.Configuration.SecureOutputs = true;
            return action;
        }

        public static IWorkflowTrigger<TConfiguration> WithSecureOutputs<TConfiguration>(
            this IWorkflowTrigger<TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureOutputsConfigurationHolder
        {
            trigger.Configuration.SecureOutputs = true;
            return trigger;
        }

        public static IBodyWorkflowTrigger<TBody, TConfiguration> WithSecureOutputs<TBody, TConfiguration>(
            this IBodyWorkflowTrigger<TBody, TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureOutputsConfigurationHolder
        {
            trigger.Configuration.SecureOutputs = true;
            return trigger;
        }

        public static IOutputWorkflowTrigger<TOutput, TConfiguration> WithSecureOutputs<TOutput, TConfiguration>(
            this IOutputWorkflowTrigger<TOutput, TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, ISecureOutputsConfigurationHolder
        {
            trigger.Configuration.SecureOutputs = true;
            return trigger;
        }

        public static IWorkflowAction<TConfiguration> WithIterationConcurrency<TConfiguration>(
            this IWorkflowAction<TConfiguration> action, int repetitions)
            where TConfiguration : IWorkflowOperationConfiguration, IIterationConcurrencyConfigurationHolder
        {
            if (repetitions < 1 || repetitions > 50)
                throw new ArgumentOutOfRangeException(nameof(repetitions), "Iteration concurrency must be between 1 and 50.");
            action.Configuration.MaximumParallelIterations = repetitions;
            return action;
        }

        public static IWorkflowTrigger<TConfiguration> WithConcurrency<TConfiguration>(
            this IWorkflowTrigger<TConfiguration> trigger, int runs, int? maximumWaitingRuns = null)
            where TConfiguration : IWorkflowOperationConfiguration, ITriggerConcurrencyConfigurationHolder
        {
            SetConcurrency(trigger.Configuration, runs, maximumWaitingRuns);
            return trigger;
        }

        public static IBodyWorkflowTrigger<TBody, TConfiguration> WithConcurrency<TBody, TConfiguration>(
            this IBodyWorkflowTrigger<TBody, TConfiguration> trigger, int runs, int? maximumWaitingRuns = null)
            where TConfiguration : IWorkflowOperationConfiguration, ITriggerConcurrencyConfigurationHolder
        {
            SetConcurrency(trigger.Configuration, runs, maximumWaitingRuns);
            return trigger;
        }

        public static IOutputWorkflowTrigger<TOutput, TConfiguration> WithConcurrency<TOutput, TConfiguration>(
            this IOutputWorkflowTrigger<TOutput, TConfiguration> trigger, int runs, int? maximumWaitingRuns = null)
            where TConfiguration : IWorkflowOperationConfiguration, ITriggerConcurrencyConfigurationHolder
        {
            SetConcurrency(trigger.Configuration, runs, maximumWaitingRuns);
            return trigger;
        }

        public static IWorkflowTrigger<TConfiguration> WithClientTrackingId<TConfiguration>(
            this IWorkflowTrigger<TConfiguration> trigger, Expression<Func<string>> clientTrackingId)
            where TConfiguration : IWorkflowOperationConfiguration, IClientTrackingIdConfigurationHolder
        {
            SetClientTrackingId(trigger.Configuration, clientTrackingId);
            return trigger;
        }

        public static IBodyWorkflowTrigger<TBody, TConfiguration> WithClientTrackingId<TBody, TConfiguration>(
            this IBodyWorkflowTrigger<TBody, TConfiguration> trigger, Expression<Func<string>> clientTrackingId)
            where TConfiguration : IWorkflowOperationConfiguration, IClientTrackingIdConfigurationHolder
        {
            SetClientTrackingId(trigger.Configuration, clientTrackingId);
            return trigger;
        }

        public static IOutputWorkflowTrigger<TOutput, TConfiguration> WithClientTrackingId<TOutput, TConfiguration>(
            this IOutputWorkflowTrigger<TOutput, TConfiguration> trigger, Expression<Func<string>> clientTrackingId)
            where TConfiguration : IWorkflowOperationConfiguration, IClientTrackingIdConfigurationHolder
        {
            SetClientTrackingId(trigger.Configuration, clientTrackingId);
            return trigger;
        }

        public static IWorkflowTrigger<TConfiguration> WithSchemaValidation<TConfiguration>(
            this IWorkflowTrigger<TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, IRequestSchemaValidationConfigurationHolder
        {
            trigger.Configuration.SchemaValidationEnabled = true;
            return trigger;
        }

        public static IOutputWorkflowTrigger<TOutput, TConfiguration> WithSchemaValidation<TOutput, TConfiguration>(
            this IOutputWorkflowTrigger<TOutput, TConfiguration> trigger)
            where TConfiguration : IWorkflowOperationConfiguration, IRequestSchemaValidationConfigurationHolder
        {
            trigger.Configuration.SchemaValidationEnabled = true;
            return trigger;
        }

        private static void AddTrackedProperty<TValue>(
            IWorkflowOperation operation,
            ITrackedPropertiesConfigurationHolder configuration,
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
            IRetryPolicyConfigurationHolder configuration,
            RetryPolicy retryPolicy) =>
            configuration.RetryPolicy = retryPolicy ?? throw new ArgumentNullException(nameof(retryPolicy));

        private static void SetSecureInputs<TConfiguration>(TConfiguration configuration)
            where TConfiguration : ISecureInputsConfigurationHolder
        {
            configuration.SecureInputs = true;
        }

        private static void SetConcurrency(
            ITriggerConcurrencyConfigurationHolder configuration,
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
            IClientTrackingIdConfigurationHolder configuration,
            Expression<Func<string>> clientTrackingId)
        {
            var descriptor = WorkflowExpression.Compile(clientTrackingId, nameof(clientTrackingId), required: true);
            configuration.ClientTrackingId = ExpressionConverter.Convert(descriptor);
        }
    }
}
