//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Customjs
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CustomjsActions([ConnectionName] string connectionId)
    {
    }

    public class CustomjsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Customjs;

    public partial class WorkflowManagedActions
    {
        public CustomjsActions Customjs(string connectionId) => new CustomjsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CustomjsTriggers Customjs(string connectionId) => new CustomjsTriggers(connectionId);
    }
}