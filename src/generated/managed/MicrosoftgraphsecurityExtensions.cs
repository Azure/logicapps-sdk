//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftgraphsecurity
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftgraphsecurityActions([ConnectionName] string connectionId)
    {
    }

    public class MicrosoftgraphsecurityTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftgraphsecurity;

    public partial class WorkflowManagedActions
    {
        public MicrosoftgraphsecurityActions Microsoftgraphsecurity(string connectionId) => new MicrosoftgraphsecurityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftgraphsecurityTriggers Microsoftgraphsecurity(string connectionId) => new MicrosoftgraphsecurityTriggers(connectionId);
    }
}