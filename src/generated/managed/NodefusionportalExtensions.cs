//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nodefusionportal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NodefusionportalActions([ConnectionName] string connectionId)
    {
    }

    public class NodefusionportalTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nodefusionportal;

    public partial class WorkflowManagedActions
    {
        public NodefusionportalActions Nodefusionportal(string connectionId) => new NodefusionportalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NodefusionportalTriggers Nodefusionportal(string connectionId) => new NodefusionportalTriggers(connectionId);
    }
}