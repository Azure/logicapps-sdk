//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Niftygatewayip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NiftygatewayipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        public IBodyWorkflowAction<NiftiesforUserResponse> NiftiesforUser(Expression<Func<string>> username, Expression<Func<string>> contractAddress = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/users/{0}/nifties/", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contractAddress != null)
                callPayload.Queries["contractAddress"] = ExpressionConverter.Convert(contractAddress);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<NiftiesforUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        public IBodyWorkflowAction<NiftiesforCreatorResponse> NiftiesforCreator(Expression<Func<string>> creatorProfileName, Expression<Func<int>> limit, Expression<Func<int>> offset)
        {
            var apiCallPath = String.Format("/creators/{0}/collectors/", ExpressionConverter.ConvertWithUrlEncoding(creatorProfileName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<NiftiesforCreatorResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Niftygatewayip;

    public partial class WorkflowManagedActions
    {
        public NiftygatewayipActions Niftygatewayip(string connectionId) => new NiftygatewayipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NiftygatewayipTriggers Niftygatewayip(string connectionId) => new NiftygatewayipTriggers(connectionId);
    }
}