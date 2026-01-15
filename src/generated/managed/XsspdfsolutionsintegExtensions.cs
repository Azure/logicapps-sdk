//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Xsspdfsolutionsinteg
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XsspdfsolutionsintegActions([ConnectionName] string connectionId)
    {
    }

    public class XsspdfsolutionsintegTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Xsspdfsolutionsinteg;

    public partial class WorkflowManagedActions
    {
        public XsspdfsolutionsintegActions Xsspdfsolutionsinteg(string connectionId) => new XsspdfsolutionsintegActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XsspdfsolutionsintegTriggers Xsspdfsolutionsinteg(string connectionId) => new XsspdfsolutionsintegTriggers(connectionId);
    }
}