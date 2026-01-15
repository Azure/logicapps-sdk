//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Dokobitportal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DokobitportalActions([ConnectionName] string connectionId)
    {
    }

    public class DokobitportalTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Dokobitportal;

    public partial class WorkflowManagedActions
    {
        public DokobitportalActions Dokobitportal(string connectionId) => new DokobitportalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DokobitportalTriggers Dokobitportal(string connectionId) => new DokobitportalTriggers(connectionId);
    }
}