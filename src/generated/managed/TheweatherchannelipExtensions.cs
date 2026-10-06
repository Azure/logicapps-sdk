//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theweatherchannelip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheweatherchannelipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema> GetConditions([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<unitsInput> units, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/wx/observations/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = SourceExpressionConverter.ConvertO(geocode);
                callPayload.Queries["units"] = SourceExpressionConverter.Convert(units);
                callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction<SuccessSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema> GetHeadlines([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<string> acceptHeader, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alerts/headlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = SourceExpressionConverter.ConvertO(geocode);
                callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["acceptHeader"] = SourceExpressionConverter.ConvertO(acceptHeader);
                return callPayload;
            }

            return new ApiConnectionAction<SuccessSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema> GetHistory([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<unitsInput> units, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/wx/conditions/historical/dailysummary/30day";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = SourceExpressionConverter.ConvertO(geocode);
                callPayload.Queries["units"] = SourceExpressionConverter.Convert(units);
                callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction<SuccessSchema>(BuildSourceInput);
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