//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._4babda8dD98f41f19b2c8e85ad925b41Microsoftmcpserverfor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _4babda8dD98f41f19b2c8e85ad925b41MicrosoftmcpserverforActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "4babda8d-d98f-41f1-9b2c-8e85ad925b41-microsoftmcpserverfor")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _4babda8dD98f41f19b2c8e85ad925b41MicrosoftmcpserverforTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._4babda8dD98f41f19b2c8e85ad925b41Microsoftmcpserverfor;

    public partial class WorkflowManagedActions
    {
        public _4babda8dD98f41f19b2c8e85ad925b41MicrosoftmcpserverforActions _4babda8dD98f41f19b2c8e85ad925b41Microsoftmcpserverfor(string connectionId) => new _4babda8dD98f41f19b2c8e85ad925b41MicrosoftmcpserverforActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _4babda8dD98f41f19b2c8e85ad925b41MicrosoftmcpserverforTriggers _4babda8dD98f41f19b2c8e85ad925b41Microsoftmcpserverfor(string connectionId) => new _4babda8dD98f41f19b2c8e85ad925b41MicrosoftmcpserverforTriggers(connectionId);
    }
}