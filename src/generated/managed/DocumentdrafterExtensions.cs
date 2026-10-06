//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentdrafter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentdrafterActions([ConnectionName] string connectionId)
    {
    }

    public class DocumentdrafterTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentdrafter;

    public partial class WorkflowManagedActions
    {
        public DocumentdrafterActions Documentdrafter(string connectionId) => new DocumentdrafterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentdrafterTriggers Documentdrafter(string connectionId) => new DocumentdrafterTriggers(connectionId);
    }
}