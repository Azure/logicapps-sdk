//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Viesip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ViesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viesip")]
        public IBodyWorkflowAction<CheckVATValidityResponse> CheckVATValidity(Expression<Func<bodycountryCodeInput>> bodycountryCode, Expression<Func<string>> bodyvatNumber)
        {
            var apiCallPath = "/taxation_customs/vies/services/checkVatService";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["countryCode"] = ExpressionConverter.ConvertO(bodycountryCode);
            bodypropCount++;
            body["vatNumber"] = ExpressionConverter.ConvertO(bodyvatNumber);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CheckVATValidityResponse>(callPayload);
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

    public enum bodycountryCodeInput
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