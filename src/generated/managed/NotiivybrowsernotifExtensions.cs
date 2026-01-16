//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Notiivybrowsernotif
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NotiivybrowsernotifActions([ConnectionName] string connectionId)
    {
    }

    public class NotiivybrowsernotifTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Notiivybrowsernotif;

    public partial class WorkflowManagedActions
    {
        public NotiivybrowsernotifActions Notiivybrowsernotif(string connectionId) => new NotiivybrowsernotifActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NotiivybrowsernotifTriggers Notiivybrowsernotif(string connectionId) => new NotiivybrowsernotifTriggers(connectionId);
    }
}