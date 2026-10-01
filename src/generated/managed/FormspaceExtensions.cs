//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Formspace
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FormspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "formspace")]
        public IBodyWorkflowAction<object> GetResponsePdf([WorkflowExpression] Func<string> responseId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/responses/{0}/pdf", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(responseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }
    }

    public class FormspaceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Subscription> WhenResponseSubmitted([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/forms/{1}/subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<Subscription>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Subscription> WhenInvokedByWorkflow([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> subscriptionnameInFormspace, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/workflow-subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscriptionpropCount++;
                subscription["name"] = SourceExpressionConverter.ConvertToken(subscriptionnameInFormspace);
                subscription["notificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<Subscription>(BuildSourceInput, triggerName, recurrence);
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