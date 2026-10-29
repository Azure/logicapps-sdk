//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theweatherchannelip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheweatherchannelipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema, ApiConnectionActionConfiguration> GetConditions(Expression<Func<string>> geocode, Expression<Func<unitsInput>> units, Expression<Func<string>> language, Expression<Func<formatInput>> format)
        {
            var __workflow_geocode = WorkflowExpression.Compile(geocode, nameof(geocode), required: true);
            var __workflow_units = WorkflowExpression.Compile(units, nameof(units), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredBodyAction<SuccessSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/wx/observations/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = ExpressionConverter.Convert(__workflow_geocode);
                callPayload.Queries["units"] = ExpressionConverter.Convert(__workflow_units);
                callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction<SuccessSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema, ApiConnectionActionConfiguration> GetHeadlines(Expression<Func<string>> geocode, Expression<Func<string>> acceptHeader, Expression<Func<string>> language, Expression<Func<formatInput>> format)
        {
            var __workflow_geocode = WorkflowExpression.Compile(geocode, nameof(geocode), required: true);
            var __workflow_acceptHeader = WorkflowExpression.Compile(acceptHeader, nameof(acceptHeader), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredBodyAction<SuccessSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alerts/headlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = ExpressionConverter.Convert(__workflow_geocode);
                callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["acceptHeader"] = ExpressionConverter.Convert(__workflow_acceptHeader);
                return new ApiConnectionAction<SuccessSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theweatherchannelip")]
        public IBodyWorkflowAction<SuccessSchema, ApiConnectionActionConfiguration> GetHistory(Expression<Func<string>> geocode, Expression<Func<unitsInput>> units, Expression<Func<string>> language, Expression<Func<formatInput>> format)
        {
            var __workflow_geocode = WorkflowExpression.Compile(geocode, nameof(geocode), required: true);
            var __workflow_units = WorkflowExpression.Compile(units, nameof(units), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredBodyAction<SuccessSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/wx/conditions/historical/dailysummary/30day";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["geocode"] = ExpressionConverter.Convert(__workflow_geocode);
                callPayload.Queries["units"] = ExpressionConverter.Convert(__workflow_units);
                callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum unitsInput
    {
        [EnumMember(Value = "e")]
        E,
        [EnumMember(Value = "m")]
        M
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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