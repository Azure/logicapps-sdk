//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotengagementsv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotengagementsv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Hubspotengagementsv2Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotengagementsv2;

    public partial class WorkflowManagedActions
    {
        public Hubspotengagementsv2Actions Hubspotengagementsv2(string connectionId) => new Hubspotengagementsv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Hubspotengagementsv2Triggers Hubspotengagementsv2(string connectionId) => new Hubspotengagementsv2Triggers(connectionId);
    }
}