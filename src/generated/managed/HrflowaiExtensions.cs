//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hrflowai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HrflowaiActions([ConnectionName] string connectionId)
    {
    }

    public class HrflowaiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hrflowai;

    public partial class WorkflowManagedActions
    {
        public HrflowaiActions Hrflowai(string connectionId) => new HrflowaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HrflowaiTriggers Hrflowai(string connectionId) => new HrflowaiTriggers(connectionId);
    }
}