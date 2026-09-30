//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signinghub
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigninghubActions([ConnectionName] string connectionId)
    {
    }

    public class SigninghubTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signinghub;

    public partial class WorkflowManagedActions
    {
        public SigninghubActions Signinghub(string connectionId) => new SigninghubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SigninghubTriggers Signinghub(string connectionId) => new SigninghubTriggers(connectionId);
    }
}