//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Encodiandocumentmanager
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodiandocumentmanagerActions([ConnectionName] string connectionId)
    {
    }

    public class EncodiandocumentmanagerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Encodiandocumentmanager;

    public partial class WorkflowManagedActions
    {
        public EncodiandocumentmanagerActions Encodiandocumentmanager(string connectionId) => new EncodiandocumentmanagerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodiandocumentmanagerTriggers Encodiandocumentmanager(string connectionId) => new EncodiandocumentmanagerTriggers(connectionId);
    }
}