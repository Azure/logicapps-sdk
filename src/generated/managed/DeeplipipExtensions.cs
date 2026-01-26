//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deeplipip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeeplipipActions([ConnectionName] string connectionId)
    {
    }

    public class DeeplipipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deeplipip;

    public partial class WorkflowManagedActions
    {
        public DeeplipipActions Deeplipip(string connectionId) => new DeeplipipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DeeplipipTriggers Deeplipip(string connectionId) => new DeeplipipTriggers(connectionId);
    }
}