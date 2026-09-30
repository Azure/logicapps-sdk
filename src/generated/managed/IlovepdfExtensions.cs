//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovepdfActions([ConnectionName] string connectionId)
    {
    }

    public class IlovepdfTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdf;

    public partial class WorkflowManagedActions
    {
        public IlovepdfActions Ilovepdf(string connectionId) => new IlovepdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IlovepdfTriggers Ilovepdf(string connectionId) => new IlovepdfTriggers(connectionId);
    }
}