//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Firmaradar
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FirmaradarActions([ConnectionName] string connectionId)
    {
    }

    public class FirmaradarTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Firmaradar;

    public partial class WorkflowManagedActions
    {
        public FirmaradarActions Firmaradar(string connectionId) => new FirmaradarActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FirmaradarTriggers Firmaradar(string connectionId) => new FirmaradarTriggers(connectionId);
    }
}