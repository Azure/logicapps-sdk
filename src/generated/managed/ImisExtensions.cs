//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Imis
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImisActions([ConnectionName] string connectionId)
    {
    }

    public class ImisTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Imis;

    public partial class WorkflowManagedActions
    {
        public ImisActions Imis(string connectionId) => new ImisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImisTriggers Imis(string connectionId) => new ImisTriggers(connectionId);
    }
}