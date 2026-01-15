//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Regexmatchingip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RegexmatchingipActions([ConnectionName] string connectionId)
    {
    }

    public class RegexmatchingipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Regexmatchingip;

    public partial class WorkflowManagedActions
    {
        public RegexmatchingipActions Regexmatchingip(string connectionId) => new RegexmatchingipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RegexmatchingipTriggers Regexmatchingip(string connectionId) => new RegexmatchingipTriggers(connectionId);
    }
}