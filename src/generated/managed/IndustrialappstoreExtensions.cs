//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Industrialappstore
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IndustrialappstoreActions([ConnectionName] string connectionId)
    {
    }

    public class IndustrialappstoreTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Industrialappstore;

    public partial class WorkflowManagedActions
    {
        public IndustrialappstoreActions Industrialappstore(string connectionId) => new IndustrialappstoreActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IndustrialappstoreTriggers Industrialappstore(string connectionId) => new IndustrialappstoreTriggers(connectionId);
    }
}