//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodianpdf
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianpdfActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianpdfTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodianpdf;

    public partial class WorkflowManagedActions
    {
        public EncodianpdfActions Encodianpdf(string connectionId) => new EncodianpdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianpdfTriggers Encodianpdf(string connectionId) => new EncodianpdfTriggers(connectionId);
    }
}