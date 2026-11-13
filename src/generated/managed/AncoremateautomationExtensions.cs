//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ancoremateautomation
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AncoremateautomationActions([ConnectionName] string connectionId)
    {
    }

    public class AncoremateautomationTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ancoremateautomation;

    public partial class WorkflowManagedActions
    {
        public AncoremateautomationActions Ancoremateautomation(string connectionId) => new AncoremateautomationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AncoremateautomationTriggers Ancoremateautomation(string connectionId) => new AncoremateautomationTriggers(connectionId);
    }
}