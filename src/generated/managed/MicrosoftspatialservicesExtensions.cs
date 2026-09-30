//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftspatialservices
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftspatialservicesActions([ConnectionName] string connectionId)
    {
    }

    public class MicrosoftspatialservicesTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftspatialservices;

    public partial class WorkflowManagedActions
    {
        public MicrosoftspatialservicesActions Microsoftspatialservices(string connectionId) => new MicrosoftspatialservicesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftspatialservicesTriggers Microsoftspatialservices(string connectionId) => new MicrosoftspatialservicesTriggers(connectionId);
    }
}