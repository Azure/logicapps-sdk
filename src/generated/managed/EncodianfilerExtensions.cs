//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Encodianfiler
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianfilerActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianfilerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Encodianfiler;

    public partial class WorkflowManagedActions
    {
        public EncodianfilerActions Encodianfiler(string connectionId) => new EncodianfilerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianfilerTriggers Encodianfiler(string connectionId) => new EncodianfilerTriggers(connectionId);
    }
}