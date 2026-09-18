//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Saphana
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SaphanaActions([ConnectionName] string connectionId)
    {
    }

    public class SaphanaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Saphana;

    public partial class WorkflowManagedActions
    {
        public SaphanaActions Saphana(string connectionId) => new SaphanaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SaphanaTriggers Saphana(string connectionId) => new SaphanaTriggers(connectionId);
    }
}