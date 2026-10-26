//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Formspace
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FormspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "formspace")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> GetResponsePdf(Expression<Func<string>> responseId)
        {
            var __workflow_responseId = WorkflowExpression.Compile(responseId, nameof(responseId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/responses/{0}/pdf", __workflow_responseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }
    }

    public class FormspaceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Subscription, ApiConnectionTriggerConfiguration> WhenResponseSubmitted(Expression<Func<string>> organizationId, Expression<Func<string>> formId, FlowRecurrence recurrence = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredBodyTrigger<Subscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/forms/{1}/subscriptions", __workflow_organizationId.WithUrlEncoding(1), __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["notificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<Subscription>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<Subscription, ApiConnectionTriggerConfiguration> WhenInvokedByWorkflow(Expression<Func<string>> organizationId, Expression<Func<string>> subscriptionnameInFormspace, FlowRecurrence recurrence = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_subscriptionnameInFormspace = WorkflowExpression.Compile(subscriptionnameInFormspace, nameof(subscriptionnameInFormspace), required: true);
            return new DeferredBodyTrigger<Subscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/workflow-subscriptions", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscriptionpropCount++;
                subscription["name"] = ExpressionConverter.ConvertO(__workflow_subscriptionnameInFormspace);
                subscription["notificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<Subscription>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Subscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("triggerType")]
        public SubscriptionTriggerTypeType TriggerType { get; set; }

        [JsonProperty("formId")]
        public string FormId { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscriptionTriggerTypeType
    {
        [EnumMember(Value = "responseSubmitted")]
        ResponseSubmitted,
        [EnumMember(Value = "workflowInvoked")]
        WorkflowInvoked
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Formspace;

    public partial class WorkflowManagedActions
    {
        public FormspaceActions Formspace(string connectionId) => new FormspaceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FormspaceTriggers Formspace(string connectionId) => new FormspaceTriggers(connectionId);
    }
}