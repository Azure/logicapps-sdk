//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tpcportal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TpcportalActions([ConnectionName] string connectionId)
    {
    }

    public class TpcportalTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tpcportal;

    public partial class WorkflowManagedActions
    {
        public TpcportalActions Tpcportal(string connectionId) => new TpcportalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TpcportalTriggers Tpcportal(string connectionId) => new TpcportalTriggers(connectionId);
    }
}