//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractibanvalidato
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractibanvalidatoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractibanvalidato")]
        public IBodyWorkflowAction<ValidateResponse> Validate([WorkflowExpression] Func<string> iban)
        {
            SourceExpression.Validate(iban, nameof(iban), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["iban"] = SourceExpressionConverter.ConvertO(iban);
                return callPayload;
            }

            return new ApiConnectionAction<ValidateResponse>(BuildSourceInput);
        }
    }

    public class AbstractibanvalidatoTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateResponse
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractibanvalidato;

    public partial class WorkflowManagedActions
    {
        public AbstractibanvalidatoActions Abstractibanvalidato(string connectionId) => new AbstractibanvalidatoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractibanvalidatoTriggers Abstractibanvalidato(string connectionId) => new AbstractibanvalidatoTriggers(connectionId);
    }
}