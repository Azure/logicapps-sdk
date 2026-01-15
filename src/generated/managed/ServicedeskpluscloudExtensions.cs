//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Servicedeskpluscloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServicedeskpluscloudActions([ConnectionName] string connectionId)
    {
    }

    public class ServicedeskpluscloudTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Servicedeskpluscloud;

    public partial class WorkflowManagedActions
    {
        public ServicedeskpluscloudActions Servicedeskpluscloud(string connectionId) => new ServicedeskpluscloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ServicedeskpluscloudTriggers Servicedeskpluscloud(string connectionId) => new ServicedeskpluscloudTriggers(connectionId);
    }
}