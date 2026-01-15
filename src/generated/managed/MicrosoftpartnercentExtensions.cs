//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Microsoftpartnercent
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftpartnercentActions([ConnectionName] string connectionId)
    {
    }

    public class MicrosoftpartnercentTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Microsoftpartnercent;

    public partial class WorkflowManagedActions
    {
        public MicrosoftpartnercentActions Microsoftpartnercent(string connectionId) => new MicrosoftpartnercentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftpartnercentTriggers Microsoftpartnercent(string connectionId) => new MicrosoftpartnercentTriggers(connectionId);
    }
}