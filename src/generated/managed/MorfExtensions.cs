//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Morf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MorfActions([ConnectionName] string connectionId)
    {
    }

    public class MorfTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Morf;

    public partial class WorkflowManagedActions
    {
        public MorfActions Morf(string connectionId) => new MorfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MorfTriggers Morf(string connectionId) => new MorfTriggers(connectionId);
    }
}