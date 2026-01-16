//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bureauoflaborstatist
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BureauoflaborstatistActions([ConnectionName] string connectionId)
    {
    }

    public class BureauoflaborstatistTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bureauoflaborstatist;

    public partial class WorkflowManagedActions
    {
        public BureauoflaborstatistActions Bureauoflaborstatist(string connectionId) => new BureauoflaborstatistActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BureauoflaborstatistTriggers Bureauoflaborstatist(string connectionId) => new BureauoflaborstatistTriggers(connectionId);
    }
}