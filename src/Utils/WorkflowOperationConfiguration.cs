// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json.Linq;

    internal static class WorkflowOperationConfiguration
    {
        private const int MaximumTrackedProperties = 16;
        private const int MinimumParallelIterations = 1;
        private const int MaximumParallelIterations = 50;
        private const int MinimumTriggerConcurrentRuns = 1;
        private const int MaximumTriggerConcurrentRuns = 100;
        private const int MinimumTriggerWaitingRuns = 10;
        private const int MaximumTriggerWaitingRuns = 100;

        internal static void ApplyActionConfiguration(
            IWorkflowOperationConfiguration configuration,
            FlowTemplateAction definition,
            FlowKind? flowKind)
        {
            if (configuration is IRetryPolicyConfiguration retry &&
                retry.RetryPolicy != null)
            {
                ValidateRetryPolicy(retry.RetryPolicy, flowKind);
                AddRetryPolicy(definition, retry.RetryPolicy);
            }

            if (configuration is ITrackedPropertiesConfiguration tracked)
            {
                ValidateTrackedProperties(tracked);
                if (tracked.TrackedProperties.Count > 0)
                {
                    definition.TrackedProperties = new JObject(
                        tracked.TrackedProperties.Select(
                            pair => new JProperty(pair.Key, pair.Value())));
                }
            }

            var secureInputs = configuration is ISecureInputsConfiguration inputs && inputs.SecureInputs;
            var secureOutputs =
                configuration is ISecureInputsAndOutputsConfiguration
                    ? secureInputs
                    : configuration is ISecureOutputsConfiguration outputs &&
                        outputs.SecureOutputs;

            var secureProperties = SecureProperties(secureInputs, secureOutputs);
            var concurrency = configuration as IIterationConcurrencyConfiguration;
            ValidateIterationConcurrency(concurrency);
            if (secureProperties.Length > 0 || concurrency?.MaximumParallelIterations.HasValue == true)
            {
                definition.RuntimeConfiguration ??= new FlowTemplateOperationRuntimeConfiguration();
            }

            if (secureProperties.Length > 0)
            {
                definition.RuntimeConfiguration.SecureData =
                    new FlowSecureDataConfiguration { Properties = secureProperties };
            }

            if (concurrency?.MaximumParallelIterations.HasValue == true)
            {
                if (flowKind == FlowKind.Stateless)
                {
                    throw new InvalidOperationException("For Each concurrency control is not supported for stateless workflows.");
                }
                definition.RuntimeConfiguration.Concurrency =
                    new FlowConcurrencyConfiguration { Repetitions = concurrency.MaximumParallelIterations };
            }
        }

        internal static void ApplyTriggerConfiguration(
            IWorkflowOperationConfiguration configuration,
            FlowTemplateTrigger definition,
            FlowKind? flowKind)
        {
            if (configuration is IRetryPolicyConfiguration retry &&
                retry.RetryPolicy != null)
            {
                ValidateRetryPolicy(retry.RetryPolicy, flowKind);
                AddRetryPolicy(definition, retry.RetryPolicy);
            }

            var secureInputs = configuration is ISecureInputsConfiguration inputs && inputs.SecureInputs;
            var secureOutputs = configuration is ISecureOutputsConfiguration outputs && outputs.SecureOutputs;
            var secureProperties = SecureProperties(secureInputs, secureOutputs);
            var concurrency = configuration as ITriggerConcurrencyConfiguration;
            ValidateTriggerConcurrency(concurrency);
            if (secureProperties.Length > 0 || concurrency?.ConcurrentRuns.HasValue == true)
            {
                definition.RuntimeConfiguration ??= new FlowTemplateOperationRuntimeConfiguration();
            }

            if (secureProperties.Length > 0)
            {
                definition.RuntimeConfiguration.SecureData =
                    new FlowSecureDataConfiguration { Properties = secureProperties };
            }

            if (concurrency?.ConcurrentRuns.HasValue == true)
            {
                if (flowKind == FlowKind.Stateless)
                {
                    throw new InvalidOperationException("Trigger concurrency control is not supported for stateless workflows.");
                }
                definition.RuntimeConfiguration.Concurrency = new FlowConcurrencyConfiguration
                {
                    Runs = concurrency.ConcurrentRuns,
                    MaximumWaitingRuns = concurrency.MaximumWaitingRuns,
                };
            }

            if (configuration is IClientTrackingIdConfiguration correlation &&
                correlation.ClientTrackingId != null)
            {
                definition.Correlation =
                    new FlowTemplateCorrelation { ClientTrackingId = correlation.ClientTrackingId() };
            }

            if (configuration is IRequestSchemaValidationConfiguration schemaValidation &&
                schemaValidation.SchemaValidationEnabled)
            {
                var inputObject = ToObject(definition.Inputs);
                if (inputObject["schema"] == null || inputObject["schema"].Type == JTokenType.Null)
                {
                    throw new InvalidOperationException("Schema validation requires a request body JSON schema.");
                }
                definition.OperationOptions =
                    (definition.OperationOptions ?? OperationOptions.None) |
                    OperationOptions.EnableSchemaValidation;
            }
        }

        private static void AddRetryPolicy(FlowTemplateOperation definition, RetryPolicy retryPolicy)
        {
            var inputs = ToObject(definition.Inputs);
            inputs["retryPolicy"] = retryPolicy.ToJToken();
            definition.Inputs = inputs;
        }

        private static JObject ToObject(object inputs)
        {
            if (inputs is JObject jObject)
            {
                return jObject;
            }
            if (inputs == null)
            {
                return new JObject();
            }

            var token = inputs as JToken ?? inputs.ToJToken();
            return token as JObject
                ?? throw new InvalidOperationException("The operation inputs must be a JSON object to configure this setting.");
        }

        private static string[] SecureProperties(bool secureInputs, bool secureOutputs)
        {
            var properties = new List<string>(2);
            if (secureInputs) properties.Add("inputs");
            if (secureOutputs) properties.Add("outputs");
            return properties.ToArray();
        }

        private static void ValidateTrackedProperties(
            ITrackedPropertiesConfiguration tracked)
        {
            if (tracked.TrackedProperties.Count > MaximumTrackedProperties)
            {
                throw new InvalidOperationException(
                    $"Logic Apps supports at most {MaximumTrackedProperties} tracked properties per action.");
            }

            foreach (var trackedProperty in tracked.TrackedProperties)
            {
                if (string.IsNullOrWhiteSpace(trackedProperty.Key))
                {
                    throw new InvalidOperationException("A tracked property name is required.");
                }

                if (trackedProperty.Value == null)
                {
                    throw new InvalidOperationException(
                        $"Tracked property '{trackedProperty.Key}' does not have a value.");
                }
            }
        }

        private static void ValidateIterationConcurrency(
            IIterationConcurrencyConfiguration concurrency)
        {
            if (concurrency?.MaximumParallelIterations is < MinimumParallelIterations or > MaximumParallelIterations)
            {
                throw new InvalidOperationException(
                    $"Iteration concurrency must be between {MinimumParallelIterations} and {MaximumParallelIterations}.");
            }
        }

        private static void ValidateTriggerConcurrency(
            ITriggerConcurrencyConfiguration concurrency)
        {
            if (concurrency == null)
            {
                return;
            }

            if (concurrency.MaximumWaitingRuns.HasValue &&
                !concurrency.ConcurrentRuns.HasValue)
            {
                throw new InvalidOperationException(
                    "Maximum waiting runs requires trigger concurrency control.");
            }

            if (concurrency.ConcurrentRuns is < MinimumTriggerConcurrentRuns or > MaximumTriggerConcurrentRuns)
            {
                throw new InvalidOperationException(
                    $"Trigger concurrency must be between {MinimumTriggerConcurrentRuns} and {MaximumTriggerConcurrentRuns}.");
            }

            if (concurrency.MaximumWaitingRuns is < MinimumTriggerWaitingRuns or > MaximumTriggerWaitingRuns)
            {
                throw new InvalidOperationException(
                    $"Maximum waiting runs must be between {MinimumTriggerWaitingRuns} and {MaximumTriggerWaitingRuns}.");
            }
        }

        private static void ValidateRetryPolicy(RetryPolicy retryPolicy, FlowKind? flowKind)
        {
            if (retryPolicy.Type == null || retryPolicy.Type == RetryType.NotSpecified)
            {
                throw new InvalidOperationException("A retry policy type is required.");
            }

            if (retryPolicy.Type is RetryType.Default or RetryType.None)
            {
                if (retryPolicy.Count != null || retryPolicy.Interval != null ||
                    retryPolicy.MinimumInterval != null || retryPolicy.MaximumInterval != null)
                {
                    throw new InvalidOperationException(
                        $"Retry policy type '{retryPolicy.Type}' does not accept interval or count settings.");
                }
                return;
            }

            if (!retryPolicy.Count.HasValue)
            {
                throw new InvalidOperationException("A retry count is required.");
            }

            if (retryPolicy.Count is < 1 or > 90)
            {
                throw new InvalidOperationException("Retry count must be between 1 and 90.");
            }

            if (retryPolicy.Interval is null || retryPolicy.Interval <= TimeSpan.Zero)
            {
                throw new InvalidOperationException("A positive retry interval is required.");
            }

            ValidateRetryInterval(retryPolicy.Interval.Value, flowKind, "Retry interval");
            if (retryPolicy.Type == RetryType.Fixed &&
                (retryPolicy.MinimumInterval != null || retryPolicy.MaximumInterval != null))
            {
                throw new InvalidOperationException("Fixed retry policies do not accept minimum or maximum intervals.");
            }

            if (retryPolicy.MinimumInterval <= TimeSpan.Zero || retryPolicy.MaximumInterval <= TimeSpan.Zero)
            {
                throw new InvalidOperationException("Retry interval bounds must be positive.");
            }

            if (retryPolicy.MinimumInterval.HasValue)
            {
                ValidateRetryInterval(retryPolicy.MinimumInterval.Value, flowKind, "Minimum retry interval");
            }

            if (retryPolicy.MaximumInterval.HasValue)
            {
                ValidateRetryInterval(retryPolicy.MaximumInterval.Value, flowKind, "Maximum retry interval");
            }

            if (retryPolicy.MinimumInterval > retryPolicy.MaximumInterval)
            {
                throw new InvalidOperationException("The minimum retry interval cannot exceed the maximum retry interval.");
            }
        }

        private static void ValidateRetryInterval(
            TimeSpan interval,
            FlowKind? flowKind,
            string settingName)
        {
            var minimum = flowKind == FlowKind.Stateless
                ? TimeSpan.FromSeconds(1)
                : TimeSpan.FromSeconds(5);
            var maximum = flowKind == FlowKind.Stateless
                ? TimeSpan.FromMinutes(1)
                : TimeSpan.FromDays(1);
            if (interval < minimum || interval > maximum)
            {
                throw new InvalidOperationException(
                    $"{settingName} must be between {minimum} and {maximum} for {flowKind ?? FlowKind.Stateful} workflows.");
            }
        }
    }
}
