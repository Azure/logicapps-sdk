//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecportabilitycheck
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecportabilitycheckActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecportabilitycheck")]
        [WorkflowExpressionFactory(nameof(__BuildVerifyPhoneNumber))]
        public IBodyWorkflowAction<VerifyPhoneNumberResponse> VerifyPhoneNumber([WorkflowExpression] Func<string> phonenumber)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VerifyPhoneNumberResponse> __BuildVerifyPhoneNumber(WorkflowValue<string> phonenumber)
        {
            WorkflowValue.Validate(phonenumber, nameof(phonenumber), required: true);
            return new DeferredBodyAction<VerifyPhoneNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/verification/v1/phone/{0}", ExpressionConverter.ConvertWithUrlEncoding(phonenumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VerifyPhoneNumberResponse>(callPayload);
            });
        }
    }

    public class TyntecportabilitycheckTriggers([ConnectionName] string connectionId)
    {
    }

    public class VerifyPhoneNumberResponse
    {
        [JsonProperty("validNumberFormat")]
        public string ValidNumberFormat { get; set; }

        [JsonProperty("activeNumber")]
        public string ActiveNumber { get; set; }

        [JsonProperty("numberType")]
        public string NumberType { get; set; }

        [JsonProperty("operatorName")]
        public string OperatorName { get; set; }

        [JsonProperty("operatorCountry")]
        public string OperatorCountry { get; set; }

        [JsonProperty("fraudRisk")]
        public string FraudRisk { get; set; }

        [JsonProperty("outreachReady")]
        public string OutreachReady { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecportabilitycheck;

    public partial class WorkflowManagedActions
    {
        public TyntecportabilitycheckActions Tyntecportabilitycheck(string connectionId) => new TyntecportabilitycheckActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TyntecportabilitycheckTriggers Tyntecportabilitycheck(string connectionId) => new TyntecportabilitycheckTriggers(connectionId);
    }
}
