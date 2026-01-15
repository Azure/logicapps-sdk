//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Getaccept
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GetacceptActions([ConnectionName] string connectionId)
    {
    }

    public class GetacceptTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Getaccept;

    public partial class WorkflowManagedActions
    {
        public GetacceptActions Getaccept(string connectionId) => new GetacceptActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GetacceptTriggers Getaccept(string connectionId) => new GetacceptTriggers(connectionId);
    }
}