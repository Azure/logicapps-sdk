//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Successfactorsgatewa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SuccessfactorsgatewaActions([ConnectionName] string connectionId)
    {
    }

    public class SuccessfactorsgatewaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Successfactorsgatewa;

    public partial class WorkflowManagedActions
    {
        public SuccessfactorsgatewaActions Successfactorsgatewa(string connectionId) => new SuccessfactorsgatewaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SuccessfactorsgatewaTriggers Successfactorsgatewa(string connectionId) => new SuccessfactorsgatewaTriggers(connectionId);
    }
}