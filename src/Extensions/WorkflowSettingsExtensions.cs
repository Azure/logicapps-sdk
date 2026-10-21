// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;

    /// <summary>
    /// Fluent methods for configuring workflow action and trigger settings.
    /// </summary>
    public static class WorkflowSettingsExtensions
    {
        /// <summary>
        /// Adds a tracked property to an action.
        /// </summary>
        public static TAction WithTrackedProperty<TAction, TValue>(
            this TAction action,
            string name,
            Expression<Func<TValue>> value)
            where TAction : IWorkflowAction
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("A tracked property name is required.", nameof(name));
            var descriptor = WorkflowExpression.Compile(value, nameof(value), required: true);
            action.Configuration.Require(WorkflowActionSettingProfile.TrackedProperties, action.Name);

            if (action.Configuration.MutableTrackedProperties.ContainsKey(name))
            {
                throw new InvalidOperationException($"Tracked property '{name}' is already configured on action '{action.Name}'.");
            }

            if (action.Configuration.MutableTrackedProperties.Count == 16)
            {
                throw new InvalidOperationException("Logic Apps supports at most 16 tracked properties per action.");
            }

            action.Configuration.MutableTrackedProperties.Add(name, ExpressionConverter.ConvertO(descriptor));
            return action;
        }

        /// <summary>
        /// Configures an action retry policy.
        /// </summary>
        public static TOperation WithRetryPolicy<TOperation>(this TOperation operation, RetryPolicy retryPolicy)
            where TOperation : IWorkflowOperation
        {
            if (operation == null) throw new ArgumentNullException(nameof(operation));
            if (retryPolicy == null) throw new ArgumentNullException(nameof(retryPolicy));
            switch (operation)
            {
                case IWorkflowAction action:
                    action.Configuration.Require(WorkflowActionSettingProfile.RetryPolicy, action.Name);
                    action.Configuration.RetryPolicy = retryPolicy;
                    break;
                case IWorkflowTrigger trigger:
                    trigger.Configuration.Require(WorkflowTriggerSettingProfile.RetryPolicy, trigger.Name);
                    trigger.Configuration.RetryPolicy = retryPolicy;
                    break;
                default:
                    throw new NotSupportedException($"Operation '{operation.Name}' does not support retry policies.");
            }
            return operation;
        }

        /// <summary>
        /// Secures action inputs in run history.
        /// </summary>
        public static TOperation WithSecureInputs<TOperation>(this TOperation operation)
            where TOperation : IWorkflowOperation
        {
            if (operation == null) throw new ArgumentNullException(nameof(operation));
            switch (operation)
            {
                case IWorkflowAction action:
                    action.Configuration.Require(WorkflowActionSettingProfile.SecureInputs, action.Name);
                    action.Configuration.SecureInputs = true;
                    if (action.Configuration.SecureOutputsLinkedToInputs)
                    {
                        action.Configuration.SecureOutputs = true;
                    }
                    break;
                case IWorkflowTrigger trigger:
                    trigger.Configuration.Require(WorkflowTriggerSettingProfile.SecureInputs, trigger.Name);
                    trigger.Configuration.SecureInputs = true;
                    break;
                default:
                    throw new NotSupportedException($"Operation '{operation.Name}' does not support secure inputs.");
            }
            return operation;
        }

        /// <summary>
        /// Secures action outputs in run history.
        /// </summary>
        public static TOperation WithSecureOutputs<TOperation>(this TOperation operation)
            where TOperation : IWorkflowOperation
        {
            if (operation == null) throw new ArgumentNullException(nameof(operation));
            switch (operation)
            {
                case IWorkflowAction action:
                    action.Configuration.Require(WorkflowActionSettingProfile.SecureOutputs, action.Name);
                    action.Configuration.SecureOutputs = true;
                    break;
                case IWorkflowTrigger trigger:
                    trigger.Configuration.Require(WorkflowTriggerSettingProfile.SecureOutputs, trigger.Name);
                    trigger.Configuration.SecureOutputs = true;
                    break;
                default:
                    throw new NotSupportedException($"Operation '{operation.Name}' does not support secure outputs.");
            }
            return operation;
        }

        /// <summary>
        /// Secures operation inputs and outputs in run history.
        /// </summary>
        public static TOperation WithSecureInputsAndOutputs<TOperation>(this TOperation operation)
            where TOperation : IWorkflowOperation
        {
            if (operation == null) throw new ArgumentNullException(nameof(operation));
            switch (operation)
            {
                case IWorkflowAction action:
                    action.Configuration.Require(WorkflowActionSettingProfile.SecureInputs, action.Name);
                    if (!action.Configuration.SecureOutputsLinkedToInputs)
                    {
                        action.Configuration.Require(WorkflowActionSettingProfile.SecureOutputs, action.Name);
                    }
                    action.Configuration.SecureInputs = true;
                    action.Configuration.SecureOutputs = true;
                    break;
                case IWorkflowTrigger trigger:
                    trigger.Configuration.Require(WorkflowTriggerSettingProfile.SecureInputs, trigger.Name);
                    trigger.Configuration.Require(WorkflowTriggerSettingProfile.SecureOutputs, trigger.Name);
                    trigger.Configuration.SecureInputs = true;
                    trigger.Configuration.SecureOutputs = true;
                    break;
                default:
                    throw new NotSupportedException($"Operation '{operation.Name}' does not support secure data.");
            }
            return operation;
        }

        /// <summary>
        /// Configures the maximum number of parallel For Each iterations.
        /// </summary>
        public static TAction WithIterationConcurrency<TAction>(this TAction action, int repetitions)
            where TAction : IWorkflowAction
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            action.Configuration.Require(WorkflowActionSettingProfile.IterationConcurrency, action.Name);
            if (repetitions < 1 || repetitions > 50)
            {
                throw new ArgumentOutOfRangeException(nameof(repetitions), "Iteration concurrency must be between 1 and 50.");
            }
            action.Configuration.MaximumParallelIterations = repetitions;
            return action;
        }

        /// <summary>
        /// Configures concurrent workflow runs for a trigger.
        /// </summary>
        public static TTrigger WithConcurrency<TTrigger>(
            this TTrigger trigger,
            int runs,
            int? maximumWaitingRuns = null)
            where TTrigger : IWorkflowTrigger
        {
            if (trigger == null) throw new ArgumentNullException(nameof(trigger));
            trigger.Configuration.Require(WorkflowTriggerSettingProfile.Concurrency, trigger.Name);
            if (runs < 1 || runs > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(runs), "Trigger concurrency must be between 1 and 100.");
            }
            if (maximumWaitingRuns is < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(maximumWaitingRuns), "Maximum waiting runs must be positive.");
            }
            trigger.Configuration.ConcurrentRuns = runs;
            trigger.Configuration.MaximumWaitingRuns = maximumWaitingRuns;
            return trigger;
        }

        /// <summary>
        /// Configures the workflow run client tracking identifier.
        /// </summary>
        public static TTrigger WithClientTrackingId<TTrigger>(
            this TTrigger trigger,
            Expression<Func<string>> clientTrackingId)
            where TTrigger : IWorkflowTrigger
        {
            if (trigger == null) throw new ArgumentNullException(nameof(trigger));
            var descriptor = WorkflowExpression.Compile(
                clientTrackingId,
                nameof(clientTrackingId),
                required: true);
            trigger.Configuration.Require(WorkflowTriggerSettingProfile.Correlation, trigger.Name);
            trigger.Configuration.ClientTrackingId = ExpressionConverter.Convert(descriptor);
            return trigger;
        }

        /// <summary>
        /// Enables request-body schema validation for a trigger.
        /// </summary>
        public static TTrigger WithSchemaValidation<TTrigger>(this TTrigger trigger)
            where TTrigger : IWorkflowTrigger
        {
            if (trigger == null) throw new ArgumentNullException(nameof(trigger));
            trigger.Configuration.Require(WorkflowTriggerSettingProfile.SchemaValidation, trigger.Name);
            trigger.Configuration.SchemaValidationEnabled = true;
            return trigger;
        }
    }
}
