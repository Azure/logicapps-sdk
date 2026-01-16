//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skypeforbiz
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkypeforbizActions([ConnectionName] string connectionId)
    {
    }

    public class SkypeforbizTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Skypeforbiz;

    public partial class WorkflowManagedActions
    {
        public SkypeforbizActions Skypeforbiz(string connectionId) => new SkypeforbizActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SkypeforbizTriggers Skypeforbiz(string connectionId) => new SkypeforbizTriggers(connectionId);
    }
}