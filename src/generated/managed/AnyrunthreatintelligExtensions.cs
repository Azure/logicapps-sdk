//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anyrunthreatintellig
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnyrunthreatintelligActions([ConnectionName] string connectionId)
    {
    }

    public class AnyrunthreatintelligTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Anyrunthreatintellig;

    public partial class WorkflowManagedActions
    {
        public AnyrunthreatintelligActions Anyrunthreatintellig(string connectionId) => new AnyrunthreatintelligActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnyrunthreatintelligTriggers Anyrunthreatintellig(string connectionId) => new AnyrunthreatintelligTriggers(connectionId);
    }
}