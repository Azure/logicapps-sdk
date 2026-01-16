//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodianconvert
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianconvertActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianconvertTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodianconvert;

    public partial class WorkflowManagedActions
    {
        public EncodianconvertActions Encodianconvert(string connectionId) => new EncodianconvertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianconvertTriggers Encodianconvert(string connectionId) => new EncodianconvertTriggers(connectionId);
    }
}