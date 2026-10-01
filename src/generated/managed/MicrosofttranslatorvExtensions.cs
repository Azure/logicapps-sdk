//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsofttranslatorv
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosofttranslatorvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsofttranslatorv")]
        public IBodyWorkflowAction<LanguageInfo[]> GetTranslateSupportedLanguages()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/languages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageInfo[]>(BuildSourceInput);
        }
    }

    public class MicrosofttranslatorvTriggers([ConnectionName] string connectionId)
    {
    }

    public class LanguageInfo
    {
        [JsonProperty("Code")]
        public string LanguageCode { get; set; }

        [JsonProperty("Name")]
        public string Language { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsofttranslatorv;

    public partial class WorkflowManagedActions
    {
        public MicrosofttranslatorvActions Microsofttranslatorv(string connectionId) => new MicrosofttranslatorvActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosofttranslatorvTriggers Microsofttranslatorv(string connectionId) => new MicrosofttranslatorvTriggers(connectionId);
    }
}