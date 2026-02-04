//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Facebook
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FacebookActions([ConnectionName] string connectionId)
    {
    }

    public class FacebookTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Facebook;

    public partial class WorkflowManagedActions
    {
        public FacebookActions Facebook(string connectionId) => new FacebookActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FacebookTriggers Facebook(string connectionId) => new FacebookTriggers(connectionId);
    }
}