//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Ibmwatsonassistantip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IbmwatsonassistantipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsonassistantip")]
        public IBodyWorkflowAction<CreateSessionResponse> CreateSession(Expression<Func<string>> version)
        {
            var apiCallPath = "/sessions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["version"] = ExpressionConverter.Convert(version);
            return new ApiConnectionAction<CreateSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsonassistantip")]
        public IWorkflowAction DeleteSession(Expression<Func<string>> session, Expression<Func<string>> version = null)
        {
            var apiCallPath = String.Format("/sessions/{0}", ExpressionConverter.ConvertWithUrlEncoding(session, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["version"] = Convert.ToString("2021-11-27");
            if (version != null)
                callPayload.Queries["version"] = ExpressionConverter.Convert(version);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class IbmwatsonassistantipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateSessionResponse
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Ibmwatsonassistantip;

    public partial class WorkflowManagedActions
    {
        public IbmwatsonassistantipActions Ibmwatsonassistantip(string connectionId) => new IbmwatsonassistantipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IbmwatsonassistantipTriggers Ibmwatsonassistantip(string connectionId) => new IbmwatsonassistantipTriggers(connectionId);
    }
}