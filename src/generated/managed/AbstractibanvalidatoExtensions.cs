//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractibanvalidato
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AbstractibanvalidatoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractibanvalidato")]
        public IBodyWorkflowAction<ValidateResponse> Validate(Expression<Func<string>> iban)
        {
            var __workflow_iban = WorkflowExpression.Compile(iban, nameof(iban), required: true);
            return new DeferredBodyAction<ValidateResponse>(() =>
            {
                var apiCallPath = "/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["iban"] = ExpressionConverter.Convert(__workflow_iban);
                return new ApiConnectionAction<ValidateResponse>(callPayload);
            });
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
