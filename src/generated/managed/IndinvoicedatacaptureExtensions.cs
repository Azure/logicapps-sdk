//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Indinvoicedatacapture
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IndinvoicedatacaptureActions([ConnectionName] string connectionId)
    {
    }

    public class IndinvoicedatacaptureTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Indinvoicedatacapture;

    public partial class WorkflowManagedActions
    {
        public IndinvoicedatacaptureActions Indinvoicedatacapture(string connectionId) => new IndinvoicedatacaptureActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IndinvoicedatacaptureTriggers Indinvoicedatacapture(string connectionId) => new IndinvoicedatacaptureTriggers(connectionId);
    }
}