//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Financialedgenxtquer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinancialedgenxtquerActions([ConnectionName] string connectionId)
    {
    }

    public class FinancialedgenxtquerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Financialedgenxtquer;

    public partial class WorkflowManagedActions
    {
        public FinancialedgenxtquerActions Financialedgenxtquer(string connectionId) => new FinancialedgenxtquerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinancialedgenxtquerTriggers Financialedgenxtquer(string connectionId) => new FinancialedgenxtquerTriggers(connectionId);
    }
}