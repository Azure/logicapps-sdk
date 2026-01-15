//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cloudconvert
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudconvertActions([ConnectionName] string connectionId)
    {
    }

    public class CloudconvertTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Cloudconvert;

    public partial class WorkflowManagedActions
    {
        public CloudconvertActions Cloudconvert(string connectionId) => new CloudconvertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudconvertTriggers Cloudconvert(string connectionId) => new CloudconvertTriggers(connectionId);
    }
}