//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enadoc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnadocActions([ConnectionName] string connectionId)
    {
    }

    public class EnadocTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Enadoc;

    public partial class WorkflowManagedActions
    {
        public EnadocActions Enadoc(string connectionId) => new EnadocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EnadocTriggers Enadoc(string connectionId) => new EnadocTriggers(connectionId);
    }
}