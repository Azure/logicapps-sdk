//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Michaelscottquotesip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MichaelscottquotesipActions([ConnectionName] string connectionId)
    {
    }

    public class MichaelscottquotesipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Michaelscottquotesip;

    public partial class WorkflowManagedActions
    {
        public MichaelscottquotesipActions Michaelscottquotesip(string connectionId) => new MichaelscottquotesipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MichaelscottquotesipTriggers Michaelscottquotesip(string connectionId) => new MichaelscottquotesipTriggers(connectionId);
    }
}