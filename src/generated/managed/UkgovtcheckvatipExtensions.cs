//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ukgovtcheckvatip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UkgovtcheckvatipActions([ConnectionName] string connectionId)
    {
    }

    public class UkgovtcheckvatipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ukgovtcheckvatip;

    public partial class WorkflowManagedActions
    {
        public UkgovtcheckvatipActions Ukgovtcheckvatip(string connectionId) => new UkgovtcheckvatipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UkgovtcheckvatipTriggers Ukgovtcheckvatip(string connectionId) => new UkgovtcheckvatipTriggers(connectionId);
    }
}