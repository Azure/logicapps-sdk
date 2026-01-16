//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Showpad
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShowpadActions([ConnectionName] string connectionId)
    {
    }

    public class ShowpadTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Showpad;

    public partial class WorkflowManagedActions
    {
        public ShowpadActions Showpad(string connectionId) => new ShowpadActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShowpadTriggers Showpad(string connectionId) => new ShowpadTriggers(connectionId);
    }
}