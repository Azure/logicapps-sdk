//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blueskysocial
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlueskysocialActions([ConnectionName] string connectionId)
    {
    }

    public class BlueskysocialTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blueskysocial;

    public partial class WorkflowManagedActions
    {
        public BlueskysocialActions Blueskysocial(string connectionId) => new BlueskysocialActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlueskysocialTriggers Blueskysocial(string connectionId) => new BlueskysocialTriggers(connectionId);
    }
}