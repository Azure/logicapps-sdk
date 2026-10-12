//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cdkdrivecustomer
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CdkdrivecustomerActions([ConnectionName] string connectionId)
    {
    }

    public class CdkdrivecustomerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cdkdrivecustomer;

    public partial class WorkflowManagedActions
    {
        public CdkdrivecustomerActions Cdkdrivecustomer(string connectionId) => new CdkdrivecustomerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CdkdrivecustomerTriggers Cdkdrivecustomer(string connectionId) => new CdkdrivecustomerTriggers(connectionId);
    }
}