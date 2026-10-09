//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xpertdoc
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XpertdocActions([ConnectionName] string connectionId)
    {
    }

    public class XpertdocTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xpertdoc;

    public partial class WorkflowManagedActions
    {
        public XpertdocActions Xpertdoc(string connectionId) => new XpertdocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XpertdocTriggers Xpertdoc(string connectionId) => new XpertdocTriggers(connectionId);
    }
}