//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hivecpqproductconfig
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HivecpqproductconfigActions([ConnectionName] string connectionId)
    {
    }

    public class HivecpqproductconfigTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hivecpqproductconfig;

    public partial class WorkflowManagedActions
    {
        public HivecpqproductconfigActions Hivecpqproductconfig(string connectionId) => new HivecpqproductconfigActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HivecpqproductconfigTriggers Hivecpqproductconfig(string connectionId) => new HivecpqproductconfigTriggers(connectionId);
    }
}