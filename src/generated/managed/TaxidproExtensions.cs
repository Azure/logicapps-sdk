//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Taxidpro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TaxidproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taxidpro")]
        public IBodyWorkflowAction<ValidateResponse> Validate([WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> tin, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<localeInput> locale = null, [WorkflowExpression] Func<bool> isIrs = null)
        {
            var apiCallPath = "/validate";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            callPayload.Queries["tin"] = ExpressionConverter.Convert(tin);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            if (isIrs != null)
                callPayload.Queries["is_irs"] = ExpressionConverter.Convert(isIrs);
            return new ApiConnectionAction<ValidateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taxidpro")]
        public IBodyWorkflowAction<LookupResponse> Lookup([WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> tin, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<localeInput> locale = null, [WorkflowExpression] Func<bool> isIrs = null)
        {
            var apiCallPath = "/lookup";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            callPayload.Queries["tin"] = ExpressionConverter.Convert(tin);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            if (isIrs != null)
                callPayload.Queries["is_irs"] = ExpressionConverter.Convert(isIrs);
            return new ApiConnectionAction<LookupResponse>(callPayload);
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

    public enum typeInput
    {
        [EnumMember(Value = "individual")]
        Individual,
        [EnumMember(Value = "entity")]
        Entity,
        [EnumMember(Value = "vat")]
        Vat
    }

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