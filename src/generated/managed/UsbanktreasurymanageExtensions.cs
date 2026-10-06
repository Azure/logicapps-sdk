//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Usbanktreasurymanage
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UsbanktreasurymanageActions([ConnectionName] string connectionId)
    {
    }

    public class UsbanktreasurymanageTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Usbanktreasurymanage;

    public partial class WorkflowManagedActions
    {
        public UsbanktreasurymanageActions Usbanktreasurymanage(string connectionId) => new UsbanktreasurymanageActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UsbanktreasurymanageTriggers Usbanktreasurymanage(string connectionId) => new UsbanktreasurymanageTriggers(connectionId);
    }
}