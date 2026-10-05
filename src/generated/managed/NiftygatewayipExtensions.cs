//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Niftygatewayip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NiftygatewayipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        [WorkflowExpressionFactory(nameof(__BuildNiftiesforUser))]
        public IBodyWorkflowAction<NiftiesforUserResponse> NiftiesforUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> contractAddress = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NiftiesforUserResponse> __BuildNiftiesforUser(WorkflowValue<string> username, WorkflowValue<string> contractAddress = null, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(username, nameof(username), required: true);
            WorkflowValue.Validate(contractAddress, nameof(contractAddress), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<NiftiesforUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/nifties/", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contractAddress != null)
                    callPayload.Queries["contractAddress"] = ExpressionConverter.Convert(contractAddress);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<NiftiesforUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "niftygatewayip")]
        [WorkflowExpressionFactory(nameof(__BuildNiftiesforCreator))]
        public IBodyWorkflowAction<NiftiesforCreatorResponse> NiftiesforCreator([WorkflowExpression] Func<string> creatorProfileName, [WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<int> offset)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NiftiesforCreatorResponse> __BuildNiftiesforCreator(WorkflowValue<string> creatorProfileName, WorkflowValue<int> limit, WorkflowValue<int> offset)
        {
            WorkflowValue.Validate(creatorProfileName, nameof(creatorProfileName), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: true);
            WorkflowValue.Validate(offset, nameof(offset), required: true);
            return new DeferredBodyAction<NiftiesforCreatorResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/creators/{0}/collectors/", ExpressionConverter.ConvertWithUrlEncoding(creatorProfileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
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
