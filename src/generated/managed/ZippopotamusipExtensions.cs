//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zippopotamusip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZippopotamusipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippopotamusip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDetailsByPostalCode))]
        public IBodyWorkflowAction<GetDetailsByPostalCodeResponse> GetDetailsByPostalCode([WorkflowExpression] Func<countryInput> country, [WorkflowExpression] Func<string> postalCode)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippopotamusip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDetailsByPostalCodeResponse> __BuildGetDetailsByPostalCode(WorkflowExpression<countryInput> country, WorkflowExpression<string> postalCode)
        {
            WorkflowExpression.Validate(country, nameof(country), required: true);
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: true);
            return new DeferredBodyAction<GetDetailsByPostalCodeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(country, 1), ExpressionConverter.ConvertWithUrlEncoding(postalCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDetailsByPostalCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippopotamusip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDetailsByStateCity))]
        public IBodyWorkflowAction<GetDetailsByStateCityResponse> GetDetailsByStateCity([WorkflowExpression] Func<countryInput> country, [WorkflowExpression] Func<string> state, [WorkflowExpression] Func<string> city)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippopotamusip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDetailsByStateCityResponse> __BuildGetDetailsByStateCity(WorkflowExpression<countryInput> country, WorkflowExpression<string> state, WorkflowExpression<string> city)
        {
            WorkflowExpression.Validate(country, nameof(country), required: true);
            WorkflowExpression.Validate(state, nameof(state), required: true);
            WorkflowExpression.Validate(city, nameof(city), required: true);
            return new DeferredBodyAction<GetDetailsByStateCityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(country, 1), ExpressionConverter.ConvertWithUrlEncoding(state, 1), ExpressionConverter.ConvertWithUrlEncoding(city, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDetailsByStateCityResponse>(callPayload);
            });
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