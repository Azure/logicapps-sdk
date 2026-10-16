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
        public IBodyWorkflowAction<CreateSealResponse> CreateSeal(Expression<Func<string>> bodyfile)
        {
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: true);
            return new DeferredBodyAction<CreateSealResponse>(() =>
            {
                var apiCallPath = "/v2/CreateSeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IBodyWorkflowAction<ListSealsResponse> ListSeals(Expression<Func<string>> bodyfile = null)
        {
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: false);
            return new DeferredBodyAction<ListSealsResponse>(() =>
            {
                var apiCallPath = "/v2/ListSeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListSealsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IWorkflowAction VerifySeal(Expression<Func<string>> bodyfile, Expression<Func<string>> bodysealId)
        {
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: true);
            var __workflow_bodysealId = WorkflowExpression.Compile(bodysealId, nameof(bodysealId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/VerfiySeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                bodypropCount++;
                body["sealId"] = ExpressionConverter.ConvertO(__workflow_bodysealId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
