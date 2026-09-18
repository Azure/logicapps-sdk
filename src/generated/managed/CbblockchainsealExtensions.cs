//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cbblockchainseal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CbblockchainsealActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IBodyWorkflowAction<CreateSealResponse> CreateSeal([WorkflowExpression] Func<string> bodyfile)
        {
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/CreateSeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSealResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IBodyWorkflowAction<ListSealsResponse> ListSeals([WorkflowExpression] Func<string> bodyfile = null)
        {
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/ListSeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListSealsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cbblockchainseal")]
        public IWorkflowAction VerifySeal([WorkflowExpression] Func<string> bodyfile, [WorkflowExpression] Func<string> bodysealId)
        {
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: true);
            SourceExpression.Validate(bodysealId, nameof(bodysealId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/VerfiySeal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                bodypropCount++;
                body["sealId"] = SourceExpressionConverter.ConvertToken(bodysealId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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