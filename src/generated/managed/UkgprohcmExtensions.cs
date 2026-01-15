//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Ukgprohcm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UkgprohcmActions([ConnectionName] string connectionId)
    {
    }

    public class UkgprohcmTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Ukgprohcm;

    public partial class WorkflowManagedActions
    {
        public UkgprohcmActions Ukgprohcm(string connectionId) => new UkgprohcmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UkgprohcmTriggers Ukgprohcm(string connectionId) => new UkgprohcmTriggers(connectionId);
    }
}