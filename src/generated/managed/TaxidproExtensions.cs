//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Taxidpro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TaxidproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taxidpro")]
        public IBodyWorkflowAction<ValidateResponse> Validate(Expression<Func<string>> country, Expression<Func<string>> tin, Expression<Func<typeInput>> type = null, Expression<Func<localeInput>> locale = null, Expression<Func<bool>> isIrs = null)
        {
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: true);
            var __workflow_tin = tin == null ? null : WorkflowExpression.Compile(tin);
            WorkflowExpression.Validate(__workflow_tin, nameof(tin), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_locale = locale == null ? null : WorkflowExpression.Compile(locale);
            WorkflowExpression.Validate(__workflow_locale, nameof(locale), required: false);
            var __workflow_isIrs = isIrs == null ? null : WorkflowExpression.Compile(isIrs);
            WorkflowExpression.Validate(__workflow_isIrs, nameof(isIrs), required: false);
            return new DeferredBodyAction<ValidateResponse>(() =>
            {
                var apiCallPath = "/validate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["tin"] = ExpressionConverter.Convert(__workflow_tin);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                if (__workflow_isIrs != null)
                    callPayload.Queries["is_irs"] = ExpressionConverter.Convert(__workflow_isIrs);
                return new ApiConnectionAction<ValidateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taxidpro")]
        public IBodyWorkflowAction<LookupResponse> Lookup(Expression<Func<string>> country, Expression<Func<string>> tin, Expression<Func<typeInput>> type = null, Expression<Func<localeInput>> locale = null, Expression<Func<bool>> isIrs = null)
        {
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: true);
            var __workflow_tin = tin == null ? null : WorkflowExpression.Compile(tin);
            WorkflowExpression.Validate(__workflow_tin, nameof(tin), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_locale = locale == null ? null : WorkflowExpression.Compile(locale);
            WorkflowExpression.Validate(__workflow_locale, nameof(locale), required: false);
            var __workflow_isIrs = isIrs == null ? null : WorkflowExpression.Compile(isIrs);
            WorkflowExpression.Validate(__workflow_isIrs, nameof(isIrs), required: false);
            return new DeferredBodyAction<LookupResponse>(() =>
            {
                var apiCallPath = "/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["tin"] = ExpressionConverter.Convert(__workflow_tin);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                if (__workflow_isIrs != null)
                    callPayload.Queries["is_irs"] = ExpressionConverter.Convert(__workflow_isIrs);
                return new ApiConnectionAction<LookupResponse>(callPayload);
            });
        }
    }

    public class TaxidproTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateResponse
    {
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("tin_compact")]
        public string TinCompact { get; set; }

        [JsonProperty("tin_standard")]
        public string TinStandard { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("format_name")]
        public string FormatName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "individual")]
        Individual,
        [EnumMember(Value = "entity")]
        Entity,
        [EnumMember(Value = "vat")]
        Vat
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum localeInput
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "jp")]
        Jp,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "es")]
        Es
    }

    public class LookupResponse
    {
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("tin_compact")]
        public string TinCompact { get; set; }

        [JsonProperty("tin_standard")]
        public string TinStandard { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("format_name")]
        public string FormatName { get; set; }

        [JsonProperty("lookup_data")]
        public LookupResponseLookupDataType LookupData { get; set; }
    }

    public class LookupResponseLookupDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Taxidpro;

    public partial class WorkflowManagedActions
    {
        public TaxidproActions Taxidpro(string connectionId) => new TaxidproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TaxidproTriggers Taxidpro(string connectionId) => new TaxidproTriggers(connectionId);
    }
}
