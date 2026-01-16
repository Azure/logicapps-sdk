//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Exactonlinepremium
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExactonlinepremiumActions([ConnectionName] string connectionId)
    {
    }

    public class ExactonlinepremiumTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Exactonlinepremium;

    public partial class WorkflowManagedActions
    {
        public ExactonlinepremiumActions Exactonlinepremium(string connectionId) => new ExactonlinepremiumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExactonlinepremiumTriggers Exactonlinepremium(string connectionId) => new ExactonlinepremiumTriggers(connectionId);
    }
}