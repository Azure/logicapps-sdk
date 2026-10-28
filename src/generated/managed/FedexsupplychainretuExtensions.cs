//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fedexsupplychainretu
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FedexsupplychainretuActions([ConnectionName] string connectionId)
    {
    }

    public class FedexsupplychainretuTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fedexsupplychainretu;

    public partial class WorkflowManagedActions
    {
        public FedexsupplychainretuActions Fedexsupplychainretu(string connectionId) => new FedexsupplychainretuActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FedexsupplychainretuTriggers Fedexsupplychainretu(string connectionId) => new FedexsupplychainretuTriggers(connectionId);
    }
}