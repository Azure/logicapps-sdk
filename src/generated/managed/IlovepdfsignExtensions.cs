//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfsign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovepdfsignActions([ConnectionName] string connectionId)
    {
    }

    public class IlovepdfsignTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfsign;

    public partial class WorkflowManagedActions
    {
        public IlovepdfsignActions Ilovepdfsign(string connectionId) => new IlovepdfsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IlovepdfsignTriggers Ilovepdfsign(string connectionId) => new IlovepdfsignTriggers(connectionId);
    }
}