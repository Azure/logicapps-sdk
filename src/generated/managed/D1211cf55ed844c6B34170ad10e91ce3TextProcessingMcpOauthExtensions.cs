//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauth
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauthActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d1211cf5-5ed8-44c6-b341-70ad10e91ce3-text-processing-mcp-oauth")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauthTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauth;

    public partial class WorkflowManagedActions
    {
        public D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauthActions D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauth(string connectionId) => new D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauthActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauthTriggers D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauth(string connectionId) => new D1211cf55ed844c6B34170ad10e91ce3TextProcessingMcpOauthTriggers(connectionId);
    }
}