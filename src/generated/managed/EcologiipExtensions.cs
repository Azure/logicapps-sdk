//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecologiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EcologiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<PurchaseTreesResponse> PurchaseTrees(Expression<Func<int>> bodynumber, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodytest = null)
        {
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodytest = WorkflowExpression.Compile(bodytest, nameof(bodytest), required: false);
            return new DeferredBodyAction<PurchaseTreesResponse>(() =>
            {
                var apiCallPath = "/impact/trees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(__workflow_bodytest);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PurchaseTreesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<PurchaseOffsetsResponse> PurchaseOffsets(Expression<Func<int>> bodynumber, Expression<Func<string>> bodyunits, Expression<Func<bool>> bodytest = null)
        {
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodyunits = WorkflowExpression.Compile(bodyunits, nameof(bodyunits), required: true);
            var __workflow_bodytest = WorkflowExpression.Compile(bodytest, nameof(bodytest), required: false);
            return new DeferredBodyAction<PurchaseOffsetsResponse>(() =>
            {
                var apiCallPath = "/impact/carbon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                bodypropCount++;
                body["units"] = ExpressionConverter.ConvertO(__workflow_bodyunits);
                if (__workflow_bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(__workflow_bodytest);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PurchaseOffsetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetImpactResponse> GetImpact(Expression<Func<string>> username)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            return new DeferredBodyAction<GetImpactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/impact", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetImpactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetTreesResponse> GetTrees(Expression<Func<string>> username)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            return new DeferredBodyAction<GetTreesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/trees", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTreesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetOffsetResponse> GetOffset(Expression<Func<string>> username)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            return new DeferredBodyAction<GetOffsetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/carbon-offset", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOffsetResponse>(callPayload);
            });
        }
    }

    public class EcologiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class PurchaseTreesResponse
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("treeUrl")]
        public string TreeUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PurchaseOffsetsResponse
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("numberInTonnes")]
        public double NumberInTonnes { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GetImpactResponse
    {
        [JsonProperty("trees")]
        public int Trees { get; set; }

        [JsonProperty("carbonOffset")]
        public int CarbonOffset { get; set; }
    }

    public class GetTreesResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetOffsetResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ecologiip;

    public partial class WorkflowManagedActions
    {
        public EcologiipActions Ecologiip(string connectionId) => new EcologiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EcologiipTriggers Ecologiip(string connectionId) => new EcologiipTriggers(connectionId);
    }
}
