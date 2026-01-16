//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meword
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4mewordActions([ConnectionName] string connectionId)
    {
    }

    public class Pdf4mewordTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meword;

    public partial class WorkflowManagedActions
    {
        public Pdf4mewordActions Pdf4meword(string connectionId) => new Pdf4mewordActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4mewordTriggers Pdf4meword(string connectionId) => new Pdf4mewordTriggers(connectionId);
    }
}