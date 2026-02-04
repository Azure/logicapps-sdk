//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cdkeleadsalescustomers
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CdkeleadsalescustomersActions([ConnectionName] string connectionId)
    {
    }

    public class CdkeleadsalescustomersTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cdkeleadsalescustomers;

    public partial class WorkflowManagedActions
    {
        public CdkeleadsalescustomersActions Cdkeleadsalescustomers(string connectionId) => new CdkeleadsalescustomersActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CdkeleadsalescustomersTriggers Cdkeleadsalescustomers(string connectionId) => new CdkeleadsalescustomersTriggers(connectionId);
    }
}