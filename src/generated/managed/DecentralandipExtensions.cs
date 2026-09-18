//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Decentralandip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DecentralandipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetDistrictsResponse> GetDistricts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/districts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDistrictsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetParcelDetailsResponse> GetParcelDetails([WorkflowExpression] Func<string> x, [WorkflowExpression] Func<string> y)
        {
            SourceExpression.Validate(x, nameof(x), required: true);
            SourceExpression.Validate(y, nameof(y), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/parcels/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(x, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(y, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetParcelDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetParcelMapResponse> GetParcelMap([WorkflowExpression] Func<string> x, [WorkflowExpression] Func<string> y, [WorkflowExpression] Func<int> width, [WorkflowExpression] Func<int> height, [WorkflowExpression] Func<int> size, [WorkflowExpression] Func<bool> publication)
        {
            SourceExpression.Validate(x, nameof(x), required: true);
            SourceExpression.Validate(y, nameof(y), required: true);
            SourceExpression.Validate(width, nameof(width), required: true);
            SourceExpression.Validate(height, nameof(height), required: true);
            SourceExpression.Validate(size, nameof(size), required: true);
            SourceExpression.Validate(publication, nameof(publication), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/parcels/{0}/{1}/map.png", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(x, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(y, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["width"] = SourceExpressionConverter.ConvertO(width);
                callPayload.Queries["height"] = SourceExpressionConverter.ConvertO(height);
                callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["publication"] = SourceExpressionConverter.ConvertO(publication);
                return callPayload;
            }

            return new ApiConnectionAction<GetParcelMapResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetTilesResponse> GetId([WorkflowExpression] Func<string> x1, [WorkflowExpression] Func<string> x2, [WorkflowExpression] Func<string> y1, [WorkflowExpression] Func<string> y2, [WorkflowExpression] Func<string> include)
        {
            SourceExpression.Validate(x1, nameof(x1), required: true);
            SourceExpression.Validate(x2, nameof(x2), required: true);
            SourceExpression.Validate(y1, nameof(y1), required: true);
            SourceExpression.Validate(y2, nameof(y2), required: true);
            SourceExpression.Validate(include, nameof(include), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x1"] = SourceExpressionConverter.ConvertO(x1);
                callPayload.Queries["x2"] = SourceExpressionConverter.ConvertO(x2);
                callPayload.Queries["y1"] = SourceExpressionConverter.ConvertO(y1);
                callPayload.Queries["y2"] = SourceExpressionConverter.ConvertO(y2);
                callPayload.Queries["include"] = SourceExpressionConverter.ConvertO(include);
                return callPayload;
            }

            return new ApiConnectionAction<GetTilesResponse>(BuildSourceInput);
        }
    }

    public class DecentralandipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDistrictsResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class StatusDetails
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("messages")]
        public Messages[] Messages { get; set; }
    }

    public class Messages
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetParcelDetailsResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class GetParcelMapResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class GetTilesResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Decentralandip;

    public partial class WorkflowManagedActions
    {
        public DecentralandipActions Decentralandip(string connectionId) => new DecentralandipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DecentralandipTriggers Decentralandip(string connectionId) => new DecentralandipTriggers(connectionId);
    }
}