//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._0e1ba67744db49df80773b71242030f2Adb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _0e1ba67744db49df80773b71242030f2AdbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "0e1ba677-44db-49df-8077-3b71242030f2-adb")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class _0e1ba67744db49df80773b71242030f2AdbTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._0e1ba67744db49df80773b71242030f2Adb;

    public partial class WorkflowManagedActions
    {
        public _0e1ba67744db49df80773b71242030f2AdbActions _0e1ba67744db49df80773b71242030f2Adb(string connectionId) => new _0e1ba67744db49df80773b71242030f2AdbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _0e1ba67744db49df80773b71242030f2AdbTriggers _0e1ba67744db49df80773b71242030f2Adb(string connectionId) => new _0e1ba67744db49df80773b71242030f2AdbTriggers(connectionId);
    }
}