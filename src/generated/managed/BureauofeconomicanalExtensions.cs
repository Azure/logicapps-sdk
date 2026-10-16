//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bureauofeconomicanal
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BureauofeconomicanalActions([ConnectionName] string connectionId)
    {
    }

    public class BureauofeconomicanalTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bureauofeconomicanal;

    public partial class WorkflowManagedActions
    {
        public BureauofeconomicanalActions Bureauofeconomicanal(string connectionId) => new BureauofeconomicanalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BureauofeconomicanalTriggers Bureauofeconomicanal(string connectionId) => new BureauofeconomicanalTriggers(connectionId);
    }
}