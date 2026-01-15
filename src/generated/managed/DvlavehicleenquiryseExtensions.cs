//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Dvlavehicleenquiryse
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DvlavehicleenquiryseActions([ConnectionName] string connectionId)
    {
    }

    public class DvlavehicleenquiryseTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Dvlavehicleenquiryse;

    public partial class WorkflowManagedActions
    {
        public DvlavehicleenquiryseActions Dvlavehicleenquiryse(string connectionId) => new DvlavehicleenquiryseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DvlavehicleenquiryseTriggers Dvlavehicleenquiryse(string connectionId) => new DvlavehicleenquiryseTriggers(connectionId);
    }
}