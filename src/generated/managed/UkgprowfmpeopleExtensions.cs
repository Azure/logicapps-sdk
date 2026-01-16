//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ukgprowfmpeople
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UkgprowfmpeopleActions([ConnectionName] string connectionId)
    {
    }

    public class UkgprowfmpeopleTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ukgprowfmpeople;

    public partial class WorkflowManagedActions
    {
        public UkgprowfmpeopleActions Ukgprowfmpeople(string connectionId) => new UkgprowfmpeopleActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UkgprowfmpeopleTriggers Ukgprowfmpeople(string connectionId) => new UkgprowfmpeopleTriggers(connectionId);
    }
}