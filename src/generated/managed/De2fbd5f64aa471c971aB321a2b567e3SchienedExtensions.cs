//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.De2fbd5f64aa471c971aB321a2b567e3Schiened
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class De2fbd5f64aa471c971aB321a2b567e3SchienedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "de2fbd5f-64aa-471c-971a-b321a2b567e3-schiened")]
        public IWorkflowAction OpId()
        {
            var apiCallPath = "/hello";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class De2fbd5f64aa471c971aB321a2b567e3SchienedTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.De2fbd5f64aa471c971aB321a2b567e3Schiened;

    public partial class WorkflowManagedActions
    {
        public De2fbd5f64aa471c971aB321a2b567e3SchienedActions De2fbd5f64aa471c971aB321a2b567e3Schiened(string connectionId) => new De2fbd5f64aa471c971aB321a2b567e3SchienedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public De2fbd5f64aa471c971aB321a2b567e3SchienedTriggers De2fbd5f64aa471c971aB321a2b567e3Schiened(string connectionId) => new De2fbd5f64aa471c971aB321a2b567e3SchienedTriggers(connectionId);
    }
}