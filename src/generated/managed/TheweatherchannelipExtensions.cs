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
        [WorkflowExpressionFactory(nameof(__BuildGetConditions))]
        public IBodyWorkflowAction<SuccessSchema> GetConditions([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<unitsInput> units, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuccessSchema> __BuildGetConditions(WorkflowValue<string> geocode, WorkflowValue<unitsInput> units, WorkflowValue<string> language, WorkflowValue<formatInput> format)
        {
            WorkflowValue.Validate(geocode, nameof(geocode), required: true);
            WorkflowValue.Validate(units, nameof(units), required: true);
            WorkflowValue.Validate(language, nameof(language), required: true);
            WorkflowValue.Validate(format, nameof(format), required: true);
            return new DeferredBodyAction<SuccessSchema>(() =>
            {
                var apiCallPath = "/wx/observations/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = ExpressionConverter.Convert(geocode);
                callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction<SuccessSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHeadlines))]
        public IBodyWorkflowAction<SuccessSchema> GetHeadlines([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<string> acceptHeader, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuccessSchema> __BuildGetHeadlines(WorkflowValue<string> geocode, WorkflowValue<string> acceptHeader, WorkflowValue<string> language, WorkflowValue<formatInput> format)
        {
            WorkflowValue.Validate(geocode, nameof(geocode), required: true);
            WorkflowValue.Validate(acceptHeader, nameof(acceptHeader), required: true);
            WorkflowValue.Validate(language, nameof(language), required: true);
            WorkflowValue.Validate(format, nameof(format), required: true);
            return new DeferredBodyAction<SuccessSchema>(() =>
            {
                var apiCallPath = "/alerts/headlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = ExpressionConverter.Convert(geocode);
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Headers["acceptHeader"] = ExpressionConverter.Convert(acceptHeader);
                return new ApiConnectionAction<SuccessSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        [WorkflowExpressionFactory(nameof(__BuildGetHistory))]
        public IBodyWorkflowAction<SuccessSchema> GetHistory([WorkflowExpression] Func<string> geocode, [WorkflowExpression] Func<unitsInput> units, [WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuccessSchema> __BuildGetHistory(WorkflowValue<string> geocode, WorkflowValue<unitsInput> units, WorkflowValue<string> language, WorkflowValue<formatInput> format)
        {
            WorkflowValue.Validate(geocode, nameof(geocode), required: true);
            WorkflowValue.Validate(units, nameof(units), required: true);
            WorkflowValue.Validate(language, nameof(language), required: true);
            WorkflowValue.Validate(format, nameof(format), required: true);
            return new DeferredBodyAction<SuccessSchema>(() =>
            {
                var apiCallPath = "/wx/conditions/historical/dailysummary/30day";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = ExpressionConverter.Convert(geocode);
                callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction<SuccessSchema>(callPayload);
            });
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
