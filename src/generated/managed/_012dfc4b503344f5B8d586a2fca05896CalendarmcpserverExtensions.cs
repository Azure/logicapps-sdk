//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._012dfc4b503344f5B8d586a2fca05896Calendarmcpserver
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _012dfc4b503344f5B8d586a2fca05896CalendarmcpserverActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "012dfc4b-5033-44f5-b8d5-86a2fca05896-calendarmcpserver")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _012dfc4b503344f5B8d586a2fca05896CalendarmcpserverTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._012dfc4b503344f5B8d586a2fca05896Calendarmcpserver;

    public partial class WorkflowManagedActions
    {
        public _012dfc4b503344f5B8d586a2fca05896CalendarmcpserverActions _012dfc4b503344f5B8d586a2fca05896Calendarmcpserver(string connectionId) => new _012dfc4b503344f5B8d586a2fca05896CalendarmcpserverActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _012dfc4b503344f5B8d586a2fca05896CalendarmcpserverTriggers _012dfc4b503344f5B8d586a2fca05896Calendarmcpserver(string connectionId) => new _012dfc4b503344f5B8d586a2fca05896CalendarmcpserverTriggers(connectionId);
    }
}