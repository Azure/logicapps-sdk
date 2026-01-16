//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dokobituniversalapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DokobituniversalapiActions([ConnectionName] string connectionId)
    {
    }

    public class DokobituniversalapiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dokobituniversalapi;

    public partial class WorkflowManagedActions
    {
        public DokobituniversalapiActions Dokobituniversalapi(string connectionId) => new DokobituniversalapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DokobituniversalapiTriggers Dokobituniversalapi(string connectionId) => new DokobituniversalapiTriggers(connectionId);
    }
}