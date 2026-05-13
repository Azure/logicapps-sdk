//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dayforcehcm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DayforcehcmActions([ConnectionName] string connectionId)
    {
    }

    public class DayforcehcmTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dayforcehcm;

    public partial class WorkflowManagedActions
    {
        public DayforcehcmActions Dayforcehcm(string connectionId) => new DayforcehcmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DayforcehcmTriggers Dayforcehcm(string connectionId) => new DayforcehcmTriggers(connectionId);
    }
}