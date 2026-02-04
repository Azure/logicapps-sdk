//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ups
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UpsActions([ConnectionName] string connectionId)
    {
    }

    public class UpsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ups;

    public partial class WorkflowManagedActions
    {
        public UpsActions Ups(string connectionId) => new UpsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UpsTriggers Ups(string connectionId) => new UpsTriggers(connectionId);
    }
}