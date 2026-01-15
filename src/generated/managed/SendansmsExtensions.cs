//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Sendansms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendansmsActions([ConnectionName] string connectionId)
    {
    }

    public class SendansmsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Sendansms;

    public partial class WorkflowManagedActions
    {
        public SendansmsActions Sendansms(string connectionId) => new SendansmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SendansmsTriggers Sendansms(string connectionId) => new SendansmsTriggers(connectionId);
    }
}