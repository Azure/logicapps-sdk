//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meai
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meaiActions([ConnectionName] string connectionId)
    {
    }

    public class Pdf4meaiTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meai;

    public partial class WorkflowManagedActions
    {
        public Pdf4meaiActions Pdf4meai(string connectionId) => new Pdf4meaiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meaiTriggers Pdf4meai(string connectionId) => new Pdf4meaiTriggers(connectionId);
    }
}