//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theweatherchannelip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheweatherchannelipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema> GetConditions([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<unitsInput> units, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            var apiCallPath = "/wx/observations/current";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["geocode"] = ExpressionConverter.Convert(geocode);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            return new ApiConnectionAction<SuccessSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema> GetHeadlines([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<string> acceptHeader, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            var apiCallPath = "/alerts/headlines";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["geocode"] = ExpressionConverter.Convert(geocode);
            callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Headers["acceptHeader"] = ExpressionConverter.Convert(acceptHeader);
            return new ApiConnectionAction<SuccessSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema> GetHistory([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<unitsInput> units, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            var apiCallPath = "/wx/conditions/historical/dailysummary/30day";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["geocode"] = ExpressionConverter.Convert(geocode);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            return new ApiConnectionAction<SuccessSchema>(callPayload);
        }
    }

    public class TheweatherchannelipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SuccessSchema
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

    public enum unitsInput
    {
        [EnumMember(Value = "e")]
        E,
        [EnumMember(Value = "m")]
        M
    }

    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Theweatherchannelip;

    public partial class WorkflowManagedActions
    {
        public TheweatherchannelipActions Theweatherchannelip(string connectionId) => new TheweatherchannelipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TheweatherchannelipTriggers Theweatherchannelip(string connectionId) => new TheweatherchannelipTriggers(connectionId);
    }
}