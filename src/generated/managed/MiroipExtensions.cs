//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Miroip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MiroipActions([ConnectionName] string connectionId)
    {
    }

    public class MiroipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Miroip;

    public partial class WorkflowManagedActions
    {
        public MiroipActions Miroip(string connectionId) => new MiroipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MiroipTriggers Miroip(string connectionId) => new MiroipTriggers(connectionId);
    }
}