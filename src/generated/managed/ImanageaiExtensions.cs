//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageaiActions([ConnectionName] string connectionId)
    {
    }

    public class ImanageaiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imanageai;

    public partial class WorkflowManagedActions
    {
        public ImanageaiActions Imanageai(string connectionId) => new ImanageaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImanageaiTriggers Imanageai(string connectionId) => new ImanageaiTriggers(connectionId);
    }
}