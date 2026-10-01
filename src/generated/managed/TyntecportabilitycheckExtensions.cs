//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecportabilitycheck
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecportabilitycheckActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecportabilitycheck")]
        public IBodyWorkflowAction<VerifyPhoneNumberResponse> VerifyPhoneNumber([WorkflowExpression] Func<string> phonenumber)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/verification/v1/phone/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phonenumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VerifyPhoneNumberResponse>(BuildSourceInput);
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