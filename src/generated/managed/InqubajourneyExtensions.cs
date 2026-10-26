//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inqubajourney
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InqubajourneyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PublishEvent(Expression<Func<string>> tenantName, Expression<Func<string>> authorizationToken, Expression<Func<PublishEventInput>> body)
        {
            var __workflow_tenantName = WorkflowExpression.Compile(tenantName, nameof(tenantName), required: true);
            var __workflow_authorizationToken = WorkflowExpression.Compile(authorizationToken, nameof(authorizationToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cems/api/Events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = ExpressionConverter.Convert(__workflow_tenantName);
                callPayload.Headers["AuthorizationToken"] = ExpressionConverter.Convert(__workflow_authorizationToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PublishTransaction(Expression<Func<string>> tenantName, Expression<Func<string>> authorizationToken, Expression<Func<PublishTransactionInput>> body = null)
        {
            var __workflow_tenantName = WorkflowExpression.Compile(tenantName, nameof(tenantName), required: true);
            var __workflow_authorizationToken = WorkflowExpression.Compile(authorizationToken, nameof(authorizationToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cems/api/Transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = ExpressionConverter.Convert(__workflow_tenantName);
                callPayload.Headers["AuthorizationToken"] = ExpressionConverter.Convert(__workflow_authorizationToken);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class InqubajourneyTriggers([ConnectionName] string connectionId)
    {
    }

    public class PublishEventInput
    {
        [JsonProperty("eventDefinitionCode")]
        public string EventDefinitionCode { get; set; }

        [JsonProperty("isTest")]
        public bool? IsTest { get; set; }

        [JsonProperty("attributes")]
        public PublishEventInputAttributesTypeItem[] Attributes { get; set; }
    }

    public class PublishEventInputAttributesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PublishTransactionInput
    {
        [JsonProperty("transactionDefinitionCode")]
        public string TransactionDefinitionCode { get; set; }

        [JsonProperty("isTest")]
        public bool? IsTest { get; set; }

        [JsonProperty("attributes")]
        public PublishTransactionInputAttributesTypeItem[] Attributes { get; set; }
    }

    public class PublishTransactionInputAttributesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Inqubajourney;

    public partial class WorkflowManagedActions
    {
        public InqubajourneyActions Inqubajourney(string connectionId) => new InqubajourneyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InqubajourneyTriggers Inqubajourney(string connectionId) => new InqubajourneyTriggers(connectionId);
    }
}