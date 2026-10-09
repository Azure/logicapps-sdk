//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Taggunreceiptocrscip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TaggunreceiptocrscipActions([ConnectionName] string connectionId)
    {
    }

    public class TaggunreceiptocrscipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Taggunreceiptocrscip;

    public partial class WorkflowManagedActions
    {
        public TaggunreceiptocrscipActions Taggunreceiptocrscip(string connectionId) => new TaggunreceiptocrscipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TaggunreceiptocrscipTriggers Taggunreceiptocrscip(string connectionId) => new TaggunreceiptocrscipTriggers(connectionId);
    }
}