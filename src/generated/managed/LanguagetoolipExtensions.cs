//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Languagetoolip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LanguagetoolipActions([ConnectionName] string connectionId)
    {
    }

    public class LanguagetoolipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Languagetoolip;

    public partial class WorkflowManagedActions
    {
        public LanguagetoolipActions Languagetoolip(string connectionId) => new LanguagetoolipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LanguagetoolipTriggers Languagetoolip(string connectionId) => new LanguagetoolipTriggers(connectionId);
    }
}