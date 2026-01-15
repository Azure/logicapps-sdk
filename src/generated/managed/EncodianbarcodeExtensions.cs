//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Encodianbarcode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianbarcodeActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianbarcodeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Encodianbarcode;

    public partial class WorkflowManagedActions
    {
        public EncodianbarcodeActions Encodianbarcode(string connectionId) => new EncodianbarcodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianbarcodeTriggers Encodianbarcode(string connectionId) => new EncodianbarcodeTriggers(connectionId);
    }
}