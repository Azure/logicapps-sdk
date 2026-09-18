//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecologiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EcologiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<PurchaseTreesResponse> PurchaseTrees([WorkflowExpression] Func<int> bodynumber, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodytest = null)
        {
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytest, nameof(bodytest), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/impact/trees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytest != null)
                {
                    body["test"] = SourceExpressionConverter.ConvertToken(bodytest);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PurchaseTreesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<PurchaseOffsetsResponse> PurchaseOffsets([WorkflowExpression] Func<int> bodynumber, [WorkflowExpression] Func<string> bodyunits, [WorkflowExpression] Func<bool> bodytest = null)
        {
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            SourceExpression.Validate(bodyunits, nameof(bodyunits), required: true);
            SourceExpression.Validate(bodytest, nameof(bodytest), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/impact/carbon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                bodypropCount++;
                body["units"] = SourceExpressionConverter.ConvertToken(bodyunits);
                if (bodytest != null)
                {
                    body["test"] = SourceExpressionConverter.ConvertToken(bodytest);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PurchaseOffsetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetImpactResponse> GetImpact([WorkflowExpression] Func<string> username)
        {
            SourceExpression.Validate(username, nameof(username), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/impact", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetImpactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetTreesResponse> GetTrees([WorkflowExpression] Func<string> username)
        {
            SourceExpression.Validate(username, nameof(username), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/trees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTreesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecologiip")]
        public IBodyWorkflowAction<GetOffsetResponse> GetOffset([WorkflowExpression] Func<string> username)
        {
            SourceExpression.Validate(username, nameof(username), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/carbon-offset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOffsetResponse>(BuildSourceInput);
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