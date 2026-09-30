//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ipqsfraudandriskscor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IpqsfraudandriskscorActions([ConnectionName] string connectionId)
    {
    }

    public class IpqsfraudandriskscorTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ipqsfraudandriskscor;

    public partial class WorkflowManagedActions
    {
        public IpqsfraudandriskscorActions Ipqsfraudandriskscor(string connectionId) => new IpqsfraudandriskscorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IpqsfraudandriskscorTriggers Ipqsfraudandriskscor(string connectionId) => new IpqsfraudandriskscorTriggers(connectionId);
    }
}