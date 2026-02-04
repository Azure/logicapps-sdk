//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Writesonicip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WritesonicipActions([ConnectionName] string connectionId)
    {
    }

    public class WritesonicipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Writesonicip;

    public partial class WorkflowManagedActions
    {
        public WritesonicipActions Writesonicip(string connectionId) => new WritesonicipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WritesonicipTriggers Writesonicip(string connectionId) => new WritesonicipTriggers(connectionId);
    }
}