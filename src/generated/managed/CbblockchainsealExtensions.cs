//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cbblockchainseal
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CbblockchainsealActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IBodyWorkflowAction<CreateSealResponse, ApiConnectionActionConfiguration> CreateSeal(Expression<Func<CreateSealInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateSealResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/CreateSeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IBodyWorkflowAction<ListSealsResponse, ApiConnectionActionConfiguration> ListSeals(Expression<Func<ListSealsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ListSealsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/ListSeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ListSealsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IWorkflowAction<ApiConnectionActionConfiguration> VerifySeal(Expression<Func<VerifySealInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/VerfiySeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CbblockchainsealTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateSealResponse
    {
        [JsonProperty("sealId")]
        public string SealId { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("error")]
        public int Error { get; set; }
    }

    public class CreateSealInput
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }
    }

    public class ListSealsResponse
    {
        [JsonProperty("seals")]
        public ListSealsResponseSealsTypeItem[] Seals { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("error")]
        public int Error { get; set; }
    }

    public class ListSealsResponseSealsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("requestStamp")]
        public int RequestStamp { get; set; }

        [JsonProperty("tenantId")]
        public int TenantId { get; set; }

        [JsonProperty("provider")]
        public int Provider { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("origin")]
        public int Origin { get; set; }
    }

    public class ListSealsInput
    {
        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class VerifySealInput
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }

        [JsonProperty("sealId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SealId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cbblockchainseal;

    public partial class WorkflowManagedActions
    {
        public CbblockchainsealActions Cbblockchainseal(string connectionId) => new CbblockchainsealActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CbblockchainsealTriggers Cbblockchainseal(string connectionId) => new CbblockchainsealTriggers(connectionId);
    }
}