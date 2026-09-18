//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Corporatebuzzwordip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CorporatebuzzwordipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corporatebuzzwordip")]
        public IBodyWorkflowAction<PhraseResponse> Phrase()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PhraseResponse>(BuildSourceInput);
        }
    }

    public class CorporatebuzzwordipTriggers([ConnectionName] string connectionId)
    {
    }

    public class PhraseResponse
    {
        [JsonProperty("phrase")]
        public string Phrase { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Corporatebuzzwordip;

    public partial class WorkflowManagedActions
    {
        public CorporatebuzzwordipActions Corporatebuzzwordip(string connectionId) => new CorporatebuzzwordipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CorporatebuzzwordipTriggers Corporatebuzzwordip(string connectionId) => new CorporatebuzzwordipTriggers(connectionId);
    }
}