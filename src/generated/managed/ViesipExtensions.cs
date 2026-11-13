//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Viesip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ViesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viesip")]
        public IBodyWorkflowAction<CheckVatValidityResponse, ApiConnectionActionConfiguration> CheckVatValidity(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CheckVatValidityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxation_customs/vies/services/checkVatService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CheckVatValidityResponse>(callPayload);
            });
        }
    }

    public class ViesipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CheckVatValidityResponse
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("vatNumber")]
        public string VatNumber { get; set; }

        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        [JsonProperty("valid")]
        public string Valid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(BodyInputCountryCodeType countryCode, string vatNumber)
        {
            this.CountryCode = countryCode;
            this.VatNumber = vatNumber;
        }

        [JsonProperty("countryCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCountryCodeType CountryCode { get; set; }

        [JsonProperty("vatNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VatNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCountryCodeType
    {
        AT,
        BE,
        BG,
        CY,
        CZ,
        DE,
        DK,
        EE,
        EL,
        ES,
        FI,
        FR,
        HR,
        HU,
        IE,
        IT,
        LT,
        LU,
        LV,
        MT,
        NL,
        PL,
        PT,
        RO,
        SE,
        SI,
        SK,
        XI
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Viesip;

    public partial class WorkflowManagedActions
    {
        public ViesipActions Viesip(string connectionId) => new ViesipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ViesipTriggers Viesip(string connectionId) => new ViesipTriggers(connectionId);
    }
}