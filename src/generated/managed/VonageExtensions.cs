//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vonage
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VonageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<BasicNumberInsightResponse> BasicNumberInsight([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> apiSecret, [WorkflowExpression] Func<string> number, [WorkflowExpression] Func<string> country)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(apiSecret, nameof(apiSecret), required: true);
            SourceExpression.Validate(number, nameof(number), required: true);
            SourceExpression.Validate(country, nameof(country), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ni/basic/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["api_secret"] = SourceExpressionConverter.ConvertO(apiSecret);
                callPayload.Queries["number"] = SourceExpressionConverter.ConvertO(number);
                callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                return callPayload;
            }

            return new ApiConnectionAction<BasicNumberInsightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<StandardNumberInsightResponse> StandardNumberInsight([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> apiSecret, [WorkflowExpression] Func<string> number, [WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> cnam = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(apiKey, nameof(apiKey), required: true);
            SourceExpression.Validate(apiSecret, nameof(apiSecret), required: true);
            SourceExpression.Validate(number, nameof(number), required: true);
            SourceExpression.Validate(country, nameof(country), required: true);
            SourceExpression.Validate(cnam, nameof(cnam), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ni/standard/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["api_secret"] = SourceExpressionConverter.ConvertO(apiSecret);
                callPayload.Queries["number"] = SourceExpressionConverter.ConvertO(number);
                callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (cnam != null)
                    callPayload.Queries["cnam"] = SourceExpressionConverter.ConvertO(cnam);
                return callPayload;
            }

            return new ApiConnectionAction<StandardNumberInsightResponse>(BuildSourceInput);
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