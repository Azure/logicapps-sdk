//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Microsoftloop
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftloopActions([ConnectionName] string connectionId)
    {
    }

    public class MicrosoftloopTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Microsoftloop;

    public partial class WorkflowManagedActions
    {
        public MicrosoftloopActions Microsoftloop(string connectionId) => new MicrosoftloopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftloopTriggers Microsoftloop(string connectionId) => new MicrosoftloopTriggers(connectionId);
    }
}