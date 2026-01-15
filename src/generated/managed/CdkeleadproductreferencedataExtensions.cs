//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cdkeleadproductreferencedata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CdkeleadproductreferencedataActions([ConnectionName] string connectionId)
    {
    }

    public class CdkeleadproductreferencedataTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Cdkeleadproductreferencedata;

    public partial class WorkflowManagedActions
    {
        public CdkeleadproductreferencedataActions Cdkeleadproductreferencedata(string connectionId) => new CdkeleadproductreferencedataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CdkeleadproductreferencedataTriggers Cdkeleadproductreferencedata(string connectionId) => new CdkeleadproductreferencedataTriggers(connectionId);
    }
}