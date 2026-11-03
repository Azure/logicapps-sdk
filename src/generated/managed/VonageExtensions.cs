//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vonage
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VonageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<BasicNumberInsightResponse, ApiConnectionActionConfiguration> BasicNumberInsight(Expression<Func<formatInput>> format, Expression<Func<string>> apiKey, Expression<Func<string>> apiSecret, Expression<Func<string>> number, Expression<Func<string>> country)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_apiSecret = WorkflowExpression.Compile(apiSecret, nameof(apiSecret), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            return new DeferredBodyAction<BasicNumberInsightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ni/basic/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["api_secret"] = ExpressionConverter.Convert(__workflow_apiSecret);
                callPayload.Queries["number"] = ExpressionConverter.Convert(__workflow_number);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                return new ApiConnectionAction<BasicNumberInsightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<StandardNumberInsightResponse, ApiConnectionActionConfiguration> StandardNumberInsight(Expression<Func<formatInput>> format, Expression<Func<string>> apiKey, Expression<Func<string>> apiSecret, Expression<Func<string>> number, Expression<Func<string>> country, Expression<Func<string>> cnam = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_apiSecret = WorkflowExpression.Compile(apiSecret, nameof(apiSecret), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_cnam = WorkflowExpression.Compile(cnam, nameof(cnam), required: false);
            return new DeferredBodyAction<StandardNumberInsightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ni/standard/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["api_secret"] = ExpressionConverter.Convert(__workflow_apiSecret);
                callPayload.Queries["number"] = ExpressionConverter.Convert(__workflow_number);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_cnam != null)
                    callPayload.Queries["cnam"] = ExpressionConverter.Convert(__workflow_cnam);
                return new ApiConnectionAction<StandardNumberInsightResponse>(callPayload);
            });
        }
    }

    public class VonageTriggers([ConnectionName] string connectionId)
    {
    }

    public class BasicNumberInsightResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("international_format_number")]
        public string InternationalFormatNumber { get; set; }

        [JsonProperty("national_format_number")]
        public string NationalFormatNumber { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_code_iso3")]
        public string CountryCodeIso3 { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_prefix")]
        public string CountryPrefix { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public class StandardNumberInsightResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("international_format_number")]
        public string InternationalFormatNumber { get; set; }

        [JsonProperty("national_format_number")]
        public string NationalFormatNumber { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_code_iso3")]
        public string CountryCodeIso3 { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_prefix")]
        public string CountryPrefix { get; set; }

        [JsonProperty("request_price")]
        public string RequestPrice { get; set; }

        [JsonProperty("refund_price")]
        public string RefundPrice { get; set; }

        [JsonProperty("remaining_balance")]
        public string RemainingBalance { get; set; }

        [JsonProperty("current_carrier")]
        public StandardNumberInsightResponseCurrentCarrierType CurrentCarrier { get; set; }

        [JsonProperty("original_carrier")]
        public StandardNumberInsightResponseOriginalCarrierType OriginalCarrier { get; set; }

        [JsonProperty("ported")]
        public string Ported { get; set; }

        [JsonProperty("caller_identity")]
        public StandardNumberInsightResponseCallerIdentityType CallerIdentity { get; set; }

        [JsonProperty("caller_name")]
        public string CallerName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("caller_type")]
        public string CallerType { get; set; }
    }

    public class StandardNumberInsightResponseCurrentCarrierType
    {
        [JsonProperty("network_code")]
        public string NetworkCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("network_type")]
        public string NetworkType { get; set; }
    }

    public class StandardNumberInsightResponseOriginalCarrierType
    {
        [JsonProperty("network_code")]
        public string NetworkCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("network_type")]
        public string NetworkType { get; set; }
    }

    public class StandardNumberInsightResponseCallerIdentityType
    {
        [JsonProperty("caller_type")]
        public string CallerType { get; set; }

        [JsonProperty("caller_name")]
        public string CallerName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vonage;

    public partial class WorkflowManagedActions
    {
        public VonageActions Vonage(string connectionId) => new VonageActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VonageTriggers Vonage(string connectionId) => new VonageTriggers(connectionId);
    }
}