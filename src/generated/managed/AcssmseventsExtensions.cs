//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Acssmsevents
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

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Acssmsevents;

    public partial class WorkflowManagedActions
    {
        public AcssmseventsActions Acssmsevents(string connectionId) => new AcssmseventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcssmseventsTriggers Acssmsevents(string connectionId) => new AcssmseventsTriggers(connectionId);
    }
}