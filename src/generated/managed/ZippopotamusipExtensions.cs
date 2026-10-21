//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zippopotamusip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZippopotamusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippopotamusip")]
        public IBodyWorkflowAction<GetDetailsByPostalCodeResponse> GetDetailsByPostalCode(Expression<Func<countryInput>> country, Expression<Func<string>> postalCode)
        {
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: true);
            return new DeferredBodyAction<GetDetailsByPostalCodeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}", __workflow_country.WithUrlEncoding(1), __workflow_postalCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDetailsByPostalCodeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippopotamusip")]
        public IBodyWorkflowAction<GetDetailsByStateCityResponse> GetDetailsByStateCity(Expression<Func<countryInput>> country, Expression<Func<string>> state, Expression<Func<string>> city)
        {
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: true);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: true);
            return new DeferredBodyAction<GetDetailsByStateCityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_country.WithUrlEncoding(1), __workflow_state.WithUrlEncoding(1), __workflow_city.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDetailsByStateCityResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class ZippopotamusipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDetailsByPostalCodeResponse
    {
        [JsonProperty("post code")]
        public string PostCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country abbreviation")]
        public string CountryAbbreviation { get; set; }

        [JsonProperty("places")]
        public GetDetailsByPostalCodeResponsePlacesTypeItem[] Places { get; set; }
    }

    public class GetDetailsByPostalCodeResponsePlacesTypeItem
    {
        [JsonProperty("place name")]
        public string PlaceName { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state abbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum countryInput
    {
        AD,
        AR,
        AS,
        AT,
        AU,
        BD,
        BE,
        BG,
        BR,
        CA,
        CH,
        CZ,
        DE,
        DK,
        DO,
        ES,
        FI,
        FO,
        FR,
        GB,
        GF,
        GG,
        GL,
        GP,
        GT,
        GU,
        GY,
        HR,
        HU,
        IM,
        IN,
        IS,
        IT,
        JE,
        JP,
        LI,
        LK,
        LT,
        LU,
        MC,
        MD,
        MH,
        MK,
        MP,
        MQ,
        MX,
        MY,
        NL,
        NO,
        NZ,
        PH,
        PK,
        PL,
        PM,
        PR,
        PT,
        RE,
        RU,
        SE,
        SI,
        SJ,
        SK,
        SM,
        TH,
        TR,
        US,
        VA,
        VI,
        YT,
        ZA
    }

    public class GetDetailsByStateCityResponse
    {
        [JsonProperty("country abbreviation")]
        public string CountryAbbreviation { get; set; }

        [JsonProperty("places")]
        public GetDetailsByStateCityResponsePlacesTypeItem[] Places { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("place name")]
        public string PlaceName { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state abbreviation")]
        public string StateAbbreviation { get; set; }
    }

    public class GetDetailsByStateCityResponsePlacesTypeItem
    {
        [JsonProperty("place name")]
        public string PlaceName { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("post code")]
        public string PostCode { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zippopotamusip;

    public partial class WorkflowManagedActions
    {
        public ZippopotamusipActions Zippopotamusip(string connectionId) => new ZippopotamusipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZippopotamusipTriggers Zippopotamusip(string connectionId) => new ZippopotamusipTriggers(connectionId);
    }
}
