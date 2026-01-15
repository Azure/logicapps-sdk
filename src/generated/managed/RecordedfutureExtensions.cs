//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Recordedfuture
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RecordedfutureActions([ConnectionName] string connectionId)
    {
    }

    public class RecordedfutureTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Recordedfuture;

    public partial class WorkflowManagedActions
    {
        public RecordedfutureActions Recordedfuture(string connectionId) => new RecordedfutureActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RecordedfutureTriggers Recordedfuture(string connectionId) => new RecordedfutureTriggers(connectionId);
    }
}