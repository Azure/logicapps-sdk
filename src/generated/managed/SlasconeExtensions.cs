//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Slascone
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SlasconeActions([ConnectionName] string connectionId)
    {
    }

    public class SlasconeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Slascone;

    public partial class WorkflowManagedActions
    {
        public SlasconeActions Slascone(string connectionId) => new SlasconeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SlasconeTriggers Slascone(string connectionId) => new SlasconeTriggers(connectionId);
    }
}