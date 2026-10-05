//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecologiip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EcologiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        [WorkflowExpressionFactory(nameof(__BuildPurchaseTrees))]
        public IBodyWorkflowAction<PurchaseTreesResponse> PurchaseTrees([WorkflowExpression] Func<int> bodynumber, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodytest = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PurchaseTreesResponse> __BuildPurchaseTrees(WorkflowValue<int> bodynumber, WorkflowValue<string> bodyname = null, WorkflowValue<bool> bodytest = null)
        {
            WorkflowValue.Validate(bodynumber, nameof(bodynumber), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodytest, nameof(bodytest), required: false);
            return new DeferredBodyAction<PurchaseTreesResponse>(() =>
            {
                var apiCallPath = "/impact/trees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(bodytest);
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
        [WorkflowExpressionFactory(nameof(__BuildPurchaseOffsets))]
        public IBodyWorkflowAction<PurchaseOffsetsResponse> PurchaseOffsets([WorkflowExpression] Func<int> bodynumber, [WorkflowExpression] Func<string> bodyunits, [WorkflowExpression] Func<bool> bodytest = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PurchaseOffsetsResponse> __BuildPurchaseOffsets(WorkflowValue<int> bodynumber, WorkflowValue<string> bodyunits, WorkflowValue<bool> bodytest = null)
        {
            WorkflowValue.Validate(bodynumber, nameof(bodynumber), required: true);
            WorkflowValue.Validate(bodyunits, nameof(bodyunits), required: true);
            WorkflowValue.Validate(bodytest, nameof(bodytest), required: false);
            return new DeferredBodyAction<PurchaseOffsetsResponse>(() =>
            {
                var apiCallPath = "/impact/carbon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
                body["units"] = ExpressionConverter.ConvertO(bodyunits);
                if (bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(bodytest);
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
        [WorkflowExpressionFactory(nameof(__BuildGetImpact))]
        public IBodyWorkflowAction<GetImpactResponse> GetImpact([WorkflowExpression] Func<string> username)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetImpactResponse> __BuildGetImpact(WorkflowValue<string> username)
        {
            WorkflowValue.Validate(username, nameof(username), required: true);
            return new DeferredBodyAction<GetImpactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/impact", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetImpactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTrees))]
        public IBodyWorkflowAction<GetTreesResponse> GetTrees([WorkflowExpression] Func<string> username)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTreesResponse> __BuildGetTrees(WorkflowValue<string> username)
        {
            WorkflowValue.Validate(username, nameof(username), required: true);
            return new DeferredBodyAction<GetTreesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/trees", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTreesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        [WorkflowExpressionFactory(nameof(__BuildGetOffset))]
        public IBodyWorkflowAction<GetOffsetResponse> GetOffset([WorkflowExpression] Func<string> username)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOffsetResponse> __BuildGetOffset(WorkflowValue<string> username)
        {
            WorkflowValue.Validate(username, nameof(username), required: true);
            return new DeferredBodyAction<GetOffsetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/carbon-offset", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
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
