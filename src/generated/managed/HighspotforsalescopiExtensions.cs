//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Highspotforsalescopi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HighspotforsalescopiActions([ConnectionName] string connectionId)
    {
    }

    public class HighspotforsalescopiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Highspotforsalescopi;

    public partial class WorkflowManagedActions
    {
        public HighspotforsalescopiActions Highspotforsalescopi(string connectionId) => new HighspotforsalescopiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HighspotforsalescopiTriggers Highspotforsalescopi(string connectionId) => new HighspotforsalescopiTriggers(connectionId);
    }
}