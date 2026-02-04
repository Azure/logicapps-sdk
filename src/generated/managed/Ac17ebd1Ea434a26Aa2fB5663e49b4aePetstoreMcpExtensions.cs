//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ac17ebd1-ea43-4a26-aa2f-b5663e49b4ae-petstore-mcp")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcpTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcp;

    public partial class WorkflowManagedActions
    {
        public Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcpActions Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcp(string connectionId) => new Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcpTriggers Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcp(string connectionId) => new Ac17ebd1Ea434a26Aa2fB5663e49b4aePetstoreMcpTriggers(connectionId);
    }
}