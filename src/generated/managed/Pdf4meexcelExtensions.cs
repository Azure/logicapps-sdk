//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meexcel
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meexcelActions([ConnectionName] string connectionId)
    {
    }

    public class Pdf4meexcelTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meexcel;

    public partial class WorkflowManagedActions
    {
        public Pdf4meexcelActions Pdf4meexcel(string connectionId) => new Pdf4meexcelActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meexcelTriggers Pdf4meexcel(string connectionId) => new Pdf4meexcelTriggers(connectionId);
    }
}