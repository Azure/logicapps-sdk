//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abnlookup
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbnlookupActions([ConnectionName] string connectionId)
    {
    }

    public class AbnlookupTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abnlookup;

    public partial class WorkflowManagedActions
    {
        public AbnlookupActions Abnlookup(string connectionId) => new AbnlookupActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbnlookupTriggers Abnlookup(string connectionId) => new AbnlookupTriggers(connectionId);
    }
}