//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Niftygatewayip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NiftygatewayipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        public IBodyWorkflowAction<NiftiesforUserResponse> NiftiesforUser(Expression<Func<string>> username, Expression<Func<string>> contractAddress = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_contractAddress = WorkflowExpression.Compile(contractAddress, nameof(contractAddress), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<NiftiesforUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/nifties/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contractAddress != null)
                    callPayload.Queries["contractAddress"] = ExpressionConverter.Convert(__workflow_contractAddress);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<NiftiesforUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        public IBodyWorkflowAction<NiftiesforCreatorResponse> NiftiesforCreator(Expression<Func<string>> creatorProfileName, Expression<Func<int>> limit, Expression<Func<int>> offset)
        {
            var __workflow_creatorProfileName = WorkflowExpression.Compile(creatorProfileName, nameof(creatorProfileName), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: true);
            return new DeferredBodyAction<NiftiesforCreatorResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/creators/{0}/collectors/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_creatorProfileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<NiftiesforCreatorResponse>(callPayload);
            });
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
