//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodiangeneral
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodiangeneralActions([ConnectionName] string connectionId)
    {
    }

    public class EncodiangeneralTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodiangeneral;

    public partial class WorkflowManagedActions
    {
        public EncodiangeneralActions Encodiangeneral(string connectionId) => new EncodiangeneralActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodiangeneralTriggers Encodiangeneral(string connectionId) => new EncodiangeneralTriggers(connectionId);
    }
}