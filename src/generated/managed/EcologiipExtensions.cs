//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecologiip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EcologiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<PurchaseTreesResponse> PurchaseTrees(Expression<Func<int>> bodynumber, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodytest = null)
        {
            var __workflow_bodynumber = bodynumber == null ? null : WorkflowExpression.Compile(bodynumber);
            WorkflowExpression.Validate(__workflow_bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodytest = bodytest == null ? null : WorkflowExpression.Compile(bodytest);
            WorkflowExpression.Validate(__workflow_bodytest, nameof(bodytest), required: false);
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
            var __workflow_bodynumber = bodynumber == null ? null : WorkflowExpression.Compile(bodynumber);
            WorkflowExpression.Validate(__workflow_bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodyunits = bodyunits == null ? null : WorkflowExpression.Compile(bodyunits);
            WorkflowExpression.Validate(__workflow_bodyunits, nameof(bodyunits), required: true);
            var __workflow_bodytest = bodytest == null ? null : WorkflowExpression.Compile(bodytest);
            WorkflowExpression.Validate(__workflow_bodytest, nameof(bodytest), required: false);
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
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            return new DeferredBodyAction<GetImpactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/impact", ExpressionConverter.ConvertWithUrlEncoding(__workflow_username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetImpactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetTreesResponse> GetTrees(Expression<Func<string>> username)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            return new DeferredBodyAction<GetTreesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/trees", ExpressionConverter.ConvertWithUrlEncoding(__workflow_username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTreesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetOffsetResponse> GetOffset(Expression<Func<string>> username)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            return new DeferredBodyAction<GetOffsetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/carbon-offset", ExpressionConverter.ConvertWithUrlEncoding(__workflow_username, 1));
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
