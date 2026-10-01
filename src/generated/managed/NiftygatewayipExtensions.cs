//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Niftygatewayip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NiftygatewayipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        public IBodyWorkflowAction<NiftiesforUserResponse> NiftiesforUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> contractAddress = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/nifties/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contractAddress != null)
                    callPayload.Queries["contractAddress"] = SourceExpressionConverter.ConvertO(contractAddress);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<NiftiesforUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        public IBodyWorkflowAction<NiftiesforCreatorResponse> NiftiesforCreator([WorkflowExpression] Func<string> creatorProfileName, [WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<int> offset)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/creators/{0}/collectors/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(creatorProfileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<NiftiesforCreatorResponse>(BuildSourceInput);
        }
    }

    public class NiftygatewayipTriggers([ConnectionName] string connectionId)
    {
    }

    public class NiftiesforUserResponse
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

    public class NiftiesforCreatorResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Niftygatewayip;

    public partial class WorkflowManagedActions
    {
        public NiftygatewayipActions Niftygatewayip(string connectionId) => new NiftygatewayipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NiftygatewayipTriggers Niftygatewayip(string connectionId) => new NiftygatewayipTriggers(connectionId);
    }
}