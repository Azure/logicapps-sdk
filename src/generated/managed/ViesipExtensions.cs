//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Viesip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ViesipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viesip")]
        [WorkflowExpressionFactory(nameof(__BuildCheckVATValidity))]
        public IBodyWorkflowAction<CheckVATValidityResponse> CheckVATValidity([WorkflowExpression] Func<bodycountryCodeInput> bodycountryCode, [WorkflowExpression] Func<string> bodyvatNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckVATValidityResponse> __BuildCheckVATValidity(WorkflowExpression<bodycountryCodeInput> bodycountryCode, WorkflowExpression<string> bodyvatNumber)
        {
            WorkflowExpression.Validate(bodycountryCode, nameof(bodycountryCode), required: true);
            WorkflowExpression.Validate(bodyvatNumber, nameof(bodyvatNumber), required: true);
            return new DeferredBodyAction<CheckVATValidityResponse>(() =>
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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