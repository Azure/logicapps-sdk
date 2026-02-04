//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlebooksip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglebooksipActions([ConnectionName] string connectionId)
    {
    }

    public class GooglebooksipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlebooksip;

    public partial class WorkflowManagedActions
    {
        public GooglebooksipActions Googlebooksip(string connectionId) => new GooglebooksipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglebooksipTriggers Googlebooksip(string connectionId) => new GooglebooksipTriggers(connectionId);
    }
}