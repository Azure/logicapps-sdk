//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acssmsevents
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcssmseventsActions([ConnectionName] string connectionId)
    {
    }

    public class AcssmseventsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acssmsevents;

    public partial class WorkflowManagedActions
    {
        public AcssmseventsActions Acssmsevents(string connectionId) => new AcssmseventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcssmseventsTriggers Acssmsevents(string connectionId) => new AcssmseventsTriggers(connectionId);
    }
}