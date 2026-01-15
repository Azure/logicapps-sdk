//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Benifex
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BenifexActions([ConnectionName] string connectionId)
    {
    }

    public class BenifexTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Benifex;

    public partial class WorkflowManagedActions
    {
        public BenifexActions Benifex(string connectionId) => new BenifexActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BenifexTriggers Benifex(string connectionId) => new BenifexTriggers(connectionId);
    }
}