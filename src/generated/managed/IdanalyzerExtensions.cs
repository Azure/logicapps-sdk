//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Idanalyzer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IdanalyzerActions([ConnectionName] string connectionId)
    {
    }

    public class IdanalyzerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Idanalyzer;

    public partial class WorkflowManagedActions
    {
        public IdanalyzerActions Idanalyzer(string connectionId) => new IdanalyzerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IdanalyzerTriggers Idanalyzer(string connectionId) => new IdanalyzerTriggers(connectionId);
    }
}