//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xssqrcodesolutions
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XssqrcodesolutionsActions([ConnectionName] string connectionId)
    {
    }

    public class XssqrcodesolutionsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xssqrcodesolutions;

    public partial class WorkflowManagedActions
    {
        public XssqrcodesolutionsActions Xssqrcodesolutions(string connectionId) => new XssqrcodesolutionsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XssqrcodesolutionsTriggers Xssqrcodesolutions(string connectionId) => new XssqrcodesolutionsTriggers(connectionId);
    }
}