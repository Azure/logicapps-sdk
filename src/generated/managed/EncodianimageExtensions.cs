//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Encodianimage
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EncodianimageActions([ConnectionName] string connectionId)
    {
    }

    public class EncodianimageTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Encodianimage;

    public partial class WorkflowManagedActions
    {
        public EncodianimageActions Encodianimage(string connectionId) => new EncodianimageActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EncodianimageTriggers Encodianimage(string connectionId) => new EncodianimageTriggers(connectionId);
    }
}