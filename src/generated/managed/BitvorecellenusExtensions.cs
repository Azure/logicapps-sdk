//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitvorecellenus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitvorecellenusActions([ConnectionName] string connectionId)
    {
    }

    public class BitvorecellenusTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bitvorecellenus;

    public partial class WorkflowManagedActions
    {
        public BitvorecellenusActions Bitvorecellenus(string connectionId) => new BitvorecellenusActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BitvorecellenusTriggers Bitvorecellenus(string connectionId) => new BitvorecellenusTriggers(connectionId);
    }
}