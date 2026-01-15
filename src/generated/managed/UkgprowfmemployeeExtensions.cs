//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Ukgprowfmemployee
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UkgprowfmemployeeActions([ConnectionName] string connectionId)
    {
    }

    public class UkgprowfmemployeeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Ukgprowfmemployee;

    public partial class WorkflowManagedActions
    {
        public UkgprowfmemployeeActions Ukgprowfmemployee(string connectionId) => new UkgprowfmemployeeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UkgprowfmemployeeTriggers Ukgprowfmemployee(string connectionId) => new UkgprowfmemployeeTriggers(connectionId);
    }
}