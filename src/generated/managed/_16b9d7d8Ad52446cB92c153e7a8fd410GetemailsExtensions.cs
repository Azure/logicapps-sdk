//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._16b9d7d8Ad52446cB92c153e7a8fd410Getemails
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _16b9d7d8Ad52446cB92c153e7a8fd410GetemailsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "16b9d7d8-ad52-446c-b92c-153e7a8fd410-getemails")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _16b9d7d8Ad52446cB92c153e7a8fd410GetemailsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._16b9d7d8Ad52446cB92c153e7a8fd410Getemails;

    public partial class WorkflowManagedActions
    {
        public _16b9d7d8Ad52446cB92c153e7a8fd410GetemailsActions _16b9d7d8Ad52446cB92c153e7a8fd410Getemails(string connectionId) => new _16b9d7d8Ad52446cB92c153e7a8fd410GetemailsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _16b9d7d8Ad52446cB92c153e7a8fd410GetemailsTriggers _16b9d7d8Ad52446cB92c153e7a8fd410Getemails(string connectionId) => new _16b9d7d8Ad52446cB92c153e7a8fd410GetemailsTriggers(connectionId);
    }
}