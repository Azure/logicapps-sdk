//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkedin
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LinkedinActions([ConnectionName] string connectionId)
    {
    }

    public class LinkedinTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Linkedin;

    public partial class WorkflowManagedActions
    {
        public LinkedinActions Linkedin(string connectionId) => new LinkedinActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LinkedinTriggers Linkedin(string connectionId) => new LinkedinTriggers(connectionId);
    }
}