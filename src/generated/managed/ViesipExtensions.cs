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
        public IBodyWorkflowAction<CheckVATValidityResponse, ApiConnectionActionConfiguration> CheckVATValidity(Expression<Func<CheckVATValidityInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CheckVATValidityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxation_customs/vies/services/checkVatService";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CheckVATValidityResponse>(callPayload);
            });
        }
    }

    public class ViesipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CheckVATValidityResponse
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

    public class CheckVATValidityInput
    {
        [JsonProperty("countryCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public CheckVATValidityInputCountryCodeType CountryCode { get; set; }

        [JsonProperty("vatNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VatNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CheckVATValidityInputCountryCodeType
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