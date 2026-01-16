//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openexperience
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenexperienceActions([ConnectionName] string connectionId)
    {
    }

    public class OpenexperienceTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openexperience;

    public partial class WorkflowManagedActions
    {
        public OpenexperienceActions Openexperience(string connectionId) => new OpenexperienceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenexperienceTriggers Openexperience(string connectionId) => new OpenexperienceTriggers(connectionId);
    }
}