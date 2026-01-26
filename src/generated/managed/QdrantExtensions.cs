//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Qdrant
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class QdrantActions([ConnectionName] string connectionId)
    {
    }

    public class QdrantTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Qdrant;

    public partial class WorkflowManagedActions
    {
        public QdrantActions Qdrant(string connectionId) => new QdrantActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public QdrantTriggers Qdrant(string connectionId) => new QdrantTriggers(connectionId);
    }
}