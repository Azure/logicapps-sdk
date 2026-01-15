//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Encodianexcel
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianexcelActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianexcelTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Encodianexcel;

    public partial class WorkflowManagedActions
    {
        public EncodianexcelActions Encodianexcel(string connectionId) => new EncodianexcelActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianexcelTriggers Encodianexcel(string connectionId) => new EncodianexcelTriggers(connectionId);
    }
}