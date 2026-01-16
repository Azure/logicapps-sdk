//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ukgprowfmtimekeeping
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UkgprowfmtimekeepingActions([ConnectionName] string connectionId)
    {
    }

    public class UkgprowfmtimekeepingTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ukgprowfmtimekeeping;

    public partial class WorkflowManagedActions
    {
        public UkgprowfmtimekeepingActions Ukgprowfmtimekeeping(string connectionId) => new UkgprowfmtimekeepingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UkgprowfmtimekeepingTriggers Ukgprowfmtimekeeping(string connectionId) => new UkgprowfmtimekeepingTriggers(connectionId);
    }
}